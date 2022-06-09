using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheque{
    public partial class RetourLivre : Form{
        public RetourLivre(){
            InitializeComponent();
        }

        private void btn_ajouterAuteur_Click(object sender, EventArgs e){

        }

        private void btn_annulerAuteur_Click(object sender, EventArgs e){
            Close();
        }
    }
}
