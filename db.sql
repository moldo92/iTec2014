-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.6.11-log - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL Version:             8.1.0.4545
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for app1
CREATE DATABASE IF NOT EXISTS `app1` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `app1`;


-- Dumping structure for table app1.categories
CREATE TABLE IF NOT EXISTS `categories` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=260 DEFAULT CHARSET=latin1;

-- Dumping data for table app1.categories: ~5 rows (approximately)
DELETE FROM `categories`;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` (`id`, `name`) VALUES
	(1, 'Fruits'),
	(2, 'Snacks'),
	(3, 'Drinks'),
	(166, 'asd'),
	(259, 'Mobile');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;


-- Dumping structure for table app1.groups
CREATE TABLE IF NOT EXISTS `groups` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Dumping data for table app1.groups: ~2 rows (approximately)
DELETE FROM `groups`;
/*!40000 ALTER TABLE `groups` DISABLE KEYS */;
INSERT INTO `groups` (`id`, `name`) VALUES
	(1, 'Google Plus'),
	(2, 'Facebook friends');
/*!40000 ALTER TABLE `groups` ENABLE KEYS */;


-- Dumping structure for table app1.items
CREATE TABLE IF NOT EXISTS `items` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT '0',
  `price` float DEFAULT '0',
  `categoryid` int(11) DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `FK_items_categories` (`categoryid`),
  CONSTRAINT `FK_items_categories` FOREIGN KEY (`categoryid`) REFERENCES `categories` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Dumping data for table app1.items: ~9 rows (approximately)
DELETE FROM `items`;
/*!40000 ALTER TABLE `items` DISABLE KEYS */;
INSERT INTO `items` (`id`, `name`, `price`, `categoryid`) VALUES
	(1, 'apple', 3, 1),
	(2, 'grapes', 10, 1),
	(3, 'oranges', 4, 1),
	(4, 'sticks', 2, 2),
	(5, 'pufuletus', 1, 2),
	(6, 'pleskavitza', 10, 2),
	(7, 'pepsi', 5, 3),
	(8, 'coca-cola', 5, 3),
	(9, 'nestea', 4, 3);
/*!40000 ALTER TABLE `items` ENABLE KEYS */;


-- Dumping structure for table app1.points
CREATE TABLE IF NOT EXISTS `points` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `itemid` int(11) NOT NULL,
  `points` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_points_users` (`username`),
  KEY `FK_points_items` (`itemid`),
  CONSTRAINT `FK_points_users` FOREIGN KEY (`username`) REFERENCES `users` (`username`),
  CONSTRAINT `FK_points_items` FOREIGN KEY (`itemid`) REFERENCES `items` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Dumping data for table app1.points: ~4 rows (approximately)
DELETE FROM `points`;
/*!40000 ALTER TABLE `points` DISABLE KEYS */;
INSERT INTO `points` (`Id`, `username`, `itemid`, `points`) VALUES
	(1, 'user1', 1, 3),
	(2, 'user1', 2, 10),
	(3, 'user1', 3, 4),
	(4, 'user1', 2, 10);
/*!40000 ALTER TABLE `points` ENABLE KEYS */;


-- Dumping structure for table app1.users
CREATE TABLE IF NOT EXISTS `users` (
  `username` varchar(50) NOT NULL,
  `role` bit(1) NOT NULL,
  `password` varchar(50) DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `points` int(11) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table app1.users: ~4 rows (approximately)
DELETE FROM `users`;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`username`, `role`, `password`, `name`, `points`) VALUES
	('admin', b'1', 'admin', 'Mr. Administratorus', 2147483647),
	('user1', b'0', 'user1', 'Mr. Userus oanus', 70),
	('user2', b'0', 'user2', 'Mr. Userus twoiust', 120),
	('user3', b'0', 'user3', 'Mr. Userus threeious', 100);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;


-- Dumping structure for table app1.user_groups
CREATE TABLE IF NOT EXISTS `user_groups` (
  `groupid` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  PRIMARY KEY (`groupid`,`username`),
  KEY `FK_user_groups_users` (`username`),
  CONSTRAINT `FK_user_groups_groups` FOREIGN KEY (`groupid`) REFERENCES `groups` (`id`),
  CONSTRAINT `FK_user_groups_users` FOREIGN KEY (`username`) REFERENCES `users` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table app1.user_groups: ~5 rows (approximately)
DELETE FROM `user_groups`;
/*!40000 ALTER TABLE `user_groups` DISABLE KEYS */;
INSERT INTO `user_groups` (`groupid`, `username`) VALUES
	(1, 'admin'),
	(2, 'admin'),
	(2, 'user1'),
	(1, 'user2'),
	(2, 'user3');
/*!40000 ALTER TABLE `user_groups` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
