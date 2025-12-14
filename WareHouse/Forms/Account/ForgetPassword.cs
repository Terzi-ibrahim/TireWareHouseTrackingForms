using System;
using System.Windows.Forms;
using WareHouse.Application.Services;

namespace WareHouse.Forms.Account
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string mail;
            mail = txtMail.Text;
            if (!mail.Contains("@gmail.com"))
            {
                MessageBox.Show("Lütfen Mail bilgilerinizi kontrol ediniz.\n(@gmail.com / @hotmail.com)");
                return;
            }
            AccountService account = new AccountService();

            try
            {

                account.SendMail(mail);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Hata : {ex.Message}");

            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
