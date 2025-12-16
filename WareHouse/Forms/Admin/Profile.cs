using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WareHouse.Application.Services;
using WareHouse.Domain.Entity;
using WareHouse.Forms.Account;
using WareHouse.Infrastructure.Reposityory;

namespace WareHouse.Forms.Admin
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            string name = txtara.Text;
            AccountService service = new AccountService();
            try
            {

                List<Users> usersList = service.GetUser(name);

                if (usersList != null)
                {

                    dtgwliste.DataSource = usersList;

                    if (dtgwliste.Columns.Contains("UserPassword"))
                    {
                        dtgwliste.Columns["UserPassword"].Visible = false;
                    }
                    if (dtgwliste.Columns.Contains("RoleId"))
                    {
                        dtgwliste.Columns["RoleId"].Visible = false;
                    }
                }
                else
                {

                    dtgwliste.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            AccountService service = new AccountService();
            int kullaniciSayisi = service.GetAllUser();
            lblusercount.Text = $"Toplam Kullanıcı Sayısı: {kullaniciSayisi}";


        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            NewAccount create = new NewAccount();
            create.ShowDialog();
        }
    }
}
