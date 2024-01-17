using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Net;
using System.Windows.Forms;




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

        

        private Image LoadImageFromUrl(string imageUrl)
        {
            Image image = null;
            try
            {
                
                WebClient webClient = new WebClient();
                byte[] data = webClient.DownloadData(imageUrl);

                
                using (MemoryStream memoryStream = new MemoryStream(data))
                {
                   
                    image = Image.FromStream(memoryStream);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
            return image;
        }

        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT D.Danie_Id, D.Danie_Nazwa, D.Danie_Opis, D.Danie_Cena, D.Danie_Kategoria, Z.Zdjecie_Link " +
                           "FROM rm_danie AS D " +
                           "INNER JOIN rm_zdjecia AS Z ON D.Danie_Id = Z.Danie_Id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MenuItem menuItem = new MenuItem
                            {
                                id = reader.GetInt32("Danie_Id"),
                                name = reader.GetString("Danie_Nazwa"),
                                description = reader.GetString("Danie_Opis"),
                                price = reader.GetDouble("Danie_Cena"),
                                category = reader.GetString("Danie_Kategoria"),
                                image = LoadImageFromUrl(reader.GetString("Zdjecie_Link"))
                            };

                            menuItems.Add(menuItem);
                        }
                    }
                }
            }

            return menuItems;
        }

    }
}
