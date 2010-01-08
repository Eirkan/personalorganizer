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
            LoadEventList();
        }

        private void LoadEventList()
        {
            gvEventList.Rows.Clear();
            EVENTDataSet ds = new EventBS().SelectByUserID(POGlobals.UserID);
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
                date.Value = (!row.IsStartDateTimeNull()) ? row.StartDateTime.ToShortDateString() : String.Empty;
                gvRow.Cells.Add(date);
                DataGridViewTextBoxCell duration = new DataGridViewTextBoxCell();
                duration.Value = (!row.IsDurationNull()) ? row.Duration.ToString() : String.Empty;
                gvRow.Cells.Add(duration);
                DataGridViewTextBoxCell note = new DataGridViewTextBoxCell();
                note.Value = (!row.IsNoteNull()) ? row.Note : String.Empty;
                gvRow.Cells.Add(note);
                DataGridViewTextBoxCell freq = new DataGridViewTextBoxCell();
                freq.Value = (!row.IsFrequencyNull()) ? row.Frequency.ToString() : String.Empty;
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

        private void gvEventList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Guid eventID = new Guid(gvEventList.Rows[e.RowIndex].Cells[7].Value.ToString());
            if(e.ColumnIndex == 8)
            {
                POGlobals.EventID = eventID;
                MainForm main = (MainForm)this.MdiParent;
                main.OpenAddEvent();
            }
            else if (e.ColumnIndex == 9)
            {
                DialogResult res = MessageBox.Show("Are you sure to delete event?", "Input", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    new EventBS().DeleteEventByEventID(eventID);
                    LoadEventList();
                }
            }
        }
    }
}
