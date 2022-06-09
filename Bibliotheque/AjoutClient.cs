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
    public partial class AjoutClient : Form
    {
        public AjoutClient()
        {
            InitializeComponent();
        }


        private void btn_ajouterAuteur_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO client (name_client,fname_client,phone_client,town_client) VALUES (@Nom,@Prenom, @Telephone, @Ville)", con);
            cmd.Parameters.AddWithValue("@Nom", txtbox_nom_client.Text);
            cmd.Parameters.AddWithValue("@Prenom", txtbox_prenom_client.Text);
            cmd.Parameters.AddWithValue("@Telephone", txtbox_telephone_client.Text);
            cmd.Parameters.AddWithValue("@Ville", txtbox_ville_client.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            Close();

            ListeClients listeClients = new ListeClients();
            listeClients.Show();
            MessageBox.Show("La création a été effectuée");
        }

        private void txtbox_telephone_client_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_telephone_client_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtbox_ville_client_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_ville_client_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_annulerAuteur_Click(object sender, EventArgs e)
        {
            Close();

            ListeClients listeClients = new ListeClients();
            listeClients.Show();
        }
    }
}
