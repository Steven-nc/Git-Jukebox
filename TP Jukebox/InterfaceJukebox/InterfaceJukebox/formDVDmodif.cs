#region "Imports" 
using ClassJukeox;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
#endregion

namespace InterfaceJukebox
{
    public partial class formDVDmodif : Form
    {
        public formDVDmodif()
        {
            InitializeComponent();
        }

        //méthode pour récupérer le DVD à modifier
        public DVD MonDVD { get; set; }

        //Même chose que les CDs en adaptant les propriétés pour des DVD
        #region "Evénements"
        private void formDVDmodif_Load(object sender, EventArgs e)
        {
            try
            {
                textTitreDVD.Text = MonDVD.Titre;
                textDureeDVD.Text = MonDVD.Duree.ToString();
                if (MonDVD.EnStock == true)
                {
                    checkStockDVD.Checked = true;
                }
                else
                {
                    checkStockDVD.Checked = false;
                }
                textCommentaireDVD.Text = MonDVD.Commentaire;
                textMetteur.Text = MonDVD.Metteurenscene;
            }
            catch (Exception ex)
            {
                textUtil.Text = "Une erreur s'est produite pendant le chargement de la fenêtre ! " + ex.Message;
            }
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            Boolean enstock;
            try
            {

                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();
                MySqlCommand cmd = new MySqlCommand("select id from dvd WHERE titre = @titre and duree= @duree and metteurenscene=@metteurenscene and commentaire= @commentaire;", bdd.GetConnection());
                cmd.Parameters.AddWithValue("@titre", MonDVD.Titre);
                cmd.Parameters.AddWithValue("@duree", MonDVD.Duree);
                cmd.Parameters.AddWithValue("@metteurenscene", MonDVD.Metteurenscene);
                cmd.Parameters.AddWithValue("@commentaire", MonDVD.Commentaire);

                int id = Convert.ToInt32(cmd.ExecuteScalar());
                string titre = textTitreDVD.Text;
                string maduree = textDureeDVD.Text;
                int duree = Convert.ToInt32(maduree);
                enstock = checkStockDVD.Checked;
                string metteurenscene = textMetteur.Text;
                string commentaire = textCommentaireDVD.Text;
                DVD leDVD= new DVD(titre, duree, enstock, commentaire, metteurenscene);
                bdd.UpdateDVD(leDVD, id);
                textUtil.Text = "Le DVD a été modifié.";

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch (Exception ex)
            {
                textUtil.Text = "Une erreur s'est produite lors de la modification du DVD ! " + ex.Message;
            }
        }
                
        private void btnretour_Click(object sender, EventArgs e)
        {
            formDVD menuDVD = new formDVD();
            menuDVD.Show();
            this.Close();
        }
        #endregion
    }
}
