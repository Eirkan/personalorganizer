using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PO.Services.BusinessObjects;
using PO.Types.DataSets;
using PersonelOrganizer.Util;

namespace PersonelOrganizer
{
    public partial class AppointmentList : Form
    {
        public AppointmentList()
        {
            InitializeComponent();
        }

        private void AppointmentList_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            gvAppointmentList.AutoGenerateColumns = false;
            DataTable dt = new AppointmentBS().SelectAll();
            gvAppointmentList.DataSource = dt;
            gvAppointmentList.Refresh();
        }

        private void gvAppointmentList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Guid appointmentID = new Guid(gvAppointmentList.Rows[e.RowIndex].Cells[0].Value.ToString());
            POGlobals.ContactID = new Guid(gvAppointmentList.Rows[e.RowIndex].Cells[2].Value.ToString());
            POGlobals.EventID = new Guid(gvAppointmentList.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (e.ColumnIndex == 15)
            {
                DialogResult res = MessageBox.Show("Are you sure to delete appointment?", "Input", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    new AppointmentBS().DeleteByAppointmentID(appointmentID);
                    LoadAppointments();
                }
            }
            else if (e.ColumnIndex == 14)
            {
                POGlobals.AppointmentID = appointmentID;
                MainForm main = (MainForm)this.MdiParent;
                main.OpenAddAppointment();
            }
        }
    }
}
