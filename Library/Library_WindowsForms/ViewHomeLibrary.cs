using BLL;
using DAO;
using GUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_WindowsForms
{
    public partial class ViewHomeLibrary : Form
    {
        private Form currentForm;

        ToolStripMenuItem userToolStripMenuItem;
        public ViewHomeLibrary()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            //string loggedInUser = UserManager.Instance.LoggedInUsername;
            checkRole();

            ShowHome();
        }
        private void ShowFormInPanel(Form form)
        {
            // Hiển thị form trong panel1
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            View.Controls.Clear();
            View.Controls.Add(form);
            form.Show();
        }

        private void ShowHome()
        {
            currentForm = new Home();
            ShowFormInPanel(currentForm);
            CenterFormOnScreen(currentForm);
        }

        private void CenterFormOnScreen(Form form)
        {
            int x = (Screen.PrimaryScreen.Bounds.Width - form.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - form.Height) / 2;

            form.Location = new Point(x, y);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentForm = new Home();
            ShowFormInPanel(currentForm);
        }

        private void bookManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentForm = new BookManagement();
            ShowFormInPanel(currentForm);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            GUI.Login login = new GUI.Login();
            login.ShowDialog();
        }

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentForm = new dataGridViewMember();
            ShowFormInPanel(currentForm);
        }

        private void borrowReturnManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentForm = new Borrow_ReturnBookManagement();
            ShowFormInPanel(currentForm);
        }

        public void checkRole()
        {
            string userRole = UserSession.UserRole;

            if (userRole == "Admin")
            {
                userToolStripMenuItem = new ToolStripMenuItem("Manager User");
                userToolStripMenuItem.Click += UserToolStripMenuItem_Click;
                fileToolStripMenuItem.DropDownItems.Add(userToolStripMenuItem);
            }
            else
            {

            }
        }
        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentForm = new ManagerUser();
            ShowFormInPanel(currentForm);
        }
        private void statisticsAndReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentForm = new StatisticsAndReport();
            ShowFormInPanel(currentForm);
        }

        private void supportAndContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The function has not been developed !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void notificationAndSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The function has not been developed !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The function has not been developed !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
