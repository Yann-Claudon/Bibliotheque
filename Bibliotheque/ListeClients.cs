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
    public partial class ListeClients : Form
    {
        public ListeClients()
        {
            InitializeComponent();
        }

        private void ListeClients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bibliothequeDataSet1.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.bibliothequeDataSet1.client);
        }

        private void dgridview_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ajoutClient_Click(object sender, EventArgs e)
        {
            //Ouvre le formulaire d'ajout d'un auteur
            AjoutClient ajoutClient = new AjoutClient();
            ajoutClient.Show();
            Close();
        }

        private void btn_accueil_clients_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            Close();
        }

        private void btn_supprClient_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.dgridview_auteur.CurrentCell.ColumnIndex.ToString());

            if (this.dgridview_client.SelectedRows.Count > 0)
            {

                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM client WHERE name_client = @Nom AND fname_client = @Prenom", con);
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_client.CurrentRow.Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@Prenom", this.dgridview_client.CurrentRow.Cells[2].Value.ToString());
                cmd.ExecuteNonQuery();

                con.Close();

                dgridview_client.Rows.RemoveAt(this.dgridview_client.SelectedRows[0].Index);
            }
        }
    }
}
