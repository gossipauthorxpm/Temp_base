-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: temp_base
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `abonent`
--

DROP TABLE IF EXISTS `abonent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `abonent` (
  `id` int NOT NULL,
  `FIO_SUBCRIBER` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `REP` int NOT NULL,
  `ADDRESS` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `DATE_LAST_TRASACTION` date DEFAULT NULL,
  `SUM_AMOUTH` double DEFAULT NULL,
  `money_fold` int DEFAULT NULL,
  PRIMARY KEY (`id`,`REP`),
  UNIQUE KEY `money_fold` (`money_fold`),
  CONSTRAINT `abonent_ibfk_1` FOREIGN KEY (`money_fold`) REFERENCES `build` (`money_fold`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `abonent`
--

LOCK TABLES `abonent` WRITE;
/*!40000 ALTER TABLE `abonent` DISABLE KEYS */;
INSERT INTO `abonent` VALUES (1,'Сапожников Владислав Валерьевич',30,'Ул Суворова 10','2003-09-11',100000,1),(2,'Цибранков Михаил Романович',60,'Ул Попова 29','2004-11-30',15000000,2),(3,'Степаненко Михаил Петрович',90,'Ул Разлова 11','2008-09-11',1000,3),(4,'Олифчук Светлана Филадельфовна',1020,'ул Понасенкова 14','2012-12-12',2000,4),(5,'Гаврилова Дарья Егоровна',50,'Ул Вакуленчука 20','2009-11-03',9000,5),(6,'Ульянова Яна Кирилловна',50,'Ул Папанина 12','2012-06-18',65100,6),(7,'Михайлов Фёдор Львович',80,'Ул Папанина 10','2020-11-11',977,7),(8,'Прохоров Даниил Артёмович',70,'Ул Суворова 19','2020-04-27',60500,8),(9,'Колесова Кира Данииловна',33,'Ул Должникова 12','2003-11-11',2000,9),(10,'Цветков Захар Камильевич',30,'Ул Цветкова 14','2001-11-14',50000,10),(11,'Семенов Константин Миронович',55,'Ул Прохорова 18','2005-08-29',5000,11),(12,'Терехов Михаил Лукич ',40,'Ул Вакуленчука 11','2009-08-10',45000,12),(13,'Сизова София Викторовна',30,'Ул Качалкина 9','1999-11-01',495000,13),(14,'Семенов Константин Миронович',90,'Ул Вздорова 18','2002-10-10',50499,14),(15,'Иванова Алиса Дмитриевна',77,'Ул Вакуленчука 121','2006-04-08',30000,15),(16,'Пономарева Александра Львовна',45,'Ул Жириновского 1','2015-06-06',90000,16),(17,'Пономарева Александра Львовна',30,'Ул Вакуленчука 30','2005-04-30',54000,17),(18,'Крючкова Александра Константиновна',45,'Ул Вакуленчука 13','2007-07-07',49499,18),(19,'Андреев Михаил Тимофеевич',40,'Ул Пожарова 39','2009-09-04',5000,19),(20,'Шаров Олег Максимович',30,'Ул Задорнова 10','2015-12-01',304000,20),(21,'Рустенко Евгений Олегович',60,'Улица Пожарова 17','2001-12-12',50000,NULL);
/*!40000 ALTER TABLE `abonent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `build`
--

DROP TABLE IF EXISTS `build`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `build` (
  `FIO_CHIEF` varchar(100) DEFAULT NULL,
  `HEAT_FOR_MOUNTH` int DEFAULT NULL,
  `COF_HEAT` double DEFAULT NULL,
  `abonent_id` int NOT NULL,
  `abonent_REP` int NOT NULL,
  `money_fold` int DEFAULT NULL,
  UNIQUE KEY `money_fold` (`money_fold`),
  KEY `fk_build_abonent_idx` (`abonent_id`,`abonent_REP`),
  CONSTRAINT `fk_build_abonent` FOREIGN KEY (`abonent_id`, `abonent_REP`) REFERENCES `abonent` (`id`, `REP`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `build`
--

LOCK TABLES `build` WRITE;
/*!40000 ALTER TABLE `build` DISABLE KEYS */;
INSERT INTO `build` VALUES ('Куртенко Алишер Сабурович',2000,3000,1,30,1),('Куртенко Алишер Сабурович',2030,3120,2,60,2),('Мекмамбетов Мекмабед Угуля',300,100,3,90,3),('Мекмамбетов Мекмабед Угуля',6000,800,4,1020,4),('Мекмамбетов Мекмабед Угуля',4500,600,5,50,5),('Куртенко Алишер Сабурович',400,10000,6,50,6),('Мекмамбетов Мекмабед Угуля',90000,10,7,80,7),('Куртенко Алишер Сабурович',750,620,8,70,8),('Симтавлаев Урслан Алихович',4098,850,9,33,9),('Симтавлаев Урслан Алихович',922,963,10,30,10),('Мекмамбетов Мекмабед Угуля',1774,7015,11,55,11),('Симтавлаев Урслан Алихович',852,805,12,40,12),('Мекмамбетов Мекмабед Угуля',963,963,13,30,13),('Симтавлаев Урслан Алихович',400,8000,14,90,14),('Симтавлаев Урслан Алихович',870,6120,15,77,15),('Мекмамбетов Мекмабед Угуля',9000,9700,16,45,16),('Симтавлаев Урслан Алихович',6500,822,17,30,17),('Куртенко Алишер Сабурович',3650,624,18,45,18),('Куртенко Алишер Сабурович',9780,789,19,40,19),('Куртенко Алишер Сабурович',1704,6000,20,30,20),('Симтавлаев Урслан Алихович',1020,1500,21,60,NULL),('Куртенко Алишер Сабурович',1020,1500,21,60,NULL);
/*!40000 ALTER TABLE `build` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-25 13:31:48
