# RestaurantManagement
 A university project. Restaurant management system in C# WinForms with MySQL database. Application is designed to also work with POS environments.
# Installation guide
 1. Run MySQL server, can be a XAMPP development server
 2. Create an empty database, name it "rm"
 3. import the rm.sql file into the empty database
 4. Run RestaurantManagement.exe file from /[Repository Path]/bin/Debug/Net6.0-windows/
 5. Log in to the application using username "admin" and password "admin"
 6. Database will be prefilled with data, and user accounts for users: "Tymon" password "Tymon1" and "Bartek" password "Bartek1"
 7. Prefilled data is limited to dishes, their photos, user accounts and employees profiles. The rest can be created and managed from the application itself.
# Views description
 1. The Login view - lets users log in to the application using their usernames and passwords.
 2. View "Nowe zamówienie" - Here, a user can create a new order, and attach dishes to it. It will sum up the prices of the dishes, and let the user create an order in the database.
 3. View "Zarządzanie zamówieniami" - Here a user can view, and manage orders, marking it as finished, or seeing the address to which the order should be delivered.
 4. View "Rezerwacje" - Here a user can create a new reservation for a certain table, and see todays reservations, or reservations for a chosen date.
 5. View "Grafik" - Here a user can fill if he/she will be available for the day or not, and plan his/her availability for next days. The data from this view will be then used to create reports of employee work times.
# ----------------------------------------------

# RestaurantManagement
 Projekt uniwersytecki. System zarządzania restauracją napisany w C# WinForms połączony z bazą danych MySQL. Aplikacja została dostosowana do użytku w systemach dotykowych typu POS.
# Instrukcja instalacji
 1. Uruchamiamy serwer MySQL, może być to serwer testowy XAMPP
 2. Tworzymy pustą bazę danych o nazwie "rm"
 3. Importujemy plik bazy danych rm.sql do pustej, stworzonej bazy danych
 4. Uruchamiamy plik RestaurantManagement.exe ze ścieżki /[Ścieżka repozytorium]/bin/Debug/Net6.0-windows/
 5. Logujemy się do aplikacji korzystając z nazwy użytkownika "admin" oraz hasła "admin"
 6. Baza danych posiada wypełnione dane, oraz konta użytkowników: "Tymon" hasło "Tymon1" oraz "Bartek" hasło "Bartek1"
 7. Wypełnione dane to: dania, zdjęcia dań, konta użytkowników oraz profile pracowników. Reszta danych może zostać stworzona i zarządzana poprzez aplikację.
# Opisy widoków
 1. Widok logowania - pozwala użytkownikom zalogować się do aplikcaji używając ich nazw użytkowników i haseł.
 2. Widok "Nowe zamówienie" - pozwala na tworzenie nowego zamówienia oraz podpinanie do niego dań. Widok sumuje wartość zamówienia, i pozwala stworzyć zamówienie w bazie danych.
 3. Widok "Zarządzanie zamówieniami" - pozwala zobaczyć, oraz zarządzać zamówieniami oznaczając je jaki zrealizowane, oraz daje możliwość podejrzenia adresu dostawy zamówienia.
 4. Widok "Rezerwacje" - pozwala stworzyć nową rezerwację dotyczącą wybranego stolika, zobaczyć dzisiejsze rezerwacje, oraz rezerwacje w wybranej dacie.
 5. Widok "Grafik" - pozwala wypełnić użytkownikom swoją dostępność dla zaznaczonego dnia, oraz planować dostępność dla innych wybranych dni. Dane z tego widoku zostaną użyte do tworzenia raportów godzin pracy pracowników.