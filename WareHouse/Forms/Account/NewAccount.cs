using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Application.Services;
using WareHouse.Domain.Entity;

namespace WareHouse.Forms.Account
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private  async void btnNewAccount_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName.Text;
            string mail = txtMail.Text;
            string Phone = msktxtPhone.Text;
            string password = txtPassword.Text;  
            
            if(string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(password)|| string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(fullname))
            {
                lbleror.Text = "Lütfen tüm alanları doldurunuz.";
                return;
            } 
            if(!mail.Contains("@gmail.com"))
            {
                lbleror.Text = "Lütfen Mail bilgilerinizi kontrol ediniz.\n(@gmail.com / @hotmail.com)";             
                return;
            }
            Users users = new Users
            {
                UserFullName = fullname,
                UserMail = mail,
                UserPhone = Phone,
                UserPassword = password,

            };
            AccountService service = new AccountService();
            try
            {
                if(service.AddUser(users))
                {
                    lbleror.Text = "Kullanıcı kaydı başarılı Login sayfasına yönlendiriliyosunuz...";
                    await Task.Delay(1500);
                    Login login = new Login();
                    this.Hide();
                    login.ShowDialog();
                }
                else{
                    MessageBox.Show("Kayıt oluşturulamadı (Veritabanı hatası).");
                }
            }catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message, "Uyarı");
            }         
        }
    }
}
