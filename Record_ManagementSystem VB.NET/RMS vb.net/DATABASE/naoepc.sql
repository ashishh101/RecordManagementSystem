-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 16, 2018 at 12:53 PM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `naoepc`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblpackage`
--

CREATE TABLE IF NOT EXISTS `tblpackage` (
`Package_id` int(11) NOT NULL,
  `Motherboard` varchar(50) DEFAULT NULL,
  `Processor` varchar(50) DEFAULT NULL,
  `HDD` varchar(50) DEFAULT NULL,
  `RAM` varchar(50) DEFAULT NULL,
  `Graphic_Card` varchar(50) DEFAULT NULL,
  `Case` varchar(50) DEFAULT NULL,
  `Price` double DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=1005 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpackage`
--

INSERT INTO `tblpackage` (`Package_id`, `Motherboard`, `Processor`, `HDD`, `RAM`, `Graphic_Card`, `Case`, `Price`) VALUES
(1001, 'Asrock H61', 'Intel i3 2100', 'SGATE 500GB', 'KNGSTN DDR3 1333 4GB', 'Nvidia GT430 1GB', 'ATX 600W', 18000),
(1002, 'ASUS H41', 'Intel Core2quad', 'SGATE 320GB', 'KNGSTN DDR3 1333 2GB', 'Nvidia GT220 1GB', 'ATX 600W', 15000),
(1004, 'ASROCK H61', 'Intel i5 2300k', 'WD 1.5TB', 'COSAIR DDR3 1333 16GB', 'Palit GT440 2GB', 'ATX 600W', 21050);

-- --------------------------------------------------------

--
-- Table structure for table `tblpassword`
--

CREATE TABLE IF NOT EXISTS `tblpassword` (
`employee_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2012002 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpassword`
--

INSERT INTO `tblpassword` (`employee_id`, `username`, `password`) VALUES
(2012001, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `tblspare`
--

CREATE TABLE IF NOT EXISTS `tblspare` (
`Product_id` int(11) NOT NULL,
  `Product_type` varchar(50) DEFAULT NULL,
  `Product_name` varchar(50) DEFAULT NULL,
  `Manufacturer` varchar(50) DEFAULT NULL,
  `Price` double DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2013 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblspare`
--

INSERT INTO `tblspare` (`Product_id`, `Product_type`, `Product_name`, `Manufacturer`, `Price`) VALUES
(2001, 'Motherboard', 'H61M-HVS', 'ASRock', 2500),
(2002, 'Processor', 'Core i3-2100', 'Intel', 5100),
(2003, 'Graphic Card', 'GeForce GT430 2GB', 'Inno3d', 3000),
(2005, 'Hard Disk Drive', 'BARRACUDA 500GB', 'SEAGATES', 4010),
(2006, 'Monitor', '16" LED', 'Samsung', 3200),
(2007, 'Hard Disk Drive', 'SATA 1TB', 'Western Digital', 7800),
(2008, 'Processor', 'Core i7-2600k', 'Intel', 13550),
(2009, 'Graphic Card', 'GeForce GT440 1GB', 'Palit', 3120),
(2010, 'Motherboard', 'G41M-HVS', 'ASRock', 2450),
(2011, 'Monitor', '21" LED ', 'Sony', 12250),
(2012, 'Comp. Accessory', 'Gaming Mouse', 'Fantech', 2100);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblpackage`
--
ALTER TABLE `tblpackage`
 ADD PRIMARY KEY (`Package_id`);

--
-- Indexes for table `tblpassword`
--
ALTER TABLE `tblpassword`
 ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `tblspare`
--
ALTER TABLE `tblspare`
 ADD PRIMARY KEY (`Product_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblpackage`
--
ALTER TABLE `tblpackage`
MODIFY `Package_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=1005;
--
-- AUTO_INCREMENT for table `tblpassword`
--
ALTER TABLE `tblpassword`
MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2012002;
--
-- AUTO_INCREMENT for table `tblspare`
--
ALTER TABLE `tblspare`
MODIFY `Product_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2013;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
