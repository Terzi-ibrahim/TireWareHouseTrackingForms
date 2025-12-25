using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Domain.Entity;

namespace WareHouse.Application.Services
{
    public class SeasonService
    {
        GenericRepository<Season> _repo = new GenericRepository<Season>();

        public List<Season> GetAll()
        {
            try
            {
                string sql = "Select *from Season";
                return _repo.GetAll<Season>(sql);

            }catch(Exception ex) { throw new Exception($"hata : {ex.Message}"); }
        }
        public List<Season> GetSearch(Season item)
        {
            try
            {
                string sql = @" Select * From Season WHERE SeasonName LIKE @SearchName";

                var result = _repo.GetAll<Season>(sql, new { SearchName = "%" + item.SeasonName + "%" });
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
        public bool Add(Season item)
        {
            if (string.IsNullOrEmpty(item.SeasonName)) { throw new Exception("lütfen iligili alanları doldurun."); }
            try
            {
                string sql = "Insert Into Season (SeasonName) Values (@SeasonName)";
                int result = _repo.Execute(sql, item);
                return result > 0;
            }
            catch (Exception ex )
            {

                throw new Exception($"Hata: {ex.Message}");
            }
        }
        public int Update(Season item)
        {
            if (string.IsNullOrEmpty(item.SeasonName)) { throw new Exception("lütfen iligili alanları doldurun."); }
            try
            {
                string sql = "Update Season Set SeasonName =@SeasonName WHERE SeasonId= @SeasonId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.SeasonId;
            }
            catch (Exception ex)
            {

                throw new Exception($"Hata: {ex.Message}");
            }

        }
        public int Delete(Season item)
        {
            
            try
            {
                string sql = "Delete From Season  WHERE SeasonId= @SeasonId";
                int row = _repo.Execute(sql, item);
                if (row == 0) { throw new Exception("Hata Kayıt bulunamadı"); }
                return item.SeasonId;
            }
            catch (Exception ex)
            {

                throw new Exception($"Hata: {ex.Message}");
            }
        }

    }
}
