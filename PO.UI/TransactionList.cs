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
using PO.Types.DataSets;

namespace PersonelOrganizer
{
    public partial class TransactionList : Form
    {
        public TransactionList()
        {
            InitializeComponent();
        }

        private void TransactionList_Load(object sender, EventArgs e)
        {
            LoadExpenseCategory();
        }

        private void LoadExpenseCategory()
        {
            TT_EXPENSE_CATEGORYDataSet ds = new ExpenseCategoryBS().SelectAll();
            foreach (TT_EXPENSE_CATEGORYDataSet.TT_EXPENSE_CATEGORYRow row in ds.TT_EXPENSE_CATEGORY.Rows)
            {
                ddlExpenseCategory.Items.Add(row.ExpenseCategoryName);
            }
            if (ds.TT_EXPENSE_CATEGORY.Rows.Count > 0)
            {
                ddlExpenseCategory.Items.Insert(0, "All");
                ddlExpenseCategory.SelectedIndex = 0;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SelectTransactions();
        }

        private void SelectTransactions()
        {
            DataTable dt = new BudgetBS().SelectTransactions(dateStart.Value, dateFinish.Value);
            BindGrid(dt);
        }

        private void BindGrid(DataTable dt)
        {
            if (dt.Rows.Count > 1)
            {
                gvTran.AutoGenerateColumns = false;
                gvTran.DataSource = dt;
                gvTran.Refresh();
            }
            else
            {
                gvTran.DataSource = null;
                gvTran.Refresh();
            }
        }

        private void btnMonthlyBudgetSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new BudgetBS().SelectMonthlyBudget(((DateTime)dateMB.Value).Month, ddlExpenseCategory.SelectedIndex);
            BindGrid(dt);
        }
    }
}
