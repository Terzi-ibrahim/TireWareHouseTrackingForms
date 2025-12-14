namespace WareHouse.Forms.Account
{
    partial class NewAccount
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
            msktxtPhone = new System.Windows.Forms.MaskedTextBox();
            btnBack = new System.Windows.Forms.Button();
            lbleror = new System.Windows.Forms.Label();
            btnNewAccount = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtMail = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.doors;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(msktxtPhone);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lbleror);
            panel1.Controls.Add(btnNewAccount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtMail);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(522, 502);
            panel1.TabIndex = 0;
            // 
            // msktxtPhone
            // 
            msktxtPhone.Location = new System.Drawing.Point(233, 227);
            msktxtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            msktxtPhone.Mask = "(999) 000-0000";
            msktxtPhone.Name = "msktxtPhone";
            msktxtPhone.Size = new System.Drawing.Size(205, 23);
            msktxtPhone.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.Crimson;
            btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            btnBack.Location = new System.Drawing.Point(29, 35);
            btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(98, 30);
            btnBack.TabIndex = 5;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lbleror
            // 
            lbleror.AutoSize = true;
            lbleror.BackColor = System.Drawing.Color.Transparent;
            lbleror.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            lbleror.ForeColor = System.Drawing.Color.Red;
            lbleror.Location = new System.Drawing.Point(92, 399);
            lbleror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbleror.Name = "lbleror";
            lbleror.Size = new System.Drawing.Size(318, 19);
            lbleror.TabIndex = 10;
            lbleror.Text = "Lütfen Bütün Bilgileri Eksiksiz Doldurunuz...";
            // 
            // btnNewAccount
            // 
            btnNewAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            btnNewAccount.Location = new System.Drawing.Point(120, 324);
            btnNewAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new System.Drawing.Size(285, 55);
            btnNewAccount.TabIndex = 4;
            btnNewAccount.Text = "Yeni Hesap Oluşturun";
            btnNewAccount.UseVisualStyleBackColor = true;
            btnNewAccount.Click += btnNewAccount_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            label4.Location = new System.Drawing.Point(111, 279);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 19);
            label4.TabIndex = 8;
            label4.Text = "Şifreniz :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            label3.Location = new System.Drawing.Point(59, 226);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(138, 19);
            label3.TabIndex = 7;
            label3.Text = "Telefon Numarası :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            label2.Location = new System.Drawing.Point(115, 174);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 19);
            label2.TabIndex = 6;
            label2.Text = "E-Posta :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            label1.Location = new System.Drawing.Point(106, 125);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 19);
            label1.TabIndex = 5;
            label1.Text = "Ad Soyad :";
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(233, 120);
            txtFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(205, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(233, 276);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(205, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtMail
            // 
            txtMail.Location = new System.Drawing.Point(233, 166);
            txtMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMail.Name = "txtMail";
            txtMail.Size = new System.Drawing.Size(205, 23);
            txtMail.TabIndex = 1;
            // 
            // NewAccount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SpringGreen;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(522, 502);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "NewAccount";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Yeni Hesap Oluşturun";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lbleror;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MaskedTextBox msktxtPhone;
    }
}