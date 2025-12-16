using Microsoft.Data.SqlClient;
using System.Data;
using WareHouse.Domain.Entity;
using WareHouse.Infrastructure.Context;

namespace WareHouse.Application.Services
{
    public class TireSizeService
    {
        public DataTable GetTireSizesDataTable()
        {
            DataTable tireSizesTable = new DataTable();
            string query = "SELECT TireSizeId, TireSizeName FROM TireSize";

            using (SqlConnection connection = AppDbContext.GetConnection())
            {
                try
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(tireSizesTable);
                    }
                }
                catch (SqlException ex)
                {

                    throw new Exception($"TireSize verileri çekilirken hata oluştu: {ex.Message}", ex);
                }
            }

            return tireSizesTable;
        }

        public TireSize AddTireSize(string tireSizeName)
        {
          
            TireSize size = new TireSize { TireSizeName = tireSizeName };          
            string query = "INSERT INTO TireSize (TireSizeName) VALUES (@sizeName); SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = AppDbContext.GetConnection())
            {
              
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   
                    command.Parameters.AddWithValue("@sizeName", tireSizeName);

                    try
                    {
                        connection.Open();

                   
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                      
                            size.TireSizeId = (int)result; 
                        }
                    }
                    catch (SqlException ex)
                    {
                        
                        throw new Exception($"Ebat eklerken veritabanı hatası oluştu: {ex.Message}", ex);
                    }
                }
            }

            return size;
        }
        public TireSize UpdateTireSize(int Id,string name)
        {
            TireSize size = new TireSize { TireSizeId= Id, TireSizeName=name};
            string query = "UPDATE TireSize SET TireSizeName = @name WHERE TireSizeId = @Id";
            using (SqlConnection connection = AppDbContext.GetConnection())
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@Id", Id);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                           
                            throw new Exception($"ID {Id} olan ebat bulunamadığı için güncelleme yapılamadı.");
                        }

                      
                        return new TireSize { TireSizeId = Id, TireSizeName = name };

                    }
                    catch(SqlException ex)
                    {
                        throw new Exception($"Ebat güncellenirken veritabanı hatası oluştu: {ex.Message}", ex);
                    }
                
                }
            }
       
         }
        public string DeleteTireSize(int Id)
        {

            string query = "DELETE FROM TireSize WHERE TireSizeId = @Id;";
            using (SqlConnection connection = AppDbContext.GetConnection())
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Id", Id);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {

                            throw new Exception($"ID {Id} olan ebat bulunamadığı için silme işlemi yapılamadı.");
                        }

                        return $"ID {Id} olan ebat başarıyla silindi. Etkilenen satır sayısı: {rowsAffected}";
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception($"Ebat güncellenirken veritabanı hatası oluştu: {ex.Message}", ex);
                    }

                }       

            }
        }




    }
}
