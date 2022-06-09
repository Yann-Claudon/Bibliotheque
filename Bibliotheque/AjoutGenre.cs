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
    public partial class AjoutGenre : Form
    {
        public AjoutGenre()
        {
            InitializeComponent();
        }

        private void btn_ajouterGenre_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into genre (name_genre) values (@Nom)", con);
            cmd.Parameters.AddWithValue("@Nom", txtbox_nom.Text);

            SqlCommand cmdverif = new SqlCommand("SELECT name_genre FROM genre WHERE name_genre LIKE '" + txtbox_nom.Text + "'", con);
            SqlDataReader drverif = cmdverif.ExecuteReader();
            drverif.Read();
            if (!drverif.HasRows)
            {
                drverif.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Genre ajouté avec succès");
                con.Close();
                Close();
                ListeGenres listeGenres = new ListeGenres();
                listeGenres.Show();
            }
            else
            {
                con.Close();
                MessageBox.Show("Erreur lors de l'ajout du livre");
            }
        }

        private void btn_annulerGenre_Click(object sender, EventArgs e)
        {
            Close();
            ListeGenres listeGenres = new ListeGenres();
            listeGenres.Show();
        }
    }
}
