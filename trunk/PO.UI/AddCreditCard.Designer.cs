namespace PersonelOrganizer
{
    partial class AddCreditCard
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
            this.lblAddCreditCard = new System.Windows.Forms.Label();
            this.ddlBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateCID = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dateFID = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateCDD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFDD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddCreditCard
            // 
            this.lblAddCreditCard.AutoSize = true;
            this.lblAddCreditCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddCreditCard.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddCreditCard.Location = new System.Drawing.Point(12, 20);
            this.lblAddCreditCard.Name = "lblAddCreditCard";
            this.lblAddCreditCard.Size = new System.Drawing.Size(94, 15);
            this.lblAddCreditCard.TabIndex = 21;
            this.lblAddCreditCard.Text = "Add Credit Card";
            // 
            // ddlBank
            // 
            this.ddlBank.FormattingEnabled = true;
            this.ddlBank.Location = new System.Drawing.Point(137, 48);
            this.ddlBank.Name = "ddlBank";
            this.ddlBank.Size = new System.Drawing.Size(163, 23);
            this.ddlBank.TabIndex = 1;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBank.Location = new System.Drawing.Point(16, 51);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(41, 15);
            this.lblBank.TabIndex = 39;
            this.lblBank.Text = "Bank :";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(137, 77);
            this.txtCardNumber.MaxLength = 100;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(249, 23);
            this.txtCardNumber.TabIndex = 2;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCardNumber.Location = new System.Drawing.Point(16, 80);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(87, 15);
            this.lblCardNumber.TabIndex = 41;
            this.lblCardNumber.Text = "Card Number :";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(137, 106);
            this.txtLimit.MaxLength = 100;
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(249, 23);
            this.txtLimit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Limit :";
            // 
            // dateCID
            // 
            this.dateCID.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCID.Location = new System.Drawing.Point(137, 135);
            this.dateCID.Name = "dateCID";
            this.dateCID.Size = new System.Drawing.Size(139, 23);
            this.dateCID.TabIndex = 4;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartDate.Location = new System.Drawing.Point(16, 141);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(117, 15);
            this.lblStartDate.TabIndex = 45;
            this.lblStartDate.Text = "Current Issue Date :";
            // 
            // dateFID
            // 
            this.dateFID.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFID.Location = new System.Drawing.Point(137, 191);
            this.dateFID.Name = "dateFID";
            this.dateFID.Size = new System.Drawing.Size(139, 23);
            this.dateFID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Future Issue  Date :";
            // 
            // dateCDD
            // 
            this.dateCDD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCDD.Location = new System.Drawing.Point(137, 164);
            this.dateCDD.Name = "dateCDD";
            this.dateCDD.Size = new System.Drawing.Size(139, 23);
            this.dateCDD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Current Due Date :";
            // 
            // dateFDD
            // 
            this.dateFDD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFDD.Location = new System.Drawing.Point(137, 222);
            this.dateFDD.Name = "dateFDD";
            this.dateFDD.Size = new System.Drawing.Size(139, 23);
            this.dateFDD.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Future Due Date :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(310, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 624);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateFDD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateCDD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateFID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateCID);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.ddlBank);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblAddCreditCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddCreditCard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AddCreditCard";
            this.Load += new System.EventHandler(this.AddCreditCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCreditCard;
        private System.Windows.Forms.ComboBox ddlBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateCID;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dateFID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateCDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
    }
}