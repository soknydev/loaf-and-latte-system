using loaf_and_latte_system.Config;
using loaf_and_latte_system.Factories.LoafAndLatteSystem.Factories;
using MySql.Data.MySqlClient;
using System;

namespace LoafAndLatteSystem.Services
{
    public class LoginService
    {
        public User Login(string username, string password)
        {
            MySqlConnection conn = DatabaseConnection.GetInstance();
            try
            {
                conn.Open();
                string query = "SELECT role FROM Employees WHERE username = @username AND password = @password";
                MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); // You should hash passwords in production!

                var role = cmd.ExecuteScalar()?.ToString();
                if (role != null)
                {
                    User user = UserFactory.CreateUser(role);
                    if (user != null)
                    {
                        user.Username = username;
                        user.SetPermissions();
                        return user;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                // handle or log error
                throw new Exception("Login failed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
