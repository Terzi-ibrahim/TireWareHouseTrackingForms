using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using WareHouse.Application.DTOs;
using WareHouse.Application.Services;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
namespace WareHouse.Forms
{
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        private void GetAll()
        {
            StockService service = new StockService();
            try
            {
                List<StockDTO> list = service.GetAll();
                dtgwList.DataSource = list;
                if (list != null)
                {
                    dtgwList.DataSource = list;
                    if (dtgwList.Columns.Contains("TireId"))
                    {
                        dtgwList.Columns["TireId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("LocationId"))
                    {
                        dtgwList.Columns["LocationId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("StockId"))
                    {
                        dtgwList.Columns["StockId"].Visible = false;
                    }
                    dtgwList.Columns["Amount"].DisplayIndex = 0;
                    dtgwList.Columns["TireSizeName"].DisplayIndex = 1;
                    dtgwList.Columns["LocationName"].DisplayIndex = 2;
                    dtgwList.Columns["Dot"].DisplayIndex = 3;
                    dtgwList.Columns["CategoryName"].DisplayIndex = 4;
                    dtgwList.Columns["BrandName"].DisplayIndex = 5;
                    dtgwList.Columns["ModelName"].DisplayIndex = 6;

                    dtgwList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {

                    dtgwList.DataSource = null;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text.Trim();
            if (name.Length == 7 && long.TryParse(name, out _))
            {

                name = $"{name.Substring(0, 3)}-{name.Substring(3, 2)}-{name.Substring(5, 2)}";
            }
            StockService service = new StockService();
            try
            {
                StockDTO search = new StockDTO { TireSizeName = txtsearch.Text };
                List<StockDTO> list = service.GetSearch(search);

                if (list != null)
                {

                    dtgwList.DataSource = list;

                    if (dtgwList.Columns.Contains("TireId"))
                    {
                        dtgwList.Columns["TireId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("LocationId"))
                    {
                        dtgwList.Columns["LocationId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("StockId"))
                    {
                        dtgwList.Columns["StockId"].Visible = false;
                    }
                    dtgwList.Columns["Amount"].DisplayIndex = 0;
                    dtgwList.Columns["TireSizeName"].DisplayIndex = 1;
                    dtgwList.Columns["LocationName"].DisplayIndex = 2;
                    dtgwList.Columns["Dot"].DisplayIndex = 3;
                    dtgwList.Columns["CategoryName"].DisplayIndex = 4;
                    dtgwList.Columns["BrandName"].DisplayIndex = 5;
                    dtgwList.Columns["ModelName"].DisplayIndex = 6;


                    dtgwList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {

                    dtgwList.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Location_Load(object sender, EventArgs e)
        {
            GetAll();

            DepoHaritasiniYukle();
      
        }
        string seciliStokID = "";
        private void RafCizim_Paint(object sender, PaintEventArgs e)
        {
            Control pnl = (Control)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            int w = pnl.Width;
            int h = pnl.Height;
            bool isHovered = pnl.ClientRectangle.Contains(pnl.PointToClient(Control.MousePosition));
            bool isActive = pnl.Tag?.ToString() == "Active";
            string locName = pnl.AccessibleDescription ?? "A-01";
            string[] tumUrunler = (pnl.AccessibleName ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            int locNumber = 0;
            int.TryParse(System.Text.RegularExpressions.Regex.Match(locName, @"\d+").Value, out locNumber);
            int aktifKat = (locNumber >= 50) ? 3 : (locNumber > 1 ? 2 : 1);

         
            using (Pen p = new Pen(isHovered ? Color.White : Color.FromArgb(70, 70, 70), 4))
            {
                // Sadece Dış Çerçeve Direkleri
                g.DrawLine(p, 10, 30, 10, h - 10);      // Sol ana direk
                g.DrawLine(p, w - 10, 30, w - 10, h - 10); // Sağ ana direk

                // Yatay Katlar 
                g.DrawLine(p, 10, 65, w - 10, 65);   // Üst Kat Rayı
                g.DrawLine(p, 10, 115, w - 10, 115); // Orta Kat Rayı
                g.DrawLine(p, 10, h - 10, w - 10, h - 10); // Alt Kat Rayı (Zemin)
            }

            // 2. LASTİKLER (Tüm genişliğe yayılan tek sıra)
            for (int kat = 1; kat <= 3; kat++)
            {
                int yPos = (kat == 3) ? 35 : (kat == 2 ? 85 : 135);
                bool isTarget = (isActive && kat == aktifKat);

               
                if (!isHovered || isTarget)
                {
                    
                    for (int i = 0; i < 18; i++)
                    {
                        Rectangle tireRect = new Rectangle(25 + (i * 25), yPos, 18, 28);
                 
                        Color tColor = isTarget ? Color.FromArgb(255, 120, 0) : Color.FromArgb(40, 44, 48);

                        using (LinearGradientBrush lgb = new LinearGradientBrush(tireRect, tColor, Color.Black, 65f))
                            g.FillPath(lgb, GetRoundedRect(tireRect, 5));
                    }
                }
            }

          
            if (isHovered)
            {
               
                Rectangle infoBox = new Rectangle(40, 45, w - 80, 100);
                g.FillPath(new SolidBrush(Color.FromArgb(252, 10, 10, 10)), GetRoundedRect(infoBox, 10));
                g.DrawPath(new Pen(Color.Cyan, 2), GetRoundedRect(infoBox, 10));

                var urunler = (pnl.AccessibleName ?? "").Split(';')
                    .Select(x => x.Split('|'))
                    .OrderByDescending(x => x[0] == seciliStokID)
                    .ToList();

                using (Font fBold = new Font("Consolas", 10f, FontStyle.Bold)) 
                using (Font fAmount = new Font("Consolas", 11f, FontStyle.Bold))
                {
                  
                    int col1 = infoBox.X + 15;          
                    int col2 = infoBox.X + (int)(infoBox.Width * 0.55); 
                    int col3 = infoBox.Right - 15;     

                    for (int i = 0; i < urunler.Count; i++)
                    {
                        if (i >= 4) break;
                        var d = urunler[i];
                        bool isSelected = (d[0] == seciliStokID);

                        int yOffset = infoBox.Y + 12 + (i * 22);
                        Brush color = isSelected ? Brushes.Gold : Brushes.White;

                    
                        string markaEbat = $"{(isSelected ? "➤ " : "• ")}{d[1]} {d[2]}";
                        g.DrawString(markaEbat, fBold, color, col1, yOffset);

                        
                        g.DrawString($"DOT:{d[3]}", fBold, isSelected ? Brushes.Orange : Brushes.Gray, col2, yOffset);

                
                        string miktarText = d[4] + " ADET";
                        SizeF szMiktar = g.MeasureString(miktarText, fAmount);
                        g.DrawString(miktarText, fAmount, isSelected ? Brushes.Chartreuse : Brushes.Aqua, col3 - szMiktar.Width, yOffset);
                    }
                }
            }

      
            Rectangle headerRect = new Rectangle((w - 150) / 2, 2, 150, 25);
            g.FillPath(new SolidBrush(isActive ? Color.OrangeRed : Color.FromArgb(35, 35, 35)), GetRoundedRect(headerRect, 5));

            using (Font f = new Font("Segoe UI", 11, FontStyle.Bold))
            {
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(locName, f, Brushes.White, headerRect, sf);
            }
        }
        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void DepoHaritasiniYukle()
        {
            try
            {
                StockService service = new StockService();
                List<StockDTO> tumVeriler = service.GetAll();

                // Temizlik
                foreach (TabPage page in tabControl1.TabPages) page.Dispose();
                tabControl1.TabPages.Clear();

                // DOĞRU GRUPLAMA: Sadece Depo bazlı
                var depoGruplari = tumVeriler.GroupBy(x => new { x.WarehouseName });

                foreach (var depo in depoGruplari)
                {
                    TabPage tp = new TabPage(depo.Key.WarehouseName);
                    FlowLayoutPanel flp = new FlowLayoutPanel
                    {
                        Dock = DockStyle.Fill,
                        AutoScroll = true,
                        Padding = new Padding(10),
                        BackColor = Color.FromArgb(30, 30, 30)
                    };

                   
                    var konumBazliGrup = depo.GroupBy(x => x.LocationName);

                    foreach (var konumGrubu in konumBazliGrup)
                    {
                        Panel pnlRaf = new Panel();

                     
                        var propertyInfo = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                        propertyInfo.SetValue(pnlRaf, true, null);

                    
                        var ilkKayit = konumGrubu.First();
                        pnlRaf.Name = "btn_" + ilkKayit.LocationId;
                        pnlRaf.AccessibleDescription = konumGrubu.Key; 

                        var detayliListe = konumGrubu.Select(x =>$"{x.StockId}|{x.TireSizeName}|{x.BrandName}|{x.Dot}|{x.Amount}");

                        pnlRaf.AccessibleName = string.Join(";", detayliListe);

                        pnlRaf.AccessibleName = string.Join(";", detayliListe);

                        pnlRaf.Size = new Size(500, 180);
                        pnlRaf.Margin = new Padding(20);
                        pnlRaf.Cursor = Cursors.Hand;

           
                        pnlRaf.Paint += RafCizim_Paint;
                        pnlRaf.MouseEnter += (s, ev) => { pnlRaf.Invalidate(); };
                        pnlRaf.MouseLeave += (s, ev) => { pnlRaf.Invalidate(); };
                        pnlRaf.Click += (s, ev) => { KonumaGit(pnlRaf.Name, ""); };

                        flp.Controls.Add(pnlRaf);
                    }
                    tp.Controls.Add(flp);
                    tabControl1.TabPages.Add(tp);
                }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }
        public void KonumaGit(string arananIsim, string stokID)
        {
            seciliStokID = stokID;
            Control hedefRaf = null;
            TabPage hedefSekme = null;
      
            foreach (TabPage tp in tabControl1.TabPages)
            {
                foreach (Control flp in tp.Controls)
                {
                    foreach (Control raf in flp.Controls)
                    {
                        if (raf.Tag?.ToString() == "Active")
                        {
                            raf.Tag = null;
                            raf.Invalidate(); 
                        }
                    }
                }
            }

         
            foreach (TabPage tp in tabControl1.TabPages)
            {
                var bul = tp.Controls.Find(arananIsim, true).FirstOrDefault();
                if (bul != null) { hedefRaf = bul; hedefSekme = tp; break; }
            }

            if (hedefRaf != null)
            {
                tabControl1.SelectedTab = hedefSekme;
                hedefRaf.Tag = "Active";
                hedefRaf.Invalidate(); 

                if (hedefRaf.Parent is FlowLayoutPanel flp)
                    flp.ScrollControlIntoView(hedefRaf);            
            }
        }



        private void dtgwList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string locationId = dtgwList.Rows[e.RowIndex].Cells["LocationId"].Value.ToString();
                string stockId = dtgwList.Rows[e.RowIndex].Cells["StockId"].Value.ToString();
                KonumaGit("btn_" + locationId, stockId);
            }
        }
    }
}
