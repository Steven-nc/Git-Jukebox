using System;

namespace ClassJukeox
{
    public class Adherent
    {
        /*https://www.epi.asso.fr/revue/articles/a0509b.htm
        CREATE DEFINER=`root`@`localhost` EVENT `maj` ON SCHEDULE EVERY 1 DAY STARTS '2017-09-20 00:00:00' ON COMPLETION NOT PRESERVE ENABLE DO UPDATE jukebox.ficheemprunt SET depasse = 1 WHERE dateLimite<NOW();
        SET GLOBAL event_scheduler="ON";
        Pour que l'évènement fonctionne, il faut modifié l'état du plannificateur d'évènements à "Activé" par défaut dans
        le fichier my.ini de wamp (event_scheduler=on)*/

        private string nom;
        private string prenom;
        private string adressemail;
        private DateTime dateInscription;
        private int nbEmprunts;
        private int nbEmpruntsDepasses;
        private int nbEmpruntsEnCours;

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Adressemail
        {
            get
            {
                return adressemail;
            }

            set
            {
                adressemail = value;
            }
        }

        public DateTime DateInscription
        {
            get
            {
                return dateInscription;
            }

            set
            {
                dateInscription = value;
            }
        }

        public int NbEmprunts
        {
            get
            {
                return nbEmprunts;
            }

            set
            {
                nbEmprunts = value;
            }
        }

        public int NbEmpruntsDepasses
        {
            get
            {
                return nbEmpruntsDepasses;
            }

            set
            {
                nbEmpruntsDepasses = value;
            }
        }

        public int NbEmpruntsEnCours
        {
            get
            {
                return nbEmpruntsEnCours;
            }
            
            set
            {
                nbEmpruntsEnCours = value;
            }
        }

        public Adherent(string nom, string prenom, string mail, DateTime dateInscript, int nbE, int nbD, int nbEEC)
        {
            this.nom = nom;
            this.prenom = prenom;
            adressemail = mail;
            dateInscription = dateInscript;
            nbEmprunts = nbE;
            nbEmpruntsDepasses = nbD;
            nbEmpruntsEnCours = nbEEC;
        }

        public Adherent afficher(Adherent unAdherent)
        {
            return unAdherent;
        }
    }
}
