using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PO.Services.BusinessObjects;
using PersonelOrganizer.Util;

namespace PersonelOrganizer
{
    public partial class ExpenseList : Form
    {
        public ExpenseList()
        {
            InitializeComponent();
        }

        private void ExpenseList_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void LoadRecords()
        {
            gvExpenseList.AutoGenerateColumns = false;
            DataTable dt = new ExpenseBillBS().SelectByUserID(POGlobals.UserID);
            gvExpenseList.DataSource = dt;
            gvExpenseList.Refresh();
        }

        private void gvExpenseList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;

            Guid installmentID = Guid.Empty;
            if (!String.IsNullOrEmpty(gvExpenseList.Rows[e.RowIndex].Cells[0].Value.ToString()))
                installmentID = new Guid(gvExpenseList.Rows[e.RowIndex].Cells[0].Value.ToString());
            Guid expenseID = new Guid(gvExpenseList.Rows[e.RowIndex].Cells[1].Value.ToString());

            if (e.ColumnIndex == 8)
            {
                POGlobals.ExpenseID = expenseID;
                POGlobals.InstallmentID = installmentID;
                MainForm main = (MainForm)this.MdiParent;
                main.OpenAddExpense();
            }

            if (e.ColumnIndex == 9)
            {
                DialogResult res = MessageBox.Show("Are you sure to delete expense? If expense has installments, All installments will be deleted!!! ", "Input", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (installmentID != Guid.Empty)
                    {
                        new ExpenseBillBS().DeleteByInstallmentID(installmentID);
                        new InstallmentBS().DeleteByInstallmentID(installmentID);
                    }
                    else
                        new ExpenseBillBS().DeleteByExpenseBillID(expenseID);
                    LoadRecords();
                }
            }
        }
    }
}
