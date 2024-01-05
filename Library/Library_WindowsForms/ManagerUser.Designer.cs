namespace GUI
{
    partial class ManagerUser
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
            panelTotal = new Panel();
            lbTitleNameUserAdmin = new Label();
            lbTitle = new Label();
            dataGridViewManagerUser = new DataGridView();
            panelControl = new Panel();
            label6 = new Label();
            button6 = new Button();
            btnAdminGrant = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            panelManager = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lbUrlImage = new Label();
            pictureBoxImage = new PictureBox();
            txtFullName = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelLine = new Panel();
            panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManagerUser).BeginInit();
            panelControl.SuspendLayout();
            panelManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // panelTotal
            // 
            panelTotal.Controls.Add(lbTitleNameUserAdmin);
            panelTotal.Controls.Add(lbTitle);
            panelTotal.Controls.Add(dataGridViewManagerUser);
            panelTotal.Controls.Add(panelControl);
            panelTotal.Controls.Add(panelManager);
            panelTotal.Controls.Add(panelLine);
            panelTotal.Location = new Point(12, 12);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(1156, 679);
            panelTotal.TabIndex = 1;
            // 
            // lbTitleNameUserAdmin
            // 
            lbTitleNameUserAdmin.AutoSize = true;
            lbTitleNameUserAdmin.Dock = DockStyle.Right;
            lbTitleNameUserAdmin.ForeColor = Color.Red;
            lbTitleNameUserAdmin.Location = new Point(1106, 0);
            lbTitleNameUserAdmin.Name = "lbTitleNameUserAdmin";
            lbTitleNameUserAdmin.Size = new Size(50, 20);
            lbTitleNameUserAdmin.TabIndex = 5;
            lbTitleNameUserAdmin.Text = "label2";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(13, 11);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(158, 25);
            lbTitle.TabIndex = 4;
            lbTitle.Text = "Manager User";
            // 
            // dataGridViewManagerUser
            // 
            dataGridViewManagerUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManagerUser.Location = new Point(13, 382);
            dataGridViewManagerUser.Name = "dataGridViewManagerUser";
            dataGridViewManagerUser.RowHeadersWidth = 51;
            dataGridViewManagerUser.RowTemplate.Height = 29;
            dataGridViewManagerUser.Size = new Size(1132, 291);
            dataGridViewManagerUser.TabIndex = 3;
            // 
            // panelControl
            // 
            panelControl.Controls.Add(label6);
            panelControl.Controls.Add(button6);
            panelControl.Controls.Add(btnAdminGrant);
            panelControl.Controls.Add(btnDelete);
            panelControl.Controls.Add(btnUpdate);
            panelControl.Controls.Add(btnSave);
            panelControl.Location = new Point(870, 66);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(275, 310);
            panelControl.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(17, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 5;
            label6.Text = "Control";
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(77, 20);
            button6.Name = "button6";
            button6.Size = new Size(140, 29);
            button6.TabIndex = 4;
            button6.Text = "New user";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnAdminGrant
            // 
            btnAdminGrant.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminGrant.ForeColor = Color.OrangeRed;
            btnAdminGrant.Location = new Point(60, 254);
            btnAdminGrant.Name = "btnAdminGrant";
            btnAdminGrant.Size = new Size(180, 29);
            btnAdminGrant.TabIndex = 3;
            btnAdminGrant.Text = "Grant admin rights";
            btnAdminGrant.UseVisualStyleBackColor = true;
            btnAdminGrant.Click += btnAdminGrant_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(77, 188);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(77, 131);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(77, 70);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panelManager
            // 
            panelManager.Controls.Add(txtSearch);
            panelManager.Controls.Add(btnSearch);
            panelManager.Controls.Add(lbUrlImage);
            panelManager.Controls.Add(pictureBoxImage);
            panelManager.Controls.Add(txtFullName);
            panelManager.Controls.Add(txtConfirmPassword);
            panelManager.Controls.Add(txtPassword);
            panelManager.Controls.Add(txtUserName);
            panelManager.Controls.Add(label5);
            panelManager.Controls.Add(label4);
            panelManager.Controls.Add(label3);
            panelManager.Controls.Add(label2);
            panelManager.Controls.Add(label1);
            panelManager.Location = new Point(13, 66);
            panelManager.Name = "panelManager";
            panelManager.Size = new Size(851, 310);
            panelManager.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(156, 254);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(363, 28);
            txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(44, 254);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbUrlImage
            // 
            lbUrlImage.AutoSize = true;
            lbUrlImage.Location = new Point(581, 234);
            lbUrlImage.Name = "lbUrlImage";
            lbUrlImage.Size = new Size(35, 20);
            lbUrlImage.TabIndex = 11;
            lbUrlImage.Text = "...url";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(581, 39);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(227, 173);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 10;
            pictureBoxImage.TabStop = false;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(204, 192);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(315, 30);
            txtFullName.TabIndex = 8;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(204, 140);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(315, 30);
            txtConfirmPassword.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(204, 89);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 30);
            txtPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(204, 39);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(315, 30);
            txtUserName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 192);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Full name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 140);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 89);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 39);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "User name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, -3);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 0;
            label1.Text = "Manager";
            // 
            // panelLine
            // 
            panelLine.Location = new Point(3, 50);
            panelLine.Name = "panelLine";
            panelLine.Size = new Size(1153, 1);
            panelLine.TabIndex = 0;
            // 
            // ManagerUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 703);
            Controls.Add(panelTotal);
            Name = "ManagerUser";
            Text = "ManagerUser";
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManagerUser).EndInit();
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            panelManager.ResumeLayout(false);
            panelManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTotal;
        private Label lbTitleNameUserAdmin;
        private Label lbTitle;
        private DataGridView dataGridViewManagerUser;
        private Panel panelControl;
        private Panel panelManager;
        private Panel panelLine;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtFullName;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private PictureBox pictureBoxImage;
        private Label lbUrlImage;
        private Button btnAdminGrant;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button button6;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label6;
    }
}