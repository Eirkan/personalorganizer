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
    public partial class CreditCardList : Form
    {
        public CreditCardList()
        {
            InitializeComponent();
        }

        private void CreditCardList_Load(object sender, EventArgs e)
        {
            LoadCreditCards();
        }

        private void LoadCreditCards()
        {
            gvCardList.AutoGenerateColumns = false;
            DataTable dt = new CreditCardBS().SelectByUserID(POGlobals.UserID);
            gvCardList.DataSource = dt;
            gvCardList.Refresh();
        }

        private void gvCardList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;

            Guid creditCardID = new Guid(gvCardList.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (e.ColumnIndex == 8)
            {
                POGlobals.CreditCard = creditCardID;
                MainForm main = (MainForm)this.MdiParent;
                main.OpenAddCreditCard();
            }

            if (e.ColumnIndex == 9)
            {
                DialogResult res = MessageBox.Show("Are you sure to delete credit card?", "Input", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    new CreditCardBS().DeleteByCreditCardID(creditCardID);
                    LoadCreditCards();
                }
            }
        }
    }
}
