namespace PersonelOrganizer
{
    partial class AddExpense
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.ddlExpenseCategory = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.ddlPaymentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlCreditCard = new System.Windows.Forms.ComboBox();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.ddlInstallment = new System.Windows.Forms.ComboBox();
            this.lblInstallment = new System.Windows.Forms.Label();
            this.txtInstallmentNo = new System.Windows.Forms.TextBox();
            this.lblInstallmentNo = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddCreditCard
            // 
            this.lblAddCreditCard.AutoSize = true;
            this.lblAddCreditCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddCreditCard.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddCreditCard.Location = new System.Drawing.Point(12, 20);
            this.lblAddCreditCard.Name = "lblAddCreditCard";
            this.lblAddCreditCard.Size = new System.Drawing.Size(98, 15);
            this.lblAddCreditCard.TabIndex = 24;
            this.lblAddCreditCard.Text = "Add Expense Bill";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(132, 113);
            this.txtAmount.MaxLength = 100;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(249, 23);
            this.txtAmount.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "Amount :";
            // 
            // dateDueDate
            // 
            this.dateDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDueDate.Location = new System.Drawing.Point(132, 84);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Size = new System.Drawing.Size(139, 23);
            this.dateDueDate.TabIndex = 53;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartDate.Location = new System.Drawing.Point(14, 90);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(66, 15);
            this.lblStartDate.TabIndex = 54;
            this.lblStartDate.Text = "Due Date :";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(132, 55);
            this.txtSubject.MaxLength = 100;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(249, 23);
            this.txtSubject.TabIndex = 51;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCardNumber.Location = new System.Drawing.Point(14, 58);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(55, 15);
            this.lblCardNumber.TabIndex = 52;
            this.lblCardNumber.Text = "Subject :";
            // 
            // ddlExpenseCategory
            // 
            this.ddlExpenseCategory.FormattingEnabled = true;
            this.ddlExpenseCategory.Location = new System.Drawing.Point(132, 142);
            this.ddlExpenseCategory.Name = "ddlExpenseCategory";
            this.ddlExpenseCategory.Size = new System.Drawing.Size(249, 23);
            this.ddlExpenseCategory.TabIndex = 58;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBank.Location = new System.Drawing.Point(14, 145);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(112, 15);
            this.lblBank.TabIndex = 59;
            this.lblBank.Text = "Expense Category :";
            // 
            // ddlPaymentType
            // 
            this.ddlPaymentType.FormattingEnabled = true;
            this.ddlPaymentType.Items.AddRange(new object[] {
            "Cash",
            "CreditCard"});
            this.ddlPaymentType.Location = new System.Drawing.Point(132, 171);
            this.ddlPaymentType.Name = "ddlPaymentType";
            this.ddlPaymentType.Size = new System.Drawing.Size(249, 23);
            this.ddlPaymentType.TabIndex = 60;
            this.ddlPaymentType.SelectedIndexChanged += new System.EventHandler(this.ddlPaymentType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Payment Type :";
            // 
            // ddlCreditCard
            // 
            this.ddlCreditCard.FormattingEnabled = true;
            this.ddlCreditCard.Location = new System.Drawing.Point(132, 200);
            this.ddlCreditCard.Name = "ddlCreditCard";
            this.ddlCreditCard.Size = new System.Drawing.Size(249, 23);
            this.ddlCreditCard.TabIndex = 62;
            this.ddlCreditCard.Visible = false;
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreditCard.Location = new System.Drawing.Point(14, 203);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(75, 15);
            this.lblCreditCard.TabIndex = 63;
            this.lblCreditCard.Text = "Credit Card :";
            this.lblCreditCard.Visible = false;
            // 
            // ddlInstallment
            // 
            this.ddlInstallment.FormattingEnabled = true;
            this.ddlInstallment.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.ddlInstallment.Location = new System.Drawing.Point(132, 229);
            this.ddlInstallment.Name = "ddlInstallment";
            this.ddlInstallment.Size = new System.Drawing.Size(249, 23);
            this.ddlInstallment.TabIndex = 64;
            this.ddlInstallment.Visible = false;
            this.ddlInstallment.SelectedIndexChanged += new System.EventHandler(this.ddlInstallment_SelectedIndexChanged);
            // 
            // lblInstallment
            // 
            this.lblInstallment.AutoSize = true;
            this.lblInstallment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInstallment.Location = new System.Drawing.Point(14, 232);
            this.lblInstallment.Name = "lblInstallment";
            this.lblInstallment.Size = new System.Drawing.Size(76, 15);
            this.lblInstallment.TabIndex = 65;
            this.lblInstallment.Text = "Installment :";
            this.lblInstallment.Visible = false;
            // 
            // txtInstallmentNo
            // 
            this.txtInstallmentNo.Location = new System.Drawing.Point(132, 258);
            this.txtInstallmentNo.MaxLength = 100;
            this.txtInstallmentNo.Name = "txtInstallmentNo";
            this.txtInstallmentNo.Size = new System.Drawing.Size(249, 23);
            this.txtInstallmentNo.TabIndex = 66;
            this.txtInstallmentNo.Visible = false;
            // 
            // lblInstallmentNo
            // 
            this.lblInstallmentNo.AutoSize = true;
            this.lblInstallmentNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInstallmentNo.Location = new System.Drawing.Point(14, 261);
            this.lblInstallmentNo.Name = "lblInstallmentNo";
            this.lblInstallmentNo.Size = new System.Drawing.Size(95, 15);
            this.lblInstallmentNo.TabIndex = 67;
            this.lblInstallmentNo.Text = "Installment No :";
            this.lblInstallmentNo.Visible = false;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(132, 287);
            this.txtTotalAmount.MaxLength = 100;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(249, 23);
            this.txtTotalAmount.TabIndex = 68;
            this.txtTotalAmount.Visible = false;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalAmount.Location = new System.Drawing.Point(14, 290);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(89, 15);
            this.lblTotalAmount.TabIndex = 69;
            this.lblTotalAmount.Text = "Total Amount :";
            this.lblTotalAmount.Visible = false;
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 622);
            this.ControlBox = false;
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtInstallmentNo);
            this.Controls.Add(this.lblInstallmentNo);
            this.Controls.Add(this.ddlInstallment);
            this.Controls.Add(this.lblInstallment);
            this.Controls.Add(this.ddlCreditCard);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.ddlPaymentType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlExpenseCategory);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDueDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblAddCreditCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddExpense";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AddExpense";
            this.Load += new System.EventHandler(this.AddExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCreditCard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDueDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.ComboBox ddlExpenseCategory;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.ComboBox ddlPaymentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlCreditCard;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.ComboBox ddlInstallment;
        private System.Windows.Forms.Label lblInstallment;
        private System.Windows.Forms.TextBox txtInstallmentNo;
        private System.Windows.Forms.Label lblInstallmentNo;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}