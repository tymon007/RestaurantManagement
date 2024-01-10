using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;




namespace RestaurantManagement
{
    internal class DatabaseHandler
    {
        private readonly string connectionString;

        public DatabaseHandler()
        {
            
            string host = "localhost";
            string database = "rm";
            string username = "root";
            string password = "";

            
            connectionString = $"Server={host};Database={database};User ID={username};Password={password};";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public bool ValidateLogin(string username, string password)
        {
            //string hashedPassword = HashPassword(password);

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM rm_users WHERE User_Login = @Username AND User_Hasło = @PasswordHash";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", password);//hashedPassword);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }
    }
}
