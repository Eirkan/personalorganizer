namespace PersonelOrganizer
{
    partial class AddContact
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnAddMail = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtWebPage = new System.Windows.Forms.TextBox();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.lblWebPage = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gvMail = new System.Windows.Forms.DataGridView();
            this.MailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gvWebPage = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gvAddress = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gvPhone = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWebPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(7, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 34);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(103, 63);
            this.txtSurname.MaxLength = 100;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(249, 23);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(7, 66);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(63, 15);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname :";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(103, 92);
            this.txtCompany.MaxLength = 100;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(249, 23);
            this.txtCompany.TabIndex = 3;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompany.Location = new System.Drawing.Point(7, 95);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(64, 15);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "Company :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(7, 124);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(87, 15);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "E-mail Adress :";
            // 
            // btnAddMail
            // 
            this.btnAddMail.Location = new System.Drawing.Point(358, 121);
            this.btnAddMail.Name = "btnAddMail";
            this.btnAddMail.Size = new System.Drawing.Size(55, 23);
            this.btnAddMail.TabIndex = 5;
            this.btnAddMail.Text = "Add";
            this.btnAddMail.UseVisualStyleBackColor = true;
            this.btnAddMail.Click += new System.EventHandler(this.btnAddMail_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(103, 121);
            this.txtMail.MaxLength = 100;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(249, 23);
            this.txtMail.TabIndex = 4;
            // 
            // txtWebPage
            // 
            this.txtWebPage.Location = new System.Drawing.Point(103, 244);
            this.txtWebPage.MaxLength = 100;
            this.txtWebPage.Name = "txtWebPage";
            this.txtWebPage.Size = new System.Drawing.Size(251, 23);
            this.txtWebPage.TabIndex = 6;
            // 
            // btnAddPage
            // 
            this.btnAddPage.Location = new System.Drawing.Point(360, 244);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(55, 23);
            this.btnAddPage.TabIndex = 7;
            this.btnAddPage.Text = "Add";
            this.btnAddPage.UseVisualStyleBackColor = true;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // lblWebPage
            // 
            this.lblWebPage.AutoSize = true;
            this.lblWebPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWebPage.Location = new System.Drawing.Point(7, 247);
            this.lblWebPage.Name = "lblWebPage";
            this.lblWebPage.Size = new System.Drawing.Size(69, 15);
            this.lblWebPage.TabIndex = 9;
            this.lblWebPage.Text = "Web Page :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(103, 368);
            this.txtPhoneNumber.MaxLength = 100;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(249, 23);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(358, 368);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(55, 23);
            this.btnAddPhone.TabIndex = 9;
            this.btnAddPhone.Text = "Add";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 371);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(97, 15);
            this.lblPhoneNumber.TabIndex = 12;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(103, 494);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(251, 23);
            this.txtAddress.TabIndex = 10;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(360, 494);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(55, 23);
            this.btnAddAddress.TabIndex = 11;
            this.btnAddAddress.Text = "Add";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Postal Adress :";
            // 
            // gvMail
            // 
            this.gvMail.AllowUserToAddRows = false;
            this.gvMail.BackgroundColor = System.Drawing.Color.White;
            this.gvMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MailAddress,
            this.Delete});
            this.gvMail.Location = new System.Drawing.Point(103, 152);
            this.gvMail.Name = "gvMail";
            this.gvMail.ReadOnly = true;
            this.gvMail.RowHeadersVisible = false;
            this.gvMail.Size = new System.Drawing.Size(310, 77);
            this.gvMail.TabIndex = 18;
            this.gvMail.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvMail_CellMouseClick);
            // 
            // MailAddress
            // 
            this.MailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MailAddress.HeaderText = "E-Mail Address";
            this.MailAddress.Name = "MailAddress";
            this.MailAddress.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 50;
            // 
            // gvWebPage
            // 
            this.gvWebPage.AllowUserToAddRows = false;
            this.gvWebPage.AllowUserToDeleteRows = false;
            this.gvWebPage.BackgroundColor = System.Drawing.Color.White;
            this.gvWebPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWebPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewButtonColumnDelete});
            this.gvWebPage.Location = new System.Drawing.Point(103, 273);
            this.gvWebPage.Name = "gvWebPage";
            this.gvWebPage.ReadOnly = true;
            this.gvWebPage.RowHeadersVisible = false;
            this.gvWebPage.Size = new System.Drawing.Size(310, 77);
            this.gvWebPage.TabIndex = 19;
            this.gvWebPage.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvWebPage_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Web Page";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // gvAddress
            // 
            this.gvAddress.AllowUserToAddRows = false;
            this.gvAddress.AllowUserToDeleteRows = false;
            this.gvAddress.BackgroundColor = System.Drawing.Color.White;
            this.gvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumnDelete});
            this.gvAddress.Location = new System.Drawing.Point(103, 523);
            this.gvAddress.Name = "gvAddress";
            this.gvAddress.ReadOnly = true;
            this.gvAddress.RowHeadersVisible = false;
            this.gvAddress.Size = new System.Drawing.Size(314, 77);
            this.gvAddress.TabIndex = 20;
            this.gvAddress.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvAddress_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Postal Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // gvPhone
            // 
            this.gvPhone.AllowUserToAddRows = false;
            this.gvPhone.AllowUserToDeleteRows = false;
            this.gvPhone.BackgroundColor = System.Drawing.Color.White;
            this.gvPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn3});
            this.gvPhone.Location = new System.Drawing.Point(103, 397);
            this.gvPhone.Name = "gvPhone";
            this.gvPhone.ReadOnly = true;
            this.gvPhone.RowHeadersVisible = false;
            this.gvPhone.Size = new System.Drawing.Size(312, 77);
            this.gvPhone.TabIndex = 21;
            this.gvPhone.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvPhone_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(342, 608);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::PersonelOrganizer.Properties.Resources.close;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Delete";
            this.dataGridViewImageColumn3.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 50;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Delete";
            this.dataGridViewImageColumn4.Image = global::PersonelOrganizer.Properties.Resources.close_small;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.Width = 50;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHeader.Location = new System.Drawing.Point(7, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(75, 15);
            this.lblHeader.TabIndex = 23;
            this.lblHeader.Text = "Add Contact";
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 638);
            this.ControlBox = false;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gvPhone);
            this.Controls.Add(this.gvAddress);
            this.Controls.Add(this.gvWebPage);
            this.Controls.Add(this.gvMail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.btnAddPhone);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtWebPage);
            this.Controls.Add(this.btnAddPage);
            this.Controls.Add(this.lblWebPage);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnAddMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddContact";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Contact";
            ((System.ComponentModel.ISupportInitialize)(this.gvMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWebPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnAddMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtWebPage;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.Label lblWebPage;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvMail;
        private System.Windows.Forms.DataGridView gvWebPage;
        private System.Windows.Forms.DataGridView gvAddress;
        private System.Windows.Forms.DataGridView gvPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailAddress;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewButtonColumnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.Label lblHeader;
    }
}