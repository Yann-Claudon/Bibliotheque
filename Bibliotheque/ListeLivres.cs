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
        public ListeLivres(){
            InitializeComponent();
        }

        private void ListeLivres_Load(object sender, EventArgs e){

            var select = "SELECT id_book AS 'ID livre', name_book AS 'Nom du livre', publish_date_book AS 'Date de publication', name_genre AS 'Genre', name_editor AS 'Editeur', name_author AS 'Auteur', name_format AS 'Format', name_status AS 'Etat' FROM book INNER JOIN genre ON book.fk_genre_book = genre.id_genre INNER JOIN author ON book.fk_author_book = author.id_author INNER JOIN format ON book.fk_format_book = format.id_format INNER JOIN editor ON book.fk_editor_book = editor.id_editor INNER join status ON book.fk_status_book = status.id_status; ";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_livre.DataSource = ds.Tables[0];

        }

        private void btn_accueil_Click(object sender, EventArgs e){
            Accueil accueil = new Accueil();
            accueil.Show();
            Close();
        }

        private void btn_ajoutLivre_Click(object sender, EventArgs e){
            AjoutLivre ajoutLivre = new AjoutLivre();
            ajoutLivre.ShowDialog();
            Close();
        }

        /// <summary>
        /// Suppression d'un livre selectionné 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Modification d'un livre selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modifier_Click(object sender, EventArgs e){ 
            
            if (this.dgridview_livre.SelectedRows.Count > 0){
                SqlConnection con = new SqlConnection("Data Source =.\\sqlexpress; Initial Catalog = bibliotheque; Integrated Security = True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE book SET name_book = @Nom, publish_date_book = @Publication, fk_genre_book = @Genre, fk_author_book = @Auteur, fk_format_book = @Format, fk_editor_book = @Editeur, fk_status_book = @Etat WHERE id_book = @ID", con);
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_livre.CurrentRow.Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@ID", this.dgridview_livre.CurrentRow.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@Genre", this.dgridview_livre.CurrentRow.Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@Auteur", this.dgridview_livre.CurrentRow.Cells[5].Value.ToString());
                cmd.Parameters.AddWithValue("@Format", this.dgridview_livre.CurrentRow.Cells[6].Value.ToString());
                cmd.Parameters.AddWithValue("@Editeur", this.dgridview_livre.CurrentRow.Cells[4].Value.ToString());
                cmd.Parameters.AddWithValue("@Publication", this.dgridview_livre.CurrentRow.Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@Etat", this.dgridview_livre.CurrentRow.Cells[7].Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modification du livre effectué");
            }
        }
        
        /// <summary>
        /// Recherche d'un livre par son nom en fonction de ce qui est entré dans la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
