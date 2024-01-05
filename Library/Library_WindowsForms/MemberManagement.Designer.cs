namespace GUI
{
    partial class dataGridViewMember
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            lbMemberID = new Label();
            lbFirstName = new Label();
            lbLastName = new Label();
            lbEmail = new Label();
            lbRole = new Label();
            txtMemberId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            rBtnChoose = new RadioButton();
            rbtnAll = new RadioButton();
            gboxRole = new GroupBox();
            cbBan = new CheckBox();
            cboxBRR = new CheckBox();
            cboxRTB = new CheckBox();
            label2 = new Label();
            lbtextName = new Label();
            dataGridViewMembers = new DataGridView();
            comboBoxSearhc = new ComboBox();
            label3 = new Label();
            gboxRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(712, 112);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 27);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(815, 113);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(353, 28);
            txtSearch.TabIndex = 2;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(590, 68);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(590, 112);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(705, 68);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 58);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 7;
            label1.Text = "Infomation member";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMemberID.Location = new Point(46, 172);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(101, 22);
            lbMemberID.TabIndex = 8;
            lbMemberID.Text = "Member ID";
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbFirstName.Location = new Point(46, 242);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(98, 22);
            lbFirstName.TabIndex = 9;
            lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLastName.Location = new Point(46, 311);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(94, 22);
            lbLastName.TabIndex = 10;
            lbLastName.Text = "Last Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.Location = new Point(46, 386);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(57, 22);
            lbEmail.TabIndex = 11;
            lbEmail.Text = "Email";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbRole.Location = new Point(46, 520);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(48, 22);
            lbRole.TabIndex = 12;
            lbRole.Text = "Role";
            // 
            // txtMemberId
            // 
            txtMemberId.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMemberId.Location = new Point(181, 167);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(373, 28);
            txtMemberId.TabIndex = 13;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(181, 237);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(373, 28);
            txtFirstName.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(181, 309);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(373, 28);
            txtLastName.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(181, 381);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(373, 28);
            txtEmail.TabIndex = 16;
            // 
            // rBtnChoose
            // 
            rBtnChoose.AutoSize = true;
            rBtnChoose.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnChoose.Location = new Point(181, 521);
            rBtnChoose.Name = "rBtnChoose";
            rBtnChoose.Size = new Size(84, 24);
            rBtnChoose.TabIndex = 17;
            rBtnChoose.TabStop = true;
            rBtnChoose.Text = "Choose";
            rBtnChoose.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            rbtnAll.AutoSize = true;
            rbtnAll.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnAll.Location = new Point(351, 521);
            rbtnAll.Name = "rbtnAll";
            rbtnAll.Size = new Size(172, 24);
            rbtnAll.TabIndex = 18;
            rbtnAll.TabStop = true;
            rbtnAll.Text = "All Rights Reserved";
            rbtnAll.UseVisualStyleBackColor = true;
            // 
            // gboxRole
            // 
            gboxRole.Controls.Add(cbBan);
            gboxRole.Controls.Add(cboxBRR);
            gboxRole.Controls.Add(cboxRTB);
            gboxRole.Location = new Point(181, 566);
            gboxRole.Name = "gboxRole";
            gboxRole.Size = new Size(186, 125);
            gboxRole.TabIndex = 19;
            gboxRole.TabStop = false;
            gboxRole.Text = "Role";
            // 
            // cbBan
            // 
            cbBan.AutoSize = true;
            cbBan.Location = new Point(11, 83);
            cbBan.Name = "cbBan";
            cbBan.Size = new Size(56, 24);
            cbBan.TabIndex = 2;
            cbBan.Text = "Ban";
            cbBan.UseVisualStyleBackColor = true;
            // 
            // cboxBRR
            // 
            cboxBRR.AutoSize = true;
            cboxBRR.Location = new Point(11, 53);
            cboxBRR.Name = "cboxBRR";
            cboxBRR.Size = new Size(157, 24);
            cboxBRR.TabIndex = 1;
            cboxBRR.Text = "Book Return Rights";
            cboxBRR.UseVisualStyleBackColor = true;
            // 
            // cboxRTB
            // 
            cboxRTB.AutoSize = true;
            cboxRTB.Location = new Point(11, 23);
            cboxRTB.Name = "cboxRTB";
            cboxRTB.Size = new Size(136, 24);
            cboxRTB.TabIndex = 0;
            cboxRTB.Text = "Right to borrow";
            cboxRTB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(815, 23);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 20;
            label2.Text = "Wellcome";
            // 
            // lbtextName
            // 
            lbtextName.AutoSize = true;
            lbtextName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbtextName.Location = new Point(925, 23);
            lbtextName.Name = "lbtextName";
            lbtextName.Size = new Size(60, 22);
            lbtextName.TabIndex = 21;
            lbtextName.Text = "label3";
            // 
            // dataGridViewMembers
            // 
            dataGridViewMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMembers.Location = new Point(590, 167);
            dataGridViewMembers.Name = "dataGridViewMembers";
            dataGridViewMembers.RowHeadersWidth = 51;
            dataGridViewMembers.RowTemplate.Height = 29;
            dataGridViewMembers.Size = new Size(578, 524);
            dataGridViewMembers.TabIndex = 22;
            // 
            // comboBoxSearhc
            // 
            comboBoxSearhc.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSearhc.FormattingEnabled = true;
            comboBoxSearhc.Location = new Point(925, 69);
            comboBoxSearhc.Name = "comboBoxSearhc";
            comboBoxSearhc.Size = new Size(243, 27);
            comboBoxSearhc.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(875, 72);
            label3.Name = "label3";
            label3.Size = new Size(38, 22);
            label3.TabIndex = 24;
            label3.Text = "Filt";
            // 
            // dataGridViewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 703);
            Controls.Add(label3);
            Controls.Add(comboBoxSearhc);
            Controls.Add(dataGridViewMembers);
            Controls.Add(lbtextName);
            Controls.Add(label2);
            Controls.Add(gboxRole);
            Controls.Add(rbtnAll);
            Controls.Add(rBtnChoose);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtMemberId);
            Controls.Add(lbRole);
            Controls.Add(lbEmail);
            Controls.Add(lbLastName);
            Controls.Add(lbFirstName);
            Controls.Add(lbMemberID);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Name = "dataGridViewMember";
            Text = "MemberManagement";
            gboxRole.ResumeLayout(false);
            gboxRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private Label lbMemberID;
        private Label lbFirstName;
        private Label lbLastName;
        private Label lbEmail;
        private Label lbRole;
        private TextBox txtMemberId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private RadioButton rBtnChoose;
        private RadioButton rbtnAll;
        private GroupBox gboxRole;
        private CheckBox cbBan;
        private CheckBox cboxBRR;
        private CheckBox cboxRTB;
        private Label label2;
        private Label lbtextName;
        private DataGridView dataGridViewMembers;
        private ComboBox comboBoxSearhc;
        private Label label3;
    }
}