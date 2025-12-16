namespace WareHouse.Forms.Admin
{
    partial class TireSize
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
            btnrefresh = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            tabadd = new System.Windows.Forms.TabPage();
            dtgwegs = new System.Windows.Forms.DataGridView();
            panel3 = new System.Windows.Forms.Panel();
            txtdelete = new System.Windows.Forms.TextBox();
            btndelete = new MaterialSkin.Controls.MaterialButton();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            mskupdate = new System.Windows.Forms.MaskedTextBox();
            txtupdate = new System.Windows.Forms.TextBox();
            btnupdate = new MaterialSkin.Controls.MaterialButton();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            mskadd = new System.Windows.Forms.MaskedTextBox();
            btnadd = new MaterialSkin.Controls.MaterialButton();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwegs).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabview);
            tabControl1.Controls.Add(tabadd);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(808, 585);
            tabControl1.TabIndex = 0;
            // 
            // tabview
            // 
            tabview.Controls.Add(btnrefresh);
            tabview.Controls.Add(dataGridView1);
            tabview.Location = new System.Drawing.Point(4, 24);
            tabview.Name = "tabview";
            tabview.Padding = new System.Windows.Forms.Padding(3);
            tabview.Size = new System.Drawing.Size(800, 557);
            tabview.TabIndex = 0;
            tabview.Text = "Ebat Görüntüle";
            tabview.UseVisualStyleBackColor = true;
            // 
            // btnrefresh
            // 
            btnrefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnrefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnrefresh.Depth = 0;
            btnrefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnrefresh.HighEmphasis = true;
            btnrefresh.Icon = null;
            btnrefresh.Location = new System.Drawing.Point(3, 518);
            btnrefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnrefresh.MouseState = MaterialSkin.MouseState.HOVER;
            btnrefresh.Name = "btnrefresh";
            btnrefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            btnrefresh.Size = new System.Drawing.Size(794, 36);
            btnrefresh.TabIndex = 1;
            btnrefresh.Text = "Yenile";
            btnrefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnrefresh.UseAccentColor = false;
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(794, 551);
            dataGridView1.TabIndex = 0;
            // 
            // tabadd
            // 
            tabadd.Controls.Add(dtgwegs);
            tabadd.Controls.Add(panel3);
            tabadd.Controls.Add(panel2);
            tabadd.Controls.Add(panel1);
            tabadd.Location = new System.Drawing.Point(4, 24);
            tabadd.Name = "tabadd";
            tabadd.Padding = new System.Windows.Forms.Padding(3);
            tabadd.Size = new System.Drawing.Size(800, 557);
            tabadd.TabIndex = 1;
            tabadd.Text = "Ebat Ekle/Güncelle/Sil";
            tabadd.UseVisualStyleBackColor = true;
            // 
            // dtgwegs
            // 
            dtgwegs.AllowUserToAddRows = false;
            dtgwegs.AllowUserToDeleteRows = false;
            dtgwegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwegs.Dock = System.Windows.Forms.DockStyle.Fill;
            dtgwegs.Location = new System.Drawing.Point(3, 301);
            dtgwegs.Name = "dtgwegs";
            dtgwegs.ReadOnly = true;
            dtgwegs.Size = new System.Drawing.Size(794, 253);
            dtgwegs.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtdelete);
            panel3.Controls.Add(btndelete);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(3, 193);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(794, 108);
            panel3.TabIndex = 2;
            // 
            // txtdelete
            // 
            txtdelete.Location = new System.Drawing.Point(305, 59);
            txtdelete.Name = "txtdelete";
            txtdelete.Size = new System.Drawing.Size(76, 23);
            txtdelete.TabIndex = 0;
            // 
            // btndelete
            // 
            btndelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btndelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btndelete.Depth = 0;
            btndelete.HighEmphasis = true;
            btndelete.Icon = null;
            btndelete.Location = new System.Drawing.Point(443, 55);
            btndelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btndelete.MouseState = MaterialSkin.MouseState.HOVER;
            btndelete.Name = "btndelete";
            btndelete.NoAccentTextColor = System.Drawing.Color.Empty;
            btndelete.Size = new System.Drawing.Size(64, 36);
            btndelete.TabIndex = 1;
            btndelete.Text = "Sil";
            btndelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btndelete.UseAccentColor = false;
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(232, 62);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Ebat Id :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Ebat Sil";
            // 
            // panel2
            // 
            panel2.Controls.Add(mskupdate);
            panel2.Controls.Add(txtupdate);
            panel2.Controls.Add(btnupdate);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(3, 99);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(794, 94);
            panel2.TabIndex = 1;
            // 
            // mskupdate
            // 
            mskupdate.Location = new System.Drawing.Point(370, 50);
            mskupdate.Mask = "000-00-00";
            mskupdate.Name = "mskupdate";
            mskupdate.Size = new System.Drawing.Size(100, 23);
            mskupdate.TabIndex = 1;
            mskupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtupdate
            // 
            txtupdate.Location = new System.Drawing.Point(156, 43);
            txtupdate.Name = "txtupdate";
            txtupdate.Size = new System.Drawing.Size(65, 23);
            txtupdate.TabIndex = 0;
            // 
            // btnupdate
            // 
            btnupdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnupdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnupdate.Depth = 0;
            btnupdate.HighEmphasis = true;
            btnupdate.Icon = null;
            btnupdate.Location = new System.Drawing.Point(565, 39);
            btnupdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnupdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnupdate.Name = "btnupdate";
            btnupdate.NoAccentTextColor = System.Drawing.Color.Empty;
            btnupdate.Size = new System.Drawing.Size(94, 36);
            btnupdate.TabIndex = 2;
            btnupdate.Text = "Güncelle";
            btnupdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnupdate.UseAccentColor = false;
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(106, 50);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(24, 15);
            label6.TabIndex = 5;
            label6.Text = "ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(272, 50);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "Ebat No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Ebat Güncelle";
            // 
            // panel1
            // 
            panel1.Controls.Add(mskadd);
            panel1.Controls.Add(btnadd);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(794, 96);
            panel1.TabIndex = 0;
            // 
            // mskadd
            // 
            mskadd.Location = new System.Drawing.Point(232, 43);
            mskadd.Mask = "000-00-00";
            mskadd.Name = "mskadd";
            mskadd.Size = new System.Drawing.Size(100, 23);
            mskadd.TabIndex = 1;
            mskadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            mskadd.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnadd
            // 
            btnadd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnadd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnadd.Depth = 0;
            btnadd.HighEmphasis = true;
            btnadd.Icon = null;
            btnadd.Location = new System.Drawing.Point(485, 30);
            btnadd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnadd.MouseState = MaterialSkin.MouseState.HOVER;
            btnadd.Name = "btnadd";
            btnadd.NoAccentTextColor = System.Drawing.Color.Empty;
            btnadd.Size = new System.Drawing.Size(64, 36);
            btnadd.TabIndex = 2;
            btnadd.Text = "Ekle";
            btnadd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnadd.UseAccentColor = false;
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(148, 41);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(36, 15);
            label7.TabIndex = 0;
            label7.Text = "Ebat :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Ebat Ekle";
            // 
            // TireSize
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(808, 585);
            Controls.Add(tabControl1);
            Name = "TireSize";
            Text = "TireSize";
            tabControl1.ResumeLayout(false);
            tabview.ResumeLayout(false);
            tabview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabadd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgwegs).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabview;
        private MaterialSkin.Controls.MaterialButton btnrefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabadd;
        private System.Windows.Forms.DataGridView dtgwegs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btndelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton btnupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton btnadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdelete;
        private System.Windows.Forms.MaskedTextBox mskupdate;
        private System.Windows.Forms.TextBox txtupdate;
        private System.Windows.Forms.MaskedTextBox mskadd;
    }
}