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
using System.Configuration;

namespace Bibliotheque{
    public partial class AjoutLivre : Form{
        public AjoutLivre(){
            InitializeComponent();
        }

        /*Chargement des données dans les combobox du formulaire
         * 
         */
        private void AjoutLivre_Load(object sender, EventArgs e){
            // TODO: cette ligne de code charge les données dans la table 'bibliothequeBDD.book'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.bookTableAdapter.Fill(this.bibliothequeBDD.book);

            load_Combobox("genre", cmbbox_genre, "Genre du livre");
            load_Combobox("editor", cmbbox_edition, "Editeur du livre");
            load_Combobox("status", cmbbox_etat, "Etat du livre");
            load_Combobox("format", cmbbox_format, "Format du livre");
            load_Combobox("author", cmbbox_auteur, "Auteur du livre");
        }

        
        /*Fonction permettant de charger les données dans les combobox du formulaire
         * String table : represente le nom de la table d'ou provienent les données 
         * ComboBox cmbbox : repreesente la combox
         * String placeholder : represente la valeur par défaut de la combobox
         * Retourne l'id et le nom de la table choisis 
         */
        private void load_Combobox(String table, ComboBox cmbbox, String placeholder){
            using (SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True")){
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id_" +table+",name_"+table+" FROM " + table, con)){
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    //Insert the Default Item to DataTable.
                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = placeholder;
                    dt.Rows.InsertAt(row, 0);
                    //Assign DataTable as DataSource.
                    cmbbox.DataSource = dt;
                    cmbbox.DisplayMember = "name_"+table;
                    cmbbox.ValueMember = "name_"+table;
                }
            }
        }
        
        /*Ferme le formulaire en cours lors du clic sur le bouton retour
         */
        private void btn_annuler_Click(object sender, EventArgs e){
            Close();
            ListeLivres listeLivres = new ListeLivres();
            listeLivres.Show();
        }

        /*Ajout d'un livre dans la base de données lors du clic sur le bouton "Ajouter"
         *Nom
         *Date Publication
         *Genre
         *Editeur
         *Auteur
         *Format
         *Etat
         */
        private void btn_ajout_Click(object sender, EventArgs e){
            
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmdgenre = new SqlCommand("SELECT id_genre FROM genre WHERE name_genre LIKE '" + cmbbox_genre.Text + "'", con);
            SqlDataReader drgenre = cmdgenre.ExecuteReader();
            drgenre.Read();
            int id_genre = Convert.ToInt32(drgenre["id_genre"]);
            drgenre.Close();
           
            SqlCommand cmdetat = new SqlCommand("SELECT id_status FROM status WHERE name_status LIKE '" + cmbbox_etat.Text + "'", con);
            SqlDataReader dretat = cmdetat.ExecuteReader();
            dretat.Read();
            int id_etat = Convert.ToInt32(dretat["id_status"]);
            dretat.Close();
            
            SqlCommand cmdediteur = new SqlCommand("SELECT id_editor FROM editor WHERE name_editor LIKE '" + cmbbox_edition.Text + "'", con);
            SqlDataReader drediteur = cmdediteur.ExecuteReader();
            drediteur.Read();
            int id_editeur = Convert.ToInt32(drediteur["id_editor"]);
            drediteur.Close();
            
            SqlCommand cmdauteur = new SqlCommand("SELECT id_author FROM author WHERE name_author LIKE '" + cmbbox_auteur.Text + "'", con);
            SqlDataReader drauteur = cmdauteur.ExecuteReader();
            drauteur.Read();
            int id_auteur = Convert.ToInt32(drauteur["id_author"]);
            drauteur.Close();
            
            SqlCommand cmdformat = new SqlCommand("SELECT id_format FROM format WHERE name_format LIKE '" + cmbbox_format.Text + "'", con);
            SqlDataReader drformat = cmdformat.ExecuteReader();
            drformat.Read();
            int id_format = Convert.ToInt32(drformat["id_format"]);
            drformat.Close();

            //Insertion des données dans la table book en fonction des valeurs entrés des combobox
            SqlCommand cmd = new SqlCommand("INSERT INTO book (name_book,publish_date_book,fk_genre_book,fk_editor_book,fk_author_book,fk_format_book,fk_status_book) values (@Nom,@DatePublication,@Genre,@Editeur,@Auteur,@Format,@Status)", con);
            cmd.Parameters.AddWithValue("@Nom", txtbox_nom.Text);
            cmd.Parameters.AddWithValue("@DatePublication", txtbox_datePublication.Text);
            cmd.Parameters.AddWithValue("@Genre", id_genre);
            cmd.Parameters.AddWithValue("@Editeur", id_editeur);
            cmd.Parameters.AddWithValue("@Auteur", id_auteur);
            cmd.Parameters.AddWithValue("@Format", id_format);
            cmd.Parameters.AddWithValue("@Status", id_etat);

            // Vérification si le livre existe déjà dans la base de données
            SqlCommand cmdverif = new SqlCommand("SELECT name_book, publish_date_book, fk_genre_book, fk_editor_book, fk_author_book, fk_format_book, fk_status_book FROM book WHERE name_book LIKE '" + txtbox_nom.Text + "'AND publish_date_book LIKE '" + txtbox_datePublication + "' AND fk_genre_book LIKE '"+ id_genre + "AND fk_editor_book LIKE '" + id_genre + "AND fk_author_book LIKE '"+id_auteur+ "AND fk_format_book LIKE '"+id_format+ "AND fk_status_book LIKE"+id_etat, con);
            SqlDataReader drverif = cmdverif.ExecuteReader();
            drverif.Read();
            if (!drverif.HasRows){
                drverif.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livre ajouté avec succès");
                Close();
                ListeLivres listeLivres = new ListeLivres();
                listeLivres.Show();
            }
            else{
                MessageBox.Show("Erreur lors de l'ajout du livre");
            }
        }

        /*Restreint la saisie des caractères autorisés dans le champs de texte date publication, autorise uniquement les caractères numériques
         */
        private void txtbox_datePublication_KeyPress(object sender, KeyPressEventArgs e){
            // Verifié que la valeur entrée est un chiffre
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')){
                e.Handled = true;
            }
        }
    }
}
