namespace GUI
{
    partial class Home
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
            panelTitle = new Panel();
            panelstatisticsBorrow = new Panel();
            lbReturn = new Label();
            label15 = new Label();
            lbBorrow = new Label();
            label13 = new Label();
            panelBorrow = new Panel();
            label4 = new Label();
            panelstatisticsBook = new Panel();
            label12 = new Label();
            lbTotalBook = new Label();
            label10 = new Label();
            lbCountBook = new Label();
            label6 = new Label();
            label3 = new Label();
            panelUserTotal = new Panel();
            panelstatisticsUser = new Panel();
            panelUser = new Panel();
            label9 = new Label();
            lbTotalUserRole = new Label();
            label7 = new Label();
            lbTotalUser = new Label();
            label5 = new Label();
            label2 = new Label();
            title = new Label();
            userTitle = new Label();
            lbTime = new Label();
            label1 = new Label();
            btnPrint = new Button();
            panelTitle.SuspendLayout();
            panelstatisticsBorrow.SuspendLayout();
            panelstatisticsBook.SuspendLayout();
            panelstatisticsUser.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(panelstatisticsBorrow);
            panelTitle.Controls.Add(panelstatisticsBook);
            panelTitle.Controls.Add(panelstatisticsUser);
            panelTitle.Location = new Point(12, 107);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1167, 225);
            panelTitle.TabIndex = 0;
            // 
            // panelstatisticsBorrow
            // 
            panelstatisticsBorrow.Controls.Add(lbReturn);
            panelstatisticsBorrow.Controls.Add(label15);
            panelstatisticsBorrow.Controls.Add(lbBorrow);
            panelstatisticsBorrow.Controls.Add(label13);
            panelstatisticsBorrow.Controls.Add(panelBorrow);
            panelstatisticsBorrow.Controls.Add(label4);
            panelstatisticsBorrow.Location = new Point(784, 12);
            panelstatisticsBorrow.Name = "panelstatisticsBorrow";
            panelstatisticsBorrow.Size = new Size(370, 198);
            panelstatisticsBorrow.TabIndex = 2;
            // 
            // lbReturn
            // 
            lbReturn.AutoSize = true;
            lbReturn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbReturn.Location = new Point(334, 157);
            lbReturn.Name = "lbReturn";
            lbReturn.Size = new Size(18, 20);
            lbReturn.TabIndex = 6;
            lbReturn.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(174, 157);
            label15.Name = "label15";
            label15.Size = new Size(154, 20);
            label15.TabIndex = 5;
            label15.Text = "Total Return Book";
            // 
            // lbBorrow
            // 
            lbBorrow.AutoSize = true;
            lbBorrow.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbBorrow.Location = new Point(162, 38);
            lbBorrow.Name = "lbBorrow";
            lbBorrow.Size = new Size(18, 20);
            lbBorrow.TabIndex = 4;
            lbBorrow.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(43, 38);
            label13.Name = "label13";
            label13.Size = new Size(111, 20);
            label13.TabIndex = 3;
            label13.Text = "Total Borrow";
            // 
            // panelBorrow
            // 
            panelBorrow.Location = new Point(174, 131);
            panelBorrow.Name = "panelBorrow";
            panelBorrow.Size = new Size(180, 1);
            panelBorrow.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, -3);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 0;
            label4.Text = "Borrow / Return";
            // 
            // panelstatisticsBook
            // 
            panelstatisticsBook.Controls.Add(label12);
            panelstatisticsBook.Controls.Add(lbTotalBook);
            panelstatisticsBook.Controls.Add(label10);
            panelstatisticsBook.Controls.Add(lbCountBook);
            panelstatisticsBook.Controls.Add(label6);
            panelstatisticsBook.Controls.Add(label3);
            panelstatisticsBook.Controls.Add(panelUserTotal);
            panelstatisticsBook.Location = new Point(399, 12);
            panelstatisticsBook.Name = "panelstatisticsBook";
            panelstatisticsBook.Size = new Size(370, 198);
            panelstatisticsBook.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Tomato;
            label12.Location = new Point(224, 38);
            label12.Name = "label12";
            label12.Size = new Size(134, 19);
            label12.TabIndex = 6;
            label12.Text = "Remaining book ";
            // 
            // lbTotalBook
            // 
            lbTotalBook.AutoSize = true;
            lbTotalBook.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalBook.Location = new Point(241, 157);
            lbTotalBook.Name = "lbTotalBook";
            lbTotalBook.Size = new Size(18, 20);
            lbTotalBook.TabIndex = 5;
            lbTotalBook.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(176, 157);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 4;
            label10.Text = "Total";
            // 
            // lbCountBook
            // 
            lbCountBook.AutoSize = true;
            lbCountBook.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCountBook.Location = new Point(149, 38);
            lbCountBook.Name = "lbCountBook";
            lbCountBook.Size = new Size(18, 20);
            lbCountBook.TabIndex = 3;
            lbCountBook.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(41, 38);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 2;
            label6.Text = "Total Book";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, -3);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 0;
            label3.Text = "Books";
            // 
            // panelUserTotal
            // 
            panelUserTotal.Location = new Point(176, 131);
            panelUserTotal.Name = "panelUserTotal";
            panelUserTotal.Size = new Size(180, 1);
            panelUserTotal.TabIndex = 1;
            // 
            // panelstatisticsUser
            // 
            panelstatisticsUser.Controls.Add(panelUser);
            panelstatisticsUser.Controls.Add(label9);
            panelstatisticsUser.Controls.Add(lbTotalUserRole);
            panelstatisticsUser.Controls.Add(label7);
            panelstatisticsUser.Controls.Add(lbTotalUser);
            panelstatisticsUser.Controls.Add(label5);
            panelstatisticsUser.Controls.Add(label2);
            panelstatisticsUser.Location = new Point(13, 12);
            panelstatisticsUser.Name = "panelstatisticsUser";
            panelstatisticsUser.Size = new Size(370, 198);
            panelstatisticsUser.TabIndex = 0;
            // 
            // panelUser
            // 
            panelUser.Location = new Point(171, 131);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(180, 1);
            panelUser.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Tomato;
            label9.Location = new Point(261, 35);
            label9.Name = "label9";
            label9.Size = new Size(90, 23);
            label9.TabIndex = 6;
            label9.Text = "Licensing";
            // 
            // lbTotalUserRole
            // 
            lbTotalUserRole.AutoSize = true;
            lbTotalUserRole.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalUserRole.Location = new Point(179, 34);
            lbTotalUserRole.Name = "lbTotalUserRole";
            lbTotalUserRole.Size = new Size(20, 23);
            lbTotalUserRole.TabIndex = 5;
            lbTotalUserRole.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(40, 35);
            label7.Name = "label7";
            label7.Size = new Size(129, 23);
            label7.TabIndex = 4;
            label7.Text = "Total Member";
            // 
            // lbTotalUser
            // 
            lbTotalUser.AutoSize = true;
            lbTotalUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalUser.Location = new Point(313, 154);
            lbTotalUser.Name = "lbTotalUser";
            lbTotalUser.Size = new Size(20, 23);
            lbTotalUser.TabIndex = 3;
            lbTotalUser.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(173, 154);
            label5.Name = "label5";
            label5.Size = new Size(134, 23);
            label5.TabIndex = 2;
            label5.Text = "Total members";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, -3);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 0;
            label2.Text = "Users";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(224, 32);
            title.TabIndex = 1;
            title.Text = "Library Manager";
            // 
            // userTitle
            // 
            userTitle.AutoSize = true;
            userTitle.Dock = DockStyle.Right;
            userTitle.Location = new Point(1102, 0);
            userTitle.Name = "userTitle";
            userTitle.Size = new Size(89, 20);
            userTitle.TabIndex = 2;
            userTitle.Text = "Welcome to";
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Dock = DockStyle.Left;
            lbTime.Location = new Point(0, 0);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(63, 20);
            lbTime.TabIndex = 3;
            lbTime.Text = "00:00:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 96);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "Statistics";
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.Location = new Point(1030, 650);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(149, 41);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print excel file";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 703);
            Controls.Add(btnPrint);
            Controls.Add(label1);
            Controls.Add(lbTime);
            Controls.Add(userTitle);
            Controls.Add(title);
            Controls.Add(panelTitle);
            Name = "Home";
            Text = "Home";
            panelTitle.ResumeLayout(false);
            panelstatisticsBorrow.ResumeLayout(false);
            panelstatisticsBorrow.PerformLayout();
            panelstatisticsBook.ResumeLayout(false);
            panelstatisticsBook.PerformLayout();
            panelstatisticsUser.ResumeLayout(false);
            panelstatisticsUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitle;
        private Label title;
        private Panel panelstatisticsBorrow;
        private Panel panelstatisticsBook;
        private Panel panelstatisticsUser;
        private Label userTitle;
        private Label lbTime;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnPrint;
        private Label label9;
        private Label lbTotalUserRole;
        private Label label7;
        private Label lbTotalUser;
        private Label label5;
        private Panel panelUserTotal;
        private Panel panelBorrow;
        private Panel panelUser;
        private Label lbTotalBook;
        private Label label10;
        private Label lbCountBook;
        private Label label6;
        private Label label12;
        private Label lbReturn;
        private Label label15;
        private Label lbBorrow;
        private Label label13;
    }
}