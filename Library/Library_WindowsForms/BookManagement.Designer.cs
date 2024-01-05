namespace GUI
{
    partial class BookManagement
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PublicationYear = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBookID = new TextBox();
            txtBookTitle = new TextBox();
            txtAuthor = new TextBox();
            txtGenre = new TextBox();
            comboBoxYear = new ComboBox();
            comboboxQuatity = new ComboBox();
            dataGridViewBooks = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            comboboxSearch = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 42);
            label1.Name = "label1";
            label1.Size = new Size(77, 22);
            label1.TabIndex = 0;
            label1.Text = "Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 102);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 1;
            label2.Text = "Book Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 163);
            label3.Name = "label3";
            label3.Size = new Size(64, 22);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // PublicationYear
            // 
            PublicationYear.AutoSize = true;
            PublicationYear.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PublicationYear.Location = new Point(712, 37);
            PublicationYear.Name = "PublicationYear";
            PublicationYear.Size = new Size(137, 22);
            PublicationYear.TabIndex = 3;
            PublicationYear.Text = "PublicationYear";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(712, 102);
            label4.Name = "label4";
            label4.Size = new Size(76, 22);
            label4.TabIndex = 4;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(712, 163);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 5;
            label5.Text = "Genre";
            // 
            // txtBookID
            // 
            txtBookID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookID.Location = new Point(193, 34);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(442, 30);
            txtBookID.TabIndex = 6;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookTitle.Location = new Point(193, 99);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(442, 30);
            txtBookTitle.TabIndex = 7;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthor.Location = new Point(193, 160);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(442, 30);
            txtAuthor.TabIndex = 8;
            // 
            // txtGenre
            // 
            txtGenre.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGenre.Location = new Point(882, 157);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(286, 30);
            txtGenre.TabIndex = 9;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(882, 37);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(151, 28);
            comboBoxYear.TabIndex = 10;
            // 
            // comboboxQuatity
            // 
            comboboxQuatity.FormattingEnabled = true;
            comboboxQuatity.Location = new Point(882, 100);
            comboboxQuatity.Name = "comboboxQuatity";
            comboboxQuatity.Size = new Size(151, 28);
            comboboxQuatity.TabIndex = 11;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(12, 285);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.RowTemplate.Height = 29;
            dataGridViewBooks.Size = new Size(1156, 406);
            dataGridViewBooks.TabIndex = 12;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(45, 233);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 31);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(168, 233);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 31);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(301, 232);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 31);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(441, 232);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 31);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(573, 233);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(368, 30);
            txtSearch.TabIndex = 17;
            // 
            // comboboxSearch
            // 
            comboboxSearch.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboboxSearch.FormattingEnabled = true;
            comboboxSearch.Location = new Point(947, 234);
            comboboxSearch.Name = "comboboxSearch";
            comboboxSearch.Size = new Size(153, 28);
            comboboxSearch.TabIndex = 18;
            // 
            // BookManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1180, 703);
            Controls.Add(comboboxSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dataGridViewBooks);
            Controls.Add(comboboxQuatity);
            Controls.Add(comboBoxYear);
            Controls.Add(txtGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookTitle);
            Controls.Add(txtBookID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(PublicationYear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookManagement";
            Text = "BookManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label PublicationYear;
        private Label label4;
        private Label label5;
        private TextBox txtBookID;
        private TextBox txtBookTitle;
        private TextBox txtAuthor;
        private TextBox txtGenre;
        private ComboBox comboBoxYear;
        private ComboBox comboboxQuatity;
        private DataGridView dataGridViewBooks;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox comboboxSearch;
    }
}