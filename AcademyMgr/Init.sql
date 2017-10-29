CREATE TABLE `SEMINARS` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Theme` varchar(200) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `WebMEMBERS` int(11) DEFAULT NULL,
  `LocalMEMBERS` int(11) DEFAULT NULL,
  `Amount` int(11) DEFAULT NULL,
  `Debt` int(11) DEFAULT NULL,
  `Comment` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

CREATE TABLE `PRIVATES` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(200) DEFAULT NULL,
  `Amount` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `bookedLessons` int(11) DEFAULT NULL,
  `doneLessons` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

CREATE TABLE `REFUNDS` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Label` varchar(200) DEFAULT NULL,
  `Amount` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Comment` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

CREATE TABLE `DOJO` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `Surface` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

CREATE TABLE `COACHS` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Firstname` varchar(20) NOT NULL,
  `Lastname` varchar(20) NOT NULL,
  `Birthdate` date NOT NULL,
  `Belt` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

CREATE TABLE `COACHSPAYMENTS` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Month` varchar(200) DEFAULT NULL,
  `Coach` varchar(200) DEFAULT NULL,
  `Lessons` int(11) DEFAULT NULL,
  `Pay` int(11) DEFAULT NULL,
  `Amount` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Comment` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

CREATE TABLE `MEMBERS` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Firstname` varchar(200) NOT NULL,
  `Lastname` varchar(200) NOT NULL,
  `Enddate` date DEFAULT NULL,
  `Belt` enum('white','blue','purple','brown','black') NOT NULL,
  `Gender` enum('M','F') NOT NULL,
  `Child` tinyint(4) NOT NULL,
  `Alert` tinyint(4) NOT NULL,
  `Comment` text CHARACTER SET latin1,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `uq_MEMBERS` (`Firstname`,`Lastname`)
) ENGINE=InnoDB AUTO_INCREMENT=117 DEFAULT CHARSET=utf8;

CREATE TABLE `PAYMENTS` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Amount` int(11) DEFAULT NULL,
  `Type` varchar(20) DEFAULT NULL,
  `ReceptionDate` date DEFAULT NULL,
  `Name` varchar(200) DEFAULT NULL,
  `Debt` int(11) DEFAULT NULL,
  `DepotBank` tinyint(4) DEFAULT NULL,
  `DepotDate` date DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=736 DEFAULT CHARSET=utf8;

CREATE TABLE `MEMBERS_PAYMENTS` (
  `MemberID` int(11) NOT NULL,
  `PaymentID` int(11) NOT NULL,
  PRIMARY KEY (`MemberID`,`PaymentID`),
  KEY `FKPayment` (`PaymentID`),
  CONSTRAINT `FKMember` FOREIGN KEY (`MemberID`) REFERENCES `members` (`ID`),
  CONSTRAINT `FKPayment` FOREIGN KEY (`PaymentID`) REFERENCES `payments` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

insert into `SEMINARS`(`ID`,`Theme`,`Date`,`WebMEMBERS`,`LocalMEMBERS`,`Amount`,`Debt`,`Comment`) values (1,'Spider guard','2017-06-10 00:00:00',14,21,1000,200,null);
insert into `SEMINARS`(`ID`,`Theme`,`Date`,`WebMEMBERS`,`LocalMEMBERS`,`Amount`,`Debt`,`Comment`) values (2,'Basics','2017-09-10 00:00:00',23,31,1357,271,null);



insert into `PRIVATES`(`ID`,`Name`,`Amount`,`Date`,`bookedLessons`,`doneLessons`) values (1,'Brice Donadelli',250,'2017-10-05 00:00:00',5,2);
insert into `PRIVATES`(`ID`,`Name`,`Amount`,`Date`,`bookedLessons`,`doneLessons`) values (2,'Marco Romeu',200,'2017-10-12 00:00:00',5,2);
insert into `PRIVATES`(`ID`,`Name`,`Amount`,`Date`,`bookedLessons`,`doneLessons`) values (3,'Sylvain Deshors',60,'2017-10-17 00:00:00',1,1);
insert into `PRIVATES`(`ID`,`Name`,`Amount`,`Date`,`bookedLessons`,`doneLessons`) values (4,'Matias Gourdon',250,'2017-10-26 00:00:00',5,0);
insert into `PRIVATES`(`ID`,`Name`,`Amount`,`Date`,`bookedLessons`,`doneLessons`) values (5,'Clara Cabrerizo',60,'2017-10-26 00:00:00',1,1);



insert into `REFUNDS`(`ID`,`Label`,`Amount`,`Date`,`Comment`) values (1,'Pot stage',75,'2017-06-10 00:00:00',null);
insert into `REFUNDS`(`ID`,`Label`,`Amount`,`Date`,`Comment`) values (2,'Location',4625,'2017-08-15 00:00:00',null);
insert into `REFUNDS`(`ID`,`Label`,`Amount`,`Date`,`Comment`) values (3,'Paiement Etienne Gregoire',90,'2017-10-16 00:00:00',null);



insert into `DOJO`(`ID`,`Name`,`Surface`) values (1,'Petite Salle du bas',30);
insert into `DOJO`(`ID`,`Name`,`Surface`) values (2,'Principale',80);
insert into `DOJO`(`ID`,`Name`,`Surface`) values (3,'Salle du haut',50);



insert into `COACHS`(`ID`,`Firstname`,`Lastname`,`Birthdate`,`Belt`) values (1,'Thibaut','OLIVIER','0919-10-06 00:00:00','Black');
insert into `COACHS`(`ID`,`Firstname`,`Lastname`,`Birthdate`,`Belt`) values (2,'Matthieu','DELALANDRE','1979-10-07 00:00:00','Black');
insert into `COACHS`(`ID`,`Firstname`,`Lastname`,`Birthdate`,`Belt`) values (3,'François','MOLESLAS','0819-10-08 00:00:00','Brown');
insert into `COACHS`(`ID`,`Firstname`,`Lastname`,`Birthdate`,`Belt`) values (4,'Stephane','HENNEQUIN','1545-10-15 00:00:00','Black');



insert into `COACHSPAYMENTS`(`ID`,`Month`,`Coach`,`Lessons`,`Pay`,`Amount`,`Date`,`Comment`) values (1,'Septembre','Stéphane HENNEQUIN',4,25,100,'2017-10-11 00:00:00',null);
insert into `COACHSPAYMENTS`(`ID`,`Month`,`Coach`,`Lessons`,`Pay`,`Amount`,`Date`,`Comment`) values (2,'Septembre','François MOLESLAS',11,25,275,'2017-10-01 00:00:00',null);
insert into `COACHSPAYMENTS`(`ID`,`Month`,`Coach`,`Lessons`,`Pay`,`Amount`,`Date`,`Comment`) values (3,'Septembre','Etienne GREGOIRE',3,30,90,'2017-10-20 00:00:00',null);




insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (1,'David','GAUTHIER','0119-10-01 00:00:00','blue','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (2,'Raphael','ANI','2017-10-29 00:00:00','blue','M',0,1,'grand qui vient de londres, doute sur son paiement...');
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (3,'Zacharie','ATTALI','2017-10-29 00:00:00','white','M',0,0,'Vient de débuter');
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (4,'Eddy','BARCLAY','2017-10-29 00:00:00','white','M',0,1,'En attente de 2 cheques que j''ai donné à Kelly');
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (6,'Frederique','BARDEY',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (7,'John','BARFF',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (8,'Didier','BARRAUD','2017-10-29 00:00:00','black','M',0,0,'Son fils est aussi inscrit mais on lui a fait cadeau du paiement');
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (9,'Lionel','BENICHOU',null,'white','M',1,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (10,'Sebastien','BIDAULT',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (11,'Farid','BOUHAZEM',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (12,'Julien','BOURGEOIS',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (13,'Gauthier','BRYSBAERT',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (15,'Sacha','BUKASSA','2017-10-29 00:00:00','white','M',1,1,'A demandé le remboursement....');
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (16,'Corentin','CAHEN',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (17,'Sarah','CASSESE',null,'blue','F',1,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (18,'Thomas','CASTAN',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (19,'Pierre','CHAMBON',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (20,'Bagdad','CHECKRI',null,'purple','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (21,'Adrien','CHEMINET',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (22,'Cyril','CHIMKIEVITCH',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (23,'Aime','CONTI',null,'black','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (24,'Ricardo','RIBEIRO',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (25,'Olivier','DAURARIO',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (26,'Christian','DEGUIS',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (27,'Mamadou?','DJOULFAYAN',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (28,'Pierre','DORE',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (29,'Raphael','DOS SANTOS',null,'blue','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (31,'Eric','DRIKES',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (32,'Mickael','FERREIRA',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (33,'Brice','FIGARO',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (34,'Marc antoine','FIGHIERA',null,'blue','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (36,'Florian','FONTRIER',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (37,'Jean Paul','FOURNET',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (38,'Simon','FRANQUET',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (39,'Bayle','GAO',null,'purple','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (42,'jesaispas','GAZAVE',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (43,'Yoann','GOLESTIN',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (44,'Matias','GOURDON',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (45,'Raphael','GRESSIN',null,'white','M',1,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (46,'Jules','GRUBO',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (47,'Olivier','HASSID',null,'white','M',1,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (48,'Dominique','JACQUES',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (49,'Sylvain','JOLIY',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (50,'Nabil','KADID',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (51,'Olivier','KAZ',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (52,'Artyom','KORMESHOV',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (53,'Vincent','LACERENZA',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (54,'Cedric','LE FRANC',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (55,'Jonas','LEBLANC',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (56,'Yohann','LES ENFANT',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (57,'Gregory','LETELLIER',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (58,'Anne','LETESSIER',null,'white','F',1,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (59,'Thomas','MACHADO',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (61,'Charles','MACQUART MOULIN','2017-10-29 00:00:00','white','M',0,0,'Blessé pour le mois de novembre, pb aux cotes');
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (62,'Yann','MALARD',null,'purple','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (63,'Marco','MARZILLI',null,'brown','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (64,'Didier','MAUS',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (65,'Franck','NGUYEN',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (66,'Stephane','NGUYEN','2017-10-29 00:00:00','white','M',0,0,'Veut faire la compet ibjjf je crois, en attente de licence');
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (67,'Nicolas','NZAMBA',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (68,'Noel','ONIZKO',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (69,'Alban','OUAHAB',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (70,'Samuel','PELLET',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (72,'Marc','PELLET',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (73,'Emmanuel','PEREIRA VIEIRA',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (74,'Celine','PERREARD',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (75,'Jeremy','PICOSTE',null,'black','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (76,'Mirjana','POLJAKOVIC',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (77,'François David','PUCHEU LASHORES',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (78,'Vincent','PUYDOYEUX',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (79,'Djamel','SAHRAOUI',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (80,'Mehdi','SAIDI',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (81,'Nelson','SILVA',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (82,'Andrei','STRUTGNSHGG',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (83,'Sylvain','TARIN',null,'purple','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (84,'Vincent','TERRONI',null,'white','M',1,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (85,'Adrien','TIREL',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (86,'Christophe','TROEL',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (87,'Alexis','TRUJILLO',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (88,'Arthur','TSIMI',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (89,'Yohan','VERGNE',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (90,'Guillaume','VIGNE',null,'purple','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (91,'Paul-François','YGORRA',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (92,'Nissim','ZERBIB',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (99,'Neo','ALZIEU',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (100,'Frederique','AMBROISE','2017-10-29 00:00:00','white','M',0,0,'Grand martiniquais, inscrit a 2 disciplines');
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (101,'Jean-Marc','BLOMBOU','2017-10-29 00:00:00','blue','M',0,1,'A repris ses derniers cheques et doit en rendre 2 autres...');
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (102,'Amandine','BOUVAT',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (103,'Manuel','BRUN',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (104,'Aurianne','CHARMET',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (105,'Daniel','CURVAT',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (106,'Jerome','DIVAC',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (107,'Jorge','DO PINHAL',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (108,'Gwenael','HUET',null,'blue','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (109,'Guillaume','LE MAUT',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (110,'Kevin','MALGERARD',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (111,'Joan','MESINELE',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (112,'Moustakim','HASSANI',null,'purple','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (113,'Samuel','OLIVIER',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (114,'David','THOMAS',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (115,'Moussa','TIMERA',null,'white','M',0,0,null);
insert into `MEMBERS`(`ID`,`Firstname`,`Lastname`,`Enddate`,`Belt`,`Gender`,`Child`,`Alert`,`Comment`) values (116,'Alexandre','WALLOIS',null,'white','M',0,0,null);




insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (225,120,'Cash','2017-09-19 00:00:00','Neo ALZIEU',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (236,40,'Cash','2017-09-05 00:00:00','John BARFF',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (261,40,'Cash','2017-09-25 00:00:00','Thomas CASTAN',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (263,120,'Cash','2017-09-05 00:00:00','Bagdad CHECKRI',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (266,250,'Check','2017-10-10 00:00:00','Aime CONTI',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (269,200,'Cash','2017-09-28 00:00:00','Olivier DAURARIO',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (271,500,'Check','2017-10-20 00:00:00','Mamadou? DJOULFAYAN',300,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (273,100,'Cash','2017-09-05 00:00:00','Raphael DOS SANTOS',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (274,80,'Cash','2017-09-14 00:00:00','Eric DRIKES',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (275,80,'Cash','2017-10-16 00:00:00','Eric DRIKES',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (278,80,'Cash','2017-10-05 00:00:00','Brice FIGARO',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (301,500,'Check','2017-10-10 00:00:00','Jules GRUBO',300,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (309,30,'Cash','2017-10-20 00:00:00','Olivier KAZ',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (319,100,'Cash','2017-09-18 00:00:00','Jonas LEBLANC',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (331,500,'Check','2017-10-16 00:00:00','Didier MAUS',300,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (337,40,'Cash','2017-09-14 00:00:00','Noel ONIZKO',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (344,50,'Check','2017-10-16 00:00:00','Marc PELLET',30,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (351,175,'Check','2017-10-16 00:00:00','Jeremy PICOSTE',105,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (354,500,'Check','2017-10-20 00:00:00','Vincent PUYDOYEUX',300,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (360,200,'Cash','2017-09-21 00:00:00','Mehdi SAIDI',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (364,80,'Cash','2017-09-14 00:00:00','Andrei STRUTGNSHGG',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (365,200,'Cash','2017-10-05 00:00:00','Sylvain TARIN',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (369,50,'Cash','2017-10-20 00:00:00','Adrien TIREL',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (374,200,'Cash','2017-09-08 00:00:00','Yohan VERGNE',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (375,100,'Check','2017-10-16 00:00:00','Guillaume VIGNE',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (376,100,'Check','2017-10-16 00:00:00','Guillaume VIGNE',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (377,100,'Check','2017-10-16 00:00:00','Guillaume VIGNE',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (378,100,'Check','2017-10-16 00:00:00','Guillaume VIGNE',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (379,100,'Check','2017-10-16 00:00:00','Guillaume VIGNE',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (407,200,'Check','2017-05-10 00:00:00','Manuel BRUN',120,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (452,140,'Cash','2017-06-01 00:00:00','Guillaume LE MAUT',84,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (453,50,'Cash','2017-06-01 00:00:00','David THOMAS',30,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (454,170,'Cash','2017-09-07 00:00:00','Matias GOURDON',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (455,80,'Cash','2017-07-18 00:00:00','Matias GOURDON',48,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (461,80,'Check','2017-05-10 00:00:00','Aurianne CHARMET',48,1,'2017-05-11 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (465,500,'Check','2017-05-10 00:00:00','Jerome DIVAC',300,1,'2017-05-11 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (466,500,'Check','2017-05-10 00:00:00','Gwenael HUET',300,1,'2017-05-11 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (467,80,'Check','2017-05-10 00:00:00','Kevin MALGERARD',48,1,'2017-05-11 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (468,500,'Check','2017-05-10 00:00:00','Moussa TIMERA',300,1,'2017-05-11 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (477,500,'Check','2017-05-10 00:00:00','Alexandre WALLOIS',300,1,'2017-05-11 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (487,500,'Check','2017-09-12 00:00:00','Gauthier BRYSBAERT',300,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (488,80,'Check','2017-06-01 00:00:00','Gauthier BRYSBAERT',48,1,'2017-06-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (494,250,'Check','2017-06-01 00:00:00','MOUSTAKIM HASSANI',150,1,'2017-06-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (495,210,'Check','2017-06-01 00:00:00','Samuel OLIVIER',126,1,'2017-07-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (496,210,'Check','2017-06-01 00:00:00','Samuel OLIVIER',126,1,'2017-06-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (514,350,'Check','2017-07-11 00:00:00','Daniel CURVAT',210,1,'2017-08-02 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (519,500,'Check','2017-07-18 00:00:00','Jorge DO PINHAL',300,1,'2017-08-02 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (528,100,'Check','2017-09-18 00:00:00','Farid BOUHAZEM',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (529,100,'Check','2017-09-18 00:00:00','Farid BOUHAZEM',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (530,100,'Check','2017-09-18 00:00:00','Farid BOUHAZEM',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (531,100,'Check','2017-09-18 00:00:00','Farid BOUHAZEM',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (532,100,'Check','2017-09-18 00:00:00','Farid BOUHAZEM',60,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (533,55,'Check','2017-05-10 00:00:00','Farid BOUHAZEM',33,1,'2017-09-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (534,55,'Check','2017-05-10 00:00:00','Farid BOUHAZEM',33,1,'2017-08-02 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (535,55,'Check','2017-05-10 00:00:00','Farid BOUHAZEM',33,1,'2017-07-07 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (536,55,'Check','2017-05-10 00:00:00','Farid BOUHAZEM',33,1,'2017-06-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (537,100,'Check','2017-05-10 00:00:00','Amandine BOUVAT',60,1,'2017-05-11 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (538,100,'Check','2017-05-10 00:00:00','Amandine BOUVAT',60,1,'2017-06-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (539,100,'Check','2017-05-10 00:00:00','Amandine BOUVAT',60,1,'2017-07-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (540,100,'Check','2017-05-10 00:00:00','Amandine BOUVAT',60,1,'2017-08-02 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (541,100,'Check','2017-05-10 00:00:00','Amandine BOUVAT',60,1,'2017-09-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (542,100,'Check','2017-05-10 00:00:00','Joan MESINELE',60,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (543,100,'Check','2017-05-10 00:00:00','Joan MESINELE',60,1,'2017-09-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (544,100,'Check','2017-05-10 00:00:00','Joan MESINELE',60,1,'2017-08-02 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (545,100,'Check','2017-05-10 00:00:00','Joan MESINELE',60,1,'2017-07-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (546,100,'Check','2017-05-10 00:00:00','Joan MESINELE',60,1,'2017-06-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (547,100,'Check','2017-09-25 00:00:00','Paul-François YGORRA',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (548,100,'Check','2017-09-25 00:00:00','Paul-François YGORRA',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (549,100,'Check','2017-09-25 00:00:00','Paul-François YGORRA',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (550,100,'Check','2017-09-25 00:00:00','Paul-François YGORRA',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (551,100,'Check','2017-09-25 00:00:00','Paul-François YGORRA',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (552,50,'Check','2017-05-10 00:00:00','Paul-François YGORRA',30,1,'2017-09-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (553,50,'Check','2017-05-10 00:00:00','Paul-François YGORRA',30,1,'2017-06-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (554,60,'Check','2017-05-10 00:00:00','Paul-François YGORRA',36,1,'2017-08-02 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (555,60,'Check','2017-05-10 00:00:00','Paul-François YGORRA',36,1,'2017-07-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (556,100,'Check','2017-09-05 00:00:00','Yim DARINA',60,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (557,100,'Check','2017-09-05 00:00:00','Yim DARINA',60,1,'2017-09-06 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (558,80,'Check','2017-05-10 00:00:00','Yim DARINA',48,1,'2017-05-11 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (559,220,'Check','2017-09-05 00:00:00','Christian DEGUIS',132,1,'2017-09-06 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (560,100,'Check','2017-09-05 00:00:00','Cedric LE FRANC',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (561,100,'Check','2017-09-05 00:00:00','Cedric LE FRANC',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (562,100,'Check','2017-09-05 00:00:00','Cedric LE FRANC',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (563,100,'Check','2017-09-05 00:00:00','Cedric LE FRANC',60,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (564,100,'Check','2017-09-05 00:00:00','Cedric LE FRANC',60,1,'2017-09-06 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (565,500,'Check','2017-09-07 00:00:00','Pierre DORE',300,1,'2017-09-07 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (566,450,'Check','2017-09-07 00:00:00','Yohann LES ENFANT',270,1,'2017-09-07 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (567,80,'Check','2017-09-07 00:00:00','Thomas MACHADO',48,1,'2017-09-07 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (568,210,'Check','2017-10-10 00:00:00','Thomas MACHADO',126,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (569,210,'Check','2017-10-10 00:00:00','Thomas MACHADO',126,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (570,500,'Check','2017-09-07 00:00:00','Franck NGUYEN',300,1,'2017-09-07 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (571,125,'Check','2017-09-12 00:00:00','Marc antoine FIGHIERA',75,1,'2017-09-13 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (572,125,'Check','2017-09-21 00:00:00','Marc antoine FIGHIERA',75,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (573,125,'Check','2017-09-21 00:00:00','Marc antoine FIGHIERA',75,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (574,125,'Check','2017-09-21 00:00:00','Marc antoine FIGHIERA',75,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (575,500,'Check','2017-09-12 00:00:00','Sylvain JOLIY',300,1,'2017-09-13 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (576,150,'Check','2017-09-14 00:00:00','Cyril CHIMKIEVITCH',90,1,'2017-09-15 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (577,700,'Check','2017-09-14 00:00:00','Simon FRANQUET',420,1,'2017-09-15 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (578,80,'Check','2017-07-11 00:00:00','Simon FRANQUET',48,1,'2017-08-02 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (579,200,'Check','2017-09-14 00:00:00','Nelson SILVA',120,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (580,150,'Check','2017-09-14 00:00:00','Nelson SILVA',90,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (581,150,'Check','2017-09-14 00:00:00','Nelson SILVA',90,1,'2017-09-15 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (582,80,'Check','2017-09-14 00:00:00','Celine PERREARD',48,1,'2017-09-15 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (584,100,'Check','2017-09-15 00:00:00','Julien BOURGEOIS',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (585,100,'Check','2017-09-15 00:00:00','Julien BOURGEOIS',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (586,100,'Check','2017-09-15 00:00:00','Julien BOURGEOIS',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (587,100,'Check','2017-09-15 00:00:00','Julien BOURGEOIS',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (588,100,'Check','2017-09-15 00:00:00','Julien BOURGEOIS',60,1,'2017-09-16 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (589,500,'Check','2017-09-15 00:00:00','Florian FONTRIER',300,1,'2017-09-16 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (590,200,'Check','2017-09-18 00:00:00','Yann MALARD',120,1,'2017-09-19 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (591,150,'Check','2017-09-18 00:00:00','Yann MALARD',90,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (592,150,'Check','2017-09-18 00:00:00','Yann MALARD',90,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (593,80,'Check','2017-09-18 00:00:00','Nissim ZERBIB',48,1,'2017-09-19 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (594,420,'Check','2017-10-16 00:00:00','Nissim ZERBIB',252,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (599,50,'Cash','2017-10-02 00:00:00','Frederique BARDEY',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (600,250,'Check','2017-10-02 00:00:00','Frederique BARDEY',150,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (602,100,'Check','2017-09-12 00:00:00','Sebastien BIDAULT',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (603,100,'Check','2017-09-12 00:00:00','Sebastien BIDAULT',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (604,100,'Check','2017-09-12 00:00:00','Sebastien BIDAULT',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (605,100,'Check','2017-09-12 00:00:00','Sebastien BIDAULT',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (606,100,'Check','2017-09-12 00:00:00','Sebastien BIDAULT',60,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (611,500,'Check','2017-09-25 00:00:00','Adrien CHEMINET',300,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (612,365,'Check','2017-09-25 00:00:00','Bayle GAO',219,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (613,365,'Check','2017-10-16 00:00:00','Bayle GAO',219,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (614,250,'Check','2017-09-21 00:00:00','Mickael FERREIRA',150,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (615,250,'Check','2017-09-21 00:00:00','Mickael FERREIRA',150,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (616,250,'Check','2017-09-28 00:00:00','Jean Paul FOURNET',150,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (617,250,'Check','2017-09-28 00:00:00','Jean Paul FOURNET',150,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (622,80,'Check','2017-09-28 00:00:00','jesaispas GAZAVE',48,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (623,100,'Check','2017-09-07 00:00:00','Yoann GOLESTIN',60,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (624,100,'Check','2017-09-07 00:00:00','Yoann GOLESTIN',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (625,100,'Check','2017-09-07 00:00:00','Yoann GOLESTIN',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (626,100,'Check','2017-09-07 00:00:00','Yoann GOLESTIN',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (627,100,'Check','2017-09-07 00:00:00','Yoann GOLESTIN',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (629,500,'Check','2017-09-27 00:00:00','Artyom KORMESHOV',300,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (630,100,'Check','2017-06-08 00:00:00','Artyom KORMESHOV',60,1,'2017-07-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (631,200,'Check','2017-09-25 00:00:00','Vincent LACERENZA',120,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (632,150,'Check','2017-09-25 00:00:00','Vincent LACERENZA',90,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (633,150,'Check','2017-09-25 00:00:00','Vincent LACERENZA',90,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (634,500,'Check','2017-09-27 00:00:00','Gregory LETELLIER',300,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (636,500,'Check','2017-09-19 00:00:00','Marco MARZILLI',300,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (639,200,'Check','2017-09-28 00:00:00','Nicolas NZAMBA',120,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (640,150,'Check','2017-09-28 00:00:00','Nicolas NZAMBA',90,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (641,150,'Check','2017-09-28 00:00:00','Nicolas NZAMBA',90,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (642,125,'Check','2017-09-25 00:00:00','Alban OUAHAB',75,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (643,125,'Check','2017-09-25 00:00:00','Alban OUAHAB',75,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (644,125,'Check','2017-09-25 00:00:00','Alban OUAHAB',75,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (645,125,'Check','2017-09-25 00:00:00','Alban OUAHAB',75,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (646,150,'Check','2017-09-21 00:00:00','Samuel PELLET',90,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (647,100,'Check','2017-09-25 00:00:00','Samuel PELLET',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (648,100,'Check','2017-09-21 00:00:00','Emmanuel PEREIRA VIEIRA',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (649,100,'Check','2017-09-21 00:00:00','Emmanuel PEREIRA VIEIRA',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (650,100,'Check','2017-09-21 00:00:00','Emmanuel PEREIRA VIEIRA',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (651,100,'Check','2017-09-21 00:00:00','Emmanuel PEREIRA VIEIRA',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (652,100,'Check','2017-09-21 00:00:00','Emmanuel PEREIRA VIEIRA',60,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (653,350,'Check','2017-09-25 00:00:00','François David PUCHEU LASHORES',210,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (654,100,'Check','2017-09-25 00:00:00','Djamel SAHRAOUI',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (655,100,'Check','2017-09-25 00:00:00','Djamel SAHRAOUI',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (656,100,'Check','2017-09-25 00:00:00','Djamel SAHRAOUI',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (657,100,'Check','2017-09-25 00:00:00','Djamel SAHRAOUI',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (658,150,'Check','2017-09-25 00:00:00','Djamel SAHRAOUI',110,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (662,250,'Check','2017-09-18 00:00:00','Christophe TROEL',150,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (663,250,'Check','2017-09-18 00:00:00','Christophe TROEL',150,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (664,110,'Check','2017-05-10 00:00:00','Christophe TROEL',66,1,'2017-06-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (665,110,'Check','2017-05-10 00:00:00','Christophe TROEL',66,1,'2017-05-11 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (666,380,'Check','2017-10-02 00:00:00','Alexis TRUJILLO',228,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (667,350,'Check','2017-09-21 00:00:00','Arthur TSIMI',210,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (668,500,'Check','2017-10-05 00:00:00','Corentin CAHEN',300,1,'2017-10-06 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (669,350,'Check','2017-10-05 00:00:00','Pierre CHAMBON',210,1,'2017-10-06 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (671,500,'Check','2017-10-05 00:00:00','Dominique JACQUES',300,1,'2017-10-06 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (672,125,'Check','2017-10-05 00:00:00','Nabil KADID',75,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (673,125,'Check','2017-10-05 00:00:00','Nabil KADID',75,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (674,125,'Check','2017-10-05 00:00:00','Nabil KADID',75,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (675,125,'Check','2017-10-05 00:00:00','Nabil KADID',75,1,'2017-10-06 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (676,1100,'Check','2017-10-05 00:00:00','Mirjana POLJAKOVIC',700,1,'2017-10-06 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (677,125,'Check','2017-09-14 00:00:00','David Gauthier',75,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (678,125,'Check','2017-09-14 00:00:00','David Gauthier',75,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (679,125,'Check','2017-09-14 00:00:00','David Gauthier',75,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (680,125,'Check','2017-09-14 00:00:00','David Gauthier',75,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (682,280,'Check','2017-09-25 00:00:00','Sarah CASSESE',168,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (683,280,'Check','2017-09-28 00:00:00','Lionel BENICHOU',168,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (684,280,'Check','2017-10-05 00:00:00','Raphael GRESSIN',168,1,'2017-10-06 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (685,280,'Check','2017-09-21 00:00:00','Olivier HASSID',168,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (687,100,'Check','2017-09-21 00:00:00','Vincent TERRONI',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (688,100,'Check','2017-09-21 00:00:00','Vincent TERRONI',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (689,80,'Check','2017-09-21 00:00:00','Vincent TERRONI',48,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (703,280,'Check','2017-09-18 00:00:00','Anne LETESSIER',168,1,'2017-09-19 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (705,350,'Check','2017-06-28 00:00:00','Frederique AMBROISE',210,1,'2017-07-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (707,250,'Check','2017-10-17 00:00:00','Zacharie ATTALI',150,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (708,250,'Check','2017-10-17 00:00:00','Zacharie ATTALI',150,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (712,500,'Check','2017-09-15 00:00:00','Didier BARRAUD',300,1,'2017-09-16 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (718,200,'Check','2017-09-18 00:00:00','Eddy BARCLAY',120,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (719,150,'Check','2017-09-18 00:00:00','Eddy BARCLAY',90,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (720,150,'Check','2017-09-18 00:00:00','Eddy BARCLAY',90,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (723,40,'Cash','2017-09-05 00:00:00','Raphael ANI',0,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (724,100,'Check','2017-06-08 00:00:00','Jean-Marc BLOMBOU',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (725,100,'Check','2017-06-08 00:00:00','Jean-Marc BLOMBOU',60,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (726,100,'Check','2017-06-08 00:00:00','Jean-Marc BLOMBOU',60,1,'2017-09-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (727,100,'Check','2017-06-08 00:00:00','Jean-Marc BLOMBOU',60,1,'2017-08-02 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (728,100,'Check','2017-06-08 00:00:00','Jean-Marc BLOMBOU',60,1,'2017-07-05 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (729,56,'Check','2017-09-14 00:00:00','Fabrice BUKASSA',34,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (730,56,'Check','2017-09-14 00:00:00','Fabrice BUKASSA',34,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (731,58,'Check','2017-09-14 00:00:00','Fabrice BUKASSA',35,0,'2017-10-26 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (732,50,'Cash','2017-09-14 00:00:00','Fabrice BUKASSA',0,0,'2017-10-27 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (733,500,'Check','2017-09-28 00:00:00','Charles MACQUART MOULIN',300,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (734,100,'Check','2017-09-28 00:00:00','Stephane NGUYEN',60,1,'2017-10-04 00:00:00');
insert into `PAYMENTS`(`ID`,`Amount`,`Type`,`ReceptionDate`,`Name`,`Debt`,`DepotBank`,`DepotDate`) values (735,500,'Check','2017-07-11 00:00:00','Stephane NGUYEN',300,1,'2017-08-02 00:00:00');




insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (99,225);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (7,236);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (18,261);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (20,263);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (23,266);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (25,269);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (27,271);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (29,273);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (31,274);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (31,275);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (33,278);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (46,301);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (51,309);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (55,319);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (64,331);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (68,337);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (72,344);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (75,351);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (78,354);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (80,360);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (82,364);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (83,365);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (85,369);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (89,374);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (90,375);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (90,376);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (90,377);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (90,378);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (90,379);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (103,407);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (109,452);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (114,453);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (44,454);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (44,455);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (104,461);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (106,465);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (108,466);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (110,467);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (115,468);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (116,477);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (13,487);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (13,488);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (112,494);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (113,495);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (113,496);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (105,514);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (107,519);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (11,528);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (11,529);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (11,530);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (11,531);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (11,532);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (11,533);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (11,534);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (11,535);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (11,536);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (102,537);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (102,538);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (102,539);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (102,540);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (102,541);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (111,542);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (111,543);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (111,544);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (111,545);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (111,546);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (91,547);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (91,548);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (91,549);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (91,550);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (91,551);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (91,552);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (91,553);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (91,554);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (91,555);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (24,556);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (24,557);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (24,558);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (26,559);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (54,560);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (54,561);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (54,562);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (54,563);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (54,564);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (28,565);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (56,566);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (59,567);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (59,568);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (59,569);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (65,570);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (34,571);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (34,572);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (34,573);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (34,574);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (49,575);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (22,576);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (38,577);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (38,578);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (81,579);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (81,580);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (81,581);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (74,582);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (12,584);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (12,585);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (12,586);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (12,587);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (12,588);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (36,589);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (62,590);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (62,591);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (62,592);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (92,593);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (92,594);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (6,599);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (6,600);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (10,602);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (10,603);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (10,604);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (10,605);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (10,606);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (21,611);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (39,612);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (39,613);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (32,614);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (32,615);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (37,616);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (37,617);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (42,622);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (43,623);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (43,624);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (43,625);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (43,626);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (43,627);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (52,629);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (52,630);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (53,631);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (53,632);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (53,633);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (57,634);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (63,636);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (67,639);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (67,640);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (67,641);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (69,642);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (69,643);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (69,644);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (69,645);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (70,646);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (70,647);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (73,648);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (73,649);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (73,650);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (73,651);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (73,652);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (77,653);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (79,654);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (79,655);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (79,656);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (79,657);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (79,658);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (86,662);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (86,663);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (86,664);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (86,665);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (87,666);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (88,667);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (16,668);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (19,669);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (48,671);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (50,672);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (50,673);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (50,674);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (50,675);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (76,676);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (1,677);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (1,678);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (1,679);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (1,680);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (17,682);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (9,683);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (45,684);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (47,685);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (84,687);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (84,688);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (84,689);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (58,703);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (100,705);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (3,707);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (3,708);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (8,712);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (4,718);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (4,719);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (4,720);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (2,723);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (101,724);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (101,725);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (101,726);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (101,727);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (101,728);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (15,729);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (15,730);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (15,731);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (15,732);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (61,733);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (66,734);
insert into `MEMBERS_PAYMENTS`(`MemberID`,`PaymentID`) values (66,735);


