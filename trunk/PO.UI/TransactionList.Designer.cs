namespace PersonelOrganizer
{
    partial class TransactionList
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateFinish = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gvTran = new System.Windows.Forms.DataGridView();
            this.transaction = new System.Windows.Forms.GroupBox();
            this.monthlyBudget = new System.Windows.Forms.GroupBox();
            this.dateMB = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMonthlyBudgetSearch = new System.Windows.Forms.Button();
            this.ddlExpenseCategory = new System.Windows.Forms.ComboBox();
            this.DataGridViewTextBoxColumnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvTran)).BeginInit();
            this.transaction.SuspendLayout();
            this.monthlyBudget.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Date :";
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(48, 22);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(103, 23);
            this.dateStart.TabIndex = 28;
            // 
            // dateFinish
            // 
            this.dateFinish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinish.Location = new System.Drawing.Point(157, 22);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Size = new System.Drawing.Size(103, 23);
            this.dateFinish.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(338, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gvTran
            // 
            this.gvTran.AllowUserToAddRows = false;
            this.gvTran.BackgroundColor = System.Drawing.Color.White;
            this.gvTran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumnStartDate,
            this.DataGridViewTextBoxColumnEndDate,
            this.DataGridViewTextBoxColumnCategoryName,
            this.DataGridViewTextBoxColumnAmount});
            this.gvTran.Location = new System.Drawing.Point(14, 130);
            this.gvTran.Name = "gvTran";
            this.gvTran.ReadOnly = true;
            this.gvTran.RowHeadersVisible = false;
            this.gvTran.Size = new System.Drawing.Size(411, 490);
            this.gvTran.TabIndex = 31;
            // 
            // transaction
            // 
            this.transaction.Controls.Add(this.dateStart);
            this.transaction.Controls.Add(this.label1);
            this.transaction.Controls.Add(this.btnSearch);
            this.transaction.Controls.Add(this.dateFinish);
            this.transaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.transaction.ForeColor = System.Drawing.Color.DodgerBlue;
            this.transaction.Location = new System.Drawing.Point(14, 12);
            this.transaction.Name = "transaction";
            this.transaction.Size = new System.Drawing.Size(417, 53);
            this.transaction.TabIndex = 32;
            this.transaction.TabStop = false;
            this.transaction.Text = "Transaction List";
            // 
            // monthlyBudget
            // 
            this.monthlyBudget.Controls.Add(this.ddlExpenseCategory);
            this.monthlyBudget.Controls.Add(this.dateMB);
            this.monthlyBudget.Controls.Add(this.label2);
            this.monthlyBudget.Controls.Add(this.btnMonthlyBudgetSearch);
            this.monthlyBudget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthlyBudget.ForeColor = System.Drawing.Color.DodgerBlue;
            this.monthlyBudget.Location = new System.Drawing.Point(14, 71);
            this.monthlyBudget.Name = "monthlyBudget";
            this.monthlyBudget.Size = new System.Drawing.Size(417, 53);
            this.monthlyBudget.TabIndex = 33;
            this.monthlyBudget.TabStop = false;
            this.monthlyBudget.Text = "Monthly Budget List";
            // 
            // dateMB
            // 
            this.dateMB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateMB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMB.Location = new System.Drawing.Point(48, 22);
            this.dateMB.Name = "dateMB";
            this.dateMB.Size = new System.Drawing.Size(103, 23);
            this.dateMB.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Date :";
            // 
            // btnMonthlyBudgetSearch
            // 
            this.btnMonthlyBudgetSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMonthlyBudgetSearch.ForeColor = System.Drawing.Color.Black;
            this.btnMonthlyBudgetSearch.Location = new System.Drawing.Point(338, 24);
            this.btnMonthlyBudgetSearch.Name = "btnMonthlyBudgetSearch";
            this.btnMonthlyBudgetSearch.Size = new System.Drawing.Size(75, 23);
            this.btnMonthlyBudgetSearch.TabIndex = 30;
            this.btnMonthlyBudgetSearch.Text = "Search";
            this.btnMonthlyBudgetSearch.UseVisualStyleBackColor = true;
            this.btnMonthlyBudgetSearch.Click += new System.EventHandler(this.btnMonthlyBudgetSearch_Click);
            // 
            // ddlExpenseCategory
            // 
            this.ddlExpenseCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ddlExpenseCategory.FormattingEnabled = true;
            this.ddlExpenseCategory.Location = new System.Drawing.Point(157, 22);
            this.ddlExpenseCategory.Name = "ddlExpenseCategory";
            this.ddlExpenseCategory.Size = new System.Drawing.Size(123, 23);
            this.ddlExpenseCategory.TabIndex = 59;
            // 
            // DataGridViewTextBoxColumnStartDate
            // 
            this.DataGridViewTextBoxColumnStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumnStartDate.DataPropertyName = "Subject";
            this.DataGridViewTextBoxColumnStartDate.HeaderText = "Subject";
            this.DataGridViewTextBoxColumnStartDate.Name = "DataGridViewTextBoxColumnStartDate";
            this.DataGridViewTextBoxColumnStartDate.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnEndDate
            // 
            this.DataGridViewTextBoxColumnEndDate.DataPropertyName = "Date";
            this.DataGridViewTextBoxColumnEndDate.HeaderText = "DueDate";
            this.DataGridViewTextBoxColumnEndDate.Name = "DataGridViewTextBoxColumnEndDate";
            this.DataGridViewTextBoxColumnEndDate.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnCategoryName
            // 
            this.DataGridViewTextBoxColumnCategoryName.DataPropertyName = "CategoryName";
            this.DataGridViewTextBoxColumnCategoryName.HeaderText = "Category Name";
            this.DataGridViewTextBoxColumnCategoryName.Name = "DataGridViewTextBoxColumnCategoryName";
            this.DataGridViewTextBoxColumnCategoryName.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnAmount
            // 
            this.DataGridViewTextBoxColumnAmount.DataPropertyName = "Amount";
            this.DataGridViewTextBoxColumnAmount.HeaderText = "Amount";
            this.DataGridViewTextBoxColumnAmount.Name = "DataGridViewTextBoxColumnAmount";
            this.DataGridViewTextBoxColumnAmount.ReadOnly = true;
            // 
            // TransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 687);
            this.ControlBox = false;
            this.Controls.Add(this.monthlyBudget);
            this.Controls.Add(this.transaction);
            this.Controls.Add(this.gvTran);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TransactionList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.TransactionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTran)).EndInit();
            this.transaction.ResumeLayout(false);
            this.transaction.PerformLayout();
            this.monthlyBudget.ResumeLayout(false);
            this.monthlyBudget.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateFinish;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gvTran;
        private System.Windows.Forms.GroupBox transaction;
        private System.Windows.Forms.GroupBox monthlyBudget;
        private System.Windows.Forms.DateTimePicker dateMB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMonthlyBudgetSearch;
        private System.Windows.Forms.ComboBox ddlExpenseCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnAmount;
    }
}