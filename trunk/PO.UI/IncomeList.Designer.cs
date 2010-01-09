namespace PersonelOrganizer
{
    partial class IncomeList
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
            this.gvIncomeList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewTextBoxColumnCreditCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewContactImageColumnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewContactImageColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvIncomeList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddCreditCard
            // 
            this.lblAddCreditCard.AutoSize = true;
            this.lblAddCreditCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddCreditCard.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddCreditCard.Location = new System.Drawing.Point(12, 21);
            this.lblAddCreditCard.Name = "lblAddCreditCard";
            this.lblAddCreditCard.Size = new System.Drawing.Size(71, 15);
            this.lblAddCreditCard.TabIndex = 23;
            this.lblAddCreditCard.Text = "Income List";
            // 
            // gvIncomeList
            // 
            this.gvIncomeList.AllowUserToAddRows = false;
            this.gvIncomeList.BackgroundColor = System.Drawing.Color.White;
            this.gvIncomeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIncomeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumnCreditCardID,
            this.DataGridViewTextBoxColumnSubject,
            this.DataGridViewTextBoxColumnLocation,
            this.DataGridViewTextBoxColumnStartDate,
            this.DataGridViewTextBoxColumnEndDate,
            this.DataGridViewContactImageColumnUpdate,
            this.DataGridViewContactImageColumnDelete});
            this.gvIncomeList.Location = new System.Drawing.Point(15, 52);
            this.gvIncomeList.Name = "gvIncomeList";
            this.gvIncomeList.ReadOnly = true;
            this.gvIncomeList.RowHeadersVisible = false;
            this.gvIncomeList.Size = new System.Drawing.Size(411, 546);
            this.gvIncomeList.TabIndex = 27;
            this.gvIncomeList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvIncomeList_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Credit Card List";
            // 
            // DataGridViewTextBoxColumnCreditCardID
            // 
            this.DataGridViewTextBoxColumnCreditCardID.DataPropertyName = "IncomeID";
            this.DataGridViewTextBoxColumnCreditCardID.HeaderText = "CreditCardID";
            this.DataGridViewTextBoxColumnCreditCardID.Name = "DataGridViewTextBoxColumnCreditCardID";
            this.DataGridViewTextBoxColumnCreditCardID.ReadOnly = true;
            this.DataGridViewTextBoxColumnCreditCardID.Visible = false;
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
            this.DataGridViewTextBoxColumnLocation.DataPropertyName = "Date";
            this.DataGridViewTextBoxColumnLocation.HeaderText = "Date";
            this.DataGridViewTextBoxColumnLocation.Name = "DataGridViewTextBoxColumnLocation";
            this.DataGridViewTextBoxColumnLocation.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnStartDate
            // 
            this.DataGridViewTextBoxColumnStartDate.DataPropertyName = "Amount";
            this.DataGridViewTextBoxColumnStartDate.HeaderText = "Amount";
            this.DataGridViewTextBoxColumnStartDate.Name = "DataGridViewTextBoxColumnStartDate";
            this.DataGridViewTextBoxColumnStartDate.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnEndDate
            // 
            this.DataGridViewTextBoxColumnEndDate.DataPropertyName = "IncomeCategoryName";
            this.DataGridViewTextBoxColumnEndDate.HeaderText = "Income Category";
            this.DataGridViewTextBoxColumnEndDate.Name = "DataGridViewTextBoxColumnEndDate";
            this.DataGridViewTextBoxColumnEndDate.ReadOnly = true;
            this.DataGridViewTextBoxColumnEndDate.Width = 150;
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
            // IncomeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 622);
            this.ControlBox = false;
            this.Controls.Add(this.gvIncomeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddCreditCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "IncomeList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "IncomeList";
            this.Load += new System.EventHandler(this.IncomeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvIncomeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCreditCard;
        private System.Windows.Forms.DataGridView gvIncomeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnCreditCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnEndDate;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewContactImageColumnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewContactImageColumnDelete;
    }
}