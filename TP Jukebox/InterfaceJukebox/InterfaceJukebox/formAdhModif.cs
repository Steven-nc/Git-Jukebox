using System;
using System.Windows.Forms;
using ClassJukeox;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace InterfaceJukebox
{
    public partial class formAdhModif : Form
    {
        public formAdhModif()
        {
            InitializeComponent();
        }

        //Méthode pour récupérer l'adhérent à modifier
        public Adherent MonAdherent { get; set; }

        //Initialisation du formulaire avec les données de l'adhérent
        private void formAdhModif_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            try
            {
                //Au chargement du formulaire, on initialise les données du CD récupéré
                txtNom.Text = MonAdherent.Nom;
                txtPrenom.Text = MonAdherent.Prenom;
                txtAdressemail.Text = MonAdherent.Adressemail;
                lbldateins.Text = MonAdherent.DateInscription.ToShortDateString();
                lblnbe.Text = MonAdherent.NbEmprunts.ToString();
            }
            catch (Exception ex)
            {
                lblnotif.Text = "Une erreur s'est produite pendant le chargement de la fenêtre ! " + ex.Message;
            }
        }

        //Bouton VALIDER, met à jour les informations entrées
        private void btnvalider_Click(object sender, EventArgs e)
        {
            try
            {

                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();

                //Je récupère l'id de l'adhérent récupéré 
                MySqlCommand cmd = new MySqlCommand("SELECT id FROM ADHERENT WHERE nom = @nom and prenom=@prenom and adressemail=@adressemail;", bdd.GetConnection());
                cmd.Parameters.AddWithValue("@nom", MonAdherent.Nom);
                cmd.Parameters.AddWithValue("@prenom", MonAdherent.Prenom);
                cmd.Parameters.AddWithValue("@adressemail", MonAdherent.Adressemail);

                //Récupère les données modifiées ou non
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                string adressemail = txtAdressemail.Text;
                DateTime dateins = Convert.ToDateTime(lbldateins.Text);
                int nbE = Convert.ToInt32(lblnbe.Text);

                Adherent leAdherent = new Adherent(nom, prenom, adressemail, dateins, nbE);

                //Méthode pour modifié l'adhérent récupéré en l'identifiant avec son id 
                bdd.updateAdh(leAdherent, id);
                lblnotif.Text = "Les informations de l'adhérent ont été modifié.";

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch (Exception ex)
            {
                lblnotif.Text = "Une erreur s'est produite lors de la modification des informations de l'adhérent ! " + ex.Message;
            }
        }

        //Bouton RETOUR
        private void btnretour_Click(object sender, EventArgs e)
        {
            formAdh menuAdh = new formAdh();
            menuAdh.Show();
            this.Close();
        }
    }
}
