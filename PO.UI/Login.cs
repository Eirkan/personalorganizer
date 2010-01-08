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
using PO.Types.DataSets;

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
            string pName = String.Empty, pSurname = String.Empty;
            Guid pUserID = Guid.Empty;

            UserBS user = new UserBS();
            user.IsUserValid(out pUserID, pUserName, pPassword, out pName, out pSurname);
            if (pUserID == Guid.Empty)
                MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                POGlobals.UserID = pUserID;
                POGlobals.UserNameSurname = pName + " " + pSurname; 
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "ibrahim";
            txtPassword.Text = "123";
        }
    }
}
