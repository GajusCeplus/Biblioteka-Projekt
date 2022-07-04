CREATE DATABASE  IF NOT EXISTS `biblioteka` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `biblioteka`;
-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: biblioteka
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `autorzy`
--

DROP TABLE IF EXISTS `autorzy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `autorzy` (
  `id_autorzy` int unsigned NOT NULL AUTO_INCREMENT,
  `imie` varchar(50) NOT NULL,
  `nazwisko` varchar(50) NOT NULL,
  PRIMARY KEY (`id_autorzy`),
  UNIQUE KEY `id_autorzy_UNIQUE` (`id_autorzy`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `autorzy`
--

LOCK TABLES `autorzy` WRITE;
/*!40000 ALTER TABLE `autorzy` DISABLE KEYS */;
INSERT INTO `autorzy` VALUES (1,'Małgorzata ','Czyńska'),(2,'Izabella ','Adamczewska-Baranowska'),(3,'Serhij','Rudenko'),(4,'Przemysław ','Słowiński'),(5,'Charles','Seife'),(6,'Kate ','Bryan'),(7,'Marian ','Tokarzewski'),(8,'Zbigniew','Sujkowski '),(9,'Jan','Rodak '),(10,'Asserate ','Asfa-Wossen'),(11,'Janusz','Jaźwiński'),(12,'Erik','Larson'),(13,'Piotr','Mikołajczak'),(14,'Iwona','Kienzler'),(15,'Beata','Sabała-Zielińska'),(16,'Anita','Głowińska'),(17,'Brandon','Mull'),(18,'Barbara','Supeł'),(19,'Marta','Galewska-Kustra'),(20,'Jeff','Kinney'),(21,'Jennifer L. ','Armentrout'),(22,'Sarah J.','Maas'),(23,'Micheal','Crichton'),(24,'Holly','Black'),(25,'Andrzej','Sapkowski'),(26,'Tomasz','Bonek'),(27,'Agnieszka','Jankowiak-Maik'),(28,'Jacek','Bartosiak'),(29,'Andrzej','Nowak'),(30,'Kamil','Janicki'),(31,'Michał','Wójcik'),(32,'Eric','Matthes'),(33,'Robert C.','Martin'),(34,'Mark','Lutz'),(35,'Marcin','Moskała'),(36,'Jon','Duckett'),(37,'Janusz','Christa'),(38,'Art','Spiegelman'),(39,'Remigiusz','Mróz'),(40,'Małgorzata','Gołota'),(41,'Szymon','Pękała'),(42,'Daniel','Kahneman'),(43,'Colleen','Hoover'),(44,'Olga','Tokarczuk'),(45,'Magda','Knedler'),(46,'Rafał','Pacześ'),(47,'Mark','Wolynn'),(48,'Karen','Bluth'),(49,'Eric','Berne'),(50,'Glenn R.','Schiraldi'),(51,'Jerzy','Rafalski'),(52,'Kacper','Pitala'),(53,'Paul','Davies'),(54,'Agata','Zejfer'),(55,'Rupi','Kaur'),(56,'Krzysztof Kamil','Baczyński'),(57,'James','Eade'),(58,'Sylwia','Kawalerowicz'),(59,'Dave','Canterbury'),(60,'Tomasz','Habdas');
/*!40000 ALTER TABLE `autorzy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `czytelnicy`
--

DROP TABLE IF EXISTS `czytelnicy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `czytelnicy` (
  `id_czytelnicy` int unsigned NOT NULL AUTO_INCREMENT,
  `imie` varchar(100) NOT NULL,
  `nazwisko` varchar(100) NOT NULL,
  `gender` varchar(15) DEFAULT NULL,
  `telefon` varchar(25) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_czytelnicy`),
  UNIQUE KEY `id_czytelnicy_UNIQUE` (`id_czytelnicy`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `czytelnicy`
--

LOCK TABLES `czytelnicy` WRITE;
/*!40000 ALTER TABLE `czytelnicy` DISABLE KEYS */;
INSERT INTO `czytelnicy` VALUES (1,'Michał','Pawlak','Mężczyzna','123456789','mpawlak@mail.com'),(2,'Paweł','Pawlak','Mężczyzna','',''),(3,'Jan','Nowak','Mężczyzna','',''),(4,'Kamil','Kowalski','Mężczyzna','',''),(5,'Anna','Jagiełło','Kobieta','',''),(6,'Kazimierz','Wielki','Mężczyzna','',''),(7,'Gal','Anonim','Brak','',''),(8,'Anna','Adamczyk','Kobieta','','');
/*!40000 ALTER TABLE `czytelnicy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gatunki`
--

DROP TABLE IF EXISTS `gatunki`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gatunki` (
  `id_gatunki` int unsigned NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(100) NOT NULL,
  PRIMARY KEY (`id_gatunki`),
  UNIQUE KEY `id_gatunki_UNIQUE` (`id_gatunki`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gatunki`
--

LOCK TABLES `gatunki` WRITE;
/*!40000 ALTER TABLE `gatunki` DISABLE KEYS */;
INSERT INTO `gatunki` VALUES (1,'Biografie'),(2,'Dla dzieci'),(3,'Fantastyka, horror'),(4,'Historia'),(5,'informatyka'),(6,'Komiks'),(7,'Kryminał, sensacja, thriller'),(8,'Literatura faktu, reportaż'),(9,'Literatura obyczajowa'),(10,'Literatura piękna'),(11,'Nauki społeczne i humanistyczne'),(12,'Nauki ścisłe, medycyna'),(13,'Poezja, aforyzm, dramat '),(14,'Poradniki'),(15,'Turystyka i podróże');
/*!40000 ALTER TABLE `gatunki` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ksiazki`
--

DROP TABLE IF EXISTS `ksiazki`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ksiazki` (
  `id_ksiazki` int unsigned NOT NULL AUTO_INCREMENT,
  `isbn` varchar(20) NOT NULL,
  `tytul` varchar(150) NOT NULL,
  `autor_id` int unsigned DEFAULT NULL,
  `gatunek_id` int unsigned DEFAULT NULL,
  `ilosc` int NOT NULL,
  `cena` double DEFAULT NULL,
  `wydawca` varchar(100) DEFAULT NULL,
  `data_wydania` date DEFAULT NULL,
  PRIMARY KEY (`id_ksiazki`),
  UNIQUE KEY `id_ksiazki_UNIQUE` (`id_ksiazki`),
  KEY `fk_autor_idx` (`autor_id`),
  KEY `fk_gatunek_idx` (`gatunek_id`),
  CONSTRAINT `fk_autor` FOREIGN KEY (`autor_id`) REFERENCES `autorzy` (`id_autorzy`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_gatunek` FOREIGN KEY (`gatunek_id`) REFERENCES `gatunki` (`id_gatunki`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=85 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ksiazki`
--

LOCK TABLES `ksiazki` WRITE;
/*!40000 ALTER TABLE `ksiazki` DISABLE KEYS */;
INSERT INTO `ksiazki` VALUES (1,'42088448','Witkacy i Kobiety. Harem metafizyczny',1,1,10,38.52,'Wydawnictwo Marginesy ','2022-07-06'),(2,'42075356','Jacek Hugo-Bader. Włóczęga',2,1,5,39.49,'Wydawnictwo Uniwersytetu Łódzkiego ','2022-06-30'),(3,'41958445','Zełenski. Poza scenariuszem',3,1,11,29.61,'Wydawnictwo Poznańskie ','2022-06-29'),(4,'42471004','Książę przygody. Biografia Antoniego Ferdynanda Ossendowskiego',4,1,23,40.99,'Zona Zero ','2022-06-26'),(5,'42471066','Hawking, Hawking. Geniusz i celebryta ',5,1,33,52.49,'Prószyński Media','2022-06-22'),(6,'42423874','Sztuka w afekcie. Romantyczne i burzliwe historie najsłynniejszych artystycznych par',6,1,9,66.99,'Wydawnictwo Arkady ','2022-06-22'),(7,'42692041','Straż przednia',7,1,44,46.99,'Klinika Języka ','2022-06-21'),(8,'42692072','Sylwetki Zbigniew Sujkowski',8,1,24,43.49,'Klinika Języka','2022-06-21'),(9,'42647997','Drogi we mgle',9,1,10,59.25,'Wydawnictwo Poligraf ','2022-06-20'),(10,'42046318','Hajle Syllasje. Ostatni cesarz Etiopii',10,1,7,38.9,'PIW Państwowy Instytut Wydawniczy ','2022-06-17'),(11,'42660590','Insynkt swobody. Wspomnienia z Polski 1939-1961',11,1,12,25.5,'Wydawnictwo Poligraf ','2022-06-17'),(12,'41098608','Rok, który zmienił wszystko',12,1,17,55.36,'Znak Horyzont ','2022-06-15'),(13,'41931370','NOrWAY. Półdzienniki z emigracji',13,1,15,29.2,'Wydawnictwo Otwarte ','2022-06-15'),(14,'42029526','Ignacy Paderewski - ulubieniec kobiet ',14,1,14,27.97,'Wydawnictwo Bellona ','2022-06-15'),(15,'41992746','TOPR. Tatrzańska przygoda Zosi i Franka',15,2,40,36.31,'Prószyński Media ','2022-06-14'),(16,'41655238','Kicia Kocia i Nunuś. Kto mieszka w zagrodzie?',16,2,30,21.42,'Media Rodzina ','2022-06-18'),(17,'41869680','Powrót zabójców smoków. Smocza straż. Tom 5',17,2,20,28.12,'Wydawnictwo Wilga ','2022-05-18'),(18,'41960349','Jadzia Pętelka czuje złość. Jadzia Pętelka',18,2,13,14.28,'Wydawnictwo Zielona Sowa','2022-05-18'),(19,'39305671','Pucio chce siusiu, czyli pożegnanie pieluszki',19,2,23,15.81,'Wydawnictwo Nasza Księgarnia ','2021-08-11'),(20,'41361023','Dziennik cwaniaczka. Krótka piłka',20,2,33,18.99,'Wydawnictwo Nasza Księgarnia ','2022-07-04'),(21,'35734673','Pucio uczy się mówić. Zabawy dźwiękonaśladowcze dla najmłodszych',19,2,13,28.51,'Wydawnictwo Nasza Księgarnia ','2020-07-15'),(22,'32131741','Kicia Kocia na plaży',16,2,28,5.49,'Media Rodzina ','2019-05-09'),(23,'41868256','Królestwo ciała i ognia. Z krwi i popiołu. Tom 2',21,3,33,32.61,'You&YA ','2022-06-29'),(24,'41895337','Dom Nieba i Oddechu. Księżycowe Miasto. Tom 2. Część 2',22,3,22,35.74,'Uroboros ','2022-06-01'),(25,'41857465','Park Jurajski',23,3,22,43.4,'Wydawnictwo Vesper ','2022-06-15'),(26,'40666150','Krew i popiół. Tom 1',21,3,11,35.03,'You&YA ','2022-01-12'),(27,'41856574','Dwór cierni i róż. Tom 1',22,3,30,29.5,'Uroboros','2016-04-27'),(28,'41905760','Księga nocy',24,3,37,30.89,'Jaguar ','2022-07-04'),(29,'41548820','Dom Nieba i oddechu. Księżycowe Miasto. Tom 2. Część 1',22,3,23,38.49,'Uroboros ','2022-04-27'),(30,'15830982','Ostatnie życzenie. Wiedźmin. Tom 1',25,3,69,38.02,'SUPERNOWA','2014-10-06'),(31,'15830883','Miecz przeznaczenia. Wiedźmin. Tom 2',25,3,55,38.02,'SUPERNOWA','2014-10-06'),(32,'16003811','Krew elfów. Wiedźmin. Tom 3',25,3,44,38.02,'SUPERNOWA','2014-10-28'),(33,'16012592','Czas pogardy. Wiedźmin. Tom 4',25,3,44,38.02,'SUPERNOWA','2014-10-28'),(34,'16003583','Chrzest ognia. Wiedźmin. Tom 5',25,3,44,38.02,'SUPERNOWA','2014-10-28'),(35,'16012721','Wieża jaskółki. Wiedźmin. Tom 6',25,3,33,39.3,'SUPERNOWA','2014-10-28'),(36,'16012660','Pani Jeziora. Wiedźmin. Tom 7',25,3,55,39.3,'SUPERNOWA','2014-10-28'),(37,'13801045','Sezon burz. Wiedźmin. Tom 8 ',25,3,55,38.02,'SUPERNOWA','2013-11-06'),(38,'','Demony śmierci. Zbrodniarze z Gross-Rosen',26,4,23,31.11,'Znak Horyzont ','2022-06-29'),(39,'41521250','Historia, której nie było',27,4,33,33.91,'Wydawnictwo Otwarte','2022-04-27'),(40,'40271934','Nadchodzi III wojna światowa ',28,4,22,28.56,'Dom Wydawniczy Rebis ','2021-10-26'),(41,'42200970','Polska i Rosja. Sąsiedztwo wolności i despotyzmu X-XXI w. ',29,4,22,54.53,'Biały Kruk ','2022-04-14'),(42,'38492341','Pańszczyzna. Prawdziwa historia polskiego niewolnictwa',30,4,42,29.29,'Wydawnictwo Poznańskie ','2021-08-11'),(43,' ','Snajper wchodzi pierwszy',31,4,31,28.51,'Znak Literanova ','2021-07-28'),(44,'34999301','Python. Instrukcje dla programisty',32,5,44,61.98,'Wydawnictwo Helion ','2020-06-22'),(45,'15520388','Czysty kod. Podręcznik dobrego programisty',33,5,11,43.87,'Wydawnictwo Helion','2014-10-15'),(46,'31156981','Agile. Programowanie zwinne: zasady, wzorce i praktyki zwinnego wytwarzania oprogramowania w C#',33,5,22,84.79,'Wydawnictwo Helion ','2019-02-05'),(47,'41218846','Python. Wprowadzenie',34,5,11,126.24,'Wydawnictwo Helion ','2022-03-28'),(48,'39687746','JavaScript od podstaw',35,5,3,26.04,'Moskała Marcin ','2021-08-11'),(49,'26190136','HTML i CSS. Zaprojektuj i zbuduj witrynę WWW. Podręcznik Front-End Developera ',36,5,6,60.95,'Wydawnictwo Helion ','2018-07-12'),(50,'36673087','Szkoła latania. Kajko i Kokosz',37,6,10,16.02,'Egmont Polska Sp. z o.o. ','2021-01-20'),(51,'35319405','Szranki i konkury. Część 1. Kajko i Kokosz',37,6,11,22.49,'Egmont Polska Sp. z o.o. ','2020-08-12'),(52,'35120858','Festiwal czarownic. Kajko i Kokosz',37,6,11,16.76,'Egmont Polska Sp. z o.o. ','2020-07-16'),(53,'20287382','Maus',38,6,27,35.23,'Wydawnictwo Komiksowe ','2016-11-10'),(54,'41770337','Obrazy z przeszłości. Seweryn Zaorski. Tom 4',39,7,34,28.14,'Wydawnictwo Filia ','2022-05-18'),(55,'40717180','Projekt Riese',39,7,23,23.99,'Wydawnictwo Filia ','2022-01-26'),(56,'41041321','Skazanie ',39,7,32,24.52,'Czwarta Strona ','2022-03-23'),(57,'42239123','Obrazy z przeszłości',39,7,12,39.9,'Wydawnictwo Filia ','2022-06-14'),(58,'41436851','Żyletkę zawsze noszę przy sobie',40,8,11,27.7,'Wydawnictwo Filia','2022-07-04'),(59,'41855355','Wojna Idei. Myśl po swojemu',41,8,32,31.13,'Znak Horyzont ','2022-06-14'),(60,'11896708','Pułapki myślenia. O myśleniu szybkim i wolnym',42,8,13,30.08,'Media Rodzina ','2012-06-05'),(61,'37964245','It Ends with Us',43,9,1,28.48,'Wydawnictwo Otwarte ','2021-03-10'),(62,'42107484','Reminders of Him. Cząstka ciebie, którą znam',43,9,2,33.37,'Wydawnictwo Otwarte ','2022-07-04'),(63,'41650783','November 9',43,9,3,28.34,'Wydawnictwo Otwarte ','2022-06-23'),(64,'40459370','Ugly Love',43,9,4,30,'Wydawnictwo Otwarte','2022-05-04'),(65,'41605790','Empuzjon',44,10,32,37.33,'Wydawnictwo Literackie ','2022-06-01'),(66,'34017357','Położna z Auschwitz',45,10,12,23,'Mando ','2020-01-15'),(67,'36143290','Grube wióry',46,10,23,24.54,'Wydawnictwo Agora','2020-11-25'),(68,'41618400','Ostatni śnieg',46,10,15,27.61,'Wydawnictwo Agora ','2022-05-22'),(69,'39017260','Nie zaczęło się od ciebie. Jak dziedziczona trauma wpływa na to, kim jesteśmy i jak zakończyć ten proces',47,11,22,23.7,'Wydawnictwo Czarna Owca ','2021-07-15'),(70,'41547540','Na emocjonalnej karuzeli. Jak pokonać samokrytycyzm, opanować emocje i zaakceptować siebie dzięki technikom uważności i współczucia',48,11,11,40.1,'GWP Gdańskie Wydawnictwo Psychologiczne ','2020-10-22'),(71,'68754990','W co grają ludzie',49,11,9,43.36,'Wydawnictwo Naukowe PWN ','2022-02-16'),(72,'41836415','Traumatyczne doświadczenia z dzieciństwa',50,11,23,56.19,'GWP Gdańskie Wydawnictwo Psychologiczne ','2022-03-24'),(73,'39971081','Gwiazdy i planety. Mała encyklopedia ilustrowana',51,12,44,33.71,' 	Multico ','2021-06-04'),(74,'37918514','Jak to wyjaśnić? W poszukiwaniu odpowiedzi na pytania, które pozornie nie mają odpowiedzi ',52,12,100,29.08,'Wydawnictwo Otwarte ','2021-05-19'),(75,'41188316','Co pożera wszechświat? i inne zagadki kosmosu ',53,12,22,32.54,'Copernicus Center Press ','2022-03-24'),(76,'41420737','Kompleksowa terapia problemów skórnych ',54,12,18,98.95,'Wydawnictwo Lekarskie PZWL ','2022-01-12'),(77,'40797489','Słońce i jej kwiaty. The Sun and Her Flowers ',55,13,0,34.45,'Wydawnictwo Otwarte ','2021-06-02'),(78,'40712451','Mleko i miód. Milk and Honey',55,13,0,33.91,'Wydawnictwo Otwarte ','2021-06-02'),(79,'39334732','Wiersze wybrane',51,13,1,27.97,'Świat Książki ','2021-11-23'),(80,'39346964','Szachy. Praktyczny przewodnik. Jak grać i wygrać',57,14,22,31.52,'Publicat ','2022-02-16'),(81,'41906132','Moc ziół. Zielarki i ich sekretne przepisy ',58,14,11,34.68,'Wydawnictwo Buchmann ','2022-06-01'),(82,'41916773','Bushcraft. Jak radzić sobie w dziczy bez współczesnych udogodnień',59,14,21,30.1,'Wydawnictwo Bezdroża ','2022-06-21'),(83,'41921524','Gdzie w góry na weekend. Górskie trasy dla każdego',60,15,11,39.63,'Znak Koncept ','2022-06-15'),(84,'42644965','Bieszczady',60,15,11,44.9,'Wydawnictwo Bezdroża ','2022-06-08');
/*!40000 ALTER TABLE `ksiazki` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uzytkownicy`
--

DROP TABLE IF EXISTS `uzytkownicy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `uzytkownicy` (
  `id_uzytkownicy` int unsigned NOT NULL AUTO_INCREMENT,
  `imie` varchar(100) DEFAULT NULL,
  `nazwisko` varchar(100) DEFAULT NULL,
  `login` varchar(50) NOT NULL,
  `haslo` varchar(50) NOT NULL,
  `typ_uzytkownika` varchar(50) NOT NULL,
  PRIMARY KEY (`id_uzytkownicy`),
  UNIQUE KEY `id_uzytkownicy_UNIQUE` (`id_uzytkownicy`),
  UNIQUE KEY `login_UNIQUE` (`login`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uzytkownicy`
--

LOCK TABLES `uzytkownicy` WRITE;
/*!40000 ALTER TABLE `uzytkownicy` DISABLE KEYS */;
INSERT INTO `uzytkownicy` VALUES (1,'Michał','Pawlak','Mic','Paw','bibliotekarz'),(2,'Paweł','Pawlak','admin','admin1','admin'),(3,'-','-','public','public','user');
/*!40000 ALTER TABLE `uzytkownicy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wypozyczenia`
--

DROP TABLE IF EXISTS `wypozyczenia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `wypozyczenia` (
  `id_wypozyczenia` int unsigned NOT NULL AUTO_INCREMENT,
  `ksiazka_id` int unsigned DEFAULT NULL,
  `czytelnik_id` int unsigned DEFAULT NULL,
  `status` varchar(45) NOT NULL,
  `data_wypozyczenia` date NOT NULL,
  `data_oddania` date NOT NULL,
  PRIMARY KEY (`id_wypozyczenia`),
  UNIQUE KEY `id_wypozyczenia_UNIQUE` (`id_wypozyczenia`),
  KEY `fk_ksiazka_idx` (`ksiazka_id`),
  KEY `fk_czytelnik_idx` (`czytelnik_id`),
  CONSTRAINT `fk_czytelnik` FOREIGN KEY (`czytelnik_id`) REFERENCES `czytelnicy` (`id_czytelnicy`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_ksiazka` FOREIGN KEY (`ksiazka_id`) REFERENCES `ksiazki` (`id_ksiazki`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wypozyczenia`
--

LOCK TABLES `wypozyczenia` WRITE;
/*!40000 ALTER TABLE `wypozyczenia` DISABLE KEYS */;
INSERT INTO `wypozyczenia` VALUES (1,22,3,'zwrócono','2022-06-08','2022-07-06'),(2,56,5,'zgubiono','2022-06-08','2022-07-14'),(3,50,8,'wypożyczono','2022-06-08','2022-07-14'),(4,48,2,'wypożyczono','2022-06-08','2022-07-14'),(5,30,1,'wypożyczono','2022-07-02','2022-07-07');
/*!40000 ALTER TABLE `wypozyczenia` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-04  4:32:31
