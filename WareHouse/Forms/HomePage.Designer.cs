namespace WareHouse.Forms
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            btnlocation = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            btntire = new System.Windows.Forms.Button();
            btnstock = new System.Windows.Forms.Button();
            pctrbxdesk = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            lblTitleChildFrom = new System.Windows.Forms.Label();
            lblclock = new System.Windows.Forms.Label();
            pnldesk = new System.Windows.Forms.Panel();
            timerclock = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctrbxdesk).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SlateGray;
            panel1.Controls.Add(btnlocation);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(btntire);
            panel1.Controls.Add(btnstock);
            panel1.Controls.Add(pctrbxdesk);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(146, 757);
            panel1.TabIndex = 0;
            // 
            // btnlocation
            // 
            btnlocation.Dock = System.Windows.Forms.DockStyle.Top;
            btnlocation.Location = new System.Drawing.Point(0, 204);
            btnlocation.Name = "btnlocation";
            btnlocation.Size = new System.Drawing.Size(146, 60);
            btnlocation.TabIndex = 15;
            btnlocation.Text = "Konum";
            btnlocation.UseVisualStyleBackColor = true;
            btnlocation.Click += btnlocation_Click;
            // 
            // button10
            // 
            button10.Dock = System.Windows.Forms.DockStyle.Bottom;
            button10.Location = new System.Drawing.Point(0, 697);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(146, 60);
            button10.TabIndex = 10;
            button10.Text = "Çıkış";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // btntire
            // 
            btntire.Dock = System.Windows.Forms.DockStyle.Top;
            btntire.Location = new System.Drawing.Point(0, 144);
            btntire.Name = "btntire";
            btntire.Size = new System.Drawing.Size(146, 60);
            btntire.TabIndex = 2;
            btntire.Text = "Lastik";
            btntire.UseVisualStyleBackColor = true;
            btntire.Click += btntire_Click;
            // 
            // btnstock
            // 
            btnstock.Dock = System.Windows.Forms.DockStyle.Top;
            btnstock.Location = new System.Drawing.Point(0, 84);
            btnstock.Name = "btnstock";
            btnstock.Size = new System.Drawing.Size(146, 60);
            btnstock.TabIndex = 1;
            btnstock.Text = "Stok";
            btnstock.UseVisualStyleBackColor = true;
            btnstock.Click += btnstock_Click;
            // 
            // pctrbxdesk
            // 
            pctrbxdesk.Dock = System.Windows.Forms.DockStyle.Top;
            pctrbxdesk.Image = Properties.Resources.tire;
            pctrbxdesk.Location = new System.Drawing.Point(0, 0);
            pctrbxdesk.Name = "pctrbxdesk";
            pctrbxdesk.Size = new System.Drawing.Size(146, 84);
            pctrbxdesk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pctrbxdesk.TabIndex = 0;
            pctrbxdesk.TabStop = false;
            pctrbxdesk.Click += pctrbxdesk_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.LightCyan;
            panel2.Controls.Add(lblTitleChildFrom);
            panel2.Controls.Add(lblclock);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(146, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1378, 30);
            panel2.TabIndex = 1;
            // 
            // lblTitleChildFrom
            // 
            lblTitleChildFrom.AutoSize = true;
            lblTitleChildFrom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            lblTitleChildFrom.Location = new System.Drawing.Point(606, 3);
            lblTitleChildFrom.Name = "lblTitleChildFrom";
            lblTitleChildFrom.Size = new System.Drawing.Size(109, 22);
            lblTitleChildFrom.TabIndex = 2;
            lblTitleChildFrom.Text = "ANASAYFA";
            // 
            // lblclock
            // 
            lblclock.AutoSize = true;
            lblclock.Dock = System.Windows.Forms.DockStyle.Right;
            lblclock.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            lblclock.Location = new System.Drawing.Point(1378, 0);
            lblclock.Name = "lblclock";
            lblclock.Size = new System.Drawing.Size(0, 24);
            lblclock.TabIndex = 1;
            // 
            // pnldesk
            // 
            pnldesk.Dock = System.Windows.Forms.DockStyle.Fill;
            pnldesk.Location = new System.Drawing.Point(146, 30);
            pnldesk.Name = "pnldesk";
            pnldesk.Size = new System.Drawing.Size(1378, 727);
            pnldesk.TabIndex = 2;
            // 
            // timerclock
            // 
            timerclock.Tick += timerclock_Tick;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1524, 757);
            Controls.Add(pnldesk);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctrbxdesk).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctrbxdesk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblclock;
        private System.Windows.Forms.LinkLabel lnklblTitleChildFrom;
        private System.Windows.Forms.Panel pnldesk;
        private System.Windows.Forms.Timer timerclock;
        private System.Windows.Forms.Button btnlocation;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btntire;
        private System.Windows.Forms.Button btnstock;
        private System.Windows.Forms.Label lblTitleChildFrom;
    }
}