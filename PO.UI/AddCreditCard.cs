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
    public partial class AddCreditCard : Form
    {
        CREDIT_CARDDataSet dsCreditCard;
        public AddCreditCard()
        {
            InitializeComponent();
        }

        private void AddCreditCard_Load(object sender, EventArgs e)
        {
            LoadBanks();
        }

        private void LoadBanks()
        {
            TT_BANKDataSet ds = new BankBS().SelectAll();
            foreach (TT_BANKDataSet.TT_BANKRow row in ds.TT_BANK.Rows)
            {
                ddlBank.Items.Add(row.BankName);
            }
            if (ds.TT_BANK.Rows.Count > 0)
                ddlBank.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInputCorrect())
                return;

            if (POGlobals.CreditCard == Guid.Empty)
                SaveCreditCard();
            else
                UpdateCreditCard();
        }

        private bool CheckInputCorrect()
        {
            if (String.IsNullOrEmpty(txtCardNumber.Text))
            {
                txtCardNumber.BackColor = Color.Red;
                MessageBox.Show("Please enter card number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCardNumber.BackColor = Color.White;
                return false;
            }
            return true;
        }

        private void SaveCreditCard()
        {
            try
            {
                dsCreditCard = new CREDIT_CARDDataSet();
                CREDIT_CARDDataSet.CREDIT_CARDRow row = dsCreditCard.CREDIT_CARD.NewCREDIT_CARDRow();
                row.CreditCardID = Guid.NewGuid();
                row.UserID = POGlobals.UserID;
                row.BankID = ddlBank.SelectedIndex + 1;
                row.CardNumber = txtCardNumber.Text;
                if (!String.IsNullOrEmpty(txtLimit.Text))
                    row.Limit = Convert.ToDecimal(txtLimit.Text);
                row.CurrentIssueDate = dateCID.Value;
                row.FutureIssueDate = dateFID.Value;
                row.CurrentDueDate = dateCDD.Value;
                row.FutureDueDate = dateFDD.Value;
                dsCreditCard.CREDIT_CARD.AddCREDIT_CARDRow(row);
                new CreditCardBS().Save(dsCreditCard);
                MessageBox.Show("Credit Card is saved succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigateEventList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Credit Card not saved, Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCreditCard()
        {
            try
            {
                CREDIT_CARDDataSet.CREDIT_CARDRow row = dsCreditCard.CREDIT_CARD[0];
                row.BankID = ddlBank.SelectedIndex + 1;
                row.CardNumber = txtCardNumber.Text;
                if (!String.IsNullOrEmpty(txtLimit.Text))
                    row.Limit = Convert.ToDecimal(txtLimit.Text);
                row.CurrentIssueDate = dateCID.Value;
                row.FutureIssueDate = dateFID.Value;
                row.CurrentDueDate = dateCDD.Value;
                row.FutureDueDate = dateFDD.Value;
                new CreditCardBS().Save(dsCreditCard);
                MessageBox.Show("Credit Card is updated succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigateEventList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Event not updated, Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavigateEventList()
        {
            MainForm main = (MainForm)this.MdiParent;
            main.OpenCreditCardList();
        }
    }
}
