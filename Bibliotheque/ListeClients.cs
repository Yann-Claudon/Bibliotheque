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

namespace Bibliotheque{//pour les teuteus
    public partial class ListeClients : Form
    {

        string connstring = "Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True";
        public ListeClients(){
            InitializeComponent();
        }

        private void ListeClients_Load(object sender, EventArgs e){
            // TODO: cette ligne de code charge les données dans la table 'bibliothequeDataSet1.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.clientTableAdapter.Fill(this.bibliothequeDataSet1.client); <== méthode plus rapide :(

            var select = "SELECT id_client AS 'ID Client', name_client AS 'Nom du client', fname_client AS 'Prénom client',phone_client AS 'Téléphone', town_client AS 'Code postal' FROM client";
                var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                var dataAdapter = new SqlDataAdapter(select, c);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgridview_client.DataSource = ds.Tables[0];
       
        }


        /*
         * Ouvre le formulaire d'ajout client
         */
        private void btn_ajoutClient_Click(object sender, EventArgs e){
            
            AjoutClient ajoutClient = new AjoutClient();
            ajoutClient.ShowDialog();
            Close();
            
        }

        /*
         * Retour à l'acceuil
         */
        private void btn_accueil_clients_Click(object sender, EventArgs e){
            Accueil accueil = new Accueil();
            accueil.Show();
            Close();
        }

        /*
         * fonction modification d'un client
         */
        private void btn_modif_client_Click_1(object sender, EventArgs e){
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE client set name_client = @Nom, fname_client = @Prenom, phone_client = @Telephone, town_client = @Ville where id_client = @ID", con);
            cmd.Parameters.AddWithValue("@ID", this.dgridview_client.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@Nom", this.dgridview_client.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@Prenom", this.dgridview_client.CurrentRow.Cells[2].Value.ToString());
            cmd.Parameters.AddWithValue("@Telephone", this.dgridview_client.CurrentRow.Cells[3].Value.ToString());
            cmd.Parameters.AddWithValue("@Ville", this.dgridview_client.CurrentRow.Cells[4].Value.ToString());
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Modification réussie");
        }

        /*
         * Suppression d'un client
         */
        private void btn_supprClient_Click(object sender, EventArgs e){
            //MessageBox.Show(this.dgridview_auteur.CurrentCell.ColumnIndex.ToString());

            if (this.dgridview_client.SelectedRows.Count > 0){

                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM client WHERE name_client = @Nom AND fname_client = @Prenom", con);
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_client.CurrentRow.Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@Prenom", this.dgridview_client.CurrentRow.Cells[2].Value.ToString());
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Le client a été supprimé");                

                dgridview_client.Rows.RemoveAt(this.dgridview_client.SelectedRows[0].Index);
            }
        }
        /*
         * Fonction rechercher un client
         */
        private void txtbox_recherche_client_TextChanged(object sender, EventArgs e){
            var select = "SELECT id_client AS 'ID Client', name_client AS 'Nom du client', fname_client AS 'Prénom client', phone_client AS 'Téléphone client', town_client AS 'Ville client' FROM client WHERE name_client LIKE '%' + @Nom + '%'; ";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Nom", txtbox_recherche_client.Text);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_client.DataSource = ds.Tables[0];
        }
    }
}
