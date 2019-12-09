-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 09, 2019 at 10:13 PM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `listpages`
--

-- --------------------------------------------------------

--
-- Table structure for table `page1`
--

CREATE TABLE IF NOT EXISTS `page1` (
  `pageid` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `pagetitle` varchar(255) NOT NULL,
  `pagebody` mediumtext NOT NULL,
  PRIMARY KEY (`pageid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `page1`
--

INSERT INTO `page1` (`pageid`, `pagetitle`, `pagebody`) VALUES
(3, 'Facebook', 'Enjoy beautiful pictures'),
(4, 'Instagram', 'Enjoy beautiful pictures'),
(5, 'Twitter', 'Have a new Experience'),
(9, 'Whatsapp', 'easy to use');
