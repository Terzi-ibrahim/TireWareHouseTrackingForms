using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Context
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
