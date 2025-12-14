using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Application.Services;

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
            string mail = txtMail.Text;
            string password = txtPassword.Text;         
            if (string.IsNullOrEmpty(mail)|| string.IsNullOrEmpty(password))
            {
                lbleror.Text = "Lütfen mail adresinizi ve şifrenizi giriniz";
                return;
            }
            if (!mail.Contains("@gmail.com"))
            {
                lbleror.Text = "Lütfen Mail bilgilerinizi kontrol ediniz.\n(@gmail.com / @hotmail.com)";
                return;
            }

            AccountService accountService = new AccountService();

            try
            {
                if (accountService.Login(mail, password)) 
                {
                    lbleror.Text = "Giriş Başarılı";
                    await Task.Delay(1500);
                    HomePage home = new HomePage();
                    this.Hide();
                    home.ShowDialog();
                }
                else 
                {
                    
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex) 
             { 
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
