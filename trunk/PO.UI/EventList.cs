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
    public partial class EventList : Form
    {
        public EventList()
        {
            InitializeComponent();
        }

        private void EventList_Load(object sender, EventArgs e)
        {
            LoadFrequenctTypes();
            LoadEventList();
        }

        private void LoadFrequenctTypes()
        {
            TT_FREQUENCYDataSet ds = new FrequencyBS().SelectAll();
            foreach (TT_FREQUENCYDataSet.TT_FREQUENCYRow row in ds.TT_FREQUENCY.Rows)
            {
                ddlFrequency.Items.Add(row.FrequencyName);
            }
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
                DataGridViewImageCell update = new DataGridViewImageCell();
                gvRow.Cells.Add(update);
                DataGridViewImageCell delete = new DataGridViewImageCell();
                gvRow.Cells.Add(delete);
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

        private void gvEventList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Guid eventID = new Guid(gvEventList.Rows[e.RowIndex].Cells[8].Value.ToString());
            if (e.ColumnIndex == 9)
            {
                POGlobals.EventID = eventID;
                MainForm main = (MainForm)this.MdiParent;
                main.OpenAddEvent();
            }
            else if (e.ColumnIndex == 10)
            {
                DialogResult res = MessageBox.Show("Are you sure to delete event?", "Input", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    new EventBS().DeleteEventByEventID(eventID);
                    LoadEventList();
                }
            }
        }

        private void ddlFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            int freqType = ddlFrequency.SelectedIndex + 1;
            EVENTDataSet ds = new EventBS().SelectByUserIDFrequencyType(POGlobals.UserID, freqType);
            BindEventGrid(ds);
        }
    }
}
