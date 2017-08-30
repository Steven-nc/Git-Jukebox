#region "Imports"
using System;
using System.Windows.Forms;
using ClassJukeox;
using MySql.Data.MySqlClient;
#endregion

namespace InterfaceJukebox
{
    public partial class formCDmodif : Form
    {
        public formCDmodif()
        {
            InitializeComponent();
        }

        //récup du CD à modifier
        public CD MonCD { get; set; }

        #region "Evénements"

        private void formCDmodif_Load(object sender, EventArgs e)
        {
            try
            {
                //Au chargement du formulaire, on initialise les données du CD récupéré
                textTitreCD.Text = MonCD.Titre;
                textDureeCD.Text = MonCD.Duree.ToString();
                if (MonCD.EnStock == true)
                {
                    checkStockCD.Checked = true;
                }
                else
                {
                    checkStockCD.Checked = false;
                }
                textCommentaireCD.Text = MonCD.Commentaire;
                textArtisteCD.Text = MonCD.Artiste;
                textNombredepistesCD.Text = MonCD.Nombredepistes.ToString();
                textPrixCD.Text = MonCD.Prix.ToString();
            }
            catch (Exception ex)
            {
                textUtil.Text = "Une erreur s'est produite pendant le chargement de la fenêtre ! " + ex.Message;
            }

        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            try
            {

                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();

                //Je récupère l'id du CD récupéré 
                MySqlCommand cmd = new MySqlCommand("select id from cd WHERE titre = @titre and duree= @duree and artiste= @artiste and nbpiste=@nbpiste and prix=@prix and commentaire= @commentaire;", bdd.GetConnection());
                cmd.Parameters.AddWithValue("@titre", MonCD.Titre);
                cmd.Parameters.AddWithValue("@duree", MonCD.Duree);
                cmd.Parameters.AddWithValue("@artiste", MonCD.Artiste);
                cmd.Parameters.AddWithValue("@nbpiste", MonCD.Nombredepistes);
                cmd.Parameters.AddWithValue("@prix", MonCD.Prix);
                cmd.Parameters.AddWithValue("@commentaire", MonCD.Commentaire);

                //Récupère les données modifiées ou non
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                string titre = textTitreCD.Text;
                string maduree = textDureeCD.Text;
                int duree = Convert.ToInt32(maduree);
                Boolean enstock = checkStockCD.Checked;
                string artiste = textArtisteCD.Text;
                string monnbpistes = textNombredepistesCD.Text;
                int nbpistes = Convert.ToInt32(monnbpistes);
                string monprix = textPrixCD.Text;
                int prix = Convert.ToInt32(monprix);
                string commentaire = textCommentaireCD.Text;

                //Création du nouveau CD qui va remplacer l'ancien 
                CD leCD = new CD(titre, duree, enstock, commentaire, artiste, nbpistes, prix);

                //Méthode pour modifié le CD récupéré en l'identifiant avec son id 
                bdd.UpdateCD(leCD, id);
                textUtil.Text = "Le CD a été modifié.";

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch (Exception ex)
            {
                textUtil.Text = "Une erreur s'est produite lors de la modification du CD ! " + ex.Message;
            }
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            FormCD menuCD = new FormCD();
            menuCD.Show();
            this.Close();

        }
        #endregion
    }
}
