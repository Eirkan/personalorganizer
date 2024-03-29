﻿namespace PersonelOrganizer
{
    partial class CreditCardList
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
            this.gvCardList = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumnCreditCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewContactImageColumnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewContactImageColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvCardList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddCreditCard
            // 
            this.lblAddCreditCard.AutoSize = true;
            this.lblAddCreditCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddCreditCard.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddCreditCard.Location = new System.Drawing.Point(12, 21);
            this.lblAddCreditCard.Name = "lblAddCreditCard";
            this.lblAddCreditCard.Size = new System.Drawing.Size(91, 15);
            this.lblAddCreditCard.TabIndex = 22;
            this.lblAddCreditCard.Text = "Credit Card List";
            // 
            // gvCardList
            // 
            this.gvCardList.AllowUserToAddRows = false;
            this.gvCardList.BackgroundColor = System.Drawing.Color.White;
            this.gvCardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCardList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumnCreditCardID,
            this.DataGridViewTextBoxColumnSubject,
            this.DataGridViewTextBoxColumnLocation,
            this.DataGridViewTextBoxColumnStartDate,
            this.DataGridViewTextBoxColumnEndDate,
            this.DataGridViewTextBoxColumnDuration,
            this.DataGridViewTextBoxColumnNote,
            this.DataGridViewTextBoxColumnFrequency,
            this.DataGridViewContactImageColumnUpdate,
            this.DataGridViewContactImageColumnDelete});
            this.gvCardList.Location = new System.Drawing.Point(15, 49);
            this.gvCardList.Name = "gvCardList";
            this.gvCardList.ReadOnly = true;
            this.gvCardList.RowHeadersVisible = false;
            this.gvCardList.Size = new System.Drawing.Size(411, 546);
            this.gvCardList.TabIndex = 25;
            this.gvCardList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvCardList_CellMouseClick);
            // 
            // DataGridViewTextBoxColumnCreditCardID
            // 
            this.DataGridViewTextBoxColumnCreditCardID.DataPropertyName = "CreditCardID";
            this.DataGridViewTextBoxColumnCreditCardID.HeaderText = "CreditCardID";
            this.DataGridViewTextBoxColumnCreditCardID.Name = "DataGridViewTextBoxColumnCreditCardID";
            this.DataGridViewTextBoxColumnCreditCardID.ReadOnly = true;
            this.DataGridViewTextBoxColumnCreditCardID.Visible = false;
            // 
            // DataGridViewTextBoxColumnSubject
            // 
            this.DataGridViewTextBoxColumnSubject.DataPropertyName = "BankName";
            this.DataGridViewTextBoxColumnSubject.HeaderText = "Bank";
            this.DataGridViewTextBoxColumnSubject.Name = "DataGridViewTextBoxColumnSubject";
            this.DataGridViewTextBoxColumnSubject.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnLocation
            // 
            this.DataGridViewTextBoxColumnLocation.DataPropertyName = "CardNumber";
            this.DataGridViewTextBoxColumnLocation.HeaderText = "Card Number";
            this.DataGridViewTextBoxColumnLocation.Name = "DataGridViewTextBoxColumnLocation";
            this.DataGridViewTextBoxColumnLocation.ReadOnly = true;
            this.DataGridViewTextBoxColumnLocation.Width = 150;
            // 
            // DataGridViewTextBoxColumnStartDate
            // 
            this.DataGridViewTextBoxColumnStartDate.DataPropertyName = "Limit";
            this.DataGridViewTextBoxColumnStartDate.HeaderText = "Limit";
            this.DataGridViewTextBoxColumnStartDate.Name = "DataGridViewTextBoxColumnStartDate";
            this.DataGridViewTextBoxColumnStartDate.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnEndDate
            // 
            this.DataGridViewTextBoxColumnEndDate.DataPropertyName = "CurrentIssueDate";
            this.DataGridViewTextBoxColumnEndDate.HeaderText = "Cuurent Issue Date";
            this.DataGridViewTextBoxColumnEndDate.Name = "DataGridViewTextBoxColumnEndDate";
            this.DataGridViewTextBoxColumnEndDate.ReadOnly = true;
            this.DataGridViewTextBoxColumnEndDate.Width = 150;
            // 
            // DataGridViewTextBoxColumnDuration
            // 
            this.DataGridViewTextBoxColumnDuration.DataPropertyName = "FutureIssueDate";
            this.DataGridViewTextBoxColumnDuration.HeaderText = "Future Issue Date";
            this.DataGridViewTextBoxColumnDuration.Name = "DataGridViewTextBoxColumnDuration";
            this.DataGridViewTextBoxColumnDuration.ReadOnly = true;
            this.DataGridViewTextBoxColumnDuration.Visible = false;
            this.DataGridViewTextBoxColumnDuration.Width = 150;
            // 
            // DataGridViewTextBoxColumnNote
            // 
            this.DataGridViewTextBoxColumnNote.DataPropertyName = "CurrentDueDate";
            this.DataGridViewTextBoxColumnNote.HeaderText = "Current Due Date";
            this.DataGridViewTextBoxColumnNote.Name = "DataGridViewTextBoxColumnNote";
            this.DataGridViewTextBoxColumnNote.ReadOnly = true;
            this.DataGridViewTextBoxColumnNote.Width = 150;
            // 
            // DataGridViewTextBoxColumnFrequency
            // 
            this.DataGridViewTextBoxColumnFrequency.DataPropertyName = "FutureDueDate";
            this.DataGridViewTextBoxColumnFrequency.HeaderText = "Future Due Date";
            this.DataGridViewTextBoxColumnFrequency.Name = "DataGridViewTextBoxColumnFrequency";
            this.DataGridViewTextBoxColumnFrequency.ReadOnly = true;
            this.DataGridViewTextBoxColumnFrequency.Width = 150;
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
            // CreditCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 624);
            this.ControlBox = false;
            this.Controls.Add(this.gvCardList);
            this.Controls.Add(this.lblAddCreditCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CreditCardList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CreditCardList";
            this.Load += new System.EventHandler(this.CreditCardList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCardList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCreditCard;
        private System.Windows.Forms.DataGridView gvCardList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnCreditCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnFrequency;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewContactImageColumnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewContactImageColumnDelete;
    }
}