using WareHouse.Domain.Entity;

namespace WareHouse.Application.Services
{
    public class AccountService 
    {
        GenericRepository<Users> _repo = new GenericRepository<Users>();
        public Users Login(string identifier, string password)
        {
            if (string.IsNullOrEmpty(identifier) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Giriş bilgileri ve şifre alanı boş bırakılamaz.");
            }

            try
            {
                string sql = @"SELECT U.*, R.RoleName 
                       FROM Users U 
                       INNER JOIN Role R ON U.RoleId = R.RoleId 
                       WHERE U.UserMail = @Id OR U.UserFullName = @Id";
            

         
                Users user = _repo.GetById(sql, new { Id = identifier });

                if (user == null)
                {
                    return null; 
                }

          
                bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, user.UserPassword);

                return isPasswordValid ? user : null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LOGIN HATA] {ex.Message}");
                return null;
            }
        }
        private string HashPassword(string password)
        {           
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12); 
        }
        public bool AddUser(Users users)
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
                string sql = "INSERT INTO Users (UserFullName,UserMail,UserPhone,UserPassword,RoleId)VALUES (@UserFullName,@UserMail,@UserPhone,@UserPassword,1);";
                int result = _repo.Execute(sql,users);
                return result > 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"[SERVICE HATA] Kullanıcı oluşturma sırasında bir hata oluştu: {ex.Message}");
                return false;
            }
        }
        public string  SendMail(string mail)
        {
            return "After cooding...";        
        }      
        public int Update(Users user)
        {
            
            if (string.IsNullOrWhiteSpace(user.UserPhone) || string.IsNullOrWhiteSpace(user.UserFullName))
            {
                throw new ArgumentException("Lütfen bütün bilgilerinizi eksiksiz doldurun.");
            }

           
            if (!user.UserMail.Contains("@gmail.com") && !user.UserMail.Contains("@hotmail.com"))
            {
                throw new ArgumentException("Lütfen geçerli bir mail adresi giriniz (@gmail.com veya @hotmail.com)");
            }
            user.UserPhone = PhoneFormatter(user.UserPhone);
            if (!user.UserPhone.StartsWith("("))
            {
                throw new ArgumentException("Telefon numarası geçersiz. Lütfen 10 hane olarak giriniz.");
            }
            try
            {             
                string sql = @"UPDATE Users 
                       SET UserFullName = @UserFullName, 
                           UserMail = @UserMail, 
                           UserPhone = @UserPhone, 
                           UserPassword = @UserPassword,
                           RoleId = @RoleId
                       WHERE UserId = @UserId";           
                int rows = _repo.Execute(sql, user);

                if (rows == 0)
                {
                    Console.WriteLine("Güncellenecek kullanıcı bulunamadı.");
                    return 0;
                }

                return user.UserId;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SERVICE HATA] Kullanıcı güncelleme hatası: {ex.Message}");
                return 0;
            }
        }
        private string PhoneFormatter(string phone)
        {
            // İçindeki tüm boşluk, parantez ve tireleri temizle, sadece rakamlar kalsın
            string digits = new string(phone.Where(char.IsDigit).ToArray());

            // Eğer tam 10 hane ise (başında 0 olmadan) formatla
            if (digits.Length == 10)
            {
                return string.Format("({0}) {1}-{2}",
                    digits.Substring(0, 3),
                    digits.Substring(3, 3),
                    digits.Substring(6));
            }
            // Eğer başında 0 ile 11 hane yazdıysa (0532...) ilk sıfırı atıp formatla
            else if (digits.Length == 11 && digits.StartsWith("0"))
            {
                return string.Format("({0}) {1}-{2}",
                    digits.Substring(1, 3),
                    digits.Substring(4, 3),
                    digits.Substring(7));
            }

            return phone; 
        }
        public int Delete(Users user)
        {
            try
            {
             
                string sql = "DELETE FROM Users WHERE UserId = @UserId";            
                int rows = _repo.Execute(sql, user);

                if (rows == 0)
                {
                    Console.WriteLine("Silinecek kullanıcı bulunamadı.");
                    return 0;
                }
                return user.UserId;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SERVICE HATA] Kullanıcı silme hatası: {ex.Message}");
                return 0;
            }
        }
        public List<Users> GetUser(Users user)
        {
           
            string searchTerm = user?.UserFullName ?? "";

         
            string sql = @"SELECT 
                    U.UserId, 
                    U.UserFullName, 
                    U.UserMail, 
                    U.UserPhone, 
                    R.RoleName 
                   FROM Users U 
                   INNER JOIN Role R ON U.RoleId = R.RoleId 
                   WHERE U.UserFullName LIKE @SearchName";

         
            var result = _repo.GetAll<Users>(sql, new { SearchName = "%" + searchTerm + "%" });

            return result;
        }
        public List<Users> GetAllUsers()
        {

            string sql = @"SELECT U.*, R.RoleName 
               FROM Users U 
               INNER JOIN Role R ON U.RoleId = R.RoleId";
            var rawData = _repo.GetAll<dynamic>(sql);
            return _repo.GetAll<Users>(sql);

        }
    }
}
