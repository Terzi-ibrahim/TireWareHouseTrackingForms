namespace WareHouse.Forms.Admin
{
    partial class Brands
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
            txtadd = new System.Windows.Forms.TextBox();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnsearch = new MaterialSkin.Controls.MaterialButton();
            txtsearch = new System.Windows.Forms.TextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            dtgwBrand = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwBrand).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtadd);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(btnsearch);
            panel1.Controls.Add(txtsearch);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1211, 135);
            panel1.TabIndex = 0;
            // 
            // txtadd
            // 
            txtadd.Location = new System.Drawing.Point(550, 67);
            txtadd.Name = "txtadd";
            txtadd.Size = new System.Drawing.Size(117, 23);
            txtadd.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new System.Drawing.Point(736, 56);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            btnAdd.Size = new System.Drawing.Size(110, 36);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Marka Ekle";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
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
            materialLabel2.Size = new System.Drawing.Size(119, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Marka Görüntüle";
            // 
            // btnsearch
            // 
            btnsearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnsearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnsearch.Depth = 0;
            btnsearch.HighEmphasis = true;
            btnsearch.Icon = null;
            btnsearch.Location = new System.Drawing.Point(331, 54);
            btnsearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnsearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnsearch.Name = "btnsearch";
            btnsearch.NoAccentTextColor = System.Drawing.Color.Empty;
            btnsearch.Size = new System.Drawing.Size(104, 36);
            btnsearch.TabIndex = 9;
            btnsearch.Text = "Marka Ara";
            btnsearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnsearch.UseAccentColor = false;
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new System.Drawing.Point(193, 64);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new System.Drawing.Size(117, 23);
            txtsearch.TabIndex = 8;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(101, 64);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(74, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Marka Ara";
            // 
            // dtgwBrand
            // 
            dtgwBrand.AllowUserToAddRows = false;
            dtgwBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwBrand.Dock = System.Windows.Forms.DockStyle.Bottom;
            dtgwBrand.Location = new System.Drawing.Point(0, 141);
            dtgwBrand.Name = "dtgwBrand";
            dtgwBrand.Size = new System.Drawing.Size(1211, 439);
            dtgwBrand.TabIndex = 1;
            dtgwBrand.CellDoubleClick += dtgwBrand_CellDoubleClick;
            dtgwBrand.CellValueChanged += dtgwBrand_CellValueChanged;
            // 
            // Brands
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1211, 580);
            Controls.Add(dtgwBrand);
            Controls.Add(panel1);
            Name = "Brands";
            Text = "Brands";
            Load += Brands_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwBrand).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dtgwBrand;
        private System.Windows.Forms.TextBox txtadd;
    }
}