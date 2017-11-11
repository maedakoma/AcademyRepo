-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost:3306
-- Généré le :  Sam 11 Novembre 2017 à 14:57
-- Version du serveur :  5.1.73-community
-- Version de PHP :  5.5.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `baugma143158com32659_cercle_academy`
--
CREATE DATABASE IF NOT EXISTS `baugma143158com32659_cercle_academy` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `baugma143158com32659_cercle_academy`;

-- --------------------------------------------------------

--
-- Structure de la table `coachspayments`
--

CREATE TABLE `coachspayments` (
  `ID` int(11) NOT NULL,
  `MemberID` int(11) NOT NULL,
  `Month` varchar(200) DEFAULT NULL,
  `Lessons` int(11) DEFAULT NULL,
  `Pay` int(11) DEFAULT NULL,
  `Amount` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Comment` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `coachspayments`
--

INSERT INTO `coachspayments` (`ID`, `MemberID`, `Month`, `Lessons`, `Pay`, `Amount`, `Date`, `Comment`) VALUES
(1, 130, 'Septembre', 4, 25, 100, '2017-10-11', NULL),
(2, 129, 'Septembre', 11, 25, 275, '2017-10-01', NULL),
(3, 131, 'Septembre', 3, 30, 90, '2017-10-20', NULL),
(4, 129, 'Octobre', 12, 25, 300, '2017-11-01', NULL),
(5, 130, 'Octobre', 3, 25, 75, '2017-11-07', NULL),
(6, 132, 'Octobre', 9, 25, 225, '2017-11-07', NULL),
(7, 131, 'Octobre', 5, 30, 150, '2017-11-11', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `dojo`
--

CREATE TABLE `dojo` (
  `ID` int(11) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Surface` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `dojo`
--

INSERT INTO `dojo` (`ID`, `Name`, `Surface`) VALUES
(1, 'Petite Salle du bas', 30),
(2, 'Principale', 80),
(3, 'Salle du haut', 50);

-- --------------------------------------------------------

--
-- Structure de la table `members`
--

CREATE TABLE `members` (
  `ID` int(11) NOT NULL,
  `Firstname` varchar(200) NOT NULL,
  `Lastname` varchar(200) NOT NULL,
  `Enddate` date DEFAULT NULL,
  `Belt` enum('white','blue','purple','brown','black') NOT NULL,
  `Gender` enum('M','F') NOT NULL,
  `Child` tinyint(4) NOT NULL,
  `Alert` tinyint(4) NOT NULL,
  `Comment` text CHARACTER SET latin1,
  `Job` varchar(200) DEFAULT NULL,
  `Active` tinyint(4) DEFAULT NULL,
  `Coach` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `members`
--

INSERT INTO `members` (`ID`, `Firstname`, `Lastname`, `Enddate`, `Belt`, `Gender`, `Child`, `Alert`, `Comment`, `Job`, `Active`, `Coach`) VALUES
(1, 'David', 'GAUTHIER', '2018-09-12', 'blue', 'M', 0, 0, '', '', 1, 0),
(2, 'Raphael', 'ARIE', '2017-10-05', 'blue', 'M', 0, 0, '', '', 1, 0),
(3, 'Zacharie', 'ATTALI', '2018-10-17', 'white', 'M', 0, 0, 'Vient de débuter', '', 1, 0),
(4, 'Eddy', 'BARCLAY', '2018-09-12', 'white', 'M', 0, 0, 'En attente de 2 cheques que j''ai donné à Kelly -> Récupérés le 09/11/2017', '', 1, 0),
(6, 'Frederique', 'BARDEY', '2018-09-26', 'white', 'M', 0, 0, 'référencé en remy au cercle?', '', 1, 0),
(7, 'John', 'BARFF', '2017-10-05', 'white', 'M', 0, 0, '', '', 0, 0),
(8, 'Didier', 'BARRAUD', '2018-09-15', 'black', 'M', 0, 0, 'Son fils est aussi inscrit mais on lui a fait cadeau du paiement', '', 1, 0),
(9, 'Lionel', 'BENICHOU', '2018-09-28', 'white', 'M', 1, 0, '', '', 1, 0),
(10, 'Sebastien', 'BIDAULT', '2018-09-11', 'white', 'M', 0, 0, '', '', 1, 0),
(11, 'Farid', 'BOUHAZEM', '2018-09-12', 'white', 'M', 0, 0, '', '', 1, 0),
(12, 'Julien', 'BOURGEOIS', '2018-09-15', 'white', 'M', 0, 0, '', '', 1, 0),
(13, 'Gauthier', 'BRYSBAERT', '2018-09-11', 'white', 'M', 0, 0, '', '', 1, 0),
(15, 'Sacha', 'BUKASSA', '2017-10-29', 'white', 'M', 1, 0, 'A demandé le remboursement....Puis se l''est fait remboursé, je lui ai rendu un cheque', '', 0, 0),
(16, 'Corentin', 'CAHEN', '2018-10-04', 'white', 'M', 0, 0, '', '', 1, 0),
(17, 'Sarah', 'CASSESE', '2018-09-25', 'blue', 'F', 1, 0, '', '', 1, 0),
(18, 'Thomas', 'CASTAN', '2018-09-25', 'white', 'M', 0, 0, 'Collèque de sylvain', '', 1, 0),
(19, 'Pierre', 'CHAMBON', '2018-09-26', 'white', 'M', 0, 0, '2 disciplines j''imagine?', '', 1, 0),
(20, 'Bagdad', 'CHECKRI', '2018-09-04', 'purple', 'M', 0, 0, '', '', 1, 0),
(21, 'Adrien', 'CHEMINET', '2018-09-20', 'white', 'M', 0, 0, '', '', 1, 0),
(22, 'Cyril', 'CHIMKIEVITCH', '2017-11-04', 'white', 'M', 0, 1, 'C''est quoi son abonnement?', '', 1, 0),
(23, 'Aime', 'CONTI', '2018-10-10', 'black', 'M', 0, 0, '', '', 1, 0),
(24, 'Ricardo', 'RIBEIRO', '2017-11-04', 'white', 'M', 0, 0, 'blessé au genou le 3/11. Redonne les cheques ou pas?', '', 1, 0),
(25, 'Olivier', 'DAURARIO', '2018-10-10', 'white', 'M', 0, 0, '', '', 1, 0),
(26, 'Christian', 'DEGUIS', '2017-11-04', 'white', 'M', 0, 1, 'C''est quoi ce taro?', '', 1, 0),
(27, 'Mamadou?', 'DJOULFAYAN', '2018-10-16', 'white', 'M', 0, 0, '', '', 1, 0),
(28, 'Fabien', 'DORE', '2018-09-04', 'blue', 'M', 0, 0, '', '', 1, 0),
(29, 'Raphael', 'DOS SANTOS', '2018-09-04', 'blue', 'M', 0, 0, '', '', 1, 0),
(31, 'Eric', 'DRIKES', '2018-09-04', 'white', 'M', 0, 0, '', '', 1, 0),
(32, 'Mickael', 'FERREIRA', '2018-09-12', 'white', 'M', 0, 0, '', '', 1, 0),
(33, 'Brice', 'FIGARO', '2018-10-04', 'white', 'M', 0, 0, '900 au cercle et 80 chez moi???', '', 1, 0),
(34, 'Marc antoine', 'FIGHIERA', '2018-09-08', 'blue', 'M', 0, 0, '', '', 1, 0),
(36, 'Florian', 'FONTRIER', '2018-09-15', 'white', 'M', 0, 0, '', '', 1, 0),
(37, 'Jean Paul', 'FOURNET', '2018-09-26', 'white', 'M', 0, 0, '', '', 1, 0),
(38, 'Simon', 'FRANQUET', '2018-09-12', 'white', 'M', 0, 0, '', '', 1, 0),
(39, 'Bayle', 'GAO', '2018-10-04', 'purple', 'M', 0, 0, '', 'ingenieur robotique', 1, 0),
(42, 'Julien', 'GAZAVE', '2018-12-09', 'white', 'M', 0, 0, '', '', 1, 0),
(43, 'Yoann', 'GOLESTIN', '2018-09-07', 'white', 'M', 0, 0, '', '', 1, 0),
(44, 'Matias', 'GOURDON', '2018-07-01', 'white', 'M', 0, 0, '', '', 1, 0),
(45, 'Raphael', 'GRESSIN', NULL, 'white', 'M', 1, 0, NULL, NULL, 1, 0),
(46, 'Jules', 'GRUBO', '2018-10-12', 'white', 'M', 0, 0, '', '', 1, 0),
(47, 'Olivier', 'HASSID', '2018-09-20', 'white', 'M', 1, 0, '', '', 1, 0),
(48, 'Dominique', 'JACQUES', '2018-10-10', 'white', 'M', 0, 0, '', '', 1, 0),
(49, 'Sylvain', 'JOLIY', '2018-09-11', 'white', 'M', 0, 0, '', '', 1, 0),
(50, 'Nabil', 'KADID', '2018-10-04', 'white', 'M', 0, 0, '', '', 1, 0),
(51, 'Olivier', 'KAZ', '2017-11-20', 'white', 'M', 0, 0, '', '', 1, 0),
(52, 'Artyom', 'KORMESHOV', '2018-09-20', 'white', 'M', 0, 0, '', '', 1, 0),
(53, 'Vincent', 'LACERENZA', '2018-09-20', 'white', 'M', 0, 0, '', '', 1, 0),
(54, 'Cedric', 'LE FRANC', '2018-04-04', 'white', 'M', 0, 0, '', '', 1, 0),
(55, 'Jonas', 'LEBLANC', '2017-11-04', 'white', 'M', 0, 0, '', '', 1, 0),
(56, 'Yohann', 'LES ENFANT', '2018-09-01', 'white', 'M', 0, 0, '', '', 1, 0),
(57, 'Gregory', 'LETELLIER', '2018-09-26', 'white', 'M', 0, 0, '', '', 1, 0),
(58, 'Anne', 'LETESSIER', '2018-09-04', 'white', 'F', 1, 0, '', '', 1, 0),
(59, 'Thomas', 'MACHADO', '2018-09-04', 'white', 'M', 0, 0, '', '', 1, 0),
(61, 'Charles', 'MACQUART MOULIN', '2018-10-10', 'white', 'M', 0, 0, 'Blessé pour le mois de novembre, pb aux cotes', '', 1, 0),
(62, 'Yann', 'MALARD', '2018-09-12', 'purple', 'M', 0, 0, '', 'notaire', 1, 0),
(63, 'Marco', 'MARZILLI', '2018-09-20', 'brown', 'M', 0, 0, '', '', 1, 0),
(64, 'Didier', 'MAUS', '2018-10-15', 'purple', 'M', 0, 0, '', '', 1, 0),
(65, 'Franck', 'NGUYEN', '2018-09-07', 'purple', 'M', 0, 0, '', '', 1, 0),
(66, 'Stephane', 'NGUYEN', '2018-07-11', 'white', 'M', 0, 0, 'Veut faire la compet ibjjf je crois, en attente de licence', '', 1, 0),
(67, 'Nicolas', 'NZAMBA', '2018-09-28', 'white', 'M', 0, 0, '', '', 1, 0),
(68, 'Noel', 'ONIZKO', '2017-10-14', 'white', 'M', 0, 0, '', '', 1, 0),
(69, 'Alban', 'OUAHAB', '2018-09-20', 'blue', 'M', 0, 0, '', '', 1, 0),
(70, 'Samuel', 'PELLET', '2017-11-04', 'white', 'M', 0, 1, 'C''est quoi son abonnement?', '', 1, 0),
(72, 'Marc', 'PELLET', '2017-11-04', 'white', 'M', 0, 1, 'C''est quoi son abonnement? Marc et Samuel pareil? Apparement c''est le pere de samuel', '', 1, 0),
(73, 'Emmanuel', 'PEREIRA VIEIRA', '2018-09-21', 'white', 'M', 0, 0, '', 'livreur dans les librairies', 1, 0),
(74, 'Celine', 'PERREARD', '2017-10-14', 'white', 'M', 0, 0, '', '', 1, 0),
(75, 'Jeremy', 'PICOSTE', '2018-10-10', 'black', 'M', 0, 0, 'tarif réduit du cercle', '', 1, 0),
(76, 'Mirjana', 'POLJAKOVIC', '2018-10-04', 'white', 'M', 0, 0, '', '', 1, 0),
(77, 'François David', 'PUCHEU LASHORES', '2018-09-20', 'purple', 'M', 0, 0, '', '', 1, 0),
(78, 'Vincent', 'PUYDOYEUX', '2018-10-16', 'white', 'M', 0, 0, '', '', 1, 0),
(79, 'Djamel', 'SAHRAOUI', '2018-09-20', 'white', 'M', 0, 0, '', '', 1, 0),
(80, 'Mehdi', 'SAIDI', '2018-09-20', 'white', 'M', 0, 0, '', '', 1, 0),
(81, 'Nelson', 'SILVA', '2018-09-11', 'white', 'M', 0, 0, 'brown belt?', '', 1, 0),
(82, 'Andrei', 'STRUTGNSHGG', '2017-10-14', 'white', 'M', 0, 0, 'C''est quoi son abo a 250 ?', '', 1, 0),
(83, 'Sylvain', 'TARIN', '2018-10-10', 'purple', 'M', 0, 0, '', '', 1, 0),
(84, 'Vincent', 'TERRONI', '2018-09-21', 'white', 'M', 1, 0, '', '', 1, 0),
(85, 'Adrien', 'TIREL', '2017-11-16', 'white', 'M', 0, 0, '', '', 1, 0),
(86, 'Christophe', 'TROEL', '2018-09-15', 'white', 'M', 0, 0, '', '', 1, 0),
(87, 'Alexis', 'TRUJILLO', '2018-09-20', 'white', 'M', 0, 0, '', '', 1, 0),
(88, 'Arthur', 'TSIMI', '2018-09-12', 'white', 'M', 0, 0, '', '', 1, 0),
(89, 'Yohan', 'VERGNE', '2018-09-08', 'white', 'M', 0, 0, '', '', 1, 0),
(90, 'Guillaume', 'VIGNE', '2018-10-04', 'purple', 'M', 0, 0, '', '', 1, 0),
(91, 'Paul-François', 'YGORRA', '2018-09-20', 'white', 'M', 0, 0, '', '', 1, 0),
(92, 'Nissim', 'ZERBIB', '2018-09-15', 'white', 'M', 0, 0, '', '', 1, 0),
(99, 'Neo', 'ALZIEU', '2017-11-04', 'white', 'M', 0, 1, 'C''est quoi son abo? un enfant?', '', 1, 0),
(100, 'Frederique', 'AMBROISE', '2018-06-01', 'white', 'M', 0, 0, 'Grand martiniquais, inscrit a 2 disciplines', '', 1, 0),
(101, 'Jean-Marc', 'BLOMBOU', '2017-10-29', 'blue', 'M', 0, 1, 'A repris ses derniers cheques et doit en rendre 2 autres...', '', 1, 0),
(102, 'Amandine', 'BOUVAT', '2018-05-10', 'white', 'F', 0, 0, 'C''est qui elle?', '', 1, 0),
(103, 'Manuel', 'BRUN', '2017-09-04', 'white', 'M', 0, 1, 'C''est quoi son abo?', '', 1, 0),
(104, 'Aurianne', 'CHARMET', '2017-06-04', 'white', 'M', 0, 0, '', '', 0, 0),
(105, 'Daniel', 'CURVAT', '2018-06-05', 'white', 'M', 0, 0, '', '', 1, 0),
(106, 'Jerome', 'DIVAC', '2018-02-04', 'blue', 'M', 0, 0, '', '', 1, 0),
(107, 'Jorge', 'DO PINHAL', '2018-05-04', 'white', 'M', 0, 0, '', '', 1, 0),
(108, 'Gwenael', 'HUET', '2018-05-10', 'blue', 'M', 0, 0, '', '', 1, 0),
(109, 'Guillaume', 'LE MAUT', NULL, 'white', 'M', 0, 0, NULL, NULL, 1, 0),
(110, 'Kevin', 'MALGERARD', '2017-06-10', 'white', 'M', 0, 0, '', '', 0, 0),
(111, 'Joan', 'MESINELE', '2018-05-10', 'white', 'M', 0, 0, '', '', 1, 0),
(112, 'Moustakim', 'HASSANI', '2018-06-04', 'purple', 'M', 0, 0, '', '', 1, 0),
(113, 'Samuel', 'OLIVIER', '2018-03-02', 'white', 'M', 0, 0, '', '', 1, 0),
(114, 'David', 'THOMAS', '2017-07-01', 'white', 'M', 0, 0, '', '', 0, 0),
(115, 'Moussa', 'TIMERA', '2018-05-04', 'white', 'M', 0, 0, '', '', 1, 0),
(116, 'Alexandre', 'WALLOIS', '2018-04-04', 'white', 'M', 0, 0, '', '', 1, 0),
(120, 'Simon', 'THULEAU', '2018-11-09', 'white', 'M', 0, 0, '', '', 1, 0),
(121, 'Thomas', 'BISSON', '2017-12-09', 'white', 'M', 0, 0, '', '', 1, 0),
(122, 'Sofien', 'ZAMITTI', '2017-12-09', 'white', 'M', 0, 0, '', '', 1, 0),
(123, 'Alessandro', 'ZANNI', '2018-11-09', 'brown', 'M', 0, 0, 'C''est quoi sa 2eme discipline à lui?', '', 1, 0),
(124, 'Hichem', 'ARFAOUI', '2018-11-09', 'white', 'M', 0, 0, 'C''est quoi ça comme taro 350 en cheque? 2 disciplines j''imagine', '', 1, 0),
(125, 'Olivier', 'ROINEL', '2018-11-09', 'white', 'M', 0, 0, '', '', 1, 0),
(126, 'Martin', 'CZABADAJ', '2017-12-09', 'blue', 'M', 0, 0, 'veut faire la coupe de zone mais s''inscrit qu''un mois??', '', 1, 0),
(127, 'Denis', 'DAVIDKOV', '2017-12-09', 'blue', 'M', 0, 0, 'peut etre bleu. Pourquoi j''ai reçu ce montant et pas 30 E?', '', 1, 0),
(128, 'Thibaut', 'OLIVIER', '2019-12-11', 'black', 'M', 0, 0, '', '', 1, 1),
(129, 'François', 'MOLESLAS', '2020-11-11', 'brown', 'M', 0, 0, '', '', 1, 1),
(130, 'Stéphane', 'HENNEQUIN', '2020-11-11', 'black', 'M', 0, 0, '', '', 1, 1),
(131, 'Etienne', 'GREGOIRE', '2019-12-01', 'black', 'M', 0, 0, '', '', 1, 1),
(132, 'Matthieu', 'DELALANDRE', '2019-12-11', 'black', 'M', 0, 0, '', '', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `members_payments`
--

CREATE TABLE `members_payments` (
  `MemberID` int(11) NOT NULL,
  `PaymentID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `members_payments`
--

INSERT INTO `members_payments` (`MemberID`, `PaymentID`) VALUES
(109, 452),
(45, 684),
(6, 756),
(6, 757),
(8, 759),
(13, 787),
(13, 788),
(16, 789),
(17, 790),
(19, 793),
(20, 795),
(21, 796),
(105, 799),
(25, 800),
(26, 801),
(106, 802),
(107, 804),
(28, 805),
(31, 807),
(31, 808),
(33, 811),
(36, 816),
(38, 819),
(38, 820),
(44, 833),
(44, 834),
(47, 837),
(112, 838),
(108, 839),
(48, 840),
(49, 841),
(51, 846),
(52, 847),
(52, 848),
(53, 849),
(53, 850),
(53, 851),
(55, 857),
(56, 858),
(57, 859),
(58, 860),
(61, 864),
(63, 869),
(111, 871),
(111, 872),
(111, 873),
(111, 874),
(111, 875),
(65, 877),
(66, 878),
(66, 879),
(113, 883),
(113, 884),
(68, 885),
(74, 902),
(76, 904),
(77, 905),
(79, 910),
(79, 911),
(79, 912),
(79, 913),
(79, 914),
(80, 915),
(83, 920),
(115, 925),
(85, 926),
(87, 931),
(88, 932),
(89, 933),
(116, 939),
(91, 940),
(91, 941),
(91, 942),
(91, 943),
(91, 944),
(91, 945),
(91, 946),
(91, 947),
(91, 948),
(99, 952),
(2, 953),
(9, 955),
(102, 956),
(102, 957),
(102, 958),
(102, 959),
(102, 960),
(103, 961),
(22, 963),
(24, 964),
(24, 965),
(24, 966),
(82, 967),
(78, 971),
(27, 972),
(90, 973),
(90, 974),
(90, 975),
(90, 976),
(90, 977),
(23, 978),
(59, 979),
(59, 980),
(59, 981),
(46, 982),
(43, 983),
(43, 984),
(43, 985),
(43, 986),
(43, 987),
(69, 988),
(69, 989),
(69, 990),
(69, 991),
(11, 992),
(11, 993),
(11, 994),
(11, 995),
(11, 996),
(11, 997),
(11, 998),
(11, 999),
(11, 1000),
(86, 1001),
(86, 1002),
(86, 1003),
(86, 1004),
(62, 1005),
(62, 1006),
(62, 1007),
(3, 1008),
(3, 1009),
(39, 1010),
(39, 1011),
(75, 1012),
(64, 1013),
(92, 1014),
(92, 1015),
(50, 1017),
(50, 1018),
(50, 1019),
(50, 1020),
(67, 1021),
(67, 1022),
(67, 1023),
(37, 1024),
(37, 1025),
(32, 1028),
(32, 1029),
(73, 1030),
(73, 1031),
(73, 1032),
(73, 1033),
(73, 1034),
(34, 1035),
(34, 1036),
(34, 1037),
(34, 1038),
(84, 1039),
(84, 1040),
(84, 1041),
(54, 1042),
(54, 1043),
(54, 1044),
(54, 1045),
(54, 1046),
(10, 1047),
(10, 1048),
(10, 1049),
(10, 1050),
(10, 1051),
(1, 1052),
(1, 1053),
(1, 1054),
(1, 1055),
(81, 1056),
(81, 1057),
(81, 1058),
(12, 1059),
(12, 1060),
(12, 1061),
(12, 1062),
(12, 1063),
(114, 1068),
(15, 1078),
(15, 1079),
(15, 1080),
(7, 1081),
(104, 1082),
(110, 1083),
(72, 1084),
(70, 1085),
(70, 1086),
(29, 1087),
(29, 1088),
(123, 1110),
(123, 1111),
(120, 1112),
(121, 1113),
(122, 1114),
(124, 1115),
(125, 1119),
(125, 1120),
(126, 1121),
(18, 1122),
(18, 1123),
(18, 1124),
(42, 1125),
(42, 1126),
(4, 1127),
(4, 1128),
(4, 1129),
(127, 1130),
(100, 1132),
(101, 1143),
(101, 1144),
(101, 1145),
(101, 1146),
(101, 1147);

-- --------------------------------------------------------

--
-- Structure de la table `payments`
--

CREATE TABLE `payments` (
  `ID` int(11) NOT NULL,
  `Amount` int(11) DEFAULT NULL,
  `Type` varchar(20) DEFAULT NULL,
  `ReceptionDate` date DEFAULT NULL,
  `Name` varchar(200) DEFAULT NULL,
  `Debt` int(11) DEFAULT NULL,
  `DepotBank` tinyint(4) DEFAULT NULL,
  `DepotDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `payments`
--

INSERT INTO `payments` (`ID`, `Amount`, `Type`, `ReceptionDate`, `Name`, `Debt`, `DepotBank`, `DepotDate`) VALUES
(452, 140, 'Cash', '2017-06-01', 'Guillaume LE MAUT', 84, 0, '2017-10-26'),
(684, 280, 'Check', '2017-10-05', 'Raphael GRESSIN', 168, 1, '2017-10-06'),
(756, 50, 'Cash', '2017-10-02', 'Frederique BARDEY', 0, 0, '2017-10-26'),
(757, 250, 'Check', '2017-10-02', 'Frederique BARDEY', 150, 1, '2017-10-04'),
(759, 500, 'Check', '2017-09-15', 'Didier BARRAUD', 300, 1, '2017-09-16'),
(787, 500, 'Check', '2017-09-12', 'Gauthier BRYSBAERT', 300, 0, '2017-10-26'),
(788, 80, 'Check', '2017-06-01', 'Gauthier BRYSBAERT', 48, 1, '2017-06-04'),
(789, 500, 'Check', '2017-10-05', 'Corentin CAHEN', 300, 1, '2017-10-06'),
(790, 280, 'Check', '2017-09-25', 'Sarah CASSESE', 168, 1, '2017-10-04'),
(793, 350, 'Check', '2017-10-05', 'Pierre CHAMBON', 210, 1, '2017-10-06'),
(795, 120, 'Cash', '2017-09-05', 'Bagdad CHECKRI', 0, 0, '2017-10-26'),
(796, 500, 'Check', '2017-09-25', 'Adrien CHEMINET', 300, 1, '2017-10-04'),
(799, 350, 'Check', '2017-07-11', 'Daniel CURVAT', 210, 1, '2017-08-02'),
(800, 200, 'Cash', '2017-09-28', 'Olivier DAURARIO', 0, 0, '2017-10-26'),
(801, 220, 'Check', '2017-09-05', 'Christian DEGUIS', 132, 1, '2017-09-06'),
(802, 500, 'Check', '2017-05-10', 'Jerome DIVAC', 300, 1, '2017-05-11'),
(804, 500, 'Check', '2017-07-18', 'Jorge DO PINHAL', 300, 1, '2017-08-02'),
(805, 500, 'Check', '2017-09-07', 'Pierre DORE', 300, 1, '2017-09-07'),
(807, 80, 'Cash', '2017-09-14', 'Eric DRIKES', 0, 0, '2017-10-26'),
(808, 80, 'Cash', '2017-10-16', 'Eric DRIKES', 0, 0, '2017-10-26'),
(811, 80, 'Cash', '2017-10-05', 'Brice FIGARO', 0, 0, '2017-10-26'),
(816, 500, 'Check', '2017-09-15', 'Florian FONTRIER', 300, 1, '2017-09-16'),
(819, 700, 'Check', '2017-09-14', 'Simon FRANQUET', 420, 1, '2017-09-15'),
(820, 80, 'Check', '2017-07-11', 'Simon FRANQUET', 48, 1, '2017-08-02'),
(833, 170, 'Cash', '2017-09-07', 'Matias GOURDON', 0, 0, '2017-10-26'),
(834, 80, 'Cash', '2017-07-18', 'Matias GOURDON', 48, 0, '2017-10-26'),
(837, 280, 'Check', '2017-09-21', 'Olivier HASSID', 168, 1, '2017-10-04'),
(838, 250, 'Check', '2017-06-01', 'MOUSTAKIM HASSANI', 150, 1, '2017-06-04'),
(839, 500, 'Check', '2017-05-10', 'Gwenael HUET', 300, 1, '2017-05-11'),
(840, 500, 'Check', '2017-10-05', 'Dominique JACQUES', 300, 1, '2017-10-06'),
(841, 500, 'Check', '2017-09-12', 'Sylvain JOLIY', 300, 1, '2017-09-13'),
(846, 30, 'Cash', '2017-10-20', 'Olivier KAZ', 0, 0, '2017-10-26'),
(847, 500, 'Check', '2017-09-27', 'Artyom KORMESHOV', 300, 1, '2017-10-04'),
(848, 100, 'Check', '2017-06-08', 'Artyom KORMESHOV', 60, 1, '2017-07-05'),
(849, 200, 'Check', '2017-09-25', 'Vincent LACERENZA', 120, 0, '2017-10-26'),
(850, 150, 'Check', '2017-09-25', 'Vincent LACERENZA', 90, 0, '2017-10-26'),
(851, 150, 'Check', '2017-09-25', 'Vincent LACERENZA', 90, 1, '2017-10-04'),
(857, 100, 'Cash', '2017-09-18', 'Jonas LEBLANC', 0, 0, '2017-10-26'),
(858, 450, 'Check', '2017-09-07', 'Yohann LES ENFANT', 270, 1, '2017-09-07'),
(859, 500, 'Check', '2017-09-27', 'Gregory LETELLIER', 300, 1, '2017-10-04'),
(860, 280, 'Check', '2017-09-18', 'Anne LETESSIER', 168, 1, '2017-09-19'),
(864, 500, 'Check', '2017-09-28', 'Charles MACQUART MOULIN', 300, 1, '2017-10-04'),
(869, 500, 'Check', '2017-09-19', 'Marco MARZILLI', 300, 1, '2017-10-04'),
(871, 100, 'Check', '2017-05-10', 'Joan MESINELE', 60, 1, '2017-10-04'),
(872, 100, 'Check', '2017-05-10', 'Joan MESINELE', 60, 1, '2017-09-05'),
(873, 100, 'Check', '2017-05-10', 'Joan MESINELE', 60, 1, '2017-08-02'),
(874, 100, 'Check', '2017-05-10', 'Joan MESINELE', 60, 1, '2017-07-05'),
(875, 100, 'Check', '2017-05-10', 'Joan MESINELE', 60, 1, '2017-06-04'),
(877, 500, 'Check', '2017-09-07', 'Franck NGUYEN', 300, 1, '2017-09-07'),
(878, 100, 'Check', '2017-09-28', 'Stephane NGUYEN', 60, 1, '2017-10-04'),
(879, 500, 'Check', '2017-07-11', 'Stephane NGUYEN', 300, 1, '2017-08-02'),
(883, 210, 'Check', '2017-06-01', 'Samuel OLIVIER', 126, 1, '2017-07-05'),
(884, 210, 'Check', '2017-06-01', 'Samuel OLIVIER', 126, 1, '2017-06-04'),
(885, 40, 'Cash', '2017-09-14', 'Noel ONIZKO', 0, 0, '2017-10-26'),
(902, 80, 'Check', '2017-09-14', 'Celine PERREARD', 48, 1, '2017-09-15'),
(904, 1100, 'Check', '2017-10-05', 'Mirjana POLJAKOVIC', 700, 1, '2017-10-06'),
(905, 350, 'Check', '2017-09-25', 'François David PUCHEU LASHORES', 210, 1, '2017-10-04'),
(910, 100, 'Check', '2017-09-25', 'Djamel SAHRAOUI', 60, 0, '2017-10-26'),
(911, 100, 'Check', '2017-09-25', 'Djamel SAHRAOUI', 60, 0, '2017-10-26'),
(912, 100, 'Check', '2017-09-25', 'Djamel SAHRAOUI', 60, 0, '2017-10-26'),
(913, 100, 'Check', '2017-09-25', 'Djamel SAHRAOUI', 60, 0, '2017-10-26'),
(914, 150, 'Check', '2017-09-25', 'Djamel SAHRAOUI', 110, 1, '2017-10-04'),
(915, 200, 'Cash', '2017-09-21', 'Mehdi SAIDI', 0, 0, '2017-10-26'),
(920, 200, 'Cash', '2017-10-05', 'Sylvain TARIN', 0, 0, '2017-10-26'),
(925, 500, 'Check', '2017-05-10', 'Moussa TIMERA', 300, 1, '2017-05-11'),
(926, 50, 'Cash', '2017-10-20', 'Adrien TIREL', 0, 0, '2017-10-26'),
(931, 380, 'Check', '2017-10-02', 'Alexis TRUJILLO', 228, 1, '2017-10-04'),
(932, 350, 'Check', '2017-09-21', 'Arthur TSIMI', 210, 1, '2017-10-04'),
(933, 200, 'Cash', '2017-09-08', 'Yohan VERGNE', 0, 0, '2017-10-26'),
(939, 500, 'Check', '2017-05-10', 'Alexandre WALLOIS', 300, 1, '2017-05-11'),
(940, 100, 'Check', '2017-09-25', 'Paul-François YGORRA', 60, 0, '2017-10-26'),
(941, 100, 'Check', '2017-09-25', 'Paul-François YGORRA', 60, 0, '2017-10-26'),
(942, 100, 'Check', '2017-09-25', 'Paul-François YGORRA', 60, 0, '2017-10-26'),
(943, 100, 'Check', '2017-09-25', 'Paul-François YGORRA', 60, 0, '2017-10-26'),
(944, 100, 'Check', '2017-09-25', 'Paul-François YGORRA', 60, 0, '2017-10-26'),
(945, 50, 'Check', '2017-05-10', 'Paul-François YGORRA', 30, 1, '2017-09-05'),
(946, 50, 'Check', '2017-05-10', 'Paul-François YGORRA', 30, 1, '2017-06-04'),
(947, 60, 'Check', '2017-05-10', 'Paul-François YGORRA', 36, 1, '2017-08-02'),
(948, 60, 'Check', '2017-05-10', 'Paul-François YGORRA', 36, 1, '2017-07-05'),
(952, 120, 'Cash', '2017-09-19', 'Neo ALZIEU', 0, 0, '2017-10-26'),
(953, 40, 'Cash', '2017-09-05', 'Raphael ANI', 0, 0, '2017-10-26'),
(955, 280, 'Check', '2017-09-28', 'Lionel BENICHOU', 168, 1, '2017-10-04'),
(956, 100, 'Check', '2017-05-10', 'Amandine BOUVAT', 60, 1, '2017-05-11'),
(957, 100, 'Check', '2017-05-10', 'Amandine BOUVAT', 60, 1, '2017-06-04'),
(958, 100, 'Check', '2017-05-10', 'Amandine BOUVAT', 60, 1, '2017-07-05'),
(959, 100, 'Check', '2017-05-10', 'Amandine BOUVAT', 60, 1, '2017-08-02'),
(960, 100, 'Check', '2017-05-10', 'Amandine BOUVAT', 60, 1, '2017-09-05'),
(961, 200, 'Check', '2017-05-10', 'Manuel BRUN', 120, 1, '2017-06-04'),
(963, 150, 'Check', '2017-09-14', 'Cyril CHIMKIEVITCH', 90, 1, '2017-09-15'),
(964, 100, 'Check', '2017-09-05', 'Yim DARINA', 60, 1, '2017-10-04'),
(965, 100, 'Check', '2017-09-05', 'Yim DARINA', 60, 1, '2017-09-06'),
(966, 80, 'Check', '2017-05-10', 'Yim DARINA', 48, 1, '2017-05-11'),
(967, 80, 'Cash', '2017-09-14', 'Andrei STRUTGNSHGG', 0, 0, '2017-10-26'),
(971, 500, 'Check', '2017-10-20', 'Vincent PUYDOYEUX', 300, 1, '2017-11-04'),
(972, 500, 'Check', '2017-10-20', 'Mamadou? DJOULFAYAN', 300, 1, '2017-11-04'),
(973, 100, 'Check', '2017-10-16', 'Guillaume VIGNE', 60, 1, '2017-11-04'),
(974, 100, 'Check', '2017-10-16', 'Guillaume VIGNE', 60, 0, '2017-10-26'),
(975, 100, 'Check', '2017-10-16', 'Guillaume VIGNE', 60, 0, '2017-10-26'),
(976, 100, 'Check', '2017-10-16', 'Guillaume VIGNE', 60, 0, '2017-10-26'),
(977, 100, 'Check', '2017-10-16', 'Guillaume VIGNE', 60, 0, '2017-10-26'),
(978, 250, 'Check', '2017-10-10', 'Aime CONTI', 0, 1, '2017-11-04'),
(979, 80, 'Check', '2017-09-07', 'Thomas MACHADO', 48, 1, '2017-09-07'),
(980, 210, 'Check', '2017-10-10', 'Thomas MACHADO', 126, 0, '2017-10-26'),
(981, 210, 'Check', '2017-10-10', 'Thomas MACHADO', 126, 1, '2017-11-04'),
(982, 500, 'Check', '2017-10-10', 'Jules GRUBO', 300, 1, '2017-11-04'),
(983, 100, 'Check', '2017-09-07', 'Yoann GOLESTIN', 60, 1, '2017-10-04'),
(984, 100, 'Check', '2017-09-07', 'Yoann GOLESTIN', 60, 1, '2017-11-04'),
(985, 100, 'Check', '2017-09-07', 'Yoann GOLESTIN', 60, 0, '2017-10-26'),
(986, 100, 'Check', '2017-09-07', 'Yoann GOLESTIN', 60, 0, '2017-10-26'),
(987, 100, 'Check', '2017-09-07', 'Yoann GOLESTIN', 60, 0, '2017-10-26'),
(988, 125, 'Check', '2017-09-25', 'Alban OUAHAB', 75, 0, '2017-10-26'),
(989, 125, 'Check', '2017-09-25', 'Alban OUAHAB', 75, 0, '2017-10-26'),
(990, 125, 'Check', '2017-09-25', 'Alban OUAHAB', 75, 1, '2017-11-04'),
(991, 125, 'Check', '2017-09-25', 'Alban OUAHAB', 75, 1, '2017-10-04'),
(992, 100, 'Check', '2017-09-18', 'Farid BOUHAZEM', 60, 0, '2017-10-26'),
(993, 100, 'Check', '2017-09-18', 'Farid BOUHAZEM', 60, 0, '2017-10-26'),
(994, 100, 'Check', '2017-09-18', 'Farid BOUHAZEM', 60, 0, '2017-10-26'),
(995, 100, 'Check', '2017-09-18', 'Farid BOUHAZEM', 60, 1, '2017-11-04'),
(996, 100, 'Check', '2017-09-18', 'Farid BOUHAZEM', 60, 1, '2017-10-04'),
(997, 55, 'Check', '2017-05-10', 'Farid BOUHAZEM', 33, 1, '2017-09-05'),
(998, 55, 'Check', '2017-05-10', 'Farid BOUHAZEM', 33, 1, '2017-08-02'),
(999, 55, 'Check', '2017-05-10', 'Farid BOUHAZEM', 33, 1, '2017-07-07'),
(1000, 55, 'Check', '2017-05-10', 'Farid BOUHAZEM', 33, 1, '2017-06-04'),
(1001, 250, 'Check', '2017-09-18', 'Christophe TROEL', 150, 1, '2017-11-04'),
(1002, 250, 'Check', '2017-09-18', 'Christophe TROEL', 150, 1, '2017-10-04'),
(1003, 110, 'Check', '2017-05-10', 'Christophe TROEL', 66, 1, '2017-06-04'),
(1004, 110, 'Check', '2017-05-10', 'Christophe TROEL', 66, 1, '2017-05-11'),
(1005, 200, 'Check', '2017-09-18', 'Yann MALARD', 120, 1, '2017-09-19'),
(1006, 150, 'Check', '2017-09-18', 'Yann MALARD', 90, 1, '2017-10-04'),
(1007, 150, 'Check', '2017-09-18', 'Yann MALARD', 90, 1, '2017-11-04'),
(1008, 250, 'Check', '2017-10-17', 'Martine ATTALI', 150, 0, '2017-10-26'),
(1009, 250, 'Check', '2017-10-17', 'Martine ATTALI', 150, 1, '2017-11-04'),
(1010, 365, 'Check', '2017-09-25', 'Delphine GAO', 219, 1, '2017-10-04'),
(1011, 365, 'Check', '2017-10-16', 'Delphine GAO', 219, 1, '2017-11-04'),
(1012, 175, 'Check', '2017-10-16', 'Jeremy PICOSTE', 105, 1, '2017-11-04'),
(1013, 500, 'Check', '2017-10-16', 'Didier MAUS', 300, 1, '2017-11-04'),
(1014, 80, 'Check', '2017-09-18', 'Nissim ZERBIB', 48, 1, '2017-09-19'),
(1015, 420, 'Check', '2017-10-16', 'Nissim ZERBIB', 252, 1, '2017-11-04'),
(1017, 125, 'Check', '2017-10-05', 'Nabil KADID', 75, 0, '2017-10-26'),
(1018, 125, 'Check', '2017-10-05', 'Nabil KADID', 75, 0, '2017-10-26'),
(1019, 125, 'Check', '2017-10-05', 'Nabil KADID', 75, 1, '2017-11-04'),
(1020, 125, 'Check', '2017-10-05', 'Nabil KADID', 75, 1, '2017-10-06'),
(1021, 200, 'Check', '2017-09-28', 'Nicolas NZAMBA', 120, 1, '2017-11-04'),
(1022, 150, 'Check', '2017-09-28', 'Nicolas NZAMBA', 90, 0, '2017-10-26'),
(1023, 150, 'Check', '2017-09-28', 'Nicolas NZAMBA', 90, 1, '2017-10-04'),
(1024, 250, 'Check', '2017-09-28', 'Jean Paul FOURNET', 150, 1, '2017-10-04'),
(1025, 250, 'Check', '2017-09-28', 'Jean Paul FOURNET', 150, 1, '2017-11-04'),
(1028, 250, 'Check', '2017-09-21', 'Mickael FERREIRA', 150, 1, '2017-10-04'),
(1029, 250, 'Check', '2017-09-21', 'Mickael FERREIRA', 150, 1, '2017-11-04'),
(1030, 100, 'Check', '2017-09-21', 'Emmanuel PEREIRA VIEIRA', 60, 0, '2017-10-26'),
(1031, 100, 'Check', '2017-09-21', 'Emmanuel PEREIRA VIEIRA', 60, 0, '2017-10-26'),
(1032, 100, 'Check', '2017-09-21', 'Emmanuel PEREIRA VIEIRA', 60, 0, '2017-10-26'),
(1033, 100, 'Check', '2017-09-21', 'Emmanuel PEREIRA VIEIRA', 60, 1, '2017-11-04'),
(1034, 100, 'Check', '2017-09-21', 'Emmanuel PEREIRA VIEIRA', 60, 1, '2017-10-04'),
(1035, 125, 'Check', '2017-09-12', 'Marc antoine FIGHIERA', 75, 1, '2017-09-13'),
(1036, 125, 'Check', '2017-09-21', 'Marc antoine FIGHIERA', 75, 1, '2017-10-04'),
(1037, 125, 'Check', '2017-09-21', 'Marc antoine FIGHIERA', 75, 1, '2017-11-04'),
(1038, 125, 'Check', '2017-09-21', 'Marc antoine FIGHIERA', 75, 0, '2017-10-26'),
(1039, 100, 'Check', '2017-09-21', 'Vincent TERRONI', 60, 0, '2017-10-26'),
(1040, 100, 'Check', '2017-09-21', 'Vincent TERRONI', 60, 1, '2017-11-04'),
(1041, 80, 'Check', '2017-09-21', 'Vincent TERRONI', 48, 1, '2017-10-04'),
(1042, 100, 'Check', '2017-09-05', 'Cedric LE FRANC', 60, 0, '2017-10-26'),
(1043, 100, 'Check', '2017-09-05', 'Cedric LE FRANC', 60, 0, '2017-10-26'),
(1044, 100, 'Check', '2017-09-05', 'Cedric LE FRANC', 60, 1, '2017-11-04'),
(1045, 100, 'Check', '2017-09-05', 'Cedric LE FRANC', 60, 1, '2017-10-04'),
(1046, 100, 'Check', '2017-09-05', 'Cedric LE FRANC', 60, 1, '2017-09-06'),
(1047, 100, 'Check', '2017-09-12', 'Sebastien BIDAULT', 60, 0, '2017-10-26'),
(1048, 100, 'Check', '2017-09-12', 'Sebastien BIDAULT', 60, 0, '2017-10-26'),
(1049, 100, 'Check', '2017-09-12', 'Sebastien BIDAULT', 60, 0, '2017-10-26'),
(1050, 100, 'Check', '2017-09-12', 'Sebastien BIDAULT', 60, 1, '2017-11-04'),
(1051, 100, 'Check', '2017-09-12', 'Sebastien BIDAULT', 60, 1, '2017-10-04'),
(1052, 125, 'Check', '2017-09-14', 'David Gauthier', 75, 1, '2017-10-04'),
(1053, 125, 'Check', '2017-09-14', 'David Gauthier', 75, 1, '2017-11-04'),
(1054, 125, 'Check', '2017-09-14', 'David Gauthier', 75, 0, '2017-10-26'),
(1055, 125, 'Check', '2017-09-14', 'David Gauthier', 75, 0, '2017-10-26'),
(1056, 200, 'Check', '2017-09-14', 'Nelson SILVA', 120, 1, '2017-11-04'),
(1057, 150, 'Check', '2017-09-14', 'Nelson SILVA', 90, 1, '2017-10-04'),
(1058, 150, 'Check', '2017-09-14', 'Nelson SILVA', 90, 1, '2017-09-15'),
(1059, 100, 'Check', '2017-09-15', 'Julien BOURGEOIS', 60, 0, '2017-10-26'),
(1060, 100, 'Check', '2017-09-15', 'Julien BOURGEOIS', 60, 0, '2017-10-26'),
(1061, 100, 'Check', '2017-09-15', 'Julien BOURGEOIS', 60, 0, '2017-10-26'),
(1062, 100, 'Check', '2017-09-15', 'Julien BOURGEOIS', 60, 1, '2017-11-04'),
(1063, 100, 'Check', '2017-09-15', 'Julien BOURGEOIS', 60, 1, '2017-09-16'),
(1068, 50, 'Cash', '2017-06-01', 'David THOMAS', 30, 0, '2017-10-26'),
(1078, 56, 'Check', '2017-09-14', 'Fabrice BUKASSA', 34, 1, '2017-10-04'),
(1079, 56, 'Check', '2017-09-14', 'Fabrice BUKASSA', 34, 1, '2017-11-04'),
(1080, 50, 'Cash', '2017-09-14', 'Fabrice BUKASSA', 0, 0, '2017-10-27'),
(1081, 40, 'Cash', '2017-09-05', 'John BARFF', 0, 0, '2017-10-26'),
(1082, 80, 'Check', '2017-05-10', 'Aurianne CHARMET', 48, 1, '2017-05-11'),
(1083, 80, 'Check', '2017-05-10', 'Kevin MALGERARD', 48, 1, '2017-05-11'),
(1084, 50, 'Check', '2017-10-16', 'Marc PELLET', 30, 1, '2017-11-04'),
(1085, 150, 'Check', '2017-09-21', 'Nathalie VANDERBURG', 90, 1, '2017-10-04'),
(1086, 100, 'Check', '2017-09-25', 'Nathalie VANDERBURG', 60, 1, '2017-11-04'),
(1087, 100, 'Cash', '2017-09-05', 'Raphael DOS SANTOS', 0, 0, '2017-10-26'),
(1088, 250, 'Cash', '2017-11-09', 'Raphael DOS SANTOS', 0, 0, '2017-11-09'),
(1110, 250, 'Check', '2017-11-09', 'Alessandro ZANNI', 150, 0, '2017-11-09'),
(1111, 100, 'Cash', '2017-11-09', 'Alessandro ZANNI', 0, 0, '2017-11-09'),
(1112, 500, 'Check', '2017-11-09', 'Simon THULEAU', 300, 1, '2017-11-10'),
(1113, 80, 'Check', '2017-11-09', 'Thomas BISSON', 48, 1, '2017-11-10'),
(1114, 80, 'Check', '2017-11-09', 'Sofien ZAMITTI', 48, 1, '2017-11-10'),
(1115, 350, 'Check', '2017-11-09', 'Hichem ARFAOUI', 210, 1, '2017-11-10'),
(1119, 250, 'Check', '2017-11-09', 'Olivier ROINEL', 150, 0, '2017-11-09'),
(1120, 250, 'Check', '2017-11-09', 'Olivier ROINEL', 150, 1, '2017-11-10'),
(1121, 80, 'Check', '2017-11-09', 'Martin CZABADAJ', 48, 1, '2017-11-10'),
(1122, 40, 'Cash', '2017-09-25', 'Thomas CASTAN', 0, 0, '2017-10-26'),
(1123, 210, 'Check', '2017-11-09', 'Thomas CASTAN', 126, 1, '2017-11-10'),
(1124, 210, 'Check', '2017-11-09', 'Thomas CASTAN', 126, 1, '2017-11-10'),
(1125, 80, 'Check', '2017-09-28', 'Julien GAZAVE', 48, 1, '2017-10-04'),
(1126, 80, 'Check', '2017-11-09', 'Julien GAZAVE', 48, 1, '2017-11-10'),
(1127, 200, 'Check', '2017-09-18', 'Eddy BARCLAY', 120, 1, '2017-11-10'),
(1128, 150, 'Check', '2017-09-18', 'Eddy BARCLAY', 90, 0, '2017-10-26'),
(1129, 150, 'Check', '2017-09-18', 'Eddy BARCLAY', 90, 1, '2017-10-04'),
(1130, 70, 'Cash', '2017-11-09', 'Denis DAVIDKOV', 0, 0, '2017-11-09'),
(1132, 350, 'Check', '2017-06-28', 'Frederique AMBROISE', 210, 1, '2017-07-05'),
(1143, 100, 'Check', '2017-06-08', 'Jean-Marc BLOMBOU', 60, 0, '2017-10-26'),
(1144, 100, 'Check', '2017-06-08', 'Jean-Marc BLOMBOU', 60, 0, '2017-10-26'),
(1145, 100, 'Check', '2017-06-08', 'Jean-Marc BLOMBOU', 60, 1, '2017-09-05'),
(1146, 100, 'Check', '2017-06-08', 'Jean-Marc BLOMBOU', 60, 1, '2017-08-02'),
(1147, 100, 'Check', '2017-06-08', 'Jean-Marc BLOMBOU', 60, 1, '2017-07-05');

-- --------------------------------------------------------

--
-- Structure de la table `privates`
--

CREATE TABLE `privates` (
  `ID` int(11) NOT NULL,
  `Name` varchar(200) DEFAULT NULL,
  `Amount` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `bookedLessons` int(11) DEFAULT NULL,
  `doneLessons` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `privates`
--

INSERT INTO `privates` (`ID`, `Name`, `Amount`, `Date`, `bookedLessons`, `doneLessons`) VALUES
(1, 'Brice Donadelli', 250, '2017-10-05', 5, 2),
(2, 'Marco Romeu', 200, '2017-10-12', 5, 3),
(3, 'Sylvain Deshors', 60, '2017-10-17', 1, 1),
(4, 'Matias Gourdon', 250, '2017-10-26', 5, 2),
(5, 'Clara Cabrerizo', 60, '2017-10-26', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `refunds`
--

CREATE TABLE `refunds` (
  `ID` int(11) NOT NULL,
  `Label` varchar(200) DEFAULT NULL,
  `Amount` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Comment` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `refunds`
--

INSERT INTO `refunds` (`ID`, `Label`, `Amount`, `Date`, `Comment`) VALUES
(1, 'Pot stage', 75, '2017-06-10', NULL),
(2, 'Location', 4625, '2017-08-15', NULL),
(3, 'Paiement Etienne Gregoire', 90, '2017-10-16', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `seminars`
--

CREATE TABLE `seminars` (
  `ID` int(11) NOT NULL,
  `Theme` varchar(200) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `WebMEMBERS` int(11) DEFAULT NULL,
  `LocalMEMBERS` int(11) DEFAULT NULL,
  `Amount` int(11) DEFAULT NULL,
  `Debt` int(11) DEFAULT NULL,
  `Comment` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `seminars`
--

INSERT INTO `seminars` (`ID`, `Theme`, `Date`, `WebMEMBERS`, `LocalMEMBERS`, `Amount`, `Debt`, `Comment`) VALUES
(1, 'Spider guard', '2017-06-10', 14, 21, 1000, 200, NULL),
(2, 'Basics', '2017-09-10', 23, 31, 1357, 271, NULL);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `coachspayments`
--
ALTER TABLE `coachspayments`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_MEMBER` (`MemberID`);

--
-- Index pour la table `dojo`
--
ALTER TABLE `dojo`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `members`
--
ALTER TABLE `members`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `uq_MEMBERS` (`Firstname`,`Lastname`);

--
-- Index pour la table `members_payments`
--
ALTER TABLE `members_payments`
  ADD PRIMARY KEY (`MemberID`,`PaymentID`),
  ADD KEY `FKPayment` (`PaymentID`);

--
-- Index pour la table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `privates`
--
ALTER TABLE `privates`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `refunds`
--
ALTER TABLE `refunds`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `seminars`
--
ALTER TABLE `seminars`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `coachspayments`
--
ALTER TABLE `coachspayments`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT pour la table `dojo`
--
ALTER TABLE `dojo`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `members`
--
ALTER TABLE `members`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=136;
--
-- AUTO_INCREMENT pour la table `payments`
--
ALTER TABLE `payments`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1148;
--
-- AUTO_INCREMENT pour la table `privates`
--
ALTER TABLE `privates`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT pour la table `refunds`
--
ALTER TABLE `refunds`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `seminars`
--
ALTER TABLE `seminars`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `coachspayments`
--
ALTER TABLE `coachspayments`
  ADD CONSTRAINT `FK_MEMBER` FOREIGN KEY (`MemberID`) REFERENCES `members` (`ID`);

--
-- Contraintes pour la table `members_payments`
--
ALTER TABLE `members_payments`
  ADD CONSTRAINT `FKMember` FOREIGN KEY (`MemberID`) REFERENCES `members` (`ID`),
  ADD CONSTRAINT `FKPayment` FOREIGN KEY (`PaymentID`) REFERENCES `payments` (`ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
