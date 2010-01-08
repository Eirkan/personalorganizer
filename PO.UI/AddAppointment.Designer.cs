namespace PersonelOrganizer
{
    partial class AddAppointment
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
            this.gvEventList = new System.Windows.Forms.DataGridView();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblContacts = new System.Windows.Forms.Label();
            this.gvContactList = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.DataGridViewcontactCheckColumnSelect = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCheckColumnSelect = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewTextBoxColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnOccurence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnEventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppointmentHeader
            // 
            this.lblAppointmentHeader.AutoSize = true;
            this.lblAppointmentHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAppointmentHeader.Location = new System.Drawing.Point(12, 19);
            this.lblAppointmentHeader.Name = "lblAppointmentHeader";
            this.lblAppointmentHeader.Size = new System.Drawing.Size(106, 15);
            this.lblAppointmentHeader.TabIndex = 21;
            this.lblAppointmentHeader.Text = "Add Appointment";
            // 
            // gvEventList
            // 
            this.gvEventList.AllowUserToAddRows = false;
            this.gvEventList.BackgroundColor = System.Drawing.Color.White;
            this.gvEventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEventList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckColumnSelect,
            this.DataGridViewTextBoxColumnSubject,
            this.DataGridViewTextBoxColumnLocation,
            this.DataGridViewTextBoxColumnStartDate,
            this.DataGridViewTextBoxColumnEndDate,
            this.DataGridViewTextBoxColumnDuration,
            this.DataGridViewTextBoxColumnNote,
            this.DataGridViewTextBoxColumnFrequency,
            this.DataGridViewTextBoxColumnOccurence,
            this.DataGridViewTextBoxColumnEventID});
            this.gvEventList.Location = new System.Drawing.Point(14, 75);
            this.gvEventList.MultiSelect = false;
            this.gvEventList.Name = "gvEventList";
            this.gvEventList.ReadOnly = true;
            this.gvEventList.RowHeadersVisible = false;
            this.gvEventList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEventList.Size = new System.Drawing.Size(411, 167);
            this.gvEventList.TabIndex = 25;
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvents.ForeColor = System.Drawing.Color.Black;
            this.lblEvents.Location = new System.Drawing.Point(11, 57);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(50, 15);
            this.lblEvents.TabIndex = 26;
            this.lblEvents.Text = "Events :";
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContacts.ForeColor = System.Drawing.Color.Black;
            this.lblContacts.Location = new System.Drawing.Point(12, 277);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(61, 15);
            this.lblContacts.TabIndex = 27;
            this.lblContacts.Text = "Contacts :";
            // 
            // gvContactList
            // 
            this.gvContactList.AllowUserToAddRows = false;
            this.gvContactList.BackgroundColor = System.Drawing.Color.White;
            this.gvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewcontactCheckColumnSelect,
            this.DataGridViewTextBoxColumnName,
            this.DataGridViewTextBoxColumnSurname,
            this.DataGridViewTextBoxColumnCompany,
            this.DataGridViewTextBoxColumnContactID});
            this.gvContactList.Location = new System.Drawing.Point(14, 295);
            this.gvContactList.MultiSelect = false;
            this.gvContactList.Name = "gvContactList";
            this.gvContactList.ReadOnly = true;
            this.gvContactList.RowHeadersVisible = false;
            this.gvContactList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvContactList.Size = new System.Drawing.Size(411, 268);
            this.gvContactList.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(349, 583);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DataGridViewcontactCheckColumnSelect
            // 
            this.DataGridViewcontactCheckColumnSelect.DataPropertyName = "Select";
            this.DataGridViewcontactCheckColumnSelect.HeaderText = "Select";
            this.DataGridViewcontactCheckColumnSelect.Image = global::PersonelOrganizer.Properties.Resources.go_small;
            this.DataGridViewcontactCheckColumnSelect.Name = "DataGridViewcontactCheckColumnSelect";
            this.DataGridViewcontactCheckColumnSelect.ReadOnly = true;
            this.DataGridViewcontactCheckColumnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewcontactCheckColumnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DataGridViewcontactCheckColumnSelect.Width = 50;
            // 
            // DataGridViewTextBoxColumnName
            // 
            this.DataGridViewTextBoxColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumnName.DataPropertyName = "Name";
            this.DataGridViewTextBoxColumnName.HeaderText = "Name";
            this.DataGridViewTextBoxColumnName.Name = "DataGridViewTextBoxColumnName";
            this.DataGridViewTextBoxColumnName.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnSurname
            // 
            this.DataGridViewTextBoxColumnSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumnSurname.DataPropertyName = "Surname";
            this.DataGridViewTextBoxColumnSurname.HeaderText = "Surname";
            this.DataGridViewTextBoxColumnSurname.Name = "DataGridViewTextBoxColumnSurname";
            this.DataGridViewTextBoxColumnSurname.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnCompany
            // 
            this.DataGridViewTextBoxColumnCompany.DataPropertyName = "Company";
            this.DataGridViewTextBoxColumnCompany.HeaderText = "Company";
            this.DataGridViewTextBoxColumnCompany.Name = "DataGridViewTextBoxColumnCompany";
            this.DataGridViewTextBoxColumnCompany.ReadOnly = true;
            this.DataGridViewTextBoxColumnCompany.Width = 106;
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
            // DataGridViewTextBoxColumnSubject
            // 
            this.DataGridViewTextBoxColumnSubject.HeaderText = "Subject";
            this.DataGridViewTextBoxColumnSubject.Name = "DataGridViewTextBoxColumnSubject";
            this.DataGridViewTextBoxColumnSubject.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnLocation
            // 
            this.DataGridViewTextBoxColumnLocation.HeaderText = "Location";
            this.DataGridViewTextBoxColumnLocation.Name = "DataGridViewTextBoxColumnLocation";
            this.DataGridViewTextBoxColumnLocation.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnStartDate
            // 
            this.DataGridViewTextBoxColumnStartDate.HeaderText = "Start Date";
            this.DataGridViewTextBoxColumnStartDate.Name = "DataGridViewTextBoxColumnStartDate";
            this.DataGridViewTextBoxColumnStartDate.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnEndDate
            // 
            this.DataGridViewTextBoxColumnEndDate.HeaderText = "EndDate";
            this.DataGridViewTextBoxColumnEndDate.Name = "DataGridViewTextBoxColumnEndDate";
            this.DataGridViewTextBoxColumnEndDate.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnDuration
            // 
            this.DataGridViewTextBoxColumnDuration.HeaderText = "Duration";
            this.DataGridViewTextBoxColumnDuration.Name = "DataGridViewTextBoxColumnDuration";
            this.DataGridViewTextBoxColumnDuration.ReadOnly = true;
            this.DataGridViewTextBoxColumnDuration.Visible = false;
            this.DataGridViewTextBoxColumnDuration.Width = 50;
            // 
            // DataGridViewTextBoxColumnNote
            // 
            this.DataGridViewTextBoxColumnNote.HeaderText = "Note";
            this.DataGridViewTextBoxColumnNote.Name = "DataGridViewTextBoxColumnNote";
            this.DataGridViewTextBoxColumnNote.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnFrequency
            // 
            this.DataGridViewTextBoxColumnFrequency.HeaderText = "Frequency";
            this.DataGridViewTextBoxColumnFrequency.Name = "DataGridViewTextBoxColumnFrequency";
            this.DataGridViewTextBoxColumnFrequency.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnOccurence
            // 
            this.DataGridViewTextBoxColumnOccurence.HeaderText = "Occurence";
            this.DataGridViewTextBoxColumnOccurence.Name = "DataGridViewTextBoxColumnOccurence";
            this.DataGridViewTextBoxColumnOccurence.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnEventID
            // 
            this.DataGridViewTextBoxColumnEventID.DataPropertyName = "EventID";
            this.DataGridViewTextBoxColumnEventID.HeaderText = "EventID";
            this.DataGridViewTextBoxColumnEventID.Name = "DataGridViewTextBoxColumnEventID";
            this.DataGridViewTextBoxColumnEventID.ReadOnly = true;
            this.DataGridViewTextBoxColumnEventID.Visible = false;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 624);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gvContactList);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.gvEventList);
            this.Controls.Add(this.lblAppointmentHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddAppointment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AddAppointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEventList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentHeader;
        private System.Windows.Forms.DataGridView gvEventList;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.DataGridView gvContactList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewcontactCheckColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnContactID;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewCheckColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnOccurence;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnEventID;
    }
}