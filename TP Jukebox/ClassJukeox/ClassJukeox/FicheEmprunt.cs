using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJukeox
{
    public class FicheEmprunt
    {
        private DateTime DateEmprunt;
        private DateTime DateLimite;
        private bool depasse;


        public FicheEmprunt(DateTime DateE, DateTime DateL, bool depasse)
        {
            DateEmprunt = DateE;
            DateLimite = DateL;
            this.depasse = depasse;
        }

        public DateTime getDateEmprunt
        {
            get
            {
                return DateEmprunt;
            }

            set
            {
                DateEmprunt = value;
            }
        }

        public DateTime getDateLimite
        {
            get
            {
                return DateLimite;
            }

            set
            {
                DateLimite = value;
            }
        }

        public bool getDepasse
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
