using BLL;
using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Borrow_ReturnBookManagement : Form
    {
        private Borrowing_ReturnBLL borrowing_Return;
        private Brrowing_Return brrowing;
        private DataTable borrowDataTable;
        private PrintDocument printDocument;

        private string status = "Borrowed";

        public Borrow_ReturnBookManagement()
        {
            InitializeComponent();
            dataGridViewBorrowReturn.CellClick += dataGridViewBorrowReturn_CellClick;
            dataGridViewBorrowReturn.CellFormatting += dataGridViewBorrowReturn_CellFormatting;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            txtSearch.KeyPress += TxtSearch_KeyPress;
            init();
        }
        private void dataGridViewBorrowReturn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewBorrowReturn.Columns["Status"].Index)
            {
                object returnDateCellValue = dataGridViewBorrowReturn.Rows[e.RowIndex].Cells["ReturnDate"].Value;
                if (returnDateCellValue != DBNull.Value && returnDateCellValue != null)
                {
                    string dateFormat = "dd/MM/yyyy";
                    if (DateTime.TryParseExact(returnDateCellValue.ToString(), dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime returnDateValue))
                    {
                        if (returnDateValue < DateTime.Now)
                        {
                            string statusValue = dataGridViewBorrowReturn.Rows[e.RowIndex].Cells["Status"].Value?.ToString();
                            if ("Borrowed".Equals(statusValue, StringComparison.OrdinalIgnoreCase))
                            {
                                e.CellStyle.BackColor = Color.Red;
                                e.CellStyle.ForeColor = Color.White;
                            }
                            else
                            {
                                e.CellStyle.BackColor = dataGridViewBorrowReturn.DefaultCellStyle.BackColor;
                                e.CellStyle.ForeColor = dataGridViewBorrowReturn.DefaultCellStyle.ForeColor;
                            }
                        }
                        else
                        {
                            e.CellStyle.BackColor = dataGridViewBorrowReturn.DefaultCellStyle.BackColor;
                            e.CellStyle.ForeColor = dataGridViewBorrowReturn.DefaultCellStyle.ForeColor;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format");
                    }
                }
                else{}
            }
        }
        private void TxtSearch_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string value = txtSearch.Text;
                borrowDataTable = borrowing_Return.Search(value);

                dataGridViewBorrowReturn.DataSource = borrowDataTable;
                dataGridViewBorrowReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            if (rbSearch.Checked)
            {
                string value = txtSearch.Text;
                borrowDataTable = borrowing_Return.Search(value);

                dataGridViewBorrowReturn.DataSource = borrowDataTable;
                dataGridViewBorrowReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else { }
        }

        private void init()
        {
            string loggedInUser = UserSession.FullName;
            lbadmin.Text = loggedInUser;
            borrowing_Return = new Borrowing_ReturnBLL();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            txtBorrowID.ReadOnly = true;
            InitializeComboBoxQuantity();
            LoadDataToComboBoxMember();
            LoadDataToComboBoxBook();
            LoadBorrow();
            setUp();
            enable();
        }
        private void enable()
        {
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnRenew.Enabled = false;
            btnReturnBook.Enabled = false;
        }
        private void trueEnable()
        {
            btnDelete.Enabled = true;
            btnPrint.Enabled = true;
            btnRenew.Enabled = true;
            btnReturnBook.Enabled = true;
        }
        private void dataGridViewBorrowReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewBorrowReturn.Rows[e.RowIndex];

                string BorrowID = selectedRow.Cells["BorrowingID"].Value.ToString();
                string title = selectedRow.Cells["Title"].Value.ToString();
                string FirstName = selectedRow.Cells["FirstName"].Value.ToString();
                string LastName = selectedRow.Cells["LastName"].Value.ToString();
                string BorrowDate = selectedRow.Cells["BorrowDate"].Value.ToString();
                string ReturnDate = selectedRow.Cells["ReturnDate"].Value.ToString();
                string QuantityBorrowed = selectedRow.Cells["QuantityBorrowed"].Value.ToString();
                string status = selectedRow.Cells["Status"].Value.ToString();

                txtBorrowID.Text = BorrowID;
                cbNameMember.Text = $"{FirstName} {LastName}";
                BookName.Text = title;
                if (DateTime.TryParse(BorrowDate, out DateTime borrowDate))
                {
                    dateTimeBorrow.Value = borrowDate;
                }

                if (DateTime.TryParse(ReturnDate, out DateTime returnDate))
                {
                    dateTimeReturn.Value = returnDate;
                }
                cbQuantity.Text = QuantityBorrowed;
                this.status = status;
                trueEnable();
            }
        }
        private void InitializeComboBoxQuantity()
        {
            List<int> Quantity = new List<int>();

            for (int i = 1; i <= 200; i++)
            {
                Quantity.Add(i);
            }
            cbQuantity.DataSource = new BindingSource(Quantity, null);
            cbQuantity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbQuantity.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadDataToComboBoxMember()
        {
            DataTable dataTable = borrowing_Return.GetMember();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    brrowing = new Brrowing_Return
                    {
                        MemberID = row["MemberID"].ToString(),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        BookID = null,
                        title = null
                    };
                    cbNameMember.Items.Add(brrowing);
                    cbNameMember.ValueMember = $"{brrowing.MemberID}";
                }

                cbNameMember.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbNameMember.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }


        private void LoadDataToComboBoxBook()
        {
            DataTable dataTable = borrowing_Return.GetBook();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {

                BookName.DisplayMember = "title";
                foreach (DataRow row in dataTable.Rows)
                {
                    Brrowing_Return brrowing = new Brrowing_Return
                    {
                        BookID = Convert.ToInt32(row["BookID"]),
                        title = row["Title"].ToString()
                    };

                    BookName.Items.Add(brrowing);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }
        private void LoadBorrow()
        {
            try
            {
                borrowDataTable = borrowing_Return.GetBorrowing();

                if (borrowDataTable != null)
                {
                    dataGridViewBorrowReturn.DataSource = borrowDataTable;
                    dataGridViewBorrowReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Unable to download member data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setUp()
        {
            string inputString = borrowing_Return.GetMaxID();
            string prefix = inputString.Substring(0, 3);
            string suffix = inputString.Substring(3);

            if (int.TryParse(suffix, out int suffixValue))
            {
                if (suffixValue == 9999)
                {
                    suffixValue++;
                    string updatedSuffix = suffixValue.ToString("D5");
                    string updatedString = prefix + updatedSuffix;

                    txtBorrowID.Text = updatedString;
                }
                else
                {
                    suffixValue++;

                    string updatedSuffix = suffixValue.ToString("D4");
                    string updatedString = prefix + updatedSuffix;

                    txtBorrowID.Text = updatedString;
                }

            }
            else
            {
                Console.WriteLine("Invalid suffix format");
            }
        }
        private bool IsValidInput()
        {
            if (!string.IsNullOrEmpty(txtBorrowID.Text)
                || cbNameMember.SelectedItem != null
                || cbQuantity != null
                || BookName != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void DeleteText()
        {
            setUp();
            cbNameMember.Text = "";
            BookName.Text = "";
            cbQuantity.SelectedIndex = 0;
            dateTimeBorrow.Value = DateTime.Today;
            dateTimeReturn.Value = DateTime.Today;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void insert()
        {
            if (IsValidInput())
            {
                DateTime selectedDate1 = dateTimeBorrow.Value;
                DateTime selectedDate2 = dateTimeReturn.Value;
                Brrowing_Return newBorrowing = new Brrowing_Return
                {
                    BorrowingID = txtBorrowID.Text,
                    IDBookBorrowingDetails = GetBookID().GetValueOrDefault(),
                    IDMemberBorrowing = GetMemberID(),
                    DateBorrowing = selectedDate1.ToString("dd/MM/yyyy"),
                    DateReturnBorrowing = selectedDate2.ToString("dd/MM/yyyy"),
                    quantity = Convert.ToInt32(cbQuantity.SelectedValue),
                    DeleteBorrowing = 1,
                };

                borrowing_Return.InsertBorrow(newBorrowing);
                DeleteText();
                LoadBorrow();
            }
        }

        private string GetMemberID()
        {
            if (cbNameMember.SelectedItem != null)
            {
                Brrowing_Return selectedMember = (Brrowing_Return)cbNameMember.SelectedItem;
                string selectedMemberID = selectedMember.MemberID;

                // MessageBox.Show("Selected MemberID: " + selectedMemberID);
                return selectedMember.MemberID;
            }
            else
            {
                Console.WriteLine("No item selected.");
                return 0 + "";
            }

        }

        private int? GetBookID()
        {
            if (BookName.SelectedItem != null)
            {
                Brrowing_Return selectBook = (Brrowing_Return)BookName.SelectedItem;
                int? selectedBookID = selectBook.BookID;

                //MessageBox.Show("Selected MemberID: " + selectedBookID);
                return selectedBookID;
            }
            else
            {
                Console.WriteLine("No item selected.");
                return 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string key = txtBorrowID.Text;

            borrowing_Return.deleteBorrow(key);

            LoadBorrow();
            enable();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            string key = txtBorrowID.Text;

            borrowing_Return.returnBorrow(key);

            LoadBorrow();
            enable();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (this.status == "Borrowed")
            {
                DateTime selectedDate2 = dateTimeReturn.Value;
                string key = txtBorrowID.Text;
                string value = selectedDate2.ToString("dd/MM/yyyy");
                borrowing_Return.reNewBorrow(key, value);

                LoadBorrow();
                enable();
            }
            else
            {
                MessageBox.Show("The voucher was returned.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                enable();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DeleteText();
            LoadBorrow();
            enable();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            borrowDataTable = borrowing_Return.Histoey();

            dataGridViewBorrowReturn.DataSource = borrowDataTable;
            dataGridViewBorrowReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            enable();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.status == "Borrowed")
                {
                    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.ShowDialog();
                    printDocument.Print();
                    enable();
                }
                else
                {
                    MessageBox.Show("The voucher was returned.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    enable();
                }
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            DateTime selectedDate1 = dateTimeBorrow.Value;
            DateTime selectedDate2 = dateTimeReturn.Value;
            string loggedInUser = UserSession.FullName;

            System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
            System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
            float lineHeight = font.GetHeight(e.Graphics);
            float yPos = 100;
            float printWidth = e.MarginBounds.Width;
            float printHeight = e.MarginBounds.Height;
            yPos += lineHeight;
            yPos += lineHeight; 
            yPos += lineHeight;
            RectangleF titleRect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, printWidth, lineHeight);
            RectangleF printRect = new RectangleF(e.MarginBounds.Left, yPos, printWidth, printHeight);
            
              StringFormat valueFormat = new StringFormat
              {
                  Alignment = StringAlignment.Near,
                  LineAlignment = StringAlignment.Center
              };

            StringFormat titleFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            yPos += lineHeight;
            yPos += lineHeight;
            yPos += lineHeight;
            yPos += lineHeight;
            yPos += lineHeight;
           
            e.Graphics.DrawString("Borrowing Invoice", titleFont, Brushes.Black, titleRect, titleFormat);
            yPos += lineHeight;
            yPos += lineHeight;
           
            e.Graphics.DrawString($"Name: {cbNameMember.Text}", font, Brushes.Black, 300, yPos, valueFormat);
            yPos += lineHeight;
            yPos += lineHeight;
            
            yPos += lineHeight;
            e.Graphics.DrawString($"Book Title: {BookName.Text}", font, Brushes.Black, 300, yPos , valueFormat);
            yPos += lineHeight;
            yPos += lineHeight;
            
            yPos += lineHeight;
            e.Graphics.DrawString($"Borrow Date: {selectedDate1.ToString("dd/MM/yyyy")}", font, Brushes.Black, 300, yPos, valueFormat);
            yPos += lineHeight;
            yPos += lineHeight;
            
            yPos += lineHeight;
            e.Graphics.DrawString($"Return Date: {selectedDate2.ToString("dd/MM/yyyy")}", font, Brushes.Black, 300, yPos, valueFormat);
            yPos += lineHeight;
            yPos += lineHeight;
            
            yPos += lineHeight;
            e.Graphics.DrawString($"Quantity of Books: {cbQuantity.Text}", font, Brushes.Black, 300, yPos, valueFormat);
            yPos += lineHeight;
            yPos += lineHeight;
            
            yPos += lineHeight;
            e.Graphics.DrawString($"Manager: {loggedInUser}", font, Brushes.Black, 300, yPos , valueFormat);
            yPos += lineHeight;
            yPos += lineHeight;
            
            e.Graphics.DrawRectangle(Pens.Black, printRect.Left, printRect.Top, printRect.Width, printRect.Height);
        }
    }
}
