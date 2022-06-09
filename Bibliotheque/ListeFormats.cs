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
    public partial class ListeFormats : Form{
        public ListeFormats(){
            InitializeComponent();
        }

        private void ListeFormats_Load(object sender, EventArgs e){
            var select = "SELECT id_format as 'ID', name_format as 'Nom du format' FROM format";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_format.DataSource = ds.Tables[0];
        }

        private void txtbox_searchFormat_TextChanged(object sender, EventArgs e){
            var select = "SELECT id_format AS 'ID', name_format AS 'Nom du format' FROM format WHERE name_format LIKE '%' + @Nom + '%'; ";
            var c = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Nom", txtbox_searchFormat.Text);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgridview_format.DataSource = ds.Tables[0];
        }

        private void btn_ajoutFormat_Click(object sender, EventArgs e){
            AjoutFormat ajoutFormat = new AjoutFormat();
            ajoutFormat.ShowDialog();
            Close();
        }

        private void btn_modifFormat_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE format set name_format = @Nom where id_format = @ID", con);
            cmd.Parameters.AddWithValue("@Nom", this.dgridview_format.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@ID", this.dgridview_format.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Modification réussie");
        }

        private void btn_supprEditeur_Click(object sender, EventArgs e)
        {
            if (this.dgridview_format.SelectedRows.Count > 0)
            {

                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=bibliotheque;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM format WHERE name_format = @Nom", con);
                cmd.Parameters.AddWithValue("@Nom", this.dgridview_format.CurrentRow.Cells[1].Value.ToString());
                cmd.ExecuteNonQuery();

                con.Close();

                dgridview_format.Rows.RemoveAt(this.dgridview_format.SelectedRows[0].Index);
            }
        }

        private void btn_accueilFormat_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            Close();
        }

    }
}
