using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Application.Services;
using WareHouse.Domain.Entity;

namespace WareHouse.Forms.Account
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string identifier = txtMail.Text; 
            string password = txtPassword.Text;


            AccountService accountService = new AccountService();

            try
            {
                
                Users loginUser = accountService.Login(identifier, password);

                if (loginUser != null)
                {
                    lbleror.Text = "Giriş Başarılı. Yönlendiriliyorsunuz...";
                    await Task.Delay(1000);

                    this.Hide();

                 
                    if (loginUser.RoleName == "Admin")
                    {
                        AdminPage admin = new AdminPage();
                        admin.ShowDialog();
                    }
                    else
                    {
                        HomePage home = new HomePage();
                        home.ShowDialog();
                    }

                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı/E-posta veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lnklblNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            this.Hide();
            newAccount.ShowDialog();        
      
        }
        private void lnklblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forget = new ForgetPassword();            
            this.Hide();
            forget.ShowDialog();
        }               
    }
}
