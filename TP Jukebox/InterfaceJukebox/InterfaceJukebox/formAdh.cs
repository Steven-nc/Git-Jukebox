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
    public partial class formAdh : Form
    {
        public formAdh()
        {
            InitializeComponent();
        }

        private void formAdh_Load_1(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();

            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from adherent", bdd.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS); 
                dgvAdh.DataSource = DS.Tables[0];
                dgvAdh.Columns[0].Visible = false;
                dgvAdh.Columns["nom"].HeaderText = "Nom";
                dgvAdh.Columns["prenom"].HeaderText = "Prénom";
                dgvAdh.Columns["adressemail"].HeaderText = "Email";
                dgvAdh.Columns["dateI"].HeaderText = "Inscrit le";
                dgvAdh.Columns["nbEmprunts"].HeaderText = "Total emprunts";
                dgvAdh.Columns["nbEmpruntsDepasses"].HeaderText = "Emprunt(s) dépassé(s)";
                dgvAdh.Columns["nbEmpruntsEnCours"].HeaderText = "Emprunt(s) en cours";
                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch
            {
                // Gestion des erreurs :

            }
        }

        private void btnAddAdh_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouverture de la connexion 
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();

                //Création d'une collection de lignes sélectionées 
                DataGridViewSelectedRowCollection maliste = dgvAdh.SelectedRows;

                //Pour chaque ligne on créé le CD correspondant et on l'insert dans la base
                foreach (DataGridViewRow row in maliste)
                {

                    //Récupère les données des cellules d'une ligne 
                    string nom = row.Cells[1].Value.ToString();
                    string prenom = row.Cells[2].Value.ToString();
                    string adressemail = row.Cells[3].Value.ToString();
                    DateTime dateI = DateTime.Now;

                    //Création du CD
                    Adherent adherent = new Adherent(nom, prenom, adressemail, dateI, 0, 0, 0);

                    //Insertion du CD
                    bdd.addAdh(adherent);
                }

                bdd.GetConnection().Close();

                if (maliste.Count > 1)
                {
                    txtnotif.Text = "Les lignes ont été ajoutées.";
                }
                else
                {
                    if (maliste.Count == 1)
                    {
                        txtnotif.Text = "La ligne a été ajoutée.";
                    }
                }
            }
            catch (Exception ex)
            {
                //Gestion erreurs
                //label1.Text = "Une erreur s'est produite pendant l'ajout ! " + ex.Message;
            }
        }

        private void btnSuppAdh_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouverture de la connexion
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();

                //Récupère les lignes sélectionnées dans une collection 
                DataGridViewSelectedRowCollection maliste = dgvAdh.SelectedRows;

                //Pour chaque ligne, on créé le CD correspondant et on le supprime
                foreach (DataGridViewRow row in maliste)
                {
                    string nom = row.Cells[1].Value.ToString();
                    string prenom = row.Cells[2].Value.ToString();
                    string adressemail = row.Cells[3].Value.ToString();
                    DateTime dateIns = Convert.ToDateTime(row.Cells[4].Value.ToString());
                    int nbE = Convert.ToInt32(row.Cells[5].Value.ToString());
                    int nbED = Convert.ToInt32(row.Cells[6].Value.ToString());
                    int nbEEC = Convert.ToInt32(row.Cells[7].Value.ToString());

                    Adherent adherent = new Adherent(nom, prenom, adressemail, dateIns, nbE, nbED, nbEEC);
                    bdd.deleteAdh(adherent);
                    dgvAdh.Rows.RemoveAt(this.dgvAdh.SelectedRows[0].Index);

                }
                bdd.GetConnection().Close();
                if (maliste.Count > 1)
                {
                    txtnotif.Text = "Les lignes ont été supprimées.";
                }
                else
                {
                    if (maliste.Count == 1)
                    {
                        txtnotif.Text = "La ligne a été supprimée.";
                    }

                }
            }
            catch (Exception ex)
            {
                txtnotif.Text = "Une erreur s'est produite pendant la suppression ! " + ex.Message;
            }
        }

        private void btnActuAdh_Click(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();

            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from adherent", bdd.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvAdh.DataSource = DS.Tables[0];
                dgvAdh.Columns[0].Visible = false;
                dgvAdh.Columns["nom"].HeaderText = "Nom";
                dgvAdh.Columns["prenom"].HeaderText = "Prénom";
                dgvAdh.Columns["adressemail"].HeaderText = "Email";
                dgvAdh.Columns["dateI"].HeaderText = "Inscrit le";
                dgvAdh.Columns["nbEmprunts"].HeaderText = "Total emprunts";
                dgvAdh.Columns["nbEmpruntsDepasses"].HeaderText = "Emprunt(s) dépassé(s)";
                dgvAdh.Columns["nbEmpruntsEnCours"].HeaderText = "Emprunt(s) en cours";
                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch
            {
                // Gestion des erreurs :

            }
        }

        private void btnModifAdh_Click(object sender, EventArgs e)
        {
            try
            {
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();
                int index = dgvAdh.SelectedRows[0].Index;

                string nom = dgvAdh.Rows[index].Cells[1].Value.ToString();
                string prenom = dgvAdh.Rows[index].Cells[2].Value.ToString();
                string adressemail = dgvAdh.Rows[index].Cells[3].Value.ToString();
                DateTime dateIns = Convert.ToDateTime(dgvAdh.Rows[index].Cells[4].Value.ToString());
                int nbE = Convert.ToInt32(dgvAdh.Rows[index].Cells[5].Value.ToString());
                int nbED = Convert.ToInt32(dgvAdh.Rows[index].Cells[6].Value.ToString());
                int nbEEC = Convert.ToInt32(dgvAdh.Rows[index].Cells[7].Value.ToString());

                Adherent adherent = new Adherent(nom, prenom, adressemail, dateIns, nbE, nbED, nbEEC);

                bdd.GetConnection().Close();
                formAdhModif modifAdh = new formAdhModif();
                //Méthode get MonCD de formCDmodif
                modifAdh.MonAdherent = adherent;
                modifAdh.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                txtnotif.Text = ex.Message;
            }
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Close();
        }
    }
}
