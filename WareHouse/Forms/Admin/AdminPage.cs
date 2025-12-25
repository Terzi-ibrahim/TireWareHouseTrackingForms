using System;
using System.Windows.Forms;
using WareHouse.Forms.Account;
using WareHouse.Forms.Admin;

namespace WareHouse.Forms
{
    public partial class AdminPage : Form
    {
        private Form currentChildForm;
        private Panel leftBorderBtn;

        public AdminPage()
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

        private void btnebat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TireSize());
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile());
        }

        private void btnbrand_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Brands());
        }

        private void btnmodel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Models());
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Categorys());
        }

        private void btnwarehouse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WareHouses());
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btntire_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tires());
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Locations());
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Stocks());
        }

        private void btnseason_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Seasons());
        }
    }
}
