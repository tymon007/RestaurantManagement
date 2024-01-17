using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Net;
using System.Windows.Forms;
using static RestaurantManagement.Models.Zamowienia;
using System.Data;




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
        public List<ZarzadzanieZamowieniami> GetZamowienia()
        {
            List<ZarzadzanieZamowieniami> zamowienia = new List<ZarzadzanieZamowieniami>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Zamowienie_Id, Zamowienie_Cena, Zamowienie_Status, Zamowienie_Data, User_Id, Adres_Id, Miejsce_Numer FROM rm_zamowienie";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ZarzadzanieZamowieniami zamowienie = new ZarzadzanieZamowieniami
                            {
                                IDZamowienia = reader.GetInt32("Zamowienie_Id"),
                                Cena = reader.GetDouble("Zamowienie_Cena"),
                                Status_zamowienia = reader.GetString("Zamowienie_Status"),
                                DataZlozenia = reader.GetDateTime("Zamowienie_Data"),
                                User = reader.GetInt32("User_Id"),
                                Adres = reader.GetString("Adres_Id"),
                                NumerZamowienia = reader.GetInt32("Miejsce_Numer")
                            };
                            zamowienia.Add(zamowienie);
                        } 
                    }
                }
                
                    return zamowienia;
            }
        }

        public DataTable GetDishesData()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT  Zamowienie_Data, Zamowienie_Cena, Miejsce_Numer, A.Adres_Ulica  FROM rm_zamowienie AS Z" +
                    " INNER JOIN rm_adres as A ON A.Adres_Id = Z.Adres_Id" ;
                //"SELECT Zamowienie_Id, Zamowienie_Cena, Zamowienie_Status, Zamowienie_Data, User_Id, Adres_Id, Miejsce_Numer FROM rm_zamowienie";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public int DodajZamowienie(decimal cena, string status, DateTime data, int userId, int adresId, string miejsceNumer)
        {
            int noweZamowienieId = -1;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO rm_zamowienie (Zamowienie_Cena, Zamowienie_Status, Zamowienie_Data, User_Id, Adres_Id, Miejsce_Numer) " +
                               "VALUES (@Cena, @Status, @Data, @UserId, @AdresId, @MiejsceNumer); " +
                               "SELECT LAST_INSERT_ID();";  // Pobierz ostatnio przydzielony identyfikator

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Dodaj parametry do zabezpieczenia przed atakami SQL Injection
                    command.Parameters.AddWithValue("@Cena", cena);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Data", data);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@AdresId", adresId);
                    command.Parameters.AddWithValue("@MiejsceNumer", miejsceNumer);

                    // Wykonaj polecenie i uzyskaj nowy identyfikator zamówienia
                    noweZamowienieId = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return noweZamowienieId;
        }

    }
}
