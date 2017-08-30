#region "Imports"
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ClassJukeox
{
    public class Bdd
    {
        #region "Connexion bdd"
        private MySqlConnection connection;

        // Constructeur
        public Bdd()
        {
            InitConnexion();
        }
        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=jukebox; UID=root; PASSWORD=''; SslMode=none";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return this.connection;
        }

        #endregion

        #region "Méthodes CD"

        public void DeleteCd(CD cd)
        {
            Bdd bdd = new Bdd();
            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();

                // Requête SQL
                cmd.CommandText = "DELETE FROM CD WHERE titre = @titre and duree= @duree and artiste= @artiste and nbpiste=@nbpiste and prix=@prix and commentaire= @commentaire;";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@titre", cd.Titre);
                cmd.Parameters.AddWithValue("@duree", cd.Duree);
                cmd.Parameters.AddWithValue("@artiste", cd.Artiste);
                cmd.Parameters.AddWithValue("@nbpiste", cd.Nombredepistes);
                cmd.Parameters.AddWithValue("@prix", cd.Prix);
                cmd.Parameters.AddWithValue("@commentaire", cd.Commentaire);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch
            {
                // Gestion des erreurs :
            }
        }

        public void UpdateCD(CD cd, int id)
        {
            Bdd bdd = new Bdd();
            bdd.GetConnection().Open();
            MySqlCommand cmd = bdd.GetConnection().CreateCommand();
            //Requête de modification du CD passé en paramètre avec son id que j'aurai récupéré auparavant
            cmd.CommandText = "update cd set titre = @titre, duree= @duree, enstock=@enstock, artiste= @artiste, nbpiste=@nbpiste, prix=@prix, commentaire= @commentaire WHERE id=@id;";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@titre", cd.Titre);
            cmd.Parameters.AddWithValue("@duree", cd.Duree);
            cmd.Parameters.AddWithValue("@enstock", cd.EnStock);
            cmd.Parameters.AddWithValue("@artiste", cd.Artiste);
            cmd.Parameters.AddWithValue("@nbpiste", cd.Nombredepistes);
            cmd.Parameters.AddWithValue("@prix", cd.Prix);
            cmd.Parameters.AddWithValue("@commentaire", cd.Commentaire);
            cmd.ExecuteNonQuery();
            bdd.GetConnection().Close();
        }

        public void AddCd(CD cd)
        {
            Bdd bdd = new Bdd();
            int id;
            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();

                //A l'ajout d'un CD, je récupère l'id le plus grand +1 pour éviter les doublons
                MySqlCommand cmdId = new MySqlCommand("select max(id)+1 from cd", bdd.GetConnection());
                string monId = cmdId.ExecuteScalar().ToString();
                if (monId == "")
                {
                    id = 1;
                }
                else
                {
                    id = Convert.ToInt32(monId);
                }

                // Requête SQL
                cmd.CommandText = "INSERT INTO cd (id,titre, duree, enstock, artiste, nbpiste, prix, commentaire) VALUES  (@id,@titre, @duree, @enstock, @artiste, @nbpiste, @prix, @commentaire)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@titre", cd.Titre);
                cmd.Parameters.AddWithValue("@duree", cd.Duree);
                cmd.Parameters.AddWithValue("@enstock", cd.EnStock);
                cmd.Parameters.AddWithValue("@artiste", cd.Artiste);
                cmd.Parameters.AddWithValue("@nbpiste", cd.Nombredepistes);
                cmd.Parameters.AddWithValue("@prix", cd.Prix);
                cmd.Parameters.AddWithValue("@commentaire", cd.Commentaire);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch
            {
                // Gestion des erreurs :
            }
        }

        #endregion

        #region "Méthodes DVD"
        public void DeleteDvd(DVD dvd)
        {
            Bdd bdd = new Bdd();
            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();

                // Requête SQL
                cmd.CommandText = "DELETE FROM dvd WHERE titre = @titre and duree= @duree and metteurenscene=@metteurenscene and commentaire= @commentaire;";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@titre", dvd.Titre);
                cmd.Parameters.AddWithValue("@duree", dvd.Duree);
                cmd.Parameters.AddWithValue("@metteurenscene", dvd.Metteurenscene);
                cmd.Parameters.AddWithValue("@commentaire", dvd.Commentaire);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch
            {
                // Gestion des erreurs :
            }
        }

        public void UpdateDVD(DVD dvd, int id)
        {
            Bdd bdd = new Bdd();
            bdd.GetConnection().Open();
            MySqlCommand cmd = bdd.GetConnection().CreateCommand();
            cmd.CommandText = "update dvd set titre = @titre, duree= @duree, metteurenscene=@metteurenscene, commentaire= @commentaire WHERE id=@id;";

            // utilisation de l'objet contact passé en paramètre
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@titre", dvd.Titre);
            cmd.Parameters.AddWithValue("@duree", dvd.Duree);
            cmd.Parameters.AddWithValue("@enstock", dvd.EnStock);
            cmd.Parameters.AddWithValue("@metteurenscene", dvd.Metteurenscene);
            cmd.Parameters.AddWithValue("@commentaire", dvd.Commentaire);
            cmd.ExecuteNonQuery();
            bdd.GetConnection().Close();
        }

        public void AddDvd(DVD dvd)
        {
            Bdd bdd = new Bdd();
            int id;
            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();
                MySqlCommand cmdId = new MySqlCommand("select max(id)+1 from dvd", bdd.GetConnection());
                string monId =cmdId.ExecuteScalar().ToString();
                if (monId == "")
                {
                    id = 1;
                }
                else
                {
                    id = Convert.ToInt32(monId);
                }

                // Requête SQL
                cmd.CommandText = "INSERT INTO dvd (id,titre, duree, enstock, metteurenscene, commentaire) VALUES  (@id,@titre, @duree, @enstock, @metteurenscene, @commentaire)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@titre", dvd.Titre);
                cmd.Parameters.AddWithValue("@duree", dvd.Duree);
                cmd.Parameters.AddWithValue("@enstock", dvd.EnStock);
                cmd.Parameters.AddWithValue("@metteurenscene", dvd.Metteurenscene);
                cmd.Parameters.AddWithValue("@commentaire", dvd.Commentaire);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch 
            {
                // Gestion des erreurs :

            }
        }

        #endregion

    }
}
