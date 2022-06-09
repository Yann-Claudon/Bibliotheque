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
    public partial class ListeEditeurs : Form{
        public ListeEditeurs(){
            InitializeComponent();
        }

        private void ListeEditeurs_Load(object sender, EventArgs e){
            //Création de la requête
            var select = "SELECT id_editor as 'ID', name_editor as 'Nom Éditeur' FROM editor";
            //Création de la connexion
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            //Liaison de la requête et de la connexion
            var dataAdapter = new SqlDataAdapter(select, c);
            //Création de la commande de remplissage
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //Création d'un dataSet
            var ds = new DataSet();
            //Remplissage du dataSet
            dataAdapter.Fill(ds);
            //Remplissage de la liste
            dgridview_editeur.DataSource = ds.Tables[0];

        }

        private void btn_ajoutEditeur_Click(object sender, EventArgs e){
            //Création du formulaire ajout éditeur
            AjoutEditeur ajoutEditeur = new AjoutEditeur();
            //Affichage du formulaire
            ajoutEditeur.ShowDialog();
            //Réactualisation de la liste
            Close();
        }

        private void btn_modifEditeur_Click(object sender, EventArgs e){
            //Création de la connexion
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            //Ouverture de la connexion
            con.Open();
            //Création de la requête
            SqlCommand cmd = new SqlCommand("UPDATE editor set name_editor = @Nom where id_editor = @ID", con);
            //Création des paramètres
            cmd.Parameters.AddWithValue("@Nom", this.dgridview_editeur.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@ID", this.dgridview_editeur.CurrentRow.Cells[0].Value.ToString());
            //Exécution de la requête
            cmd.ExecuteNonQuery();
            //Fermeture de la connexion
            con.Close();
            //Affichage d'un message de confirmation
            MessageBox.Show("Modification réussie");

        }

        private void btn_supprEditeur_Click(object sender, EventArgs e){
            if (this.dgridview_editeur.SelectedRows.Count > 0){
                //Création de la connexion
                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                //Ouverture de la connexion
                con.Open();
                //Création de la requête
                SqlCommand cmd = new SqlCommand("DELETE FROM editor WHERE name_editor = @Nom", con);
                //Création des paramètres
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_editeur.CurrentRow.Cells[1].Value.ToString());
                //Exécution de la requête
                cmd.ExecuteNonQuery();
                //Fermeture de la connexion
                con.Close();
                //Suppression de la ligne dataGridView
                dgridview_editeur.Rows.RemoveAt(this.dgridview_editeur.SelectedRows[0].Index);
            }
        }

        private void btn_accueilEditeur_Click(object sender, EventArgs e){
            //Création du formulaire accueil
            Accueil accueil = new Accueil();
            //Affichage du formulaire
            accueil.Show();
            //Fermeture du formulaire actuel
            Close();
        }

        private void txtbox_searchEditeur_TextChanged(object sender, EventArgs e){
            //Création de la requête
            var select = "SELECT id_editor AS 'ID', name_editor AS 'Nom Éditeur' FROM editor WHERE name_editor LIKE '%" + txtbox_searchEditeur.Text + "%';";
            //Création de la connexion
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            //Liaison de la requête et de la connexion
            var dataAdapter = new SqlDataAdapter(select, c);
            //Affectation des paramètres
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Nom", txtbox_searchEditeur.Text);
            //Création de la commande de remplissage
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //Création d'un dataSet
            var ds = new DataSet();
            //Remplissage du dataSet
            dataAdapter.Fill(ds);
            //Remplissage de la liste
            dgridview_editeur.DataSource = ds.Tables[0];
        }

        

    }
}
