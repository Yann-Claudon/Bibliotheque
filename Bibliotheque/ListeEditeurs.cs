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
            // TODO: cette ligne de code charge les données dans la table 'bibliothequeBDD.editor'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.editorTableAdapter.Fill(this.bibliothequeBDD.editor);

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
                SqlCommand cmd = new SqlCommand("DELETE FROM author WHERE name_author = @Nom", con);
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_editeur.CurrentRow.Cells[1].Value.ToString());
                cmd.ExecuteNonQuery();

                con.Close();

                dgridview_editeur.Rows.RemoveAt(this.dgridview_editeur.SelectedRows[0].Index);
            }
        }

        private void btn_accueil_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            Close();
        }
    }
}
