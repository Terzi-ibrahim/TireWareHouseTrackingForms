using WareHouse.Domain.Entity;
using WareHouse.Infrastructure.Reposityory;

namespace WareHouse.Application.Services
{
    public class AccountService 
    {
        private readonly UsersRepository _usersRepository =new UsersRepository();

        public bool Login (string mail,string password)
        {
            if(string.IsNullOrEmpty(mail)|| string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("E-posta ve şifre alanı boş bırakılamaz.");
            }
            if (!mail.Contains("@gmail.com"))
            {
                throw new ArgumentException ("Lütfen Mail bilgilerinizi kontrol ediniz.\n(@gmail.com / @hotmail.com)");               
            }
            Users users = _usersRepository.GetUserByMail(mail);
            if(users == null)
            {
                return false;
            }
            bool ispasswordCorrect = BCrypt.Net.BCrypt.Verify(password, users.UserPassword);
            if (ispasswordCorrect) { return true; }
            else { return false; }
        }

        public bool AddUser(Users users)
        {
            if(string.IsNullOrEmpty(users.UserFullName)|| string.IsNullOrEmpty(users.UserPassword)||
                string.IsNullOrEmpty(users.UserMail) ||string.IsNullOrEmpty(users.UserPhone))
            {
                throw new ArgumentException("Lütfen bütün alanları eksiksiz doldurunuz.");
            }
            Users existingUser = _usersRepository.GetUserByMail(users.UserMail);

            if (existingUser != null)
            {
                throw new InvalidOperationException("Bu e-posta adresi zaten kullanılmaktadır.");
            }
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(users.UserPassword);
            users.UserPassword = passwordHash;
            if (users.RoleId == 0)
            {
                users.RoleId = 1;
            }
            bool isAdded = _usersRepository.AddUser(users);
            return isAdded;
        }
        public void  SendMail(string mail)
        {
            if (string.IsNullOrEmpty(mail)|| !IsValidEmail(mail))
            {
                throw new ArgumentException("Lütfen e posta adresini doldurunuz (@gmail.com)");
            }
            Users user = _usersRepository.GetUserByMail(mail);
            if(user == null)
            {
                throw new InvalidDataException("Bu e-posta adresiyle ilgili sistemde kayıt bulunmuyor.");
            }          
            string mailtoUri = $"mailto:{mail}";
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(mailtoUri)
                {
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {                
                Console.WriteLine($"Mail istemcisini açarken hata oluştu: {ex.Message}");              
                throw new Exception("E-posta istemcisi açılamadı.", ex);
            }         
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }




    }
}
