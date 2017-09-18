using System;
using System.Windows.Forms;
using ClassJukeox;
using MySql.Data.MySqlClient;

namespace InterfaceJukebox
{
    public partial class formAdhModif : Form
    {
        public formAdhModif()
        {
            InitializeComponent();
        }

        public Adherent MonAdherent { get; set; }

        private void formAdhModif_Load(object sender, EventArgs e)
        {
            try
            {
                //Au chargement du formulaire, on initialise les données du CD récupéré
                txtNom.Text = MonAdherent.Nom;
                txtPrenom.Text = MonAdherent.Prenom;
                txtAdressemail.Text = MonAdherent.Adressemail;
                lbldateins.Text = MonAdherent.DateInscription.ToShortDateString();
                lblnbe.Text = MonAdherent.NbEmprunts.ToString();
                lblnbed.Text = MonAdherent.NbEmpruntsDepasses.ToString();
                lblnbeec.Text = MonAdherent.NbEmpruntsEnCours.ToString();
            }
            catch (Exception ex)
            {
                lblnotif.Text = "Une erreur s'est produite pendant le chargement de la fenêtre ! " + ex.Message;
            }
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            try
            {

                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();

                //Je récupère l'id du CD récupéré 
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
                int nbED = Convert.ToInt32(lblnbed.Text);
                int nbEEC = Convert.ToInt32(lblnbeec.Text);

                Adherent leAdherent = new Adherent(nom, prenom, adressemail, dateins, nbE, nbED, nbEEC);

                //Méthode pour modifié le CD récupéré en l'identifiant avec son id 
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

        private void btnretour_Click(object sender, EventArgs e)
        {
            formAdh menuAdh = new formAdh();
            menuAdh.Show();
            this.Close();
        }
    }
}
