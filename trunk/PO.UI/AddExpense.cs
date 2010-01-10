using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PO.Types.DataSets;
using PO.Services.BusinessObjects;
using PersonelOrganizer.Util;

namespace PersonelOrganizer
{
    public partial class AddExpense : Form
    {
        EXPENSE_BILLDataSet dsExpense;
        INSTALLMENTDataSet dsInstallment;
        public AddExpense()
        {
            InitializeComponent();
        }

        private void AddExpense_Load(object sender, EventArgs e)
        {
            ddlPaymentType.SelectedIndex = 0;
            ddlInstallment.SelectedIndex = 0;
            LoadExpenseCategory();
            LoadCreditCards();
            if (POGlobals.ExpenseID != Guid.Empty)
                LoadIncomeInfo();
        }

        private void ddlPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPaymentType.SelectedIndex == 1)
            {
                lblCreditCard.Visible = true;
                ddlCreditCard.Visible = true;
                lblInstallment.Visible = true;
                ddlInstallment.Visible = true;
            }
            else
            {
                lblCreditCard.Visible = false;
                ddlCreditCard.Visible = false;
                lblInstallment.Visible = false;
                ddlInstallment.Visible = false;
                lblInstallmentNo.Visible = false;
                txtInstallmentNo.Visible = false;
                lblTotalAmount.Visible = false;
                txtTotalAmount.Visible = false;
                ddlInstallment.SelectedIndex = 0;
            }
        }

        private void CheckCashCreditCard()
        {
            if (ddlInstallment.SelectedIndex == 1)
            {
                lblInstallmentNo.Visible = true;
                txtInstallmentNo.Visible = true;
                lblTotalAmount.Visible = true;
                txtTotalAmount.Visible = true;
            }
            else
            {
                lblInstallmentNo.Visible = false;
                txtInstallmentNo.Visible = false;
                lblTotalAmount.Visible = false;
                txtTotalAmount.Visible = false;
            }
        }

        private void LoadCreditCards()
        {
            string card = String.Empty;
            Guid creditCardID = Guid.Empty;
            ddlCreditCard.Items.Clear();
            DataTable dt = new CreditCardBS().SelectByUserID(POGlobals.UserID);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["BankName"] != DBNull.Value)
                        card = row["BankName"].ToString();
                    if (row["CardNumber"] != DBNull.Value)
                        card += " - " + row["CardNumber"].ToString();
                    if (row["CreditCardID"] != DBNull.Value)
                        creditCardID = new Guid(row["CreditCardID"].ToString());
                    ListItem item = new ListItem(card, creditCardID);
                    ddlCreditCard.Items.Add(item);
                }
                ddlCreditCard.SelectedIndex = 0;
            }
            else
            {
                ListItem item = new ListItem("There is no defined credit card", Guid.Empty);
                ddlCreditCard.Items.Add(item);
            }
        }

        private void LoadExpenseCategory()
        {
            TT_EXPENSE_CATEGORYDataSet ds = new ExpenseCategoryBS().SelectAll();
            foreach (TT_EXPENSE_CATEGORYDataSet.TT_EXPENSE_CATEGORYRow row in ds.TT_EXPENSE_CATEGORY.Rows)
            {
                ddlExpenseCategory.Items.Add(row.ExpenseCategoryName);
            }
            if (ds.TT_EXPENSE_CATEGORY.Rows.Count > 0)
                ddlExpenseCategory.SelectedIndex = 0;
        }

        private void ddlInstallment_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCashCreditCard();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInputCorrect())
                return;

            SaveExpense();
        }

        private bool CheckInputCorrect()
        {
            decimal totalAmount = 0;

            if (String.IsNullOrEmpty(txtSubject.Text))
            {
                txtSubject.BackColor = Color.Red;
                MessageBox.Show("Please enter subject!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubject.BackColor = Color.White;
                return false;
            }
            if (String.IsNullOrEmpty(txtAmount.Text))
            {
                txtAmount.BackColor = Color.Red;
                MessageBox.Show("Please enter amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.BackColor = Color.White;
                return false;
            }
            if (ddlInstallment.SelectedIndex == 1)
            {
                if (String.IsNullOrEmpty(txtInstallmentNo.Text))
                {
                    txtInstallmentNo.BackColor = Color.Red;
                    MessageBox.Show("Please enter InstallmentNo!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInstallmentNo.BackColor = Color.White;
                    return false;
                }
                if (String.IsNullOrEmpty(txtTotalAmount.Text))
                {
                    txtTotalAmount.BackColor = Color.Red;
                    MessageBox.Show("Please enter TotalAmount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTotalAmount.BackColor = Color.White;
                    return false;
                }
            }
            if (ddlInstallment.SelectedIndex == 1)
            {
                totalAmount = Convert.ToInt32(txtInstallmentNo.Text) * Convert.ToDecimal(txtAmount.Text);
                if (Convert.ToDecimal(txtTotalAmount.Text) > totalAmount)
                {
                    MessageBox.Show("Please correct installment no, amount or total amount. Because Total Amout is more than sum of all installments!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (ddlPaymentType.SelectedIndex == 1)
            {
                CREDIT_CARDDataSet ds = new CreditCardBS().SelectByCreditCardID(((ListItem)ddlCreditCard.SelectedItem).Value);
                int usedLimit = new ExpenseBillBS().SelectCreditCardID(((ListItem)ddlCreditCard.SelectedItem).Value);
                if (ds.CREDIT_CARD.Rows.Count > 0)
                {
                    decimal leftLimit = ds.CREDIT_CARD[0].Limit - usedLimit;
                    if (ddlPaymentType.SelectedIndex == 0 ||
                        (ddlPaymentType.SelectedIndex == 1 && ddlInstallment.SelectedIndex == 0) || ddlInstallment.SelectedIndex == 1)
                        return LimitExceedMessage(leftLimit);
                }
            }
            return true;
        }

        private bool LimitExceedMessage(decimal leftLimit)
        {
            if (Convert.ToDecimal(txtAmount.Text) > leftLimit)
            {
                MessageBox.Show("Total debt exceeds the limit for credit card", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private void SaveExpense()
        {
            try
            {
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal leftTotal = amount;

                if (ddlInstallment.SelectedIndex == 1)
                    leftTotal = Convert.ToDecimal(txtTotalAmount.Text);

                dsInstallment = new INSTALLMENTDataSet();
                INSTALLMENTDataSet.INSTALLMENTRow row = dsInstallment.INSTALLMENT.NewINSTALLMENTRow();
                row.InstallmentID = Guid.NewGuid();
                row.NumberOfInstallment = 1;

                if (ddlPaymentType.SelectedIndex == 1)
                {
                    if (ddlInstallment.SelectedIndex == 1)
                    {
                        row.NumberOfInstallment = Convert.ToInt32(txtInstallmentNo.Text);
                        row.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                    }
                    else
                        row.TotalAmount = Convert.ToDecimal(txtAmount.Text);
                    dsInstallment.INSTALLMENT.AddINSTALLMENTRow(row);
                }

                dsExpense = new EXPENSE_BILLDataSet();
                for (int i = 0; i < row.NumberOfInstallment; i++)
                {
                    EXPENSE_BILLDataSet.EXPENSE_BILLRow rowExpense = dsExpense.EXPENSE_BILL.NewEXPENSE_BILLRow();
                    rowExpense.ExpenseBillID = Guid.NewGuid();
                    rowExpense.UserID = POGlobals.UserID;
                    rowExpense.Subject = txtSubject.Text;
                    if (leftTotal >= amount)
                        rowExpense.Amount = amount;
                    else
                        rowExpense.Amount = leftTotal;
                    rowExpense.ExpenseCategory = ddlExpenseCategory.SelectedIndex + 1;
                    rowExpense.DueDate = dateDueDate.Value.AddMonths(i);
                    if (ddlPaymentType.SelectedIndex == 1)
                    {
                        rowExpense.InstallmentID = row.InstallmentID;
                        if (ddlCreditCard.Items.Count > 0)
                        {
                            rowExpense.CreditCardID = ((ListItem)ddlCreditCard.SelectedItem).Value;
                        }
                    }
                    dsExpense.EXPENSE_BILL.AddEXPENSE_BILLRow(rowExpense);
                    leftTotal = leftTotal - amount;
                }

                if (POGlobals.InstallmentID != Guid.Empty)
                    new ExpenseBillBS().DeleteByInstallmentID(POGlobals.InstallmentID);

                new InstallmentBS().Save(dsInstallment);
                new ExpenseBillBS().Save(dsExpense);

                MessageBox.Show("Expense is saved succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigateEventList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Expense not saved, Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavigateEventList()
        {
            MainForm main = (MainForm)this.MdiParent;
            main.OpenExpenseList();
        }

        private void LoadIncomeInfo()
        {
            dsExpense = new ExpenseBillBS().SelectDataSetByExpenseID(POGlobals.ExpenseID);
            dsInstallment = new InstallmentBS().SelectByInstallmentID(POGlobals.InstallmentID);

            EXPENSE_BILLDataSet.EXPENSE_BILLRow rowExpense = dsExpense.EXPENSE_BILL[0];
            INSTALLMENTDataSet.INSTALLMENTRow rowIns = dsInstallment.INSTALLMENT[0];
            if (!rowExpense.IsAmountNull())
                txtAmount.Text = rowExpense.Amount.ToString();
            txtSubject.Text = rowExpense.Subject;
            if (!rowExpense.IsCreditCardIDNull())
            {
                for (int i = 0; i < ddlCreditCard.Items.Count; i++)
                {
                    if (rowExpense.CreditCardID == ((ListItem)ddlCreditCard.Items[i]).Value)
                    {
                        ddlCreditCard.SelectedIndex = i;
                        break;
                    }
                }
            }
            if (!rowExpense.IsDueDateNull())
                dateDueDate.Value = rowExpense.DueDate;
            if (!rowExpense.IsExpenseCategoryNull())
                ddlExpenseCategory.SelectedIndex = rowExpense.ExpenseCategory - 1;
            if (!rowExpense.IsInstallmentIDNull())
            {
                if (!rowIns.IsNumberOfInstallmentNull())
                    txtInstallmentNo.Text = rowIns.NumberOfInstallment.ToString();
                if (!rowIns.IsTotalAmountNull())
                    txtTotalAmount.Text = rowIns.TotalAmount.ToString();
                ddlInstallment.SelectedIndex = 1;
                ddlPaymentType.SelectedIndex = 1;
            }
        }
    }
}
