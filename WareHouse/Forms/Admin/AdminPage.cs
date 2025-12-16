using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
