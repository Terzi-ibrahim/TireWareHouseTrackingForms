using WareHouse.Application.DTOs;
using WareHouse.Domain.Entity;

namespace WareHouse.Application.Services
{
    public class ModelService
    {
        GenericRepository<Model> _repo = new GenericRepository<Model>();
        public List<ModelDTO> GetAll()
        {
            string sql = @"SELECT M.ModelId, M.ModelName, M.BrandId, B.BrandName 
               FROM Model M 
               INNER JOIN Brand B ON M.BrandId = B.BrandId";
            return _repo.GetAll<ModelDTO>(sql); 
        }
        public bool GetAdd(Model model)
        {
            if (string.IsNullOrEmpty(model.ModelName))
            {
                throw new Exception("Lütfen Tüm alanları doldurunuz.");
            }
            try
            {
                string sql = "INSERT INTO Model (ModelName,BrandId)VALUES (@ModelName,@BrandId);";
                int result = _repo.Execute(sql, model);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lütfen Tüm alanları doldurunuz{ex.Message}.");
                return false;
            }
        }
        public int Update(ModelDTO model)
        {
            if (string.IsNullOrEmpty(model.ModelName))
            {
                throw new Exception("Lütfen tüm alanları doldurunuz.");
            }
            try
            {
                string sql = "Update Model Set ModelName=@ModelName Where ModelId=@ModelId";
                int row = _repo.Execute(sql,model);
                if (row == 0)
                {
                    throw new Exception("güncellencek item bulunamadı.");
                }
                return model.ModelId;

            }catch(Exception ex)
            {
                throw new Exception($"Hata:{ex.Message}");
            }
        }
        public int Delete(ModelDTO model)
        {
            try
            {
                string sql = "Delete  From Model Where ModelId = @ModelId";
                int row = _repo.Execute(sql,model);
                if (row == 0)
                {
                    throw new Exception("Böyle bi item yok");
                }
                return model.ModelId;
            }
            catch(Exception ex)
            {
                throw new Exception($"hata{ex.Message}");
            }
        }
        public List<ModelDTO> GetSearch(ModelDTO model) 
        {
            try
            {
                string sql = @"
            SELECT 
                M.ModelId, 
                M.ModelName, 
                M.BrandId, 
                B.BrandName 
            FROM Model M 
            INNER JOIN Brand B ON M.BrandId = B.BrandId 
            WHERE M.ModelName LIKE @SearchName";

                var result = _repo.GetAll<ModelDTO>(sql, new { SearchName = "%" + model.ModelName + "%" });
                if (result.Count == 0)
                {
                    throw new Exception("Böyle Bi Marka bulunamadı.");
                }

                return result;

            }
            catch(Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
    }
}
