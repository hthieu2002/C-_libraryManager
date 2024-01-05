namespace Library_WindowsForms
{
    partial class ViewHomeLibrary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            View = new Panel();
            labelName = new Label();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            supportAndContactToolStripMenuItem = new ToolStripMenuItem();
            notificationAndSystemToolStripMenuItem = new ToolStripMenuItem();
            MenuHome = new ToolStripMenuItem();
            bookManagementToolStripMenuItem = new ToolStripMenuItem();
            memberManagementToolStripMenuItem = new ToolStripMenuItem();
            borrowReturnManagementToolStripMenuItem = new ToolStripMenuItem();
            statisticsAndReportsToolStripMenuItem = new ToolStripMenuItem();
            menu = new MenuStrip();
            View.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // View
            // 
            View.Controls.Add(labelName);
            View.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            View.Location = new Point(12, 36);
            View.Name = "View";
            View.Size = new Size(1198, 715);
            View.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(957, -27);
            labelName.Name = "labelName";
            labelName.Size = new Size(224, 26);
            labelName.TabIndex = 4;
            labelName.Text = "Chào mừng User name";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, logoutToolStripMenuItem, supportAndContactToolStripMenuItem, notificationAndSystemToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(50, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(257, 26);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(257, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // supportAndContactToolStripMenuItem
            // 
            supportAndContactToolStripMenuItem.Name = "supportAndContactToolStripMenuItem";
            supportAndContactToolStripMenuItem.Size = new Size(257, 26);
            supportAndContactToolStripMenuItem.Text = "Support and Contact";
            supportAndContactToolStripMenuItem.Click += supportAndContactToolStripMenuItem_Click;
            // 
            // notificationAndSystemToolStripMenuItem
            // 
            notificationAndSystemToolStripMenuItem.Name = "notificationAndSystemToolStripMenuItem";
            notificationAndSystemToolStripMenuItem.Size = new Size(257, 26);
            notificationAndSystemToolStripMenuItem.Text = "Notification and System";
            notificationAndSystemToolStripMenuItem.Click += notificationAndSystemToolStripMenuItem_Click;
            // 
            // MenuHome
            // 
            MenuHome.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MenuHome.Name = "MenuHome";
            MenuHome.Size = new Size(65, 24);
            MenuHome.Text = "Home";
            MenuHome.Click += homeToolStripMenuItem_Click;
            // 
            // bookManagementToolStripMenuItem
            // 
            bookManagementToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            bookManagementToolStripMenuItem.Name = "bookManagementToolStripMenuItem";
            bookManagementToolStripMenuItem.Size = new Size(151, 24);
            bookManagementToolStripMenuItem.Text = "Book Management";
            bookManagementToolStripMenuItem.Click += bookManagementToolStripMenuItem_Click;
            // 
            // memberManagementToolStripMenuItem
            // 
            memberManagementToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            memberManagementToolStripMenuItem.Name = "memberManagementToolStripMenuItem";
            memberManagementToolStripMenuItem.Size = new Size(172, 24);
            memberManagementToolStripMenuItem.Text = "Member Management";
            memberManagementToolStripMenuItem.Click += memberManagementToolStripMenuItem_Click;
            // 
            // borrowReturnManagementToolStripMenuItem
            // 
            borrowReturnManagementToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            borrowReturnManagementToolStripMenuItem.Name = "borrowReturnManagementToolStripMenuItem";
            borrowReturnManagementToolStripMenuItem.Size = new Size(217, 24);
            borrowReturnManagementToolStripMenuItem.Text = "Borrow/Return Management";
            borrowReturnManagementToolStripMenuItem.Click += borrowReturnManagementToolStripMenuItem_Click;
            // 
            // statisticsAndReportsToolStripMenuItem
            // 
            statisticsAndReportsToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            statisticsAndReportsToolStripMenuItem.Name = "statisticsAndReportsToolStripMenuItem";
            statisticsAndReportsToolStripMenuItem.Size = new Size(171, 24);
            statisticsAndReportsToolStripMenuItem.Text = "Statistics and Reports";
            statisticsAndReportsToolStripMenuItem.Click += statisticsAndReportsToolStripMenuItem_Click;
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, MenuHome, bookManagementToolStripMenuItem, memberManagementToolStripMenuItem, borrowReturnManagementToolStripMenuItem, statisticsAndReportsToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1222, 28);
            menu.TabIndex = 3;
            menu.Text = "menuStrip1";
            // 
            // ViewHomeLibrary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 763);
            Controls.Add(View);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "ViewHomeLibrary";
            Text = "Library";
            View.ResumeLayout(false);
            View.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel View;
        private Label labelName;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem supportAndContactToolStripMenuItem;
        private ToolStripMenuItem notificationAndSystemToolStripMenuItem;
        private ToolStripMenuItem MenuHome;
        private ToolStripMenuItem bookManagementToolStripMenuItem;
        private ToolStripMenuItem memberManagementToolStripMenuItem;
        private ToolStripMenuItem borrowReturnManagementToolStripMenuItem;
        private ToolStripMenuItem statisticsAndReportsToolStripMenuItem;
        private MenuStrip menu;
    }
}