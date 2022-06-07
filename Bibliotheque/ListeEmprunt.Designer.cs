namespace Bibliotheque
{
    partial class ListeEmprunt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeEmprunt));
            this.txtbox_recherche = new System.Windows.Forms.TextBox();
            this.dgridview_livre = new System.Windows.Forms.DataGridView();
            this.btn_accueil = new System.Windows.Forms.Button();
            this.btn_retourLivre = new System.Windows.Forms.Button();
            this.btn_pretLivre = new System.Windows.Forms.Button();
            this.lbl_SousTitre = new System.Windows.Forms.Label();
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_livre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_recherche
            // 
            this.txtbox_recherche.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_recherche.Location = new System.Drawing.Point(60, 138);
            this.txtbox_recherche.Name = "txtbox_recherche";
            this.txtbox_recherche.Size = new System.Drawing.Size(120, 25);
            this.txtbox_recherche.TabIndex = 17;
            this.txtbox_recherche.Text = "Recherche livre";
            this.txtbox_recherche.TextChanged += new System.EventHandler(this.txtbox_recherche_TextChanged);
            // 
            // dgridview_livre
            // 
            this.dgridview_livre.AllowUserToAddRows = false;
            this.dgridview_livre.AllowUserToDeleteRows = false;
            this.dgridview_livre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridview_livre.Location = new System.Drawing.Point(35, 194);
            this.dgridview_livre.Name = "dgridview_livre";
            this.dgridview_livre.ReadOnly = true;
            this.dgridview_livre.Size = new System.Drawing.Size(745, 228);
            this.dgridview_livre.TabIndex = 15;
            // 
            // btn_accueil
            // 
            this.btn_accueil.Location = new System.Drawing.Point(21, 31);
            this.btn_accueil.Name = "btn_accueil";
            this.btn_accueil.Size = new System.Drawing.Size(119, 23);
            this.btn_accueil.TabIndex = 14;
            this.btn_accueil.Text = "Retour à l\'accueil";
            this.btn_accueil.UseVisualStyleBackColor = true;
            this.btn_accueil.Click += new System.EventHandler(this.btn_accueil_Click);
            // 
            // btn_retourLivre
            // 
            this.btn_retourLivre.Location = new System.Drawing.Point(490, 138);
            this.btn_retourLivre.Name = "btn_retourLivre";
            this.btn_retourLivre.Size = new System.Drawing.Size(119, 23);
            this.btn_retourLivre.TabIndex = 13;
            this.btn_retourLivre.Text = "Retour livre";
            this.btn_retourLivre.UseVisualStyleBackColor = true;
            this.btn_retourLivre.Click += new System.EventHandler(this.btn_retourLivre_Click);
            // 
            // btn_pretLivre
            // 
            this.btn_pretLivre.Location = new System.Drawing.Point(198, 138);
            this.btn_pretLivre.Name = "btn_pretLivre";
            this.btn_pretLivre.Size = new System.Drawing.Size(119, 23);
            this.btn_pretLivre.TabIndex = 12;
            this.btn_pretLivre.Text = "Prêt de livre";
            this.btn_pretLivre.UseVisualStyleBackColor = true;
            this.btn_pretLivre.Click += new System.EventHandler(this.btn_pretLivre_Click);
            // 
            // lbl_SousTitre
            // 
            this.lbl_SousTitre.AutoSize = true;
            this.lbl_SousTitre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SousTitre.Location = new System.Drawing.Point(323, 83);
            this.lbl_SousTitre.Name = "lbl_SousTitre";
            this.lbl_SousTitre.Size = new System.Drawing.Size(171, 27);
            this.lbl_SousTitre.TabIndex = 11;
            this.lbl_SousTitre.Text = "Liste emprunts";
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre.Location = new System.Drawing.Point(268, 28);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(288, 55);
            this.lbl_Titre.TabIndex = 10;
            this.lbl_Titre.Text = "Bibliothèque";
            this.lbl_Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Location = new System.Drawing.Point(344, 138);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(119, 23);
            this.btn_imprimer.TabIndex = 18;
            this.btn_imprimer.Text = "Impression";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ListeEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_imprimer);
            this.Controls.Add(this.txtbox_recherche);
            this.Controls.Add(this.dgridview_livre);
            this.Controls.Add(this.btn_accueil);
            this.Controls.Add(this.btn_retourLivre);
            this.Controls.Add(this.btn_pretLivre);
            this.Controls.Add(this.lbl_SousTitre);
            this.Controls.Add(this.lbl_Titre);
            this.Name = "ListeEmprunt";
            this.Text = "ListeEmprunt";
            this.Load += new System.EventHandler(this.ListeEmprunt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_livre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_recherche;
        private System.Windows.Forms.DataGridView dgridview_livre;
        private System.Windows.Forms.Button btn_accueil;
        private System.Windows.Forms.Button btn_retourLivre;
        private System.Windows.Forms.Button btn_pretLivre;
        private System.Windows.Forms.Label lbl_SousTitre;
        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}