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
    public partial class formAjoutEmprunt : Form
    {
        public formAjoutEmprunt()
        {
            InitializeComponent();
        }

        private void formAjoutEmprunt_Load(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();

            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                string Query = "select id, CONCAT(nom,' ', prenom) as adherent from Adherent where id not in (select idadherent from ficheemprunt where depasse =1)";
                MySqlCommand cmd = new MySqlCommand(Query, bdd.GetConnection());
                var reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    string adh = reader.GetString("adherent") +' '+ reader.GetString("id");
                    cbAdh.Items.Add(adh);
                }
                reader.Close();

                string Query1 = "select id, titre from cd where enstock=1 union select id, titre from dvd where enstock=1 order by id";
                MySqlCommand cmdQuery1 = new MySqlCommand(Query1, bdd.GetConnection());
                var readerQuery1 = cmdQuery1.ExecuteReader();
                while (readerQuery1.Read())
                {
                    string support = readerQuery1.GetString("titre") +' '+ readerQuery1.GetString("id");
                    cbSup.Items.Add(support);
                }
                readerQuery1.Close();

            }
            catch(MySqlException i)
            {
                
            }          

            List<string> values = new List<string>();
            
            string sql = "SELECT CONCAT(nom,' ',prenom,' ',id) as adherent FROM adherent where id not in (select idadherent from ficheemprunt)";
            MySqlCommand cmd1 = new MySqlCommand(sql, bdd.GetConnection());
            MySqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                values.Add(reader1.GetString("adherent"));
            }
            reader1.Close();

            var cc = new AutoCompleteStringCollection();
            foreach(string a in values)
            {
                cc.Add(a);
            }

            cbAdh.AutoCompleteCustomSource = cc;            

           List<string> valuesSup = new List<string>();

            string sql1 = "select concat(titre,' ',id) as support from cd where enstock = 1 union select concat(titre,' ',id) as support from dvd where enstock = 1";
            MySqlCommand cmd2 = new MySqlCommand(sql1, bdd.GetConnection());
            MySqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                valuesSup.Add(reader2.GetString("support"));
            }
            reader2.Close();

            var cc1 = new AutoCompleteStringCollection();
            foreach (string b in valuesSup)
            {
                cc1.Add(b);
            }
       
            cbSup.AutoCompleteCustomSource = cc1;


        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            formEmprunt menuEmprunt = new formEmprunt();
            menuEmprunt.Show();
            this.Hide();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                Bdd bdd = new Bdd();
                bdd.GetConnection().Open();

                int IDsupport = Convert.ToInt32(cbSup.Text.Split(' ').LastOrDefault());
                int IDadherent = Convert.ToInt32(cbAdh.Text.Split(' ').LastOrDefault());
                DateTime dateE = DateTime.Now;
                DateTime dateL = dateE.AddDays(7);
                bool dep = false;

                FicheEmprunt uneFiche = new FicheEmprunt(IDsupport, IDadherent, dateE, dateL, dep);
                bdd.addFicheEmprunt(uneFiche);
                lblnotif.Text = "Emprunt effectué";
            }
            catch
            {

            }
        }
    }
}

