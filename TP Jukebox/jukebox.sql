-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 05 Octobre 2017 à 02:22
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
  `dateI` datetime NOT NULL,
  `nbEmprunts` int(11) DEFAULT '0',
  `nbEmpruntsDepasses` int(11) DEFAULT '0',
  `nbEmpruntsEnCours` int(11) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `adherent`
--

INSERT INTO `adherent` (`id`, `nom`, `prenom`, `adressemail`, `dateI`, `nbEmprunts`, `nbEmpruntsDepasses`, `nbEmpruntsEnCours`) VALUES
(1, 'OBRY ', 'Ilona', 'obry.ilona@gmail.com', '2017-09-15 00:00:00', 3, 0, 0),
(2, 'TONG', 'Benoit', 'yanapas', '2017-09-15 00:00:00', 0, 0, 0),
(3, 'NGUYEN', 'Ilona', 'mail', '2017-09-15 00:00:00', 0, 0, 0),
(4, 'VIVANCOS', 'Thomas', 'ouioui', '2017-09-15 00:00:00', 0, 0, 0);

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
(1, 'Evolve', 40, 1, 'Imagine Dragons', 15, 3000, 'Excellent ! ');

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
(2, 'Jack et la mécanique du coeur ', 94, 0, 'Mathias Malzieu', 'Bien '),
(20, 'Cloud atlas ', 172, 1, 'Tom Tykwer', 'Wow ');

-- --------------------------------------------------------

--
-- Structure de la table `ficheemprunt`
--

CREATE TABLE IF NOT EXISTS `ficheemprunt` (
  `id` int(255) NOT NULL,
  `idsupport` int(255) NOT NULL,
  `idadherent` int(255) NOT NULL,
  `dateEmprunt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `dateLimite` timestamp NOT NULL,
  `depasse` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `ficheemprunt`
--

INSERT INTO `ficheemprunt` (`id`, `idsupport`, `idadherent`, `dateEmprunt`, `dateLimite`, `depasse`) VALUES
(1, 2, 2, '2017-09-20 22:51:48', '2017-09-27 22:51:48', 1),
(2, 1, 1, '2017-10-02 02:48:50', '2017-10-09 02:48:50', 0);

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
(20);

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
CREATE DEFINER=`root`@`localhost` EVENT `maj` ON SCHEDULE EVERY 1 DAY STARTS '2017-09-20 00:00:00' ON COMPLETION NOT PRESERVE ENABLE DO UPDATE jukebox.ficheemprunt 
   SET depasse = 1
   WHERE dateLimite < NOW()$$

DELIMITER ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
