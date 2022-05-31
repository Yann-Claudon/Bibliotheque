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
            MessageBox.Show("La création à été effectué");
            

        }
    }
}
