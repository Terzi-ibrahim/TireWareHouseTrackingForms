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
            Users users = _usersRepository.GetMail(mail);
            if(users == null)
            {
                return false;
            }
            bool ispasswordCorrect = BCrypt.Net.BCrypt.Verify(password, users.UserPassword);
            if (ispasswordCorrect) { return true; }
            else { return false; }
            
        }
        private string HashPassword(string password)
        {           
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12); 
        }

        public int AddUser(Users users)
        {
            if (string.IsNullOrEmpty(users.UserFullName)|| string.IsNullOrEmpty(users.UserPhone))
            {
                throw new ArgumentException("Lütfen bütün bilgilerinizi eksiksiz doldurun.");
            }
            if (!users.UserMail.Contains("@gmail.com"))
            {
                throw new ArgumentException("Lütfen Mail bilgilerinizi kontrol ediniz.\n(@gmail.com / @hotmail.com)");
            }
            string plainPassword = users.UserPassword;
            users.UserPassword = HashPassword(plainPassword);
            try
            {
                int newId = _usersRepository.AddUser(users);
                if (newId==0)
                {
                    Console.WriteLine("Kullanıcı ekleme işlemi veritabanında başarısız oldu.");

                }
                return newId;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"[SERVICE HATA] Kullanıcı oluşturma sırasında bir hata oluştu: {ex.Message}");
                return 0;
            }
        }
        public void  SendMail(string mail)
        {
            if (string.IsNullOrEmpty(mail)|| !IsValidEmail(mail))
            {
                throw new ArgumentException("Lütfen e posta adresini doldurunuz (@gmail.com)");
            }
            Users user = _usersRepository.GetMail(mail);
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
        public int Update(Users user)
        {
            if (string.IsNullOrEmpty(user.UserPhone)|| string.IsNullOrEmpty(user.UserFullName))
            {
                throw new ArgumentException("Lütfen bütün bilgilerinizi eksiksiz doldurun.");
            }
            if (!user.UserMail.Contains("@gmail.com"))
            {
                throw new ArgumentException("Lütfen Mail bilgilerinizi kontrol ediniz.\n(@gmail.com / @hotmail.com)");
            }
            try
            {
                int currentId = _usersRepository.UpdateUser(user);
                if (currentId == 0)
                {
                    Console.WriteLine("Kullanıcı ekleme işlemi veri tabanında başarısız oldu.");
                }
                return currentId;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"[SERVICE HATA] Kullanıcı oluşturma sırasında bir hata oluştu: {ex.Message}");
                return 0;
            }

        }
        public int Delete(int  user)
        {            
            try
            {
                int currentId = _usersRepository.DeleteUser(user);
                if (currentId == 0)
                {
                    Console.WriteLine("Kullanıcı ekleme işlemi veri tabanında başarısız oldu.");
                }
                return currentId;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SERVICE HATA] Kullanıcı oluşturma sırasında bir hata oluştu: {ex.Message}");
                return 0;
            }
        }

        public List<Users> GetUser(string name)
        {
            List<Users> userList = _usersRepository.GetUser(name);       
            return userList;

        }
        public int GetAllUser()
        {
            return _usersRepository.GetAllUserCount();
        }

    }
}
