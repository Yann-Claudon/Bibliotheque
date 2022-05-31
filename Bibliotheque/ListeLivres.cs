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

        }

        private void btn_accueil_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            Close();
        }
    }
}
