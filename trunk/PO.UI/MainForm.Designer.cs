namespace PersonelOrganizer
{
    partial class MainForm
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
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.aboutPersonelOrganizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCreditCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCreditCardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cardListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIncomeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPersonalOrganizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 645);
            this.status.Name = "status";
            this.status.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.status.Size = new System.Drawing.Size(438, 22);
            this.status.TabIndex = 2;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(118, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.contactsToolStripMenuItem,
            this.timeToolStripMenuItem,
            this.moneyToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(438, 24);
            this.menu.TabIndex = 3;
            this.menu.Text = "menu";
            // 
            // aboutPersonelOrganizerToolStripMenuItem
            // 
            this.aboutPersonelOrganizerToolStripMenuItem.Name = "aboutPersonelOrganizerToolStripMenuItem";
            this.aboutPersonelOrganizerToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.aboutPersonelOrganizerToolStripMenuItem.Text = "About Personel Organizer";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Image = global::PersonelOrganizer.Properties.Resources.home;
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.contactListToolStripMenuItem});
            this.contactsToolStripMenuItem.Image = global::PersonelOrganizer.Properties.Resources.user;
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Image = global::PersonelOrganizer.Properties.Resources.user_add;
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // contactListToolStripMenuItem
            // 
            this.contactListToolStripMenuItem.Image = global::PersonelOrganizer.Properties.Resources.report;
            this.contactListToolStripMenuItem.Name = "contactListToolStripMenuItem";
            this.contactListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contactListToolStripMenuItem.Text = "Contact List";
            this.contactListToolStripMenuItem.Click += new System.EventHandler(this.contactListToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTimeToolStripMenuItem,
            this.addEventToolStripMenuItem});
            this.timeToolStripMenuItem.Image = global::PersonelOrganizer.Properties.Resources.clock;
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.timeToolStripMenuItem.Text = "Time";
            // 
            // addTimeToolStripMenuItem
            // 
            this.addTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppointmentToolStripMenuItem,
            this.appointmentListToolStripMenuItem});
            this.addTimeToolStripMenuItem.Name = "addTimeToolStripMenuItem";
            this.addTimeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTimeToolStripMenuItem.Text = "Appointment";
            // 
            // addAppointmentToolStripMenuItem
            // 
            this.addAppointmentToolStripMenuItem.Image = global::PersonelOrganizer.Properties.Resources.add;
            this.addAppointmentToolStripMenuItem.Name = "addAppointmentToolStripMenuItem";
            this.addAppointmentToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addAppointmentToolStripMenuItem.Text = "Add Appointment";
            this.addAppointmentToolStripMenuItem.Click += new System.EventHandler(this.addAppointmentToolStripMenuItem_Click);
            // 
            // appointmentListToolStripMenuItem
            // 
            this.appointmentListToolStripMenuItem.Image = global::PersonelOrganizer.Properties.Resources.report;
            this.appointmentListToolStripMenuItem.Name = "appointmentListToolStripMenuItem";
            this.appointmentListToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.appointmentListToolStripMenuItem.Text = "Appointment List";
            this.appointmentListToolStripMenuItem.Click += new System.EventHandler(this.appointmentListToolStripMenuItem_Click);
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem1,
            this.eventListToolStripMenuItem});
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addEventToolStripMenuItem.Text = "Event";
            // 
            // addEventToolStripMenuItem1
            // 
            this.addEventToolStripMenuItem1.Image = global::PersonelOrganizer.Properties.Resources.add;
            this.addEventToolStripMenuItem1.Name = "addEventToolStripMenuItem1";
            this.addEventToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addEventToolStripMenuItem1.Text = "Add Event";
            this.addEventToolStripMenuItem1.Click += new System.EventHandler(this.addEventToolStripMenuItem1_Click);
            // 
            // eventListToolStripMenuItem
            // 
            this.eventListToolStripMenuItem.Image = global::PersonelOrganizer.Properties.Resources.report;
            this.eventListToolStripMenuItem.Name = "eventListToolStripMenuItem";
            this.eventListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eventListToolStripMenuItem.Text = "Event List";
            this.eventListToolStripMenuItem.Click += new System.EventHandler(this.eventListToolStripMenuItem_Click);
            // 
            // moneyToolStripMenuItem
            // 
            this.moneyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCreditCardToolStripMenuItem,
            this.addIncomeToolStripMenuItem,
            this.addExpenseToolStripMenuItem,
            this.budgetToolStripMenuItem});
            this.moneyToolStripMenuItem.Image = global::PersonelOrganizer.Properties.Resources.calculator;
            this.moneyToolStripMenuItem.Name = "moneyToolStripMenuItem";
            this.moneyToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.moneyToolStripMenuItem.Text = "Money";
            // 
            // addCreditCardToolStripMenuItem
            // 
            this.addCreditCardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCreditCardToolStripMenuItem1,
            this.cardListToolStripMenuItem1});
            this.addCreditCardToolStripMenuItem.Name = "addCreditCardToolStripMenuItem";
            this.addCreditCardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addCreditCardToolStripMenuItem.Text = "Credit Card";
            // 
            // addCreditCardToolStripMenuItem1
            // 
            this.addCreditCardToolStripMenuItem1.Image = global::PersonelOrganizer.Properties.Resources.add;
            this.addCreditCardToolStripMenuItem1.Name = "addCreditCardToolStripMenuItem1";
            this.addCreditCardToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.addCreditCardToolStripMenuItem1.Text = "Add Credit Card";
            this.addCreditCardToolStripMenuItem1.Click += new System.EventHandler(this.addCreditCardToolStripMenuItem1_Click);
            // 
            // cardListToolStripMenuItem1
            // 
            this.cardListToolStripMenuItem1.Image = global::PersonelOrganizer.Properties.Resources.report;
            this.cardListToolStripMenuItem1.Name = "cardListToolStripMenuItem1";
            this.cardListToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.cardListToolStripMenuItem1.Text = "Card List";
            this.cardListToolStripMenuItem1.Click += new System.EventHandler(this.cardListToolStripMenuItem1_Click);
            // 
            // addIncomeToolStripMenuItem
            // 
            this.addIncomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIncomeToolStripMenuItem1,
            this.incomeListToolStripMenuItem1});
            this.addIncomeToolStripMenuItem.Name = "addIncomeToolStripMenuItem";
            this.addIncomeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addIncomeToolStripMenuItem.Text = "Income";
            // 
            // addIncomeToolStripMenuItem1
            // 
            this.addIncomeToolStripMenuItem1.Image = global::PersonelOrganizer.Properties.Resources.add;
            this.addIncomeToolStripMenuItem1.Name = "addIncomeToolStripMenuItem1";
            this.addIncomeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addIncomeToolStripMenuItem1.Text = "Add Income";
            this.addIncomeToolStripMenuItem1.Click += new System.EventHandler(this.addIncomeToolStripMenuItem1_Click);
            // 
            // incomeListToolStripMenuItem1
            // 
            this.incomeListToolStripMenuItem1.Image = global::PersonelOrganizer.Properties.Resources.report;
            this.incomeListToolStripMenuItem1.Name = "incomeListToolStripMenuItem1";
            this.incomeListToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.incomeListToolStripMenuItem1.Text = "Income List";
            this.incomeListToolStripMenuItem1.Click += new System.EventHandler(this.incomeListToolStripMenuItem1_Click);
            // 
            // addExpenseToolStripMenuItem
            // 
            this.addExpenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExpenseToolStripMenuItem1,
            this.expenseListToolStripMenuItem1});
            this.addExpenseToolStripMenuItem.Name = "addExpenseToolStripMenuItem";
            this.addExpenseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addExpenseToolStripMenuItem.Text = "Expense";
            // 
            // addExpenseToolStripMenuItem1
            // 
            this.addExpenseToolStripMenuItem1.Image = global::PersonelOrganizer.Properties.Resources.add;
            this.addExpenseToolStripMenuItem1.Name = "addExpenseToolStripMenuItem1";
            this.addExpenseToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addExpenseToolStripMenuItem1.Text = "Add Expense";
            this.addExpenseToolStripMenuItem1.Click += new System.EventHandler(this.addExpenseToolStripMenuItem1_Click);
            // 
            // expenseListToolStripMenuItem1
            // 
            this.expenseListToolStripMenuItem1.Image = global::PersonelOrganizer.Properties.Resources.report;
            this.expenseListToolStripMenuItem1.Name = "expenseListToolStripMenuItem1";
            this.expenseListToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.expenseListToolStripMenuItem1.Text = "Expense List";
            this.expenseListToolStripMenuItem1.Click += new System.EventHandler(this.expenseListToolStripMenuItem1_Click);
            // 
            // budgetToolStripMenuItem
            // 
            this.budgetToolStripMenuItem.Name = "budgetToolStripMenuItem";
            this.budgetToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.budgetToolStripMenuItem.Text = "Budget";
            this.budgetToolStripMenuItem.Click += new System.EventHandler(this.budgetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPersonalOrganizerToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::PersonelOrganizer.Properties.Resources.help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutPersonalOrganizerToolStripMenuItem
            // 
            this.aboutPersonalOrganizerToolStripMenuItem.Name = "aboutPersonalOrganizerToolStripMenuItem";
            this.aboutPersonalOrganizerToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.aboutPersonalOrganizerToolStripMenuItem.Text = "About Personal Organizer";
            this.aboutPersonalOrganizerToolStripMenuItem.Click += new System.EventHandler(this.aboutPersonalOrganizerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::PersonelOrganizer.Properties.Resources.cancel;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 667);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Organizer v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPersonelOrganizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPersonalOrganizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCreditCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCreditCardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cardListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addIncomeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem incomeListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem expenseListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem budgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eventListToolStripMenuItem;
    }
}

