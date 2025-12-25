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
            panel1 = new System.Windows.Forms.Panel();
            tabControl2 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            txtara = new System.Windows.Forms.TextBox();
            lblusercount = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnnew = new System.Windows.Forms.Button();
            btnara = new MaterialSkin.Controls.MaterialButton();
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
            tabProfil.Controls.Add(panel1);
            tabProfil.Controls.Add(tabControl2);
            tabProfil.Controls.Add(dtgwliste);
            tabProfil.Location = new System.Drawing.Point(4, 24);
            tabProfil.Name = "tabProfil";
            tabProfil.Padding = new System.Windows.Forms.Padding(3);
            tabProfil.Size = new System.Drawing.Size(1195, 551);
            tabProfil.TabIndex = 0;
            tabProfil.Text = "Kullanıcı Kontrol";
            // 
            // panel1
            // 
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(3, 97);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1189, 10);
            panel1.TabIndex = 3;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            tabControl2.Location = new System.Drawing.Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(1189, 94);
            tabControl2.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtara);
            tabPage1.Controls.Add(lblusercount);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnnew);
            tabPage1.Controls.Add(btnara);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1181, 66);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtara
            // 
            txtara.Location = new System.Drawing.Point(90, 17);
            txtara.Name = "txtara";
            txtara.Size = new System.Drawing.Size(165, 23);
            txtara.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Üye Ara :";
            // 
            // btnnew
            // 
            btnnew.Location = new System.Drawing.Point(494, 17);
            btnnew.Name = "btnnew";
            btnnew.Size = new System.Drawing.Size(128, 34);
            btnnew.TabIndex = 3;
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
            btnara.Location = new System.Drawing.Point(289, 9);
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
            // dtgwliste
            // 
            dtgwliste.AllowUserToAddRows = false;
            dtgwliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwliste.Dock = System.Windows.Forms.DockStyle.Bottom;
            dtgwliste.Location = new System.Drawing.Point(3, 113);
            dtgwliste.Name = "dtgwliste";
            dtgwliste.Size = new System.Drawing.Size(1189, 435);
            dtgwliste.TabIndex = 0;
            dtgwliste.CellDoubleClick += dtgwliste_CellDoubleClick;
            dtgwliste.CellValueChanged += dtgwliste_CellValueChanged;
            // 
            // Profile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1203, 579);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "Profile";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label lblusercount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnew;
        private MaterialSkin.Controls.MaterialButton btnara;
        private System.Windows.Forms.DataGridView dtgwliste;
    }
}