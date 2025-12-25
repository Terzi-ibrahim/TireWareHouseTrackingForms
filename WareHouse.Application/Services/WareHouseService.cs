using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Domain.Entity;

namespace WareHouse.Application.Services
{
    public class WareHouseService
    {
        GenericRepository<WareHouse.Domain.Entity.WareHouse> _repo = new GenericRepository<WareHouse.Domain.Entity.WareHouse>();

        public List<WareHouse.Domain.Entity.WareHouse> GetAll()
        {
            string sql = "Select *From WareHouse";
            return _repo.GetAll< WareHouse.Domain.Entity.WareHouse>(sql);

        }
        public bool Add(WareHouse.Domain.Entity.WareHouse item)
        {
            if (string.IsNullOrEmpty(item.WarehouseName)|| string.IsNullOrEmpty(item.WarehouseAdress))
            {
                throw new Exception("Lütfen Tüm alanları doldurunuz.");
            }
            try
            {
                string sql = "INSERT INTO WareHouse (WarehouseName,WarehouseAdress)VALUES (@WareHouseName,@WarehouseAdress);";
                int result = _repo.Execute(sql, item);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lütfen Tüm alanları doldurunuz{ex.Message}.");
                return false;
            }
        }

        public int Update(WareHouse.Domain.Entity.WareHouse item)
        {
            try
            {
                string sql = "Update WareHouse Set WareHouseName =@WareHouseName , WareHouseAdress = @WareHouseAdress WHERE WareHouseId= @WareHouseId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.WarehouseId;

            }
            catch (Exception ex) { throw new Exception($"Hata :{ex.Message}"); }
        }
        public int Delete(WareHouse.Domain.Entity.WareHouse item)
        {
            try
            {
                string sql = "Delete From WareHouse WHERE WareHouseId= @WareHouseId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.WarehouseId;

            }
            catch (Exception ex) { throw new Exception($"Hata :{ex.Message}"); }
        }
        public List<WareHouse.Domain.Entity.WareHouse> GetSearch(WareHouse.Domain.Entity.WareHouse item)
        {
            try
            {
                string sql = @" Select * From WareHouse WHERE WarehouseName LIKE @SearchName";

                var result = _repo.GetAll<WareHouse.Domain.Entity.WareHouse>(sql, new { SearchName = "%" + item.WarehouseName + "%" });
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

    }
}
