namespace PersonelOrganizer
{
    partial class EventList
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
            this.lblEventListHeader = new System.Windows.Forms.Label();
            this.gvEventList = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnOccurence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnEventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewContactImageColumnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewContactImageColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventListHeader
            // 
            this.lblEventListHeader.AutoSize = true;
            this.lblEventListHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEventListHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEventListHeader.Location = new System.Drawing.Point(12, 22);
            this.lblEventListHeader.Name = "lblEventListHeader";
            this.lblEventListHeader.Size = new System.Drawing.Size(61, 15);
            this.lblEventListHeader.TabIndex = 23;
            this.lblEventListHeader.Text = "Event List";
            // 
            // gvEventList
            // 
            this.gvEventList.AllowUserToAddRows = false;
            this.gvEventList.BackgroundColor = System.Drawing.Color.White;
            this.gvEventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEventList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumnSubject,
            this.DataGridViewTextBoxColumnLocation,
            this.DataGridViewTextBoxColumnStartDate,
            this.DataGridViewTextBoxColumnDuration,
            this.DataGridViewTextBoxColumnNote,
            this.DataGridViewTextBoxColumnFrequency,
            this.DataGridViewTextBoxColumnOccurence,
            this.DataGridViewTextBoxColumnEventID,
            this.DataGridViewContactImageColumnUpdate,
            this.DataGridViewContactImageColumnDelete});
            this.gvEventList.Location = new System.Drawing.Point(12, 50);
            this.gvEventList.Name = "gvEventList";
            this.gvEventList.ReadOnly = true;
            this.gvEventList.RowHeadersVisible = false;
            this.gvEventList.Size = new System.Drawing.Size(411, 541);
            this.gvEventList.TabIndex = 24;
            this.gvEventList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvEventList_CellMouseClick);
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
            this.DataGridViewTextBoxColumnEventID.HeaderText = "EventID";
            this.DataGridViewTextBoxColumnEventID.Name = "DataGridViewTextBoxColumnEventID";
            this.DataGridViewTextBoxColumnEventID.ReadOnly = true;
            this.DataGridViewTextBoxColumnEventID.Visible = false;
            // 
            // DataGridViewContactImageColumnUpdate
            // 
            this.DataGridViewContactImageColumnUpdate.HeaderText = "Update";
            this.DataGridViewContactImageColumnUpdate.Image = global::PersonelOrganizer.Properties.Resources.document_edit_small;
            this.DataGridViewContactImageColumnUpdate.Name = "DataGridViewContactImageColumnUpdate";
            this.DataGridViewContactImageColumnUpdate.ReadOnly = true;
            this.DataGridViewContactImageColumnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewContactImageColumnUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DataGridViewContactImageColumnUpdate.Width = 50;
            // 
            // DataGridViewContactImageColumnDelete
            // 
            this.DataGridViewContactImageColumnDelete.HeaderText = "Delete";
            this.DataGridViewContactImageColumnDelete.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.DataGridViewContactImageColumnDelete.Name = "DataGridViewContactImageColumnDelete";
            this.DataGridViewContactImageColumnDelete.ReadOnly = true;
            this.DataGridViewContactImageColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewContactImageColumnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DataGridViewContactImageColumnDelete.Width = 50;
            // 
            // EventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 624);
            this.ControlBox = false;
            this.Controls.Add(this.gvEventList);
            this.Controls.Add(this.lblEventListHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EventList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EventList";
            this.Load += new System.EventHandler(this.EventList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEventList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventListHeader;
        private System.Windows.Forms.DataGridView gvEventList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnOccurence;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnEventID;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewContactImageColumnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewContactImageColumnDelete;
    }
}