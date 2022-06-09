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
    public partial class ListeStatuts : Form
    {
        public ListeStatuts()
        {
            InitializeComponent();
        }

 

        private void txtbox_searchStatut_TextChanged(object sender, EventArgs e)
        {
            var select = "SELECT id_status AS 'ID', name_status AS 'Nom du status' FROM status WHERE name_status LIKE '%' + @Nom + '%'; ";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Nom", txtbox_searchStatut.Text);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_statut.DataSource = ds.Tables[0];
        }

        private void btn_ajoutStatut_Click(object sender, EventArgs e)
        {
            AjoutStatut ajoutstatut = new AjoutStatut();
            ajoutstatut.ShowDialog();
            Close();
        }

        private void btn_modifStatut_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE status set name_status = @Nom where id_status = @ID", con);
            cmd.Parameters.AddWithValue("@Nom", this.dgridview_statut.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@ID", this.dgridview_statut.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Modification réussie");
        }

        private void btn_supprStatut_Click(object sender, EventArgs e)
        {
            //Vérifie si une ligne est sélectionnée
            if (this.dgridview_statut.SelectedRows.Count > 0)
            {
                //Création de la connexion
                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                //Ouverture de la connexion
                con.Open();
                //Création de la requête
                SqlCommand cmd = new SqlCommand("DELETE FROM status WHERE name_status = @Nom", con);
                //Affectation des paramètres
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_statut.CurrentRow.Cells[1].Value.ToString());
                //Exécution de la commande
                cmd.ExecuteNonQuery();
                //Fermeture de la connexion
                con.Close();
                //Suppression de la ligne séléctionnée dans le datagridView
                dgridview_statut.Rows.RemoveAt(this.dgridview_statut.SelectedRows[0].Index);
            }
        }

        private void btn_accueilStatut_Click(object sender, EventArgs e)
        {
            //Création d'une instance de la fenêtre Accueil
            Accueil accueil = new Accueil();
            //Affichage de la fenêtre Accueil
            accueil.Show();
            //Fermeture de la fenêtre ListeGenres
            Close();
        }

        private void ListeStatuts_Load_1(object sender, EventArgs e)
        {
            var select = "SELECT id_status as 'ID', name_status as 'Nom du status' FROM status";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_statut.DataSource = ds.Tables[0];

        }
    }
}
