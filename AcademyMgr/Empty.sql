-- --------------------------------------------------------
-- Hôte :                        127.0.0.1
-- Version du serveur:           5.7.21-log - MySQL Community Server (GPL)
-- SE du serveur:                Win64
-- HeidiSQL Version:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Export de la structure de la base pour gokudo
DROP DATABASE IF EXISTS `gokudo`;
CREATE DATABASE IF NOT EXISTS `gokudo` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `gokudo`;

-- Export de la structure de la table gokudo. coachspayments
DROP TABLE IF EXISTS `coachspayments`;
CREATE TABLE IF NOT EXISTS `coachspayments` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MemberID` int(11) NOT NULL,
  `Month` varchar(200) DEFAULT NULL,
  `Lessons` int(11) DEFAULT NULL,
  `Pay` int(11) DEFAULT NULL,
  `Amount` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Comment` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_MEMBER` (`MemberID`),
  CONSTRAINT `FK_MEMBER` FOREIGN KEY (`MemberID`) REFERENCES `members` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Export de données de la table gokudo.coachspayments : ~0 rows (environ)
DELETE FROM `coachspayments`;
/*!40000 ALTER TABLE `coachspayments` DISABLE KEYS */;
/*!40000 ALTER TABLE `coachspayments` ENABLE KEYS */;

-- Export de la structure de la table gokudo. dojo
DROP TABLE IF EXISTS `dojo`;
CREATE TABLE IF NOT EXISTS `dojo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `Surface` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Export de données de la table gokudo.dojo : ~0 rows (environ)
DELETE FROM `dojo`;
/*!40000 ALTER TABLE `dojo` DISABLE KEYS */;
/*!40000 ALTER TABLE `dojo` ENABLE KEYS */;

-- Export de la structure de la table gokudo. members
DROP TABLE IF EXISTS `members`;
CREATE TABLE IF NOT EXISTS `members` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Firstname` varchar(200) NOT NULL,
  `Lastname` varchar(200) NOT NULL,
  `Enddate` date NOT NULL,
  `CreationDate` date NOT NULL,
  `Belt` enum('white','blue','purple','brown','black') NOT NULL,
  `Gender` enum('M','F') NOT NULL,
  `Comment` text CHARACTER SET latin1,
  `Job` varchar(200) DEFAULT NULL,
  `Mail` varchar(200) DEFAULT NULL,
  `Phone` varchar(200) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `Facebook` varchar(200) DEFAULT NULL,
  `Child` tinyint(4) NOT NULL,
  `Alert` tinyint(4) NOT NULL,
  `FullYear` tinyint(4) NOT NULL,
  `Internal` tinyint(4) NOT NULL,
  `Coach` tinyint(4) NOT NULL,
  `Competitor` tinyint(4) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `uq_MEMBERS` (`Firstname`,`Lastname`)
) ENGINE=InnoDB AUTO_INCREMENT=192 DEFAULT CHARSET=utf8;

-- Export de données de la table gokudo.members : ~165 rows (environ)
DELETE FROM `members`;
/*!40000 ALTER TABLE `members` DISABLE KEYS */;
/*!40000 ALTER TABLE `members` ENABLE KEYS */;

-- Export de la structure de la table gokudo. members_payments
DROP TABLE IF EXISTS `members_payments`;
CREATE TABLE IF NOT EXISTS `members_payments` (
  `MemberID` int(11) NOT NULL,
  `PaymentID` int(11) NOT NULL,
  PRIMARY KEY (`MemberID`,`PaymentID`),
  KEY `FKPayment` (`PaymentID`),
  CONSTRAINT `FKMember` FOREIGN KEY (`MemberID`) REFERENCES `members` (`ID`),
  CONSTRAINT `FKPayment` FOREIGN KEY (`PaymentID`) REFERENCES `payments` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Export de données de la table gokudo.members_payments : ~0 rows (environ)
DELETE FROM `members_payments`;
/*!40000 ALTER TABLE `members_payments` DISABLE KEYS */;
/*!40000 ALTER TABLE `members_payments` ENABLE KEYS */;

-- Export de la structure de la table gokudo. members_status
DROP TABLE IF EXISTS `members_status`;
CREATE TABLE IF NOT EXISTS `members_status` (
  `MemberID` int(11) DEFAULT NULL,
  `Active` tinyint(4) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Current` tinyint(4) DEFAULT NULL,
  KEY `FK_MEMBERS2` (`MemberID`),
  CONSTRAINT `FK_MEMBERS2` FOREIGN KEY (`MemberID`) REFERENCES `members` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Export de données de la table gokudo.members_status : ~0 rows (environ)
DELETE FROM `members_status`;
/*!40000 ALTER TABLE `members_status` DISABLE KEYS */;
/*!40000 ALTER TABLE `members_status` ENABLE KEYS */;

-- Export de la structure de la table gokudo. metrics
DROP TABLE IF EXISTS `metrics`;
CREATE TABLE IF NOT EXISTS `metrics` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '0',
  `Value` int(11) NOT NULL DEFAULT '0',
  `Date` date DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Export de données de la table gokudo.metrics : ~0 rows (environ)
DELETE FROM `metrics`;
/*!40000 ALTER TABLE `metrics` DISABLE KEYS */;
/*!40000 ALTER TABLE `metrics` ENABLE KEYS */;

-- Export de la structure de la table gokudo. payments
DROP TABLE IF EXISTS `payments`;
CREATE TABLE IF NOT EXISTS `payments` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Amount` int(11) DEFAULT NULL,
  `Type` enum('Cash','Check','Transfert') DEFAULT NULL,
  `ReceptionDate` date DEFAULT NULL,
  `Name` varchar(200) DEFAULT NULL,
  `Debt` int(11) DEFAULT NULL,
  `Bank` enum('None','Academy','Perso') NOT NULL DEFAULT 'None',
  `DepotDate` date DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1903 DEFAULT CHARSET=utf8;

-- Export de données de la table gokudo.payments : ~0 rows (environ)
DELETE FROM `payments`;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;

-- Export de la structure de la table gokudo. privates
DROP TABLE IF EXISTS `privates`;
CREATE TABLE IF NOT EXISTS `privates` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MemberID` int(11) NOT NULL,
  `Amount` int(11) NOT NULL,
  `Date` date NOT NULL,
  `bookedLessons` int(11) NOT NULL,
  `doneLessons` int(11) NOT NULL,
  `Description` text,
  PRIMARY KEY (`ID`),
  KEY `FK_MEMBERS` (`MemberID`),
  CONSTRAINT `FK_MEMBERS` FOREIGN KEY (`MemberID`) REFERENCES `members` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Export de données de la table gokudo.privates : ~0 rows (environ)
DELETE FROM `privates`;
/*!40000 ALTER TABLE `privates` DISABLE KEYS */;
/*!40000 ALTER TABLE `privates` ENABLE KEYS */;

-- Export de la structure de la table gokudo. refunds
DROP TABLE IF EXISTS `refunds`;
CREATE TABLE IF NOT EXISTS `refunds` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Label` varchar(200) NOT NULL,
  `Amount` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Comment` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Export de données de la table gokudo.refunds : ~0 rows (environ)
DELETE FROM `refunds`;
/*!40000 ALTER TABLE `refunds` DISABLE KEYS */;
/*!40000 ALTER TABLE `refunds` ENABLE KEYS */;

-- Export de la structure de la table gokudo. seminars
DROP TABLE IF EXISTS `seminars`;
CREATE TABLE IF NOT EXISTS `seminars` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Theme` varchar(200) NOT NULL,
  `Date` date NOT NULL,
  `WebMEMBERS` int(11) NOT NULL,
  `LocalMEMBERS` int(11) NOT NULL,
  `Amount` int(11) NOT NULL,
  `Debt` int(11) NOT NULL,
  `Comment` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Export de données de la table gokudo.seminars : ~0 rows (environ)
DELETE FROM `seminars`;
/*!40000 ALTER TABLE `seminars` DISABLE KEYS */;
/*!40000 ALTER TABLE `seminars` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
