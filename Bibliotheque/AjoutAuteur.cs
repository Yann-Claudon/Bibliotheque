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
    public partial class AjoutAuteur : Form
    {
        public AjoutAuteur()
        {
            InitializeComponent();
        }
        

        private void btn_ajouterAuteur_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into author (name_author,birthday_author) values (@Nom,@Naissance)", con);
            cmd.Parameters.AddWithValue("@Nom", txtbox_nom.Text);
            cmd.Parameters.AddWithValue("@Naissance", txtbox_naissance.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            Close();
            ListeAuteurs listeAuteurs = new ListeAuteurs();
            listeAuteurs.Show();
            MessageBox.Show("La création a été effectuée");
            
        }

        private void txtbox_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_annulerAuteur_Click(object sender, EventArgs e)
        {
            Close();
            ListeAuteurs listeAuteurs = new ListeAuteurs();
            listeAuteurs.Show();
        }
    }
}
