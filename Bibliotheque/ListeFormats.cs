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

namespace Bibliotheque{
    public partial class ListeFormats : Form{
        public ListeFormats(){
            InitializeComponent();
        }

        private void ListeFormats_Load(object sender, EventArgs e){
            //Sélectionne tous les formats de la base de données
            var select = "SELECT id_format as 'ID', name_format as 'Nom du format' FROM format";
            //Connexion à la base de données
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            //Ouverture de la connexion
            var dataAdapter = new SqlDataAdapter(select, c);
            //Affectation du résultat de la requête à une variable de type DataTable
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //Création d'un nouveau DataSet
            var ds = new DataSet();
            //Remplissage du DataSet avec le résultat de la requête
            dataAdapter.Fill(ds);
            //Remplissage de la DataGridView avec le DataSet
            dgridview_format.DataSource = ds.Tables[0];
        }

        private void txtbox_searchFormat_TextChanged(object sender, EventArgs e){
            //Sélectionne tous les formats de la base de données
            var select = "SELECT id_format AS 'ID', name_format AS 'Nom du format' FROM format WHERE name_format LIKE '%' + @Nom + '%'; ";
            //Connexion à la base de données
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            //Affectation de la requête à la connexion à la base de données
            var dataAdapter = new SqlDataAdapter(select, c);
            //Affectation de la barre de rechercher à une variable SQL
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Nom", txtbox_searchFormat.Text);
            //Affectation du résultat de la requête à une variable de type DataTable
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //Création d'un nouveau DataSet
            var ds = new DataSet();
            //Remplissage du DataSet avec le résultat de la requête
            dataAdapter.Fill(ds);
            //Remplissage de la DataGridView avec le DataSet
            dgridview_format.DataSource = ds.Tables[0];
        }

        private void btn_ajoutFormat_Click(object sender, EventArgs e){
            //Création d'un nouveau formulaire de type AjoutFormat
            AjoutFormat ajoutFormat = new AjoutFormat();
            //Affichage du formulaire ajoutFormat
            ajoutFormat.ShowDialog();
            //Fermeture du formulaire actuel
            Close();
        }

        private void btn_modifFormat_Click(object sender, EventArgs e){
            //Création de la connexion
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            //Ouverture de la connexion
            con.Open();
            //Création de la requête
            SqlCommand cmd = new SqlCommand("UPDATE format set name_format = @Nom where id_format = @ID", con);
            //Affectation des paramètres à la requête
            cmd.Parameters.AddWithValue("@Nom", this.dgridview_format.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@ID", this.dgridview_format.CurrentRow.Cells[0].Value.ToString());
            //Exécution de la requête
            cmd.ExecuteNonQuery();
            //Fermeture de la connexion
            con.Close();
            //Affichage d'un message de confirmation
            MessageBox.Show("Modification réussie");
        }

        private void btn_supprEditeur_Click(object sender, EventArgs e){
            //Vérifie si une ligne est sélectionnée
            if (this.dgridview_format.SelectedRows.Count > 0){
                //Création de la connexion
                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                //Ouverture de la connexion
                con.Open();
                //Création de la requête
                SqlCommand cmd = new SqlCommand("DELETE FROM format WHERE name_format = @Nom", con);
                //Affectation des paramètres à la requête
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_format.CurrentRow.Cells[1].Value.ToString());
                //Exécution de la requête
                cmd.ExecuteNonQuery();
                //Fermeture de la connexion
                con.Close();
                //Suppression de la ligne sélectionnée de la DataGridView
                dgridview_format.Rows.RemoveAt(this.dgridview_format.SelectedRows[0].Index);
            }
        }

        private void btn_accueilFormat_Click(object sender, EventArgs e){
            //Création d'un nouveau formulaire de type Accueil
            Accueil accueil = new Accueil();
            //Affichage du formulaire accueil
            accueil.Show();
            //Fermeture du formulaire actuel
            Close();
        }
    }
}
