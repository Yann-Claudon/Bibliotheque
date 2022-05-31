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
    public partial class Auteur : Form
    {
        public Auteur()
        {
            InitializeComponent();
        }

        private void Auteur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bibliothequeDataSet.author'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.authorTableAdapter.Fill(this.bibliothequeDataSet.author);

        }

        private void btn_ajoutAuteur_Click(object sender, EventArgs e)
        {
            AjoutAuteur ajoutAuteur = new AjoutAuteur();
            ajoutAuteur.Show();
        }
    }
}
