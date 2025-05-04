namespace loginWinform
{
    partial class loginForm
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
            login = new Label();
            username = new Label();
            password = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            buttonlogin = new Button();
            SuspendLayout();
            // 
            // login
            // 
            login.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.Location = new Point(262, 20);
            login.Name = "login";
            login.Size = new Size(265, 57);
            login.TabIndex = 0;
            login.Text = "LOGIN FORM";
            login.TextAlign = ContentAlignment.TopCenter;
            login.Click += label1_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.ForeColor = SystemColors.ButtonHighlight;
            username.Location = new Point(117, 99);
            username.Name = "username";
            username.Size = new Size(96, 25);
            username.TabIndex = 1;
            username.Text = "Email : ";
            username.Click += label1_Click_1;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.ForeColor = SystemColors.ButtonHighlight;
            password.Location = new Point(117, 172);
            password.Name = "password";
            password.Size = new Size(147, 25);
            password.TabIndex = 2;
            password.Text = "PassWord : ";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(280, 102);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(290, 27);
            textUsername.TabIndex = 3;
            textUsername.TextChanged += textUsername_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(280, 174);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(290, 27);
            textPassword.TabIndex = 4;
            // 
            // buttonlogin
            // 
            buttonlogin.BackColor = SystemColors.ActiveCaptionText;
            buttonlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonlogin.ForeColor = SystemColors.ButtonHighlight;
            buttonlogin.Location = new Point(347, 257);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(119, 45);
            buttonlogin.TabIndex = 5;
            buttonlogin.Text = "Login";
            buttonlogin.UseVisualStyleBackColor = false;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonlogin);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(login);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login;
        private Label username;
        private Label password;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button buttonlogin;
    }
}
