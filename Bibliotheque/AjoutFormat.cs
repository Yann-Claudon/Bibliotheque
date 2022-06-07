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
    public partial class AjoutFormat : Form
    {
        public AjoutFormat()
        {
            InitializeComponent();
        }

        private void btn_ajouterFormat_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into format (name_format) values (@Nom)", con);
            cmd.Parameters.AddWithValue("@Nom", txtbox_nom.Text);

            SqlCommand cmdverif = new SqlCommand("SELECT name_format FROM format WHERE name_format LIKE '"+ txtbox_nom.Text + "'", con);
            SqlDataReader drverif = cmdverif.ExecuteReader();
            drverif.Read();
            if (!drverif.HasRows)
            {
                drverif.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Format ajouté avec succès");
                con.Close();
                Close();
                ListeFormats listeFormats = new ListeFormats();
                listeFormats.Show();
            }
            else
            {
                con.Close();
                MessageBox.Show("Erreur lors de l'ajout du livre");
            }
        }

        private void btn_annulerFormat_Click(object sender, EventArgs e)
        {
            Close();
            ListeFormats listeFormats = new ListeFormats();
            listeFormats.Show();
        }
    }
}
