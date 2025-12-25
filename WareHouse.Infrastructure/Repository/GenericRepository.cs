using Dapper;
using Microsoft.Data.SqlClient;
using WareHouse.Infrastructure.Context;

public class GenericRepository<T> where T : class
{
   
    private SqlConnection CreateConnection() => AppDbContext.GetConnection();


    public List<T> GetAll<T>(string sql, object parameters = null)
    {
        using (var conn = CreateConnection())
        {
           
            return conn.Query<T>(sql, parameters).ToList();
        }
    } 
    public int Execute(string sql, object parameters= null)
    {
        using (var conn = CreateConnection())
        {
            return conn.Execute(sql, parameters);
        }
    }
    public T GetById(string sql, object parameters)
    {
        using (var conn = CreateConnection())
        {
            return conn.QueryFirstOrDefault<T>(sql, parameters);
        }
    }
    
}