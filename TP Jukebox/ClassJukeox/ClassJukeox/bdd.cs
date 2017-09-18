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
            int id;
            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();


                cmd.CommandText = "SELECT id FROM CD WHERE titre = @titre and duree= @duree and artiste= @artiste and nbpiste=@nbpiste and prix=@prix;";
                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@titre", cd.Titre);
                cmd.Parameters.AddWithValue("@duree", cd.Duree);
                cmd.Parameters.AddWithValue("@artiste", cd.Artiste);
                cmd.Parameters.AddWithValue("@nbpiste", cd.Nombredepistes);
                cmd.Parameters.AddWithValue("@prix", cd.Prix);
                // Exécution de la commande SQL               
                id = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                cmd.Parameters.Clear();

                // Requête SQL
                cmd.CommandText = "DELETE FROM CD WHERE id = @id;";
                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@id", id);
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
               
                cmd.CommandText = "DELETE FROM SUPPORT WHERE id =@id;";             
                cmd.Parameters.AddWithValue("@id", id);
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
                MySqlCommand cmdId = new MySqlCommand("select max(id) from cd", bdd.GetConnection());
                string monId = cmdId.ExecuteScalar().ToString();
                if (monId == "")
                {
                    id = 1;
                }
                else
                {
                    monId = monId.Substring(1);
                    if (monId == "")
                    {
                        monId = "10";
                    }
                    else
                    {
                        id = Convert.ToInt32(monId) + 1;
                        monId = id.ToString();
                        monId = monId.Insert(0, "1");
                    }
                    id = Convert.ToInt32(monId);

                }

                cmd.CommandText = "INSERT INTO support (id) VALUES  (@id)";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

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
            int id;
            try
            {
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();

                cmd.CommandText = "SELECT id FROM dvd WHERE titre = @titre and duree= @duree and metteurenscene=@metteurenscene;";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@titre", dvd.Titre);
                cmd.Parameters.AddWithValue("@duree", dvd.Duree);
                cmd.Parameters.AddWithValue("@metteurenscene", dvd.Metteurenscene);

                // Exécution de la commande SQL
                id=Convert.ToInt32(cmd.ExecuteScalar().ToString());
                cmd.Parameters.Clear();

                // Requête SQL
                cmd.CommandText = "DELETE FROM dvd WHERE id=@id;";
                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@id", id);
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM SUPPORT WHERE id =@id";
                cmd.Parameters.AddWithValue("@id", id);
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
                MySqlCommand cmdId = new MySqlCommand("select max(id) from dvd", bdd.GetConnection());
                string monId = cmdId.ExecuteScalar().ToString();
                if (monId == "")
                {
                    id = 2;
                }
                else
                {
                    monId = monId.Substring(1);
                    if (monId == "")
                    {
                        monId = "20";
                    }
                    else
                    {
                        id = Convert.ToInt32(monId) + 1;
                        monId = id.ToString();
                        monId = monId.Insert(0, "2");
                    }
                    id = Convert.ToInt32(monId);

                }

                cmd.CommandText = "INSERT INTO support (id) VALUES  (@id)";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

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
