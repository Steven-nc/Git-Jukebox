#region "Imports"
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ClassJukeox
{   
    class Biblio
    {
        #region "Propriété, Constructeur, Accesseur de MesSupports"
        private List<Support> mesSupports;

        public Biblio()
        { mesSupports = new List<Support> { }; }

        public List<Support> MesSupports
        {
            get
            {
                return mesSupports;
            }

            set
            {
                mesSupports = value;
            }
        }
    }
#endregion   
}