using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bibliotheque
{
    public partial class ListeGenres : Form
    {
        public ListeGenres()
        {
            InitializeComponent();
        }



        private void txtbox_searchGenre_TextChanged(object sender, EventArgs e)
        {
            //Récupération des genres
            var select = "SELECT id_genre AS 'ID', name_genre AS 'Nom du genre' FROM genre WHERE name_genre LIKE '%' + @Nom + '%'; ";
            //Connection à la base de données
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            //Requête SQL
            var dataAdapter = new SqlDataAdapter(select, c);
            //Affectation de la barre de rechercher à une variable SQL
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Nom", txtbox_searchGenre.Text);
            //Affectation du résultat de la requête à une variable de type DataTable            
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //Création du dataset
            var ds = new DataSet();
            //Remplissage du dataset
            dataAdapter.Fill(ds);
            //Affichage du résultat dans le DataGridView
            dgridview_genre.DataSource = ds.Tables[0];
        }

        private void btn_ajoutGenre_Click(object sender, EventArgs e)
        {
            //Création d'une instance de la fenêtre AjoutGenre
            AjoutGenre ajoutGenre = new AjoutGenre();
            //Affichage de la fenêtre AjoutGenre
            ajoutGenre.ShowDialog();
            //Fermeture de la fenêtre ListeGenres
            Close();
        }

        private void btn_modifGenre_Click(object sender, EventArgs e)
        {
            //Connection à la base de données
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            //Ouverture de la connexion
            con.Open();
            //Création d'un objet commande modification
            SqlCommand cmd = new SqlCommand("UPDATE genre set name_genre = @Nom where id_genre = @ID", con);
            //Affectation des paramètres
            cmd.Parameters.AddWithValue("@Nom", this.dgridview_genre.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@ID", this.dgridview_genre.CurrentRow.Cells[0].Value.ToString());
            //Exécution de la commande
            cmd.ExecuteNonQuery();
            //Fermeture de la connexion
            con.Close();
            //Affichage d'un message de confirmation
            MessageBox.Show("Modification réussie");
        }

        private void btn_supprGenre_Click(object sender, EventArgs e)
        {
            //Test de séléction d'une ligne
            if (this.dgridview_genre.SelectedRows.Count > 0)
            {

                //Connection à la base de données
                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                //Ouverture de la connexion
                con.Open();
                //Création d'un objet commande suppression
                SqlCommand cmd = new SqlCommand("DELETE FROM genre WHERE name_genre = @Nom", con);
                //Affectation des paramètres
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_genre.CurrentRow.Cells[1].Value.ToString());
                //Exécution de la commande
                cmd.ExecuteNonQuery();
                //Fermeture de la connexion
                con.Close();
                //Suppression de la ligne séléctionnée dans le datagridView
                dgridview_genre.Rows.RemoveAt(this.dgridview_genre.SelectedRows[0].Index);
            }
        }

        private void btn_accueilGenre_Click(object sender, EventArgs e)
        {
            //Création d'une instance de la fenêtre Accueil
            Accueil accueil = new Accueil();
            //Affichage de la fenêtre Accueil
            accueil.Show();
            //Fermeture de la fenêtre ListeGenres
            Close();
        }

        private void ListeGenres_Load_1(object sender, EventArgs e)
        {
            //Récupération des genres
            var select = "SELECT id_genre as 'ID', name_genre as 'Nom du genre' FROM genre";
            //Connection à la base de données
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            //Requête SQL
            var dataAdapter = new SqlDataAdapter(select, c);
            //Affectation du résultat de la requête à une variable de type DataTable
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //Création du dataset            
            var ds = new DataSet();
            //Remplissage du dataset
            dataAdapter.Fill(ds);
            //Affichage du résultat dans le DataGridView
            dgridview_genre.DataSource = ds.Tables[0];
        }
    }
}
