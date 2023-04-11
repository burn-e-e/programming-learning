-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 08, 2023 at 05:01 AM
-- Server version: 10.4.13-MariaDB
-- PHP Version: 7.2.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ems_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance_table`
--

CREATE TABLE `attendance_table` (
  `ID` int(50) DEFAULT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Department` varchar(50) DEFAULT NULL,
  `Phone` varchar(50) DEFAULT NULL,
  `Edu` varchar(50) DEFAULT NULL,
  `Gender` varchar(50) DEFAULT NULL,
  `DateOfBirth` varchar(50) DEFAULT NULL,
  `IN_Time` time(5) DEFAULT NULL,
  `Out_Time` time(5) DEFAULT NULL,
  `Status` int(50) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `attendance_table`
--

INSERT INTO `attendance_table` (`ID`, `Name`, `Address`, `Department`, `Phone`, `Edu`, `Gender`, `DateOfBirth`, `IN_Time`, `Out_Time`, `Status`) VALUES
(1, 'YonMin', 'Korea', 'HR', '+5698745623', 'M.B.A', 'Male', '1/29/1888', '07:56:41.00000', '08:08:27.00000', 0),
(2, 'Lieo.Sanay', 'France', 'IT', '+9865223475', 'M.C.Sc', 'Male', '1/29/1986', '08:02:41.00000', '08:03:39.00000', 0),
(2, 'Lieo.Sanay', 'France', 'IT', '+9865223475', 'M.C.Sc', 'Male', '1/29/1986', '08:07:42.00000', '08:08:57.00000', 0),
(1, 'YonMin', 'Korea', 'HR', '+5698745623', 'M.B.A', 'Male', '1/29/1888', '08:17:50.00000', '08:18:30.00000', 0),
(3, 'Sina', 'Indo', 'Cleaner', '+9865745224', 'U.G', 'Female', '2/1/1982', '08:21:23.00000', '08:22:25.00000', 0),
(3, 'Sina', 'Indo', 'Cleaner', '+9865745224', 'U.G', 'Female', '2/1/1982', '08:23:43.00000', '08:24:31.00000', 0),
(4, 'C.Ronoldo', 'France', 'IT', '+8956874500', 'M.E(IT)', 'Male', '2/8/1986', '08:29:30.00000', '08:30:28.00000', 0);

-- --------------------------------------------------------

--
-- Table structure for table `employee_tb`
--

CREATE TABLE `employee_tb` (
  `ID` int(50) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Department` varchar(50) DEFAULT NULL,
  `Phone` varchar(50) DEFAULT NULL,
  `Edu` varchar(50) DEFAULT NULL,
  `DateOfBirth` varchar(50) DEFAULT NULL,
  `Gender` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee_tb`
--

INSERT INTO `employee_tb` (`ID`, `Name`, `Address`, `Department`, `Phone`, `Edu`, `DateOfBirth`, `Gender`) VALUES
(1, 'YonMin', 'Korea', 'HR', '+5698745623', 'M.B.A', '1/29/1888', 'Male'),
(2, 'Lieo.Sanay', 'France', 'IT', '+9865223475', 'M.C.Sc', '1/29/1986', 'Male'),
(3, 'Sina', 'Indo', 'Cleaner', '+9865745224', 'U.G', '2/1/1982', 'Female'),
(4, 'C.Ronoldo', 'France', 'IT', '+8956874500', 'M.E(IT)', '2/8/1986', 'Male'),
(5, 'Jon.Bi', 'France', 'Security', '+659854563', 'U.G', '2/8/1982', 'Male'),
(8, 'Minn', 'Thiland', 'Accountant', '+66589455278', 'M.B.A', '1/16/1987', 'Female'),
(12, 'ff', 'fff', 'Accountant', 'h1122', 'ff', '2/1/1986', 'Male');

-- --------------------------------------------------------

--
-- Table structure for table `login_tb`
--

CREATE TABLE `login_tb` (
  `Username` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login_tb`
--

INSERT INTO `login_tb` (`Username`, `Password`) VALUES
('admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee_tb`
--
ALTER TABLE `employee_tb`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee_tb`
--
ALTER TABLE `employee_tb`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
