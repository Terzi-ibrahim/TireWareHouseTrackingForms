using Microsoft.Data.SqlClient;
using WareHouse.Domain.Entity;
using WareHouse.Infrastructure.Context;

namespace WareHouse.Infrastructure.Reposityory
{
    public class UsersRepository
    {

        public Users GetUserByMail(string mail)
        {
            Users users = null;
            string query = "SELECT UserId, UserMail, UserPassword FROM Users WHERE UserMail = @mail";
            using (SqlConnection connection = AppDbContext.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@mail", mail);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                              
                                users = new Users
                                {
                                    UserId = (int)reader["UserId"],
                                    UserMail = (string)reader["UserMail"],
                                    UserPassword = (string)reader["UserPassword"]
                                };
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                   
                    throw new Exception($"Kullanıcı verisi çekilirken hata oluştu: {ex.Message}", ex);
                }
            }
            return users;
        }
        public bool  AddUser(Users users)
        {
            string query = "INSERT INTO Users (UserFullName,UserMail,UserPhone,UserPassword,RoleId) " +
                "VALUES (@fullname,@mail,@phone,@password,@roleId)";
            int rowsAffected = 0;
            using(SqlConnection connection = AppDbContext.GetConnection())
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fullname", users.UserFullName);
                        command.Parameters.AddWithValue("@mail", users.UserMail);
                        command.Parameters.AddWithValue("@phone",users.UserPhone);
                        command.Parameters.AddWithValue("@password", users.UserPassword);
                        command.Parameters.AddWithValue("@roleId", users.RoleId);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Kullanıcı eklenirken veritabanı hatası: {ex.Message}", ex);
                }
                return rowsAffected > 0;
            }
        }

       













    }
}
