namespace WareHouse.Forms.Admin
{
    partial class Locations
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
            cmbraf = new System.Windows.Forms.ComboBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            cmbaz = new System.Windows.Forms.ComboBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            cmbwarehouse = new System.Windows.Forms.ComboBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnsearch = new MaterialSkin.Controls.MaterialButton();
            txtsearch = new System.Windows.Forms.TextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            dtgwList = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbraf);
            panel1.Controls.Add(materialLabel6);
            panel1.Controls.Add(cmbaz);
            panel1.Controls.Add(materialLabel5);
            panel1.Controls.Add(materialLabel4);
            panel1.Controls.Add(cmbwarehouse);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(btnsearch);
            panel1.Controls.Add(txtsearch);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1009, 152);
            panel1.TabIndex = 0;
            // 
            // cmbraf
            // 
            cmbraf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbraf.FormattingEnabled = true;
            cmbraf.Location = new System.Drawing.Point(754, 66);
            cmbraf.Name = "cmbraf";
            cmbraf.Size = new System.Drawing.Size(133, 23);
            cmbraf.TabIndex = 34;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel6.Location = new System.Drawing.Point(645, 68);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new System.Drawing.Size(103, 19);
            materialLabel6.TabIndex = 33;
            materialLabel6.Text = "01-50 Raf Ekle";
            // 
            // cmbaz
            // 
            cmbaz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbaz.FormattingEnabled = true;
            cmbaz.Location = new System.Drawing.Point(491, 64);
            cmbaz.Name = "cmbaz";
            cmbaz.Size = new System.Drawing.Size(133, 23);
            cmbaz.TabIndex = 32;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel5.Location = new System.Drawing.Point(364, 64);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new System.Drawing.Size(121, 19);
            materialLabel5.TabIndex = 31;
            materialLabel5.Text = "A-Z Konum Ekle: ";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel4.Location = new System.Drawing.Point(381, 99);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new System.Drawing.Size(68, 19);
            materialLabel4.TabIndex = 29;
            materialLabel4.Text = "Depo Seç";
            // 
            // cmbwarehouse
            // 
            cmbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbwarehouse.FormattingEnabled = true;
            cmbwarehouse.Location = new System.Drawing.Point(455, 97);
            cmbwarehouse.Name = "cmbwarehouse";
            cmbwarehouse.Size = new System.Drawing.Size(133, 23);
            cmbwarehouse.TabIndex = 4;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel3.Location = new System.Drawing.Point(352, 9);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new System.Drawing.Size(85, 19);
            materialLabel3.TabIndex = 25;
            materialLabel3.Text = "Konum Ekle";
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new System.Drawing.Point(715, 110);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            btnAdd.Size = new System.Drawing.Size(112, 36);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Konum Ekle";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel2.Location = new System.Drawing.Point(12, 9);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(125, 19);
            materialLabel2.TabIndex = 22;
            materialLabel2.Text = "Konum Görüntüle";
            // 
            // btnsearch
            // 
            btnsearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnsearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnsearch.Depth = 0;
            btnsearch.HighEmphasis = true;
            btnsearch.Icon = null;
            btnsearch.Location = new System.Drawing.Point(225, 50);
            btnsearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnsearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnsearch.Name = "btnsearch";
            btnsearch.NoAccentTextColor = System.Drawing.Color.Empty;
            btnsearch.Size = new System.Drawing.Size(106, 36);
            btnsearch.TabIndex = 1;
            btnsearch.Text = "Konum Ara";
            btnsearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnsearch.UseAccentColor = false;
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new System.Drawing.Point(101, 58);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new System.Drawing.Size(117, 23);
            txtsearch.TabIndex = 0;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(12, 60);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(80, 19);
            materialLabel1.TabIndex = 19;
            materialLabel1.Text = "Konum Ara";
            // 
            // dtgwList
            // 
            dtgwList.AllowUserToAddRows = false;
            dtgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwList.Dock = System.Windows.Forms.DockStyle.Bottom;
            dtgwList.Location = new System.Drawing.Point(0, 158);
            dtgwList.Name = "dtgwList";
            dtgwList.Size = new System.Drawing.Size(1009, 381);
            dtgwList.TabIndex = 1;
            dtgwList.CellClick += dtgwList_CellClick;
            dtgwList.CellValueChanged += dtgwList_CellValueChanged;
            // 
            // Locations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1009, 539);
            Controls.Add(dtgwList);
            Controls.Add(panel1);
            Name = "Locations";
            Text = "Locations";
            Load += Locations_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cmbwarehouse;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dtgwList;
        private System.Windows.Forms.ComboBox cmbaz;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox cmbraf;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}