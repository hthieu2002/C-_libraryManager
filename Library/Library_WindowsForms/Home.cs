using BLL;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using DrawingImage = System.Drawing.Image;
using WinFormsTimer = System.Windows.Forms.Timer;

using System.Windows.Forms;
using Xceed.Document.NET;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI
{
    public partial class Home : Form
    {
        Panel container;
        private WinFormsTimer timer;
        private DAL.configUrl configUrl;
        private BLL.StatisticsBLL statistics;

        public Home()
        {
            InitializeComponent();
            container = new Panel();
            configUrl = new DAL.configUrl();
            statistics = new BLL.StatisticsBLL();
            title.Size = new Size(1209, 100);
            container.Size = new Size(1209, 100);
            setUp();

        }
        private void setUp()
        {
            Data();
            GetUser();
            TimeDate();
            InitializeUserIcon();
            InitializeBookIcon();
            InitializeBorrowIcon();
            panelTitle.Paint += new PaintEventHandler(yourPanel_Paint);
            panelstatisticsUser.Paint += new PaintEventHandler(UserPanel_Paint);
            panelstatisticsBook.Paint += new PaintEventHandler(BookPanel_Paint);
            panelstatisticsBorrow.Paint += new PaintEventHandler(BorrowPanel_Paint);
            panelUserTotal.Paint += new PaintEventHandler(UserTotalPanel_Paint);
            panelUser.Paint += new PaintEventHandler(UserTotalPanel_Paint);
            panelBorrow.Paint += new PaintEventHandler(UserTotalPanel_Paint);
            title.Location = new Point((container.Width - title.Width) / 2, (container.Height - title.Height) / 2);
        }

        private void GetUser()
        {
            string fullName = UserSession.FullName;
            userTitle.Text = $"Welcome to {fullName}";
        }
        private void yourPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.Black, ButtonBorderStyle.Inset);
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }
        private void UserPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.Black, ButtonBorderStyle.Dashed);

        }
        private void BookPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.Black, ButtonBorderStyle.Dashed);

        }
        private void BorrowPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.Black, ButtonBorderStyle.Dashed);

        }

        private void UserTotalPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.Black, ButtonBorderStyle.Inset);
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);

        }
        private void TimeDate()
        {
            timer = new WinFormsTimer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void InitializeUserIcon()
        {
            PictureBox pictureBoxIcon = new PictureBox();
            pictureBoxIcon.Image = DrawingImage.FromFile(configUrl.GetImagePath("user.png"));
            pictureBoxIcon.Size = new Size(42, 42);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxIcon.Location = new Point(0, 0);
            int offsetX = 20;
            int offsetY = panelstatisticsUser.Height - pictureBoxIcon.Height - 20;
            pictureBoxIcon.Location = new Point(offsetX, offsetY);
            panelstatisticsUser.Controls.Add(pictureBoxIcon);
        }
        private void InitializeBookIcon()
        {
            PictureBox pictureBoxIcon = new PictureBox();
            pictureBoxIcon.Image = DrawingImage.FromFile(configUrl.GetImagePath("books.png"));
            pictureBoxIcon.Size = new Size(42, 42);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxIcon.Location = new Point(0, 0);
            int offsetX = 20;
            int offsetY = panelstatisticsBook.Height - pictureBoxIcon.Height - 20;
            pictureBoxIcon.Location = new Point(offsetX, offsetY);
            panelstatisticsBook.Controls.Add(pictureBoxIcon);
        }

        private void InitializeBorrowIcon()
        {
            PictureBox pictureBoxIcon = new PictureBox();
            pictureBoxIcon.Image = DrawingImage.FromFile(configUrl.GetImagePath("bookBorrow.png"));
            pictureBoxIcon.Size = new Size(42, 42);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxIcon.Location = new Point(0, 0);
            int offsetX = 20;
            int offsetY = panelstatisticsBorrow.Height - pictureBoxIcon.Height - 20;
            pictureBoxIcon.Location = new Point(offsetX, offsetY);
            panelstatisticsBorrow.Controls.Add(pictureBoxIcon);
        }

        private void Data()
        {
            try
            {
                {
                    DataTable dataTable = statistics.GETCountMemberRole();

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        int countValue = Convert.ToInt32(dataTable.Rows[0]["TotalRows"]);
                        lbTotalUserRole.Text = countValue.ToString();
                    }
                    else
                    {
                        Console.WriteLine("No data found.");
                    }
                }
                {
                    DataTable dataTable = statistics.GETCountMember();

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        int countValue = Convert.ToInt32(dataTable.Rows[0]["TotalRows"]);
                        lbTotalUser.Text = countValue.ToString();
                    }
                    else
                    {
                        Console.WriteLine("No data found.");
                    }
                }

                {
                    DataTable dataTable = statistics.GETCountBook();

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        int countValue = Convert.ToInt32(dataTable.Rows[0]["TotalQuantity"]);
                        lbCountBook.Text = countValue.ToString();
                    }
                    else
                    {
                        Console.WriteLine("No data found.");
                    }
                }

                {
                    DataTable dataTable = statistics.GETCountBook();
                    DataTable dataTableTotal = statistics.GETCountBookTotal();
                    int countDataTable = 0;
                    int countTableTotal = 0;
                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        int countValue = Convert.ToInt32(dataTable.Rows[0]["TotalQuantity"]);
                        countDataTable = countValue;
                        if (dataTableTotal != null && dataTableTotal.Rows.Count > 0)
                        {
                            int countValueTotal = Convert.ToInt32(dataTableTotal.Rows[0]["TotalQuantity"]);
                            countTableTotal = countValueTotal;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found.");
                    }
                    int Total = countDataTable + countTableTotal;
                    lbTotalBook.Text = Total.ToString();
                }
                {
                    DataTable dataTable = statistics.GETCountBorrow();

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        int countValue = Convert.ToInt32(dataTable.Rows[0]["TotalStatus"]);
                        lbBorrow.Text = countValue.ToString();
                    }
                    else
                    {
                        Console.WriteLine("No data found.");
                    }
                }
                {
                    DataTable dataTable = statistics.GETCountReturn();

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        int countValue = Convert.ToInt32(dataTable.Rows[0]["TotalStatus"]);
                        lbReturn.Text = countValue.ToString();
                    }
                    else
                    {
                        Console.WriteLine("No data found.");
                    }
                }
            }
            catch { }
        }
    }
}
