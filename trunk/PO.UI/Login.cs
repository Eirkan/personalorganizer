using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PO.Services.BusinessObjects;
using PersonelOrganizer.Util;

namespace PersonelOrganizer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckInputs();
        }

        private void CheckInputs()
        {
            if (txtUserName.Text == String.Empty)
                MessageBox.Show("Please Enter UserName!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtPassword.Text == String.Empty)
                MessageBox.Show("Please Enter Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                IsUserAuthenticate();
        }

        private void IsUserAuthenticate()
        {
            string pUserName = txtUserName.Text;
            string pPassword = txtPassword.Text;

            UserBS user = new UserBS();
            Guid pUserID = user.IsUserValid(pUserName, pPassword); 
            if (pUserID == Guid.Empty)
                MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                POGlobals.UserID = pUserID;
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
        }
    }
}
