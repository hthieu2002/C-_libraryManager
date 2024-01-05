using BLL;
using DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class dataGridViewMember : Form
    {
        private MemberBLL memberBLL;
        private DataTable memberDataTable;
        string IDMember = "";
        public dataGridViewMember()
        {
            InitializeComponent();
            memberBLL = new MemberBLL();
            Init();
        }

        private void Init()
        {
            SetUp();
            LoadMembers();
            VisibleControl();
            InitializeComboBoxSearch();
        }

        private void SetUp()
        {
            dataGridViewMembers.CellFormatting += dataGridViewMembers_CellFormatting;
            dataGridViewMembers.CellClick += dataGridViewMembers_CellClick;
            txtMemberId.TextChanged += txtMemberId_TextChanged;
            txtSearch.TextChanged += txtSearch_TextChanged;
            rBtnChoose.CheckedChanged += rBtnChoose_CheckedChanged;
            rbtnAll.CheckedChanged += rbtnAll_CheckedChanged;
            cboxBRR.CheckedChanged += cboxBRR_CheckedChanged;
            cboxRTB.CheckedChanged += cboxRTB_CheckedChanged;
            cbBan.CheckedChanged += cbBan_CheckedChanged;
            comboBoxSearhc.SelectedIndexChanged += comboBoxSearhc_SelectedIndexChanged;
            string loggedInUser = UserSession.FullName;
            lbtextName.Text = loggedInUser;

        }

        private void dataGridViewMembers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                string roleColumnName = "Role";
                if (dataGridViewMembers.Columns[e.ColumnIndex].Name == roleColumnName && e.RowIndex >= 0)
                {
                    if (e.Value != null && (string)e.Value == "1")
                    {
                        e.Value = "Ban";
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else if (e.Value != null && (string)e.Value == "2")
                    {
                        e.Value = "Book Return Rights";
                    }
                    else if (e.Value != null && (string)e.Value == "3")
                    {
                        e.Value = "Right to borrow";
                    }
                    else if (e.Value != null && (string)e.Value == "4")
                    {
                        e.Value = "All Rights Reserved";
                    }
                }
            }
            catch { }

        }


        private void VisibleControl()
        {
            gboxRole.Visible = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void InitializeComboBoxSearch()
        {
            List<string> Search = new List<string>();
            Search.Add("...");
            Search.Add("All Rights Reserved");
            Search.Add("Right to borrow");
            Search.Add("Book Return Rights");
            Search.Add("Ban");
   

            comboBoxSearhc.DataSource = new BindingSource(Search, null);
            comboBoxSearhc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSearhc.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadMembers()
        {
            try
            {
                memberDataTable = memberBLL.GetAllMembers();

                if (memberDataTable != null)
                {
                    dataGridViewMembers.DataSource = memberDataTable;
                    dataGridViewMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        private void dataGridViewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewMembers.Rows[e.RowIndex];

                string MemberID = selectedRow.Cells["MemberID"].Value.ToString();
                string FirstName = selectedRow.Cells["FirstName"].Value.ToString();
                string LastName = selectedRow.Cells["LastName"].Value.ToString();
                string Email = selectedRow.Cells["Email"].Value.ToString();
                string Role = selectedRow.Cells["Role"].Value.ToString();

                txtMemberId.Text = MemberID;
                txtFirstName.Text = FirstName;
                txtLastName.Text = LastName;
                txtEmail.Text = Email;
                switch (Role)
                {
                    case "1":
                        rBtnChoose.Checked = true;
                        gboxRole.Visible = true;
                        cbBan.Checked = true;
                        break;
                    case "2":
                        rBtnChoose.Checked = true;
                        gboxRole.Visible = true;
                        cboxBRR.Checked = true;
                        break;
                    case "3":
                        rBtnChoose.Checked = true;
                        gboxRole.Visible = true;
                        cboxRTB.Checked = true;
                        break;
                    case "4":
                        rbtnAll.Checked = true;
                        break;
                }
                IDMember = MemberID;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void txtMemberId_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            textBox.Text = textBox.Text.ToUpper();
            textBox.SelectionStart = textBox.Text.Length;
        }


        private void rBtnChoose_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnChoose.Checked)
            {
                gboxRole.Visible = true;
            }
            else
            {
                gboxRole.Visible = false;
            }
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAll.Checked)
            {
                cboxRTB.Checked = false;
                cboxBRR.Checked = false;
                cbBan.Checked = false;
            }
        }

        private void cboxBRR_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxBRR.Checked)
            {
                cbBan.Checked = false;
            }
        }

        private void cboxRTB_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxRTB.Checked)
            {
                cbBan.Checked = false;
            }
        }
        private void cbBan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBan.Checked)
            {
                cboxRTB.Checked = false;
                cboxBRR.Checked = false;
            }
        }
        private bool IsValidInput()
        {
            if (!string.IsNullOrWhiteSpace(txtMemberId.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                if (rBtnChoose.Checked || rbtnAll.Checked)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        // ban = 1, BRR && RTB = 4 == ALL , BRR = 2, RTB = 3
        private int checkRole()
        {
            int status = 0;
            if (rBtnChoose.Checked)
            {
                if (cbBan.Checked)
                {
                    status = 1;
                }
                else if (cboxBRR.Checked && cboxRTB.Checked)
                {
                    status = 4;
                }
                else
                {
                    if (cboxBRR.Checked)
                    {
                        status = 2;
                    }
                    else if (cboxRTB.Checked)
                    {
                        status = 3;
                    }
                }
            }
            else
            {
                status = 4;
            }


            return status;
        }

        private void DeleteText()
        {
            VisibleControl();
            txtMemberId.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtEmail.Text = "";
            rbtnAll.Checked = false;
            rBtnChoose.Checked = false;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (IsValidInput() && checkRole() != 0)
            {
                Member newMember = new Member
                {
                    MemberID = txtMemberId.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Role = checkRole()
                };

                memberBLL.InsertMember(newMember);
                DeleteText();
                LoadMembers();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidInput() && checkRole() != 0)
            {
                Member updatedMember = new Member
                {
                    MemberID = txtMemberId.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Role = checkRole(),
                    IDMember = IDMember
                };

                memberBLL.UpdateMember(updatedMember);
                DeleteText();
                LoadMembers();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedMemberID = IDMember;
            memberBLL.DeleteMember(selectedMemberID);
            DeleteText();
            LoadMembers();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (!string.IsNullOrEmpty(keyword))
            {

                FuzzySearchDataGridView(keyword);
            }
            else
            {

                ClearSearchResults();
            }
        }

        private void FuzzySearchDataGridView(string keyword)
        {
            dataGridViewMembers.ClearSelection();

            foreach (DataGridViewRow row in dataGridViewMembers.Rows)
            {
                bool found = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && FuzzyMatch(cell.Value.ToString(), keyword))
                    {

                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    row.Selected = true;
                    dataGridViewMembers.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
        }


        private void ClearSearchResults()
        {
            foreach (DataGridViewRow row in dataGridViewMembers.Rows)
            {
                row.Selected = false;
            }
        }

        private bool FuzzyMatch(string input, string pattern)
        {
            return input.ToLower().Contains(pattern.ToLower());
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            FuzzySearchDataGridView(keyword);
        }

        private void comboBoxSearhc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = comboBoxSearhc.SelectedIndex;

            if(selectedValue == 0)
            {
                LoadMembers();
            }
            else if(selectedValue == 1)
            {
                memberDataTable = memberBLL.Search("4");
                dataGridViewMembers.DataSource = memberDataTable;
                dataGridViewMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if(selectedValue == 2)
            {
                memberDataTable = memberBLL.Search("3");
                dataGridViewMembers.DataSource = memberDataTable;
                dataGridViewMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (selectedValue == 3)
            {
                memberDataTable = memberBLL.Search("2");
                dataGridViewMembers.DataSource = memberDataTable;
                dataGridViewMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (selectedValue == 4)
            {
                memberDataTable = memberBLL.Search("1");
                dataGridViewMembers.DataSource = memberDataTable;
                dataGridViewMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
