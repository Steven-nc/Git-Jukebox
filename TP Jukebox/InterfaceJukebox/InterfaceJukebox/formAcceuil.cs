#region "Imports"
using System;
using System.Drawing;
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

        private void Acceuil_Load(object sender, EventArgs e)
        {
            picture.Image = Image.FromFile("C:/Users/steve/Documents/Visual Studio 2015/Projects/TP Jukebox/InterfaceJukebox/InterfaceJukebox/bin/Image/image.jpg");
            picture1.Image = Image.FromFile("C:/Users/steve/Documents/Visual Studio 2015/Projects/TP Jukebox/InterfaceJukebox/InterfaceJukebox/bin/Image/image1.jpg");
            picture2.Image = Image.FromFile("C:/Users/steve/Documents/Visual Studio 2015/Projects/TP Jukebox/InterfaceJukebox/InterfaceJukebox/bin/Image/image2.jpg");
            picture3.Image = Image.FromFile("C:/Users/steve/Documents/Visual Studio 2015/Projects/TP Jukebox/InterfaceJukebox/InterfaceJukebox/bin/Image/image3.jpg");
            //this.BackColor = Color.Gold;

        }
    }
}


