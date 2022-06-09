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
    public partial class ListeEmprunt : Form{
        /*
         * Constructeur
         */
        public ListeEmprunt(){
            InitializeComponent();
        }
        /*
         * Affiche le formulaire de pret d'un livre
         */
        private void btn_pretLivre_Click(object sender, EventArgs e){
            PretLivre pretLivre = new PretLivre();
            pretLivre.ShowDialog();
            Close();
        }
        /*
         * Ferme la page actuelle et ouvre la page d'accueil
         */
        private void btn_accueil_Click(object sender, EventArgs e){
            Accueil accueil = new Accueil();
            accueil.ShowDialog();
            Close();
        }

        /*
         * Charge les données des tables book, genre, author, format, editor, status, loan et client pour pouvoir les afficher dans le DataGridView
         */
        private void ListeEmprunt_Load(object sender, EventArgs e){
            var select = "SELECT id_book AS 'ID livre', name_book AS 'Nom du livre', name_genre AS 'Genre',name_status AS 'Etat', name_client AS 'Nom emprunteur',first_date_loan AS 'Date de prêt', last_date_loan AS 'Date de retour' FROM book INNER JOIN genre ON book.fk_genre_book = genre.id_genre INNER JOIN author ON book.fk_author_book = author.id_author INNER JOIN format ON book.fk_format_book = format.id_format INNER JOIN editor ON book.fk_editor_book = editor.id_editor INNER JOIN status ON book.fk_status_book = status.id_status INNER JOIN loan ON book.id_book = loan.fk_book_loan INNER JOIN client ON loan.fk_client_loan = client.id_client ; ";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); 
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_livre.DataSource = ds.Tables[0];
        }
        /*
         * Recherche d'un emprunt en fonction du nom livre ou date de retour entré dans le champ de recherche et l'affiche dans le DataGridView
         */
        private void txtbox_recherche_TextChanged(object sender, EventArgs e){
            var select = "SELECT id_book AS 'ID livre', name_book AS 'Nom du livre', name_genre AS 'Genre',name_status AS 'Etat', name_client AS 'Nom emprunteur',first_date_loan AS 'Date de prêt', last_date_loan AS 'Date de retour' FROM book INNER JOIN genre ON book.fk_genre_book = genre.id_genre INNER JOIN author ON book.fk_author_book = author.id_author INNER JOIN format ON book.fk_format_book = format.id_format INNER JOIN editor ON book.fk_editor_book = editor.id_editor INNER JOIN status ON book.fk_status_book = status.id_status INNER JOIN loan ON book.id_book = loan.fk_book_loan INNER JOIN client ON loan.fk_client_loan = client.id_client WHERE name_book LIKE '%' + @Nom + '%' OR  last_date_loan LIKE '%' + @Dateretour + '%';";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            var dataAdapter = new SqlDataAdapter(select, c);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Nom", txtbox_recherche.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Dateretour", txtbox_recherche.Text);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_livre.DataSource = ds.Tables[0];

        }
        /*
         * Affiche le formulaire de retour d'un livre
         */
        private void btn_retourLivre_Click(object sender, EventArgs e)
        {
            RetourLivre retourLivre = new RetourLivre();
            retourLivre.ShowDialog();
            Close();
        }

        /*
         * Ouvre une boite de dialogue pour choisir son imprimante puis une boite de dialogue de prévisualisation de l'impression
         */
        Bitmap bmp;
        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Width, this.Height);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        /*
         * Imprime le Form
         */
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
