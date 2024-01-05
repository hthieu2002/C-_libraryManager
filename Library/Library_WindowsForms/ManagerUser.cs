using BLL;
using DAL;
using DAO;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class ManagerUser : Form
    {
        Panel container;
        configUrl config = new configUrl();
        private int maxLength = 30;
        private static string fullText = $"{configUrl.uploadImage}596EF56DEFBABD63A51046276F7A05A53E0C89CB920FF00EE4C0F98E74100169.jpg";
        private static string urlFullText = configUrl.uploadImage;
        private static string urlNameImage = "";
        private static string PasswordSha256 = "";
        private static int key = 0;
        private static int IdDelete = 0;
        private DataTable userDataTable;
        private BLL.UserManagerBLL userManagerBLL;

        public ManagerUser()
        {
            InitializeComponent();
            container = new Panel();
            setUp();
            loadData();
            Enable();
            userDataTable = new DataTable();
            lbTitle.Size = new Size(1248, 100);
            container.Size = new Size(1248, 50);

            lbTitle.Location = new Point((container.Width - lbTitle.Width) / 2, (container.Height - lbTitle.Height) / 2);
            //panelTotal.Paint += new PaintEventHandler(yourPanel_Paint);
            panelLine.Paint += new PaintEventHandler(yourPanel_Paint);
            panelManager.Paint += new PaintEventHandler(Panel_Paint);
            panelControl.Paint += new PaintEventHandler(Panel_Paint);

        }
        private void setUp()
        {
            pictureBoxImage.Click += pictureBoxImage_Click;
            dataGridViewManagerUser.CellClick += dataGridViewManagerUser_CellClick;
            button6.Click += button6_Click;
            lbUrlImage.Text = "";
            setImageBox(config.GetImage("596EF56DEFBABD63A51046276F7A05A53E0C89CB920FF00EE4C0F98E74100169.jpg"));
            txtPassword.PasswordChar = '.';
            txtConfirmPassword.PasswordChar = '.';
            string admin = UserSession.FullName;
            lbTitleNameUserAdmin.Text = $"Welcome to {admin}";
        }

        private void Button6_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void yourPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.Black, ButtonBorderStyle.Inset);
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.Black, ButtonBorderStyle.Dashed);

        }
        private void setImageBox(string key)
        {
            pictureBoxImage.ImageLocation = key;
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "image file|*.jpg;*.png;*.gif;*.bmp|All file|*.*",
                Title = "Select image"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                lbUrlImage.Text = imagePath;
                fullText = imagePath;
                CheckTextImage(imagePath);
                key = 1;
                pictureBoxImage.Image = Image.FromFile(imagePath);
            }
        }
        private void CheckTextImage(string fulltext)
        {
            if (fulltext.Length > maxLength)
            {
                string displayedText = fulltext.Substring(0, maxLength - 3) + "...";
                lbUrlImage.Text = displayedText;
                lbUrlImage.AutoEllipsis = true;

            }
            else
            {
                lbUrlImage.Text = fulltext;
                lbUrlImage.AutoEllipsis = false;
            }
        }
        private void newUser()
        {
            setImageBox(config.GetImage("596EF56DEFBABD63A51046276F7A05A53E0C89CB920FF00EE4C0F98E74100169.jpg"));
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtFullName.Text = "";
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdminGrant.Enabled = false;
            key = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            newUser();
        }
        private void loadData()
        {
            if (userManagerBLL == null)
            {
                userManagerBLL = new UserManagerBLL();
            }

            userDataTable = userManagerBLL.GetAllDataUser();

            if (userDataTable != null && userDataTable.Rows.Count > 0)
            {
                dataGridViewManagerUser.DataSource = userDataTable;
                dataGridViewManagerUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewManagerUser.Columns["Image"].Visible = false;
                dataGridViewManagerUser.CellFormatting += DataGridViewManagerUser_CellFormatting;
            }
            else
            {
            }
        }
        private void DataGridViewManagerUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewManagerUser.Columns["Password"].Index && e.Value != null)
            {

                e.Value = new string('.', Math.Min(5, e.Value.ToString().Length));
            }
        }
        private void dataGridViewManagerUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int selectedRowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = dataGridViewManagerUser.Rows[selectedRowIndex];

                    int selectedID = Convert.ToInt32(selectedRow.Cells["UserId"].Value);
                    string selectedName = Convert.ToString(selectedRow.Cells["UserName"].Value);
                    string selectedPassword = Convert.ToString(selectedRow.Cells["Password"].Value);
                    string selectedimage = Convert.ToString(selectedRow.Cells["Image"].Value);
                    string Fullname = Convert.ToString(selectedRow.Cells["FullName"].Value);


                    txtUserName.Text = selectedName;
                    PasswordSha256 = selectedPassword;
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtFullName.Text = Fullname;
                    urlFullText = selectedimage;
                    key = 0;
                    IdDelete = selectedID;
                    CheckTextImage(urlFullText);
                    setImageBox(config.GetImage(urlFullText + ".jpg"));
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnAdminGrant.Enabled = true;
                }
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInfomation())
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    string imageUrl = fullText;
                    string folderPath = configUrl.uploadImage;
                    DownloadAndSaveImageWithSHA256(imageUrl, folderPath);

                    DAO.UserManager user = new UserManager
                    {
                        UserName = txtUserName.Text,
                        FullName = txtFullName.Text,
                        Password = HashPassword(txtPassword.Text),
                        Image = urlNameImage
                    };

                    userManagerBLL.InsertUser(user);
                    newUser();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Confirm wrong password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            //MessageBox.Show(urlNameImage);
        }
        private bool CheckInfomation()
        {
            if (!string.IsNullOrEmpty(txtFullName.Text) ||
                !string.IsNullOrEmpty(txtPassword.Text) ||
                !string.IsNullOrEmpty(txtUserName.Text))
            {
                return true;
            }
            return false;
        }

        static void DownloadAndSaveImageWithSHA256(string imageUrl, string folderPath)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(imageUrl);
                    byte[] sha256Hash = ComputeSHA256Hash(imageData);
                    string sha256HashString = BitConverter.ToString(sha256Hash).Replace("-", "");
                    urlNameImage = sha256HashString;
                    string fileName = Path.Combine(folderPath, sha256HashString + ".jpg");
                    File.WriteAllBytes(fileName, imageData);

                    //MessageBox.Show("Hình ảnh đã được lưu thành công vào: " + fileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static byte[] ComputeSHA256Hash(byte[] inputBytes)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(inputBytes);
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.Unicode.GetBytes(password); // Sử dụng Unicode thay vì UTF-8

                byte[] hashBytes = sha256.ComputeHash(bytes);
                string hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower(); // Chuyển đổi thành chuỗi in thường

                return hashedPassword;
            }
        }

        private void Enable()
        {
            btnAdminGrant.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void TrueEnable()
        {
            btnAdminGrant.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            userManagerBLL.DeleteUser(IdDelete);
            newUser();
            loadData();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdminGrant.Enabled = false;
        }

        private void btnAdminGrant_Click(object sender, EventArgs e)
        {
            userManagerBLL.UpdateAdminRole(IdDelete);
            newUser();
            loadData();
            MessageBox.Show("Admin rights removed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdminGrant.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) || !string.IsNullOrEmpty(txtFullName.Text))
            {
                if (txtPassword.Text == "" && txtConfirmPassword.Text == "")
                {
                    string password = PasswordSha256;
                    string imageUrl = fullText;
                    string folderPath = configUrl.uploadImage;
                    DownloadAndSaveImageWithSHA256(imageUrl, folderPath);

                    DAO.UserManager user = new UserManager
                    {
                        UserID = IdDelete,
                        UserName = txtUserName.Text,
                        FullName = txtFullName.Text,
                        Password = password,
                        Image = urlNameImage
                    };

                    userManagerBLL.UpdateUser(user);
                    newUser();
                    loadData();
                }
                else
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        string password = PasswordSha256;
                        string imageUrl = fullText;
                        string folderPath = configUrl.uploadImage;
                        DownloadAndSaveImageWithSHA256(imageUrl, folderPath);

                        DAO.UserManager user = new UserManager
                        {
                            UserID = IdDelete,
                            UserName = txtUserName.Text,
                            FullName = txtFullName.Text,
                            Password = HashPassword(txtPassword.Text),
                            Image = urlNameImage
                        };

                        userManagerBLL.UpdateUser(user);
                        newUser();
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Confirm wrong password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {

            }
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdminGrant.Enabled = false;
        }
    }
}

