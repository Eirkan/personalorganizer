using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PO.Types.DataSets;
using PersonelOrganizer.Util;
using PO.Services.BusinessObjects;

namespace PersonelOrganizer
{
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        #region Mail

        private void btnAddMail_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMail.Text))
            {
                txtMail.BackColor = Color.Red;
                MessageBox.Show("Please Enter Mail Address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMail.BackColor = Color.White;
                return;
            }
            AddMail();
        }

        private void AddMail()
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            cell.Value = txtMail.Text;
            row.Cells.Add(cell);
            gvMail.Rows.Add(row);
            txtMail.Text = String.Empty;
        }

        private void gvMail_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
                gvMail.Rows.RemoveAt(e.RowIndex);
        }
        #endregion

        #region Web Page

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtWebPage.Text))
            {
                txtWebPage.BackColor = Color.Red;
                MessageBox.Show("Please Enter Web Page!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWebPage.BackColor = Color.White;
                return;
            }
            AddWebPage();
        }

        private void AddWebPage()
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            cell.Value = txtWebPage.Text;
            row.Cells.Add(cell);
            gvWebPage.Rows.Add(row);
            txtWebPage.Text = String.Empty;
        }

        private void gvWebPage_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
                gvWebPage.Rows.RemoveAt(e.RowIndex);
        }
        #endregion

        #region Phone Number

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                txtPhoneNumber.BackColor = Color.Red;
                MessageBox.Show("Please Enter Phone Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.BackColor = Color.White;
                return;
            }
            AddPhoneNumber();
        }

        private void AddPhoneNumber()
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            cell.Value = txtPhoneNumber.Text;
            row.Cells.Add(cell);
            gvPhone.Rows.Add(row);
            txtPhoneNumber.Text = String.Empty;
        }

        private void gvPhone_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
                gvPhone.Rows.RemoveAt(e.RowIndex);
        }
        #endregion

        #region Address

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                txtAddress.BackColor = Color.Red;
                MessageBox.Show("Please Enter Postal Address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.BackColor = Color.White;
                return;
            }
            AddPostalAddress();
        }

        private void AddPostalAddress()
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            cell.Value = txtAddress.Text;
            row.Cells.Add(cell);
            gvAddress.Rows.Add(row);
            txtAddress.Text = String.Empty;
        }

        private void gvAddress_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                gvAddress.Rows.RemoveAt(e.RowIndex);
            }
        }
        #endregion

        #region Save Contact

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckContactInfo())
                return;

            CONTACTDataSet contactDS = new CONTACTDataSet();
            CONTACTDataSet.CONTACTRow rowContact = contactDS.CONTACT.NewCONTACTRow();
            rowContact.ContactID = Guid.NewGuid();
            rowContact.UserID = POGlobals.UserID;
            rowContact.Name = txtName.Text;
            rowContact.Surname = txtSurname.Text;
            rowContact.Company = txtCompany.Text;
            contactDS.CONTACT.AddCONTACTRow(rowContact);

            EMAILDataSet mailDS = new EMAILDataSet();
            for (int i = 0; i < gvMail.Rows.Count; i++)
            {
                EMAILDataSet.EMAILRow rowMail = mailDS.EMAIL.NewEMAILRow();
                rowMail.EmailID = Guid.NewGuid();
                rowMail.ContactID = rowContact.ContactID;
                rowMail.EmailAddress = gvMail.Rows[i].Cells[0].Value.ToString();
                mailDS.EMAIL.AddEMAILRow(rowMail);
            }

            WEBPAGEDataSet webpageDS = new WEBPAGEDataSet();
            for (int i = 0; i < gvWebPage.Rows.Count; i++)
            {
                WEBPAGEDataSet.WEBPAGERow rowPage = webpageDS.WEBPAGE.NewWEBPAGERow();
                rowPage.WebPageID = Guid.NewGuid();
                rowPage.ContactID = rowContact.ContactID;
                rowPage.WebPageAddress = gvWebPage.Rows[i].Cells[0].Value.ToString();
                webpageDS.WEBPAGE.AddWEBPAGERow(rowPage);
            }

            PHONE_NUMBERDataSet phoneDS = new PHONE_NUMBERDataSet();
            for (int i = 0; i < gvPhone.Rows.Count; i++)
            {
                PHONE_NUMBERDataSet.PHONE_NUMBERRow rowPhone = phoneDS.PHONE_NUMBER.NewPHONE_NUMBERRow();
                rowPhone.PhoneNumberID = Guid.NewGuid();
                rowPhone.ContactID = rowContact.ContactID;
                rowPhone.PhoneNumber = gvPhone.Rows[i].Cells[0].Value.ToString();
                phoneDS.PHONE_NUMBER.AddPHONE_NUMBERRow(rowPhone);
            }

            POSTAL_ADDRESSDataSet addressDS = new POSTAL_ADDRESSDataSet();
            for (int i = 0; i < gvAddress.Rows.Count; i++)
            {
                POSTAL_ADDRESSDataSet.POSTAL_ADDRESSRow rowAddress = addressDS.POSTAL_ADDRESS.NewPOSTAL_ADDRESSRow();
                rowAddress.PostalAddressID = Guid.NewGuid();
                rowAddress.ContactID = rowContact.ContactID;
                rowAddress.PostalAddress = gvAddress.Rows[i].Cells[0].Value.ToString();
                addressDS.POSTAL_ADDRESS.AddPOSTAL_ADDRESSRow(rowAddress);
            }

            try
            {
                ContactBS contact = new ContactBS();
                contact.AddContact(contactDS, mailDS, webpageDS, phoneDS, addressDS);
                MessageBox.Show("Contact is saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm main = (MainForm)this.MdiParent;
                main.OpenContactList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Contact not saved, Error : " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckContactInfo()
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                txtName.BackColor = Color.Red;
                MessageBox.Show("Please Enter Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.BackColor = Color.White;
                return false;
            }
            if (String.IsNullOrEmpty(txtSurname.Text))
            {
                txtSurname.BackColor = Color.Red;
                MessageBox.Show("Please Enter Surname!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSurname.BackColor = Color.White;
                return false;
            }
            if (String.IsNullOrEmpty(txtCompany.Text))
            {
                txtCompany.BackColor = Color.Red;
                MessageBox.Show("Please Enter Company!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompany.BackColor = Color.White;
                return false;
            }
            return true;
        }
        #endregion
    }
}
