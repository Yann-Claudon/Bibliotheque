using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheque
{
    public partial class ListeLivres : Form
    {
        public ListeLivres()
        {
            InitializeComponent();
        }

        private void ListeLivres_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bibliothequeBDD.book'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bookTableAdapter.Fill(this.bibliothequeBDD.book);
            // TODO: cette ligne de code charge les données dans la table 'bibliothequeBDD.author'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.authorTableAdapter.Fill(this.bibliothequeBDD.author);

        }

        private void btn_accueil_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ajoutLivre_Click(object sender, EventArgs e)
        {
            AjoutLivre ajoutLivre = new AjoutLivre();
            ajoutLivre.ShowDialog();
        }
    }
}
