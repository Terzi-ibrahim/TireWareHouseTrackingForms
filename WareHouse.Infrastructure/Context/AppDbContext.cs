using Microsoft.Data.SqlClient;

namespace WareHouse.Infrastructure.Context
{
    public static class AppDbContext
    {
        private const string ConnectionString = "Data Source=(localdb)\\mssqllocaldb; initial catalog=WareHouseDb; integrated security=true";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
