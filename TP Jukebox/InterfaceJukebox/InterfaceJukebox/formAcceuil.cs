#region "Imports"
using System;
using System.Windows.Forms;
#endregion

namespace InterfaceJukebox
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        #region "Evénements"

        private void btnmenucd_Click(object sender, EventArgs e)
        {
            FormCD menuCD = new FormCD();
            menuCD.Show();
            this.Hide();
        }

        private void btnmenudvd_Click(object sender, EventArgs e)
        {
            formDVD menuDVD = new formDVD();
            menuDVD.Show();
            this.Hide();
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
    }
}
