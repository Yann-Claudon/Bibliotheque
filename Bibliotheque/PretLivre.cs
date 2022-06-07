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
    public partial class PretLivre : Form{
        /*
         * Initialise le Form PretLivre
         */
        public PretLivre(){
            InitializeComponent();
        }

        /*Fonction permettant de charger les données dans les combobox du formulaire
         * String table : represente le nom de la table d'ou provienent les données 
         * ComboBox cmbbox : repreesente la combox
         * String placeholder : represente la valeur par défaut de la combobox
         * Retourne l'id et le nom de la table choisis 
         */
        private void load_Combobox(String table, ComboBox cmbbox, String placeholder){
            using (SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True")){
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id_" + table + ",name_" + table + " FROM " + table, con)){
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
                    cmbbox.DisplayMember = "name_" + table;
                    cmbbox.ValueMember = "name_" + table;
                }
            }
        }

        /*
         * Charge les données dans les combobox du formulaire
         */
        private void PretLivre_Load(object sender, EventArgs e){
            load_Combobox("client", cmbbox_nomClient, "Nom du client");
            load_Combobox("book", cmbbox_livre, "Nom du livre");
        }

        /*
         * Ferme le formulaire lors du clic sur le bouton annuler
         */
        private void btn_annulerAuteur_Click(object sender, EventArgs e){
            Close();
        }

        /*
        * Insére les données dans la table pret quand le bouton valider est cliqué
        */
        private void btn_ajouterAuteur_Click(object sender, EventArgs e){
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmdbook = new SqlCommand("SELECT id_book FROM book WHERE name_book LIKE '" + cmbbox_livre.Text + "'", con);
            SqlDataReader drgbook = cmdbook.ExecuteReader();
            drgbook.Read();
            int id_book = Convert.ToInt32(drgbook["id_book"]);
            drgbook.Close();

            SqlCommand cmdclient = new SqlCommand("SELECT id_client FROM client WHERE name_client LIKE '" + cmbbox_nomClient.Text + "'", con);
            SqlDataReader drclient = cmdclient.ExecuteReader();
            drclient.Read();
            int id_client = Convert.ToInt32(drclient["id_client"]);
            drclient.Close();

            SqlCommand cmd = new SqlCommand("INSERT INTO loan(fk_book_loan,first_date_loan, last_date_loan, fk_client_loan) VALUES(@id_book,@date_pret,@date_retour,@id_client)", con);
            cmd.Parameters.AddWithValue("@id_book", id_book);
            cmd.Parameters.AddWithValue("@date_pret", date_pret.Value);
            cmd.Parameters.AddWithValue("@date_retour", date_retour.Value);
            cmd.Parameters.AddWithValue("@id_client", id_client);          
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Livre prêté avec succès");
            Close();
        }
    }
}
