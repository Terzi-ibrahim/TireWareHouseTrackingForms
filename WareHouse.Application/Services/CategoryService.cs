using WareHouse.Domain.Entity; 

namespace WareHouse.Application.Services
{
    public class CategoryService
    {
        GenericRepository<Category> _repo = new GenericRepository<Category>();
        public List<Category> GetAll()
        {
            string sql = "Select *From Category";
            return _repo.GetAll<Category>(sql);
        }
        public bool GetAdd(Category model)
        {
            if (string.IsNullOrEmpty(model.CategoryName))
            {
                throw new Exception("Lütfen Tüm alanları doldurunuz.");
            }
            try
            {
                string sql = "INSERT INTO Category (CategoryName)VALUES (@CategoryName);";
                int result = _repo.Execute(sql, model);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lütfen Tüm alanları doldurunuz{ex.Message}.");
                return false;
            }
        }
        public List<Category> GetSearch(Category model)
        {
            try
            {
                string sql = @" Select * From Category WHERE CategoryName LIKE @SearchName";

                var result = _repo.GetAll<Category>(sql, new { SearchName = "%" + model.CategoryName + "%" });
                if (result.Count == 0)
                {
                    throw new Exception("Böyle Bi item bulunamadı.");
                }

                return result;

            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
        public int Update(Category item)
        {
            try
            {
                string sql = "Update Category Set CategoryName =@CategoryName WHERE CategoryId= @CategoryId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.CategoryId;

            }catch(Exception ex) { throw new Exception($"Hata :{ex.Message}"); }

        }
        public int Delete (Category item)
        {
            try
            {
                string sql = "Delete From Category Where CategoryId =@CategoryId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.CategoryId;
            }
            catch (Exception ex) { throw new Exception($"Hata :{ex.Message}"); }
        }
    }
}
