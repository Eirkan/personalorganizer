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
    public partial class IncomeList : Form
    {
        public IncomeList()
        {
            InitializeComponent();
        }

        private void IncomeList_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void LoadRecords()
        {
            gvIncomeList.AutoGenerateColumns = false;
            DataTable dt = new IncomeBS().SelectByUserID(POGlobals.UserID);
            gvIncomeList.DataSource = dt;
            gvIncomeList.Refresh();
        }

        private void gvIncomeList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;

            Guid incomeID = new Guid(gvIncomeList.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (e.ColumnIndex == 5)
            {
                POGlobals.IncomeID = incomeID;
                MainForm main = (MainForm)this.MdiParent;
                main.OpenAddIncome();
            }

            if (e.ColumnIndex == 6)
            {
                DialogResult res = MessageBox.Show("Are you sure to delete income?", "Input", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        new IncomeBS().DeleteByIncomeID(incomeID);
                        LoadRecords();
                    }
                    catch (Exception exc)
                    {
                        if (exc.Message.Contains("FK"))
                            MessageBox.Show("Income is used in somewhere, can't be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
