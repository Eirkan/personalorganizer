namespace PersonelOrganizer
{
    partial class ExpenseList
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
            this.gvExpenseList = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnExpenseCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnNumberOfInstallment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewContactImageColumnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewContactImageColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvExpenseList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddCreditCard
            // 
            this.lblAddCreditCard.AutoSize = true;
            this.lblAddCreditCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddCreditCard.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddCreditCard.Location = new System.Drawing.Point(12, 19);
            this.lblAddCreditCard.Name = "lblAddCreditCard";
            this.lblAddCreditCard.Size = new System.Drawing.Size(75, 15);
            this.lblAddCreditCard.TabIndex = 25;
            this.lblAddCreditCard.Text = "Expense List";
            // 
            // gvExpenseList
            // 
            this.gvExpenseList.AllowUserToAddRows = false;
            this.gvExpenseList.BackgroundColor = System.Drawing.Color.White;
            this.gvExpenseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExpenseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumnSubject,
            this.DataGridViewTextBoxColumnLocation,
            this.DataGridViewTextBoxColumnStartDate,
            this.DataGridViewTextBoxColumnEndDate,
            this.DataGridViewTextBoxColumnAmount,
            this.DataGridViewTextBoxColumnExpenseCategoryName,
            this.DataGridViewTextBoxColumnNumberOfInstallment,
            this.DataGridViewTextBoxColumnTotalAmount,
            this.DataGridViewContactImageColumnUpdate,
            this.DataGridViewContactImageColumnDelete});
            this.gvExpenseList.Location = new System.Drawing.Point(14, 46);
            this.gvExpenseList.Name = "gvExpenseList";
            this.gvExpenseList.ReadOnly = true;
            this.gvExpenseList.RowHeadersVisible = false;
            this.gvExpenseList.Size = new System.Drawing.Size(411, 553);
            this.gvExpenseList.TabIndex = 28;
            this.gvExpenseList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvExpenseList_CellMouseClick);
            // 
            // DataGridViewTextBoxColumnSubject
            // 
            this.DataGridViewTextBoxColumnSubject.DataPropertyName = "InstallmentID";
            this.DataGridViewTextBoxColumnSubject.HeaderText = "InstallmentID";
            this.DataGridViewTextBoxColumnSubject.Name = "DataGridViewTextBoxColumnSubject";
            this.DataGridViewTextBoxColumnSubject.ReadOnly = true;
            this.DataGridViewTextBoxColumnSubject.Visible = false;
            // 
            // DataGridViewTextBoxColumnLocation
            // 
            this.DataGridViewTextBoxColumnLocation.DataPropertyName = "ExpenseBillID";
            this.DataGridViewTextBoxColumnLocation.HeaderText = "ExpenseBillID";
            this.DataGridViewTextBoxColumnLocation.Name = "DataGridViewTextBoxColumnLocation";
            this.DataGridViewTextBoxColumnLocation.ReadOnly = true;
            this.DataGridViewTextBoxColumnLocation.Visible = false;
            // 
            // DataGridViewTextBoxColumnStartDate
            // 
            this.DataGridViewTextBoxColumnStartDate.DataPropertyName = "Subject";
            this.DataGridViewTextBoxColumnStartDate.HeaderText = "Subject";
            this.DataGridViewTextBoxColumnStartDate.Name = "DataGridViewTextBoxColumnStartDate";
            this.DataGridViewTextBoxColumnStartDate.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnEndDate
            // 
            this.DataGridViewTextBoxColumnEndDate.DataPropertyName = "DueDate";
            this.DataGridViewTextBoxColumnEndDate.HeaderText = "DueDate";
            this.DataGridViewTextBoxColumnEndDate.Name = "DataGridViewTextBoxColumnEndDate";
            this.DataGridViewTextBoxColumnEndDate.ReadOnly = true;
            this.DataGridViewTextBoxColumnEndDate.Width = 150;
            // 
            // DataGridViewTextBoxColumnAmount
            // 
            this.DataGridViewTextBoxColumnAmount.DataPropertyName = "Amount";
            this.DataGridViewTextBoxColumnAmount.HeaderText = "Amount";
            this.DataGridViewTextBoxColumnAmount.Name = "DataGridViewTextBoxColumnAmount";
            this.DataGridViewTextBoxColumnAmount.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnExpenseCategoryName
            // 
            this.DataGridViewTextBoxColumnExpenseCategoryName.DataPropertyName = "ExpenseCategoryName";
            this.DataGridViewTextBoxColumnExpenseCategoryName.HeaderText = "Expense Category Name";
            this.DataGridViewTextBoxColumnExpenseCategoryName.Name = "DataGridViewTextBoxColumnExpenseCategoryName";
            this.DataGridViewTextBoxColumnExpenseCategoryName.ReadOnly = true;
            this.DataGridViewTextBoxColumnExpenseCategoryName.Width = 200;
            // 
            // DataGridViewTextBoxColumnNumberOfInstallment
            // 
            this.DataGridViewTextBoxColumnNumberOfInstallment.DataPropertyName = "NumberOfInstallment";
            this.DataGridViewTextBoxColumnNumberOfInstallment.HeaderText = "Number Of Installment";
            this.DataGridViewTextBoxColumnNumberOfInstallment.Name = "DataGridViewTextBoxColumnNumberOfInstallment";
            this.DataGridViewTextBoxColumnNumberOfInstallment.ReadOnly = true;
            this.DataGridViewTextBoxColumnNumberOfInstallment.Width = 200;
            // 
            // DataGridViewTextBoxColumnTotalAmount
            // 
            this.DataGridViewTextBoxColumnTotalAmount.DataPropertyName = "TotalAmount";
            this.DataGridViewTextBoxColumnTotalAmount.HeaderText = "Total Amount";
            this.DataGridViewTextBoxColumnTotalAmount.Name = "DataGridViewTextBoxColumnTotalAmount";
            this.DataGridViewTextBoxColumnTotalAmount.ReadOnly = true;
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
            // ExpenseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 622);
            this.ControlBox = false;
            this.Controls.Add(this.gvExpenseList);
            this.Controls.Add(this.lblAddCreditCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ExpenseList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ExpenseList";
            this.Load += new System.EventHandler(this.ExpenseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvExpenseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCreditCard;
        private System.Windows.Forms.DataGridView gvExpenseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnExpenseCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnNumberOfInstallment;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnTotalAmount;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewContactImageColumnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewContactImageColumnDelete;
    }
}