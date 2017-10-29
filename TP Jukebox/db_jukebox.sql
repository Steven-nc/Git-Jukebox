-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Dim 22 Octobre 2017 à 09:41
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `jukebox`
--

-- --------------------------------------------------------

--
-- Structure de la table `adherent`
--

CREATE TABLE IF NOT EXISTS `adherent` (
  `id` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `adressemail` varchar(200) NOT NULL,
  `dateI` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `nbEmprunts` int(11) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `adherent`
--

INSERT INTO `adherent` (`id`, `nom`, `prenom`, `adressemail`, `dateI`, `nbEmprunts`) VALUES
(1, 'OBRY ', 'Ilona', 'obry.ilona@gmail.com', '2017-09-14 13:00:00', 5),
(4, 'VIVANCOS', 'Thomas', 'ouioui', '2017-09-14 13:00:00', 0),
(5, 'NGUYEN', 'Steven', 'oui@gmal.com', '2017-10-09 13:00:00', 0);

-- --------------------------------------------------------

--
-- Structure de la table `cd`
--

CREATE TABLE IF NOT EXISTS `cd` (
  `id` int(11) NOT NULL,
  `titre` varchar(100) NOT NULL,
  `duree` int(11) NOT NULL,
  `enstock` tinyint(1) NOT NULL,
  `artiste` varchar(100) NOT NULL,
  `nbpiste` int(11) NOT NULL,
  `prix` int(11) NOT NULL,
  `commentaire` varchar(535) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `cd`
--

INSERT INTO `cd` (`id`, `titre`, `duree`, `enstock`, `artiste`, `nbpiste`, `prix`, `commentaire`) VALUES
(1, 'drfg', 4052, 1, '"''ytrte', 15, 6666, 'oui'),
(11, 'Evolvertyh', 999, 1, 'Moidftgf', 5, 555, 'nnser');

-- --------------------------------------------------------

--
-- Structure de la table `dvd`
--

CREATE TABLE IF NOT EXISTS `dvd` (
  `id` int(11) NOT NULL,
  `titre` varchar(100) NOT NULL,
  `duree` int(11) NOT NULL,
  `enstock` tinyint(1) NOT NULL,
  `metteurenscene` varchar(100) NOT NULL,
  `commentaire` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `dvd`
--

INSERT INTO `dvd` (`id`, `titre`, `duree`, `enstock`, `metteurenscene`, `commentaire`) VALUES
(2, 'ertyu', 94, 1, 'Mathias Malzieu', 'Bien ezrt'),
(20, 'oui oui', 180, 1, 'Tom Tykwerrt', 'Wow ret'),
(21, '1', 1, 1, '1', '1');

-- --------------------------------------------------------

--
-- Structure de la table `ficheemprunt`
--

CREATE TABLE IF NOT EXISTS `ficheemprunt` (
  `id` int(255) NOT NULL,
  `idsupport` int(255) NOT NULL,
  `idadherent` int(255) NOT NULL,
  `dateEmprunt` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `dateLimite` timestamp NULL DEFAULT NULL,
  `depasse` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déclencheurs `ficheemprunt`
--
DROP TRIGGER IF EXISTS `date_limite`;
DELIMITER //
CREATE TRIGGER `date_limite` BEFORE INSERT ON `ficheemprunt`
 FOR EACH ROW begin 
set new.dateLimite = date_add(new.dateEmprunt, INTERVAL 7 DAY);
end
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `support`
--

CREATE TABLE IF NOT EXISTS `support` (
  `id` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `support`
--

INSERT INTO `support` (`id`) VALUES
(1),
(2),
(11),
(20),
(21);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `cd`
--
ALTER TABLE `cd`
  ADD CONSTRAINT `cd_ibfk_1` FOREIGN KEY (`id`) REFERENCES `support` (`id`);

--
-- Contraintes pour la table `dvd`
--
ALTER TABLE `dvd`
  ADD CONSTRAINT `dvd_ibfk_1` FOREIGN KEY (`id`) REFERENCES `support` (`id`);

DELIMITER $$
--
-- Événements
--
CREATE DEFINER=`root`@`localhost` EVENT `maj` ON SCHEDULE EVERY 1 MINUTE STARTS '2017-09-20 00:00:00' ON COMPLETION NOT PRESERVE ENABLE DO UPDATE jukebox.ficheemprunt 
   SET depasse = 1
   WHERE dateLimite < NOW()$$

DELIMITER ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
