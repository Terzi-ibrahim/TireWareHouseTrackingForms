using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Application.DTOs;
using WareHouse.Domain.Entity;

namespace WareHouse.Application.Services
{
    public class TireService
    {
        GenericRepository<Tire> _repo = new GenericRepository<Tire>();
        public List<TireDTO> GetAll()
        {
            string sql = @"SELECT   T.TireId,  T.CategoryId,    C.CategoryName,  T.TiresizeId,    S.TireSizeName,  T.ModelId,    M.ModelName,
              M.BrandId,   B.BrandName ,SN.SeasonName FROM Tire T 
              INNER JOIN Category C ON T.CategoryId = C.CategoryId
              INNER JOIN TireSize S ON T.TiresizeId = S.TireSizeId
              INNER JOIN Model M ON T.ModelId = M.ModelId
              INNER JOIN Brand B ON B.BrandId = M.BrandId 
              INNER JOIN Season SN ON T.SeasonId = SN.SeasonId";
            return _repo.GetAll<TireDTO>(sql);
        }       
        public bool GetAdd(TireDTO model)
        {           
            try
            {
                string sql = "INSERT INTO Tire (CategoryId,TireSizeId,ModelId,SeasonId)VALUES (@CategoryId,@TireSizeId,@ModelId,@SeasonId);";
                int result = _repo.Execute(sql, model);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lütfen Tüm alanları doldurunuz{ex.Message}.");
                return false;
            }
        }
        public List<TireDTO> GetSearch(TireDTO model)
        {
            
            try
            {
                string sql = @"SELECT T.*, C.CategoryName, S.TireSizeName, M.ModelName, SN.SeasonName ,B.BrandName FROM Tire T
                 INNER JOIN Category C ON T.CategoryId = C.CategoryId
                 INNER JOIN TireSize S ON T.TiresizeId = S.TireSizeId
                 INNER JOIN Model M ON T.ModelId = M.ModelId
                 INNER JOIN Season SN ON T.SeasonId = SN.SeasonId
                 Inner JOIN Brand B ON M.BrandId = B.BrandId
                 WHERE S.TireSizeName LIKE @SearchName;";


              
                var result = _repo.GetAll<TireDTO>(sql, new { SearchName = "%" + model.TireSizeName + "%" });
                if (result == null || result.Count == 0)
                {
                    throw new Exception("Böyle bir öğe bulunamadı.");
                }

                return result;

            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
        public int Update(TireDTO item)
        {
            try
            {
                string sql = "Update Tire Set CategoryId =@CategoryId ,SeasonId=@SeasonId ,TireSizeId =@TireSizeId,ModelId=@ModelId  WHERE TireId= @TireId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.TireId;

            }
            catch (Exception ex) { throw new Exception($"Hata :{ex.Message}"); }

        }
        public int Delete(TireDTO item)
        {
            try
            {
                string sql = "Delete From Tire Where TireId =@TireId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.TireId;
            }
            catch (Exception ex) { throw new Exception($"Hata :{ex.Message}"); }
        }

    }
}
