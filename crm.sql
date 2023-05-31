-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: crm
-- ------------------------------------------------------
-- Server version	8.0.18

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
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20200302095100_initial','2.2.6-servicing-10079');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroleclaims`
--

DROP TABLE IF EXISTS `aspnetroleclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroleclaims`
--

LOCK TABLES `aspnetroleclaims` WRITE;
/*!40000 ALTER TABLE `aspnetroleclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroleclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroles`
--

DROP TABLE IF EXISTS `aspnetroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetroles` (
  `Id` varchar(767) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` text,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
INSERT INTO `aspnetroles` VALUES ('1','admin','admin','admin'),('2','user','user','user');
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserclaims`
--

DROP TABLE IF EXISTS `aspnetuserclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserclaims`
--

LOCK TABLES `aspnetuserclaims` WRITE;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserlogins`
--

DROP TABLE IF EXISTS `aspnetuserlogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(767) NOT NULL,
  `ProviderKey` varchar(767) NOT NULL,
  `ProviderDisplayName` text,
  `UserId` varchar(767) NOT NULL,
  KEY `IX_AspNetUserLogins_UserId` (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserlogins`
--

LOCK TABLES `aspnetuserlogins` WRITE;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserroles`
--

DROP TABLE IF EXISTS `aspnetuserroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(767) NOT NULL,
  `RoleId` varchar(767) NOT NULL,
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
INSERT INTO `aspnetuserroles` VALUES ('2da1370d-7b9a-4836-b2c5-e3e1046641cc','1'),('9f765c13-fba7-406d-bb7e-cb194e6754b3','2');
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusers`
--

DROP TABLE IF EXISTS `aspnetusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetusers` (
  `Id` varchar(767) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` int(11) NOT NULL,
  `PasswordHash` text,
  `SecurityStamp` text,
  `ConcurrencyStamp` text,
  `PhoneNumber` text,
  `PhoneNumberConfirmed` int(11) NOT NULL,
  `TwoFactorEnabled` int(11) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` int(11) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `FirstName` text,
  `LastName` text,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
INSERT INTO `aspnetusers` VALUES ('2da1370d-7b9a-4836-b2c5-e3e1046641cc','dkraval07@gmail.com','DKRAVAL07@GMAIL.COM','dkraval07@gmail.com','DKRAVAL07@GMAIL.COM',0,'AQAAAAEAACcQAAAAEFZIsjY2TECaYFeyPkzVh3Cha2fK2nUBtRm9WC3zV1zS4dVCVePFoeZObwx89xqKLA==','N5YZXE4NTOT2Y32JLN2WF57W5OTKAOUR','6b81b1c6-bd42-426f-9505-e1c36485bf97',NULL,0,0,NULL,1,0,'dhruvin','raval'),('9f765c13-fba7-406d-bb7e-cb194e6754b3','user@gmail.com','USER@GMAIL.COM','user@gmail.com','USER@GMAIL.COM',0,'AQAAAAEAACcQAAAAEEToIzM62mspLnDGt1tYbyUz8sIDB634xAmhMaYRMOpDuY2bNjb4Io4aLGm+JgTTGA==','ZEON6OIRKH7NBQZIWBAXJSWMNYNJ7PSM','f9b40275-3401-4d77-9a7b-fc587845159c',NULL,0,0,NULL,1,0,'Pranav','Sharma');
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusertokens`
--

DROP TABLE IF EXISTS `aspnetusertokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(767) NOT NULL,
  `LoginProvider` varchar(767) NOT NULL,
  `Name` varchar(767) NOT NULL,
  `Value` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusertokens`
--

LOCK TABLES `aspnetusertokens` WRITE;
/*!40000 ALTER TABLE `aspnetusertokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetusertokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iv_linkname`
--

DROP TABLE IF EXISTS `iv_linkname`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iv_linkname` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `ImgOrVideo` char(1) DEFAULT NULL,
  `BriefName` varchar(100) DEFAULT NULL,
  `ImgVideoPath` varchar(250) DEFAULT NULL,
  `ForTime` int(11) DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iv_linkname`
--

LOCK TABLES `iv_linkname` WRITE;
/*!40000 ALTER TABLE `iv_linkname` DISABLE KEYS */;
/*!40000 ALTER TABLE `iv_linkname` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_area`
--

DROP TABLE IF EXISTS `mst_area`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_area` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Mst_District_SrNo` int(11) DEFAULT NULL,
  `AreaName` varchar(100) DEFAULT NULL,
  `ZIPCode` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `frn_mst_district_srno_idx` (`Mst_District_SrNo`),
  CONSTRAINT `frn_mst_district_srno` FOREIGN KEY (`Mst_District_SrNo`) REFERENCES `mst_district` (`SrNo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_area`
--

LOCK TABLES `mst_area` WRITE;
/*!40000 ALTER TABLE `mst_area` DISABLE KEYS */;
INSERT INTO `mst_area` VALUES (8,8,'Tadwadi','395010'),(9,7,'maninagar','351268'),(11,7,'test','789654');
/*!40000 ALTER TABLE `mst_area` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_bank`
--

DROP TABLE IF EXISTS `mst_bank`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_bank` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `BankName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_bank`
--

LOCK TABLES `mst_bank` WRITE;
/*!40000 ALTER TABLE `mst_bank` DISABLE KEYS */;
INSERT INTO `mst_bank` VALUES (1,'Yes Bank');
/*!40000 ALTER TABLE `mst_bank` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_country`
--

DROP TABLE IF EXISTS `mst_country`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_country` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `CountryName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_country`
--

LOCK TABLES `mst_country` WRITE;
/*!40000 ALTER TABLE `mst_country` DISABLE KEYS */;
INSERT INTO `mst_country` VALUES (6,'Japan'),(7,'Germany'),(9,'Pakistan'),(10,'America'),(11,'Zimbaway'),(19,'uganda'),(20,'Argentina'),(23,'India'),(28,'urugway'),(29,'Afghanistan'),(30,'New Zealand'),(31,'test'),(32,'Kazakhstan');
/*!40000 ALTER TABLE `mst_country` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_department`
--

DROP TABLE IF EXISTS `mst_department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_department` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Department` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_department`
--

LOCK TABLES `mst_department` WRITE;
/*!40000 ALTER TABLE `mst_department` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_designation`
--

DROP TABLE IF EXISTS `mst_designation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_designation` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Designation` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_designation`
--

LOCK TABLES `mst_designation` WRITE;
/*!40000 ALTER TABLE `mst_designation` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_designation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_district`
--

DROP TABLE IF EXISTS `mst_district`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_district` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Mst_State_SrNo` int(11) DEFAULT NULL,
  `DistrictName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `frn_mst_state_srno_idx` (`Mst_State_SrNo`),
  CONSTRAINT `frn_mst_state_srno` FOREIGN KEY (`Mst_State_SrNo`) REFERENCES `mst_state` (`SrNo`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_district`
--

LOCK TABLES `mst_district` WRITE;
/*!40000 ALTER TABLE `mst_district` DISABLE KEYS */;
INSERT INTO `mst_district` VALUES (7,1,'Ahmedabad'),(8,1,'Surat'),(9,1,'Vadodara'),(10,1,'Anand');
/*!40000 ALTER TABLE `mst_district` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_doctag`
--

DROP TABLE IF EXISTS `mst_doctag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_doctag` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `DocTagName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_doctag`
--

LOCK TABLES `mst_doctag` WRITE;
/*!40000 ALTER TABLE `mst_doctag` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_doctag` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_empdeptreview`
--

DROP TABLE IF EXISTS `mst_empdeptreview`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_empdeptreview` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `DisplayOrder` float DEFAULT NULL,
  `Mst_Dept_SrNo` int(11) DEFAULT NULL,
  `Mst_EmployeeReview_SrNo` int(11) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `Mst_Dept_SrNo_idx` (`Mst_Dept_SrNo`),
  KEY `Mst_EmployeeReview_SrNo_idx` (`Mst_EmployeeReview_SrNo`),
  CONSTRAINT `Mst_Dept_SrNo` FOREIGN KEY (`Mst_Dept_SrNo`) REFERENCES `mst_department` (`SrNo`),
  CONSTRAINT `Mst_EmployeeReview_SrNo` FOREIGN KEY (`Mst_EmployeeReview_SrNo`) REFERENCES `mst_employeereview` (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_empdeptreview`
--

LOCK TABLES `mst_empdeptreview` WRITE;
/*!40000 ALTER TABLE `mst_empdeptreview` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_empdeptreview` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_employeereview`
--

DROP TABLE IF EXISTS `mst_employeereview`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_employeereview` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `ReviewName` varchar(100) DEFAULT NULL,
  `Points` float DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_employeereview`
--

LOCK TABLES `mst_employeereview` WRITE;
/*!40000 ALTER TABLE `mst_employeereview` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_employeereview` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_holidays`
--

DROP TABLE IF EXISTS `mst_holidays`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_holidays` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `ForYear` int(11) DEFAULT NULL,
  `HolidayName` varchar(100) DEFAULT NULL,
  `Type` char(1) DEFAULT NULL,
  `ForDate` date DEFAULT NULL,
  `PartialWorking` char(1) DEFAULT NULL,
  `StartTime` time DEFAULT NULL,
  `OffTime` time DEFAULT NULL,
  `Remark` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_holidays`
--

LOCK TABLES `mst_holidays` WRITE;
/*!40000 ALTER TABLE `mst_holidays` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_holidays` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_note`
--

DROP TABLE IF EXISTS `mst_note`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_note` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `NoteName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_note`
--

LOCK TABLES `mst_note` WRITE;
/*!40000 ALTER TABLE `mst_note` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_note` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_perks`
--

DROP TABLE IF EXISTS `mst_perks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_perks` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `PerksType` int(11) DEFAULT NULL,
  `AllowType` int(11) DEFAULT NULL,
  `DisplaySeq` float DEFAULT NULL,
  `PerkName` varchar(100) DEFAULT NULL,
  `MinPerk` int(11) DEFAULT NULL,
  `PerkPer` float DEFAULT NULL,
  `FixPer` float DEFAULT NULL,
  `CalculatedOn` int(11) DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_perks`
--

LOCK TABLES `mst_perks` WRITE;
/*!40000 ALTER TABLE `mst_perks` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_perks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_ppmodules`
--

DROP TABLE IF EXISTS `mst_ppmodules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_ppmodules` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Mst_ProductPrice_SrNo` int(11) DEFAULT NULL,
  `Mst_Product_Module_SrNo` int(11) DEFAULT NULL,
  `PriceConsidered` float DEFAULT NULL,
  `Remark` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `frn_ppm_pp_idx` (`Mst_ProductPrice_SrNo`),
  KEY `frn_ppm_module_idx` (`Mst_Product_Module_SrNo`),
  CONSTRAINT `frn_ppm_module` FOREIGN KEY (`Mst_Product_Module_SrNo`) REFERENCES `mst_product_module` (`SrNo`),
  CONSTRAINT `frn_ppm_pp` FOREIGN KEY (`Mst_ProductPrice_SrNo`) REFERENCES `mst_productprice` (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_ppmodules`
--

LOCK TABLES `mst_ppmodules` WRITE;
/*!40000 ALTER TABLE `mst_ppmodules` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_ppmodules` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_product`
--

DROP TABLE IF EXISTS `mst_product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_product` (
  `SrNO` int(11) NOT NULL AUTO_INCREMENT,
  `Status` char(1) DEFAULT NULL,
  `ProductName` varchar(100) DEFAULT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `Mst_ProductCategory_SrNo` int(11) DEFAULT NULL,
  `Mst_ProductSubCategory_SrNo` int(11) DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `VideoLinkMkt` int(11) DEFAULT NULL,
  `VideoLinkSupport` int(11) DEFAULT NULL,
  `VideoLinkCustomer` int(11) DEFAULT NULL,
  `Remark` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`SrNO`),
  KEY `mst_procat_srno_idx` (`Mst_ProductCategory_SrNo`),
  KEY `mst_prossubcat_srno_idx` (`Mst_ProductSubCategory_SrNo`),
  KEY `frn_mst_video_mkt_idx` (`VideoLinkMkt`),
  KEY `frn_mst_video_support_idx` (`VideoLinkSupport`),
  KEY `frn_mst_video_customer_idx` (`VideoLinkCustomer`),
  CONSTRAINT `frn_mst_video_customer` FOREIGN KEY (`VideoLinkCustomer`) REFERENCES `iv_linkname` (`SrNo`),
  CONSTRAINT `frn_mst_video_mkt` FOREIGN KEY (`VideoLinkMkt`) REFERENCES `iv_linkname` (`SrNo`),
  CONSTRAINT `frn_mst_video_support` FOREIGN KEY (`VideoLinkSupport`) REFERENCES `iv_linkname` (`SrNo`),
  CONSTRAINT `mst_procat_srno` FOREIGN KEY (`Mst_ProductCategory_SrNo`) REFERENCES `mst_productcategory` (`SrNo`),
  CONSTRAINT `mst_prossubcat_srno` FOREIGN KEY (`Mst_ProductSubCategory_SrNo`) REFERENCES `mst_productsubcategory` (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_product`
--

LOCK TABLES `mst_product` WRITE;
/*!40000 ALTER TABLE `mst_product` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_product_module`
--

DROP TABLE IF EXISTS `mst_product_module`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_product_module` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Mst_Product_SrNo` int(11) DEFAULT NULL,
  `Status` char(1) DEFAULT NULL,
  `ModuleName` varchar(100) DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `VideoLinkMkt` int(11) DEFAULT NULL,
  `VideoLinkSupport` int(11) DEFAULT NULL,
  `VideoLinkCustomer` int(11) DEFAULT NULL,
  `Remark` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `frn_product_srno_idx` (`Mst_Product_SrNo`),
  KEY `frn_mod_video_mkt_idx` (`VideoLinkMkt`),
  KEY `frn_mod_Video_Support_idx` (`VideoLinkSupport`),
  KEY `frn_mod_Video_customer_idx` (`VideoLinkCustomer`),
  CONSTRAINT `frn_mod_Video_Support` FOREIGN KEY (`VideoLinkSupport`) REFERENCES `iv_linkname` (`SrNo`),
  CONSTRAINT `frn_mod_Video_customer` FOREIGN KEY (`VideoLinkCustomer`) REFERENCES `iv_linkname` (`SrNo`),
  CONSTRAINT `frn_mod_video_mkt` FOREIGN KEY (`VideoLinkMkt`) REFERENCES `iv_linkname` (`SrNo`),
  CONSTRAINT `frn_product_srno` FOREIGN KEY (`Mst_Product_SrNo`) REFERENCES `mst_product` (`SrNO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_product_module`
--

LOCK TABLES `mst_product_module` WRITE;
/*!40000 ALTER TABLE `mst_product_module` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_product_module` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_productcategory`
--

DROP TABLE IF EXISTS `mst_productcategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_productcategory` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Status` char(1) DEFAULT NULL,
  `ProductCategory` varchar(50) DEFAULT NULL,
  `IV_LinkName_SrNo` int(11) DEFAULT NULL,
  `Remark` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `IV_LinkName_SrNo_idx` (`IV_LinkName_SrNo`),
  CONSTRAINT `IV_LinkName_SrNo` FOREIGN KEY (`IV_LinkName_SrNo`) REFERENCES `iv_linkname` (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_productcategory`
--

LOCK TABLES `mst_productcategory` WRITE;
/*!40000 ALTER TABLE `mst_productcategory` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_productcategory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_productprice`
--

DROP TABLE IF EXISTS `mst_productprice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_productprice` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Mst_Product_SrNo` int(11) DEFAULT NULL,
  `RevisedDate` date DEFAULT NULL,
  `ProductPrice` float DEFAULT NULL,
  `AMCPrice` float DEFAULT NULL,
  `Remark` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `frn_product_price_idx` (`Mst_Product_SrNo`),
  CONSTRAINT `frn_product_price` FOREIGN KEY (`Mst_Product_SrNo`) REFERENCES `mst_product` (`SrNO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_productprice`
--

LOCK TABLES `mst_productprice` WRITE;
/*!40000 ALTER TABLE `mst_productprice` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_productprice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_productsubcategory`
--

DROP TABLE IF EXISTS `mst_productsubcategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_productsubcategory` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Status` char(1) DEFAULT NULL,
  `Mst_ProductCategory_SrNo` int(11) DEFAULT NULL,
  `ProductSubCategoryName` varchar(50) DEFAULT NULL,
  `IV_LinkName_SrNo` int(11) DEFAULT NULL,
  `Remark` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `Mst_ProductCategory_SrNo_idx` (`Mst_ProductCategory_SrNo`),
  KEY `IV_LinkName_SrNo_idx` (`IV_LinkName_SrNo`),
  CONSTRAINT `IV_LinkName_psc_SrNo` FOREIGN KEY (`IV_LinkName_SrNo`) REFERENCES `iv_linkname` (`SrNo`),
  CONSTRAINT `Mst_ProductCategory_psc_SrNo` FOREIGN KEY (`Mst_ProductCategory_SrNo`) REFERENCES `mst_productcategory` (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_productsubcategory`
--

LOCK TABLES `mst_productsubcategory` WRITE;
/*!40000 ALTER TABLE `mst_productsubcategory` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_productsubcategory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_productversion`
--

DROP TABLE IF EXISTS `mst_productversion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_productversion` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Mst_Product_SrNo` int(11) DEFAULT NULL,
  `VersionName` varchar(50) DEFAULT NULL,
  `VersionCode` varchar(20) DEFAULT NULL,
  `VersionReleaseDate` date DEFAULT NULL,
  `BriefVideoLink` int(11) DEFAULT NULL,
  `Remark` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `frn_product_ver_idx` (`Mst_Product_SrNo`),
  KEY `frn_brief_video_idx` (`BriefVideoLink`),
  CONSTRAINT `frn_brief_video` FOREIGN KEY (`BriefVideoLink`) REFERENCES `iv_linkname` (`SrNo`),
  CONSTRAINT `frn_product_ver` FOREIGN KEY (`Mst_Product_SrNo`) REFERENCES `mst_product` (`SrNO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_productversion`
--

LOCK TABLES `mst_productversion` WRITE;
/*!40000 ALTER TABLE `mst_productversion` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_productversion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_pvchanges`
--

DROP TABLE IF EXISTS `mst_pvchanges`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_pvchanges` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Mst_ProductVerSrNo` int(11) DEFAULT NULL,
  `Mst_Product_Module_SrNo` int(11) DEFAULT NULL,
  `WhatChanges` varchar(250) DEFAULT NULL,
  `VideoLink` int(11) DEFAULT NULL,
  `Remark` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `frn_pvc_product_idx` (`Mst_ProductVerSrNo`),
  KEY `frn_pmodule_idx` (`Mst_Product_Module_SrNo`),
  KEY `frn_VideoLink_idx` (`VideoLink`),
  CONSTRAINT `frn_VideoLink` FOREIGN KEY (`VideoLink`) REFERENCES `iv_linkname` (`SrNo`),
  CONSTRAINT `frn_pmodule` FOREIGN KEY (`Mst_Product_Module_SrNo`) REFERENCES `mst_product_module` (`SrNo`),
  CONSTRAINT `frn_pvc_productversion` FOREIGN KEY (`Mst_ProductVerSrNo`) REFERENCES `mst_productversion` (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_pvchanges`
--

LOCK TABLES `mst_pvchanges` WRITE;
/*!40000 ALTER TABLE `mst_pvchanges` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_pvchanges` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_regchild`
--

DROP TABLE IF EXISTS `mst_regchild`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_regchild` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Mst_Region_SrNo` int(11) DEFAULT NULL,
  `Mst_State_SrNo` int(11) DEFAULT NULL,
  `Mst_District_SrNo` int(11) DEFAULT NULL,
  `Mst_Area_SrNo` int(11) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `frn_mst_reg_Srno_idx` (`Mst_Region_SrNo`),
  KEY `frn_mst_st_srno_idx` (`Mst_State_SrNo`),
  KEY `frn_mst_dst_srno_idx` (`Mst_District_SrNo`),
  KEY `frn_mst_area_idx` (`Mst_Area_SrNo`),
  CONSTRAINT `frn_mst_area` FOREIGN KEY (`Mst_Area_SrNo`) REFERENCES `mst_area` (`SrNo`),
  CONSTRAINT `frn_mst_dst_srno` FOREIGN KEY (`Mst_District_SrNo`) REFERENCES `mst_district` (`SrNo`),
  CONSTRAINT `frn_mst_reg_Srno` FOREIGN KEY (`Mst_Region_SrNo`) REFERENCES `mst_region` (`SrNo`),
  CONSTRAINT `frn_mst_st_srno` FOREIGN KEY (`Mst_State_SrNo`) REFERENCES `mst_state` (`SrNo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_regchild`
--

LOCK TABLES `mst_regchild` WRITE;
/*!40000 ALTER TABLE `mst_regchild` DISABLE KEYS */;
INSERT INTO `mst_regchild` VALUES (1,2,1,8,8);
/*!40000 ALTER TABLE `mst_regchild` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_region`
--

DROP TABLE IF EXISTS `mst_region`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_region` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `RegionName` varchar(100) DEFAULT NULL,
  `Remark` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_region`
--

LOCK TABLES `mst_region` WRITE;
/*!40000 ALTER TABLE `mst_region` DISABLE KEYS */;
INSERT INTO `mst_region` VALUES (1,'west Zone','asd'),(2,'East Zone','East Zone');
/*!40000 ALTER TABLE `mst_region` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_relationship`
--

DROP TABLE IF EXISTS `mst_relationship`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_relationship` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Relationship` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_relationship`
--

LOCK TABLES `mst_relationship` WRITE;
/*!40000 ALTER TABLE `mst_relationship` DISABLE KEYS */;
/*!40000 ALTER TABLE `mst_relationship` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mst_state`
--

DROP TABLE IF EXISTS `mst_state`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_state` (
  `SrNo` int(11) NOT NULL AUTO_INCREMENT,
  `Mst_Country_SrNo` int(11) DEFAULT NULL,
  `StateName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`SrNo`),
  KEY `frn_mst_Country_SrNo_idx` (`Mst_Country_SrNo`),
  CONSTRAINT `frn_mst_Country_SrNo` FOREIGN KEY (`Mst_Country_SrNo`) REFERENCES `mst_country` (`SrNo`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_state`
--

LOCK TABLES `mst_state` WRITE;
/*!40000 ALTER TABLE `mst_state` DISABLE KEYS */;
INSERT INTO `mst_state` VALUES (1,23,'Gujarat'),(3,10,'New York'),(6,6,'Gujarat');
/*!40000 ALTER TABLE `mst_state` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'crm'
--
/*!50003 DROP PROCEDURE IF EXISTS `proc_iv_linkname_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_iv_linkname_delete`(p_SrNo int)
BEGIN
Delete From iv_linkname where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_iv_linkname_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_iv_linkname_getall`(
 in keyword varchar(50),
 in sortorder int,
 in pagenumber int,
 in pagesize int,
 out totalrecords int
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
ImgOrVideo char(1),
BriefName varchar(100), 
ImgVideoPath varchar(250),
ForTime int
);
insert into temp(SrNo,ImgOrVideo,BriefName,ImgVideoPath,ForTime)
select m.SrNo,m.ImgOrVideo,m.BriefName,m.ImgVideoPath,m.ForTime from iv_linkname as m where (
v_lockeyword = '%%'
or m.BriefName like v_lockeyword
)
order by
case when v_locsortorder = 11 then m.ImgOrVideo end asc,
case when v_locsortorder = 12 then m.ImgOrVideo end desc,
case when v_locsortorder = 21 then m.BriefName end asc,
case when v_locsortorder = 22 then m.BriefName end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_iv_linkname_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_iv_linkname_getbyid`(p_SrNo int)
BEGIN
select * From iv_linkname where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_iv_linkname_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_iv_linkname_insertupdate`(
p_SrNo int,
p_ImgOrVideo char(1),
p_BriefName varchar(100),
p_ImgVideoPath varchar(250),
p_ForTime int
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
IF EXISTS(SELECT 'True' FROM iv_linkname WHERE BriefName Like p_BriefName or ImgVideoPath Like p_ImgVideoPath)
then
	Select -1;
else
INSERT INTO iv_linkname
(SrNo,
ImgOrVideo,
BriefName,
ImgVideoPath,
ForTime)
VALUES
(p_SrNo,
p_ImgOrVideo,
p_BriefName,
p_ImgVideoPath,
p_ForTime
);
select last_insert_id();
end if;
ELSE
IF EXISTS(SELECT 'True' FROM iv_linkname WHERE (BriefName Like p_BriefName or ImgVideoPath Like p_ImgVideoPath) and SrNo != p_SrNo )
then
	Select -1;
else
UPDATE iv_linkname
SET
SrNo = p_SrNo,
ImgOrVideo = p_ImgOrVideo,
BriefName = p_BriefName,
ImgVideoPath = p_ImgVideoPath,
ForTime = p_ForTime
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_area_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_area_delete`(p_SrNo int)
BEGIN
Delete From mst_area where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_area_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_area_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int ,Mst_District_SrNo int,
AreaName varchar(100),ZIPCode varchar(10)
);
insert into temp(SrNo,Mst_District_SrNo,AreaName,ZIPCode)
select m.SrNo,m.Mst_District_SrNo,m.AreaName,m.ZIPCode from mst_area as m where (
v_lockeyword = '%%'
or m.AreaName like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.AreaName end asc,
case when v_locsortorder = 22 then m.AreaName end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_area_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_area_getbyid`(p_SrNo int)
BEGIN
select * From mst_area where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_area_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_area_insertupdate`(
p_SrNo int,
p_Mst_District_SrNo int,
p_AreaName varchar(100),
p_ZIPCode varchar(10)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_area where AreaName=P_AreaName or ZIPCode=p_ZIPCode)then
INSERT INTO mst_area
(SrNo,
Mst_District_SrNo,
AreaName,
ZIPCode)
VALUES
(p_SrNo,
p_Mst_District_SrNo,
p_AreaName,
p_ZIPCode
);
select last_insert_id();
 ELSE
 select -1;
 end if ;
 else
 if not exists(select * from mst_area where (AreaName=p_AreaName or ZIPCode=p_ZIPCode) and SrNo!=P_SrNo)then

UPDATE mst_area
SET
SrNo = p_SrNo,
Mst_District_SrNo = p_Mst_District_SrNo,
AreaName = p_AreaName,
ZIPCode = p_ZIPCode
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_bank_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_bank_delete`(p_SrNo int)
BEGIN
Delete From mst_bank where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_bank_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_bank_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
BankName varchar(100)
);
insert into temp(SrNo,BankName)
select m.SrNo,m.BankName from mst_bank as m where (
v_lockeyword = '%%'
or m.BankName like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.BankName end asc,
case when v_locsortorder = 22 then m.BankName end desc;
 
select count(*) into totalrecords from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_bank_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_bank_getbyid`(p_SrNo int)
BEGIN
select * From mst_bank where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_bank_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_bank_insertupdate`(
p_SrNo int,
p_BankName varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_bank where BankName = p_BankName)
then

INSERT INTO mst_bank
(SrNo,
BankName)
VALUES
(p_SrNo,
p_BankName
);
select last_insert_id();
else
select -1;
end if;
 ELSE

if not exists(select * from mst_bank where BankName=p_BankName and SrNo != p_SrNo)
then

UPDATE mst_bank
SET
SrNo = p_SrNo,
BankName = p_BankName
WHERE SrNo = p_SrNo;

SELECT p_SrNo;

else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_country_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_country_delete`(p_SrNo int)
BEGIN
Delete From mst_country where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_country_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_country_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
CountryName varchar(100)
);
insert into temp(SrNo,CountryName)
select m.SrNo,m.CountryName from mst_country as m where (
v_lockeyword = '%%'
or m.CountryName like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.CountryName end asc,
case when v_locsortorder = 22 then m.CountryName end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_country_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_country_getbyid`(p_SrNo int)
BEGIN
select * From mst_country where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_country_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_country_insertupdate`(
p_SrNo int,
p_CountryName varchar(100)
)
BEGIN
if(p_SrNo =0 or p_SrNo is null)
then
if not exists(select * from mst_country where CountryName=P_CountryName)then
INSERT INTO `crm`.`mst_country`
(`SrNo`,
`CountryName`)
VALUES
(p_SrNo,
p_CountryName
);
select last_insert_id();
else
select -1;
end if;
else
if not exists(select * from mst_country where CountryName=P_CountryName and SrNo!=P_SrNo)then
UPDATE mst_country
SET
SrNo = p_SrNo,
CountryName = p_CountryName
WHERE SrNo = p_SrNo;
SELECT p_SrNo;
else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_department_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_department_delete`(p_SrNo int)
BEGIN
Delete From mst_department where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_department_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_department_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
Department varchar(100)
);
insert into temp(SrNo,Department)
select m.SrNo,m.Department from mst_department as m where (
v_lockeyword = '%%'
or m.Department like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.Department end asc,
case when v_locsortorder = 22 then m.Department end desc;
 
select count(*) into totalrecords from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_department_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_department_getbyid`(p_SrNo int)
BEGIN
select * From mst_department where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_department_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_department_insertupdate`(
p_SrNo int,
p_Department varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_department where Department = p_Department)
then

INSERT INTO mst_department
(SrNo,
Department)
VALUES
(p_SrNo,
p_Department
);
select last_insert_id();
else
select -1;
end if;
 ELSE
 
if not exists(select * from mst_department where Department=p_Department and SrNo != p_SrNo)
then

UPDATE mst_department
SET
SrNo = p_SrNo,
Department = p_Department
WHERE SrNo = p_SrNo;

SELECT p_SrNo;

else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_designation_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_designation_delete`(p_SrNo int)
BEGIN
Delete From mst_designation where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_designation_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_designation_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
Designation varchar(100)
);
insert into temp(SrNo,Designation)
select m.SrNo,m.Designation from mst_designation as m where (
v_lockeyword = '%%'
or m.Designation like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.Designation end asc,
case when v_locsortorder = 22 then m.Designation end desc;
 
select count(*) into totalrecords from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_designation_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_designation_getbyid`(p_SrNo int)
BEGIN
select * From mst_designation where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_designation_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_designation_insertupdate`(
p_SrNo int,
p_Designation varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_designation where Designation = p_Designation)
then

INSERT INTO mst_designation
(SrNo,
Designation)
VALUES
(p_SrNo,
p_Designation
);
select last_insert_id();
else
select -1;
end if;
 ELSE

if not exists(select * from mst_designation where Designation=p_Designation and SrNo != p_SrNo)
then

UPDATE mst_designation
SET
SrNo = p_SrNo,
Designation = p_Designation
WHERE SrNo = p_SrNo;

SELECT p_SrNo;

else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_district_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_district_delete`(p_SrNo int)
BEGIN
Delete From mst_district where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_district_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_district_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int ,Mst_State_SrNo int,
DistrictName varchar(100)
);
insert into temp(SrNo,Mst_State_SrNo,DistrictName)
select m.SrNo,m.Mst_State_SrNo,m.DistrictName from mst_district as m where (
v_lockeyword = '%%'
or m.DistrictName like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.DistrictName end asc,
case when v_locsortorder = 22 then m.DistrictName end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_district_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_district_getbyid`(p_SrNo int)
BEGIN
select * From mst_district where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_district_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_district_insertupdate`(
p_SrNo int,
p_Mst_State_SrNo int,
p_DistrictName varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_district where DistrictName=P_DistrictName)then
INSERT INTO mst_district
(SrNo,
Mst_State_SrNo,
DistrictName)
VALUES
(p_SrNo,
p_Mst_State_SrNo,
p_DistrictName
);
select last_insert_id();
 ELSE
 select -1;
 end if ;
 else
 if not exists(select * from mst_district where DistrictName=p_DistrictName and SrNo!=P_SrNo)then
UPDATE mst_district
SET
SrNo = p_SrNo,
Mst_State_SrNo = p_Mst_State_SrNo,
DistrictName = p_DistrictName
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_doctag_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_doctag_delete`(p_SrNo int)
BEGIN
Delete From mst_doctag where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_doctag_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_doctag_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
DocTagName varchar(100)
);
insert into temp(SrNo,DocTagName)
select m.SrNo,m.DocTagName from mst_doctag as m where (
v_lockeyword = '%%'
or m.DocTagName like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.DocTagName end asc,
case when v_locsortorder = 22 then m.DocTagName end desc;
 
select count(*) into totalrecords from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_doctag_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_doctag_getbyid`(p_SrNo int)
BEGIN
select * From mst_doctag where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_doctag_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_doctag_insertupdate`(
p_SrNo int,
p_DocTagName varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_doctag where DocTagName = p_DocTagName)
then

INSERT INTO mst_doctag
(SrNo,
DocTagName)
VALUES
(p_SrNo,
p_DocTagName
);
select last_insert_id();
else
select -1;
end if;
 ELSE

if not exists(select * from mst_doctag where DocTagName=p_DocTagName and SrNo != p_SrNo)
then

UPDATE mst_doctag
SET
SrNo = p_SrNo,
DocTagName = p_DocTagName
WHERE SrNo = p_SrNo;

SELECT p_SrNo;

else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_empdeptreview_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_empdeptreview_delete`(p_SrNo int)
BEGIN
Delete From mst_empdeptreview where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_empdeptreview_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_empdeptreview_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
DisplayOrder float, Mst_Dept_SrNo int, Mst_EmployeeReview_SrNo int
);
insert into temp(SrNo,DisplayOrder,Mst_Dept_SrNo,Mst_EmployeeReview_SrNo)
select m.SrNo,m.DisplayOrder,m.Mst_Dept_SrNo,m.Mst_EmployeeReview_SrNo from mst_empdeptreview as m where (
v_lockeyword = '%%'
or m.DisplayOrder like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.DisplayOrder end asc,
case when v_locsortorder = 22 then m.DisplayOrder end desc;
 
select count(*) into totalrecords from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_empdeptreview_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_empdeptreview_getbyid`(p_SrNo int)
BEGIN
select * From mst_empdeptreview where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_empdeptreview_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_empdeptreview_insertupdate`(
p_SrNo int,
p_DisplayOrder float,
p_Mst_Dept_SrNo int,
p_Mst_EmployeeReview_SrNo int
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_empdeptreview where DisplayOrder = p_DisplayOrder)
then

INSERT INTO mst_empdeptreview
(SrNo,
DisplayOrder,
Mst_Dept_SrNo,
Mst_EmployeeReview_SrNo)
VALUES
(p_SrNo,
p_DisplayOrder,
p_Mst_Dept_SrNo,
p_Mst_EmployeeReview_SrNo
);
select last_insert_id();
else
select -1;
end if;
 ELSE
 
 if not exists(select * from mst_empdeptreview where DisplayOrder = p_DisplayOrder and SrNo != p_SrNo)
then
 
UPDATE mst_empdeptreview
SET
SrNo = p_SrNo,
DisplayOrder = p_DisplayOrder,
Mst_Dept_SrNo = p_Mst_Dept_SrNo,
Mst_EmployeeReview_SrNo = p_Mst_EmployeeReview_SrNo
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_employeereview_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_employeereview_delete`(p_SrNo int)
BEGIN
Delete From mst_employeereview where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_employeereview_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_employeereview_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
ReviewName varchar(100), Points float
);
insert into temp(SrNo,ReviewName,Points)
select m.SrNo,m.ReviewName,m.Points from mst_employeereview as m where (
v_lockeyword = '%%'
or m.ReviewName like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.ReviewName end asc,
case when v_locsortorder = 22 then m.ReviewName end desc;
 
select count(*) into totalrecords from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_employeereview_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_employeereview_getbyid`(p_SrNo int)
BEGIN
select * From mst_employeereview where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_employeereview_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_employeereview_insertupdate`(
p_SrNo int,
p_ReviewName varchar(100),
p_Points float
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_employeereview where ReviewName = p_ReviewName)
then

INSERT INTO mst_employeereview
(SrNo,
ReviewName,
Points)
VALUES
(p_SrNo,
p_ReviewName,
p_Points
);
select last_insert_id();
else
select -1;
end if;
 ELSE
 
if not exists(select * from mst_employeereview where ReviewName=p_ReviewName and SrNo != p_SrNo)
then
 
UPDATE mst_employeereview
SET
SrNo = p_SrNo,
ReviewName = p_ReviewName,
Points = p_Points
WHERE SrNo = p_SrNo;

SELECT p_SrNo;

else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_holidays_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_holidays_delete`(
p_SrNo int
)
BEGIN
	delete from mst_holidays where SrNo=p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_holidays_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_holidays_getall`(
 in keyword varchar(50),
 in sortorder int,
 in pagenumber int,
 in pagesize int,
 out totalrecords int
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
ForYear int,
HolidayName varchar(100), 
Type char(1),
ForDate date,
PartialWorking char(1),
StartTime Time,
OffTime Time,
Remark varchar(100)
);
insert into temp(SrNo,ForYear,HolidayName,Type,ForDate,PartialWorking,StartTime,OffTime,Remark)
select m.SrNo,m.ForYear,m.HolidayName,m.Type,m.ForDate,m.PartialWorking,m.StartTime,m.OffTime,m.Remark from mst_holidays as m where (
v_lockeyword = '%%'
or m.ForDate like v_lockeyword
or m.HolidayName like v_lockeyword 
)
order by
case when v_locsortorder = 11 then m.ForDate end asc,
case when v_locsortorder = 12 then m.ForDate end desc,
case when v_locsortorder = 21 then m.HolidayName end asc,
case when v_locsortorder = 22 then m.HolidayName end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_holidays_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_holidays_getbyid`(
p_SrNo int
)
BEGIN
	select * from mst_holidays where SrNo=p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_holidays_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_holidays_insertupdate`(
p_SrNo int,
p_ForYear int,
p_HolidayName varchar(100), 
p_Type char(1),
p_ForDate date,
p_PartialWorking char(1),
p_StartTime TIME,
p_OffTime TIME,
p_Remark varchar(100)
)
BEGIN

if(p_SrNo =0 or p_SrNo is null)
then
IF EXISTS(SELECT 'True' FROM mst_holidays  WHERE HolidayName Like p_HolidayName and ForYear = p_ForYear)
then
	Select -1;
else
INSERT INTO `crm`.`mst_holidays`
(`SrNo`,
`ForYear`,
`HolidayName`,
`Type`,
`ForDate`,
`PartialWorking`,
`StartTime`,
`OffTime`,
`Remark`)
VALUES
(
p_SrNo,
p_ForYear,
p_HolidayName, 
p_Type,
p_ForDate,
p_PartialWorking,
p_StartTime,
p_OffTime,
p_Remark
);
select last_insert_id();
end if;
else
IF EXISTS(SELECT 'True' FROM mst_holidays  WHERE HolidayName Like p_HolidayName and ForYear = p_ForYear and SrNo != p_SrNo)
then
	Select -1;
else
UPDATE `crm`.`mst_holidays`
SET
SrNo = p_SrNo,
ForYear = p_ForYear,
HolidayName = p_HolidayName,
Type = p_Type,
ForDate = p_ForDate,
PartialWorking = p_PartialWorking,
StartTime = p_StartTime,
OffTime = p_OffTime,
Remark = p_Remark
WHERE SrNo = p_SrNo;
select p_SrNo;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_note_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_note_delete`(p_SrNo int)
BEGIN
Delete From mst_note where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_note_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_note_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
NoteName varchar(100)
);
insert into temp(SrNo,NoteName)
select m.SrNo,m.NoteName from mst_note as m where (
v_lockeyword = '%%'
or m.NoteName like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.NoteName end asc,
case when v_locsortorder = 22 then m.NoteName end desc;
 
select count(*) into totalrecords from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_note_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_note_getbyid`(p_SrNo int)
BEGIN
select * From mst_note where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_note_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_note_insertupdate`(
p_SrNo int,
p_NoteName varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_note where NoteName = p_NoteName)
then

INSERT INTO mst_note
(SrNo,
NoteName)
VALUES
(p_SrNo,
p_NoteName
);
select last_insert_id();
else
select -1;
end if;
 ELSE

if not exists(select * from mst_note where NoteName=p_NoteName and SrNo != p_SrNo)
then

UPDATE mst_note
SET
SrNo = p_SrNo,
NoteName = p_NoteName
WHERE SrNo = p_SrNo;

SELECT p_SrNo;

else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_perks_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_perks_delete`(p_SrNo int)
BEGIN
Delete From mst_perks where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_perks_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_perks_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
PerksType int, AllowType int, DisplaySeq float, PerkName varchar(100), MinPerk int, PerkPer float, FixPer float, CalculatedOn int
);
insert into temp(SrNo,PerksType,AllowType,DisplaySeq,PerkName,MinPerk,PerkPer,FixPer,CalculatedOn)
select m.SrNo,m.PerksType,m.AllowType,m.DisplaySeq,m.PerkName,m.MinPerk,m.PerkPer,m.FixPer,m.CalculatedOn from mst_perks as m where (
v_lockeyword = '%%'
or m.PerkName like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.PerkName end asc,
case when v_locsortorder = 22 then m.PerkName end desc;
 
select count(*) into totalrecords from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_perks_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_perks_getbyid`(p_SrNo int)
BEGIN
select * From mst_perks where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_perks_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_perks_insertupdate`(
p_SrNo int,
p_PerksType int,
p_AllowType int,
p_DisplaySeq float,
p_PerkName varchar(100),
p_MinPerk int,
p_PerkPer float,
p_FixPer float,
p_CalculatedOn int
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_perks where PerkName = p_PerkName)
then

INSERT INTO mst_perks
(SrNo,
PerksType,
AllowType,
DisplaySeq,
PerkName,
MinPerk,
PerkPer,
FixPer,
CalculatedOn)
VALUES
(p_SrNo,
p_PerksType,
p_AllowType,
p_DisplaySeq,
p_PerkName,
p_MinPerk,
p_PerkPer,
p_FixPer,
p_CalculatedOn
);
select last_insert_id();
else
select -1;
end if;
 ELSE
 
 if not exists(select * from mst_perks where PerkName=p_PerkName and SrNo != p_SrNo)
then

UPDATE mst_perks
SET
SrNo = p_SrNo,
PerksType = p_PerksType,
AllowType = p_AllowType,
DisplaySeq = p_DisplaySeq,
PerkName = p_PerkName,
MinPerk = p_MinPerk,
PerkPer = p_PerkPer,
FixPer = p_FixPer,
CalculatedOn = p_CalculatedOn
WHERE SrNo = p_SrNo;

SELECT p_SrNo;

else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_ppmodules_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_ppmodules_delete`(p_SrNo int)
BEGIN
Delete From mst_ppmodules where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_ppmodules_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_ppmodules_getall`(
 in keyword varchar(50),
 in sortorder int,
 in pagenumber int,
 in pagesize int,
 out totalrecords int
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
Mst_ProductPrice_SrNo int,
Mst_Product_Module_SrNo int,
PriceConsidered float,
Remark varchar(250)
);
insert into temp(SrNo,Mst_ProductPrice_SrNo,Mst_Product_Module_SrNo,PriceConsidered,Remark)
select m.SrNo,m.Mst_ProductPrice_SrNo,m.Mst_Product_Module_SrNo,m.PriceConsidered,m.Remark from mst_ppmodules as m where (
v_lockeyword = '%%'
or m.PriceConsidered like v_lockeyword
or m.Remark like v_lockeyword
)
order by
case when v_locsortorder = 11 then m.PriceConsidered end asc,
case when v_locsortorder = 12 then m.PriceConsidered end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_ppmodules_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_ppmodules_getbyid`(p_SrNo int)
BEGIN
select * From mst_ppmodules where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_ppmodules_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_ppmodules_insertupdate`(
p_SrNo int,
p_Mst_ProductPrice_SrNo int,
p_Mst_Product_Module_SrNo int,
p_PriceConsidered float,
p_Remark varchar(250)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
IF EXISTS(SELECT 'True' FROM mst_ppmodules WHERE Mst_ProductPrice_SrNo  Like p_Mst_ProductPrice_SrNo and Mst_Product_Module_SrNo Like p_Mst_Product_Module_SrNo and PriceConsidered like p_PriceConsidered )
then
	Select -1;
else
INSERT INTO mst_ppmodules
(SrNo,
Mst_ProductPrice_SrNo,
Mst_Product_Module_SrNo,
PriceConsidered,
Remark)
VALUES
(p_SrNo,
p_Mst_ProductPrice_SrNo,
p_Mst_Product_Module_SrNo,
p_PriceConsidered,
p_Remark
);
select last_insert_id();
 end if;
 ELSE
 IF EXISTS(SELECT 'True' FROM mst_ppmodules WHERE Mst_ProductPrice_SrNo  Like p_Mst_ProductPrice_SrNo and Mst_Product_Module_SrNo Like p_Mst_Product_Module_SrNo and PriceConsidered like p_PriceConsidered and SrNo != p_SrNo )
then
	Select -1;
else
UPDATE mst_ppmodules
SET
SrNo = p_SrNo,
Mst_ProductPrice_SrNo = p_Mst_ProductPrice_SrNo,
Mst_Product_Module_SrNo = p_Mst_Product_Module_SrNo,
PriceConsidered = p_PriceConsidered,
Remark = p_Remark
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productcategory_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productcategory_delete`(p_SrNo int)
BEGIN
Delete From mst_productcategory where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productcategory_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productcategory_getall`(
 in keyword varchar(50),
 in sortorder int,
 in pagenumber int,
 in pagesize int,
 out totalrecords int
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
`Status` char(1),
ProductCategory varchar(100), 
IV_LinkName_SrNo varchar(250),
Remark int
);
insert into temp(SrNo,Status,ProductCategory,IV_LinkName_SrNo,Remark)
select m.SrNo,m.Status,m.ProductCategory,m.IV_LinkName_SrNo,m.Remark from mst_productcategory as m where (
v_lockeyword = '%%'
or m.ProductCategory like v_lockeyword
or m.Remark like v_lockeyword
)
order by
case when v_locsortorder = 11 then m.Status end asc,
case when v_locsortorder = 12 then m.Status end desc,
case when v_locsortorder = 21 then m.ProductCategory end asc,
case when v_locsortorder = 22 then m.ProductCategory end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productcategory_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productcategory_getbyid`(p_SrNo int)
BEGIN
select * From mst_productcategory where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productcategory_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productcategory_insertupdate`(
p_SrNo int,
p_Status char(1),
p_ProductCategory varchar(50),
p_IV_LinkName_SrNo int,
p_Remark varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
IF EXISTS(SELECT 'True' FROM mst_productcategory WHERE ProductCategory  Like p_ProductCategory)
then
	Select -1;
else
INSERT INTO mst_productcategory
(SrNo,
Status,
ProductCategory,
IV_LinkName_SrNo,
Remark)
VALUES
(p_SrNo,
p_Status,
p_ProductCategory,
p_IV_LinkName_SrNo,
p_Remark
);
select last_insert_id();
end if;
ELSE
IF EXISTS(SELECT 'True' FROM mst_productcategory WHERE ProductCategory Like p_ProductCategory and SrNo != p_SrNo )
then
	Select -1;
else
UPDATE mst_productcategory
SET
SrNo = p_SrNo,
Status = p_Status,
ProductCategory = p_ProductCategory,
IV_LinkName_SrNo = p_IV_LinkName_SrNo,
Remark = p_Remark
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productprice_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productprice_delete`(p_SrNo int)
BEGIN
Delete From mst_productprice where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productprice_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productprice_getall`(
 in keyword varchar(50),
 in sortorder int,
 in pagenumber int,
 in pagesize int,
 out totalrecords int
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
Mst_Product_SrNo int,
RevisedDate date,
ProductPrice float, 
AMCPrice float,
Remark varchar(250)
);
insert into temp(SrNo,Mst_Product_SrNo,RevisedDate,ProductPrice,AMCPrice,Remark)
select m.SrNo,m.Mst_Product_SrNo,m.RevisedDate,m.ProductPrice,m.AMCPrice,m.Remark from mst_productprice as m where (
v_lockeyword = '%%'
or m.ProductPrice like v_lockeyword
or m.AMCPrice like v_lockeyword
or m.Remark like v_lockeyword
)
order by
case when v_locsortorder = 11 then m.RevisedDate end asc,
case when v_locsortorder = 12 then m.RevisedDate end desc,
case when v_locsortorder = 21 then m.ProductPrice end asc,
case when v_locsortorder = 22 then m.ProductPrice end desc,
 case when v_locsortorder = 31 then m.AMCPrice end asc,
case when v_locsortorder = 32 then m.AMCPrice end desc;
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productprice_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productprice_getbyid`(p_SrNo int)
BEGIN
select * From mst_productprice where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productprice_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productprice_insertupdate`(
p_SrNo int,
p_Mst_Product_SrNo int,
p_RevisedDate date,
p_ProductPrice float,
p_AMCPrice float,
p_Remark varchar(250)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
IF EXISTS(SELECT 'True' FROM mst_productprice WHERE Mst_Product_SrNo  Like p_Mst_Product_SrNo)
then
	Select -1;
else
INSERT INTO mst_productprice
(SrNo,
Mst_Product_SrNo,
RevisedDate,
ProductPrice,
AMCPrice,
Remark)
VALUES
(p_SrNo,
p_Mst_Product_SrNo,
p_RevisedDate,
p_ProductPrice,
p_AMCPrice,
p_Remark
);
select last_insert_id();
end if;
 ELSE
 IF EXISTS(SELECT 'True' FROM mst_productprice WHERE Mst_Product_SrNo Like p_Mst_Product_SrNo and SrNo != p_SrNo )
then
	Select -1;
else
UPDATE mst_productprice
SET
SrNo = p_SrNo,
Mst_Product_SrNo = p_Mst_Product_SrNo,
RevisedDate = p_RevisedDate,
ProductPrice = p_ProductPrice,
AMCPrice = p_AMCPrice,
Remark = p_Remark
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productsubcategory_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productsubcategory_delete`(p_SrNo int)
BEGIN
Delete From mst_productsubcategory where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productsubcategory_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productsubcategory_getall`(
 in keyword varchar(50),
 in sortorder int,
 in pagenumber int,
 in pagesize int,
 out totalrecords int
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
`Status` char(1),
Mst_ProductCategory_SrNo int,
ProductSubCategoryName varchar(100), 
IV_LinkName_SrNo varchar(250),
Remark int
);
insert into temp(SrNo,Status,Mst_ProductCategory_SrNo,ProductSubCategoryName,IV_LinkName_SrNo,Remark)
select m.SrNo,m.Status,m.Mst_ProductCategory_SrNo,m.ProductSubCategoryName,m.IV_LinkName_SrNo,m.Remark from mst_productsubcategory as m where (
v_lockeyword = '%%'
or m.ProductSubCategoryName like v_lockeyword
or m.Remark like v_lockeyword
)
order by
case when v_locsortorder = 11 then m.Status end asc,
case when v_locsortorder = 12 then m.Status end desc,
case when v_locsortorder = 21 then m.ProductSubCategoryName end asc,
case when v_locsortorder = 22 then m.ProductSubCategoryName end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productsubcategory_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productsubcategory_getbyid`(p_SrNo int)
BEGIN
select * From mst_productsubcategory where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productsubcategory_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productsubcategory_insertupdate`(
p_SrNo int,
p_Status char(1),
p_Mst_ProductCategory_SrNo int,
p_ProductSubCategoryName varchar(50),
p_IV_LinkName_SrNo int,
p_Remark varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
IF EXISTS(SELECT 'True' FROM mst_productsubcategory WHERE ProductSubCategoryName  Like p_ProductSubCategoryName)
then
	Select -1;
else
INSERT INTO mst_productsubcategory
(SrNo,
Status,
Mst_ProductCategory_SrNo,
ProductSubCategoryName,
IV_LinkName_SrNo,
Remark)
VALUES
(p_SrNo,
p_Status,
p_Mst_ProductCategory_SrNo,
p_ProductSubCategoryName,
p_IV_LinkName_SrNo,
p_Remark
);
select last_insert_id();
end if;
 ELSE
 IF EXISTS(SELECT 'True' FROM mst_productsubcategory WHERE ProductSubCategoryName Like p_ProductSubCategoryName and SrNo != p_SrNo )
then
	Select -1;
else
UPDATE mst_productsubcategory
SET
SrNo = p_SrNo,
Status = p_Status,
Mst_ProductCategory_SrNo = p_Mst_ProductCategory_SrNo,
ProductSubCategoryName = p_ProductSubCategoryName,
IV_LinkName_SrNo = p_IV_LinkName_SrNo,
Remark = p_Remark
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productversion_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productversion_delete`(p_SrNo int)
BEGIN
Delete From mst_productversion where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productversion_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productversion_getall`(
 in keyword varchar(50),
 in sortorder int,
 in pagenumber int,
 in pagesize int,
 out totalrecords int
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
Mst_Product_SrNo int,
VersionName varchar(50),
VersionCode varchar(20),
VersionReleaseDate date,
BriefVideoLink int,
Remark varchar(250)
);
insert into temp(SrNo,Mst_Product_SrNo,VersionName,VersionCode,VersionReleaseDate,BriefVideoLink,Remark)
select m.SrNo,m.Mst_Product_SrNo,m.VersionName,m.VersionCode,m.VersionReleaseDate,m.BriefVideoLink,m.Remark from mst_productversion as m where (
v_lockeyword = '%%'
or m.VersionName like v_lockeyword
or m.VersionCode like v_lockeyword
or m.Remark like v_lockeyword
)
order by
case when v_locsortorder = 11 then m.VersionName end asc,
case when v_locsortorder = 12 then m.VersionName end desc,
case when v_locsortorder = 21 then m.VersionCode end asc,
case when v_locsortorder = 22 then m.VersionCode end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productversion_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productversion_getbyid`(p_SrNo int)
BEGIN
select * From mst_productversion where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_productversion_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_productversion_insertupdate`(
p_SrNo int,
p_Mst_Product_SrNo int,
p_VersionName varchar(50),
p_VersionCode varchar(20),
p_VersionReleaseDate date,
p_BriefVideoLink int,
p_Remark varchar(250)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then

IF EXISTS(SELECT 'True' FROM mst_productversion WHERE VersionName  Like p_VersionName and VersionCode like p_VersionCode )
then
	Select -1;
else
INSERT INTO mst_productversion
(SrNo,
Mst_Product_SrNo,
VersionName,
VersionCode,
VersionReleaseDate,
BriefVideoLink,
Remark)
VALUES
(p_SrNo,
p_Mst_Product_SrNo,
p_VersionName,
p_VersionCode,
p_VersionReleaseDate,
p_BriefVideoLink,
p_Remark
);
select last_insert_id();
end if;
 ELSE
 IF EXISTS(SELECT 'True' FROM mst_productversion WHERE VersionName Like p_VersionName and VersionCode like p_VersionCode and SrNo != p_SrNo )
then
	Select -1;
else
UPDATE mst_productversion
SET
SrNo = p_SrNo,
Mst_Product_SrNo = p_Mst_Product_SrNo,
VersionName = p_VersionName,
VersionCode = p_VersionCode,
VersionReleaseDate = p_VersionReleaseDate,
BriefVideoLink = p_BriefVideoLink,
Remark = p_Remark
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_product_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_product_delete`(p_SrNO int)
BEGIN
Delete From mst_product where SrNO = p_SrNO;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_product_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_product_getall`(
 in keyword varchar(50),
 in sortorder int,
 in pagenumber int,
 in pagesize int,
 out totalrecords int
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
`Status` char(1),
ProductName varchar(100),
Description varchar(250),
Mst_ProductCategory_SrNo int,
Mst_ProductSubCategory_SrNo int,
StartDate date,
EndDate date,
VideoLinkMkt int,
VideoLinkSupport int,
VideoLinkCustomer int,
Remark varchar(250)
);
insert into temp(SrNo,Status,ProductName,Description,Mst_ProductCategory_SrNo,Mst_ProductSubCategory_SrNo,StartDate,EndDate,VideoLinkMkt,VideoLinkSupport,VideoLinkCustomer,Remark)
select m.SrNo,m.Status,m.ProductName,m.Description,m.Mst_ProductCategory_SrNo,m.Mst_ProductSubCategory_SrNo,m.StartDate,m.EndDate,m.VideoLinkMkt,m.VideoLinkSupport,m.VideoLinkCustomer,m.Remark from mst_product as m where (
v_lockeyword = '%%'
or m.ProductName like v_lockeyword
or m.Remark like v_lockeyword
)
order by
case when v_locsortorder = 11 then m.Status end asc,
case when v_locsortorder = 12 then m.Status end desc,
case when v_locsortorder = 21 then m.ProductName end asc,
case when v_locsortorder = 22 then m.ProductName end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_product_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_product_getbyid`(p_SrNO int)
BEGIN
select * From mst_product where SrNO = p_SrNO;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_product_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_product_insertupdate`(
p_SrNO int,
p_Status char(1),
p_ProductName varchar(100),
p_Description varchar(250),
p_Mst_ProductCategory_SrNo int,
p_Mst_ProductSubCategory_SrNo int,
p_StartDate date,
p_EndDate date,
p_VideoLinkMkt int,
p_VideoLinkSupport int,
p_VideoLinkCustomer int,
p_Remark varchar(250)
)
BEGIN
 if(p_SrNO = 0 or p_SrNO is null)
then
IF EXISTS(SELECT 'True' FROM mst_product WHERE ProductName  Like p_ProductName)
then
	Select -1;
else
INSERT INTO mst_product
(SrNO,
Status,
ProductName,
Description,
Mst_ProductCategory_SrNo,
Mst_ProductSubCategory_SrNo,
StartDate,
EndDate,
VideoLinkMkt,
VideoLinkSupport,
VideoLinkCustomer,
Remark)
VALUES
(p_SrNO,
p_Status,
p_ProductName,
p_Description,
p_Mst_ProductCategory_SrNo,
p_Mst_ProductSubCategory_SrNo,
p_StartDate,
p_EndDate,
p_VideoLinkMkt,
p_VideoLinkSupport,
p_VideoLinkCustomer,
p_Remark
);
select last_insert_id();
end if;
 ELSE
 IF EXISTS(SELECT 'True' FROM mst_product WHERE ProductName Like p_ProductName and SrNo != p_SrNo )
then
	Select -1;
else
 
UPDATE mst_product
SET
SrNO = p_SrNO,
Status = p_Status,
ProductName = p_ProductName,
Description = p_Description,
Mst_ProductCategory_SrNo = p_Mst_ProductCategory_SrNo,
Mst_ProductSubCategory_SrNo = p_Mst_ProductSubCategory_SrNo,
StartDate = p_StartDate,
EndDate = p_EndDate,
VideoLinkMkt = p_VideoLinkMkt,
VideoLinkSupport = p_VideoLinkSupport,
VideoLinkCustomer = p_VideoLinkCustomer,
Remark = p_Remark
WHERE SrNO = p_SrNO;

SELECT p_SrNO;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_product_module_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_product_module_delete`(p_SrNo int)
BEGIN
Delete From mst_product_module where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_product_module_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_product_module_getall`(
 in keyword varchar(50),
 in sortorder int,
 in pagenumber int,
 in pagesize int,
 out totalrecords int
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
Mst_Product_SrNo int,
`Status` char(1),
ModuleName varchar(100),
StartDate date,
EndDate date,
VideoLinkMkt int,
VideoLinkSupport int,
VideoLinkCustomer int,
Remark varchar(100)
);
insert into temp(SrNo,Mst_Product_SrNo,Status,ModuleName,StartDate,EndDate,VideoLinkMkt,VideoLinkSupport,VideoLinkCustomer,Remark)
select m.SrNo,m.Mst_Product_SrNo,m.Status,m.ModuleName,m.StartDate,m.EndDate,m.VideoLinkMkt,m.VideoLinkSupport,m.VideoLinkCustomer,m.Remark from mst_product_module as m where (
v_lockeyword = '%%'
or m.ModuleName like v_lockeyword
or m.Remark like v_lockeyword
)
order by
case when v_locsortorder = 11 then m.Status end asc,
case when v_locsortorder = 12 then m.Status end desc,
case when v_locsortorder = 21 then m.ModuleName end asc,
case when v_locsortorder = 22 then m.ModuleName end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_product_module_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_product_module_getbyid`(p_SrNo int)
BEGIN
select * From mst_product_module where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_product_module_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_product_module_insertupdate`(
p_SrNo int,
p_Mst_Product_SrNo int,
p_Status char(1),
p_ModuleName varchar(100),
p_StartDate date,
p_EndDate date,
p_VideoLinkMkt int,
p_VideoLinkSupport int,
p_VideoLinkCustomer int,
p_Remark varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
IF EXISTS(SELECT 'True' FROM mst_product_module WHERE ModuleName  Like p_ModuleName and Mst_Product_SrNo like p_Mst_Product_SrNo )
then
	Select -1;
else
INSERT INTO mst_product_module
(SrNo,
Mst_Product_SrNo,
Status,
ModuleName,
StartDate,
EndDate,
VideoLinkMkt,
VideoLinkSupport,
VideoLinkCustomer,
Remark)
VALUES
(p_SrNo,
p_Mst_Product_SrNo,
p_Status,
p_ModuleName,
p_StartDate,
p_EndDate,
p_VideoLinkMkt,
p_VideoLinkSupport,
p_VideoLinkCustomer,
p_Remark
);
select last_insert_id();
end if;
 ELSE
 IF EXISTS(SELECT 'True' FROM mst_product_module WHERE (ModuleName Like p_ModuleName and Mst_Product_SrNo like p_Mst_Product_SrNo) and SrNo != p_SrNo )
then
	Select -1;
else
UPDATE mst_product_module
SET
SrNo = p_SrNo,
Mst_Product_SrNo = p_Mst_Product_SrNo,
Status = p_Status,
ModuleName = p_ModuleName,
StartDate = p_StartDate,
EndDate = p_EndDate,
VideoLinkMkt = p_VideoLinkMkt,
VideoLinkSupport = p_VideoLinkSupport,
VideoLinkCustomer = p_VideoLinkCustomer,
Remark = p_Remark
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_pvchanges_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_pvchanges_delete`(p_SrNo int)
BEGIN
Delete From mst_pvchanges where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_pvchanges_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_pvchanges_getall`(
 in keyword varchar(50),
 in sortorder int,
 in pagenumber int,
 in pagesize int,
 out totalrecords int
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
Mst_ProductVerSrNo int,
Mst_Product_Module_SrNo int, 
WhatChanges varchar(250),
VideoLink int,
Remark varchar(250)
);
insert into temp(SrNo,Mst_ProductVerSrNo,Mst_Product_Module_SrNo,WhatChanges,VideoLink,Remark)
select m.SrNo,m.Mst_ProductVerSrNo,m.Mst_Product_Module_SrNo,m.WhatChanges,m.VideoLink,m.Remark from mst_pvchanges as m where (
v_lockeyword = '%%'
or m.WhatChanges like v_lockeyword
or m.Remark like v_lockeyword
)
order by
case when v_locsortorder = 11 then m.WhatChanges end asc,
case when v_locsortorder = 12 then m.WhatChanges end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_pvchanges_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_pvchanges_getbyid`(p_SrNo int)
BEGIN
select * From mst_pvchanges where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_pvchanges_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_pvchanges_insertupdate`(
p_SrNo int,
p_Mst_ProductVerSrNo int,
p_Mst_Product_Module_SrNo int,
p_WhatChanges varchar(250),
p_VideoLink int,
p_Remark varchar(250)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then

IF EXISTS(SELECT 'True' FROM mst_pvchanges WHERE WhatChanges  Like p_WhatChanges)
then
	Select -1;
else
INSERT INTO mst_pvchanges
(SrNo,
Mst_ProductVerSrNo,
Mst_Product_Module_SrNo,
WhatChanges,
VideoLink,
Remark)
VALUES
(p_SrNo,
p_Mst_ProductVerSrNo,
p_Mst_Product_Module_SrNo,
p_WhatChanges,
p_VideoLink,
p_Remark
);
select last_insert_id();
end if;
 ELSE
 IF EXISTS(SELECT 'True' FROM mst_pvchanges WHERE WhatChanges  Like p_WhatChanges and SrNo != p_SrNo )
then
	Select -1;
else
UPDATE mst_pvchanges
SET
SrNo = p_SrNo,
Mst_ProductVerSrNo = p_Mst_ProductVerSrNo,
Mst_Product_Module_SrNo = p_Mst_Product_Module_SrNo,
WhatChanges = p_WhatChanges,
VideoLink = p_VideoLink,
Remark = p_Remark
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_regchild_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_regchild_delete`(p_SrNo int)
BEGIN
Delete From mst_regchild where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_regchild_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_regchild_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int ,
Mst_Region_SrNo int,Mst_State_SrNo int,Mst_District_SrNo int,Mst_Area_SrNo int
);
insert into temp(SrNo,Mst_Region_SrNo,Mst_State_SrNo,Mst_District_SrNo,Mst_Area_SrNo)
select m.SrNo,m.Mst_Region_SrNo,m.Mst_State_SrNo,m.Mst_District_SrNo,m.Mst_Area_SrNo from mst_regchild as m where (
v_lockeyword = '%%'
or m.Mst_Region_SrNo like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.Mst_Region_SrNo end asc,
case when v_locsortorder = 22 then m.Mst_Region_SrNo end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_regchild_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_regchild_getbyid`(p_SrNo int)
BEGIN
select * From mst_regchild where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_regchild_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_regchild_insertupdate`(
p_SrNo int,
p_Mst_Region_SrNo int,
p_Mst_State_SrNo int,
p_Mst_District_SrNo int,
p_Mst_Area_SrNo int
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_regchild where Mst_Region_SrNo=p_Mst_Region_SrNo and Mst_State_SrNo = p_Mst_State_SrNo and Mst_District_SrNo = p_Mst_District_SrNo and Mst_Area_SrNo = p_Mst_Area_SrNo)then
INSERT INTO mst_regchild
(SrNo,
Mst_Region_SrNo,
Mst_State_SrNo,
Mst_District_SrNo,
Mst_Area_SrNo)
VALUES
(p_SrNo,
p_Mst_Region_SrNo,
p_Mst_State_SrNo,
p_Mst_District_SrNo,
p_Mst_Area_SrNo
);
select last_insert_id();
 ELSE
 select -1;
 end if ;
 else
 if not exists(select * from mst_regchild where (Mst_Region_SrNo=p_Mst_Region_SrNo and Mst_State_SrNo = p_Mst_State_SrNo and Mst_District_SrNo = p_Mst_District_SrNo and Mst_Area_SrNo = p_Mst_Area_SrNo) and SrNo!=P_SrNo)then

UPDATE mst_regchild
SET
SrNo = p_SrNo,
Mst_Region_SrNo = p_Mst_Region_SrNo,
Mst_State_SrNo = p_Mst_State_SrNo,
Mst_District_SrNo = p_Mst_District_SrNo,
Mst_Area_SrNo = p_Mst_Area_SrNo
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_region_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_region_delete`(p_SrNo int)
BEGIN
Delete From mst_region where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_region_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_region_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int ,
RegionName varchar(100),Remark varchar(100)
);
insert into temp(SrNo,RegionName,Remark)
select m.SrNo,m.RegionName,m.Remark from mst_region as m where (
v_lockeyword = '%%'
or m.RegionName like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.RegionName end asc,
case when v_locsortorder = 22 then m.RegionName end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_region_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_region_getbyid`(p_SrNo int)
BEGIN
select * From mst_region where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_region_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_region_insertupdate`(
p_SrNo int,
p_RegionName varchar(100),
p_Remark varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_region where RegionName=P_RegionName)then
INSERT INTO mst_region
(SrNo,
RegionName,
Remark)
VALUES
(p_SrNo,
p_RegionName,
p_Remark
);
select last_insert_id();
 ELSE
 select -1;
 end if ;
 else
 if not exists(select * from mst_region where RegionName=p_RegionName and SrNo!=P_SrNo)then

UPDATE mst_region
SET
SrNo = p_SrNo,
RegionName = p_RegionName,
Remark = p_Remark
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_relationship_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_relationship_delete`(p_SrNo int)
BEGIN
Delete From mst_relationship where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_relationship_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_relationship_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,
Relationship varchar(100)
);
insert into temp(SrNo,Relationship)
select m.SrNo,m.Relationship from mst_relationship as m where (
v_lockeyword = '%%'
or m.Relationship like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.Relationship end asc,
case when v_locsortorder = 22 then m.Relationship end desc;
 
select count(*) into totalrecords from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_relationship_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_relationship_getbyid`(p_SrNo int)
BEGIN
select * From mst_relationship where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_relationship_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_relationship_insertupdate`(
p_SrNo int,
p_Relationship varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_relationship where Relationship = p_Relationship)
then

INSERT INTO mst_relationship
(SrNo,
Relationship)
VALUES
(p_SrNo,
p_Relationship
);
select last_insert_id();
else
select -1;
end if;
 ELSE
 
if not exists(select * from mst_relationship where Relationship=p_Relationship and SrNo != p_SrNo)
then

UPDATE mst_relationship
SET
SrNo = p_SrNo,
Relationship = p_Relationship
WHERE SrNo = p_SrNo;

SELECT p_SrNo;

else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_state_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_state_delete`(p_SrNo int)
BEGIN
Delete From mst_state where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_state_getall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_state_getall`(
    in keyword varchar(50),
 in sortorder int,
    in pagenumber int,
 in pagesize int,
 out totalrecords int
 
)
begin
declare v_lockeyword varchar(52);
declare v_locsortorder int;
declare v_intstart int;
declare v_intend int;
declare v_intend1 int;
set v_lockeyword = concat('%' ,keyword , '%');
set v_locsortorder = sortorder;
set v_intstart = ((pagenumber - 1) * pagesize) + 1;
set v_intend = v_intstart + pagesize - 1;
drop temporary table if exists temp;
create temporary table  temp (disid int auto_increment key,SrNo int,Mst_Country_SrNo int,
StateName varchar(100)
);
insert into temp(SrNo,Mst_Country_SrNo,StateName)
select m.SrNo,m.Mst_Country_SrNo,m.StateName from mst_state as m where (
v_lockeyword = '%%'
or m.StateName like v_lockeyword
)
order by
case when v_locsortorder = 21 then m.StateName end asc,
case when v_locsortorder = 22 then m.StateName end desc;
 
select count(*) into totalrecords  from temp;
select *
 from temp
 where (disid >= v_intstart and disid <= v_intend)
 order by disid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_state_getbyid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_state_getbyid`(p_SrNo int)
BEGIN
select * From mst_state where SrNo = p_SrNo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `proc_mst_state_insertupdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_mst_state_insertupdate`(
p_SrNo int,
p_Mst_Country_SrNo int,
p_StateName varchar(100)
)
BEGIN
 if(p_SrNo = 0 or p_SrNo is null)
then
if not exists(select * from mst_state where StateName=P_StateName and Mst_Country_SrNo=p_Mst_Country_SrNo)then
INSERT INTO mst_state
(SrNo,
Mst_Country_SrNo,
StateName)
VALUES
(p_SrNo,
p_Mst_Country_SrNo,
p_StateName
);
select last_insert_id();
 ELSE
 select -1;
 end if;
 else
 if not exists(select * from mst_state where StateName=P_StateName and SrNo!=P_SrNo)then
UPDATE mst_state
SET
SrNo = p_SrNo,
Mst_Country_SrNo = p_Mst_Country_SrNo,
StateName = p_StateName
WHERE SrNo = p_SrNo;

SELECT p_SrNo;
else
select -1;
end if;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-13 11:49:35
