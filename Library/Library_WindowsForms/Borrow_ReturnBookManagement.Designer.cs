namespace GUI
{
    partial class Borrow_ReturnBookManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnNew = new Button();
            label7 = new Label();
            dateTimeReturn = new DateTimePicker();
            cbQuantity = new ComboBox();
            label6 = new Label();
            BookName = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            dateTimeBorrow = new DateTimePicker();
            cbNameMember = new ComboBox();
            label3 = new Label();
            txtBorrowID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnHistory = new Button();
            lbadmin = new Label();
            lbNameAdmin = new Label();
            panel3 = new Panel();
            txtSearch = new TextBox();
            rbSearch = new RadioButton();
            btnDelete = new Button();
            btnPrint = new Button();
            btnRenew = new Button();
            btnReturnBook = new Button();
            btnSave = new Button();
            dataGridViewBorrowReturn = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrowReturn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimeReturn);
            panel1.Controls.Add(cbQuantity);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(BookName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTimeBorrow);
            panel1.Controls.Add(cbNameMember);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBorrowID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 363);
            panel1.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(621, 18);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(346, 267);
            label7.Name = "label7";
            label7.Size = new Size(104, 22);
            label7.TabIndex = 11;
            label7.Text = "Return Date";
            // 
            // dateTimeReturn
            // 
            dateTimeReturn.CustomFormat = "dd/MM/yyyy";
            dateTimeReturn.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeReturn.Format = DateTimePickerFormat.Custom;
            dateTimeReturn.Location = new Point(456, 265);
            dateTimeReturn.Name = "dateTimeReturn";
            dateTimeReturn.Size = new Size(259, 28);
            dateTimeReturn.TabIndex = 10;
            // 
            // cbQuantity
            // 
            cbQuantity.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbQuantity.FormattingEnabled = true;
            cbQuantity.Location = new Point(159, 264);
            cbQuantity.Name = "cbQuantity";
            cbQuantity.Size = new Size(103, 28);
            cbQuantity.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 264);
            label6.Name = "label6";
            label6.Size = new Size(76, 22);
            label6.TabIndex = 8;
            label6.Text = "Quantity";
            // 
            // BookName
            // 
            BookName.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BookName.FormattingEnabled = true;
            BookName.Location = new Point(159, 196);
            BookName.Name = "BookName";
            BookName.Size = new Size(270, 28);
            BookName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 198);
            label5.Name = "label5";
            label5.Size = new Size(103, 22);
            label5.TabIndex = 6;
            label5.Text = "Book Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 136);
            label4.Name = "label4";
            label4.Size = new Size(99, 22);
            label4.TabIndex = 5;
            label4.Text = "BrrowDate";
            // 
            // dateTimeBorrow
            // 
            dateTimeBorrow.CustomFormat = "dd/MM/yyyy";
            dateTimeBorrow.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeBorrow.Format = DateTimePickerFormat.Custom;
            dateTimeBorrow.Location = new Point(159, 130);
            dateTimeBorrow.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dateTimeBorrow.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimeBorrow.Name = "dateTimeBorrow";
            dateTimeBorrow.Size = new Size(272, 28);
            dateTimeBorrow.TabIndex = 4;
            // 
            // cbNameMember
            // 
            cbNameMember.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbNameMember.FormattingEnabled = true;
            cbNameMember.Location = new Point(159, 70);
            cbNameMember.Name = "cbNameMember";
            cbNameMember.Size = new Size(273, 28);
            cbNameMember.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 76);
            label3.Name = "label3";
            label3.Size = new Size(127, 22);
            label3.TabIndex = 2;
            label3.Text = "Name Member";
            // 
            // txtBorrowID
            // 
            txtBorrowID.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBorrowID.Location = new Point(159, 18);
            txtBorrowID.Name = "txtBorrowID";
            txtBorrowID.Size = new Size(274, 28);
            txtBorrowID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(97, 22);
            label1.TabIndex = 0;
            label1.Text = "Borrow ID";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnHistory);
            panel2.Controls.Add(lbadmin);
            panel2.Controls.Add(lbNameAdmin);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnPrint);
            panel2.Controls.Add(btnRenew);
            panel2.Controls.Add(btnReturnBook);
            panel2.Controls.Add(btnSave);
            panel2.Location = new Point(757, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 363);
            panel2.TabIndex = 1;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistory.Location = new Point(163, 310);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(115, 37);
            btnHistory.TabIndex = 8;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // lbadmin
            // 
            lbadmin.AutoSize = true;
            lbadmin.Location = new Point(131, 18);
            lbadmin.Name = "lbadmin";
            lbadmin.Size = new Size(50, 20);
            lbadmin.TabIndex = 7;
            lbadmin.Text = "label2";
            // 
            // lbNameAdmin
            // 
            lbNameAdmin.AutoSize = true;
            lbNameAdmin.Location = new Point(28, 18);
            lbNameAdmin.Name = "lbNameAdmin";
            lbNameAdmin.Size = new Size(104, 20);
            lbNameAdmin.TabIndex = 6;
            lbNameAdmin.Text = "Management :";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(rbSearch);
            panel3.Location = new Point(28, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(368, 141);
            panel3.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(23, 76);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(319, 30);
            txtSearch.TabIndex = 1;
            // 
            // rbSearch
            // 
            rbSearch.AutoSize = true;
            rbSearch.Location = new Point(23, 34);
            rbSearch.Name = "rbSearch";
            rbSearch.Size = new Size(145, 24);
            rbSearch.TabIndex = 0;
            rbSearch.TabStop = true;
            rbSearch.Text = "Search Borrow ID";
            rbSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(163, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 42);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.Location = new Point(302, 310);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 37);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnRenew
            // 
            btnRenew.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRenew.Location = new Point(302, 231);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(94, 42);
            btnRenew.TabIndex = 2;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += btnRenew_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturnBook.Location = new Point(28, 307);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(121, 40);
            btnReturnBook.TabIndex = 1;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(28, 231);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridViewBorrowReturn
            // 
            dataGridViewBorrowReturn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBorrowReturn.Location = new Point(9, 371);
            dataGridViewBorrowReturn.Name = "dataGridViewBorrowReturn";
            dataGridViewBorrowReturn.RowHeadersWidth = 51;
            dataGridViewBorrowReturn.RowTemplate.Height = 29;
            dataGridViewBorrowReturn.Size = new Size(1170, 320);
            dataGridViewBorrowReturn.TabIndex = 2;
            // 
            // Borrow_ReturnBookManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 703);
            Controls.Add(dataGridViewBorrowReturn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Borrow_ReturnBookManagement";
            Text = "Borrow_ReturnBookManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrowReturn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewBorrowReturn;
        private Panel panel3;
        private TextBox txtSearch;
        private RadioButton rbSearch;
        private Button btnDelete;
        private Button btnPrint;
        private Button btnRenew;
        private Button btnReturnBook;
        private Button btnSave;
        private Label label1;
        private Label lbNameAdmin;
        private Label label3;
        private TextBox txtBorrowID;
        private DateTimePicker dateTimeBorrow;
        private ComboBox cbNameMember;
        private Label label7;
        private DateTimePicker dateTimeReturn;
        private ComboBox cbQuantity;
        private Label label6;
        private ComboBox BookName;
        private Label label5;
        private Label label4;
        private Label lbadmin;
        private Button btnNew;
        private Button btnHistory;
    }
}