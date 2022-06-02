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
    
    public partial class ListeAuteurs : Form
    {
        string connstring = "Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True";
        public ListeAuteurs()
        {
            InitializeComponent();
        }

        private void Auteur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bibliothequeDataSet.author'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.authorTableAdapter.Fill(this.bibliothequeDataSet.author);

        }

        private void btn_ajoutAuteur_Click(object sender, EventArgs e)
        {
            //Ouvre le formulaire d'ajout d'un auteur
            AjoutAuteur ajoutAuteur = new AjoutAuteur();
            ajoutAuteur.ShowDialog();
            Close();
            
        }

        private void btn_supprAuteur_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.dgridview_auteur.CurrentCell.ColumnIndex.ToString());

            if (this.dgridview_auteur.SelectedRows.Count > 0)
            {

                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM author WHERE name_author = @Nom AND birthday_author = @Naissance", con);
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_auteur.CurrentRow.Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@Naissance", this.dgridview_auteur.CurrentRow.Cells[2].Value.ToString());
                cmd.ExecuteNonQuery();

                con.Close();

                dgridview_auteur.Rows.RemoveAt(this.dgridview_auteur.SelectedRows[0].Index);
            }
        }

        private void btn_accueil_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            Close();
        }

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("connstring");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM author", con);
            SqlDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                this.comboBox1.Items.Add(sqlReader["name_author"].ToString());
            }

            sqlReader.Close();
        }*/

        private void btn_modif_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE author set name_author = @Nom, birthday_author = @Naissance where id_author = @ID", con);
            cmd.Parameters.AddWithValue("@Nom", this.dgridview_auteur.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@Naissance", this.dgridview_auteur.CurrentRow.Cells[2].Value.ToString());
            cmd.Parameters.AddWithValue("@ID", this.dgridview_auteur.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Modification réussie");
        }
    }
}
