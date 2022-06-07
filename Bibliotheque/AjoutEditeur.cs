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
    public partial class AjoutEditeur : Form
    {
        public AjoutEditeur()
        {
            InitializeComponent();
        }

        private void btn_ajouterEditeur_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into editor (name_editor) values (@Nom)", con);
            cmd.Parameters.AddWithValue("@Nom", txtbox_nom.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            Close();
            ListeEditeurs listeEditeurs = new ListeEditeurs();
            listeEditeurs.Show();
            MessageBox.Show("La création à été effectuée");
        }
    }
}
