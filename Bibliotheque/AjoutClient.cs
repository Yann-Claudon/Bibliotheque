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
    public partial class AjoutClient : Form{
        public AjoutClient(){ //pour les teuteus
            InitializeComponent();
        }

        /*
         * Fonction qui ajoute la saisie du formulaire ajout client dans la base de données lors du click sur le bouton "ajouter"
         */
        private void btn_ajouterClient_Click(object sender, EventArgs e){
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO client (name_client,fname_client,phone_client,town_client) VALUES (@Nom,@Prenom, @Telephone, @Ville)", con);
            cmd.Parameters.AddWithValue("@Nom", txtbox_nom_client.Text);
            cmd.Parameters.AddWithValue("@Prenom", txtbox_prenom_client.Text);
            cmd.Parameters.AddWithValue("@Telephone", txtbox_telephone_client.Text);
            cmd.Parameters.AddWithValue("@Ville", txtbox_ville_client.Text);
           
            SqlCommand cmdverif = new SqlCommand("SELECT name_client, fname_client, phone_client, town_client FROM client WHERE name_client LIKE @Nom AND fname_client = @Prenom AND phone_client = @Telephone AND town_client = @Ville", con);
            cmdverif.Parameters.AddWithValue("@Nom", txtbox_nom_client.Text);
            cmdverif.Parameters.AddWithValue("@Prenom", txtbox_prenom_client.Text);
            cmdverif.Parameters.AddWithValue("@Telephone", txtbox_telephone_client.Text);
            cmdverif.Parameters.AddWithValue("@Ville", txtbox_ville_client.Text);
            SqlDataReader drverif = cmdverif.ExecuteReader();
            drverif.Read();
            if (!drverif.HasRows){
                drverif.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client ajouté avec succès");
                Close();
                ListeClients listeClients = new ListeClients();
                listeClients.Show();
            }
            else {
                MessageBox.Show("Le client existe déjà");
            }
        }


        /*
         * Fonction qui vérifie si la saisie du telephone est un nombre
         */
        private void txtbox_telephone_client_KeyPress(object sender, KeyPressEventArgs e){
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')){
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)){
                e.Handled = true;
            }
        }


        /*
         * Fonction qui vérifie si la saisie du code postal est un nombre
         */

        private void txtbox_ville_client_KeyPress(object sender, KeyPressEventArgs e){
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')){
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)){
                e.Handled = true;
            }
        }

        /*
         * Bouton annuler
         * Ferme le formulaire
         */
        private void btn_annulerClient_Click(object sender, EventArgs e){
            Close();
        }
    }
}
