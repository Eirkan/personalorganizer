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
    public partial class AddAppointment : Form
    {
        APPOINTMENTDataSet dsAppointment;
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            LoadEventList();
            LoadContacts();
            if (POGlobals.AppointmentID != Guid.Empty)
                SelectEventContact();
        }

        private void LoadEventList()
        {
            EVENTDataSet ds = new EventBS().SelectByUserID(POGlobals.UserID);
            BindEventGrid(ds);
        }

        private void BindEventGrid(EVENTDataSet ds)
        {
            gvEventList.Rows.Clear();
            foreach (EVENTDataSet.EVENTRow row in ds.EVENT.Rows)
            {
                DataGridViewRow gvRow = new DataGridViewRow();
                DataGridViewImageCell select = new DataGridViewImageCell();
                gvRow.Cells.Add(select);
                DataGridViewTextBoxCell subject = new DataGridViewTextBoxCell();
                subject.Value = (!row.IsSubjectNull()) ? row.Subject : String.Empty;
                gvRow.Cells.Add(subject);
                DataGridViewTextBoxCell location = new DataGridViewTextBoxCell();
                location.Value = (!row.IsLocationNull()) ? row.Location : String.Empty;
                gvRow.Cells.Add(location);
                DataGridViewTextBoxCell date = new DataGridViewTextBoxCell();
                date.Value = (!row.IsStartDateTimeNull()) ? row.StartDateTime.ToString() : null;
                gvRow.Cells.Add(date);
                DataGridViewTextBoxCell endDate = new DataGridViewTextBoxCell();
                endDate.Value = (!row.IsEndDateTimeNull()) ? row.EndDateTime.ToString() : null;
                gvRow.Cells.Add(endDate);
                DataGridViewTextBoxCell duration = new DataGridViewTextBoxCell();
                duration.Value = (!row.IsDurationNull()) ? row.Duration.ToString() : String.Empty;
                gvRow.Cells.Add(duration);
                DataGridViewTextBoxCell note = new DataGridViewTextBoxCell();
                note.Value = (!row.IsNoteNull()) ? row.Note : String.Empty;
                gvRow.Cells.Add(note);
                DataGridViewTextBoxCell freq = new DataGridViewTextBoxCell();
                freq.Value = (!row.IsFrequencyNull()) ? GetFrequency(row.Frequency) : String.Empty;
                gvRow.Cells.Add(freq);
                DataGridViewTextBoxCell occ = new DataGridViewTextBoxCell();
                occ.Value = (!row.IsNumberOfOccurenceNull()) ? row.NumberOfOccurence.ToString() : String.Empty;
                gvRow.Cells.Add(occ);
                DataGridViewTextBoxCell eventID = new DataGridViewTextBoxCell();
                eventID.Value = row.EventID;
                gvRow.Cells.Add(eventID);
                gvEventList.Rows.Add(gvRow);
            }
        }

        private string GetFrequency(int frequency)
        {
            string freqName = String.Empty;
            switch (frequency)
            {
                case 1:
                    freqName = "Daily";
                    break;
                case 2:
                    freqName = "Weekly";
                    break;
                case 3:
                    freqName = "Monthly";
                    break;
                case 4:
                    freqName = "Yearly";
                    break;
            }
            return freqName;
        }

        private void LoadContacts()
        {
            gvContactList.AutoGenerateColumns = false;
            CONTACTDataSet con = new ContactBS().SelectContactsWithUserID(POGlobals.UserID);
            gvContactList.DataSource = con.CONTACT;
            gvContactList.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (POGlobals.AppointmentID == Guid.Empty)
                SaveAppointment();
            else
                UpdateAppointment();
        }

        private void SaveAppointment()
        {
            try
            {
                DataGridViewRow colEvent = gvEventList.SelectedRows[0];
                DataGridViewRow colContact = gvContactList.SelectedRows[0];
                dsAppointment = new APPOINTMENTDataSet();
                APPOINTMENTDataSet.APPOINTMENTRow row = dsAppointment.APPOINTMENT.NewAPPOINTMENTRow();
                row.AppointmentID = Guid.NewGuid();
                row.UserID = POGlobals.UserID;
                row.ContactID = new Guid(colContact.Cells[4].Value.ToString());
                row.EventID = new Guid(colEvent.Cells[9].Value.ToString());
                dsAppointment.APPOINTMENT.AddAPPOINTMENTRow(row);
                new AppointmentBS().Save(dsAppointment);
                MessageBox.Show("Appointment is saved succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigateEventList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Appointment not saved, Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAppointment()
        {
            try
            {
                DataGridViewRow colEvent = gvEventList.SelectedRows[0];
                DataGridViewRow colContact = gvContactList.SelectedRows[0];
                APPOINTMENTDataSet.APPOINTMENTRow row = dsAppointment.APPOINTMENT[0];
                row.ContactID = new Guid(colContact.Cells[4].Value.ToString());
                row.EventID = new Guid(colEvent.Cells[9].Value.ToString());
                new AppointmentBS().Save(dsAppointment);
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
            main.OpenAppointmentList();
        }

        private void SelectEventContact()
        {
            gvContactList.MultiSelect = true;
            dsAppointment = new AppointmentBS().SelectByAppointmentID(POGlobals.AppointmentID);
            foreach (DataGridViewRow rowContact in gvContactList.Rows)
            {
                if (rowContact.Cells[4].Value.ToString() == POGlobals.ContactID.ToString())
                {
                    gvContactList.BindingContext[gvContactList.DataSource].Position = rowContact.Index;
                    break;
                }
            }

            
            foreach (DataGridViewRow rowEvent in gvEventList.Rows)
            {
                if (rowEvent.Cells[9].Value.ToString() == POGlobals.EventID.ToString())
                {
                    rowEvent.Selected = true;
                    break;
                }
            }
        }
    }
}
