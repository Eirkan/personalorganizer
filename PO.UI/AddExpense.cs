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
        }

        private void ddlPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPaymentType.SelectedIndex == 1)
            {
                lblCreditCard.Visible = true;
                ddlCreditCard.Visible = true;
                lblInstallment.Visible = true;
                ddlInstallment.Visible = true;
                LoadCreditCards();
            }
            else
            {
                lblCreditCard.Visible = false;
                ddlCreditCard.Visible = false;
                lblInstallment.Visible = false;
                ddlInstallment.Visible = false;
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
            txtTotalAmount.Text = String.Empty;
            txtInstallmentNo.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInputCorrect())
                return;

            if (POGlobals.ExpenseID == Guid.Empty)
                SaveExpense();
            else
                UpdateExpense();
        }

        private bool CheckInputCorrect()
        {
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
            return true;
        }

        private void SaveExpense()
        {
            try
            {
                dsInstallment = new INSTALLMENTDataSet();
                INSTALLMENTDataSet.INSTALLMENTRow row = dsInstallment.INSTALLMENT.NewINSTALLMENTRow();
                row.InstallmentID = Guid.NewGuid();
                row.NumberOfInstallment = Convert.ToInt32(txtInstallmentNo.Text);
                row.TotalAmount = Convert.ToDecimal(txtAmount.Text);
                dsInstallment.INSTALLMENT.AddINSTALLMENTRow(row);

                dsExpense = new EXPENSE_BILLDataSet();
                EXPENSE_BILLDataSet.EXPENSE_BILLRow rowExpense = dsExpense.EXPENSE_BILL.NewEXPENSE_BILLRow();
                rowExpense.ExpenseBillID = Guid.NewGuid();
                rowExpense.Subject = txtSubject.Text;
                rowExpense.Amount = Convert.ToDecimal(txtAmount.Text);
                rowExpense.ExpenseCategory = ddlExpenseCategory.SelectedIndex + 1;
                rowExpense.DueDate = dateDueDate.Value;
                if (ddlCreditCard.Items.Count > 0)
                {
                    rowExpense.CreditCardID = ((ListItem)ddlCreditCard.SelectedItem).Value;
                }
                if (ddlInstallment.SelectedIndex == 1)
                {
                    row.InstallmentID = row.InstallmentID;
                }
                dsExpense.EXPENSE_BILL.AddEXPENSE_BILLRow(rowExpense);

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

        private void UpdateExpense()
        {
            try
            {
                INSTALLMENTDataSet.INSTALLMENTRow row = dsInstallment.INSTALLMENT[0];
                row.InstallmentID = Guid.NewGuid();
                row.NumberOfInstallment = Convert.ToInt32(txtInstallmentNo.Text);
                row.TotalAmount = Convert.ToDecimal(txtAmount.Text);

                dsExpense = new EXPENSE_BILLDataSet();
                EXPENSE_BILLDataSet.EXPENSE_BILLRow rowExpense = dsExpense.EXPENSE_BILL[0];
                rowExpense.ExpenseBillID = Guid.NewGuid();
                rowExpense.Subject = txtSubject.Text;
                rowExpense.Amount = Convert.ToDecimal(txtAmount.Text);
                rowExpense.ExpenseCategory = ddlExpenseCategory.SelectedIndex + 1;
                rowExpense.DueDate = dateDueDate.Value;
                if (ddlCreditCard.Items.Count > 0)
                {
                    rowExpense.CreditCardID = ((ListItem)ddlCreditCard.SelectedItem).Value;
                }
                if (ddlInstallment.SelectedIndex == 1)
                {
                    row.InstallmentID = row.InstallmentID;
                }

                new InstallmentBS().Save(dsInstallment);
                new ExpenseBillBS().Save(dsExpense);
                MessageBox.Show("Expense is updated succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigateEventList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Expense not updated, Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }
    }
}
