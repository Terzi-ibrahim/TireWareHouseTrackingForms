namespace WareHouse.Forms.Account
{
    partial class ForgetPassword
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
            label2 = new System.Windows.Forms.Label();
            txtMail = new System.Windows.Forms.TextBox();
            btnSend = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btngeri = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Purple;
            panel1.Controls.Add(btngeri);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMail);
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(363, 202);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(34, 57);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(273, 19);
            label2.TabIndex = 4;
            label2.Text = "Lütfen kayıtlı E-posta adresinizi giriniz";
            // 
            // txtMail
            // 
            txtMail.Location = new System.Drawing.Point(111, 98);
            txtMail.Name = "txtMail";
            txtMail.Size = new System.Drawing.Size(156, 26);
            txtMail.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Location = new System.Drawing.Point(89, 149);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(178, 30);
            btnSend.TabIndex = 2;
            btnSend.Text = "Gönder";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 101);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 19);
            label1.TabIndex = 0;
            label1.Text = "E-Posta :";
            // 
            // btngeri
            // 
            btngeri.Location = new System.Drawing.Point(3, 3);
            btngeri.Name = "btngeri";
            btngeri.Size = new System.Drawing.Size(102, 30);
            btngeri.TabIndex = 5;
            btngeri.Text = "Geri Dön";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(363, 202);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ForgetPassword";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ForgetPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngeri;
    }
}