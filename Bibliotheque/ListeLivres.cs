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
    public partial class ListeLivres : Form{
        /*
         * Initialise le Form ListeLivres
         */
        public ListeLivres(){
            InitializeComponent();
        }

        /*
         * Charge les données des tables book, genre, author, format, editor, status pour pouvoir les afficher dans le DataGridView
         */
        private void ListeLivres_Load(object sender, EventArgs e){

            var select = "SELECT id_book AS 'ID livre', name_book AS 'Nom du livre', publish_date_book AS 'Date de publication', name_genre AS 'Genre', name_editor AS 'Editeur', name_author AS 'Auteur', name_format AS 'Format', name_status AS 'Etat' FROM book INNER JOIN genre ON book.fk_genre_book = genre.id_genre INNER JOIN author ON book.fk_author_book = author.id_author INNER JOIN format ON book.fk_format_book = format.id_format INNER JOIN editor ON book.fk_editor_book = editor.id_editor INNER join status ON book.fk_status_book = status.id_status; ";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_livre.DataSource = ds.Tables[0];

        }

        /*
         * Affiche le Form Accueil lors du clic sur le bouton "accueil"
         */
        private void btn_accueil_Click(object sender, EventArgs e){
            Accueil accueil = new Accueil();
            accueil.Show();
            Close();
        }

        /*
         * Affiche le Form AjoutLivre lors du clic sur le bouton "ajout livre"
         */
        private void btn_ajoutLivre_Click(object sender, EventArgs e){
            AjoutLivre ajoutLivre = new AjoutLivre();
            ajoutLivre.ShowDialog();
            Close();
        }


        /*
         * Supprime le livre sélectionné dans le DataGridView lors du clic sur le bouton "supprimer"
         */
        private void btn_supressionLivre_Click(object sender, EventArgs e){
            if (this.dgridview_livre.SelectedRows.Count > 0){          
                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM book WHERE id_book = @Id", con);
                cmd.Parameters.AddWithValue("@Id", this.dgridview_livre.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                dgridview_livre.Rows.RemoveAt(this.dgridview_livre.SelectedRows[0].Index);

            }
        }

        /*
         * Modifie le livre sélectionné dans le DataGridView lors du clic sur le bouton "modifier"
         */
        private void btn_modifier_Click(object sender, EventArgs e){ 
            
            if (this.dgridview_livre.SelectedRows.Count > 0){
                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                con.Open();
                SqlCommand cmdgenre = new SqlCommand("SELECT id_genre FROM genre WHERE name_genre LIKE '" + this.dgridview_livre.CurrentRow.Cells[3].Value.ToString() + "'", con);
                SqlDataReader drgenre = cmdgenre.ExecuteReader();
                drgenre.Read();
                int id_genre = Convert.ToInt32(drgenre["id_genre"]);
                drgenre.Close();

                SqlCommand cmdetat = new SqlCommand("SELECT id_status FROM status WHERE name_status LIKE '" + this.dgridview_livre.CurrentRow.Cells[7].Value.ToString() + "'", con);
                SqlDataReader dretat = cmdetat.ExecuteReader();
                dretat.Read();
                int id_etat = Convert.ToInt32(dretat["id_status"]);
                dretat.Close();

                SqlCommand cmdediteur = new SqlCommand("SELECT id_editor FROM editor WHERE name_editor LIKE '" + this.dgridview_livre.CurrentRow.Cells[4].Value.ToString() + "'", con);
                SqlDataReader drediteur = cmdediteur.ExecuteReader();
                drediteur.Read();
                int id_editeur = Convert.ToInt32(drediteur["id_editor"]);
                drediteur.Close();

                SqlCommand cmdauteur = new SqlCommand("SELECT id_author FROM author WHERE name_author LIKE '" + this.dgridview_livre.CurrentRow.Cells[5].Value.ToString() + "'", con);
                SqlDataReader drauteur = cmdauteur.ExecuteReader();
                drauteur.Read();
                int id_auteur = Convert.ToInt32(drauteur["id_author"]);
                drauteur.Close();

                SqlCommand cmdformat = new SqlCommand("SELECT id_format FROM format WHERE name_format LIKE '" + this.dgridview_livre.CurrentRow.Cells[6].Value.ToString() + "'", con);
                SqlDataReader drformat = cmdformat.ExecuteReader();
                drformat.Read();
                int id_format = Convert.ToInt32(drformat["id_format"]);
                drformat.Close();

                SqlCommand cmd = new SqlCommand("UPDATE book SET name_book = @Nom, publish_date_book = @Publication, fk_genre_book = @Genre, fk_author_book = @Auteur, fk_format_book = @Format, fk_editor_book = @Editeur, fk_status_book = @Etat WHERE id_book = @ID", con);
                cmd.Parameters.AddWithValue("@ID", this.dgridview_livre.CurrentRow.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_livre.CurrentRow.Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@DatePublication", this.dgridview_livre.CurrentRow.Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@Genre", id_genre);
                cmd.Parameters.AddWithValue("@Editeur", id_editeur);
                cmd.Parameters.AddWithValue("@Auteur", id_auteur);
                cmd.Parameters.AddWithValue("@Format", id_format);
                cmd.Parameters.AddWithValue("@Status", id_etat);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modification du livre effectué");
            }
        }


        /*
         * Recherche un livre en fonction de son nom entré dans le champ de recherche et l'affiche dans le DataGridView
         */
        private void txtbox_recherche_TextChanged(object sender, EventArgs e){
            var select = "SELECT id_book AS 'ID livre', name_book AS 'Nom du livre', publish_date_book AS 'Date de publication', name_genre AS 'Genre', name_editor AS 'Editeur', name_author AS 'Auteur', name_format AS 'Format', name_status AS 'Etat' FROM book INNER JOIN genre ON book.fk_genre_book = genre.id_genre INNER JOIN author ON book.fk_author_book = author.id_author INNER JOIN format ON book.fk_format_book = format.id_format INNER JOIN editor ON book.fk_editor_book = editor.id_editor INNER join status ON book.fk_status_book = status.id_status WHERE name_book LIKE '%' + @Nom + '%'; ";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Nom", txtbox_recherche.Text);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_livre.DataSource = ds.Tables[0];

        }
    }
}
