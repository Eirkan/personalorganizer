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
    public partial class AddEvent : Form
    {
        EVENTDataSet dsEvent;
        public AddEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            LoadFrequenctTypes();
            ddlDuration.SelectedIndex = 0;
            if (POGlobals.EventID != Guid.Empty)
                LoadUpdateEventInfo();
        }

        private void LoadFrequenctTypes()
        {
            TT_FREQUENCYDataSet ds = new FrequencyBS().SelectAll();
            foreach (TT_FREQUENCYDataSet.TT_FREQUENCYRow row in ds.TT_FREQUENCY.Rows)
            {
                ddlFrequency.Items.Add(row.FrequencyName);
            }
            if (ds.TT_FREQUENCY.Rows.Count > 0)
                ddlFrequency.SelectedIndex = 0;
        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            if (!CheckLengthOfInputs())
                return;
            if (!ChechkOverlapEvents())
                return;

            if (POGlobals.EventID == Guid.Empty)
                SaveEvent();
            else
                UpdateEvent();
        }

        private bool ChechkOverlapEvents()
        {
            DataTable dt;
            if (POGlobals.EventID != Guid.Empty)
                dt = new EventBS().ChechkOverlapEvents(POGlobals.EventID, dateStartDate.Value, CalculateEndDateTime());
            else
                dt = new EventBS().ChechkOverlapEvents(dateStartDate.Value, CalculateEndDateTime());

            if (dt.Rows.Count > 0)
            {
                string evn = String.Empty;
                foreach (DataRow row in dt.Rows)
                {
                    evn += row["Subject"].ToString() + ", ";
                }
                MessageBox.Show("Event Overlaps with event subject: " + evn.Substring(0, evn.LastIndexOf(",")), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void SaveEvent()
        {
            try
            {
                dsEvent = new EVENTDataSet();
                EVENTDataSet.EVENTRow row = dsEvent.EVENT.NewEVENTRow();
                row.EventID = Guid.NewGuid();
                row.UserID = POGlobals.UserID;
                if (!String.IsNullOrEmpty(txtSubject.Text))
                    row.Subject = txtSubject.Text;
                if (!String.IsNullOrEmpty(txtLocation.Text))
                    row.Location = txtLocation.Text;
                if (!String.IsNullOrEmpty(txtDuration.Text))
                    row.Duration = Convert.ToInt32(txtDuration.Text);
                if (!String.IsNullOrEmpty(txtNote.Text))
                    row.Note = txtNote.Text;
                row.Frequency = ddlFrequency.SelectedIndex + 1;
                if (!String.IsNullOrEmpty(txtOccurence.Text))
                    row.NumberOfOccurence = Convert.ToInt32(txtOccurence.Text);
                row.StartDateTime = dateStartDate.Value;
                row.EndDateTime = CalculateEndDateTime();
                dsEvent.EVENT.AddEVENTRow(row);
                new EventBS().Save(dsEvent);
                MessageBox.Show("Event is saved succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigateEventList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Event not saved, Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateEvent()
        {
            try
            {
                EVENTDataSet.EVENTRow row = dsEvent.EVENT[0];
                if (!String.IsNullOrEmpty(txtSubject.Text))
                    row.Subject = txtSubject.Text;
                if (!String.IsNullOrEmpty(txtLocation.Text))
                    row.Location = txtLocation.Text;
                if (!String.IsNullOrEmpty(txtDuration.Text))
                    row.Duration = Convert.ToInt32(txtDuration.Text);
                if (!String.IsNullOrEmpty(txtNote.Text))
                    row.Note = txtNote.Text;
                row.Frequency = ddlFrequency.SelectedIndex + 1;
                if (!String.IsNullOrEmpty(txtOccurence.Text))
                    row.NumberOfOccurence = Convert.ToInt32(txtOccurence.Text);
                row.StartDateTime = dateStartDate.Value;
                row.EndDateTime = CalculateEndDateTime();
                new EventBS().Save(dsEvent);
                MessageBox.Show("Event is updated succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigateEventList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Event not updated, Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DateTime CalculateEndDateTime()
        {
            DateTime dt = dateStartDate.Value;
            if (ddlDuration.SelectedIndex == 0)
                dt = dt.AddMinutes(Convert.ToInt32(txtDuration.Text));
            else if (ddlDuration.SelectedIndex == 1)
                dt = dt.AddHours(Convert.ToInt32(txtDuration.Text));
            else if (ddlDuration.SelectedIndex == 2)
                dt = dt.AddDays(Convert.ToInt32(txtDuration.Text));
            else if (ddlDuration.SelectedIndex == 3)
                dt = dt.AddMonths(Convert.ToInt32(txtDuration.Text));
            else if (ddlDuration.SelectedIndex == 4)
                dt = dt.AddYears(Convert.ToInt32(txtDuration.Text));
            return dt;
        }

        private bool CheckLengthOfInputs()
        {
            if (txtSubject.Text.Length > 200)
            {
                txtSubject.BackColor = Color.Red;
                MessageBox.Show("Max Subject 200 character!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubject.BackColor = Color.White;
                return false;
            }
            if (txtLocation.Text.Length > 100)
            {
                txtLocation.BackColor = Color.Red;
                MessageBox.Show("Max Location 100 character!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.BackColor = Color.White;
                return false;
            }
            if (txtNote.Text.Length > 500)
            {
                txtNote.BackColor = Color.Red;
                MessageBox.Show("Max Note 500 character!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNote.BackColor = Color.White;
                return false;
            }
            if (String.IsNullOrEmpty(txtDuration.Text))
            {
                txtDuration.BackColor = Color.Red;
                MessageBox.Show("Please Enter Duration!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDuration.BackColor = Color.White;
                return false;
            }
            return true;
        }

        private void LoadUpdateEventInfo()
        {
            dsEvent = new EventBS().SelectByEventID(POGlobals.EventID);
            EVENTDataSet.EVENTRow row = dsEvent.EVENT[0];
            if (!row.IsDurationNull())
                txtDuration.Text = row.Duration.ToString();
            if (!row.IsLocationNull())
                txtLocation.Text = row.Location;
            if (!row.IsNoteNull())
                txtNote.Text = row.Note;
            if (!row.IsNumberOfOccurenceNull())
                txtOccurence.Text = row.NumberOfOccurence.ToString();
            if (!row.IsSubjectNull())
                txtSubject.Text = row.Subject;
            if (!row.IsStartDateTimeNull())
                dateStartDate.Value = row.StartDateTime;
            if (!row.IsFrequencyNull())
                ddlFrequency.SelectedIndex = row.Frequency - 1;
        }

        private void NavigateEventList()
        {
            MainForm main = (MainForm)this.MdiParent;
            main.OpenEventList();
        }
    }
}
