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
    public partial class AjoutLivre : Form
    {
        public AjoutLivre()
        {
            InitializeComponent();
        }

        private void AjoutLivre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bibliothequeBDD.book'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bookTableAdapter.Fill(this.bibliothequeBDD.book);

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbox_livre_Enter(object sender, EventArgs e)
        {

        }

        private void cmbbox_genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            //SqlCommand cmdgenre = new SqlCommand("SELECT fk_genre_book FROM book B INNER JOIN genre G ON G.id_genre = B.fk_genre_book WHERE name_genre LIKE " + cmbbox_genre.Text, con);
            SqlCommand cmdetat = new SqlCommand("SELECT fk_status_book FROM book B INNER JOIN genre G ON G.id_status = B.fk_status_book WHERE name_status LIKE " + cmbbox_etat.Text, con);
            SqlCommand cmdediteur = new SqlCommand("SELECT fk_editor_book FROM book B INNER JOIN genre G ON G.id_editor = B.fk_editor_book WHERE name_editor LIKE " + cmbbox_edition.Text, con);
            SqlCommand cmdauteur = new SqlCommand("SELECT fk_author_book FROM book B INNER JOIN genre G ON G.id_author = B.fk_author_book WHERE name_author LIKE " + cmbbox_auteur.Text, con);
            SqlCommand cmdformat = new SqlCommand("SELECT fk_format_book FROM book B INNER JOIN genre G ON G.id_format = B.fk_format_book WHERE name_format LIKE " + cmbbox_format.Text, con);
            
            SqlCommand cmd = new SqlCommand("insert into book (name_book,publish_date_book,fk_genre_book,fk_editor_book,fk_author_book,fk_format_book,fk_status_book values (@Nom,@DatePublication,@Genre,@Editeur,@Format,@Status)", con);
            cmd.Parameters.AddWithValue("@Nom", txtbox_nom.Text);
            //cmd.Parameters.AddWithValue("@Naissance", txtbox_naissance.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Le livre à été ajouté");

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
