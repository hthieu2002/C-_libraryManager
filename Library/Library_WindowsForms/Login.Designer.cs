namespace GUI
{
    partial class Login
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 36);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 0;
            label1.Text = "Login Library";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(96, 131);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(96, 190);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(212, 126);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(380, 30);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(212, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(380, 30);
            txtPassword.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(282, 263);
            button1.Name = "button1";
            button1.Size = new Size(122, 42);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 359);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button button1;
    }
}