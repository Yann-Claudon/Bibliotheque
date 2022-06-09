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
    public partial class ListeEditeurs : Form
    {
        public ListeEditeurs()
        {
            InitializeComponent();
        }

        private void ListeEditeurs_Load(object sender, EventArgs e)
        {
            var select = "SELECT id_editor as 'ID', name_editor as 'Nom Éditeur' FROM editor";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_editeur.DataSource = ds.Tables[0];

        }

        private void btn_ajoutEditeur_Click(object sender, EventArgs e)
        {
            AjoutEditeur ajoutEditeur = new AjoutEditeur();
            ajoutEditeur.ShowDialog();
            Close();
        }

        private void btn_modifEditeur_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE editor set name_editor = @Nom where id_editor = @ID", con);
            cmd.Parameters.AddWithValue("@Nom", this.dgridview_editeur.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@ID", this.dgridview_editeur.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Modification réussie");

        }

        private void btn_supprEditeur_Click(object sender, EventArgs e)
        {
            if (this.dgridview_editeur.SelectedRows.Count > 0)
            {

                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM editor WHERE name_editor = @Nom", con);
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_editeur.CurrentRow.Cells[1].Value.ToString());
                cmd.ExecuteNonQuery();

                con.Close();

                dgridview_editeur.Rows.RemoveAt(this.dgridview_editeur.SelectedRows[0].Index);
            }
        }

        private void btn_accueilEditeur_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            Close();
        }

        private void txtbox_searchEditeur_TextChanged(object sender, EventArgs e)
        {
            var select = "SELECT id_editor AS 'ID', name_editor AS 'Nom Éditeur' FROM editor WHERE name_editor LIKE '%" + txtbox_searchEditeur.Text + "%';";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Nom", txtbox_searchEditeur.Text);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_editeur.DataSource = ds.Tables[0];
        }

        

    }
}
