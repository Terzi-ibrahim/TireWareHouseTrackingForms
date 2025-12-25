namespace WareHouse.Forms
{
    partial class Location
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
            txtsearch = new System.Windows.Forms.TextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnsearch = new MaterialSkin.Controls.MaterialButton();
            dtgwList = new System.Windows.Forms.DataGridView();
            tabControl1 = new System.Windows.Forms.TabControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtsearch);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(btnsearch);
            panel1.Controls.Add(dtgwList);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1362, 141);
            panel1.TabIndex = 0;
            // 
            // txtsearch
            // 
            txtsearch.Location = new System.Drawing.Point(144, 52);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new System.Drawing.Size(105, 23);
            txtsearch.TabIndex = 3;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(3, 52);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(135, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Lastik Konum Ara :";
            // 
            // btnsearch
            // 
            btnsearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnsearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnsearch.Depth = 0;
            btnsearch.HighEmphasis = true;
            btnsearch.Icon = null;
            btnsearch.Location = new System.Drawing.Point(256, 44);
            btnsearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnsearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnsearch.Name = "btnsearch";
            btnsearch.NoAccentTextColor = System.Drawing.Color.Empty;
            btnsearch.Size = new System.Drawing.Size(158, 36);
            btnsearch.TabIndex = 1;
            btnsearch.Text = "Lastik Konum Ara";
            btnsearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnsearch.UseAccentColor = false;
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // dtgwList
            // 
            dtgwList.AllowUserToAddRows = false;
            dtgwList.AllowUserToDeleteRows = false;
            dtgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwList.Dock = System.Windows.Forms.DockStyle.Right;
            dtgwList.Location = new System.Drawing.Point(434, 0);
            dtgwList.Name = "dtgwList";
            dtgwList.ReadOnly = true;
            dtgwList.Size = new System.Drawing.Size(928, 141);
            dtgwList.TabIndex = 0;    
            dtgwList.CellDoubleClick += dtgwList_CellDoubleClick;
            // 
            // tabControl1
            // 
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 141);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1362, 547);
            tabControl1.TabIndex = 1;
            // 
            // Location
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1362, 688);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Location";
            Text = "Location";
            Load += Location_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnsearch;
        private System.Windows.Forms.DataGridView dtgwList;
        private System.Windows.Forms.TabControl tabControl1;
    }
}