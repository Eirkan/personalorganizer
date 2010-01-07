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
            this.lblWebPage = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.gvMail = new System.Windows.Forms.DataGridView();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnAddMail = new System.Windows.Forms.Button();
            this.gvWebPage = new System.Windows.Forms.DataGridView();
            this.txtWebPage = new System.Windows.Forms.TextBox();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gvPhone = new System.Windows.Forms.DataGridView();
            this.gvAddress = new System.Windows.Forms.DataGridView();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlContactDetail = new System.Windows.Forms.TabControl();
            this.tabPageMail = new System.Windows.Forms.TabPage();
            this.tabPageWebPage = new System.Windows.Forms.TabPage();
            this.tabPagePhoneNumber = new System.Windows.Forms.TabPage();
            this.tabPageAddress = new System.Windows.Forms.TabPage();
            this.MailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.MailDataGridViewImageColumnSelect = new System.Windows.Forms.DataGridViewImageColumn();
            this.MailDataGridViewImageColumnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.MailDataGridViewImageColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.WebPageDataGridViewTextBoxColumnSelect = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebPageDataGridViewImageColumnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewButtonColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.PhoneNumberDataGridViewTextBoxColumnSelect = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumberDataGridViewImageColumnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddressDataGridViewImageColumnSelect = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressDataGridViewImageColumnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewImageColumnSelect = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DataGridViewTextBoxColumnContactID});
            this.gvContactList.Location = new System.Drawing.Point(5, 31);
            this.gvContactList.Name = "gvContactList";
            this.gvContactList.ReadOnly = true;
            this.gvContactList.RowHeadersVisible = false;
            this.gvContactList.Size = new System.Drawing.Size(422, 296);
            this.gvContactList.TabIndex = 19;
            this.gvContactList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvContactList_CellMouseClick);
            // 
            // lblContactList
            // 
            this.lblContactList.AutoSize = true;
            this.lblContactList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContactList.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblContactList.Location = new System.Drawing.Point(1, 13);
            this.lblContactList.Name = "lblContactList";
            this.lblContactList.Size = new System.Drawing.Size(72, 15);
            this.lblContactList.TabIndex = 20;
            this.lblContactList.Text = "Contact List";
            // 
            // lblWebPage
            // 
            this.lblWebPage.AutoSize = true;
            this.lblWebPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWebPage.ForeColor = System.Drawing.Color.Black;
            this.lblWebPage.Location = new System.Drawing.Point(3, 18);
            this.lblWebPage.Name = "lblWebPage";
            this.lblWebPage.Size = new System.Drawing.Size(66, 15);
            this.lblWebPage.TabIndex = 21;
            this.lblWebPage.Text = "WebPage :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.Black;
            this.lblMail.Location = new System.Drawing.Point(6, 26);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 15);
            this.lblMail.TabIndex = 22;
            this.lblMail.Text = "E-Mail :";
            // 
            // gvMail
            // 
            this.gvMail.AllowUserToAddRows = false;
            this.gvMail.BackgroundColor = System.Drawing.Color.White;
            this.gvMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MailDataGridViewImageColumnSelect,
            this.MailAddress,
            this.MailDataGridViewImageColumnUpdate,
            this.MailDataGridViewImageColumnDelete});
            this.gvMail.Location = new System.Drawing.Point(6, 52);
            this.gvMail.Name = "gvMail";
            this.gvMail.ReadOnly = true;
            this.gvMail.RowHeadersVisible = false;
            this.gvMail.Size = new System.Drawing.Size(404, 134);
            this.gvMail.TabIndex = 25;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(71, 23);
            this.txtMail.MaxLength = 100;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(278, 23);
            this.txtMail.TabIndex = 24;
            // 
            // btnAddMail
            // 
            this.btnAddMail.Location = new System.Drawing.Point(355, 22);
            this.btnAddMail.Name = "btnAddMail";
            this.btnAddMail.Size = new System.Drawing.Size(55, 23);
            this.btnAddMail.TabIndex = 23;
            this.btnAddMail.Text = "Save";
            this.btnAddMail.UseVisualStyleBackColor = true;
            // 
            // gvWebPage
            // 
            this.gvWebPage.AllowUserToAddRows = false;
            this.gvWebPage.AllowUserToDeleteRows = false;
            this.gvWebPage.BackgroundColor = System.Drawing.Color.White;
            this.gvWebPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWebPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WebPageDataGridViewTextBoxColumnSelect,
            this.dataGridViewTextBoxColumn1,
            this.WebPageDataGridViewImageColumnUpdate,
            this.dataGridViewButtonColumnDelete});
            this.gvWebPage.Location = new System.Drawing.Point(6, 44);
            this.gvWebPage.Name = "gvWebPage";
            this.gvWebPage.ReadOnly = true;
            this.gvWebPage.RowHeadersVisible = false;
            this.gvWebPage.Size = new System.Drawing.Size(399, 142);
            this.gvWebPage.TabIndex = 28;
            // 
            // txtWebPage
            // 
            this.txtWebPage.Location = new System.Drawing.Point(75, 15);
            this.txtWebPage.MaxLength = 100;
            this.txtWebPage.Name = "txtWebPage";
            this.txtWebPage.Size = new System.Drawing.Size(267, 23);
            this.txtWebPage.TabIndex = 27;
            // 
            // btnAddPage
            // 
            this.btnAddPage.Location = new System.Drawing.Point(350, 14);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(55, 23);
            this.btnAddPage.TabIndex = 26;
            this.btnAddPage.Text = "Save";
            this.btnAddPage.UseVisualStyleBackColor = true;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 23);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(97, 15);
            this.lblPhoneNumber.TabIndex = 29;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(3, 17);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(93, 15);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Postal Address :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gvPhone
            // 
            this.gvPhone.AllowUserToAddRows = false;
            this.gvPhone.AllowUserToDeleteRows = false;
            this.gvPhone.BackgroundColor = System.Drawing.Color.White;
            this.gvPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhoneNumberDataGridViewTextBoxColumnSelect,
            this.dataGridViewTextBoxColumn3,
            this.PhoneNumberDataGridViewImageColumnUpdate,
            this.dataGridViewButtonColumn3});
            this.gvPhone.Location = new System.Drawing.Point(4, 49);
            this.gvPhone.Name = "gvPhone";
            this.gvPhone.ReadOnly = true;
            this.gvPhone.RowHeadersVisible = false;
            this.gvPhone.Size = new System.Drawing.Size(406, 137);
            this.gvPhone.TabIndex = 36;
            // 
            // gvAddress
            // 
            this.gvAddress.AllowUserToAddRows = false;
            this.gvAddress.AllowUserToDeleteRows = false;
            this.gvAddress.BackgroundColor = System.Drawing.Color.White;
            this.gvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddressDataGridViewImageColumnSelect,
            this.dataGridViewTextBoxColumn2,
            this.AddressDataGridViewImageColumnUpdate,
            this.dataGridViewImageColumnDelete});
            this.gvAddress.Location = new System.Drawing.Point(6, 43);
            this.gvAddress.Name = "gvAddress";
            this.gvAddress.ReadOnly = true;
            this.gvAddress.RowHeadersVisible = false;
            this.gvAddress.Size = new System.Drawing.Size(402, 143);
            this.gvAddress.TabIndex = 35;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 14);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(238, 23);
            this.txtAddress.TabIndex = 34;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(353, 13);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(55, 23);
            this.btnAddAddress.TabIndex = 33;
            this.btnAddAddress.Text = "Save";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(100, 20);
            this.txtPhoneNumber.MaxLength = 100;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(249, 23);
            this.txtPhoneNumber.TabIndex = 32;
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(355, 20);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(55, 23);
            this.btnAddPhone.TabIndex = 31;
            this.btnAddPhone.Text = "Save";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(2, 343);
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
            this.tabControlContactDetail.Location = new System.Drawing.Point(2, 362);
            this.tabControlContactDetail.Name = "tabControlContactDetail";
            this.tabControlContactDetail.SelectedIndex = 0;
            this.tabControlContactDetail.Size = new System.Drawing.Size(424, 220);
            this.tabControlContactDetail.TabIndex = 39;
            // 
            // tabPageMail
            // 
            this.tabPageMail.Controls.Add(this.lblMail);
            this.tabPageMail.Controls.Add(this.btnAddMail);
            this.tabPageMail.Controls.Add(this.txtMail);
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
            this.tabPageWebPage.Controls.Add(this.lblWebPage);
            this.tabPageWebPage.Controls.Add(this.btnAddPage);
            this.tabPageWebPage.Controls.Add(this.txtWebPage);
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
            this.tabPagePhoneNumber.Controls.Add(this.lblPhoneNumber);
            this.tabPagePhoneNumber.Controls.Add(this.btnAddPhone);
            this.tabPagePhoneNumber.Controls.Add(this.txtPhoneNumber);
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
            this.tabPageAddress.Controls.Add(this.lblAddress);
            this.tabPageAddress.Controls.Add(this.btnAddAddress);
            this.tabPageAddress.Controls.Add(this.txtAddress);
            this.tabPageAddress.Location = new System.Drawing.Point(4, 24);
            this.tabPageAddress.Name = "tabPageAddress";
            this.tabPageAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddress.Size = new System.Drawing.Size(416, 192);
            this.tabPageAddress.TabIndex = 3;
            this.tabPageAddress.Text = "Postal Address";
            this.tabPageAddress.UseVisualStyleBackColor = true;
            // 
            // MailAddress
            // 
            this.MailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MailAddress.HeaderText = "E-Mail Address";
            this.MailAddress.Name = "MailAddress";
            this.MailAddress.ReadOnly = true;
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
            // MailDataGridViewImageColumnSelect
            // 
            this.MailDataGridViewImageColumnSelect.HeaderText = "Select";
            this.MailDataGridViewImageColumnSelect.Image = global::PersonelOrganizer.Properties.Resources.go_small;
            this.MailDataGridViewImageColumnSelect.Name = "MailDataGridViewImageColumnSelect";
            this.MailDataGridViewImageColumnSelect.ReadOnly = true;
            this.MailDataGridViewImageColumnSelect.Width = 50;
            // 
            // MailDataGridViewImageColumnUpdate
            // 
            this.MailDataGridViewImageColumnUpdate.HeaderText = "Update";
            this.MailDataGridViewImageColumnUpdate.Image = global::PersonelOrganizer.Properties.Resources.document_edit_small;
            this.MailDataGridViewImageColumnUpdate.Name = "MailDataGridViewImageColumnUpdate";
            this.MailDataGridViewImageColumnUpdate.ReadOnly = true;
            this.MailDataGridViewImageColumnUpdate.Width = 50;
            // 
            // MailDataGridViewImageColumnDelete
            // 
            this.MailDataGridViewImageColumnDelete.HeaderText = "Delete";
            this.MailDataGridViewImageColumnDelete.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.MailDataGridViewImageColumnDelete.Name = "MailDataGridViewImageColumnDelete";
            this.MailDataGridViewImageColumnDelete.ReadOnly = true;
            this.MailDataGridViewImageColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MailDataGridViewImageColumnDelete.Width = 50;
            // 
            // WebPageDataGridViewTextBoxColumnSelect
            // 
            this.WebPageDataGridViewTextBoxColumnSelect.HeaderText = "Select";
            this.WebPageDataGridViewTextBoxColumnSelect.Image = global::PersonelOrganizer.Properties.Resources.go_small;
            this.WebPageDataGridViewTextBoxColumnSelect.Name = "WebPageDataGridViewTextBoxColumnSelect";
            this.WebPageDataGridViewTextBoxColumnSelect.ReadOnly = true;
            this.WebPageDataGridViewTextBoxColumnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WebPageDataGridViewTextBoxColumnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WebPageDataGridViewTextBoxColumnSelect.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Web Page";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // WebPageDataGridViewImageColumnUpdate
            // 
            this.WebPageDataGridViewImageColumnUpdate.HeaderText = "Update";
            this.WebPageDataGridViewImageColumnUpdate.Name = "WebPageDataGridViewImageColumnUpdate";
            this.WebPageDataGridViewImageColumnUpdate.ReadOnly = true;
            this.WebPageDataGridViewImageColumnUpdate.Width = 50;
            // 
            // dataGridViewButtonColumnDelete
            // 
            this.dataGridViewButtonColumnDelete.HeaderText = "Delete";
            this.dataGridViewButtonColumnDelete.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.dataGridViewButtonColumnDelete.Name = "dataGridViewButtonColumnDelete";
            this.dataGridViewButtonColumnDelete.ReadOnly = true;
            this.dataGridViewButtonColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumnDelete.Width = 50;
            // 
            // PhoneNumberDataGridViewTextBoxColumnSelect
            // 
            this.PhoneNumberDataGridViewTextBoxColumnSelect.HeaderText = "Select";
            this.PhoneNumberDataGridViewTextBoxColumnSelect.Image = global::PersonelOrganizer.Properties.Resources.go_small;
            this.PhoneNumberDataGridViewTextBoxColumnSelect.Name = "PhoneNumberDataGridViewTextBoxColumnSelect";
            this.PhoneNumberDataGridViewTextBoxColumnSelect.ReadOnly = true;
            this.PhoneNumberDataGridViewTextBoxColumnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneNumberDataGridViewTextBoxColumnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PhoneNumberDataGridViewTextBoxColumnSelect.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // PhoneNumberDataGridViewImageColumnUpdate
            // 
            this.PhoneNumberDataGridViewImageColumnUpdate.HeaderText = "Update";
            this.PhoneNumberDataGridViewImageColumnUpdate.Image = global::PersonelOrganizer.Properties.Resources.document_edit_small;
            this.PhoneNumberDataGridViewImageColumnUpdate.Name = "PhoneNumberDataGridViewImageColumnUpdate";
            this.PhoneNumberDataGridViewImageColumnUpdate.ReadOnly = true;
            this.PhoneNumberDataGridViewImageColumnUpdate.Width = 50;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Delete";
            this.dataGridViewButtonColumn3.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.ReadOnly = true;
            this.dataGridViewButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn3.Width = 50;
            // 
            // AddressDataGridViewImageColumnSelect
            // 
            this.AddressDataGridViewImageColumnSelect.HeaderText = "Select";
            this.AddressDataGridViewImageColumnSelect.Image = global::PersonelOrganizer.Properties.Resources.go_small;
            this.AddressDataGridViewImageColumnSelect.Name = "AddressDataGridViewImageColumnSelect";
            this.AddressDataGridViewImageColumnSelect.ReadOnly = true;
            this.AddressDataGridViewImageColumnSelect.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Postal Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // AddressDataGridViewImageColumnUpdate
            // 
            this.AddressDataGridViewImageColumnUpdate.HeaderText = "Update";
            this.AddressDataGridViewImageColumnUpdate.Image = global::PersonelOrganizer.Properties.Resources.document_edit_small;
            this.AddressDataGridViewImageColumnUpdate.Name = "AddressDataGridViewImageColumnUpdate";
            this.AddressDataGridViewImageColumnUpdate.ReadOnly = true;
            this.AddressDataGridViewImageColumnUpdate.Width = 50;
            // 
            // dataGridViewImageColumnDelete
            // 
            this.dataGridViewImageColumnDelete.HeaderText = "Delete";
            this.dataGridViewImageColumnDelete.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.dataGridViewImageColumnDelete.Name = "dataGridViewImageColumnDelete";
            this.dataGridViewImageColumnDelete.ReadOnly = true;
            this.dataGridViewImageColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumnDelete.Width = 50;
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
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 639);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlContactDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
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
            this.tabPageMail.PerformLayout();
            this.tabPageWebPage.ResumeLayout(false);
            this.tabPageWebPage.PerformLayout();
            this.tabPagePhoneNumber.ResumeLayout(false);
            this.tabPagePhoneNumber.PerformLayout();
            this.tabPageAddress.ResumeLayout(false);
            this.tabPageAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvContactList;
        private System.Windows.Forms.Label lblContactList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.Label lblWebPage;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.DataGridView gvMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnAddMail;
        private System.Windows.Forms.DataGridView gvWebPage;
        private System.Windows.Forms.TextBox txtWebPage;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gvPhone;
        private System.Windows.Forms.DataGridView gvAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControlContactDetail;
        private System.Windows.Forms.TabPage tabPageMail;
        private System.Windows.Forms.TabPage tabPageWebPage;
        private System.Windows.Forms.TabPage tabPagePhoneNumber;
        private System.Windows.Forms.TabPage tabPageAddress;
        private System.Windows.Forms.DataGridViewImageColumn MailDataGridViewImageColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailAddress;
        private System.Windows.Forms.DataGridViewImageColumn MailDataGridViewImageColumnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn MailDataGridViewImageColumnDelete;
        private System.Windows.Forms.DataGridViewImageColumn WebPageDataGridViewTextBoxColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn WebPageDataGridViewImageColumnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewButtonColumnDelete;
        private System.Windows.Forms.DataGridViewImageColumn PhoneNumberDataGridViewTextBoxColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn PhoneNumberDataGridViewImageColumnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewImageColumn AddressDataGridViewImageColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn AddressDataGridViewImageColumnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumnDelete;
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
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewImageColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnContactID;
    }
}