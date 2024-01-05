using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Library_WindowsForms;

using DAO;
using Microsoft.VisualBasic.ApplicationServices;

namespace GUI
{
    public partial class Login : Form
    {
        private CheckLoginAuthenticationBLL checkLogin;
        LoginBLL loginBLL = new LoginBLL();
        public Login()
        {
            InitializeComponent();
            checkLogin = new CheckLoginAuthenticationBLL();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtPassword.PasswordChar = '.';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isAuthenticated = loginBLL.ValidateLogin(username, password);

            if (isAuthenticated)
            {
                    DataTable userData = checkLogin.GetRole_GetInformationUser(username, password);

                if (userData.Rows.Count > 0)
                {
                    DataRow row = userData.Rows[0];

                    UserSession.UserId = Convert.ToInt32(row["UserID"]);
                    UserSession.FullName = row["FullName"].ToString();
                    UserSession.UserRole = row["Role"].ToString();
                    UserSession.UserImage = row["Image"].ToString();

                    MessageBox.Show("Successful login!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    this.Hide();

                    ViewHomeLibrary homeForm = new ViewHomeLibrary();
                    homeForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Logon failure. Please double-check your username and password.", "Error" 
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
