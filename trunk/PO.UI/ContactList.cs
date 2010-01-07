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
                select.Description = "Deneme";
                row.Cells.Add(select);
                DataGridViewTextBoxCell name = new DataGridViewTextBoxCell();
                name.Value = (!con.CONTACT[0].IsNameNull()) ? con.CONTACT[0].Name : String.Empty;
                row.Cells.Add(name);
                DataGridViewTextBoxCell surname = new DataGridViewTextBoxCell();
                surname.Value = (!con.CONTACT[0].IsSurnameNull()) ? con.CONTACT[0].Surname : String.Empty;
                row.Cells.Add(surname);
                DataGridViewTextBoxCell company = new DataGridViewTextBoxCell();
                company.Value = (!con.CONTACT[0].IsCompanyNull()) ? con.CONTACT[0].Company : String.Empty;
                DataGridViewTextBoxCell contactID = new DataGridViewTextBoxCell();
                contactID.Value = con.CONTACT[0].ContactID;
                row.Cells.Add(contactID);
                gvContactList.Rows.Add(row);
            }
        }

        private void gvContactList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
                LoadContactDetails(gvContactList.Rows[e.RowIndex].Cells["ContactID"].Value.ToString());
        }

        private void LoadContactDetails(string contactID)
        {
            Guid pContactID = new Guid(contactID);
            ClearAllDetails();

        }

        private void ClearAllDetails()
        {
            gvMail.Rows.Clear();
            gvPhone.Rows.Clear();
            gvAddress.Rows.Clear();
            gvWebPage.Rows.Clear();
        }
    }
}
