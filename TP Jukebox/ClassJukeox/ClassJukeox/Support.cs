#region "Imports"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ClassJukeox
{
    public class Support
    {
        #region "Propriétés et constructeur Support"
        protected string titre;
        protected int duree;
        protected bool enStock;
        protected string commentaire;

        public Support(string titre, int duree, bool enStock, string commentaire)
        {
            this.Titre = titre;
            this.Duree = duree;
            this.EnStock = enStock;
            this.Commentaire = commentaire;
        }
        #endregion

        #region "Accesseurs Support"
        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public int Duree
        {
            get
            {
                return duree;
            }

            set
            {
                duree = value;
            }
        }

        public bool EnStock
        {
            get
            {
                return enStock;
            }

            set
            {
                enStock = value;
            }
        }

        public string Commentaire
        {
            get
            {
                return commentaire;
            }

            set
            {
                commentaire = value;
            }
        }

        public Support afficher(Support unSupport)
        {
            if (this.EnStock == true)
            {
                return unSupport;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
