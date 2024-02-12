# RestaurantManagement
 A university project. Restaurant management system in c# WinForms with MySQL database
# Installation guide
 1. Run MySQL server, can be a XAMPP development server
 2. Create an empty database, name it "rm"
 3. import the rm.sql file into the empty database
 4. Run RestaurantManagement.exe file from /[Repository Path]/bin/Debug/Net6.0-windows/
 5. Log in to the application using username "admin" and password "admin"
 6. Database will be prefilled with data, and user accounts for users: "Tymon" password "Tymon1" and "Bartek" password "Bartek1"
 7. Prefilled data is limited to dishes, their photos, user accounts and employees profiles. The rest can be created and managed from the application itself.
# views description
 1. The Login view - lets users log in to the application using their usernames and passwords.
 2 View "Nowe zamówienie" - Here, a user can create a new order, and attach dishes to it. It will sum up the prices of the dishes, and let the user create an order in the database.
 3. View "Zarządzanie zamówieniami" - Here a user can view, and manage orders, marking it as finished, or seeing the address to which the order should be delivered.
 4. View "Rezerwacje" - Here a user can create a new reservation for a certain table, and see todays reservations, or reservations for a chosen date.
 5. View "Grafik" - Here a user can fill if he/she will be available for the day or not, and plan his/her availability for next days. The data from this view will be then used to create reports of employee work times.
