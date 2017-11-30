using ClassJukeox;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static bool IsValidEmailAddress(string emailaddress)
        {
            try
            {
                Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
                return rx.IsMatch(emailaddress);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //Bouton AJOUTER
        private void btnAddAdh_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouverture de la connexion 
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();

                //Création d'une collection de lignes sélectionées 
                DataGridViewSelectedRowCollection maliste = dgvAdh.SelectedRows;

                //Pour chaque ligne on créé l'adhérent correspondant et on l'insert dans la base
                foreach (DataGridViewRow row in maliste)
                {

                    //Récupère les données des cellules d'une ligne 
                    string nom = row.Cells[1].Value.ToString();
                    string prenom = row.Cells[2].Value.ToString();
                    string adressemail = row.Cells[3].Value.ToString();
                    DateTime dateI = DateTime.Now;
                    if (IsValidEmailAddress(adressemail))
                    {
                        //Création de l'adhérent
                        Adherent adherent = new Adherent(nom, prenom, adressemail, dateI, 0);

                        //Insertion de l'adhérent
                        bdd.addAdh(adherent);
                    }
                }

                bdd.GetConnection().Close();

                if (maliste.Count > 1)
                {
                    txtnotif.Text = "Les adhérents ont été ajoutés.";
                }
                else
                {
                    if (maliste.Count == 1)
                    {
                        txtnotif.Text = "L'adhérent a été ajoutée.";
                    }
                }
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

            }
            catch (Exception ex)
            {
                //Gestion erreurs
                txtnotif.Text = "Une erreur s'est produite pendant l'ajout ! " + ex.Message;
            }
        }

        //Bouton SUPPRIMER
        private void btnSuppAdh_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouverture de la connexion
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();

                //Récupère les lignes sélectionnées dans une collection 
                DataGridViewSelectedRowCollection maliste = dgvAdh.SelectedRows;

                //Pour chaque ligne, on créé l'adhérent correspondant et on le supprime
                foreach (DataGridViewRow row in maliste)
                {
                    string nom = row.Cells[1].Value.ToString();
                    string prenom = row.Cells[2].Value.ToString();
                    string adressemail = row.Cells[3].Value.ToString();
                    DateTime dateIns = Convert.ToDateTime(row.Cells[4].Value.ToString());
                    int nbE = Convert.ToInt32(row.Cells[5].Value.ToString());

                    //Création de l'adhérent avec les informations récupérées du tableau 
                    Adherent adherent = new Adherent(nom, prenom, adressemail, dateIns, nbE);
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

        //Bouton ACTUALISER, recharge le tableau de la même façon qu'il est initialisé
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
                // Fermeture de la connexion
                bdd.GetConnection().Close();
                
            }
            catch
            {
                // Gestion des erreurs :

            }
        }

        //Bouton MODIFIER, récupère les informations de l'adhérent à modifier et le passe au formulaire formAdhModif
        private void btnModifAdh_Click(object sender, EventArgs e)
        {
            try
            {
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();
                int index = dgvAdh.SelectedRows[0].Index;
                //Récupère informations de l'adhérents à modifier
                string nom = dgvAdh.Rows[index].Cells[1].Value.ToString();
                string prenom = dgvAdh.Rows[index].Cells[2].Value.ToString();
                string adressemail = dgvAdh.Rows[index].Cells[3].Value.ToString();
                DateTime dateIns = Convert.ToDateTime(dgvAdh.Rows[index].Cells[4].Value.ToString());
                int nbE = Convert.ToInt32(dgvAdh.Rows[index].Cells[5].Value.ToString());
                //Création de l'adhérent pour le passer au formulaire formAdhModif
                Adherent adherent = new Adherent(nom, prenom, adressemail, dateIns, nbE);

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

        //Bouton RETOUR
        private void btnretour_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Close();
        }

        private void formAdh_Load(object sender, EventArgs e)
        {
            dgvAdh.BackgroundColor = Color.White;
            Bdd bdd = new Bdd();

            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from adherent", bdd.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvAdh.DataSource = DS.Tables[0];
                dgvAdh.Columns["id"].Visible = false;
                dgvAdh.Columns["nom"].HeaderText = "Nom";
                dgvAdh.Columns["prenom"].HeaderText = "Prénom";
                dgvAdh.Columns["adressemail"].HeaderText = "Email";
                dgvAdh.Columns["dateI"].HeaderText = "Inscrit le";
                dgvAdh.Columns["dateI"].ReadOnly = true;
                dgvAdh.Columns["nbEmprunts"].HeaderText = "Total emprunts";
                dgvAdh.Columns["nbEmprunts"].ReadOnly = true;
                dgvAdh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch(MySqlException ee)
            {
                // Gestion des erreurs :
                txtnotif.Text = ee.Message;
            }
        }
    }
}