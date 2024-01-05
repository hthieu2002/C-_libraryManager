using BLL;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI
{
    public partial class BookManagement : Form
    {
        private BookBLL bookBLL;
        private DataTable booksDataTable;

        public BookManagement()
        {
            InitializeComponent();
            bookBLL = new BookBLL();
            init();
        }

        private void init()
        {
            InitializeYearComboBox();
            InitializeComboBoxQuantity();
            InitializeComboBoxSearch();
            SetInit();
            LoadBooks();

            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
            dataGridViewBooks.CellFormatting += dataGridViewBooks_CellFormatting;
            txtSearch.KeyDown += txtSearch_KeyDown;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void InitializeYearComboBox()
        {
            List<int> years = new List<int>();
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                years.Add(year);
            }
            comboBoxYear.DataSource = new BindingSource(years, null);
            comboBoxYear.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxYear.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        private void InitializeComboBoxQuantity()
        {
            List<int> Quantity = new List<int>();

            for (int i = 0; i <= 200; i++)
            {
                Quantity.Add(i);
            }
            comboboxQuatity.DataSource = new BindingSource(Quantity, null);
            comboboxQuatity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboboxQuatity.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void InitializeComboBoxSearch()
        {
            List<string> Search = new List<string>();
            Search.Add("BookID");
            Search.Add("Title");
            Search.Add("Author");
            Search.Add("PublicationYear");
            Search.Add("Quantity");
            Search.Add("Status");

            comboboxSearch.DataSource = new BindingSource(Search, null);
            comboboxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboboxSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void SetInit()
        {
            txtBookID.ReadOnly = true;
            txtSearch.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            comboboxSearch.Enabled = false;
        }

        private void LoadBooks()
        {
            booksDataTable = bookBLL.GetAllBooks();
            dataGridViewBooks.DataSource = booksDataTable;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewBooks.Rows[e.RowIndex];

                string bookID = selectedRow.Cells["BookID"].Value.ToString();
                string title = selectedRow.Cells["Title"].Value.ToString();
                string author = selectedRow.Cells["Author"].Value.ToString();
                string publicationYear = selectedRow.Cells["PublicationYear"].Value.ToString();
                string quantity = selectedRow.Cells["Quantity"].Value.ToString();
                string genre = selectedRow.Cells["Genre"].Value.ToString();

                txtBookID.Text = bookID;
                txtBookTitle.Text = title;
                txtAuthor.Text = author;
                comboBoxYear.Text = publicationYear;
                comboboxQuatity.Text = quantity;
                txtGenre.Text = genre;

                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

            }
        }

        private void dataGridViewBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                string statusValue = e.Value?.ToString();

                if (string.Equals(statusValue, "Out of stock", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.DarkGreen;
                }
            }
        }
        private bool IsValidInput()
        {
            if (!string.IsNullOrWhiteSpace(txtBookTitle.Text) &&
                !string.IsNullOrWhiteSpace(txtAuthor.Text) &&
                !string.IsNullOrWhiteSpace(txtGenre.Text) &&
                comboboxQuatity.SelectedValue != null &&
                comboBoxYear.SelectedValue != null)
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
            txtBookID.Text = "";
            txtAuthor.Text = "";
            txtBookTitle.Text = "";
            txtGenre.Text = "";
            comboboxQuatity.SelectedIndex = 0;
            comboBoxYear.SelectedIndex = 0;
            txtSearch.Enabled = false;
            txtSearch.Text = "";
            comboboxSearch.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                Book newBook = new Book
                {
                    Title = txtBookTitle.Text,
                    Author = txtAuthor.Text,
                    PublicationYear = Convert.ToInt32(comboBoxYear.SelectedValue),
                    Quantity = Convert.ToInt32(comboboxQuatity.SelectedValue),
                    Genre = txtGenre.Text
                };

                bookBLL.InsertBook(newBook);
                DeleteText();
                LoadBooks();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                Book updatedBook = new Book
                {
                    BookID = Convert.ToInt32(txtBookID.Text),
                    Title = txtBookTitle.Text,
                    Author = txtAuthor.Text,
                    PublicationYear = Convert.ToInt32(comboBoxYear.SelectedValue),
                    Quantity = Convert.ToInt32(comboboxQuatity.SelectedValue),
                    Genre = txtGenre.Text
                };

                bookBLL.UpdateBook(updatedBook);
                DeleteText();
                LoadBooks();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedBookID = Convert.ToInt32(txtBookID.Text);
            bookBLL.DeleteBook(selectedBookID);
            DeleteText();
            LoadBooks();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Enabled = true;
            comboboxSearch.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string title = comboboxSearch.SelectedItem != null ? comboboxSearch.SelectedItem.ToString() : string.Empty;
            string value = txtSearch.Text;

            booksDataTable = bookBLL.SearchBook(title, value);
            dataGridViewBooks.DataSource = booksDataTable;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            string title = comboboxSearch.SelectedItem != null ? comboboxSearch.SelectedItem.ToString() : string.Empty;
            string value = txtSearch.Text;
            if (e.KeyCode == Keys.Enter)
            {
                booksDataTable = bookBLL.SearchBook(title, value);
                dataGridViewBooks.DataSource = booksDataTable;
                dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
