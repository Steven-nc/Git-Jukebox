using ClassJukeox;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceJukebox
{
    public partial class formEmprunt : Form
    {
        public formEmprunt()
        {
            InitializeComponent();
        }
        
        //Chargement du tableau avec les données de la table ficheemprunt
        private void formEmprunt_Load(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();

            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(@"select ficheemprunt.id, dvd.titre, CONCAT(adherent.nom, ' ', adherent.prenom) as adherent, ficheemprunt.dateEmprunt, ficheemprunt.dateLimite
                                                                           from dvd, ficheemprunt, adherent
                                                                           where ficheemprunt.idsupport = dvd.id
                                                                           and ficheemprunt.idadherent = adherent.id
                                                                           union
                                                                           select ficheemprunt.id, cd.titre, CONCAT(adherent.nom, ' ', adherent.prenom) as adherent, ficheemprunt.dateEmprunt, ficheemprunt.dateLimite
                                                                           from cd, ficheemprunt, adherent
                                                                           where ficheemprunt.idsupport = cd.id
                                                                           and ficheemprunt.idadherent = adherent.id", bdd.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvEmprunt.DataSource = DS.Tables[0];
                dgvEmprunt.Columns["id"].HeaderText = "ID";
                dgvEmprunt.Columns["titre"].HeaderText = "Titre";
                dgvEmprunt.Columns["adherent"].HeaderText = "Emprunté par";
                dgvEmprunt.Columns["dateEmprunt"].HeaderText = "Emprunté le";
                dgvEmprunt.Columns["dateLimite"].HeaderText = "A rendre avant le";
                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch
            {
                // Gestion des erreurs :

            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            formAjoutEmprunt menuAjout = new formAjoutEmprunt();
            menuAjout.Show();
            this.Hide();
        }
    }
    //EN COURS
}

