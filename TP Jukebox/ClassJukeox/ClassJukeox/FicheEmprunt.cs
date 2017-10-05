using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJukeox
{
    public class FicheEmprunt
    {

        private Support unSupport;
        private Adherent unAdherent;
        private DateTime dateEmprunt;
        private DateTime dateLimite;
        private bool depasse;

        public FicheEmprunt(Support unSupport, Adherent unAdherent, DateTime dateEmprunt, DateTime dateLimite, bool depasse)
        {
            this.unSupport = unSupport;
            this.unAdherent = unAdherent;
            this.dateEmprunt = dateEmprunt;
            this.dateLimite = dateLimite;
            this.depasse = depasse;
        }

        public Support UnSupport
        {
            get
            {
                return unSupport;
            }

            set
            {
                unSupport = value;
            }
        }

        public Adherent UnAdherent
        {
            get
            {
                return unAdherent;
            }

            set
            {
                unAdherent = value;
            }
        }

        public DateTime DateEmprunt
        {
            get
            {
                return dateEmprunt;
            }

            set
            {
                dateEmprunt = value;
            }
        }

        public DateTime DateLimite
        {
            get
            {
                return dateLimite;
            }

            set
            {
                dateLimite = value;
            }
        }

        public bool Depasse
        {
            get
            {
                return depasse;
            }

            set
            {
                depasse = value;
            }
        }
    }
}
