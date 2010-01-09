namespace PersonelOrganizer
{
    partial class AddIncome
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
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.dateCID = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ddlIncomeCategory = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddCreditCard
            // 
            this.lblAddCreditCard.AutoSize = true;
            this.lblAddCreditCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddCreditCard.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddCreditCard.Location = new System.Drawing.Point(12, 18);
            this.lblAddCreditCard.Name = "lblAddCreditCard";
            this.lblAddCreditCard.Size = new System.Drawing.Size(74, 15);
            this.lblAddCreditCard.TabIndex = 23;
            this.lblAddCreditCard.Text = "Add Income";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(130, 49);
            this.txtSubject.MaxLength = 100;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(249, 23);
            this.txtSubject.TabIndex = 42;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCardNumber.Location = new System.Drawing.Point(12, 52);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(55, 15);
            this.lblCardNumber.TabIndex = 43;
            this.lblCardNumber.Text = "Subject :";
            // 
            // dateCID
            // 
            this.dateCID.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCID.Location = new System.Drawing.Point(130, 78);
            this.dateCID.Name = "dateCID";
            this.dateCID.Size = new System.Drawing.Size(139, 23);
            this.dateCID.TabIndex = 46;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartDate.Location = new System.Drawing.Point(12, 84);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(40, 15);
            this.lblStartDate.TabIndex = 47;
            this.lblStartDate.Text = "Date :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(130, 107);
            this.txtAmount.MaxLength = 100;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(249, 23);
            this.txtAmount.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Amount :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ddlIncomeCategory
            // 
            this.ddlIncomeCategory.FormattingEnabled = true;
            this.ddlIncomeCategory.Location = new System.Drawing.Point(130, 136);
            this.ddlIncomeCategory.Name = "ddlIncomeCategory";
            this.ddlIncomeCategory.Size = new System.Drawing.Size(163, 23);
            this.ddlIncomeCategory.TabIndex = 51;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBank.Location = new System.Drawing.Point(12, 139);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(108, 15);
            this.lblBank.TabIndex = 52;
            this.lblBank.Text = "Income Category :";
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 622);
            this.ControlBox = false;
            this.Controls.Add(this.ddlIncomeCategory);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateCID);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblAddCreditCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddIncome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AddIncome";
            this.Load += new System.EventHandler(this.AddIncome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCreditCard;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.DateTimePicker dateCID;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox ddlIncomeCategory;
        private System.Windows.Forms.Label lblBank;
    }
}