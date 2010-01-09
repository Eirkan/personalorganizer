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
    public partial class AddIncome : Form
    {
        INCOMEDataSet dsIncome;
        public AddIncome()
        {
            InitializeComponent();
        }

        private void AddIncome_Load(object sender, EventArgs e)
        {
            LoadIncomeCategory();
            if (POGlobals.IncomeID != Guid.Empty)
                LoadIncomeInfo();
        }

        private void LoadIncomeCategory()
        {
            TT_INCOME_CATEGORYDataSet ds = new IncomeCategoryBS().SelectAll();
            foreach (TT_INCOME_CATEGORYDataSet.TT_INCOME_CATEGORYRow row in ds.TT_INCOME_CATEGORY.Rows)
            {
                ddlIncomeCategory.Items.Add(row.IncomeCategoryName);
            }
            if (ds.TT_INCOME_CATEGORY.Rows.Count > 0)
                ddlIncomeCategory.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInputCorrect())
                return;

            if (POGlobals.IncomeID == Guid.Empty)
                SaveIncome();
            else
                UpdateIncome();
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
            return true;
        }

        private void SaveIncome()
        {
            try
            {
                dsIncome = new INCOMEDataSet();
                INCOMEDataSet.INCOMERow row = dsIncome.INCOME.NewINCOMERow();
                row.IncomeID = Guid.NewGuid();
                row.UserID = POGlobals.UserID;
                row.Amount = Convert.ToDecimal(txtAmount.Text);
                row.Subject = txtSubject.Text;
                row.Date = dateCID.Value;
                row.IncomeCategoryID = ddlIncomeCategory.SelectedIndex + 1;
                dsIncome.INCOME.AddINCOMERow(row);
                new IncomeBS().Save(dsIncome);
                MessageBox.Show("Income is saved succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigateEventList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Income Card not saved, Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateIncome()
        {
            try
            {
                INCOMEDataSet.INCOMERow row = dsIncome.INCOME[0];
                row.IncomeCategoryID = ddlIncomeCategory.SelectedIndex + 1;
                row.Amount = Convert.ToDecimal(txtAmount.Text);
                row.Subject = txtSubject.Text;
                row.Date = dateCID.Value;
                row.IncomeCategoryID = ddlIncomeCategory.SelectedIndex + 1;
                new IncomeBS().Save(dsIncome);
                MessageBox.Show("Income is updated succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigateEventList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Income not updated, Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavigateEventList()
        {
            MainForm main = (MainForm)this.MdiParent;
            main.OpenIncomeList();
        }

        private void LoadIncomeInfo()
        {
            dsIncome = new IncomeBS().SelectDataSetByUserID(POGlobals.UserID);
            INCOMEDataSet.INCOMERow row = dsIncome.INCOME[0];
            txtAmount.Text = row.Amount.ToString();
            txtSubject.Text = row.Subject;
            dateCID.Value = row.Date;
            ddlIncomeCategory.SelectedIndex = row.IncomeCategoryID - 1;
        }
    }
}
