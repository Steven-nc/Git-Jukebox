#region "Imports"
using ClassJukeox;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
#endregion

namespace InterfaceJukebox
{
    public partial class formDVD : Form
    {
        public formDVD()
        {
            InitializeComponent();
        }

        //Je refais la même chose que pour les CDs en adaptant le code pour un DVD
        #region "Evénements"

        private void formDVD_Load(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();

            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from dvd", bdd.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDVD.DataSource = DS.Tables[0];
                dgvDVD.Columns[0].Visible = false;
                dgvDVD.Columns["titre"].HeaderText = "Titre";
                dgvDVD.Columns["duree"].HeaderText = "Durée(mins)";
                dgvDVD.Columns["enstock"].HeaderText = "En stock";
                dgvDVD.Columns["metteurenscene"].HeaderText = "Metteur en scène";
                dgvDVD.Columns["commentaire"].HeaderText = "Commentaire";
                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch
            {
                // Gestion des erreurs :

            }
        }

        private void btnactualiserdvd_Click(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();

            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from dvd", bdd.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDVD.DataSource = DS.Tables[0];
                dgvDVD.Columns[0].Visible = false;
                dgvDVD.Columns["titre"].HeaderText = "Titre";
                dgvDVD.Columns["duree"].HeaderText = "Durée(mins)";
                dgvDVD.Columns["enstock"].HeaderText = "En stock";
                dgvDVD.Columns["metteurenscene"].HeaderText = "Metteur en scène";
                dgvDVD.Columns["commentaire"].HeaderText = "Commentaire";
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

        private void btnajouterdvd_Click(object sender, EventArgs e)
        {
            try
            {
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();
                DataGridViewSelectedRowCollection maliste = dgvDVD.SelectedRows;
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
                    string metteurenscene = row.Cells[4].Value.ToString();
                    string commentaire = row.Cells[5].Value.ToString();
                    DVD dvd = new DVD(titre, duree, enstock, commentaire, metteurenscene);
                    bdd.AddDvd(dvd);
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
                label1.Text = "Une erreur s'est produite pendant l'ajout ! " + ex.Message;
            }
        }

        private void btnretourdvd_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Close();
        }

        private void btnsuppdvd_Click(object sender, EventArgs e)
        {
            try
            {
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();
                DataGridViewSelectedRowCollection maliste = dgvDVD.SelectedRows;
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
                    string metteurenscene = row.Cells[4].Value.ToString();
                    string commentaire = row.Cells[5].Value.ToString();

                    DVD dvd = new DVD(titre, duree, enstock, commentaire, metteurenscene);
                    bdd.DeleteDvd(dvd);
                    dgvDVD.Rows.RemoveAt(this.dgvDVD.SelectedRows[0].Index);
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

        private void btnmodifdvd_Click(object sender, EventArgs e)
        {
            try
            {
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();
                int index = dgvDVD.SelectedRows[0].Index;

                Boolean enstock;
                string titre = dgvDVD.Rows[index].Cells[1].Value.ToString();
                string maduree = dgvDVD.Rows[index].Cells[2].Value.ToString();
                int duree = Convert.ToInt32(maduree);
                string enstock1 = dgvDVD.Rows[index].Cells[3].Value.ToString();
                if (enstock1 == "True")
                {
                    enstock = true;
                }
                else
                {
                    enstock = false;
                }
                string metteurenscene = dgvDVD.Rows[index].Cells[4].Value.ToString();
                string commentaire = dgvDVD.Rows[index].Cells[5].Value.ToString();

                DVD dvdamodifier = new DVD(titre, duree, enstock, commentaire, metteurenscene);

                bdd.GetConnection().Close();
                formDVDmodif modifDVD = new formDVDmodif();
                modifDVD.MonDVD = dvdamodifier;
                modifDVD.Show();
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
