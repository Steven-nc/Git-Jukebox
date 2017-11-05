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
                dgvEmprunt.BackgroundColor = System.Drawing.SystemColors.Control;
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(@"select ficheemprunt.id, dvd.titre, CONCAT(adherent.nom, ' ', adherent.prenom) as adherent, ficheemprunt.dateEmprunt, ficheemprunt.dateLimite, ficheemprunt.depasse
                                                                           from dvd, ficheemprunt, adherent
                                                                           where ficheemprunt.idsupport = dvd.id
                                                                           and ficheemprunt.idadherent = adherent.id
                                                                           union
                                                                           select ficheemprunt.id, cd.titre, CONCAT(adherent.nom, ' ', adherent.prenom) as adherent, ficheemprunt.dateEmprunt, ficheemprunt.dateLimite, ficheemprunt.depasse
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
                dgvEmprunt.Columns[5].Visible = false;
                // Fermeture de la connexion
                bdd.GetConnection().Close();

                dgvEmprunt.AllowUserToAddRows = false;

                
                dgvEmprunt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEmprunt.Sort(dgvEmprunt.Columns["id"], ListSortDirection.Ascending);
                foreach (DataGridViewRow row in dgvEmprunt.Rows)
                {
                    if (Convert.ToInt32(row.Cells[5].Value) == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
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

        private void btnSup_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouverture de la connexion
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();

                //Récupère les lignes sélectionnées dans une collection 
                DataGridViewSelectedRowCollection maliste = dgvEmprunt.SelectedRows;

                //Pour chaque ligne, on créé le CD correspondant et on le supprime
                foreach (DataGridViewRow row in maliste)
                {
                    
                    string id = row.Cells[0].Value.ToString();                   

                    bdd.DeleteFicheEmprunt(Convert.ToInt32(id));
                    dgvEmprunt.Rows.RemoveAt(this.dgvEmprunt.SelectedRows[0].Index);
                }
                bdd.GetConnection().Close();
                if (maliste.Count > 1)
                {
                    lblnotif.Text = "Les lignes ont été supprimées.";
                }
                else
                {
                    if (maliste.Count == 1)
                    {
                        lblnotif.Text = "La ligne a été supprimée.";
                    }

                }
            }
            catch (Exception ex)
            {
                lblnotif.Text = "Une erreur s'est produite pendant la suppression ! " + ex.Message;
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Close();
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();

            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(@"select ficheemprunt.id, dvd.titre, CONCAT(adherent.nom, ' ', adherent.prenom) as adherent, ficheemprunt.dateEmprunt, ficheemprunt.dateLimite, ficheemprunt.depasse
                                                                           from dvd, ficheemprunt, adherent
                                                                           where ficheemprunt.idsupport = dvd.id
                                                                           and ficheemprunt.idadherent = adherent.id
                                                                           union
                                                                           select ficheemprunt.id, cd.titre, CONCAT(adherent.nom, ' ', adherent.prenom) as adherent, ficheemprunt.dateEmprunt, ficheemprunt.dateLimite, ficheemprunt.depasse
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
                dgvEmprunt.Columns[5].Visible = false;
                // Fermeture de la connexion
                bdd.GetConnection().Close();

                dgvEmprunt.AllowUserToAddRows = false;


                dgvEmprunt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEmprunt.Sort(dgvEmprunt.Columns["id"], ListSortDirection.Ascending);
                foreach (DataGridViewRow row in dgvEmprunt.Rows)
                {
                    if (Convert.ToInt32(row.Cells[5].Value) == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch
            {
                // Gestion des erreurs :

            }
        }
    }
}

