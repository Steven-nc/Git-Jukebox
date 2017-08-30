#region "Imports"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ClassJukeox
{
    public class DVD : Support
    {
        #region "Propriété et constructeur DVD"
        private string metteurenscene;

        public DVD(string titre, int duree, bool enStock, string commentaire, string metteurenscene) : base(titre, duree, enStock, commentaire)
        {
            this.Metteurenscene = metteurenscene;
        }
        #endregion

        #region "Accesseurs DVD"
        public string Metteurenscene
        {
            get
            {
                return metteurenscene;
            }

            set
            {
                metteurenscene = value;
            }
        }

        public DVD afficher(DVD unDVD)
        {
            return unDVD;
        }
        #endregion
    }
}
