using WareHouse.Application.DTOs;
using WareHouse.Domain.Entity;

namespace WareHouse.Application.Services
{
    public class StockService
    {
        GenericRepository<Stock> _repo = new GenericRepository<Stock>();
        public List<StockDTO> GetAll()
        {
            string sql = @"SELECT 
    ST.StockId, 
    ST.Dot, 
    ST.Amount, 
    T.TireId, 
    T.CategoryId, C.CategoryName,
    T.TiresizeId, TS.TireSizeName,
    T.ModelId, M.ModelName,
    T.SeasonId, SN.SeasonName,
    M.BrandId, B.BrandName,
    L.LocationId, L.LocationName,
    W.WarehouseName, W.WarehouseId
FROM Stock ST
INNER JOIN Tire T ON ST.TireId = T.TireId
INNER JOIN Category C ON T.CategoryId = C.CategoryId
INNER JOIN TireSize TS ON T.TiresizeId = TS.TireSizeId
INNER JOIN Model M ON T.ModelId = M.ModelId
INNER JOIN Brand B ON M.BrandId = B.BrandId
INNER JOIN Season SN ON T.SeasonId = SN.SeasonId
INNER JOIN Location L ON ST.LocationId = L.LocationId
INNER JOIN Warehouse W ON L.WarehouseId = W.WarehouseId";

            return _repo.GetAll<StockDTO>(sql);
        }
        public bool GetAdd(StockDTO model)
        {
            try
            {
                string sql = "INSERT INTO Stock (TireId,LocationId,Amount,Dot)VALUES (@TireId,@LocationId,@Amount,@Dot);";
                int result = _repo.Execute(sql, model);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lütfen Tüm alanları doldurunuz{ex.Message}.");
                return false;
            }
        }
        public List<StockDTO> GetSearch(StockDTO model)
        {

            try
            {
                string sql = @"SELECT ST.StockId,     ST.Dot,     ST.Amount,     T.TireId,     T.CategoryId, C.CategoryName,    T.TiresizeId, TS.TireSizeName,    T.ModelId, M.ModelName,
                 T.SeasonId, SN.SeasonName,    M.BrandId, B.BrandName,    L.LocationId, L.LocationName,    W.WarehouseName FROM Stock ST INNER JOIN Tire T ON ST.TireId = T.TireId
                 INNER JOIN Category C ON T.CategoryId = C.CategoryId
                 INNER JOIN TireSize TS ON T.TiresizeId = TS.TireSizeId
                 INNER JOIN Model M ON T.ModelId = M.ModelId
                 INNER JOIN Brand B ON M.BrandId = B.BrandId
                 INNER JOIN Season SN ON T.SeasonId = SN.SeasonId
                 INNER JOIN Location L ON ST.LocationId = L.LocationId
                 INNER JOIN Warehouse W ON L.WarehouseId = W.WarehouseId 
                 WHERE REPLACE(TS.TireSizeName, '-', '') LIKE @SearchName
                 OR B.BrandName LIKE @SearchName
                 OR M.ModelName LIKE @SearchName";

                var result = _repo.GetAll<StockDTO>(sql, new { SearchName = "%" + model.TireSizeName + "%" });
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
        public int Update(StockDTO item)
        {
            try
            {
                string sql = "Update Stock Set TireId =@TireId ,LocationId=@LocationId , Amount=@Amount , Dot=@Dot WHERE StockId= @StockId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.StockId;

            }
            catch (Exception ex) { throw new Exception($"Hata :{ex.Message}"); }

        }
        public int Delete(StockDTO item)
        {
            try
            {
                string sql = "Delete From Stock Where StockId =@StockId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.StockId;
            }
            catch (Exception ex) { throw new Exception($"Hata :{ex.Message}"); }
        }

    }
}
