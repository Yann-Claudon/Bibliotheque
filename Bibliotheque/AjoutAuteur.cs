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
    public partial class frmAjoutAuteur : Form
    {
        public frmAjoutAuteur()
        {
            InitializeComponent();
        }
        public string Nom
        {
            get
            {
                return txtbox_nom.Text;
            }
            set
            {
                txtbox_nom.Text = value;
            }
        }
        public string Naissance
        {
            get
            {
                return txtbox_naissance.Text;
            }
            set
            {
                txtbox_naissance.Text = value;
            }
        }
        public void setAuteur(string nom, string naissance)
        {
            txtbox_nom.Text = nom;
            txtbox_naissance.Text = naissance;
        }

        private void btn_ajouterAuteur_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into author (name_author,birthday_author) values (@Nom,@Naissance)", con);
            cmd.Parameters.AddWithValue("@Nom", txtbox_nom.Text);
            cmd.Parameters.AddWithValue("@Naissance", txtbox_naissance.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("La création à été effectué");

        }
    }
}
