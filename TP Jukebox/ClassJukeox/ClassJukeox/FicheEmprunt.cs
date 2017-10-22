using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJukeox
{
    public class FicheEmprunt
    {

        private int idSupport;
        private int idAdherent;
        private DateTime dateEmprunt;
        private DateTime dateLimite;
        private bool depasse;

        public int IdSupport
        {
            get
            {
                return idSupport;
            }

            set
            {
                idSupport = value;
            }
        }

        public int IdAdherent
        {
            get
            {
                return idAdherent;
            }

            set
            {
                idAdherent = value;
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

        public FicheEmprunt(int idSupport, int idAdherent, DateTime dateEmprunt, DateTime dateLimite, bool depasse)
        {
            this.idSupport = idSupport;
            this.idAdherent = idAdherent;
            this.dateEmprunt = dateEmprunt;
            this.dateLimite = dateLimite;
            this.depasse = depasse;
        }
    }
}
