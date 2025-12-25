using WareHouse.Application.DTOs;
using WareHouse.Domain.Entity;

namespace WareHouse.Application.Services
{
    public class BrandService
    {
        GenericRepository<Brand> _repo = new GenericRepository<Brand>();
        public List<Brand> GetBrandSize(Brand brand)
        {
            string sql = "SELECT * FROM Brand WHERE BrandName LIKE @SearchName";

            var result = _repo.GetAll<Brand>(sql, new { SearchName = "%" + brand.BrandName + "%" });
            if (result.Count==0)
            {
                throw new Exception("Böyle Bi Marka bulunamadı.");
            }

            return result;
        }
        public bool Add(Brand brand)
        {
            if (string.IsNullOrEmpty(brand.BrandName))
            {
                throw new Exception("Lütfen Tüm alanları doldurunuz.");
            }
            try
            {
                string sql = "INSERT INTO Brand (BrandName)VALUES (@BrandName);";
                int result = _repo.Execute(sql, brand);
                return result > 0;
            }
            catch(Exception ex)
            {
                throw new Exception($"Lütfen Tüm alanları doldurunuz{ex.Message}.");
                return false;
            }
        }
        public List<Brand> GetAll()
        {
            string sql = "Select *From Brand";
            return _repo.GetAll<Brand>(sql);
        }
        public int Delete(Brand brand)
        {
            try
            {

                string sql = "DELETE FROM Brand WHERE BrandId = @BrandId";
                int rows = _repo.Execute(sql, brand);

                if (rows == 0)
                {
                    Console.WriteLine("Silinecek marka bulunamadı.");
                    return 0;
                }
                return brand.BrandId;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SERVICE HATA] Marka silme hatası: {ex.Message}");
                return 0;
            }

        }
        public int Update(Brand brand)
        {

            if (string.IsNullOrWhiteSpace(brand.BrandName))
            {
                throw new ArgumentException("Lütfen bütün bilgilerinizi eksiksiz doldurun.");
            }           
            try
            {
                string sql = @"UPDATE Brand 
                       SET BrandName = @BrandName                        
                       WHERE BrandId = @BrandId";
                int rows = _repo.Execute(sql, brand);

                if (rows == 0)
                {
                    Console.WriteLine("Güncellenecek model bulunamadı.");
                    return 0;
                }

                return brand.BrandId;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SERVICE HATA] Model güncelleme hatası: {ex.Message}");
                return 0;
            }
        }
    }
}
