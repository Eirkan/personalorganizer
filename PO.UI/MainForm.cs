using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersonelOrganizer.Util;

namespace PersonelOrganizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            OpenHomeForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseWindowOpenedBefore()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                if (form != null)
                    form.Dispose();
            }
        }

        private void SetChildrenFormValues(Form form)
        {
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHomeForm();
        }

        private void OpenHomeForm()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new Home());
            statusLabel.Text = "Ready";
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POGlobals.ContactID = Guid.Empty;
            OpenAddContact();
        }

        public void OpenAddContact()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new AddContact());
            statusLabel.Text = "Add Contact";
        }

        private void contactListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenContactList();
        }

        public void OpenContactList()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new ContactList());
            statusLabel.Text = "Contact List";
        }

        private void addAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POGlobals.AppointmentID = Guid.Empty;
            OpenAddAppointment();
        }

        public void OpenAddAppointment()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new AddAppointment());
            statusLabel.Text = "Add Appointment";
        }

        private void appointmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAppointmentList();
        }

        public void OpenAppointmentList()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new AppointmentList());
            statusLabel.Text = "Appointment List";
        }

        private void addEventToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            POGlobals.EventID = Guid.Empty;
            OpenAddEvent();
        }

        public void OpenAddEvent()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new AddEvent());
            statusLabel.Text = "Add Event";
        }

        private void eventListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEventList();
        }

        public void OpenEventList()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new EventList());
            statusLabel.Text = "Event List";
        }

        private void addCreditCardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            POGlobals.CreditCard = Guid.Empty;
            OpenAddCreditCard();
        }

        public void OpenAddCreditCard()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new AddCreditCard());
            statusLabel.Text = "Add Credit Card";
        }

        private void cardListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenCreditCardList();
        }

        public void OpenCreditCardList()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new CreditCardList());
            statusLabel.Text = "Credit Card List";
        }

        private void addIncomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            POGlobals.IncomeID = Guid.Empty;
            OpenAddIncome();
        }

        public void OpenAddIncome()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new AddIncome());
            statusLabel.Text = "Add Income";
        }

        private void incomeListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenIncomeList();
        }

        public void OpenIncomeList()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new IncomeList());
            statusLabel.Text = "Income List";
        }

        private void addExpenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            POGlobals.ExpenseID = Guid.Empty;
            POGlobals.InstallmentID = Guid.Empty;
            OpenAddExpense();
        }

        public void OpenAddExpense()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new AddExpense());
            statusLabel.Text = "Add Expense";
        }

        private void expenseListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenExpenseList();
        }

        public void OpenExpenseList()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new ExpenseList());
            statusLabel.Text = "Expense List";
        }      

        private void aboutPersonalOrganizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new POHelp());
            statusLabel.Text = "About Personel Organizer";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTransactiontList();
        }

        public void OpenTransactiontList()
        {
            CloseWindowOpenedBefore();
            SetChildrenFormValues(new TransactionList());
            statusLabel.Text = "Transaction List";
        }
    }
}
