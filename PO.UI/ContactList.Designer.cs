namespace PersonelOrganizer
{
    partial class ContactList
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
            this.gvContactList = new System.Windows.Forms.DataGridView();
            this.lblContactList = new System.Windows.Forms.Label();
            this.gvMail = new System.Windows.Forms.DataGridView();
            this.gvWebPage = new System.Windows.Forms.DataGridView();
            this.gvPhone = new System.Windows.Forms.DataGridView();
            this.gvAddress = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlContactDetail = new System.Windows.Forms.TabControl();
            this.tabPageMail = new System.Windows.Forms.TabPage();
            this.tabPageWebPage = new System.Windows.Forms.TabPage();
            this.tabPagePhoneNumber = new System.Windows.Forms.TabPage();
            this.tabPageAddress = new System.Windows.Forms.TabPage();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.MailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewImageColumnSelect = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewContactImageColumnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewContactImageColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWebPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddress)).BeginInit();
            this.tabControlContactDetail.SuspendLayout();
            this.tabPageMail.SuspendLayout();
            this.tabPageWebPage.SuspendLayout();
            this.tabPagePhoneNumber.SuspendLayout();
            this.tabPageAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvContactList
            // 
            this.gvContactList.AllowUserToAddRows = false;
            this.gvContactList.BackgroundColor = System.Drawing.Color.White;
            this.gvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewImageColumnSelect,
            this.DataGridViewTextBoxColumnName,
            this.DataGridViewTextBoxColumnSurname,
            this.DataGridViewTextBoxColumnCompany,
            this.DataGridViewTextBoxColumnContactID,
            this.DataGridViewContactImageColumnUpdate,
            this.DataGridViewContactImageColumnDelete});
            this.gvContactList.Location = new System.Drawing.Point(16, 44);
            this.gvContactList.Name = "gvContactList";
            this.gvContactList.ReadOnly = true;
            this.gvContactList.RowHeadersVisible = false;
            this.gvContactList.Size = new System.Drawing.Size(411, 296);
            this.gvContactList.TabIndex = 19;
            this.gvContactList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvContactList_CellMouseClick);
            // 
            // lblContactList
            // 
            this.lblContactList.AutoSize = true;
            this.lblContactList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContactList.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblContactList.Location = new System.Drawing.Point(10, 14);
            this.lblContactList.Name = "lblContactList";
            this.lblContactList.Size = new System.Drawing.Size(72, 15);
            this.lblContactList.TabIndex = 20;
            this.lblContactList.Text = "Contact List";
            // 
            // gvMail
            // 
            this.gvMail.AllowUserToAddRows = false;
            this.gvMail.BackgroundColor = System.Drawing.Color.White;
            this.gvMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MailAddress});
            this.gvMail.Location = new System.Drawing.Point(9, 16);
            this.gvMail.Name = "gvMail";
            this.gvMail.ReadOnly = true;
            this.gvMail.RowHeadersVisible = false;
            this.gvMail.Size = new System.Drawing.Size(392, 170);
            this.gvMail.TabIndex = 25;
            // 
            // gvWebPage
            // 
            this.gvWebPage.AllowUserToAddRows = false;
            this.gvWebPage.AllowUserToDeleteRows = false;
            this.gvWebPage.BackgroundColor = System.Drawing.Color.White;
            this.gvWebPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWebPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.gvWebPage.Location = new System.Drawing.Point(6, 17);
            this.gvWebPage.Name = "gvWebPage";
            this.gvWebPage.ReadOnly = true;
            this.gvWebPage.RowHeadersVisible = false;
            this.gvWebPage.Size = new System.Drawing.Size(396, 169);
            this.gvWebPage.TabIndex = 28;
            // 
            // gvPhone
            // 
            this.gvPhone.AllowUserToAddRows = false;
            this.gvPhone.AllowUserToDeleteRows = false;
            this.gvPhone.BackgroundColor = System.Drawing.Color.White;
            this.gvPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.gvPhone.Location = new System.Drawing.Point(6, 17);
            this.gvPhone.Name = "gvPhone";
            this.gvPhone.ReadOnly = true;
            this.gvPhone.RowHeadersVisible = false;
            this.gvPhone.Size = new System.Drawing.Size(392, 169);
            this.gvPhone.TabIndex = 36;
            // 
            // gvAddress
            // 
            this.gvAddress.AllowUserToAddRows = false;
            this.gvAddress.AllowUserToDeleteRows = false;
            this.gvAddress.BackgroundColor = System.Drawing.Color.White;
            this.gvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.gvAddress.Location = new System.Drawing.Point(6, 20);
            this.gvAddress.Name = "gvAddress";
            this.gvAddress.ReadOnly = true;
            this.gvAddress.RowHeadersVisible = false;
            this.gvAddress.Size = new System.Drawing.Size(392, 166);
            this.gvAddress.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(9, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Contact Details";
            // 
            // tabControlContactDetail
            // 
            this.tabControlContactDetail.Controls.Add(this.tabPageMail);
            this.tabControlContactDetail.Controls.Add(this.tabPageWebPage);
            this.tabControlContactDetail.Controls.Add(this.tabPagePhoneNumber);
            this.tabControlContactDetail.Controls.Add(this.tabPageAddress);
            this.tabControlContactDetail.Location = new System.Drawing.Point(12, 378);
            this.tabControlContactDetail.Name = "tabControlContactDetail";
            this.tabControlContactDetail.SelectedIndex = 0;
            this.tabControlContactDetail.Size = new System.Drawing.Size(414, 220);
            this.tabControlContactDetail.TabIndex = 39;
            // 
            // tabPageMail
            // 
            this.tabPageMail.Controls.Add(this.gvMail);
            this.tabPageMail.Location = new System.Drawing.Point(4, 24);
            this.tabPageMail.Name = "tabPageMail";
            this.tabPageMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMail.Size = new System.Drawing.Size(416, 192);
            this.tabPageMail.TabIndex = 0;
            this.tabPageMail.Text = "E-Mail";
            this.tabPageMail.UseVisualStyleBackColor = true;
            // 
            // tabPageWebPage
            // 
            this.tabPageWebPage.Controls.Add(this.gvWebPage);
            this.tabPageWebPage.Location = new System.Drawing.Point(4, 24);
            this.tabPageWebPage.Name = "tabPageWebPage";
            this.tabPageWebPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWebPage.Size = new System.Drawing.Size(416, 192);
            this.tabPageWebPage.TabIndex = 1;
            this.tabPageWebPage.Text = "WebPage";
            this.tabPageWebPage.UseVisualStyleBackColor = true;
            // 
            // tabPagePhoneNumber
            // 
            this.tabPagePhoneNumber.Controls.Add(this.gvPhone);
            this.tabPagePhoneNumber.Location = new System.Drawing.Point(4, 24);
            this.tabPagePhoneNumber.Name = "tabPagePhoneNumber";
            this.tabPagePhoneNumber.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhoneNumber.Size = new System.Drawing.Size(416, 192);
            this.tabPagePhoneNumber.TabIndex = 2;
            this.tabPagePhoneNumber.Text = "Phone Number";
            this.tabPagePhoneNumber.UseVisualStyleBackColor = true;
            // 
            // tabPageAddress
            // 
            this.tabPageAddress.Controls.Add(this.gvAddress);
            this.tabPageAddress.Location = new System.Drawing.Point(4, 24);
            this.tabPageAddress.Name = "tabPageAddress";
            this.tabPageAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddress.Size = new System.Drawing.Size(406, 192);
            this.tabPageAddress.TabIndex = 3;
            this.tabPageAddress.Text = "Postal Address";
            this.tabPageAddress.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Select";
            this.dataGridViewImageColumn1.Image = global::PersonelOrganizer.Properties.Resources.go_small;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Details";
            this.dataGridViewImageColumn2.Image = global::PersonelOrganizer.Properties.Resources.report_small;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Select";
            this.dataGridViewImageColumn3.Image = global::PersonelOrganizer.Properties.Resources.go_small;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 50;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Update";
            this.dataGridViewImageColumn4.Image = global::PersonelOrganizer.Properties.Resources.document_edit_small;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Width = 50;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.HeaderText = "Delete";
            this.dataGridViewImageColumn5.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn5.Width = 50;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.HeaderText = "Select";
            this.dataGridViewImageColumn6.Image = global::PersonelOrganizer.Properties.Resources.go_small;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn6.Width = 50;
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.HeaderText = "Delete";
            this.dataGridViewImageColumn7.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            this.dataGridViewImageColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn7.Width = 50;
            // 
            // dataGridViewImageColumn8
            // 
            this.dataGridViewImageColumn8.HeaderText = "Select";
            this.dataGridViewImageColumn8.Image = global::PersonelOrganizer.Properties.Resources.go_small;
            this.dataGridViewImageColumn8.Name = "dataGridViewImageColumn8";
            this.dataGridViewImageColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn8.Width = 50;
            // 
            // dataGridViewImageColumn9
            // 
            this.dataGridViewImageColumn9.HeaderText = "Delete";
            this.dataGridViewImageColumn9.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.dataGridViewImageColumn9.Name = "dataGridViewImageColumn9";
            this.dataGridViewImageColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn9.Width = 50;
            // 
            // dataGridViewImageColumn10
            // 
            this.dataGridViewImageColumn10.HeaderText = "Delete";
            this.dataGridViewImageColumn10.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.dataGridViewImageColumn10.Name = "dataGridViewImageColumn10";
            this.dataGridViewImageColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn10.Width = 50;
            // 
            // MailAddress
            // 
            this.MailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MailAddress.HeaderText = "E-Mail Address";
            this.MailAddress.Name = "MailAddress";
            this.MailAddress.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Web Page";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Postal Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // DataGridViewImageColumnSelect
            // 
            this.DataGridViewImageColumnSelect.HeaderText = "Select";
            this.DataGridViewImageColumnSelect.Image = global::PersonelOrganizer.Properties.Resources.go_small;
            this.DataGridViewImageColumnSelect.Name = "DataGridViewImageColumnSelect";
            this.DataGridViewImageColumnSelect.ReadOnly = true;
            this.DataGridViewImageColumnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewImageColumnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DataGridViewImageColumnSelect.Width = 50;
            // 
            // DataGridViewTextBoxColumnName
            // 
            this.DataGridViewTextBoxColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumnName.HeaderText = "Name";
            this.DataGridViewTextBoxColumnName.Name = "DataGridViewTextBoxColumnName";
            this.DataGridViewTextBoxColumnName.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnSurname
            // 
            this.DataGridViewTextBoxColumnSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumnSurname.HeaderText = "Surname";
            this.DataGridViewTextBoxColumnSurname.Name = "DataGridViewTextBoxColumnSurname";
            this.DataGridViewTextBoxColumnSurname.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnCompany
            // 
            this.DataGridViewTextBoxColumnCompany.HeaderText = "Company";
            this.DataGridViewTextBoxColumnCompany.Name = "DataGridViewTextBoxColumnCompany";
            this.DataGridViewTextBoxColumnCompany.ReadOnly = true;
            this.DataGridViewTextBoxColumnCompany.Width = 106;
            // 
            // DataGridViewTextBoxColumnContactID
            // 
            this.DataGridViewTextBoxColumnContactID.HeaderText = "ContactID";
            this.DataGridViewTextBoxColumnContactID.Name = "DataGridViewTextBoxColumnContactID";
            this.DataGridViewTextBoxColumnContactID.ReadOnly = true;
            this.DataGridViewTextBoxColumnContactID.Visible = false;
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
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 624);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlContactDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContactList);
            this.Controls.Add(this.gvContactList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ContactList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.ContactList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWebPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddress)).EndInit();
            this.tabControlContactDetail.ResumeLayout(false);
            this.tabPageMail.ResumeLayout(false);
            this.tabPageWebPage.ResumeLayout(false);
            this.tabPagePhoneNumber.ResumeLayout(false);
            this.tabPageAddress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvContactList;
        private System.Windows.Forms.Label lblContactList;
        private System.Windows.Forms.DataGridView gvMail;
        private System.Windows.Forms.DataGridView gvWebPage;
        private System.Windows.Forms.DataGridView gvPhone;
        private System.Windows.Forms.DataGridView gvAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControlContactDetail;
        private System.Windows.Forms.TabPage tabPageMail;
        private System.Windows.Forms.TabPage tabPageWebPage;
        private System.Windows.Forms.TabPage tabPagePhoneNumber;
        private System.Windows.Forms.TabPage tabPageAddress;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewImageColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnContactID;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewContactImageColumnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewContactImageColumnDelete;
    }
}