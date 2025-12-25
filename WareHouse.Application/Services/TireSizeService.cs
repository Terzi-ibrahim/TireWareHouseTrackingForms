
using System.Text.RegularExpressions;
using WareHouse.Domain.Entity;

namespace WareHouse.Application.Services
{
    public class TireSizeService
    {
        GenericRepository<TireSize> _repo = new GenericRepository<TireSize>();          

        public List<TireSize> GetTireSize(TireSize size)
        {

            string sql = "SELECT * FROM TireSize WHERE TireSizeName LIKE @SearchName";

            var result = _repo.GetAll<TireSize>(sql, new { SearchName = "%" + size.TireSizeName + "%" });

            return result;
        }
        public int Delete(TireSize size)
        {
            try
            {

                string sql = "DELETE FROM TireSize WHERE TireSizeId = @TireSizeId";
                int rows = _repo.Execute(sql, size);

                if (rows == 0)
                {
                    Console.WriteLine("Silinecek Ebat bulunamadı.");
                    return 0;
                }
                return size.TireSizeId;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SERVICE HATA] ebat silme hatası: {ex.Message}");
                return 0;
            }
        }
        public int Update(TireSize size)
        {

            if (string.IsNullOrWhiteSpace(size.TireSizeName))
            {
                throw new ArgumentException("Lütfen bütün bilgilerinizi eksiksiz doldurun.");
            }
            string pattern = @"^[0-9]{3}-[0-9]{2}-[0-9]{2}$";

            if (!Regex.IsMatch(size.TireSizeName, pattern))
            {
                throw new ArgumentException("Lütfen doğru formatta ebat giriniz (Örn: 205-55-16)");
            }
            try
            {
                string sql = @"UPDATE TireSize 
                       SET TireSizeName = @TireSizeName                        
                       WHERE TireSizeId = @TireSizeId";
                int rows = _repo.Execute(sql, size);

                if (rows == 0)
                {
                    Console.WriteLine("Güncellenecek Ebat bulunamadı.");
                    return 0;
                }

                return size.TireSizeId;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SERVICE HATA] Ebat güncelleme hatası: {ex.Message}");
                return 0;
            }
        }
        public bool Add(TireSize size)
        {
            if (string.IsNullOrEmpty(size.TireSizeName) )
            {
                throw new ArgumentException("Lütfen bütün bilgilerinizi eksiksiz doldurun.");
            }            
            try
            {
                string sql = "INSERT INTO TireSize (TireSizeName)VALUES (@TireSizeName);";
                int result = _repo.Execute(sql, size);
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SERVICE HATA] Ebat oluşturma sırasında bir hata oluştu: {ex.Message}");
                return false;
            }
        }
        public List<TireSize> GetAll()
        {
            string sql = "Select * From TireSize";
            return _repo.GetAll<TireSize>(sql);
            
        }
    }
}
