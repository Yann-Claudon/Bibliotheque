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
    public partial class AjoutStatut : Form
    {
        public AjoutStatut()
        {
            InitializeComponent();
        }

        private void btn_ajouterStatut_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into status (name_status) values (@Nom)", con);
            cmd.Parameters.AddWithValue("@Nom", txtbox_nom.Text);

            SqlCommand cmdverif = new SqlCommand("SELECT name_status FROM status WHERE name_status LIKE '" + txtbox_nom.Text + "'", con);
            SqlDataReader drverif = cmdverif.ExecuteReader();
            drverif.Read();
            if (!drverif.HasRows)
            {
                drverif.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Statut ajouté avec succès");
                con.Close();
                Close();
                ListeStatuts listeStatuts = new ListeStatuts();
                listeStatuts.Show();
            }
            else
            {
                con.Close();
                MessageBox.Show("Erreur lors de l'ajout du livre");
            }
        }

        private void btn_annulerStatut_Click(object sender, EventArgs e)
        {
            Close();
            ListeStatuts listeStatuts = new ListeStatuts();
            listeStatuts.Show();
        }
    }
}
