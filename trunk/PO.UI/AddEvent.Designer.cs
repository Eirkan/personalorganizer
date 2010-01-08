namespace PersonelOrganizer
{
    partial class AddEvent
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
            this.lblEventHeader = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblOccurence = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.ddlFrequency = new System.Windows.Forms.ComboBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtOccurence = new System.Windows.Forms.TextBox();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblEventHeader
            // 
            this.lblEventHeader.AutoSize = true;
            this.lblEventHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEventHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEventHeader.Location = new System.Drawing.Point(12, 20);
            this.lblEventHeader.Name = "lblEventHeader";
            this.lblEventHeader.Size = new System.Drawing.Size(64, 15);
            this.lblEventHeader.TabIndex = 22;
            this.lblEventHeader.Text = "Add Event";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(87, 51);
            this.txtSubject.MaxLength = 100;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(249, 23);
            this.txtSubject.TabIndex = 24;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubject.Location = new System.Drawing.Point(12, 54);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(55, 15);
            this.lblSubject.TabIndex = 23;
            this.lblSubject.Text = "Subject :";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(87, 80);
            this.txtLocation.MaxLength = 100;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(249, 23);
            this.txtLocation.TabIndex = 26;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLocation.Location = new System.Drawing.Point(12, 83);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(60, 15);
            this.lblLocation.TabIndex = 25;
            this.lblLocation.Text = "Location :";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartDate.Location = new System.Drawing.Point(12, 112);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(74, 15);
            this.lblStartDate.TabIndex = 27;
            this.lblStartDate.Text = "Start  Date :";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuration.Location = new System.Drawing.Point(12, 143);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(62, 15);
            this.lblDuration.TabIndex = 28;
            this.lblDuration.Text = "Duration :";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFrequency.Location = new System.Drawing.Point(12, 172);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(71, 15);
            this.lblFrequency.TabIndex = 29;
            this.lblFrequency.Text = "Frequency :";
            // 
            // lblOccurence
            // 
            this.lblOccurence.AutoSize = true;
            this.lblOccurence.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOccurence.Location = new System.Drawing.Point(12, 203);
            this.lblOccurence.Name = "lblOccurence";
            this.lblOccurence.Size = new System.Drawing.Size(73, 15);
            this.lblOccurence.TabIndex = 30;
            this.lblOccurence.Text = "Occurence :";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNote.Location = new System.Drawing.Point(12, 231);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(41, 15);
            this.lblNote.TabIndex = 31;
            this.lblNote.Text = "Note :";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(87, 231);
            this.txtNote.MaxLength = 100;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(296, 99);
            this.txtNote.TabIndex = 32;
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.Location = new System.Drawing.Point(307, 352);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEvent.TabIndex = 33;
            this.btnSaveEvent.Text = "Save";
            this.btnSaveEvent.UseVisualStyleBackColor = true;
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // ddlFrequency
            // 
            this.ddlFrequency.FormattingEnabled = true;
            this.ddlFrequency.Location = new System.Drawing.Point(89, 169);
            this.ddlFrequency.Name = "ddlFrequency";
            this.ddlFrequency.Size = new System.Drawing.Size(163, 23);
            this.ddlFrequency.TabIndex = 34;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(87, 140);
            this.txtDuration.MaxLength = 100;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(249, 23);
            this.txtDuration.TabIndex = 35;
            // 
            // txtOccurence
            // 
            this.txtOccurence.Location = new System.Drawing.Point(87, 200);
            this.txtOccurence.MaxLength = 100;
            this.txtOccurence.Name = "txtOccurence";
            this.txtOccurence.Size = new System.Drawing.Size(249, 23);
            this.txtOccurence.TabIndex = 36;
            // 
            // dateStartDate
            // 
            this.dateStartDate.Location = new System.Drawing.Point(87, 106);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(139, 23);
            this.dateStartDate.TabIndex = 37;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 624);
            this.ControlBox = false;
            this.Controls.Add(this.dateStartDate);
            this.Controls.Add(this.txtOccurence);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.ddlFrequency);
            this.Controls.Add(this.btnSaveEvent);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblOccurence);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblEventHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddEvent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AddEvent";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventHeader;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblOccurence;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.ComboBox ddlFrequency;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtOccurence;
        private System.Windows.Forms.DateTimePicker dateStartDate;
    }
}