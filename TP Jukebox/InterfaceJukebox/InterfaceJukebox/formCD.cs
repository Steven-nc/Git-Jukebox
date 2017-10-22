#region "Imports"
using System;
using System.Data;
using System.Windows.Forms;
using ClassJukeox;
using MySql.Data.MySqlClient;
using System.Drawing;
#endregion

namespace InterfaceJukebox
{
    public partial class FormCD : Form
    {
        public FormCD()
        {
            InitializeComponent();
        }

        #region "Evénements"

        private void FormCD_Load(object sender, EventArgs e)
        {

            Bdd bdd = new Bdd();

            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                //Récupère les CD de la base et les insère dans le datagrid
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from cd", bdd.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvCD.DataSource = DS.Tables[0];
                dgvCD.Columns[0].Visible = false;
                dgvCD.Columns["titre"].HeaderText = "Titre";
                dgvCD.Columns["duree"].HeaderText = "Durée(mins)";
                dgvCD.Columns["enstock"].HeaderText = "En stock";
                dgvCD.Columns["artiste"].HeaderText = "Artiste";
                dgvCD.Columns["nbpiste"].HeaderText = "Nombre de piste";
                dgvCD.Columns["prix"].HeaderText = "Prix (xcfp)";
                dgvCD.Columns["commentaire"].HeaderText = "Commentaire";
                dgvCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Fermeture de la connexion
                bdd.GetConnection().Close();


                    
            }
            catch (Exception ex)
            {
                // Gestion des erreurs :
                label1.Text = "Une erreur est survenue lors du chargement ! " + ex.Message;

            }

        }

        private void btnactualisercd_Click(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();

            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                //Récupère et insère les CD de la base dans le datagrid
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from cd", bdd.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvCD.DataSource = DS.Tables[0];
                dgvCD.Columns[0].Visible = false;
                dgvCD.Columns["titre"].HeaderText = "Titre";
                dgvCD.Columns["duree"].HeaderText = "Durée(mins)";
                dgvCD.Columns["enstock"].HeaderText = "En stock";
                dgvCD.Columns["artiste"].HeaderText = "Artiste";
                dgvCD.Columns["nbpiste"].HeaderText = "Nombre de piste";
                dgvCD.Columns["prix"].HeaderText = "Prix (xcfp)";
                dgvCD.Columns["commentaire"].HeaderText = "Commentaire";

                // Fermeture de la connexion
                bdd.GetConnection().Close();
                label1.Text = "Le tableau a été actualisé.";
            }
            catch (Exception ex)
            {
                // Gestion des erreurs :
                label1.Text = "Une erreur est survenue lors du rafraichissement du tableau ! " + ex.Message;

            }
        }

        private void btnajoutercd_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouverture de la connexion 
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();

                //Création d'une collection de lignes sélectionées 
                DataGridViewSelectedRowCollection maliste = dgvCD.SelectedRows;

                //Pour chaque ligne on créé le CD correspondant et on l'insert dans la base
                foreach (DataGridViewRow row in maliste)
                {

                    //Récupère les données des cellules d'une ligne 
                    Boolean enstock;
                    string titre = row.Cells[1].Value.ToString();
                    string maduree = row.Cells[2].Value.ToString();
                    int duree = Convert.ToInt32(maduree);
                    string enstock1 = row.Cells[3].Value.ToString();
                    if (enstock1 == "True")
                    {
                        enstock = true;
                    }
                    else
                    {
                        enstock = false;
                    }
                    string artiste = row.Cells[4].Value.ToString();
                    string monnbpiste = row.Cells[5].Value.ToString();
                    int nbpiste = Convert.ToInt32(monnbpiste);
                    string monprix = row.Cells[6].Value.ToString();
                    int prix = Convert.ToInt32(monprix);
                    string commentaire = row.Cells[7].Value.ToString();

                    //Création du CD
                    CD cd = new CD(titre, duree, enstock, commentaire, artiste, nbpiste, prix);

                    //Insertion du CD
                    bdd.AddCd(cd);
                }

                bdd.GetConnection().Close();

                if (maliste.Count > 1)
                {
                    label1.Text = "Les lignes ont été ajoutées.";
                }
                else
                {
                    if (maliste.Count == 1)
                    {
                        label1.Text = "La ligne a été ajoutée.";
                    }
                }
            }
            catch (Exception ex)
            {
                //Gestion erreurs
                label1.Text = "Une erreur s'est produite pendant l'ajout ! " + ex.Message;
            }
            
        }

        private void btnretourcd_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Close();
            //MessageBox.Show("My message here");
        }

        private void btnsuppcd_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouverture de la connexion
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();

                //Récupère les lignes sélectionnées dans une collection 
                DataGridViewSelectedRowCollection maliste = dgvCD.SelectedRows;

                //Pour chaque ligne, on créé le CD correspondant et on le supprime
                foreach (DataGridViewRow row in maliste)
                {
                    Boolean enstock;
                    string titre = row.Cells[1].Value.ToString();
                    string maduree = row.Cells[2].Value.ToString();
                    int duree = Convert.ToInt32(maduree);
                    string enstock1 = row.Cells[3].Value.ToString();
                    if (enstock1 == "True")
                    {
                        enstock = true;
                    }
                    else
                    {
                        enstock = false;
                    }
                    string artiste = row.Cells[4].Value.ToString();
                    string monnbpiste = row.Cells[5].Value.ToString();
                    int nbpiste = Convert.ToInt32(monnbpiste);
                    string monprix = row.Cells[6].Value.ToString();
                    int prix = Convert.ToInt32(monprix);
                    string commentaire = row.Cells[7].Value.ToString();

                    CD cd = new CD(titre, duree, enstock, commentaire, artiste, nbpiste, prix);
                    bdd.DeleteCd(cd);
                    dgvCD.Rows.RemoveAt(this.dgvCD.SelectedRows[0].Index);
                }
                bdd.GetConnection().Close();
                if (maliste.Count > 1)
                {
                    label1.Text = "Les lignes ont été supprimées.";
                }
                else
                {
                    if (maliste.Count == 1)
                    {
                        label1.Text = "La ligne a été supprimée.";
                    }
                    
                }
            }
            catch (Exception ex)
            {
                label1.Text = "Une erreur s'est produite pendant la suppression ! " + ex.Message;
            }

        }

        private void btnmodifcd_Click(object sender, EventArgs e)
        {
            try
            {
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();
                int index = dgvCD.SelectedRows[0].Index;

                Boolean enstock;
                string titre = dgvCD.Rows[index].Cells[1].Value.ToString();
                string maduree = dgvCD.Rows[index].Cells[2].Value.ToString();
                int duree = Convert.ToInt32(maduree);
                string enstock1 = dgvCD.Rows[index].Cells[3].Value.ToString();
                if (enstock1 == "True")
                {
                    enstock = true;
                }
                else
                {
                    enstock = false;
                }
                string artiste = dgvCD.Rows[index].Cells[4].Value.ToString();
                string monnbpiste = dgvCD.Rows[index].Cells[5].Value.ToString();
                int nbpiste = Convert.ToInt32(monnbpiste);
                string monprix = dgvCD.Rows[index].Cells[6].Value.ToString();
                int prix = Convert.ToInt32(monprix);
                string commentaire = dgvCD.Rows[index].Cells[7].Value.ToString();

                CD cdamodifier = new CD(titre, duree, enstock, commentaire, artiste, nbpiste, prix);

                bdd.GetConnection().Close();
                formCDmodif modifCD = new formCDmodif();
                //Méthode get MonCD de formCDmodif
                modifCD.MonCD = cdamodifier;
                modifCD.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            
        }
        #endregion

    }
}
