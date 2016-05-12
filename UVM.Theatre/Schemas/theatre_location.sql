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
-- Table structure for table `location`
--

DROP TABLE IF EXISTS `location`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `location` (
  `locationId` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `imageUrl` varchar(255) DEFAULT NULL,
  `googleMapUrl` varchar(1000) DEFAULT NULL,
  `description` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`locationId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `location`
--

LOCK TABLES `location` WRITE;
/*!40000 ALTER TABLE `location` DISABLE KEYS */;
INSERT INTO `location` VALUES (1,'Royal Tyler Theatre','http://nagel.w3.uvm.edu/theatre/imgs/miniIndex.png','https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2846.842781987515!2d-73.20017288444936!3d44.4773952791016!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4cca7af821ccf30f%3A0x6241990581cd1c83!2sRoyall+Tyler+Theatre!5e0!3m2!1sen!2sus!4v1455080944332','The Royall Tyler Theatre owes its existence to a providential fire which in 1886 demolished the University\'s ramshackle gymnasium. By 1898, students and faculty hotly protested the lack of physical facilities at UVM, so the next year President Matthew Henry Buckham reported that for $20,000 a very plain gymnasium could be provided. A site next to the Old Mill was selected in 1900.'),(2,'Parking','http://nagel.w3.uvm.edu/theatre/imgs/miniIndex.png','https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d488.92096269882876!2d-73.20239032881418!3d44.47832539849981!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4cca7a5beeaf827f%3A0x7ffeed5fea2eed3b!2sWaterman+Bldg%2C+85+S+Prospect+St%2C+Burlington%2C+VT+05401!5e0!3m2!1sen!2sus!4v1460957780688','The Royall Tyler Theatre owes its existence to a providential fire which in 1886 demolished the University\'s ramshackle gymnasium. By 1898, students and faculty hotly protested the lack of physical facilities at UVM, so the next year President Matthew Henry Buckham reported that for $20,000 a very plain gymnasium could be provided. A site next to the Old Mill was selected in 1900. ');
/*!40000 ALTER TABLE `location` ENABLE KEYS */;
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
