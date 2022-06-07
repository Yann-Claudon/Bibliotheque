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

        private void btn_formats_Click(object sender, EventArgs e)
        {
            ListeFormats listeFormats = new ListeFormats();
            listeFormats.Show();
            Hide();
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            /*ListeStatus listeStatus = new ListeStatus();
            listeStatus.Show();
            Close();
            */
        }

        private void btn_genres_Click(object sender, EventArgs e)
        {
            /*ListeGenres listeGenres = new ListeGenres();
            listeGenres.Show();
            Close();
            */
        }

        private void btn_emprunts_Click(object sender, EventArgs e)
        {

        }

        private void btn_editeurs_Click(object sender, EventArgs e)
        {
            ListeEditeurs listeEditeurs = new ListeEditeurs();
            listeEditeurs.Show();
            Hide();

        }
    }
}
