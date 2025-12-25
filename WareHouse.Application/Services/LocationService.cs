using WareHouse.Application.DTOs;
using WareHouse.Domain.Entity;

namespace WareHouse.Application.Services
{
    public class LocationService
    {
        GenericRepository<Location> _repo = new GenericRepository<Location>();
        public List <LocationDTO> GetAll()
        {
            string sql = @"SELECT l.LocationId, l.LocationName , w.WareHouseName, w.WareHouseId
               FROM Location l 
               INNER JOIN WareHouse w ON l.WareHouseId =w.WareHouseId ORDER BY w.WareHouseName, l.LocationName";
            return _repo.GetAll<LocationDTO>(sql);
        }
        public bool GetAdd(LocationDTO item)
        {
            if (string.IsNullOrEmpty(item.LocationName))
            {
                throw new Exception("Lütfen Tüm alanları doldurunuz.");
            }
            try
            {
                string sql = "Insert Into Location (LocationName,WareHouseId)values (@LocationName,@WarehouseId)";
                int result = _repo.Execute(sql, item);
                return result > 0;


            }
            catch(Exception ex) { throw new Exception($"Hata: {ex.Message}"); return false; }
        }
        public List<LocationDTO> GetSearch(LocationDTO item)
        {
            try
            {
                string sql = @"SELECT    L.*,    W.WarehouseName FROM Location L INNER JOIN Warehouse W ON L.WarehouseId = W.WarehouseId
                  WHERE L.LocationName LIKE @SearchName";

                var result = _repo.GetAll<LocationDTO>(sql, new { SearchName = "%" + item.LocationName + "%" });
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
        public int Update(LocationDTO item)
        {
            try
            {
                string sql = "Update  Location Set LocationName = @LocationName Where LocationId =@LocationId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.LocationId;
            }
            catch (Exception ex) { throw new Exception($"Hata :{ex.Message}"); }

        }
        public int Delete (LocationDTO item)
        {
            try
            {
                string sql = "Delete From Location Where LocationId =@LocationId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.LocationId;
            }
            catch (Exception ex) { throw new Exception($"Hata :{ex.Message}"); }
        }
    }
}
