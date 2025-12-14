namespace WareHouse.Forms
{
    partial class Stock
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
            tabview = new System.Windows.Forms.TabPage();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            mskview = new System.Windows.Forms.MaskedTextBox();
            btnara = new MaterialSkin.Controls.MaterialButton();
            lblview = new MaterialSkin.Controls.MaterialLabel();
            tabadd = new System.Windows.Forms.TabPage();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            tabupdate = new System.Windows.Forms.TabPage();
            tabdelete = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            tabview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tabadd.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabview);
            tabControl1.Controls.Add(tabadd);
            tabControl1.Controls.Add(tabupdate);
            tabControl1.Controls.Add(tabdelete);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1060, 504);
            tabControl1.TabIndex = 0;
            // 
            // tabview
            // 
            tabview.BackColor = System.Drawing.Color.SlateGray;
            tabview.Controls.Add(dataGridView1);
            tabview.Controls.Add(panel1);
            tabview.ForeColor = System.Drawing.Color.Transparent;
            tabview.Location = new System.Drawing.Point(4, 32);
            tabview.Name = "tabview";
            tabview.Padding = new System.Windows.Forms.Padding(3);
            tabview.Size = new System.Drawing.Size(1052, 468);
            tabview.TabIndex = 0;
            tabview.Text = "Stok Sörüntüle";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(1046, 366);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(mskview);
            panel1.Controls.Add(btnara);
            panel1.Controls.Add(lblview);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1046, 96);
            panel1.TabIndex = 0;
            // 
            // mskview
            // 
            mskview.Location = new System.Drawing.Point(292, 33);
            mskview.Mask = "000-00-00";
            mskview.Name = "mskview";
            mskview.Size = new System.Drawing.Size(177, 31);
            mskview.TabIndex = 3;
            // 
            // btnara
            // 
            btnara.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnara.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnara.Depth = 0;
            btnara.HighEmphasis = true;
            btnara.Icon = null;
            btnara.Location = new System.Drawing.Point(500, 29);
            btnara.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnara.MouseState = MaterialSkin.MouseState.HOVER;
            btnara.Name = "btnara";
            btnara.NoAccentTextColor = System.Drawing.Color.Empty;
            btnara.Size = new System.Drawing.Size(64, 36);
            btnara.TabIndex = 2;
            btnara.Text = "Ara";
            btnara.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnara.UseAccentColor = false;
            btnara.UseVisualStyleBackColor = true;
            btnara.Click += btnara_Click_1;
            // 
            // lblview
            // 
            lblview.AutoSize = true;
            lblview.Depth = 0;
            lblview.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            lblview.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblview.Location = new System.Drawing.Point(211, 32);
            lblview.MouseState = MaterialSkin.MouseState.HOVER;
            lblview.Name = "lblview";
            lblview.Size = new System.Drawing.Size(61, 29);
            lblview.TabIndex = 0;
            lblview.Text = "Ebat :";
            // 
            // tabadd
            // 
            tabadd.BackColor = System.Drawing.Color.SlateGray;
            tabadd.Controls.Add(materialTextBox2);
            tabadd.Controls.Add(materialTextBox1);
            tabadd.Controls.Add(materialLabel4);
            tabadd.Controls.Add(materialLabel3);
            tabadd.Controls.Add(materialLabel2);
            tabadd.Location = new System.Drawing.Point(4, 32);
            tabadd.Name = "tabadd";
            tabadd.Padding = new System.Windows.Forms.Padding(3);
            tabadd.Size = new System.Drawing.Size(1052, 468);
            tabadd.TabIndex = 1;
            tabadd.Text = "Stok Ekle";
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new System.Drawing.Point(199, 99);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new System.Drawing.Size(225, 50);
            materialTextBox2.TabIndex = 5;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new System.Drawing.Point(199, 23);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new System.Drawing.Size(225, 50);
            materialTextBox1.TabIndex = 4;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel4.Location = new System.Drawing.Point(56, 175);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new System.Drawing.Size(107, 19);
            materialLabel4.TabIndex = 2;
            materialLabel4.Text = "materialLabel4";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel3.Location = new System.Drawing.Point(56, 130);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new System.Drawing.Size(107, 19);
            materialLabel3.TabIndex = 1;
            materialLabel3.Text = "materialLabel3";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel2.Location = new System.Drawing.Point(56, 81);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(107, 19);
            materialLabel2.TabIndex = 0;
            materialLabel2.Text = "materialLabel2";
            // 
            // tabupdate
            // 
            tabupdate.BackColor = System.Drawing.Color.SlateGray;
            tabupdate.Location = new System.Drawing.Point(4, 32);
            tabupdate.Name = "tabupdate";
            tabupdate.Size = new System.Drawing.Size(1052, 468);
            tabupdate.TabIndex = 2;
            tabupdate.Text = "Stok Güncelle";
            // 
            // tabdelete
            // 
            tabdelete.BackColor = System.Drawing.Color.SlateGray;
            tabdelete.Location = new System.Drawing.Point(4, 32);
            tabdelete.Name = "tabdelete";
            tabdelete.Size = new System.Drawing.Size(1052, 468);
            tabdelete.TabIndex = 3;
            tabdelete.Text = "Stok Sil";
            // 
            // Stock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1060, 504);
            Controls.Add(tabControl1);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            tabControl1.ResumeLayout(false);
            tabview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabadd.ResumeLayout(false);
            tabadd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabview;
        private System.Windows.Forms.TabPage tabadd;
        private System.Windows.Forms.TabPage tabupdate;
        private System.Windows.Forms.TabPage tabdelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private MaterialSkin.Controls.MaterialLabel lblview;
        private MaterialSkin.Controls.MaterialButton btnara;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.MaskedTextBox mskview;
    }
}