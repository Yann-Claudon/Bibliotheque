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
    public partial class Planning : Form{
        public Planning(){
            InitializeComponent();
        }

        /*
         * Affiche le Form Accueil lors du clic sur le bouton "accueil"
         */
        private void btn_accueil_Click(object sender, EventArgs e){
            Accueil accueil = new Accueil();
            accueil.Show();
            Close();
        }

        /*
         * Affiche une boite de dialogue avec choix de l'imprimante puis prévisualisation de l'impression lors du clic sur le bouton "imprimer" 
         */
        Bitmap bmp;
        private void btn_impression_Click(object sender, EventArgs e){
            printDialog1.ShowDialog();
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Width, this.Height);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        /*
         * Imprime le Form actuel
         */
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e){
            e.Graphics.DrawImage(bmp, 0, 0);
        }

    }
}
