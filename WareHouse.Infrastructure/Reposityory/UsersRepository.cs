using Microsoft.Data.SqlClient;
using System.Data;
using WareHouse.Domain.Entity;
using WareHouse.Infrastructure.Context;

namespace WareHouse.Infrastructure.Reposityory
{
    public class UsersRepository
    {
        public Users GetMail(string mail)
        {
            string query = "Select UserMail Forms Users Where UserMail = @mail";
            try
            {
                using (SqlConnection connection = AppDbContext.GetConnection())
                using (SqlCommand command =new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mail", mail);
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Users
                            {

                                UserId = (int)reader["UserId"],
                                RoleId = (int)reader["RoleId"],
                                UserFullName = reader["UserFullName"] as string ?? string.Empty,
                                UserMail = reader["UserMail"] as string ?? string.Empty,
                          

                            };
                        }
                    }
                    
                }
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Veri getirme hatası (Mail: {mail}): {ex.Message}");
                return null;
            }
        }
        public List<Users> GetUser(string name)
        {
            List<Users> userList = new List<Users>();

           
            string query = @"
        SELECT
            U.UserId, U.UserFullName, U.UserMail, U.UserPhone, U.RoleId, 
            R.RoleName
        FROM Users U
        INNER JOIN Role R ON U.RoleId = R.RoleId  
        WHERE (@name IS NULL OR @name = '' OR U.UserFullName = @name)"; 

            try
            {
                using (SqlConnection connection = AppDbContext.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@name", (object)name ?? DBNull.Value); 

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                       
                        while (reader.Read()) 
                        {
                            Users user = new Users
                            {
                                UserId = (int)reader["UserId"],
                                RoleId = (int)reader["RoleId"],
                                UserFullName = reader["UserFullName"] as string ?? string.Empty,
                                UserMail = reader["UserMail"] as string ?? string.Empty,
                                UserPhone = reader["UserPhone"] as string ?? string.Empty,

                            

                                Role = new Role
                                {
                                    RoleId = (int)reader["RoleId"],
                                    RoleName = reader["RoleName"] as string ?? string.Empty
                                }
                            };

                            userList.Add(user); 
                        }
                    }
                }
                return userList; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Veri getirme hatası (Name: {name}): {ex.Message}");
                return new List<Users>(); 
            }
        }
        public Users GetUsersId(int userId)
        {
            string query = "SELECT UserId, UserFullName, UserMail, UserPhone, UserPassword, RoleId FROM Users WHERE UserId = @UserId";
            try
            {
               
                using (SqlConnection connection = AppDbContext.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@UserId", userId);


                    connection.Open();

            
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                       
                        if (reader.Read())
                        {
                            return new Users
                            {

                                UserId = (int)reader["UserId"],
                                RoleId = (int)reader["RoleId"],
                                UserFullName = reader["UserFullName"] as string ?? string.Empty,
                                UserMail = reader["UserMail"] as string ?? string.Empty,
                                UserPhone = reader["UserPhone"] as string ?? string.Empty,
                                UserPassword = reader["UserPassword"] as string ?? string.Empty,

                            };
                        }
                    }
                
                    return null;
                }
            }
            catch (Exception ex)
            {               
                Console.WriteLine($"Veri getirme hatası (ID: {userId}): {ex.Message}");
                return null;
            }
        }
        public int GetAllUserCount()
        {
            string query = "SELECT COUNT(*) FROM Users";

            try
            {
                using (SqlConnection connection = AppDbContext.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                 
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                      
                        return Convert.ToInt32(result);
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Kullanıcı sayısı getirme hatası: {ex.Message}");
             
                return 0;
            }
        }

        public int AddUser(Users newUser)
        {
            
            int newUserId = 0;

           
            string query = @"INSERT INTO Users (UserFullName, UserMail, UserPhone, UserPassword, RoleId) 
                         VALUES (@fullname, @mail, @phone, @password, @roleId); 
                         SELECT SCOPE_IDENTITY();";

            try
            {
                
                using (var connection = AppDbContext.GetConnection())
                using (var command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.Add("@fullname", SqlDbType.NVarChar, 255).Value = newUser.UserFullName ?? (object)DBNull.Value;
                    command.Parameters.Add("@mail", SqlDbType.NVarChar, 50).Value = newUser.UserMail ?? (object)DBNull.Value;
                    command.Parameters.Add("@phone", SqlDbType.NVarChar, 15).Value = newUser.UserPhone ?? (object)DBNull.Value;
                    command.Parameters.Add("@password", SqlDbType.NVarChar,255).Value = newUser.UserPassword;
                    command.Parameters.Add("@roleId", SqlDbType.Int).Value = newUser.RoleId;                   
                  
                    connection.Open();
                  
                    object result = command.ExecuteScalar();
               
                    if (result != null && result != DBNull.Value)
                    {
                    
                        newUserId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
            
                Console.WriteLine($"[HATA] Kullanıcı eklenirken bir sorun oluştu: {ex.Message}");
              
                return 0;
            }

            return newUserId;
        }
        public int UpdateUser(Users userToUpdate)
        {
           
            string query = @"UPDATE Users SET 
                UserFullName = @fullname, 
                UserMail = @mail, 
                UserPhone = @phone, 
                UserPassword = @password, 
                RoleId = @roleId  WHERE UserId = @userId";

            int rowsAffected = 0;

            try
            {
                using (var connection = AppDbContext.GetConnection())
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@fullname", SqlDbType.NVarChar, 100).Value = userToUpdate.UserFullName ?? (object)DBNull.Value;
                    command.Parameters.Add("@mail", SqlDbType.NVarChar, 100).Value = userToUpdate.UserMail ?? (object)DBNull.Value;
                    command.Parameters.Add("@phone", SqlDbType.NVarChar, 20).Value = userToUpdate.UserPhone ?? (object)DBNull.Value;                
                    command.Parameters.Add("@password", SqlDbType.NVarChar, 255).Value = userToUpdate.UserPassword;                
                    command.Parameters.Add("@roleId", SqlDbType.Int).Value = userToUpdate.RoleId;
                    command.Parameters.Add("@userId", SqlDbType.Int).Value = userToUpdate.UserId;
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[HATA] Kullanıcı güncellenirken bir sorun oluştu (ID: {userToUpdate.UserId}): {ex.Message}");
         
                return 0;
            }

            return rowsAffected;
        }
        public int DeleteUser(int userId)
        {
            
            string query = "DELETE FROM Users WHERE UserId = @userId";

            int rowsAffected = 0;

            try
            {
                using (var connection = AppDbContext.GetConnection())
                using (var command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;

                    connection.Open();

                
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[HATA] Kullanıcı silinirken bir sorun oluştu (ID: {userId}): {ex.Message}");               
                return 0;
            }

            return rowsAffected;
        }
    }
}
