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
            gvContactList.Rows.Clear();
            CONTACTDataSet con = new ContactBS().SelectContactsWithUserID(POGlobals.UserID);
            for (int i = 0; i < con.CONTACT.Rows.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewImageCell select = new DataGridViewImageCell();
                row.Cells.Add(select);
                DataGridViewTextBoxCell name = new DataGridViewTextBoxCell();
                name.Value = (!con.CONTACT[i].IsNameNull()) ? con.CONTACT[i].Name : String.Empty;
                row.Cells.Add(name);
                DataGridViewTextBoxCell surname = new DataGridViewTextBoxCell();
                surname.Value = (!con.CONTACT[i].IsSurnameNull()) ? con.CONTACT[i].Surname : String.Empty;
                row.Cells.Add(surname);
                DataGridViewTextBoxCell company = new DataGridViewTextBoxCell();
                company.Value = (!con.CONTACT[i].IsCompanyNull()) ? con.CONTACT[i].Company : String.Empty;
                row.Cells.Add(company);
                DataGridViewTextBoxCell contactID = new DataGridViewTextBoxCell();
                contactID.Value = con.CONTACT[i].ContactID;
                row.Cells.Add(contactID);
                DataGridViewImageCell update = new DataGridViewImageCell();
                row.Cells.Add(update);
                DataGridViewImageCell delete = new DataGridViewImageCell();
                row.Cells.Add(delete);
                gvContactList.Rows.Add(row);
            }
        }

        private void gvContactList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Guid contactID = new Guid(gvContactList.Rows[e.RowIndex].Cells[4].Value.ToString());
            if (e.ColumnIndex == 0)
                LoadContactDetails(contactID);
            else if (e.ColumnIndex == 5)
            {
                POGlobals.ContactID = contactID;
                MainForm main = (MainForm)this.MdiParent;
                main.OpenAddContact();
            }
            else if (e.ColumnIndex == 6)
            {
                DialogResult res = MessageBox.Show("Are you sure to delete contact?", "Input", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        new ContactBS().DeleteContactByContactID(contactID);
                        LoadContacts();
                    }
                    catch (Exception exc)
                    {
                        if (exc.Message.Contains("FK"))
                            MessageBox.Show("Contact is used in somewhere, can't be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void LoadContactDetails(Guid contactID)
        {
            ClearAllDetails();
            LoadAllContactDetails(contactID);
        }

        private void LoadAllContactDetails(Guid pContactID)
        {
            EMAILDataSet mailDS = new EmailBS().SelectByContactID(pContactID);
            PHONE_NUMBERDataSet phoneDS = new PhoneNumberBS().SelectByContactID(pContactID);
            POSTAL_ADDRESSDataSet addressDS = new AddressBS().SelectByContactID(pContactID);
            WEBPAGEDataSet pageDS = new WebPageBS().SelectByContactID(pContactID);

            for (int m = 0; m < pageDS.WEBPAGE.Rows.Count; m++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell page = new DataGridViewTextBoxCell();
                page.Value = pageDS.WEBPAGE[m].WebPageAddress;
                row.Cells.Add(page);
                gvWebPage.Rows.Add(row);
            }

            for (int k = 0; k < addressDS.POSTAL_ADDRESS.Rows.Count; k++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell address = new DataGridViewTextBoxCell();
                address.Value = addressDS.POSTAL_ADDRESS[k].PostalAddress;
                row.Cells.Add(address);
                gvAddress.Rows.Add(row);
            }

            for (int j = 0; j < phoneDS.PHONE_NUMBER.Rows.Count; j++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell phone = new DataGridViewTextBoxCell();
                phone.Value = phoneDS.PHONE_NUMBER[j].PhoneNumber;
                row.Cells.Add(phone);
                gvPhone.Rows.Add(row);
            }

            for (int i = 0; i < mailDS.EMAIL.Rows.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell mail = new DataGridViewTextBoxCell();
                mail.Value = mailDS.EMAIL[i].EmailAddress;
                row.Cells.Add(mail);
                gvMail.Rows.Add(row);
            }
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
