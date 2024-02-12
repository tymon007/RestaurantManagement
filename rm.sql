-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 12, 2024 at 10:13 PM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rm`
--

-- --------------------------------------------------------

--
-- Zastąpiona struktura widoku `ranking_najpopularniejszych_dan`
-- (See below for the actual view)
--
CREATE TABLE `ranking_najpopularniejszych_dan` (
`Nazwa_Dania` varchar(255)
,`Ilosc_Sprzedanych_Sztuk` decimal(32,0)
,`Udzial_Procentowy` decimal(38,2)
);

-- --------------------------------------------------------

--
-- Zastąpiona struktura widoku `raport_godzin_pracownikow_luty_2024`
-- (See below for the actual view)
--
CREATE TABLE `raport_godzin_pracownikow_luty_2024` (
`Imie` varchar(255)
,`Nazwisko` varchar(255)
,`User_Rola` enum('Admin','Pracownik')
,`Ilosc_Zaplanowanych_Godzin` decimal(39,0)
,`Ilosc_Godzin_Urlopu` decimal(39,0)
,`Ilosc_Godzin_Niedostepnych` decimal(39,0)
);

-- --------------------------------------------------------

--
-- Zastąpiona struktura widoku `raport_przychodu_na_2024`
-- (See below for the actual view)
--
CREATE TABLE `raport_przychodu_na_2024` (
`Nazwa_Miesiaca` varchar(11)
,`Laczny_przychod` double(19,2)
);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rezerwacje`
--

CREATE TABLE `rezerwacje` (
  `IDrezerwacji` int(11) NOT NULL,
  `dataOd` datetime NOT NULL,
  `dataDo` datetime NOT NULL,
  `OsobaRezerwujaca` varchar(255) NOT NULL,
  `stolik` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rm_adres`
--

CREATE TABLE `rm_adres` (
  `Adres_Id` int(11) NOT NULL,
  `Numer_Telefonu` varchar(20) DEFAULT NULL,
  `Adres_Dostawy` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rm_danie`
--

CREATE TABLE `rm_danie` (
  `Danie_Id` int(11) NOT NULL,
  `Danie_Nazwa` varchar(255) NOT NULL,
  `Danie_Opis` varchar(500) DEFAULT NULL,
  `Danie_Cena` double NOT NULL,
  `Danie_Kategoria` enum('Burger','Napój','Przekąska') NOT NULL DEFAULT 'Burger'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rm_danie`
--

INSERT INTO `rm_danie` (`Danie_Id`, `Danie_Nazwa`, `Danie_Opis`, `Danie_Cena`, `Danie_Kategoria`) VALUES
(1, 'Cheeseburger', 'Burger z sałatą i serem', 15, 'Burger'),
(2, 'Burger zwyczajny', 'burger z sałatą i cebulą', 12, 'Burger'),
(3, 'Burger ostry', 'Burger z sałatą, ostrym serem cheddar i jalapenio', 17, 'Burger'),
(4, 'Coca-Cola 0.5L', 'Pół litra popularnego napoju gazowanego CocaCola', 7, 'Napój'),
(5, 'Sprite 0.5L', 'Pół litra napoju Sprite', 7, 'Napój'),
(6, 'Woda niegazowana 0.5L', 'Pół litra wody niegazowanej', 5, 'Napój'),
(7, 'Woda gazowana 0.5L', 'Pół litra wody gazowanej', 5, 'Napój'),
(8, 'Małe frytki', 'mała porcja frytek', 8, 'Przekąska'),
(9, 'średnie frytki', 'średnia porcja frytek', 10, 'Przekąska'),
(10, 'Duże frytki', 'Duża porcja frytek', 12, 'Przekąska'),
(11, 'Onion Rings', 'Porcja krążków cebulowych podana z sosem BBQ', 10, 'Przekąska');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rm_grafik`
--

CREATE TABLE `rm_grafik` (
  `Id_wpisu` int(11) NOT NULL,
  `User_Id` int(11) NOT NULL,
  `Data` date NOT NULL,
  `Godzina_Od` time NOT NULL,
  `Godzina_Do` time NOT NULL,
  `Stan` enum('Dostępny','Nieobecny','Urlop') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rm_miejsce`
--

CREATE TABLE `rm_miejsce` (
  `Numer` varchar(2) NOT NULL,
  `liczba_miejsc` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rm_miejsce`
--

INSERT INTO `rm_miejsce` (`Numer`, `liczba_miejsc`) VALUES
('1', 2),
('10', 8),
('2', 2),
('3', 4),
('4', 4),
('5', 4),
('6', 4),
('7', 2),
('8', 2),
('9', 8);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rm_pozycja`
--

CREATE TABLE `rm_pozycja` (
  `Pozycja_Id` int(11) NOT NULL,
  `Zamowienie_Id` int(11) NOT NULL,
  `Danie_Id` int(11) NOT NULL,
  `Ilosc` int(11) NOT NULL,
  `Krotnosc` double NOT NULL,
  `Cena_jednostki` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rm_pracownik`
--

CREATE TABLE `rm_pracownik` (
  `Pracownik_ID` int(11) NOT NULL,
  `Imie` varchar(255) DEFAULT NULL,
  `Nazwisko` varchar(255) DEFAULT NULL,
  `Plec` enum('M','K') DEFAULT NULL,
  `Wiek` int(3) DEFAULT NULL,
  `Data_Rozpoczecia_Pracy` date DEFAULT NULL,
  `LinkDoZdjecia` varchar(255) DEFAULT NULL,
  `User_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rm_pracownik`
--

INSERT INTO `rm_pracownik` (`Pracownik_ID`, `Imie`, `Nazwisko`, `Plec`, `Wiek`, `Data_Rozpoczecia_Pracy`, `LinkDoZdjecia`, `User_ID`) VALUES
(1, 'Maciej', 'Janas', 'M', 12, '2023-11-01', 'https://i.pinimg.com/736x/de/59/4e/de594ec09881da3fa66d98384a3c72ff.jpg', 2),
(2, 'Bartek', 'Karbownik', 'M', 22, '2023-12-01', 'https://t3.ftcdn.net/jpg/02/43/12/34/360_F_243123463_zTooub557xEWABDLk0jJklDyLSGl2jrr.jpg', 1),
(3, 'Tymon', 'Kozanecki', 'M', 21, '2022-07-01', 'https://uxwing.com/wp-content/themes/uxwing/download/peoples-avatars/man-person-icon.png', 3);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rm_users`
--

CREATE TABLE `rm_users` (
  `User_Login` varchar(255) DEFAULT NULL,
  `User_Hasło` varchar(1000) DEFAULT NULL,
  `User_Id` int(11) NOT NULL,
  `User_Rola` enum('Admin','Pracownik') DEFAULT NULL,
  `Status` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rm_users`
--

INSERT INTO `rm_users` (`User_Login`, `User_Hasło`, `User_Id`, `User_Rola`, `Status`) VALUES
('Bartek', 'Bartek1', 1, 'Pracownik', 1),
('admin', 'admin', 2, 'Admin', 1),
('Tymon', 'Tymon1', 3, 'Pracownik', 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rm_zamowienie`
--

CREATE TABLE `rm_zamowienie` (
  `Zamowienie_Id` int(11) NOT NULL,
  `Zamowienie_Cena` double DEFAULT NULL,
  `Zamowienie_Status` enum('Przyjęte','Zrealizowane') DEFAULT NULL,
  `Godzina_złożenia_zamówienia` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `User_Id` int(11) DEFAULT NULL,
  `Adres_Id` int(11) DEFAULT NULL,
  `Godzina_zakonczenia_zamowienia` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rm_zdjecia`
--

CREATE TABLE `rm_zdjecia` (
  `Zdjecie_Id` int(11) NOT NULL,
  `Danie_Id` int(11) NOT NULL,
  `Zdjecie_Link` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rm_zdjecia`
--

INSERT INTO `rm_zdjecia` (`Zdjecie_Id`, `Danie_Id`, `Zdjecie_Link`) VALUES
(1, 3, 'https://restaumatic-production.imgix.net/uploads/accounts/22532/media_library/8792a406-595f-4cb5-9630-63af600ec41b.jpg?auto=compress%2Cformat&blur=0&crop=focalpoint&fit=max&fp-x=0.5&fp-y=0.5&h=768&rect=0%2C0%2C2000%2C1500&w=1920'),
(2, 2, 'https://akademiasmaku.pl/storage/6491/domowe-burgery-z-grilla-3644.jpg'),
(3, 1, 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/4d/Cheeseburger.jpg/800px-Cheeseburger.jpg'),
(4, 4, 'https://niemirka.com/766-large_default/coca-cola-05l-x-18-sztuk.jpg'),
(5, 10, 'https://kraftowezapiekanki.pl/wp-content/uploads/2021/08/kraftowe_frytki_belgijskie.png'),
(6, 8, 'https://www.kebabnazar.pl/jpg/50.jpg'),
(7, 11, 'https://www.eatingwell.com/thmb/rHWeEGjoMYBLwY3YPcHdYLgvP6Q=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/air-fryer-onion-rings-88f75f083c30401d80e40b31d0f115fe.jpg'),
(8, 5, 'https://niemirka.com/591-large_default/sprite-05l-x-12-sztuk.jpg'),
(9, 7, 'https://niemirka.com/2685/cisowianka-05-l-gazowana-x-12-sztuk.jpg'),
(10, 6, 'https://opakowania24.eu/images/sv531/19000-20000/Woda-CISOWIANKA-0-5l-niegazowana-zgrzewka-12-szt_%5B19256%5D_480.jpg'),
(11, 9, 'https://cdn.galleries.smcloud.net/t/galleries/gf-SRvr-NswP-it2h_czy-frytki-moga-byc-zdrowe-jak-zrobic-dietetyczne-frytki-1920x1080-nocrop.jpg');

-- --------------------------------------------------------

--
-- Zastąpiona struktura widoku `widok_przychodu_luty_2024`
-- (See below for the actual view)
--
CREATE TABLE `widok_przychodu_luty_2024` (
`Przychod_Na_Miejscu` double
,`Udzial_Na_Miejscu` double(19,2)
,`Ilosc_Zamowien_Na_Miejscu` bigint(21)
,`Przychod_Na_Wynos` double
,`Udzial_Na_Wynos` double(19,2)
,`Ilosc_Zamowien_Na_Wynos` bigint(21)
);

-- --------------------------------------------------------

--
-- Struktura widoku `ranking_najpopularniejszych_dan`
--
DROP TABLE IF EXISTS `ranking_najpopularniejszych_dan`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `ranking_najpopularniejszych_dan`  AS SELECT `d`.`Danie_Nazwa` AS `Nazwa_Dania`, sum(`p`.`Ilosc`) AS `Ilosc_Sprzedanych_Sztuk`, round(sum(`p`.`Ilosc`) / (select sum(`rm_pozycja`.`Ilosc`) from (`rm_pozycja` join `rm_zamowienie` on(`rm_pozycja`.`Zamowienie_Id` = `rm_zamowienie`.`Zamowienie_Id`)) where month(`rm_zamowienie`.`Godzina_złożenia_zamówienia`) = 2 and year(`rm_zamowienie`.`Godzina_złożenia_zamówienia`) = 2024) * 100,2) AS `Udzial_Procentowy` FROM ((`rm_danie` `d` join `rm_pozycja` `p` on(`d`.`Danie_Id` = `p`.`Danie_Id`)) join `rm_zamowienie` `z` on(`p`.`Zamowienie_Id` = `z`.`Zamowienie_Id`)) WHERE month(`z`.`Godzina_złożenia_zamówienia`) = 2 AND year(`z`.`Godzina_złożenia_zamówienia`) = 2024 GROUP BY `d`.`Danie_Nazwa` ORDER BY sum(`p`.`Ilosc`) DESC ;

-- --------------------------------------------------------

--
-- Struktura widoku `raport_godzin_pracownikow_luty_2024`
--
DROP TABLE IF EXISTS `raport_godzin_pracownikow_luty_2024`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raport_godzin_pracownikow_luty_2024`  AS SELECT `p`.`Imie` AS `Imie`, `p`.`Nazwisko` AS `Nazwisko`, `u`.`User_Rola` AS `User_Rola`, floor(sum(case when `g`.`Stan` = 'Dostępny' then time_to_sec(timediff(`g`.`Godzina_Do`,`g`.`Godzina_Od`)) / 3600 else 0 end)) AS `Ilosc_Zaplanowanych_Godzin`, floor(sum(case when `g`.`Stan` = 'Urlop' then time_to_sec(timediff(`g`.`Godzina_Do`,`g`.`Godzina_Od`)) / 3600 else 0 end)) AS `Ilosc_Godzin_Urlopu`, floor(sum(case when `g`.`Stan` = 'Nieobecny' then time_to_sec(timediff(`g`.`Godzina_Do`,`g`.`Godzina_Od`)) / 3600 else 0 end)) AS `Ilosc_Godzin_Niedostepnych` FROM ((`rm_grafik` `g` join `rm_pracownik` `p` on(`g`.`User_Id` = `p`.`User_ID`)) join `rm_users` `u` on(`p`.`User_ID` = `u`.`User_Id`)) WHERE month(`g`.`Data`) = 2 AND year(`g`.`Data`) = 2024 GROUP BY `p`.`Imie`, `p`.`Nazwisko`, `u`.`User_Rola` ;

-- --------------------------------------------------------

--
-- Struktura widoku `raport_przychodu_na_2024`
--
DROP TABLE IF EXISTS `raport_przychodu_na_2024`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raport_przychodu_na_2024`  AS SELECT `miesiac`.`Nazwa_Miesiaca` AS `Nazwa_Miesiaca`, round(coalesce(sum(`z`.`Calkowita_kwota`),0),2) AS `Laczny_przychod` FROM ((select 'Styczeń' AS `Nazwa_Miesiaca`,1 AS `Miesiac_Num` union all select 'Luty' AS `Luty`,2 AS `2` union all select 'Marzec' AS `Marzec`,3 AS `3` union all select 'Kwiecień' AS `Kwiecień`,4 AS `4` union all select 'Maj' AS `Maj`,5 AS `5` union all select 'Czerwiec' AS `Czerwiec`,6 AS `6` union all select 'Lipiec' AS `Lipiec`,7 AS `7` union all select 'Sierpień' AS `Sierpień`,8 AS `8` union all select 'Wrzesień' AS `Wrzesień`,9 AS `9` union all select 'Październik' AS `Październik`,10 AS `10` union all select 'Listopad' AS `Listopad`,11 AS `11` union all select 'Grudzień' AS `Grudzień`,12 AS `12`) `miesiac` left join (select month(`z`.`Godzina_złożenia_zamówienia`) AS `Miesiac`,year(`z`.`Godzina_złożenia_zamówienia`) AS `Rok`,sum(`p`.`Ilosc` * `p`.`Cena_jednostki`) AS `Calkowita_kwota` from (`rm_zamowienie` `z` join `rm_pozycja` `p` on(`z`.`Zamowienie_Id` = `p`.`Zamowienie_Id`)) where year(`z`.`Godzina_złożenia_zamówienia`) = 2024 group by month(`z`.`Godzina_złożenia_zamówienia`),year(`z`.`Godzina_złożenia_zamówienia`)) `z` on(`miesiac`.`Miesiac_Num` = `z`.`Miesiac`)) GROUP BY `miesiac`.`Nazwa_Miesiaca` ORDER BY `miesiac`.`Miesiac_Num` ASC ;

-- --------------------------------------------------------

--
-- Struktura widoku `widok_przychodu_luty_2024`
--
DROP TABLE IF EXISTS `widok_przychodu_luty_2024`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `widok_przychodu_luty_2024`  AS SELECT sum(case when `rm_zamowienie`.`Adres_Id` is null then `rm_zamowienie`.`Zamowienie_Cena` else 0 end) AS `Przychod_Na_Miejscu`, round(sum(case when `rm_zamowienie`.`Adres_Id` is null then `rm_zamowienie`.`Zamowienie_Cena` else 0 end) / sum(`rm_zamowienie`.`Zamowienie_Cena`) * 100,2) AS `Udzial_Na_Miejscu`, count(case when `rm_zamowienie`.`Adres_Id` is null then 1 end) AS `Ilosc_Zamowien_Na_Miejscu`, sum(case when `rm_zamowienie`.`Adres_Id` is not null then `rm_zamowienie`.`Zamowienie_Cena` else 0 end) AS `Przychod_Na_Wynos`, round(sum(case when `rm_zamowienie`.`Adres_Id` is not null then `rm_zamowienie`.`Zamowienie_Cena` else 0 end) / sum(`rm_zamowienie`.`Zamowienie_Cena`) * 100,2) AS `Udzial_Na_Wynos`, count(case when `rm_zamowienie`.`Adres_Id` is not null then 1 end) AS `Ilosc_Zamowien_Na_Wynos` FROM `rm_zamowienie` WHERE month(`rm_zamowienie`.`Godzina_złożenia_zamówienia`) = 2 AND year(`rm_zamowienie`.`Godzina_złożenia_zamówienia`) = 2024 ;

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `rezerwacje`
--
ALTER TABLE `rezerwacje`
  ADD PRIMARY KEY (`IDrezerwacji`),
  ADD KEY `Rezerwacje_rm_miejsce_FK` (`stolik`);

--
-- Indeksy dla tabeli `rm_adres`
--
ALTER TABLE `rm_adres`
  ADD PRIMARY KEY (`Adres_Id`);

--
-- Indeksy dla tabeli `rm_danie`
--
ALTER TABLE `rm_danie`
  ADD PRIMARY KEY (`Danie_Id`);

--
-- Indeksy dla tabeli `rm_grafik`
--
ALTER TABLE `rm_grafik`
  ADD PRIMARY KEY (`Id_wpisu`),
  ADD KEY `User_Id` (`User_Id`);

--
-- Indeksy dla tabeli `rm_miejsce`
--
ALTER TABLE `rm_miejsce`
  ADD PRIMARY KEY (`Numer`);

--
-- Indeksy dla tabeli `rm_pozycja`
--
ALTER TABLE `rm_pozycja`
  ADD PRIMARY KEY (`Pozycja_Id`),
  ADD KEY `Zamowienie_Id` (`Zamowienie_Id`),
  ADD KEY `Danie_Id` (`Danie_Id`);

--
-- Indeksy dla tabeli `rm_pracownik`
--
ALTER TABLE `rm_pracownik`
  ADD PRIMARY KEY (`Pracownik_ID`),
  ADD KEY `User_ID` (`User_ID`);

--
-- Indeksy dla tabeli `rm_users`
--
ALTER TABLE `rm_users`
  ADD PRIMARY KEY (`User_Id`);

--
-- Indeksy dla tabeli `rm_zamowienie`
--
ALTER TABLE `rm_zamowienie`
  ADD PRIMARY KEY (`Zamowienie_Id`),
  ADD KEY `User_Id` (`User_Id`),
  ADD KEY `Adres_Zamowienie_FK` (`Adres_Id`);

--
-- Indeksy dla tabeli `rm_zdjecia`
--
ALTER TABLE `rm_zdjecia`
  ADD PRIMARY KEY (`Zdjecie_Id`),
  ADD KEY `Danie_Id` (`Danie_Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `rezerwacje`
--
ALTER TABLE `rezerwacje`
  MODIFY `IDrezerwacji` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `rm_adres`
--
ALTER TABLE `rm_adres`
  MODIFY `Adres_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `rm_danie`
--
ALTER TABLE `rm_danie`
  MODIFY `Danie_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `rm_grafik`
--
ALTER TABLE `rm_grafik`
  MODIFY `Id_wpisu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `rm_pozycja`
--
ALTER TABLE `rm_pozycja`
  MODIFY `Pozycja_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `rm_pracownik`
--
ALTER TABLE `rm_pracownik`
  MODIFY `Pracownik_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `rm_users`
--
ALTER TABLE `rm_users`
  MODIFY `User_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `rm_zamowienie`
--
ALTER TABLE `rm_zamowienie`
  MODIFY `Zamowienie_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `rm_zdjecia`
--
ALTER TABLE `rm_zdjecia`
  MODIFY `Zdjecie_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `rezerwacje`
--
ALTER TABLE `rezerwacje`
  ADD CONSTRAINT `Rezerwacje_rm_miejsce_FK` FOREIGN KEY (`stolik`) REFERENCES `rm_miejsce` (`Numer`);

--
-- Constraints for table `rm_grafik`
--
ALTER TABLE `rm_grafik`
  ADD CONSTRAINT `rm_grafik_ibfk_1` FOREIGN KEY (`User_Id`) REFERENCES `rm_users` (`User_Id`);

--
-- Constraints for table `rm_pozycja`
--
ALTER TABLE `rm_pozycja`
  ADD CONSTRAINT `Pozycja_ibfk_1` FOREIGN KEY (`Zamowienie_Id`) REFERENCES `rm_zamowienie` (`Zamowienie_Id`),
  ADD CONSTRAINT `Pozycja_ibfk_2` FOREIGN KEY (`Danie_Id`) REFERENCES `rm_danie` (`Danie_Id`);

--
-- Constraints for table `rm_pracownik`
--
ALTER TABLE `rm_pracownik`
  ADD CONSTRAINT `rm_pracownik_ibfk_1` FOREIGN KEY (`User_ID`) REFERENCES `rm_users` (`User_Id`);

--
-- Constraints for table `rm_zamowienie`
--
ALTER TABLE `rm_zamowienie`
  ADD CONSTRAINT `Adres_Zamowienie_FK` FOREIGN KEY (`Adres_Id`) REFERENCES `rm_adres` (`Adres_Id`),
  ADD CONSTRAINT `Zamowienie_ibfk_1` FOREIGN KEY (`User_Id`) REFERENCES `rm_users` (`User_Id`);

--
-- Constraints for table `rm_zdjecia`
--
ALTER TABLE `rm_zdjecia`
  ADD CONSTRAINT `Zdjecia_ibfk_1` FOREIGN KEY (`Danie_Id`) REFERENCES `rm_danie` (`Danie_Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
