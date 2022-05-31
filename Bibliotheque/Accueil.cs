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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void btn_retourLivres_Click(object sender, EventArgs e)
        {

        }

        private void btn_auteurs_Click(object sender, EventArgs e)
        {
            ListeAuteurs auteur = new ListeAuteurs();
            auteur.Show();
            Hide();
        }

        private void btn_livres_Click(object sender, EventArgs e)
        {
            ListeLivres listeLivres = new ListeLivres();
            listeLivres.Show();
            Hide();
        }
    }
}
