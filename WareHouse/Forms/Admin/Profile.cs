using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WareHouse.Application.Services;
using WareHouse.Domain.Entity;
using WareHouse.Forms.Account;

namespace WareHouse.Forms.Admin
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        private void GetAll()
        {
            AccountService service = new AccountService();
            try
            {
                List <Users> list = service.GetAllUsers();
                dtgwliste.DataSource = list;
                if (dtgwliste.Columns.Contains("UserPassword"))
                {
                    dtgwliste.Columns["UserPassword"].Visible = false;
                }
                if (dtgwliste.Columns.Contains("Role"))
                {
                    dtgwliste.Columns["Role"].Visible = false;
                }
                if (dtgwliste.Columns.Contains("RoleId"))
                {
                    dtgwliste.Columns["RoleId"].Visible = false;
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            string name = txtara.Text;
            AccountService service = new AccountService();
            try
            {
                Users arananUser = new Users { UserFullName = txtara.Text };
                List<Users> usersList = service.GetUser(arananUser);

                if (usersList != null)
                {

                    dtgwliste.DataSource = usersList;

                    if (dtgwliste.Columns.Contains("UserPassword"))
                    {
                        dtgwliste.Columns["UserPassword"].Visible = false;
                    }
                    if (dtgwliste.Columns.Contains("Role"))
                    {
                        dtgwliste.Columns["Role"].Visible = false;
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
            
            lblusercount.Text = $"Toplam Kullanıcı Sayısı: {service.GetAllUsers().Count}";

            GetAll();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            NewAccount create = new NewAccount();
            create.ShowDialog();
        }

        private void dtgwliste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var user = (Users)dtgwliste.Rows[e.RowIndex].DataBoundItem;

                var onay = MessageBox.Show($"{user.UserFullName} isimli kullanıcıyı silmek istiyor musunuz?",
                                           "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    AccountService service = new AccountService();
                    int silinenId = service.Delete(user);

                    if (silinenId > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi.");

                        btnara_Click(null, null);
                    }
                }
            }
        }

        private void dtgwliste_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgwliste.DataSource != null && e.RowIndex >= 0)
            {
                try
                {
                    var user = (Users)dtgwliste.Rows[e.RowIndex].DataBoundItem;
                    AccountService service = new AccountService();

              
                    service.Update(user);

                    MessageBox.Show("Başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentException ex)
                {
                    
                    MessageBox.Show(ex.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                 
                    btnara_Click(null, null);
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message);
                }
            }
        }
      
    }
}
