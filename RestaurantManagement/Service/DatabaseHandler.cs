﻿using System;
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
using RestaurantManagement.Models;
using Org.BouncyCastle.Utilities.Net;
using System.Reflection;
using static RestaurantManagement.Models.Raporty;


namespace RestaurantManagement.Service
{
    internal class DatabaseHandler
    {
        private readonly string connectionString;
        User user = FormLogin.loggedInUser;
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

        public User ValidateLogin(string username, string password)
        {
            //string hashedPassword = HashPassword(password);

            User user = null;

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
                        if (reader.Read())
                        {
                            //employeeId = reader.GetInt32("User_Id");
                            user = new User
                            {
                                Login = reader.GetString("User_Login"),
                                Haslo = reader.GetString("User_Hasło"),
                                UserID = reader.GetInt32("User_Id"),
                                Rola = reader.GetString("User_Rola"),
                                Status = reader.GetInt32("Status")
                            };
                        }
                    }
                }

                return user;

            }
        }

        public User GetUserByID(int userID)
        {

            User user = new User();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = $"SELECT * FROM rm_users WHERE User_ID = {userID}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //employeeId = reader.GetInt32("User_Id");
                            user = new User
                            {
                                Login = reader.GetString("User_Login"),
                                Haslo = reader.GetString("User_Hasło"),
                                UserID = reader.GetInt32("User_Id"),
                                Rola = reader.GetString("User_Rola"),
                                Status = reader.GetInt32("Status")
                            };
                        }
                    }
                }

                return user;

            }
        }



        public Image LoadImageFromUrl(string imageUrl)
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

        public async Task<Image> LoadImageFromUrlAsync(string imageUrl)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var data = await httpClient.GetByteArrayAsync(imageUrl);
                    using (var memoryStream = new MemoryStream(data))
                    {
                        return Image.FromStream(memoryStream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
                return null;
            }
        }

        public async Task<List<MenuItem>> GetMenuItemsAsync()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            List<Task<Image>> imageTasks = new List<Task<Image>>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT D.Danie_Id, D.Danie_Nazwa, D.Danie_Opis, D.Danie_Cena, D.Danie_Kategoria, Z.Zdjecie_Link " +
                    "FROM rm_danie AS D " + "INNER JOIN rm_zdjecia AS Z ON D.Danie_Id = Z.Danie_Id";


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var imageUrl = reader.GetString("Zdjecie_Link");
                            var imageTask = LoadImageFromUrlAsync(imageUrl);
                            imageTasks.Add(imageTask);

                            MenuItem menuItem = new MenuItem
                            {
                                id = reader.GetInt32("Danie_Id"),
                                name = reader.GetString("Danie_Nazwa"),
                                description = reader.GetString("Danie_Opis"),
                                price = reader.GetDouble("Danie_Cena"),
                                category = reader.GetString("Danie_Kategoria"),
                            };

                            menuItems.Add(menuItem);
                        }
                    }
                }

                var images = await Task.WhenAll(imageTasks);

                for (int i = 0; i < menuItems.Count; i++)
                {
                    menuItems[i].image = images[i];
                }
            }

            return menuItems;
        }
        public List<ZarzadzanieZamowieniami> GetZamowienia(int realizacja, int forma)
        {
            //realizacja: 1 - 
            
            List<ZarzadzanieZamowieniami> zamowienia = new List<ZarzadzanieZamowieniami>();

            string queryAddOn = string.Empty;
            if (realizacja == 1)
            {
                queryAddOn += " WHERE Zamowienie_Status = 'Przyjęte'";
            }
            else if(realizacja == 2)
            {
                queryAddOn += " WHERE Zamowienie_Status = 'Zrealizowane'";
            }
            if (forma==1)
            {
                if (queryAddOn == string.Empty)
                {
                    queryAddOn += " WHERE Adres_Id is null";
                }
                if (queryAddOn != string.Empty)
                {
                    queryAddOn += " AND Adres_Id is null";
                }
            }
            else if(forma == 2)
            {
                if (queryAddOn == string.Empty)
                {
                    queryAddOn += " WHERE Adres_Id is not null";
                }
                if (queryAddOn != string.Empty)
                {
                    queryAddOn += " AND Adres_Id is not null";
                }
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Zamowienie_Id, Zamowienie_Cena, Zamowienie_Status, Godzina_złożenia_zamówienia, User_Id, Adres_Id, Godzina_zakonczenia_zamowienia " +
                    "FROM rm_zamowienie" + queryAddOn;

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ZarzadzanieZamowieniami zamowienie = new ZarzadzanieZamowieniami
                            {
                                IDZamowienia = reader.GetInt32("Zamowienie_Id"),
                                DataZlozenia = reader.GetDateTime("Godzina_złożenia_zamówienia").Date,
                                GodzinaZlozenia = reader.GetDateTime("Godzina_złożenia_zamówienia").TimeOfDay,
                                Status_zamowienia = reader.GetString("Zamowienie_Status"),
                                Cena = reader.GetDouble("Zamowienie_Cena"),
                                Adres = reader.IsDBNull(reader.GetOrdinal("Adres_Id")) ? (int?)null : reader.GetInt32("Adres_Id"),
                                GodzinaRealizacji = reader.IsDBNull(reader.GetOrdinal("Godzina_zakonczenia_zamowienia")) ? (TimeSpan?)null : reader.GetDateTime("Godzina_zakonczenia_zamowienia").TimeOfDay
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
                    " INNER JOIN rm_adres as A ON A.Adres_Id = Z.Adres_Id";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public int DodajZamowienie(ZarzadzanieZamowieniami order)
        {
            int noweZamowienieId = -1;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO rm_zamowienie (Zamowienie_Cena, Zamowienie_Status, User_Id, Adres_Id) " +
                               "VALUES (@Cena, @Status, @UserId, @AdresId); " +
                               "SELECT LAST_INSERT_ID();";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Dodaj parametry do zabezpieczenia przed atakami SQL Injection
                    command.Parameters.AddWithValue("@Cena", order.Cena);
                    command.Parameters.AddWithValue("@Status", "Przyjęte");
                    command.Parameters.AddWithValue("@UserId", user.UserID);
                    command.Parameters.AddWithValue("@AdresId", order.Adres);


                    // Wykonaj polecenie i uzyskaj nowy identyfikator zamówienia
                    noweZamowienieId = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return noweZamowienieId;
        }

        public Pracownik GetEmployeeById(int userId)
        {
            Pracownik employee = new Pracownik();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = $"SELECT * FROM rm_pracownik WHERE User_Id = {userId}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = GetUserByID(userId);
                            employee = new Pracownik
                            {
                                Id = reader.GetInt32("Pracownik_ID"),
                                Imie = reader.IsDBNull(reader.GetOrdinal("Imie")) ? string.Empty : reader.GetString("Imie"),
                                Nazwisko = reader.IsDBNull(reader.GetOrdinal("Nazwisko")) ? string.Empty : reader.GetString("Nazwisko"),
                                Plec = reader.IsDBNull(reader.GetOrdinal("Plec")) ? string.Empty : reader.GetString("Plec"),
                                Wiek = reader.IsDBNull(reader.GetOrdinal("Wiek")) ? 0 : reader.GetInt32("Wiek"),
                                DataRozpoczeciaPracy = reader.IsDBNull(reader.GetOrdinal("Data_Rozpoczecia_Pracy")) ? DateTime.MinValue : reader.GetDateTime("Data_Rozpoczecia_Pracy"),
                                LinkDoZdjecia = reader.IsDBNull(reader.GetOrdinal("LinkDoZdjecia")) ? string.Empty : reader.GetString("LinkDoZdjecia"),
                                Uzytkownik = user
                            };
                        }
                    }
                }
            }

            return employee;
        }

        public List<Pracownik> GetAllEmployees()
        {
            List<Pracownik> employees = new List<Pracownik>();
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = $"SELECT * FROM rm_pracownik";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pracownik newEmployee = new Pracownik
                            {
                                Id = reader.GetInt32("Pracownik_ID"),
                                Imie = reader.IsDBNull(reader.GetOrdinal("Imie")) ? string.Empty : reader.GetString("Imie"),
                                Nazwisko = reader.IsDBNull(reader.GetOrdinal("Nazwisko")) ? string.Empty : reader.GetString("Nazwisko"),
                                Plec = reader.IsDBNull(reader.GetOrdinal("Plec")) ? string.Empty : reader.GetString("Plec"),
                                Wiek = reader.IsDBNull(reader.GetOrdinal("Wiek")) ? 0 : reader.GetInt32("Wiek"),
                                DataRozpoczeciaPracy = reader.IsDBNull(reader.GetOrdinal("Data_Rozpoczecia_Pracy")) ? DateTime.MinValue : reader.GetDateTime("Data_Rozpoczecia_Pracy"),
                                LinkDoZdjecia = reader.IsDBNull(reader.GetOrdinal("LinkDoZdjecia")) ? string.Empty : reader.GetString("LinkDoZdjecia"),
                                Uzytkownik = GetUserByID(reader.GetInt32("User_Id"))
                            };
                            employees.Add(newEmployee);
                        }
                    }
                }
            }

            return employees;
        }
        public GrafikWpis GetScheduleByDay(DateTime day)
        {
            GrafikWpis schedule = null;
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM rm_grafik WHERE Data = @Day AND User_Id = @UserId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Day", day);
                    command.Parameters.AddWithValue("@UserId", user.UserID);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            schedule = new GrafikWpis
                            {
                                Id = reader.GetInt32("Id_wpisu"),
                                userId = reader.GetInt32("User_Id"),
                                data = reader.GetDateTime("Data"),
                                godzinaOd = reader.GetTimeSpan("Godzina_Od"),
                                godzinaDo = reader.GetTimeSpan("Godzina_Do"),
                                stan = reader.GetString("Stan")
                            };
                        }
                    }
                }
            }
            return schedule;
        }
        public void InsertSchedule(GrafikWpis schedule)
        {
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO rm_grafik (User_Id, Data, Godzina_Od, Godzina_Do, Stan) " +
                               "VALUES (@UserId, @Data, @GodzinaOd, @GodzinaDo, @Stan)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", user.UserID);
                    command.Parameters.AddWithValue("@Data", schedule.data);
                    command.Parameters.AddWithValue("@GodzinaOd", schedule.godzinaOd);
                    command.Parameters.AddWithValue("@GodzinaDo", schedule.godzinaDo);
                    command.Parameters.AddWithValue("@Stan", schedule.stan);
                    command.ExecuteNonQuery();
                }
            }
        }
        public int InsertAddress(string phone, string address)
        {
            int address_Id = -1;
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO rm_adres (Numer_Telefonu, Adres_Dostawy) " +
                               "VALUES (@phone, @address);" +
                               "SELECT LAST_INSERT_ID();";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@address", address);

                    address_Id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return address_Id;
        }
        public void DodajPozycjeZamowienia(ZamowienieElement pozycja)
        {
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO rm_pozycja (Zamowienie_Id, Danie_Id, Ilosc, Cena_jednostki) " +
                               "VALUES (@Zamowienie_Id, @Danie_Id, @Ilosc, @Cena);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Zamowienie_Id", pozycja.zamowienie_id);
                    command.Parameters.AddWithValue("@Danie_Id", pozycja.produkt_id);
                    command.Parameters.AddWithValue("@Ilosc", pozycja.produkt_ilosc);
                    command.Parameters.AddWithValue("@Cena", pozycja.produkt_cena);

                    command.ExecuteNonQuery();
                }
            }
        }
        
        public List<ZamowienieElement> GetZamowienieElements(int orderId)
        {
            List<ZamowienieElement> elements = new List<ZamowienieElement>();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT P.Ilosc, P.Danie_Id, D.Danie_Nazwa, P.Cena_jednostki, P.Zamowienie_Id " +
                         "FROM rm_pozycja AS P " +
                         "INNER JOIN rm_danie AS D ON P.Danie_Id = D.Danie_Id " +
                         "WHERE P.Zamowienie_Id = @OrderId;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ZamowienieElement element = new ZamowienieElement
                            {
                                produkt_ilosc = reader.GetInt32("Ilosc"),
                                produkt_id = reader.GetInt32("Danie_Id"),
                                produkt_nazwa = reader.GetString("Danie_Nazwa"),
                                produkt_cena = reader.GetDouble("Cena_jednostki"),
                                zamowienie_id = reader.GetInt32("Zamowienie_Id")
                            };

                            elements.Add(element);
                        }
                    }
                }
            }

            return elements;
        }
        public Adres GetAddressById(int? addressId)
        {
            Adres address = null;

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM rm_adres WHERE Adres_Id = @AddressId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AddressId", addressId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            address = new Adres
                            {
                                ID = reader.GetInt32("Adres_Id"),
                                adres = reader.GetString("Adres_Dostawy"),
                                telefon = reader.GetString("Numer_Telefonu")
                            };
                        }
                    }
                }
            }

            return address;
        }
        public List<GodzinyPracownikow> PobierzRaportGodzinPracownikow()
        {
            List<GodzinyPracownikow> raport = new List<GodzinyPracownikow>();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT Imie, Nazwisko, User_Rola, Ilosc_Zaplanowanych_Godzin, Ilosc_Godzin_Urlopu, Ilosc_Godzin_Niedostepnych FROM raport_godzin_pracownikow_luty_2024";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var godzinyPracownikow = new GodzinyPracownikow
                            {
                                // Przypisanie wartości z readera do właściwości klasy GodzinyPracownikow
                                imie = reader.GetString("Imie"),
                                nazwisko = reader.GetString("Nazwisko"),
                                rola = reader.GetString("User_Rola"),
                                godzinyDostepny = reader.GetInt32("Ilosc_Zaplanowanych_Godzin"),
                                godzinyUrlop = reader.GetInt32("Ilosc_Godzin_Urlopu"),
                                godzinyNiedostepny = reader.GetInt32("Ilosc_Godzin_Niedostepnych")
                            };

                            raport.Add(godzinyPracownikow);
                        }
                    }
                }
            }

            return raport;
        }
        public void InsertReservation(Rezerwacja reservation)
        {
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO rezerwacje (dataOd, dataDo, OsobaRezerwujaca, stolik) " +
                               "VALUES (@dataOd, @DataDo, @OsobaRezerwujaca, @stolik)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dataOd", reservation.DataOd);
                    command.Parameters.AddWithValue("@DataDo", reservation.DataDo);
                    command.Parameters.AddWithValue("@OsobaRezerwujaca", reservation.OsobaRezerwujaca);
                    command.Parameters.AddWithValue("@stolik", reservation.Stolik);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Rezerwacja> GetRezerwacjaList()
        {
               List<Rezerwacja> rezerwacje = new List<Rezerwacja>();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM rezerwacje";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rezerwacja rezerwacja = new Rezerwacja
                            {
                                Id = reader.GetInt32("IDrezerwacji"),
                                DataOd = reader.GetDateTime("dataOd"),
                                DataDo = reader.GetDateTime("dataDo"),
                                OsobaRezerwujaca = reader.GetString("OsobaRezerwujaca"),
                                Stolik = reader.GetString("stolik")
                            };

                            rezerwacje.Add(rezerwacja);
                        }
                    }
                }
            }

            return rezerwacje;  
        }

        public List<String> GetSeats()
        {
            List < String > seats = new List<String>();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM rm_miejsce";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            seats.Add(reader.GetString("Numer"));
                        }
                    }
                }
            }
            return seats;
        }

        public List<NajpopularniejszeDania> PobierzRankingNajpopularniejszychDan()
        {
            List<NajpopularniejszeDania> ranking = new List<NajpopularniejszeDania>();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT Nazwa_Dania, Ilosc_Sprzedanych_Sztuk, Udzial_Procentowy FROM ranking_najpopularniejszych_dan";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NajpopularniejszeDania danie = new NajpopularniejszeDania
                            {
                                nazwaDania = reader.GetString("Nazwa_Dania"),
                                iloscSztuk = reader.GetInt32("Ilosc_Sprzedanych_Sztuk"),
                                udzialProcentowy = reader.GetDouble("Udzial_Procentowy")
                            };

                            ranking.Add(danie);
                        }
                    }
                }
            }

            return ranking;
        }

        public List<PrzychodMiesieczny> PobierzPrzychodMiesieczny()
        {
            List<PrzychodMiesieczny> przychodMiesieczny = new List<PrzychodMiesieczny>();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT Laczny_przychod, Nazwa_Miesiaca FROM raport_przychodu_na_2024";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PrzychodMiesieczny przychod = new PrzychodMiesieczny
                            {
                                przychod = reader.GetDouble("Laczny_przychod"),
                                miesiac = reader.GetString("Nazwa_Miesiaca"),
                            };

                            przychodMiesieczny.Add(przychod);
                        }
                    }
                }
            }

            return przychodMiesieczny;
        }

        public List<PodzialPrzychodu> PobierzPodzialPrzychodu()
        {
            List<PodzialPrzychodu> podzialPrzychodu = new List<PodzialPrzychodu>();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT Przychod_Na_Miejscu, Udzial_Na_Miejscu, Ilosc_Zamowien_Na_Miejscu, Przychod_Na_Wynos, Udzial_Na_Wynos, Ilosc_Zamowien_Na_Wynos FROM widok_przychodu_luty_2024";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PodzialPrzychodu przychod = new PodzialPrzychodu
                            {
                                przychodNaMiejscu = reader.GetDouble("Przychod_Na_Miejscu"),
                                udzialNaMiejscu = reader.GetDouble("Udzial_Na_Miejscu"),
                                iloscNaMiejscu = reader.GetInt32("Ilosc_Zamowien_Na_Miejscu"),
                                przychodNaWynos = reader.GetDouble("Przychod_Na_Wynos"),
                                udzialNaWynos = reader.GetDouble("Udzial_Na_Wynos"),
                                iloscNaWynos = reader.GetInt32("Ilosc_Zamowien_Na_Wynos")
                            };

                            podzialPrzychodu.Add(przychod);
                        }
                    }
                }
            }

            return podzialPrzychodu;
        }

        public void ZmienRolePracownika(int idPracownika, string nowaRola)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string query = @"UPDATE rm_users AS u
                         JOIN rm_pracownik AS p ON u.User_Id = p.User_Id
                         SET u.User_Rola = @NowaRola 
                         WHERE p.Pracownik_ID = @IdPracownika";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NowaRola", nowaRola);
                    command.Parameters.AddWithValue("@IdPracownika", idPracownika);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void ZmienStatusPracownika(int idPracownika, int nowyStatus)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string query = @"UPDATE rm_users AS u
                         JOIN rm_pracownik AS p ON u.User_Id = p.User_Id
                         SET u.Status = @NowyStatus 
                         WHERE p.Pracownik_ID = @IdPracownika";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NowyStatus", nowyStatus);
                    command.Parameters.AddWithValue("@IdPracownika", idPracownika);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UsunDanePracownika(int idPracownika)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string query = @"UPDATE rm_pracownik 
                         SET Imie = NULL, 
                             Nazwisko = NULL, 
                             Plec = NULL, 
                             Wiek = NULL, 
                             Data_Rozpoczecia_Pracy = NULL, 
                             LinkDoZdjecia = NULL
                         WHERE Pracownik_ID = @IdPracownika";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdPracownika", idPracownika);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void UsunZamowienie(int orderId)
        {

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        
                        string deletePozycjaQuery = "DELETE FROM rm_pozycja WHERE Zamowienie_Id = @OrderId";
                        using (MySqlCommand deletePozycjaCommand = new MySqlCommand(deletePozycjaQuery, connection, transaction))
                        {
                            deletePozycjaCommand.Parameters.AddWithValue("@OrderId", orderId);
                            deletePozycjaCommand.ExecuteNonQuery();
                        }

                        
                        string deleteZamowienieQuery = "DELETE FROM rm_zamowienie WHERE Zamowienie_Id = @OrderId";
                        using (MySqlCommand deleteZamowienieCommand = new MySqlCommand(deleteZamowienieQuery, connection, transaction))
                        {
                            deleteZamowienieCommand.Parameters.AddWithValue("@OrderId", orderId);
                            deleteZamowienieCommand.ExecuteNonQuery();
                        }

                        
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        
                        transaction.Rollback();
                        Console.WriteLine("Wystąpił błąd podczas usuwania zamówienia: " + ex.Message);
                        
                    }
                }
            }
        }
        public void ZrealizujZamowienie(int orderId)
        {
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "UPDATE rm_zamowienie SET Zamowienie_status = 'Zrealizowane', " +
                    "Godzina_zakonczenia_zamowienia = NOW() WHERE Zamowienie_Id = @OrderId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
