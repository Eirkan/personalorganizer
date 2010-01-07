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
    public partial class ContactList : Form
    {
        public ContactList()
        {
            InitializeComponent();
        }

        private void ContactList_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void LoadContacts()
        {
            CONTACTDataSet con = new ContactBS().SelectContactsWithUserID(POGlobals.UserID);
            gvContactList.Rows.Clear();
            for (int i = 0; i < con.CONTACT.Rows.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewImageCell select = new DataGridViewImageCell();
                row.Cells.Add(select);
                DataGridViewTextBoxCell name = new DataGridViewTextBoxCell();
                name.Value = con.CONTACT[0].Name;
                row.Cells.Add(name);
                DataGridViewTextBoxCell surname = new DataGridViewTextBoxCell();
                surname.Value = con.CONTACT[0].Surname;
                row.Cells.Add(surname);
                DataGridViewTextBoxCell company = new DataGridViewTextBoxCell();
                company.Value = con.CONTACT[0].Company;
                row.Cells.Add(company);
                gvContactList.Rows.Add(row);
            }
        }
    }
}
