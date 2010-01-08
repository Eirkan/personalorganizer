namespace PersonelOrganizer
{
    partial class AppointmentList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAppointmentHeader = new System.Windows.Forms.Label();
            this.gvAppointmentList = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumnAppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnEventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCheckColumnSelect = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnOccurence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewImageColumnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewImageColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvAppointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppointmentHeader
            // 
            this.lblAppointmentHeader.AutoSize = true;
            this.lblAppointmentHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAppointmentHeader.Location = new System.Drawing.Point(12, 24);
            this.lblAppointmentHeader.Name = "lblAppointmentHeader";
            this.lblAppointmentHeader.Size = new System.Drawing.Size(103, 15);
            this.lblAppointmentHeader.TabIndex = 22;
            this.lblAppointmentHeader.Text = "Appointment List";
            // 
            // gvAppointmentList
            // 
            this.gvAppointmentList.AllowUserToAddRows = false;
            this.gvAppointmentList.BackgroundColor = System.Drawing.Color.White;
            this.gvAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAppointmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumnAppointmentID,
            this.DataGridViewTextBoxColumnEventID,
            this.DataGridViewTextBoxColumnContactID,
            this.DataGridViewCheckColumnSelect,
            this.DataGridViewTextBoxColumnName,
            this.DataGridViewTextBoxColumnSurname,
            this.DataGridViewTextBoxColumnSubject,
            this.DataGridViewTextBoxColumnLocation,
            this.DataGridViewTextBoxColumnStartDate,
            this.DataGridViewTextBoxColumnEndDate,
            this.DataGridViewTextBoxColumnDuration,
            this.DataGridViewTextBoxColumnNote,
            this.DataGridViewTextBoxColumnFrequency,
            this.DataGridViewTextBoxColumnOccurence,
            this.DataGridViewImageColumnUpdate,
            this.DataGridViewImageColumnDelete});
            this.gvAppointmentList.Location = new System.Drawing.Point(15, 51);
            this.gvAppointmentList.Name = "gvAppointmentList";
            this.gvAppointmentList.ReadOnly = true;
            this.gvAppointmentList.RowHeadersVisible = false;
            this.gvAppointmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAppointmentList.Size = new System.Drawing.Size(411, 546);
            this.gvAppointmentList.TabIndex = 26;
            this.gvAppointmentList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvAppointmentList_CellMouseClick);
            // 
            // DataGridViewTextBoxColumnAppointmentID
            // 
            this.DataGridViewTextBoxColumnAppointmentID.DataPropertyName = "AppointmentID";
            this.DataGridViewTextBoxColumnAppointmentID.HeaderText = "AppointmentID";
            this.DataGridViewTextBoxColumnAppointmentID.Name = "DataGridViewTextBoxColumnAppointmentID";
            this.DataGridViewTextBoxColumnAppointmentID.ReadOnly = true;
            this.DataGridViewTextBoxColumnAppointmentID.Visible = false;
            // 
            // DataGridViewTextBoxColumnEventID
            // 
            this.DataGridViewTextBoxColumnEventID.DataPropertyName = "EventID";
            this.DataGridViewTextBoxColumnEventID.HeaderText = "EventID";
            this.DataGridViewTextBoxColumnEventID.Name = "DataGridViewTextBoxColumnEventID";
            this.DataGridViewTextBoxColumnEventID.ReadOnly = true;
            this.DataGridViewTextBoxColumnEventID.Visible = false;
            // 
            // DataGridViewTextBoxColumnContactID
            // 
            this.DataGridViewTextBoxColumnContactID.DataPropertyName = "ContactID";
            this.DataGridViewTextBoxColumnContactID.HeaderText = "ContactID";
            this.DataGridViewTextBoxColumnContactID.Name = "DataGridViewTextBoxColumnContactID";
            this.DataGridViewTextBoxColumnContactID.ReadOnly = true;
            this.DataGridViewTextBoxColumnContactID.Visible = false;
            // 
            // DataGridViewCheckColumnSelect
            // 
            this.DataGridViewCheckColumnSelect.HeaderText = "Select";
            this.DataGridViewCheckColumnSelect.Image = global::PersonelOrganizer.Properties.Resources.go_small;
            this.DataGridViewCheckColumnSelect.Name = "DataGridViewCheckColumnSelect";
            this.DataGridViewCheckColumnSelect.ReadOnly = true;
            this.DataGridViewCheckColumnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCheckColumnSelect.Width = 50;
            // 
            // DataGridViewTextBoxColumnName
            // 
            this.DataGridViewTextBoxColumnName.DataPropertyName = "Name";
            this.DataGridViewTextBoxColumnName.HeaderText = "Name";
            this.DataGridViewTextBoxColumnName.Name = "DataGridViewTextBoxColumnName";
            this.DataGridViewTextBoxColumnName.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnSurname
            // 
            this.DataGridViewTextBoxColumnSurname.DataPropertyName = "Surname";
            this.DataGridViewTextBoxColumnSurname.HeaderText = "Surname";
            this.DataGridViewTextBoxColumnSurname.Name = "DataGridViewTextBoxColumnSurname";
            this.DataGridViewTextBoxColumnSurname.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnSubject
            // 
            this.DataGridViewTextBoxColumnSubject.DataPropertyName = "Subject";
            this.DataGridViewTextBoxColumnSubject.HeaderText = "Subject";
            this.DataGridViewTextBoxColumnSubject.Name = "DataGridViewTextBoxColumnSubject";
            this.DataGridViewTextBoxColumnSubject.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnLocation
            // 
            this.DataGridViewTextBoxColumnLocation.DataPropertyName = "Location";
            this.DataGridViewTextBoxColumnLocation.HeaderText = "Location";
            this.DataGridViewTextBoxColumnLocation.Name = "DataGridViewTextBoxColumnLocation";
            this.DataGridViewTextBoxColumnLocation.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnStartDate
            // 
            this.DataGridViewTextBoxColumnStartDate.DataPropertyName = "StartDateTime";
            this.DataGridViewTextBoxColumnStartDate.HeaderText = "Start Date";
            this.DataGridViewTextBoxColumnStartDate.Name = "DataGridViewTextBoxColumnStartDate";
            this.DataGridViewTextBoxColumnStartDate.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnEndDate
            // 
            this.DataGridViewTextBoxColumnEndDate.DataPropertyName = "EndDateTime";
            this.DataGridViewTextBoxColumnEndDate.HeaderText = "EndDate";
            this.DataGridViewTextBoxColumnEndDate.Name = "DataGridViewTextBoxColumnEndDate";
            this.DataGridViewTextBoxColumnEndDate.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnDuration
            // 
            this.DataGridViewTextBoxColumnDuration.DataPropertyName = "Duration";
            this.DataGridViewTextBoxColumnDuration.HeaderText = "Duration";
            this.DataGridViewTextBoxColumnDuration.Name = "DataGridViewTextBoxColumnDuration";
            this.DataGridViewTextBoxColumnDuration.ReadOnly = true;
            this.DataGridViewTextBoxColumnDuration.Visible = false;
            this.DataGridViewTextBoxColumnDuration.Width = 50;
            // 
            // DataGridViewTextBoxColumnNote
            // 
            this.DataGridViewTextBoxColumnNote.DataPropertyName = "Note";
            this.DataGridViewTextBoxColumnNote.HeaderText = "Note";
            this.DataGridViewTextBoxColumnNote.Name = "DataGridViewTextBoxColumnNote";
            this.DataGridViewTextBoxColumnNote.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnFrequency
            // 
            this.DataGridViewTextBoxColumnFrequency.DataPropertyName = "Frequency";
            this.DataGridViewTextBoxColumnFrequency.HeaderText = "Frequency";
            this.DataGridViewTextBoxColumnFrequency.Name = "DataGridViewTextBoxColumnFrequency";
            this.DataGridViewTextBoxColumnFrequency.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnOccurence
            // 
            this.DataGridViewTextBoxColumnOccurence.DataPropertyName = "NumberOfOccurence";
            this.DataGridViewTextBoxColumnOccurence.HeaderText = "Occurence";
            this.DataGridViewTextBoxColumnOccurence.Name = "DataGridViewTextBoxColumnOccurence";
            this.DataGridViewTextBoxColumnOccurence.ReadOnly = true;
            // 
            // DataGridViewImageColumnUpdate
            // 
            this.DataGridViewImageColumnUpdate.HeaderText = "Update";
            this.DataGridViewImageColumnUpdate.Image = global::PersonelOrganizer.Properties.Resources.document_edit_small;
            this.DataGridViewImageColumnUpdate.Name = "DataGridViewImageColumnUpdate";
            this.DataGridViewImageColumnUpdate.ReadOnly = true;
            this.DataGridViewImageColumnUpdate.Width = 50;
            // 
            // DataGridViewImageColumnDelete
            // 
            this.DataGridViewImageColumnDelete.HeaderText = "Delete";
            this.DataGridViewImageColumnDelete.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.DataGridViewImageColumnDelete.Name = "DataGridViewImageColumnDelete";
            this.DataGridViewImageColumnDelete.ReadOnly = true;
            this.DataGridViewImageColumnDelete.Width = 50;
            // 
            // AppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 624);
            this.ControlBox = false;
            this.Controls.Add(this.gvAppointmentList);
            this.Controls.Add(this.lblAppointmentHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AppointmentList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AppointmentList";
            this.Load += new System.EventHandler(this.AppointmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAppointmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentHeader;
        private System.Windows.Forms.DataGridView gvAppointmentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnAppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnEventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnContactID;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewCheckColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnOccurence;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewImageColumnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewImageColumnDelete;
    }
}