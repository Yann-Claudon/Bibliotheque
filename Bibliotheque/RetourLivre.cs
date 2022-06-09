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
    public partial class RetourLivre : Form{
        public RetourLivre(){
            InitializeComponent();
        }

        //Fonction de remplissage des comboBox
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


        //Fonction de retour de livre
        private void btn_ajouterAuteur_Click(object sender, EventArgs e)
        {
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

            //requete selection du status
            SqlCommand cmdstatus = new SqlCommand("SELECT id_status FROM status WHERE name_status LIKE '" + cmbboxetat.Text + "'", con);
            SqlDataReader drstatus = cmdstatus.ExecuteReader();
            drstatus.Read();
            int id_status = Convert.ToInt32(drstatus["id_status"]);
            drstatus.Close();

            //Verification qu'un livre est emprunté
            SqlCommand cmdverif = new SqlCommand("SELECT id_loan FROM loan WHERE fk_book_loan = @id_book AND fk_client_loan = @id_client", con);
            cmdverif.Parameters.AddWithValue("@id_book", id_book);
            cmdverif.Parameters.AddWithValue("@id_client", id_client);
            SqlDataReader drverif = cmdverif.ExecuteReader();
            if (drverif.HasRows)
            {
                drverif.Read();
                int id_loan = Convert.ToInt32(drverif["id_loan"]);
                drverif.Close();
                //Modification du status du livre
                SqlCommand cmd = new SqlCommand("DELETE FROM loan WHERE fk_book_loan = @id_book AND fk_client_loan = @id_client", con);
                cmd.Parameters.AddWithValue("@id_book", id_book);
                cmd.Parameters.AddWithValue("@id_client", id_client);
                cmd.ExecuteNonQuery();
                //Modification du status du livre
                SqlCommand cmdStatut = new SqlCommand("UPDATE book SET fk_status_book = @id_status WHERE id_book = @id_book", con);
                cmdStatut.Parameters.AddWithValue("@id_book", id_book);
                cmdStatut.Parameters.AddWithValue("@id_status", id_status);
                cmdStatut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Retour du livre avec succès");
                ListeEmprunt liste = new ListeEmprunt();
                liste.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Ce livre n'est pas emprunté");
                con.Close();
            }
        }

            //Bouton pour annuler le retour d'un livre qui renvoie à la page liste des emprunts
        private void btn_annulerAuteur_Click(object sender, EventArgs e){
            ListeEmprunt liste = new ListeEmprunt();
            liste.Show();
            Close();
        }

        //Fonction de remplissage des comboBox
        private void RetourLivre_Load(object sender, EventArgs e){
            load_Combobox("client", cmbbox_nomClient, "Nom du client");
            load_Combobox("book", cmbbox_livre, "Nom du livre");
            load_Combobox("status", cmbboxetat, "Etat du livre");

        }
    }
}
