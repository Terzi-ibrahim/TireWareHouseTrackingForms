namespace WareHouse.Forms.Admin
{
    partial class Stocks
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
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            cmbgundepo = new System.Windows.Forms.ComboBox();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            cmbdepo = new System.Windows.Forms.ComboBox();
            nmbupdate = new System.Windows.Forms.NumericUpDown();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            nmbadd = new System.Windows.Forms.NumericUpDown();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            mskdot = new System.Windows.Forms.MaskedTextBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            cmbloc = new System.Windows.Forms.ComboBox();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            cmbtire = new System.Windows.Forms.ComboBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            mskgundot = new System.Windows.Forms.MaskedTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            cmbgunloc = new System.Windows.Forms.ComboBox();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            cmbguntire = new System.Windows.Forms.ComboBox();
            btndelete = new System.Windows.Forms.Button();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            btngun = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            btnsearch = new MaterialSkin.Controls.MaterialButton();
            txtsearch = new System.Windows.Forms.TextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            dtgwList = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmbupdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmbadd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgwList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(materialLabel14);
            panel1.Controls.Add(cmbgundepo);
            panel1.Controls.Add(materialLabel13);
            panel1.Controls.Add(cmbdepo);
            panel1.Controls.Add(nmbupdate);
            panel1.Controls.Add(materialLabel5);
            panel1.Controls.Add(nmbadd);
            panel1.Controls.Add(materialLabel7);
            panel1.Controls.Add(materialLabel8);
            panel1.Controls.Add(mskdot);
            panel1.Controls.Add(materialLabel9);
            panel1.Controls.Add(cmbloc);
            panel1.Controls.Add(materialLabel12);
            panel1.Controls.Add(cmbtire);
            panel1.Controls.Add(materialLabel4);
            panel1.Controls.Add(mskgundot);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(cmbgunloc);
            panel1.Controls.Add(materialLabel11);
            panel1.Controls.Add(cmbguntire);
            panel1.Controls.Add(btndelete);
            panel1.Controls.Add(materialLabel10);
            panel1.Controls.Add(btngun);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnsearch);
            panel1.Controls.Add(txtsearch);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1009, 198);
            panel1.TabIndex = 0;
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel14.Location = new System.Drawing.Point(551, 70);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new System.Drawing.Size(79, 19);
            materialLabel14.TabIndex = 102;
            materialLabel14.Text = "Depo Ekle :";
            // 
            // cmbgundepo
            // 
            cmbgundepo.FormattingEnabled = true;
            cmbgundepo.Location = new System.Drawing.Point(647, 70);
            cmbgundepo.Name = "cmbgundepo";
            cmbgundepo.Size = new System.Drawing.Size(97, 23);
            cmbgundepo.TabIndex = 101;
            cmbgundepo.SelectedIndexChanged += cmbgundepo_SelectedIndexChanged;
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel13.Location = new System.Drawing.Point(22, 76);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new System.Drawing.Size(79, 19);
            materialLabel13.TabIndex = 100;
            materialLabel13.Text = "Depo Ekle :";
            // 
            // cmbdepo
            // 
            cmbdepo.FormattingEnabled = true;
            cmbdepo.Location = new System.Drawing.Point(118, 76);
            cmbdepo.Name = "cmbdepo";
            cmbdepo.Size = new System.Drawing.Size(97, 23);
            cmbdepo.TabIndex = 99;
            cmbdepo.SelectedIndexChanged += cmbdepo_SelectedIndexChanged;
            // 
            // nmbupdate
            // 
            nmbupdate.Location = new System.Drawing.Point(883, 105);
            nmbupdate.Name = "nmbupdate";
            nmbupdate.Size = new System.Drawing.Size(97, 23);
            nmbupdate.TabIndex = 98;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel5.Location = new System.Drawing.Point(787, 107);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new System.Drawing.Size(88, 19);
            materialLabel5.TabIndex = 97;
            materialLabel5.Text = "Stok Sayısı :";
            // 
            // nmbadd
            // 
            nmbadd.Location = new System.Drawing.Point(361, 107);
            nmbadd.Name = "nmbadd";
            nmbadd.Size = new System.Drawing.Size(97, 23);
            nmbadd.TabIndex = 96;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel7.Location = new System.Drawing.Point(265, 113);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new System.Drawing.Size(88, 19);
            materialLabel7.TabIndex = 95;
            materialLabel7.Text = "Stok Sayısı :";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel8.Location = new System.Drawing.Point(19, 111);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new System.Drawing.Size(41, 19);
            materialLabel8.TabIndex = 93;
            materialLabel8.Text = "DOT :";
            // 
            // mskdot
            // 
            mskdot.Location = new System.Drawing.Point(123, 109);
            mskdot.Mask = "00-00";
            mskdot.Name = "mskdot";
            mskdot.Size = new System.Drawing.Size(126, 23);
            mskdot.TabIndex = 92;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel9.Location = new System.Drawing.Point(231, 74);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new System.Drawing.Size(90, 19);
            materialLabel9.TabIndex = 91;
            materialLabel9.Text = "Konum Seç :";
            // 
            // cmbloc
            // 
            cmbloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbloc.FormattingEnabled = true;
            cmbloc.Location = new System.Drawing.Point(335, 72);
            cmbloc.Name = "cmbloc";
            cmbloc.Size = new System.Drawing.Size(126, 23);
            cmbloc.TabIndex = 90;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel12.Location = new System.Drawing.Point(19, 47);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new System.Drawing.Size(82, 19);
            materialLabel12.TabIndex = 89;
            materialLabel12.Text = "Lastik Seç :";
            // 
            // cmbtire
            // 
            cmbtire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbtire.FormattingEnabled = true;
            cmbtire.Location = new System.Drawing.Point(123, 45);
            cmbtire.Name = "cmbtire";
            cmbtire.Size = new System.Drawing.Size(335, 23);
            cmbtire.TabIndex = 88;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel4.Location = new System.Drawing.Point(551, 105);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new System.Drawing.Size(41, 19);
            materialLabel4.TabIndex = 85;
            materialLabel4.Text = "DOT :";
            // 
            // mskgundot
            // 
            mskgundot.Location = new System.Drawing.Point(655, 103);
            mskgundot.Name = "mskgundot";
            mskgundot.Size = new System.Drawing.Size(126, 23);
            mskgundot.TabIndex = 84;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel2.Location = new System.Drawing.Point(745, 70);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(90, 19);
            materialLabel2.TabIndex = 83;
            materialLabel2.Text = "Konum Seç :";
            // 
            // cmbgunloc
            // 
            cmbgunloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbgunloc.FormattingEnabled = true;
            cmbgunloc.Location = new System.Drawing.Point(849, 68);
            cmbgunloc.Name = "cmbgunloc";
            cmbgunloc.Size = new System.Drawing.Size(126, 23);
            cmbgunloc.TabIndex = 82;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel11.Location = new System.Drawing.Point(551, 41);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new System.Drawing.Size(82, 19);
            materialLabel11.TabIndex = 81;
            materialLabel11.Text = "Lastik Seç :";
            // 
            // cmbguntire
            // 
            cmbguntire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbguntire.Enabled = false;
            cmbguntire.FormattingEnabled = true;
            cmbguntire.Location = new System.Drawing.Point(655, 39);
            cmbguntire.Name = "cmbguntire";
            cmbguntire.Size = new System.Drawing.Size(320, 23);
            cmbguntire.TabIndex = 78;
            // 
            // btndelete
            // 
            btndelete.BackColor = System.Drawing.Color.Red;
            btndelete.Enabled = false;
            btndelete.Location = new System.Drawing.Point(926, 153);
            btndelete.Name = "btndelete";
            btndelete.Size = new System.Drawing.Size(80, 40);
            btndelete.TabIndex = 77;
            btndelete.Text = "Lastik Sil";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel10.Location = new System.Drawing.Point(513, 9);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new System.Drawing.Size(98, 19);
            materialLabel10.TabIndex = 73;
            materialLabel10.Text = "Stok Güncelle";
            // 
            // btngun
            // 
            btngun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btngun.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btngun.Depth = 0;
            btngun.Enabled = false;
            btngun.HighEmphasis = true;
            btngun.Icon = null;
            btngun.Location = new System.Drawing.Point(655, 149);
            btngun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btngun.MouseState = MaterialSkin.MouseState.HOVER;
            btngun.Name = "btngun";
            btngun.NoAccentTextColor = System.Drawing.Color.Empty;
            btngun.Size = new System.Drawing.Size(147, 36);
            btngun.TabIndex = 72;
            btngun.Text = "Lastik Güncelle";
            btngun.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btngun.UseAccentColor = false;
            btngun.UseVisualStyleBackColor = true;
            btngun.Click += btngun_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel3.Location = new System.Drawing.Point(3, 11);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new System.Drawing.Size(66, 19);
            materialLabel3.TabIndex = 65;
            materialLabel3.Text = "Stok Ekle";
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new System.Drawing.Point(204, 149);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            btnAdd.Size = new System.Drawing.Size(108, 36);
            btnAdd.TabIndex = 63;
            btnAdd.Text = "Lastik Ekle";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnsearch
            // 
            btnsearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnsearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnsearch.Depth = 0;
            btnsearch.HighEmphasis = true;
            btnsearch.Icon = null;
            btnsearch.Location = new System.Drawing.Point(340, 2);
            btnsearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnsearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnsearch.Name = "btnsearch";
            btnsearch.NoAccentTextColor = System.Drawing.Color.Empty;
            btnsearch.Size = new System.Drawing.Size(91, 36);
            btnsearch.TabIndex = 59;
            btnsearch.Text = "Stok Ara";
            btnsearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnsearch.UseAccentColor = false;
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new System.Drawing.Point(204, 9);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new System.Drawing.Size(117, 23);
            txtsearch.TabIndex = 58;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(127, 9);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(61, 19);
            materialLabel1.TabIndex = 64;
            materialLabel1.Text = "Stok Ara";
            // 
            // dtgwList
            // 
            dtgwList.AllowUserToAddRows = false;
            dtgwList.AllowUserToDeleteRows = false;
            dtgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwList.Dock = System.Windows.Forms.DockStyle.Fill;
            dtgwList.Location = new System.Drawing.Point(0, 198);
            dtgwList.Name = "dtgwList";
            dtgwList.ReadOnly = true;
            dtgwList.Size = new System.Drawing.Size(1009, 341);
            dtgwList.TabIndex = 1;
            dtgwList.CellDoubleClick += dtgwList_CellDoubleClick;
            // 
            // Stocks
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1009, 539);
            Controls.Add(dtgwList);
            Controls.Add(panel1);
            Name = "Stocks";
            Text = "Stocks";
            Load += Stocks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmbupdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmbadd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgwList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgwList;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.ComboBox cmbguntire;
        private System.Windows.Forms.Button btndelete;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialButton btngun;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.MaskedTextBox mskprice;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.MaskedTextBox mskdot;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.ComboBox cmbloc;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.ComboBox cmbtire;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.MaskedTextBox mskgunprice;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.MaskedTextBox mskgundot;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox cmbgunloc;
        private System.Windows.Forms.NumericUpDown nmbadd;
        private System.Windows.Forms.NumericUpDown nmbupdate;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private System.Windows.Forms.ComboBox cmbgundepo;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.ComboBox cmbdepo;
    }
}