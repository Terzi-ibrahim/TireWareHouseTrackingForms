namespace WareHouse.Forms.Admin
{
    partial class Profile
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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabProfil = new System.Windows.Forms.TabPage();
            tabControl2 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            txtara = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            lblusercount = new System.Windows.Forms.Label();
            btnnew = new System.Windows.Forms.Button();
            btnara = new MaterialSkin.Controls.MaterialButton();
            tabPage2 = new System.Windows.Forms.TabPage();
            dtgwliste = new System.Windows.Forms.DataGridView();
            tabControl1.SuspendLayout();
            tabProfil.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwliste).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProfil);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1203, 579);
            tabControl1.TabIndex = 0;
            // 
            // tabProfil
            // 
            tabProfil.BackColor = System.Drawing.Color.RosyBrown;
            tabProfil.Controls.Add(tabControl2);
            tabProfil.Controls.Add(dtgwliste);
            tabProfil.Location = new System.Drawing.Point(4, 24);
            tabProfil.Name = "tabProfil";
            tabProfil.Padding = new System.Windows.Forms.Padding(3);
            tabProfil.Size = new System.Drawing.Size(1195, 551);
            tabProfil.TabIndex = 0;
            tabProfil.Text = "Kullanıcı Kontrol";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            tabControl2.Location = new System.Drawing.Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(1189, 235);
            tabControl2.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtara);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lblusercount);
            tabPage1.Controls.Add(btnnew);
            tabPage1.Controls.Add(btnara);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1181, 207);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtara
            // 
            txtara.Location = new System.Drawing.Point(63, 23);
            txtara.Name = "txtara";
            txtara.Size = new System.Drawing.Size(165, 23);
            txtara.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Üye Ara :";
            // 
            // lblusercount
            // 
            lblusercount.AutoSize = true;
            lblusercount.Dock = System.Windows.Forms.DockStyle.Right;
            lblusercount.Location = new System.Drawing.Point(1178, 3);
            lblusercount.Name = "lblusercount";
            lblusercount.Size = new System.Drawing.Size(0, 15);
            lblusercount.TabIndex = 5;
            // 
            // btnnew
            // 
            btnnew.Location = new System.Drawing.Point(6, 167);
            btnnew.Name = "btnnew";
            btnnew.Size = new System.Drawing.Size(128, 34);
            btnnew.TabIndex = 4;
            btnnew.Text = "Yeni Üye Kaydı";
            btnnew.UseVisualStyleBackColor = true;
            btnnew.Click += btnnew_Click;
            // 
            // btnara
            // 
            btnara.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnara.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnara.Depth = 0;
            btnara.HighEmphasis = true;
            btnara.Icon = null;
            btnara.Location = new System.Drawing.Point(235, 23);
            btnara.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnara.MouseState = MaterialSkin.MouseState.HOVER;
            btnara.Name = "btnara";
            btnara.NoAccentTextColor = System.Drawing.Color.Empty;
            btnara.Size = new System.Drawing.Size(122, 36);
            btnara.TabIndex = 2;
            btnara.Text = "Kullanıc Ara";
            btnara.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnara.UseAccentColor = false;
            btnara.UseVisualStyleBackColor = true;
            btnara.Click += btnara_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1181, 207);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgwliste
            // 
            dtgwliste.AllowUserToAddRows = false;
            dtgwliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwliste.Dock = System.Windows.Forms.DockStyle.Bottom;
            dtgwliste.Location = new System.Drawing.Point(3, 244);
            dtgwliste.Name = "dtgwliste";
            dtgwliste.ReadOnly = true;
            dtgwliste.Size = new System.Drawing.Size(1189, 304);
            dtgwliste.TabIndex = 0;
            // 
            // Profile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1203, 579);
            Controls.Add(tabControl1);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            tabControl1.ResumeLayout(false);
            tabProfil.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwliste).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProfil;
        private System.Windows.Forms.DataGridView dtgwliste;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblusercount;
        private System.Windows.Forms.Button btnnew;
        private MaterialSkin.Controls.MaterialButton btnara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtara;
    }
}