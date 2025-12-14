namespace WareHouse.Forms.Account
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
            panel1 = new System.Windows.Forms.Panel();
            lbleror = new System.Windows.Forms.Label();
            lnklblNewAccount = new System.Windows.Forms.LinkLabel();
            lnklblForgetPassword = new System.Windows.Forms.LinkLabel();
            label3 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtMail = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.doors;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(lbleror);
            panel1.Controls.Add(lnklblNewAccount);
            panel1.Controls.Add(lnklblForgetPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtMail);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(531, 657);
            panel1.TabIndex = 0;
            // 
            // lbleror
            // 
            lbleror.AutoSize = true;
            lbleror.BackColor = System.Drawing.Color.Transparent;
            lbleror.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            lbleror.ForeColor = System.Drawing.Color.Red;
            lbleror.Location = new System.Drawing.Point(89, 552);
            lbleror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbleror.Name = "lbleror";
            lbleror.Size = new System.Drawing.Size(237, 19);
            lbleror.TabIndex = 8;
            lbleror.Text = "Lütfen bütün bilgileri doldurunuz";
            // 
            // lnklblNewAccount
            // 
            lnklblNewAccount.ActiveLinkColor = System.Drawing.Color.White;
            lnklblNewAccount.AutoSize = true;
            lnklblNewAccount.BackColor = System.Drawing.Color.Transparent;
            lnklblNewAccount.ForeColor = System.Drawing.Color.Black;
            lnklblNewAccount.LinkColor = System.Drawing.Color.Green;
            lnklblNewAccount.Location = new System.Drawing.Point(326, 505);
            lnklblNewAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lnklblNewAccount.Name = "lnklblNewAccount";
            lnklblNewAccount.Size = new System.Drawing.Size(121, 15);
            lnklblNewAccount.TabIndex = 4;
            lnklblNewAccount.TabStop = true;
            lnklblNewAccount.Text = "Yeni Hesap Oluşturun";
            lnklblNewAccount.LinkClicked += lnklblNewAccount_LinkClicked;
            // 
            // lnklblForgetPassword
            // 
            lnklblForgetPassword.ActiveLinkColor = System.Drawing.Color.White;
            lnklblForgetPassword.AutoSize = true;
            lnklblForgetPassword.BackColor = System.Drawing.Color.Transparent;
            lnklblForgetPassword.LinkColor = System.Drawing.Color.Gold;
            lnklblForgetPassword.Location = new System.Drawing.Point(77, 505);
            lnklblForgetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lnklblForgetPassword.Name = "lnklblForgetPassword";
            lnklblForgetPassword.Size = new System.Drawing.Size(104, 15);
            lnklblForgetPassword.TabIndex = 3;
            lnklblForgetPassword.TabStop = true;
            lnklblForgetPassword.Text = "Şifremi Unutttum?";
            lnklblForgetPassword.LinkClicked += lnklblForgetPassword_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            label3.ForeColor = System.Drawing.Color.MediumPurple;
            label3.Location = new System.Drawing.Point(76, 178);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(324, 22);
            label3.TabIndex = 5;
            label3.Text = "Depo Takip Uygulamasına Hoşgeldiniz";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(197, 362);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(167, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtMail
            // 
            txtMail.Location = new System.Drawing.Point(197, 286);
            txtMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMail.Name = "txtMail";
            txtMail.Size = new System.Drawing.Size(167, 23);
            txtMail.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.Transparent;
            btnLogin.ForeColor = System.Drawing.Color.MediumPurple;
            btnLogin.Location = new System.Drawing.Point(197, 421);
            btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(168, 57);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            label2.ForeColor = System.Drawing.Color.MediumPurple;
            label2.Location = new System.Drawing.Point(89, 360);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 21);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            label1.ForeColor = System.Drawing.Color.MediumPurple;
            label1.Location = new System.Drawing.Point(89, 285);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 21);
            label1.TabIndex = 0;
            label1.Text = "E-Posta :";
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(531, 657);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblNewAccount;
        private System.Windows.Forms.LinkLabel lnklblForgetPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbleror;
    }
}