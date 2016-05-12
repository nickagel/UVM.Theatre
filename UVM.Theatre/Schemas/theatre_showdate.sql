CREATE DATABASE  IF NOT EXISTS `theatre` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `theatre`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win32 (AMD64)
--
-- Host: localhost    Database: theatre
-- ------------------------------------------------------
-- Server version	5.7.12-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `showdate`
--

DROP TABLE IF EXISTS `showdate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `showdate` (
  `dateId` int(11) NOT NULL AUTO_INCREMENT,
  `date` date DEFAULT NULL,
  `showId` int(11) NOT NULL,
  `time` time NOT NULL,
  `regularPrice` decimal(10,0) NOT NULL,
  `studentPrice` decimal(10,0) NOT NULL,
  `seniorPrice` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`dateId`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `showdate`
--

LOCK TABLES `showdate` WRITE;
/*!40000 ALTER TABLE `showdate` DISABLE KEYS */;
INSERT INTO `showdate` VALUES (1,'2015-10-01',1,'19:30:00',0,0,NULL),(2,'2015-10-02',1,'19:30:00',0,0,NULL),(3,'2015-10-03',1,'19:30:00',0,0,NULL),(4,'2015-10-08',1,'19:30:00',0,0,NULL),(5,'2015-10-09',1,'19:30:00',0,0,NULL),(6,'2015-10-03',1,'14:00:00',0,0,NULL),(7,'2015-10-11',1,'14:00:00',0,0,NULL),(8,'2015-11-05',2,'19:30:00',0,0,NULL),(9,'2015-11-06',2,'19:30:00',0,0,NULL),(10,'2015-11-07',2,'19:30:00',0,0,NULL),(11,'2015-11-07',2,'14:00:00',0,0,NULL),(12,'2015-11-15',2,'14:00:00',0,0,NULL),(13,'2015-11-12',2,'19:30:00',0,0,NULL),(14,'2015-11-13',2,'19:30:00',0,0,NULL),(15,'2015-11-14',2,'19:30:00',0,0,NULL),(16,'2015-12-05',3,'10:00:00',0,0,NULL),(17,'2015-12-05',3,'14:00:00',0,0,NULL),(18,'2015-12-05',3,'18:00:00',0,0,NULL),(19,'2015-12-06',3,'10:00:00',0,0,NULL),(20,'2015-12-06',3,'14:00:00',0,0,NULL),(21,'2015-12-06',3,'18:00:00',0,0,NULL),(22,'2016-02-24',4,'19:30:00',0,0,NULL),(23,'2016-02-28',4,'19:30:00',0,0,NULL),(24,'2016-02-27',4,'14:00:00',0,0,NULL),(25,'2016-02-28',4,'14:00:00',0,0,NULL);
/*!40000 ALTER TABLE `showdate` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-12 13:44:37
