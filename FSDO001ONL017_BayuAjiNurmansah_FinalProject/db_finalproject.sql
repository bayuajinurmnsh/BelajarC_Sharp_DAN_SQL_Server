-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 22, 2021 at 12:49 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_finalproject`
--

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(85) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(85) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(85) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(85) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(85) NOT NULL,
  `ProviderKey` varchar(85) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` varchar(85) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(85) NOT NULL,
  `RoleId` varchar(85) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(85) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(85) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(85) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('2f85c0e9-ac5e-4b30-9fde-9c49b463ee98', 'bayu3', 'BAYU3', 'bayu3@gmail.com', 'BAYU3@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEG6yFo9kr9gar+jq0r0NCmLg0SMWQkaLIu3tRAAdDYJpRzkAW9MBZBHam0IwVNEDVA==', '2PDWP7O6RGRYMSJEHH62QVFRJG3743AD', '8edbabfa-c6ff-406b-a8f7-e218a4f36ea2', NULL, 0, 0, NULL, 1, 0),
('893bdf0d-a6b4-44ad-941d-d514b25bbf29', 'coba', 'COBA', 'coba@gmail.com', 'COBA@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEOO7tmWhYB0LGZGVXnxA//sFld/j2OPq1DPFVClWfBYzXVp9BpwFG3P0eeQcyUK42A==', '7APTHNRBC36JA7MOJLSPEWM2TMWKYSPI', '650107ca-df4f-4cf3-8084-51184e7fceee', NULL, 0, 0, NULL, 1, 0),
('af0e312f-26fa-415d-85a4-01f8ddaa860c', 'bayu1', 'BAYU1', 'bayu1@gmail.com', 'BAYU1@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAECaIPrPa7qzeIOOFYf90QU26M/LswbCqAGxHZq2TtIJpPn+UK3MZ1E2P7sCfPXW2ig==', 'LNBJE3XLKKWNDDFCOOSAPN5XUUGHXAQG', '0f0423a2-7bc2-4519-86d6-ecb16e2809bf', NULL, 0, 0, NULL, 1, 0),
('be81e5f9-2302-425c-87d6-18ac847be937', 'bayu2', 'BAYU2', 'bayu2@gmail.com', 'BAYU2@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEIetZKesGyCUzhTtJYK3/48wbHjo5uXn5ilvYto+TVTmu6lsOnbGRQ+H9dnV9Qy+Ww==', 'PCHMCZO35U7E6RKHN5VGPOEGP5RRBG6R', '6538c431-4bf9-4eeb-938f-5f34b3514599', NULL, 0, 0, NULL, 1, 0),
('d0a02420-16cb-49c9-9a32-7ad4dda8e479', 'bayu', 'BAYU', 'bayu@gmail.com', 'BAYU@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEPn3ij5eTUPKeAvazyWL+bdALR3qOEpmSu97ffeTEI/cJbnUrmz62+CQtqUXUE5fDQ==', 'OXFSXQEKXJ3IFICTKZ3QW36BCGZJPMJ5', 'd7eb9969-6c68-4372-9bdd-adfa10d0883a', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(85) NOT NULL,
  `LoginProvider` varchar(85) NOT NULL,
  `Name` varchar(85) NOT NULL,
  `Value` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ownerdetails`
--

CREATE TABLE `ownerdetails` (
  `ownerId` int(11) NOT NULL,
  `ownerCardNumber` longtext NOT NULL,
  `ownerName` longtext NOT NULL,
  `ownerAddress` longtext NOT NULL,
  `status` longtext NOT NULL,
  `createdDate` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ownerdetails`
--

INSERT INTO `ownerdetails` (`ownerId`, `ownerCardNumber`, `ownerName`, `ownerAddress`, `status`, `createdDate`) VALUES
(1, '1234-5678-9-0', 'Bayu Aji Nurmansah', 'Medan', 'active', '2021-10-21 16:27:57.553000'),
(2, '1234-5678-9-1', 'Jonn Snow', 'Winterfell', 'active', '2021-10-21 16:27:57.553000'),
(4, '1234-5678-9-2', 'Robert Baratheon', 'King\'s Landing', 'active', '2021-10-21 16:27:57.553000');

-- --------------------------------------------------------

--
-- Table structure for table `paymentdetails`
--

CREATE TABLE `paymentdetails` (
  `paymentDetailId` int(11) NOT NULL,
  `cardOwnerName` longtext NOT NULL,
  `cardNumber` longtext NOT NULL,
  `expirationDate` datetime(6) NOT NULL,
  `securityCode` longtext NOT NULL,
  `totalTransactions` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `paymentdetails`
--

INSERT INTO `paymentdetails` (`paymentDetailId`, `cardOwnerName`, `cardNumber`, `expirationDate`, `securityCode`, `totalTransactions`) VALUES
(1, 'Bayu Aji Nurmansah', '1234-5678-9-0', '2021-10-21 16:30:45.697000', '1234', 150500);

-- --------------------------------------------------------

--
-- Table structure for table `refreshtokens`
--

CREATE TABLE `refreshtokens` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(85) DEFAULT NULL,
  `Token` longtext DEFAULT NULL,
  `JwtId` longtext DEFAULT NULL,
  `IsUsed` tinyint(1) NOT NULL,
  `IsRevorked` tinyint(1) NOT NULL,
  `AddedDate` datetime(6) NOT NULL,
  `ExpiryDate` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `refreshtokens`
--

INSERT INTO `refreshtokens` (`Id`, `UserId`, `Token`, `JwtId`, `IsUsed`, `IsRevorked`, `AddedDate`, `ExpiryDate`) VALUES
(1, 'd0a02420-16cb-49c9-9a32-7ad4dda8e479', '7Q71CCCBI7YNIADLHESEGRRX2V764BCW24K762985dc-8e8e-432e-a2da-b327a14e0c7d', 'a928c08e-1e71-4bac-87f8-b21afac26adc', 0, 0, '2021-10-21 16:26:57.290891', '2022-04-21 16:26:57.290940'),
(2, 'd0a02420-16cb-49c9-9a32-7ad4dda8e479', 'WX2Q675EN7KQT39KCV7JCAF4V407D96DGKR66c53f9f-3545-4ee7-8f5a-87c47b327dd5', '6efda607-467d-4f90-adf9-38443c24c7cb', 0, 0, '2021-10-21 16:27:14.389656', '2022-04-21 16:27:14.389657'),
(3, 'af0e312f-26fa-415d-85a4-01f8ddaa860c', 'AUPIHIYQELN3YCQRCX15SO4WL6FCAOQ1X962156c7be-d0e4-4747-a01c-9b1d025b20a3', 'b95b6d49-9584-410c-9f95-71894af27fd8', 0, 0, '2021-10-21 16:51:03.876535', '2022-04-21 16:51:03.876536'),
(4, 'be81e5f9-2302-425c-87d6-18ac847be937', 'MLLXU4XGLQD4KLPC2LA57QYX1NMVROLOV01f9c70071-8f72-4470-8b64-4b90ff862b17', 'a9124652-2daa-4200-a716-a5b531081cc9', 0, 0, '2021-10-21 16:51:38.477381', '2022-04-21 16:51:38.477381'),
(5, '2f85c0e9-ac5e-4b30-9fde-9c49b463ee98', 'CVDFL4LCGW8DE4PCWD7EGGJ5OWP1VSDP9CN7f5351c5-fd4c-4a27-9dd0-759c600fe81d', 'feaba578-30a3-4774-b6da-3be0725df8f5', 0, 0, '2021-10-21 16:52:35.672557', '2022-04-21 16:52:35.672557'),
(6, '893bdf0d-a6b4-44ad-941d-d514b25bbf29', 'M9XSX2QOI92L3MW0X2Z9MCICBI4HXM2ZXQ6cb208cc8-532d-4d99-8998-4bc2f26689c4', 'c2f3655f-9391-45ac-9564-ea1d87b0ff1a', 0, 0, '2021-10-21 16:58:52.643751', '2022-04-21 16:58:52.643751'),
(7, '893bdf0d-a6b4-44ad-941d-d514b25bbf29', 'VQZ50TDHTKSDMRA7WZF40HAG9HJ6VX22J3Naa183b76-a46d-427a-9eb5-b01956e96dae', '7c4dd4a1-9009-4729-aff6-fa1b8d274d27', 0, 0, '2021-10-21 17:00:21.947453', '2022-04-21 17:00:21.947453'),
(8, 'd0a02420-16cb-49c9-9a32-7ad4dda8e479', 'W9F5N62KFNVZKQ84Z27TB2AM5ABTY2PYEXU5a81de2b-d2d5-408e-aadc-83b9ffa135ec', '4eb3af4e-7c30-4006-89dc-853f2b761d2c', 0, 0, '2021-10-21 22:18:08.251280', '2022-04-21 22:18:08.251327');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20211021161409_Final Project with MySql', '5.0.11');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `ownerdetails`
--
ALTER TABLE `ownerdetails`
  ADD PRIMARY KEY (`ownerId`);

--
-- Indexes for table `paymentdetails`
--
ALTER TABLE `paymentdetails`
  ADD PRIMARY KEY (`paymentDetailId`);

--
-- Indexes for table `refreshtokens`
--
ALTER TABLE `refreshtokens`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_RefreshTokens_UserId` (`UserId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `ownerdetails`
--
ALTER TABLE `ownerdetails`
  MODIFY `ownerId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `paymentdetails`
--
ALTER TABLE `paymentdetails`
  MODIFY `paymentDetailId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `refreshtokens`
--
ALTER TABLE `refreshtokens`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `refreshtokens`
--
ALTER TABLE `refreshtokens`
  ADD CONSTRAINT `FK_RefreshTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
