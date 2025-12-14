using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Forms.Account;

namespace WareHouse.Forms
{
    public partial class HomePage : Form
    {
        private Form currentChildForm;
        private Panel leftBorderBtn;

        public HomePage()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnldesk.Controls.Add(childForm);
            pnldesk.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildFrom.Text = childForm.Text;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            timerclock.Start();
        }
        private void Reset()
        {
            lblTitleChildFrom.Text = "Anasayfa";

        }

        private void timerclock_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToString("HH:mm:ss");
            string tarih = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            lblclock.Text = $"{tarih}  {saat}";
        }

        private void pctrbxdesk_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Stock());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void btntire_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Tire());
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Location());
        }

    }
}
