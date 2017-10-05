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

        #region "OnClick CD, DVD, ADHERENT, EMPRUNT"

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

        private void btnAdh_Click(object sender, EventArgs e)
        {
            formAdh menuAdh = new formAdh();
            menuAdh.Show();
            this.Hide();
        }

        private void btnEmprunt_Click(object sender, EventArgs e)
        {
            formEmprunt menuEmprunt = new formEmprunt();
            menuEmprunt.Show();
            this.Hide();
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

    }
}


