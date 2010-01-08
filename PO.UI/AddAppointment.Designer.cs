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
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 624);
            this.ControlBox = false;
            this.Controls.Add(this.lblAppointmentHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddAppointment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AddAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentHeader;
    }
}