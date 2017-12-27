-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost:3306
-- Généré le :  Mer 27 Décembre 2017 à 16:38
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
(7, 131, 'Octobre', 5, 30, 150, '2017-11-11', NULL),
(8, 131, 'Novembre', 3, 30, 90, '2017-12-01', NULL),
(9, 132, 'Novembre', 8, 25, 200, '2017-12-02', NULL),
(10, 130, 'Novembre', 2, 25, 50, '2017-12-05', NULL),
(11, 130, 'Decembre', 3, 25, 75, '2017-12-21', NULL),
(12, 132, 'Decembre', 6, 25, 150, '2017-12-21', NULL),
(13, 129, 'Decembre', 4, 25, 100, '2017-12-21', NULL),
(14, 131, 'Decembre', 4, 30, 120, '2017-12-24', NULL);

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
  `Mail` varchar(200) DEFAULT NULL,
  `Phone` varchar(200) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `Facebook` varchar(200) DEFAULT NULL,
  `Active` tinyint(4) DEFAULT NULL,
  `Coach` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `members`
--

INSERT INTO `members` (`ID`, `Firstname`, `Lastname`, `Enddate`, `Belt`, `Gender`, `Child`, `Alert`, `Comment`, `Job`, `Mail`, `Phone`, `Address`, `Facebook`, `Active`, `Coach`) VALUES
(1, 'David', 'GAUTHIER', '2018-09-12', 'purple', 'M', 0, 0, '', 'prof d''EPS', '', '', '', '', 1, 0),
(2, 'Raphael', 'ARIE', '2018-10-05', 'blue', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(3, 'Zacharie', 'ATTALI', '2018-10-17', 'white', 'M', 0, 0, 'Vient de débuter', '', NULL, NULL, NULL, NULL, 1, 0),
(4, 'Eddy', 'BARCLAY', '2018-09-12', 'white', 'M', 0, 0, 'En attente de 2 cheques que j''ai donné à Kelly -> Récupérés le 09/11/2017 -> anciens cheques déchirés le 19/12', '', '', '', '', '', 1, 0),
(6, 'Frederique', 'BARDEY', '2018-09-26', 'white', 'M', 0, 0, 'référencé en remy au cercle?', '', NULL, NULL, NULL, NULL, 1, 0),
(7, 'John', 'BARFF', '2017-10-05', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 0, 0),
(8, 'Didier', 'BARRAUD', '2018-09-15', 'black', 'M', 0, 0, 'Son fils est aussi inscrit mais on lui a fait cadeau du paiement', '', NULL, NULL, NULL, NULL, 1, 0),
(9, 'Lionel', 'BENICHOU', '2018-09-28', 'white', 'M', 1, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(10, 'Sebastien', 'BIDAULT', '2018-09-11', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(11, 'Farid', 'BOUHAZEM', '2018-09-12', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(12, 'Julien', 'BOURGEOIS', '2018-09-15', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(13, 'Gauthier', 'BRYSBAERT', '2018-09-11', 'white', 'M', 0, 0, '', 'Scientist à polytechnique apparement', NULL, NULL, NULL, NULL, 1, 0),
(15, 'Sacha', 'BUKASSA', '2017-10-29', 'white', 'M', 1, 0, 'A demandé le remboursement....Puis se l''est fait remboursé, je lui ai rendu un cheque', '', NULL, NULL, NULL, NULL, 0, 0),
(16, 'Corentin', 'CAHEN', '2018-10-04', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(17, 'Sarah', 'CASSESE', '2018-09-25', 'blue', 'F', 1, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(18, 'Thomas', 'CASTAN', '2018-09-25', 'white', 'M', 0, 0, 'Collèque de sylvain', 'Dans le service/evenementiel', NULL, NULL, NULL, NULL, 1, 0),
(19, 'Pierre', 'CHAMBON', '2018-09-26', 'white', 'M', 0, 0, '2 disciplines j''imagine?', '', NULL, NULL, NULL, NULL, 1, 0),
(20, 'Bagdad', 'CHECKRI', '2018-09-04', 'purple', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(21, 'Adrien', 'CHEMINET', '2018-09-20', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(22, 'Cyril', 'CHIMKIEVITCH', '2017-11-04', 'white', 'M', 0, 1, 'C''est quoi son abonnement?', '', NULL, NULL, NULL, NULL, 1, 0),
(23, 'Aime', 'CONTI', '2018-10-10', 'black', 'M', 0, 0, 'potentielemnt interessé par des cours particuliers', 'Dans les assurances', NULL, NULL, NULL, NULL, 1, 0),
(24, 'Ricardo', 'RIBEIRO', '2017-11-04', 'white', 'M', 0, 0, 'blessé au genou le 3/11. Redonne les cheques ou pas?', 'cuisinier', NULL, NULL, NULL, NULL, 0, 0),
(25, 'Olivier', 'DAURARIO', '2018-10-10', 'brown', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(26, 'Christian', 'DEGUIS', '2017-11-04', 'white', 'M', 0, 1, 'C''est quoi ce taro?', '', NULL, NULL, NULL, NULL, 1, 0),
(27, 'Mamadou?', 'DJOULFAYAN', '2018-10-16', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(28, 'Fabien', 'DORE', '2018-09-04', 'blue', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(29, 'Raphael', 'DOS SANTOS', '2018-11-09', 'blue', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(31, 'Eric', 'DRIKES', '2018-09-04', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(32, 'Mickael', 'FERREIRA', '2018-09-12', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(33, 'Brice', 'FIGARO', '2018-10-04', 'purple', 'M', 0, 0, '900 au cercle et 80 chez moi???', '', '', '', '', '', 1, 0),
(34, 'Marc antoine', 'FIGHIERA', '2018-09-08', 'blue', 'M', 0, 0, '', 'graphiste je crois', NULL, NULL, NULL, NULL, 1, 0),
(36, 'Florian', 'FONTRIER', '2018-09-15', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(37, 'Jean Paul', 'FOURNET', '2018-09-26', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(38, 'Simon', 'FRANQUET', '2018-09-12', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(39, 'Bayle', 'GAO', '2018-10-04', 'purple', 'M', 0, 0, '', 'ingenieur robotique', NULL, NULL, NULL, NULL, 1, 0),
(42, 'Julien', 'GAZAVE', '2018-12-09', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(43, 'Yoann', 'GOLESTIN', '2018-09-07', 'white', 'M', 0, 0, 'avait donné 5 cheques de 100. S''est blessé au ligament du coup j''ai déchiré les 2 derniers cheques et je l''ai remboursé de 175 E.', '', '', '', '', '', 1, 0),
(44, 'Matias', 'GOURDON', '2018-07-01', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(45, 'Raphael', 'GRESSIN', NULL, 'white', 'M', 1, 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0),
(46, 'Jules', 'GRUBO', '2018-10-12', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(47, 'Olivier', 'HASSID', '2018-09-20', 'white', 'M', 1, 0, 'Le oliver ceinture marron?', '', NULL, NULL, NULL, NULL, 1, 0),
(48, 'Dominique', 'JACQUES', '2018-10-10', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(49, 'Sylvain', 'JOLIY', '2018-09-11', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(50, 'Nabil', 'KADID', '2018-10-04', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(51, 'Olivier', 'KAZ', '2017-11-20', 'white', 'M', 0, 0, '', '', '', '', '', '', 1, 0),
(52, 'Artyom', 'KORMESHOV', '2018-09-20', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(53, 'Vincent', 'LACERENZA', '2018-09-20', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(54, 'Cedric', 'LE FRANC', '2018-04-04', 'white', 'M', 0, 0, 'pas bleu lui?', '', NULL, NULL, NULL, NULL, 1, 0),
(55, 'Jonas', 'LEBLANC', '2018-11-04', 'white', 'M', 0, 0, '2 disciplines', '', '', '', '', '', 1, 0),
(56, 'Yohann', 'LES ENFANT', '2018-09-01', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(57, 'Gregory', 'LETELLIER', '2018-09-26', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(58, 'Anne', 'LETESSIER', '2018-09-04', 'white', 'F', 1, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(59, 'Thomas', 'MACHADO', '2018-09-04', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(61, 'Charles', 'MACQUART MOULIN', '2018-10-10', 'white', 'M', 0, 0, 'Blessé pour le mois de novembre, pb aux cotes', '', NULL, NULL, NULL, NULL, 1, 0),
(62, 'Yann', 'MALARD', '2018-09-12', 'purple', 'M', 0, 0, '', 'notaire', NULL, NULL, NULL, NULL, 1, 0),
(63, 'Marco', 'MARZILLI', '2018-09-20', 'brown', 'M', 0, 0, '', 'gérant de restos', NULL, NULL, NULL, NULL, 1, 0),
(64, 'Didier', 'MAUS', '2018-10-15', 'purple', 'M', 0, 0, '', 'Policier je crois', NULL, NULL, NULL, NULL, 1, 0),
(65, 'Franck', 'NGUYEN', '2018-09-07', 'purple', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(66, 'Stephane', 'NGUYEN', '2018-07-11', 'white', 'M', 0, 0, 'Veut faire la compet ibjjf je crois, en attente de licence', '', NULL, NULL, NULL, NULL, 1, 0),
(67, 'Nicolas', 'NZAMBA', '2018-09-28', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(68, 'Noel', 'ONIZKO', '2017-10-14', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 0, 0),
(69, 'Alban', 'OUAHAB', '2018-09-20', 'blue', 'M', 0, 0, '', 'étudiant / recherche commerce?', NULL, NULL, NULL, NULL, 1, 0),
(70, 'Samuel', 'PELLET', '2017-11-04', 'white', 'M', 0, 1, 'C''est quoi son abonnement?', '', NULL, NULL, NULL, NULL, 1, 0),
(72, 'Marc', 'PELLET', '2017-11-04', 'white', 'M', 0, 1, 'C''est quoi son abonnement? Marc et Samuel pareil? Apparement c''est le pere de samuel', '', NULL, NULL, NULL, NULL, 1, 0),
(73, 'Emmanuel', 'PEREIRA VIEIRA', '2018-09-21', 'white', 'M', 0, 0, '', 'livreur dans les librairies', NULL, NULL, NULL, NULL, 1, 0),
(74, 'Celine', 'PERREARD', '2018-09-14', 'white', 'F', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(75, 'Jeremy', 'PICOSTE', '2018-10-10', 'black', 'M', 0, 0, 'tarif réduit du cercle', '', NULL, NULL, NULL, NULL, 1, 0),
(76, 'Mirjana', 'POLJAKOVIC', '2018-10-04', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(77, 'François David', 'PUCHEU LASHORES', '2018-09-20', 'purple', 'M', 0, 0, '', 'Dans le pétrole?', NULL, NULL, NULL, NULL, 1, 0),
(78, 'Vincent', 'PUYDOYEUX', '2018-10-16', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(79, 'Djamel', 'SAHRAOUI', '2018-09-20', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(80, 'Mehdi', 'SAIDI', '2018-09-20', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(81, 'Nelson', 'SILVA', '2018-09-11', 'white', 'M', 0, 0, 'brown belt?', '', NULL, NULL, NULL, NULL, 1, 0),
(82, 'Andrei', 'STRUTGNSHGG', '2017-10-14', 'white', 'M', 0, 0, 'C''est quoi son abo a 250 ?', '', NULL, NULL, NULL, NULL, 0, 0),
(83, 'Sylvain', 'TARIN', '2018-10-10', 'purple', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(84, 'Vincent', 'TERRONI', '2018-09-21', 'white', 'M', 1, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(85, 'Adrien', 'TIREL', '2018-10-20', 'white', 'M', 0, 0, 'A demandé pour des CP', '', '', '', '', '', 1, 0),
(86, 'Christophe', 'TROEL', '2018-09-15', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(87, 'Alexis', 'TRUJILLO', '2018-09-20', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(88, 'Arthur', 'TSIMI', '2018-09-12', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(89, 'Yohan', 'VERGNE', '2018-09-08', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(90, 'Guillaume', 'VIGNE', '2018-10-04', 'purple', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(91, 'Paul-François', 'YGORRA', '2018-09-20', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(92, 'Nissim', 'ZERBIB', '2018-09-15', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(99, 'Neo', 'ALZIEU', '2017-11-04', 'white', 'M', 0, 1, 'C''est quoi son abo? un enfant?', '', NULL, NULL, NULL, NULL, 1, 0),
(100, 'Frederique', 'AMBROISE', '2018-06-01', 'white', 'M', 0, 0, 'Grand martiniquais, inscrit a 2 disciplines, vient de l''hapkido', '', NULL, NULL, NULL, NULL, 1, 0),
(101, 'Jean-Marc', 'BLOMBOU', '2017-10-29', 'blue', 'M', 0, 1, 'A repris ses derniers cheques et doit en rendre 2 autres...', '', NULL, NULL, NULL, NULL, 1, 0),
(102, 'Amandine', 'BOUVAT', '2018-05-10', 'white', 'F', 0, 0, 'C''est qui elle?', '', NULL, NULL, NULL, NULL, 1, 0),
(103, 'Manuel', 'BRUN', '2017-09-04', 'white', 'M', 0, 1, 'C''est quoi son abo?', '', NULL, NULL, NULL, NULL, 1, 0),
(104, 'Aurianne', 'CHARMET', '2017-06-04', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 0, 0),
(105, 'Daniel', 'CURVAT', '2018-06-05', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(106, 'Jerome', 'DIVAC', '2018-02-04', 'blue', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(107, 'Jorge', 'DO PINHAL', '2018-05-04', 'blue', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(108, 'Gwenael', 'HUET', '2018-05-10', 'blue', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(109, 'Guillaume', 'LE MAUT', NULL, 'white', 'M', 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0),
(110, 'Kevin', 'MALGERARD', '2017-06-10', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 0, 0),
(111, 'Joan', 'MESINELE', '2018-05-10', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(112, 'Moustakima', 'HASSANI', '2018-06-04', 'brown', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(113, 'Samuel', 'OLIVIER', '2018-03-02', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(114, 'David', 'THOMAS', '2017-07-01', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 0, 0),
(115, 'Moussa', 'TIMERA', '2018-05-04', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(116, 'Alexandre', 'WALLOIS', '2018-04-04', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(120, 'Simon', 'THULEAU', '2018-11-09', 'white', 'M', 0, 0, 'Cheque de 500 puis remboursement en cours de 290E. Ca revient a un paiement de 210E.....', '', '', '', '', '', 1, 0),
(121, 'Thomas', 'BISSON', '2017-12-09', 'white', 'M', 0, 0, 'Je connais un Franck plutot, beau fils de philou?', '', NULL, NULL, NULL, NULL, 1, 0),
(122, 'Sofien', 'ZAMITTI', '2017-12-09', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(123, 'Alessandro', 'ZANNI', '2018-11-09', 'brown', 'M', 0, 0, 'C''est quoi sa 2eme discipline à lui?', 'informaticien dans la sécurité', NULL, NULL, NULL, NULL, 1, 0),
(124, 'Hichem', 'ARFAOUI', '2018-11-09', 'white', 'M', 0, 0, 'C''est quoi ça comme taro 350 en cheque? 2 disciplines j''imagine', '', NULL, NULL, NULL, NULL, 1, 0),
(125, 'Olivier', 'ROINEL', '2018-11-09', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(126, 'Martin', 'CZABADAJ', '2017-12-09', 'blue', 'M', 0, 0, 'veut faire la coupe de zone mais s''inscrit qu''un mois??', '', NULL, NULL, NULL, NULL, 1, 0),
(127, 'Denis', 'DAVIDKOV', '2017-12-09', 'white', 'M', 0, 0, 'Pourquoi j''ai reçu ce montant et pas 30 E?', '', NULL, NULL, NULL, NULL, 1, 0),
(128, 'Thibaut', 'OLIVIER', '2019-12-11', 'black', 'M', 0, 0, 'Moi', 'Jiu-Jitsu headcoach', 'thibautolivier77@gmail.com', '0675403464', '44 rue faidherbe 78800 HOUILLES', 'https://www.facebook.com/thibautolivier77', 1, 1),
(129, 'François', 'MOLESLAS', '2020-11-11', 'black', 'M', 0, 0, '', '', '', '', '', '', 1, 1),
(130, 'Stéphane', 'HENNEQUIN', '2020-11-11', 'black', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 1),
(131, 'Etienne', 'GREGOIRE', '2019-12-01', 'black', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 1),
(132, 'Matthieu', 'DELALANDRE', '2019-12-11', 'black', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 1),
(136, 'Jean-Baptiste', 'QUINQUENEL', '2018-11-15', 'white', 'M', 0, 0, '2 disciplines j''imagine', '', NULL, NULL, NULL, NULL, 1, 0),
(137, 'Julien', 'FARAUT', '2018-11-15', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(138, 'Michel-Ange', 'MATOUBA', '2018-11-15', 'white', 'M', 0, 0, 'Enfant?', '', '', '', '', '', 1, 0),
(139, 'Akhmed', 'SALAMOV', '2018-09-18', 'blue', 'M', 0, 1, 'Son reste de  paiement (250) a été récupéré par la boxe', '', '', '', '', '', 1, 0),
(142, 'Sylvain', 'DESHORS', '2018-05-01', 'white', 'M', 0, 0, 'Prend des CP', 'Chez veolia', '', '', '', '', 1, 0),
(143, 'Brice', 'DONADELLI', '2017-11-20', 'brown', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 0, 0),
(144, 'Marco', 'GONCALVES', '2017-11-20', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 0, 0),
(145, 'Clara', 'CABRERIZO', '2017-11-20', 'white', 'F', 0, 0, '', '', NULL, NULL, NULL, NULL, 0, 0),
(146, 'nicolas', 'DUVAUCHELLE', '2018-11-21', 'white', 'M', 0, 0, '', 'Acteur', NULL, NULL, NULL, NULL, 1, 0),
(147, 'Sebastien', 'LOPES', '2018-11-21', 'black', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(148, 'Denis', 'CEOLIN', '2018-11-30', 'blue', 'M', 0, 0, '', 'Chercheur en chimie', NULL, NULL, NULL, NULL, 1, 0),
(149, 'Yohann', 'LY', '2018-11-30', 'purple', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(150, 'Thibaud', 'DENINGER', '2018-11-30', 'blue', 'M', 0, 0, '', 'Policier', NULL, NULL, NULL, NULL, 1, 0),
(151, 'Jennifer', 'MALGERARD', '2017-12-30', 'white', 'F', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(152, 'Nicolas', 'MALARD', '2018-11-30', 'white', 'M', 0, 0, 'Frere de Yann la ceinture violette', '', NULL, NULL, NULL, NULL, 1, 0),
(153, 'David', 'DONNINI', '2018-11-30', 'white', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(154, 'Juan', 'NERINA', '2018-11-30', 'blue', 'M', 0, 1, 'Doit changer un de ces cheques, l''ordre n''est pas bon. Je lui ai rendu celui de 200 deja.', '', '', '', '', '', 1, 0),
(155, 'Roméo', 'YOMBOU', '2017-12-04', 'blue', 'M', 0, 0, 'Seulement le libre, !! non déclaré !!', '', NULL, NULL, NULL, NULL, 1, 0),
(156, 'Inconnnu', 'HORSKYY', '2018-01-07', 'white', 'M', 0, 0, 'Ceinture blanche russe prof dans sa tete?', '', '', '', '', '', 1, 0),
(157, 'Dominique', 'BOYER', '2017-12-07', 'white', 'M', 0, 0, 'aikidoka avec une sceance par semaine', '', NULL, NULL, NULL, NULL, 1, 0),
(158, 'Zou', 'THIEN DU CHABERT', '2018-02-07', 'purple', 'M', 0, 0, '2 mois abonnement', '', '', '', '', '', 1, 0),
(159, 'Roy', 'HARRIS', '2017-12-07', 'brown', 'M', 0, 0, '', '', NULL, NULL, NULL, NULL, 1, 0),
(160, 'Hernan', 'VASQUEZ MORA', '2018-12-07', 'black', 'M', 0, 0, '', 'policier', '', '', '', '', 1, 0),
(162, 'David', 'ANKRI', '2019-04-25', 'brown', 'M', 0, 0, 'Juif integriste', 'Vendeur de cuir', '', '', '', '', 1, 0),
(163, 'Matthieu', 'LHOSPITALIER', '2018-01-19', 'white', 'M', 0, 0, '', '', '', '', '', '', 1, 0),
(164, 'Aissa', 'EDDAMI', '2017-12-19', 'white', 'M', 0, 0, 'pote de bagdad', '', '', '', '', '', 1, 0),
(165, 'Lothaire', 'EPEE', '2018-12-19', 'purple', 'M', 0, 0, '', '', '', '', '', '', 1, 0);

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
(8, 759),
(16, 789),
(17, 790),
(19, 793),
(20, 795),
(21, 796),
(105, 799),
(26, 801),
(106, 802),
(28, 805),
(31, 807),
(31, 808),
(36, 816),
(38, 819),
(38, 820),
(44, 833),
(44, 834),
(108, 839),
(48, 840),
(49, 841),
(52, 847),
(52, 848),
(56, 858),
(57, 859),
(58, 860),
(61, 864),
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
(76, 904),
(80, 915),
(83, 920),
(115, 925),
(87, 931),
(88, 932),
(89, 933),
(116, 939),
(9, 955),
(102, 956),
(102, 957),
(102, 958),
(102, 959),
(102, 960),
(103, 961),
(22, 963),
(78, 971),
(27, 972),
(46, 982),
(86, 1001),
(86, 1002),
(86, 1003),
(86, 1004),
(75, 1012),
(92, 1014),
(92, 1015),
(37, 1024),
(37, 1025),
(32, 1028),
(32, 1029),
(81, 1056),
(81, 1057),
(81, 1058),
(114, 1068),
(15, 1078),
(15, 1079),
(15, 1080),
(104, 1082),
(110, 1083),
(72, 1084),
(70, 1085),
(70, 1086),
(122, 1114),
(124, 1115),
(125, 1119),
(125, 1120),
(126, 1121),
(42, 1125),
(42, 1126),
(101, 1143),
(101, 1144),
(101, 1145),
(101, 1146),
(101, 1147),
(99, 1149),
(6, 1159),
(6, 1160),
(6, 1161),
(18, 1175),
(18, 1176),
(18, 1177),
(23, 1178),
(107, 1181),
(39, 1188),
(39, 1189),
(47, 1194),
(62, 1196),
(62, 1197),
(62, 1198),
(63, 1199),
(64, 1200),
(77, 1205),
(123, 1210),
(123, 1211),
(2, 1212),
(2, 1213),
(148, 1219),
(25, 1236),
(74, 1237),
(74, 1238),
(74, 1239),
(13, 1240),
(13, 1241),
(84, 1242),
(84, 1243),
(84, 1244),
(34, 1245),
(34, 1246),
(34, 1247),
(34, 1248),
(73, 1249),
(73, 1250),
(73, 1251),
(73, 1252),
(73, 1253),
(67, 1254),
(67, 1255),
(67, 1256),
(3, 1257),
(3, 1258),
(10, 1264),
(10, 1265),
(10, 1266),
(10, 1267),
(10, 1268),
(12, 1273),
(12, 1274),
(12, 1275),
(12, 1276),
(12, 1277),
(54, 1278),
(54, 1279),
(54, 1280),
(54, 1281),
(54, 1282),
(11, 1283),
(11, 1284),
(11, 1285),
(11, 1286),
(11, 1287),
(11, 1288),
(11, 1289),
(11, 1290),
(11, 1291),
(69, 1292),
(69, 1293),
(69, 1294),
(69, 1295),
(91, 1296),
(91, 1297),
(91, 1298),
(91, 1299),
(91, 1300),
(91, 1301),
(91, 1302),
(91, 1303),
(91, 1304),
(79, 1305),
(79, 1306),
(79, 1307),
(79, 1308),
(79, 1309),
(53, 1310),
(53, 1311),
(53, 1312),
(50, 1313),
(50, 1314),
(50, 1315),
(50, 1316),
(59, 1317),
(59, 1318),
(59, 1319),
(90, 1320),
(90, 1321),
(90, 1322),
(90, 1323),
(90, 1324),
(136, 1325),
(137, 1326),
(137, 1327),
(146, 1331),
(147, 1332),
(147, 1333),
(149, 1334),
(151, 1336),
(152, 1337),
(153, 1338),
(153, 1339),
(153, 1340),
(153, 1341),
(155, 1342),
(127, 1363),
(150, 1364),
(29, 1365),
(29, 1366),
(112, 1369),
(112, 1370),
(159, 1371),
(82, 1381),
(24, 1382),
(24, 1383),
(24, 1384),
(68, 1385),
(7, 1387),
(157, 1389),
(157, 1390),
(157, 1391),
(157, 1392),
(100, 1396),
(121, 1397),
(160, 1408),
(160, 1409),
(85, 1410),
(85, 1411),
(85, 1412),
(85, 1413),
(120, 1414),
(142, 1420),
(163, 1421),
(164, 1422),
(165, 1423),
(165, 1424),
(165, 1425),
(138, 1426),
(138, 1427),
(138, 1428),
(154, 1429),
(154, 1430),
(154, 1431),
(43, 1438),
(33, 1442),
(33, 1443),
(55, 1444),
(51, 1445),
(156, 1447),
(158, 1448),
(4, 1449),
(4, 1450),
(4, 1451),
(139, 1452),
(139, 1453),
(1, 1454),
(1, 1455),
(1, 1456),
(1, 1457),
(162, 1466),
(162, 1467),
(162, 1468),
(162, 1469);

-- --------------------------------------------------------

--
-- Structure de la table `metrics`
--

CREATE TABLE `metrics` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL DEFAULT '0',
  `Value` int(11) NOT NULL DEFAULT '0',
  `Date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `metrics`
--

INSERT INTO `metrics` (`ID`, `Name`, `Value`, `Date`) VALUES
(1, 'activeStudents', 131, '2017-12-27'),
(2, 'activeWhiteStudents', 86, '2017-12-27'),
(3, 'activeBlueStudents', 16, '2017-12-27'),
(4, 'activePurpleStudents', 13, '2017-12-27'),
(5, 'activeBrownStudents', 6, '2017-12-27'),
(6, 'activeBlackStudents', 10, '2017-12-27');

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
  `Bank` enum('None','Academy','Perso') NOT NULL DEFAULT 'None',
  `DepotDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `payments`
--

INSERT INTO `payments` (`ID`, `Amount`, `Type`, `ReceptionDate`, `Name`, `Debt`, `Bank`, `DepotDate`) VALUES
(452, 140, 'Cash', '2017-06-01', 'Guillaume LE MAUT', 84, 'None', '2017-10-26'),
(684, 280, 'Check', '2017-10-05', 'Raphael GRESSIN', 168, 'Academy', '2017-10-06'),
(759, 500, 'Check', '2017-09-15', 'Didier BARRAUD', 300, 'Academy', '2017-09-16'),
(789, 500, 'Check', '2017-10-05', 'Corentin CAHEN', 300, 'Academy', '2017-10-06'),
(790, 280, 'Check', '2017-09-25', 'Sarah CASSESE', 168, 'Academy', '2017-10-04'),
(793, 350, 'Check', '2017-10-05', 'Pierre CHAMBON', 210, 'Academy', '2017-10-06'),
(795, 120, 'Cash', '2017-09-05', 'Bagdad CHECKRI', 0, 'None', '2017-10-26'),
(796, 500, 'Check', '2017-09-25', 'Adrien CHEMINET', 300, 'Academy', '2017-10-04'),
(799, 350, 'Check', '2017-07-11', 'Daniel CURVAT', 210, 'Academy', '2017-08-02'),
(801, 220, 'Check', '2017-09-05', 'Christian DEGUIS', 132, 'Academy', '2017-09-06'),
(802, 500, 'Check', '2017-05-10', 'Jerome DIVAC', 300, 'Academy', '2017-05-11'),
(805, 500, 'Check', '2017-09-07', 'Pierre DORE', 300, 'Academy', '2017-09-07'),
(807, 80, 'Cash', '2017-09-14', 'Eric DRIKES', 0, 'None', '2017-10-26'),
(808, 80, 'Cash', '2017-10-16', 'Eric DRIKES', 0, 'None', '2017-10-26'),
(816, 500, 'Check', '2017-09-15', 'Florian FONTRIER', 300, 'Academy', '2017-09-16'),
(819, 700, 'Check', '2017-09-14', 'Simon FRANQUET', 420, 'Academy', '2017-09-15'),
(820, 80, 'Check', '2017-07-11', 'Simon FRANQUET', 48, 'Academy', '2017-08-02'),
(833, 170, 'Cash', '2017-09-07', 'Matias GOURDON', 0, 'None', '2017-10-26'),
(834, 80, 'Cash', '2017-07-18', 'Matias GOURDON', 48, 'None', '2017-10-26'),
(839, 500, 'Check', '2017-05-10', 'Gwenael HUET', 300, 'Academy', '2017-05-11'),
(840, 500, 'Check', '2017-10-05', 'Dominique JACQUES', 300, 'Academy', '2017-10-06'),
(841, 500, 'Check', '2017-09-12', 'Sylvain JOLIY', 300, 'Academy', '2017-09-13'),
(847, 500, 'Check', '2017-09-27', 'Artyom KORMESHOV', 300, 'Academy', '2017-10-04'),
(848, 100, 'Check', '2017-06-08', 'Artyom KORMESHOV', 60, 'Academy', '2017-07-05'),
(858, 450, 'Check', '2017-09-07', 'Yohann LES ENFANT', 270, 'Academy', '2017-09-07'),
(859, 500, 'Check', '2017-09-27', 'Gregory LETELLIER', 300, 'Academy', '2017-10-04'),
(860, 280, 'Check', '2017-09-18', 'Anne LETESSIER', 168, 'Academy', '2017-09-19'),
(864, 500, 'Check', '2017-09-28', 'Charles MACQUART MOULIN', 300, 'Academy', '2017-10-04'),
(871, 100, 'Check', '2017-05-10', 'Joan MESINELE', 60, 'Academy', '2017-10-04'),
(872, 100, 'Check', '2017-05-10', 'Joan MESINELE', 60, 'Academy', '2017-09-05'),
(873, 100, 'Check', '2017-05-10', 'Joan MESINELE', 60, 'Academy', '2017-08-02'),
(874, 100, 'Check', '2017-05-10', 'Joan MESINELE', 60, 'Academy', '2017-07-05'),
(875, 100, 'Check', '2017-05-10', 'Joan MESINELE', 60, 'Academy', '2017-06-04'),
(877, 500, 'Check', '2017-09-07', 'Franck NGUYEN', 300, 'Academy', '2017-09-07'),
(878, 100, 'Check', '2017-09-28', 'Stephane NGUYEN', 60, 'Academy', '2017-10-04'),
(879, 500, 'Check', '2017-07-11', 'Stephane NGUYEN', 300, 'Academy', '2017-08-02'),
(883, 210, 'Check', '2017-06-01', 'Samuel OLIVIER', 126, 'Academy', '2017-07-05'),
(884, 210, 'Check', '2017-06-01', 'Samuel OLIVIER', 126, 'Academy', '2017-06-04'),
(904, 1100, 'Check', '2017-10-05', 'Mirjana POLJAKOVIC', 700, 'Academy', '2017-10-06'),
(915, 200, 'Cash', '2017-09-21', 'Mehdi SAIDI', 0, 'None', '2017-10-26'),
(920, 200, 'Cash', '2017-10-05', 'Sylvain TARIN', 0, 'None', '2017-10-26'),
(925, 500, 'Check', '2017-05-10', 'Moussa TIMERA', 300, 'Academy', '2017-05-11'),
(931, 380, 'Check', '2017-10-02', 'Alexis TRUJILLO', 228, 'Academy', '2017-10-04'),
(932, 350, 'Check', '2017-09-21', 'Arthur TSIMI', 210, 'Academy', '2017-10-04'),
(933, 200, 'Cash', '2017-09-08', 'Yohan VERGNE', 0, 'None', '2017-10-26'),
(939, 500, 'Check', '2017-05-10', 'Alexandre WALLOIS', 300, 'Academy', '2017-05-11'),
(955, 280, 'Check', '2017-09-28', 'Lionel BENICHOU', 168, 'Academy', '2017-10-04'),
(956, 100, 'Check', '2017-05-10', 'Amandine BOUVAT', 60, 'Academy', '2017-05-11'),
(957, 100, 'Check', '2017-05-10', 'Amandine BOUVAT', 60, 'Academy', '2017-06-04'),
(958, 100, 'Check', '2017-05-10', 'Amandine BOUVAT', 60, 'Academy', '2017-07-05'),
(959, 100, 'Check', '2017-05-10', 'Amandine BOUVAT', 60, 'Academy', '2017-08-02'),
(960, 100, 'Check', '2017-05-10', 'Amandine BOUVAT', 60, 'Academy', '2017-09-05'),
(961, 200, 'Check', '2017-05-10', 'Manuel BRUN', 120, 'Academy', '2017-06-04'),
(963, 150, 'Check', '2017-09-14', 'Cyril CHIMKIEVITCH', 90, 'Academy', '2017-09-15'),
(971, 500, 'Check', '2017-10-20', 'Vincent PUYDOYEUX', 300, 'Academy', '2017-11-04'),
(972, 500, 'Check', '2017-10-20', 'Mamadou? DJOULFAYAN', 300, 'Academy', '2017-11-04'),
(982, 500, 'Check', '2017-10-10', 'Jules GRUBO', 300, 'Academy', '2017-11-04'),
(1001, 250, 'Check', '2017-09-18', 'Christophe TROEL', 150, 'Academy', '2017-11-04'),
(1002, 250, 'Check', '2017-09-18', 'Christophe TROEL', 150, 'Academy', '2017-10-04'),
(1003, 110, 'Check', '2017-05-10', 'Christophe TROEL', 66, 'Academy', '2017-06-04'),
(1004, 110, 'Check', '2017-05-10', 'Christophe TROEL', 66, 'Academy', '2017-05-11'),
(1012, 175, 'Check', '2017-10-16', 'Jeremy PICOSTE', 105, 'Academy', '2017-11-04'),
(1014, 80, 'Check', '2017-09-18', 'Nissim ZERBIB', 48, 'Academy', '2017-09-19'),
(1015, 420, 'Check', '2017-10-16', 'Nissim ZERBIB', 252, 'Academy', '2017-11-04'),
(1024, 250, 'Check', '2017-09-28', 'Jean Paul FOURNET', 150, 'Academy', '2017-10-04'),
(1025, 250, 'Check', '2017-09-28', 'Jean Paul FOURNET', 150, 'Academy', '2017-11-04'),
(1028, 250, 'Check', '2017-09-21', 'Mickael FERREIRA', 150, 'Academy', '2017-10-04'),
(1029, 250, 'Check', '2017-09-21', 'Mickael FERREIRA', 150, 'Academy', '2017-11-04'),
(1056, 200, 'Check', '2017-09-14', 'Nelson SILVA', 120, 'Academy', '2017-11-04'),
(1057, 150, 'Check', '2017-09-14', 'Nelson SILVA', 90, 'Academy', '2017-10-04'),
(1058, 150, 'Check', '2017-09-14', 'Nelson SILVA', 90, 'Academy', '2017-09-15'),
(1068, 50, 'Cash', '2017-06-01', 'David THOMAS', 30, 'None', '2017-10-26'),
(1078, 56, 'Check', '2017-09-14', 'Fabrice BUKASSA', 34, 'Academy', '2017-10-04'),
(1079, 56, 'Check', '2017-09-14', 'Fabrice BUKASSA', 34, 'Academy', '2017-11-04'),
(1080, 50, 'Cash', '2017-09-14', 'Fabrice BUKASSA', 0, 'None', '2017-10-27'),
(1082, 80, 'Check', '2017-05-10', 'Aurianne CHARMET', 48, 'Academy', '2017-05-11'),
(1083, 80, 'Check', '2017-05-10', 'Kevin MALGERARD', 48, 'Academy', '2017-05-11'),
(1084, 50, 'Check', '2017-10-16', 'Marc PELLET', 30, 'Academy', '2017-11-04'),
(1085, 150, 'Check', '2017-09-21', 'Nathalie VANDERBURG', 90, 'Academy', '2017-10-04'),
(1086, 100, 'Check', '2017-09-25', 'Nathalie VANDERBURG', 60, 'Academy', '2017-11-04'),
(1114, 80, 'Check', '2017-11-09', 'Sofien ZAMITTI', 48, 'Academy', '2017-11-10'),
(1115, 350, 'Check', '2017-11-09', 'Hichem ARFAOUI', 210, 'Academy', '2017-11-10'),
(1119, 250, 'Check', '2017-11-09', 'Olivier ROINEL', 150, 'None', '2017-11-09'),
(1120, 250, 'Check', '2017-11-09', 'Olivier ROINEL', 150, 'Academy', '2017-11-10'),
(1121, 80, 'Check', '2017-11-09', 'Martin CZABADAJ', 48, 'Academy', '2017-11-10'),
(1125, 80, 'Check', '2017-09-28', 'Julien GAZAVE', 48, 'Academy', '2017-10-04'),
(1126, 80, 'Check', '2017-11-09', 'Julien GAZAVE', 48, 'Academy', '2017-11-10'),
(1143, 100, 'Check', '2017-06-08', 'Jean-Marc BLOMBOU', 60, 'None', '2017-10-26'),
(1144, 100, 'Check', '2017-06-08', 'Jean-Marc BLOMBOU', 60, 'None', '2017-10-26'),
(1145, 100, 'Check', '2017-06-08', 'Jean-Marc BLOMBOU', 60, 'Academy', '2017-09-05'),
(1146, 100, 'Check', '2017-06-08', 'Jean-Marc BLOMBOU', 60, 'Academy', '2017-08-02'),
(1147, 100, 'Check', '2017-06-08', 'Jean-Marc BLOMBOU', 60, 'Academy', '2017-07-05'),
(1149, 120, 'Cash', '2017-09-19', 'Neo ALZIEU', 0, 'None', '2017-10-26'),
(1159, 50, 'Cash', '2017-10-02', 'Frederique BARDEY', 0, 'None', '2017-10-26'),
(1160, 250, 'Check', '2017-10-02', 'Frederique BARDEY', 150, 'Academy', '2017-10-04'),
(1161, 50, 'Cash', '2017-11-15', 'Frederique BARDEY', 0, 'None', '2017-11-15'),
(1175, 40, 'Cash', '2017-09-25', 'Thomas CASTAN', 0, 'None', '2017-10-26'),
(1176, 210, 'Check', '2017-11-09', 'Thomas CASTAN', 126, 'Academy', '2017-11-10'),
(1177, 210, 'Check', '2017-11-09', 'Thomas CASTAN', 126, 'Academy', '2017-11-10'),
(1178, 250, 'Check', '2017-10-10', 'Aime CONTI', 0, 'Academy', '2017-11-04'),
(1181, 500, 'Check', '2017-07-18', 'Jorge DO PINHAL', 300, 'Academy', '2017-08-02'),
(1188, 365, 'Check', '2017-09-25', 'Delphine GAO', 219, 'Academy', '2017-10-04'),
(1189, 365, 'Check', '2017-10-16', 'Delphine GAO', 219, 'Academy', '2017-11-04'),
(1194, 280, 'Check', '2017-09-21', 'Olivier HASSID', 168, 'Academy', '2017-10-04'),
(1196, 200, 'Check', '2017-09-18', 'Yann MALARD', 120, 'Academy', '2017-09-19'),
(1197, 150, 'Check', '2017-09-18', 'Yann MALARD', 90, 'Academy', '2017-10-04'),
(1198, 150, 'Check', '2017-09-18', 'Yann MALARD', 90, 'Academy', '2017-11-04'),
(1199, 500, 'Check', '2017-09-19', 'Marco MARZILLI', 300, 'Academy', '2017-10-04'),
(1200, 500, 'Check', '2017-10-16', 'Didier MAUS', 300, 'Academy', '2017-11-04'),
(1205, 350, 'Check', '2017-09-25', 'François David PUCHEU LASHORES', 210, 'Academy', '2017-10-04'),
(1210, 250, 'Check', '2017-11-09', 'Alessandro ZANNI', 150, 'None', '2017-11-09'),
(1211, 100, 'Cash', '2017-11-09', 'Alessandro ZANNI', 0, 'None', '2017-11-09'),
(1212, 40, 'Cash', '2017-09-05', 'Raphael ANI', 0, 'None', '2017-10-26'),
(1213, 210, 'Cash', '2017-11-21', 'Raphael ARIE', 0, 'None', '2017-11-21'),
(1219, 500, 'Check', '2017-11-30', 'Denis CEOLIN', 300, 'None', '2017-11-30'),
(1236, 200, 'Cash', '2017-09-28', 'Olivier DAURARIO', 0, 'None', '2017-10-26'),
(1237, 80, 'Check', '2017-09-14', 'Celine PERREARD', 48, 'Academy', '2017-09-15'),
(1238, 220, 'Check', '2017-11-30', 'Celine PERREARD', 132, 'Academy', '2017-12-04'),
(1239, 200, 'Check', '2017-11-30', 'Celine PERREARD', 120, 'None', '2017-11-30'),
(1240, 500, 'Check', '2017-09-12', 'Gauthier BRYSBAERT', 300, 'Academy', '2017-12-04'),
(1241, 80, 'Check', '2017-06-01', 'Gauthier BRYSBAERT', 48, 'Academy', '2017-06-04'),
(1242, 100, 'Check', '2017-09-21', 'Vincent TERRONI', 60, 'Academy', '2017-12-04'),
(1243, 100, 'Check', '2017-09-21', 'Vincent TERRONI', 60, 'Academy', '2017-11-04'),
(1244, 80, 'Check', '2017-09-21', 'Vincent TERRONI', 48, 'Academy', '2017-10-04'),
(1245, 125, 'Check', '2017-09-12', 'Marc antoine FIGHIERA', 75, 'Academy', '2017-09-13'),
(1246, 125, 'Check', '2017-09-21', 'Marc antoine FIGHIERA', 75, 'Academy', '2017-10-04'),
(1247, 125, 'Check', '2017-09-21', 'Marc antoine FIGHIERA', 75, 'Academy', '2017-11-04'),
(1248, 125, 'Check', '2017-09-21', 'Marc antoine FIGHIERA', 75, 'Academy', '2017-12-04'),
(1249, 100, 'Check', '2017-09-21', 'Emmanuel PEREIRA VIEIRA', 60, 'None', '2017-10-26'),
(1250, 100, 'Check', '2017-09-21', 'Emmanuel PEREIRA VIEIRA', 60, 'None', '2017-10-26'),
(1251, 100, 'Check', '2017-09-21', 'Emmanuel PEREIRA VIEIRA', 60, 'Academy', '2017-12-04'),
(1252, 100, 'Check', '2017-09-21', 'Emmanuel PEREIRA VIEIRA', 60, 'Academy', '2017-11-04'),
(1253, 100, 'Check', '2017-09-21', 'Emmanuel PEREIRA VIEIRA', 60, 'Academy', '2017-10-04'),
(1254, 200, 'Check', '2017-09-28', 'Nicolas NZAMBA', 120, 'Academy', '2017-11-04'),
(1255, 150, 'Check', '2017-09-28', 'Nicolas NZAMBA', 90, 'Academy', '2017-12-04'),
(1256, 150, 'Check', '2017-09-28', 'Nicolas NZAMBA', 90, 'Academy', '2017-10-04'),
(1257, 250, 'Check', '2017-10-17', 'Martine ATTALI', 150, 'Academy', '2017-12-04'),
(1258, 250, 'Check', '2017-10-17', 'Martine ATTALI', 150, 'Academy', '2017-11-04'),
(1264, 100, 'Check', '2017-09-12', 'Sebastien BIDAULT', 60, 'None', '2017-10-26'),
(1265, 100, 'Check', '2017-09-12', 'Sebastien BIDAULT', 60, 'None', '2017-10-26'),
(1266, 100, 'Check', '2017-09-12', 'Sebastien BIDAULT', 60, 'Academy', '2017-12-04'),
(1267, 100, 'Check', '2017-09-12', 'Sebastien BIDAULT', 60, 'Academy', '2017-11-04'),
(1268, 100, 'Check', '2017-09-12', 'Sebastien BIDAULT', 60, 'Academy', '2017-10-04'),
(1273, 100, 'Check', '2017-09-15', 'Julien BOURGEOIS', 60, 'None', '2017-10-26'),
(1274, 100, 'Check', '2017-09-15', 'Julien BOURGEOIS', 60, 'None', '2017-10-26'),
(1275, 100, 'Check', '2017-09-15', 'Julien BOURGEOIS', 60, 'Academy', '2017-12-04'),
(1276, 100, 'Check', '2017-09-15', 'Julien BOURGEOIS', 60, 'Academy', '2017-11-04'),
(1277, 100, 'Check', '2017-09-15', 'Julien BOURGEOIS', 60, 'Academy', '2017-09-16'),
(1278, 100, 'Check', '2017-09-05', 'Cedric LE FRANC', 60, 'None', '2017-10-26'),
(1279, 100, 'Check', '2017-09-05', 'Cedric LE FRANC', 60, 'Academy', '2017-12-04'),
(1280, 100, 'Check', '2017-09-05', 'Cedric LE FRANC', 60, 'Academy', '2017-11-04'),
(1281, 100, 'Check', '2017-09-05', 'Cedric LE FRANC', 60, 'Academy', '2017-10-04'),
(1282, 100, 'Check', '2017-09-05', 'Cedric LE FRANC', 60, 'Academy', '2017-09-06'),
(1283, 100, 'Check', '2017-09-18', 'Farid BOUHAZEM', 60, 'None', '2017-10-26'),
(1284, 100, 'Check', '2017-09-18', 'Farid BOUHAZEM', 60, 'None', '2017-10-26'),
(1285, 100, 'Check', '2017-09-18', 'Farid BOUHAZEM', 60, 'Academy', '2017-12-04'),
(1286, 100, 'Check', '2017-09-18', 'Farid BOUHAZEM', 60, 'Academy', '2017-11-04'),
(1287, 100, 'Check', '2017-09-18', 'Farid BOUHAZEM', 60, 'Academy', '2017-10-04'),
(1288, 55, 'Check', '2017-05-10', 'Farid BOUHAZEM', 33, 'Academy', '2017-09-05'),
(1289, 55, 'Check', '2017-05-10', 'Farid BOUHAZEM', 33, 'Academy', '2017-08-02'),
(1290, 55, 'Check', '2017-05-10', 'Farid BOUHAZEM', 33, 'Academy', '2017-07-07'),
(1291, 55, 'Check', '2017-05-10', 'Farid BOUHAZEM', 33, 'Academy', '2017-06-04'),
(1292, 125, 'Check', '2017-09-25', 'Alban OUAHAB', 75, 'None', '2017-10-26'),
(1293, 125, 'Check', '2017-09-25', 'Alban OUAHAB', 75, 'Academy', '2017-12-04'),
(1294, 125, 'Check', '2017-09-25', 'Alban OUAHAB', 75, 'Academy', '2017-11-04'),
(1295, 125, 'Check', '2017-09-25', 'Alban OUAHAB', 75, 'Academy', '2017-10-04'),
(1296, 100, 'Check', '2017-09-25', 'Paul-François YGORRA', 60, 'None', '2017-10-26'),
(1297, 100, 'Check', '2017-09-25', 'Paul-François YGORRA', 60, 'None', '2017-10-26'),
(1298, 100, 'Check', '2017-09-25', 'Paul-François YGORRA', 60, 'None', '2017-10-26'),
(1299, 100, 'Check', '2017-09-25', 'Paul-François YGORRA', 60, 'None', '2017-10-26'),
(1300, 100, 'Check', '2017-09-25', 'Paul-François YGORRA', 60, 'Academy', '2017-12-04'),
(1301, 50, 'Check', '2017-05-10', 'Paul-François YGORRA', 30, 'Academy', '2017-09-05'),
(1302, 50, 'Check', '2017-05-10', 'Paul-François YGORRA', 30, 'Academy', '2017-06-04'),
(1303, 60, 'Check', '2017-05-10', 'Paul-François YGORRA', 36, 'Academy', '2017-08-02'),
(1304, 60, 'Check', '2017-05-10', 'Paul-François YGORRA', 36, 'Academy', '2017-07-05'),
(1305, 100, 'Check', '2017-09-25', 'Djamel SAHRAOUI', 60, 'None', '2017-10-26'),
(1306, 100, 'Check', '2017-09-25', 'Djamel SAHRAOUI', 60, 'None', '2017-10-26'),
(1307, 100, 'Check', '2017-09-25', 'Djamel SAHRAOUI', 60, 'None', '2017-10-26'),
(1308, 100, 'Check', '2017-09-25', 'Djamel SAHRAOUI', 60, 'Academy', '2017-12-04'),
(1309, 150, 'Check', '2017-09-25', 'Djamel SAHRAOUI', 110, 'Academy', '2017-10-04'),
(1310, 200, 'Check', '2017-09-25', 'Vincent LACERENZA', 120, 'None', '2017-10-26'),
(1311, 150, 'Check', '2017-09-25', 'Vincent LACERENZA', 90, 'Academy', '2017-12-04'),
(1312, 150, 'Check', '2017-09-25', 'Vincent LACERENZA', 90, 'Academy', '2017-10-04'),
(1313, 125, 'Check', '2017-10-05', 'Nabil KADID', 75, 'None', '2017-10-26'),
(1314, 125, 'Check', '2017-10-05', 'Nabil KADID', 75, 'Academy', '2017-12-04'),
(1315, 125, 'Check', '2017-10-05', 'Nabil KADID', 75, 'Academy', '2017-11-04'),
(1316, 125, 'Check', '2017-10-05', 'Nabil KADID', 75, 'Academy', '2017-10-06'),
(1317, 80, 'Check', '2017-09-07', 'Thomas MACHADO', 48, 'Academy', '2017-09-07'),
(1318, 210, 'Check', '2017-10-10', 'Thomas MACHADO', 126, 'Academy', '2017-12-04'),
(1319, 210, 'Check', '2017-10-10', 'Thomas MACHADO', 126, 'Academy', '2017-11-04'),
(1320, 100, 'Check', '2017-10-16', 'Guillaume VIGNE', 60, 'Academy', '2017-11-04'),
(1321, 100, 'Check', '2017-10-16', 'Guillaume VIGNE', 60, 'Academy', '2017-12-04'),
(1322, 100, 'Check', '2017-10-16', 'Guillaume VIGNE', 60, 'None', '2017-10-26'),
(1323, 100, 'Check', '2017-10-16', 'Guillaume VIGNE', 60, 'None', '2017-10-26'),
(1324, 100, 'Check', '2017-10-16', 'Guillaume VIGNE', 60, 'None', '2017-10-26'),
(1325, 350, 'Check', '2017-11-15', 'QUINQUENEL Jean-Baptiste', 210, 'Academy', '2017-12-04'),
(1326, 200, 'Check', '2017-11-15', 'FARAUT Julien', 120, 'None', '2017-11-15'),
(1327, 200, 'Check', '2017-11-15', 'FARAUT Julien', 120, 'Academy', '2017-12-04'),
(1331, 400, 'Check', '2017-11-21', 'nicolas duvauchelle', 240, 'Academy', '2017-12-04'),
(1332, 125, 'Check', '2017-11-21', 'Sebastien LOPES', 75, 'Academy', '2017-12-04'),
(1333, 125, 'Check', '2017-11-21', 'Sebastien LOPES', 75, 'None', '2017-11-21'),
(1334, 500, 'Check', '2017-11-30', 'Yohann LY', 300, 'Academy', '2017-12-04'),
(1336, 80, 'Check', '2017-11-30', 'Jennifer MALGERARD', 48, 'Academy', '2017-12-04'),
(1337, 500, 'Check', '2017-11-30', 'Nicolas MALARD', 300, 'Academy', '2017-12-04'),
(1338, 125, 'Check', '2017-11-30', 'David DONNINI', 75, 'Academy', '2017-12-04'),
(1339, 125, 'Check', '2017-11-30', 'David DONNINI', 75, 'None', '2017-11-30'),
(1340, 125, 'Check', '2017-11-30', 'David DONNINI', 75, 'None', '2017-11-30'),
(1341, 125, 'Check', '2017-11-30', 'David DONNINI', 75, 'None', '2017-11-30'),
(1342, 150, 'Check', '2017-12-04', 'Roméo YOMBOU', 0, 'Academy', '2017-12-04'),
(1363, 70, 'Cash', '2017-11-09', 'Denis DAVIDKOV', 0, 'None', '2017-11-09'),
(1364, 500, 'Check', '2017-11-30', 'Thibaud DENINGER', 300, 'Academy', '2017-12-04'),
(1365, 100, 'Cash', '2017-09-05', 'Raphael DOS SANTOS', 0, 'None', '2017-10-26'),
(1366, 250, 'Cash', '2017-11-09', 'Raphael DOS SANTOS', 0, 'None', '2017-11-09'),
(1369, 250, 'Check', '2017-06-01', 'MOUSTAKIM HASSANI', 150, 'Academy', '2017-06-04'),
(1370, 250, 'Check', '2017-12-07', 'Moustakima HASSANI', 150, 'Academy', '2017-12-07'),
(1371, 500, 'Check', '2017-12-07', 'Roy HARRIS', 300, 'Academy', '2017-12-07'),
(1381, 80, 'Cash', '2017-09-14', 'Andrei STRUTGNSHGG', 0, 'None', '2017-10-26'),
(1382, 100, 'Check', '2017-09-05', 'Yim DARINA', 60, 'Academy', '2017-10-04'),
(1383, 100, 'Check', '2017-09-05', 'Yim DARINA', 60, 'Academy', '2017-09-06'),
(1384, 80, 'Check', '2017-05-10', 'Yim DARINA', 48, 'Academy', '2017-05-11'),
(1385, 40, 'Cash', '2017-09-14', 'Noel ONIZKO', 0, 'None', '2017-10-26'),
(1387, 40, 'Cash', '2017-09-05', 'John BARFF', 0, 'None', '2017-10-26'),
(1389, 50, 'Check', '2017-12-07', 'dominique BOYER', 30, 'Academy', '2017-12-07'),
(1390, 50, 'Check', '2017-12-07', 'dominique BOYER', 30, 'None', '2017-12-07'),
(1391, 50, 'Check', '2017-12-07', 'dominique BOYER', 30, 'None', '2017-12-07'),
(1392, 50, 'Check', '2017-12-07', 'dominique BOYER', 30, 'None', '2017-12-07'),
(1396, 350, 'Check', '2017-06-28', 'Frederique AMBROISE', 210, 'Academy', '2017-07-05'),
(1397, 80, 'Check', '2017-11-09', 'Thomas BISSON', 48, 'Academy', '2017-11-10'),
(1408, 200, 'Check', '2017-12-07', 'Hernan VASQUEZ MORA', 120, 'Perso', '2017-12-17'),
(1409, 200, 'Check', '2017-12-07', 'Hernan VASQUEZ MORA', 120, 'None', '2017-12-07'),
(1410, 50, 'Cash', '2017-10-20', 'Adrien TIREL', 0, 'None', '2017-10-26'),
(1411, 140, 'Check', '2017-12-07', 'Adrien TIREL', 84, 'Academy', '2017-12-07'),
(1412, 140, 'Check', '2017-12-07', 'Adrien TIREL', 84, 'None', '2017-12-07'),
(1413, 140, 'Check', '2017-12-07', 'Adrien TIREL', 84, 'None', '2017-12-07'),
(1414, 210, 'Check', '2017-11-09', 'Simon THULEAU', 126, 'Academy', '2017-11-10'),
(1420, 500, 'Check', '2017-12-19', 'Sylvain DESHORS', 300, 'None', '2017-12-19'),
(1421, 80, 'Check', '2017-12-19', 'Matthieu LHOSPITALIER', 48, 'None', '2017-12-19'),
(1422, 250, 'Cash', '2017-12-19', 'aissa eddami', 0, 'None', '2017-12-19'),
(1423, 150, 'Check', '2017-12-19', 'lothaire epee', 90, 'None', '2017-12-19'),
(1424, 150, 'Check', '2017-12-19', 'lothaire epee', 90, 'None', '2017-12-19'),
(1425, 200, 'Check', '2017-12-19', 'lothaire epee', 120, 'None', '2017-12-19'),
(1426, 100, 'Check', '2017-11-15', 'Michel-ange MATOUBA', 60, 'Academy', '2017-12-04'),
(1427, 100, 'Check', '2017-11-15', 'Michel-ange MATOUBA', 60, 'None', '2017-11-15'),
(1428, 75, 'Check', '2017-11-15', 'Michel-ange MATOUBA', 45, 'None', '2017-11-15'),
(1429, 200, 'Check', '2017-11-30', 'Juan NERINA', 120, 'None', '2017-11-30'),
(1430, 150, 'Check', '2017-11-30', 'Juan NERINA', 90, 'None', '2017-11-30'),
(1431, 150, 'Check', '2017-11-30', 'Juan NERINA', 90, 'None', '2017-11-30'),
(1438, 125, 'Check', '2017-09-07', 'Yoann GOLESTIN', 75, 'Academy', '2017-10-04'),
(1442, 80, 'Cash', '2017-10-05', 'Brice FIGARO', 0, 'None', '2017-10-26'),
(1443, 150, 'Cash', '2017-11-15', 'Brice FIGARO', 0, 'None', '2017-11-15'),
(1444, 100, 'Cash', '2017-09-18', 'Jonas LEBLANC', 0, 'None', '2017-10-26'),
(1445, 30, 'Cash', '2017-10-20', 'Olivier KAZ', 0, 'None', '2017-10-26'),
(1447, 40, 'Cash', '2017-12-07', 'inconnnu HORSKYY', 0, 'None', '2017-12-07'),
(1448, 160, 'Check', '2017-12-07', 'zou thien du chabert', 96, 'Academy', '2017-12-07'),
(1449, 200, 'Check', '2017-09-18', 'Eddy BARCLAY', 120, 'Academy', '2017-11-10'),
(1450, 150, 'Check', '2017-09-18', 'Eddy BARCLAY', 90, 'None', '2017-10-26'),
(1451, 150, 'Check', '2017-09-18', 'Eddy BARCLAY', 90, 'Academy', '2017-10-04'),
(1452, 125, 'Check', '2017-12-18', 'Akhmed SALAMOV', 75, 'None', '2017-12-18'),
(1453, 125, 'Check', '2017-12-18', 'Akhmed SALAMOV', 75, 'None', '2017-12-18'),
(1454, 125, 'Check', '2017-09-14', 'David Gauthier', 75, 'Academy', '2017-10-04'),
(1455, 125, 'Check', '2017-09-14', 'David Gauthier', 75, 'Academy', '2017-11-04'),
(1456, 125, 'Check', '2017-09-14', 'David Gauthier', 75, 'Academy', '2017-12-04'),
(1457, 125, 'Check', '2017-09-14', 'David Gauthier', 75, 'None', '2017-10-26'),
(1466, 50, 'Cash', '2017-12-12', 'david ankri', 0, 'None', '2017-12-12'),
(1467, 120, 'Check', '2017-12-26', 'David ANKRI', 72, 'Perso', '2017-12-26'),
(1468, 140, 'Check', '2017-12-26', 'David ANKRI', 84, 'None', '2017-12-26'),
(1469, 140, 'Check', '2017-12-26', 'David ANKRI', 84, 'None', '2017-12-26');

-- --------------------------------------------------------

--
-- Structure de la table `privates`
--

CREATE TABLE `privates` (
  `ID` int(11) NOT NULL,
  `MemberID` int(11) NOT NULL,
  `Amount` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `bookedLessons` int(11) DEFAULT NULL,
  `doneLessons` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `privates`
--

INSERT INTO `privates` (`ID`, `MemberID`, `Amount`, `Date`, `bookedLessons`, `doneLessons`) VALUES
(1, 143, 250, '2017-11-20', 5, 2),
(2, 144, 200, '2017-11-30', 5, 5),
(3, 142, 60, '2017-10-17', 1, 1),
(4, 44, 250, '2017-11-23', 5, 5),
(5, 145, 60, '2017-10-26', 1, 1),
(6, 44, 250, '2017-12-11', 5, 2),
(7, 142, 60, '2017-11-28', 1, 1),
(8, 144, 0, '2017-12-22', 5, 2);

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
(3, 'Paiement Etienne Gregoire', 90, '2017-10-16', NULL),
(4, 'Paiement Etienne Gregoire', 150, '2017-11-10', NULL),
(5, 'Location', 10000, '2017-11-15', ''),
(6, 'Paiement Etienne Gregoire', 90, '2017-12-01', ''),
(7, 'Paiement Etienne Gregoire', 120, '2017-12-24', '');

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
(2, 'Basics', '2017-09-10', 23, 31, 1357, 271, NULL),
(3, 'Passages de gardes', '2017-12-02', 10, 13, 570, 114, NULL);

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
-- Index pour la table `metrics`
--
ALTER TABLE `metrics`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `privates`
--
ALTER TABLE `privates`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_MEMBERS` (`MemberID`);

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
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT pour la table `dojo`
--
ALTER TABLE `dojo`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `members`
--
ALTER TABLE `members`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=166;
--
-- AUTO_INCREMENT pour la table `metrics`
--
ALTER TABLE `metrics`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT pour la table `payments`
--
ALTER TABLE `payments`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1470;
--
-- AUTO_INCREMENT pour la table `privates`
--
ALTER TABLE `privates`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `refunds`
--
ALTER TABLE `refunds`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT pour la table `seminars`
--
ALTER TABLE `seminars`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
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

--
-- Contraintes pour la table `privates`
--
ALTER TABLE `privates`
  ADD CONSTRAINT `FK_MEMBERS` FOREIGN KEY (`MemberID`) REFERENCES `members` (`ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
