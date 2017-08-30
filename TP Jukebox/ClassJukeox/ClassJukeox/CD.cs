#region "Imports"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ClassJukeox
{
    public class CD : Support
    {
        #region "Propiétés et constructeur CD"
        private string artiste;
        private int nombredepistes;
        private int prix;

        public CD(string titre, int duree, bool enStock, string commentaire, string artiste, int nombredepistes, int prix) : base(titre, duree, enStock, commentaire)
        {
            this.Artiste = artiste;
            this.Nombredepistes = nombredepistes;
            this.Prix = prix;
        }
        #endregion

        #region "Accesseurs CD"
        public string Artiste
        {
            get
            {
                return artiste;
            }

            set
            {
                artiste = value;
            }
        }

        public int Nombredepistes
        {
            get
            {
                return nombredepistes;
            }

            set
            {
                nombredepistes = value;
            }
        }

        public int Prix
        {
            get
            {
                return prix;
            }

            set
            {
                prix = value;
            }
        }

        public CD afficher(CD unCD)
        {
            return unCD;
        }
        #endregion
    }
}
