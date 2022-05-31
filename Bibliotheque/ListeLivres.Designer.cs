namespace Bibliotheque
{
    partial class ListeLivres
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
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.lbl_SousTitre = new System.Windows.Forms.Label();
            this.btn_ajoutLivre = new System.Windows.Forms.Button();
            this.btn_supressionLivre = new System.Windows.Forms.Button();
            this.btn_accueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre.Location = new System.Drawing.Point(259, 9);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(288, 55);
            this.lbl_Titre.TabIndex = 1;
            this.lbl_Titre.Text = "Bibliothèque";
            this.lbl_Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_SousTitre
            // 
            this.lbl_SousTitre.AutoSize = true;
            this.lbl_SousTitre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SousTitre.Location = new System.Drawing.Point(333, 64);
            this.lbl_SousTitre.Name = "lbl_SousTitre";
            this.lbl_SousTitre.Size = new System.Drawing.Size(124, 27);
            this.lbl_SousTitre.TabIndex = 3;
            this.lbl_SousTitre.Text = "Liste livres";
            // 
            // btn_ajoutLivre
            // 
            this.btn_ajoutLivre.Location = new System.Drawing.Point(200, 119);
            this.btn_ajoutLivre.Name = "btn_ajoutLivre";
            this.btn_ajoutLivre.Size = new System.Drawing.Size(119, 23);
            this.btn_ajoutLivre.TabIndex = 4;
            this.btn_ajoutLivre.Text = "Ajout livre";
            this.btn_ajoutLivre.UseVisualStyleBackColor = true;
            // 
            // btn_supressionLivre
            // 
            this.btn_supressionLivre.Location = new System.Drawing.Point(458, 119);
            this.btn_supressionLivre.Name = "btn_supressionLivre";
            this.btn_supressionLivre.Size = new System.Drawing.Size(119, 23);
            this.btn_supressionLivre.TabIndex = 5;
            this.btn_supressionLivre.Text = "Suppression Livre";
            this.btn_supressionLivre.UseVisualStyleBackColor = true;
            // 
            // btn_accueil
            // 
            this.btn_accueil.Location = new System.Drawing.Point(12, 12);
            this.btn_accueil.Name = "btn_accueil";
            this.btn_accueil.Size = new System.Drawing.Size(119, 23);
            this.btn_accueil.TabIndex = 6;
            this.btn_accueil.Text = "Retour à l\'accueil";
            this.btn_accueil.UseVisualStyleBackColor = true;
            this.btn_accueil.Click += new System.EventHandler(this.btn_accueil_Click);
            // 
            // ListeLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_accueil);
            this.Controls.Add(this.btn_supressionLivre);
            this.Controls.Add(this.btn_ajoutLivre);
            this.Controls.Add(this.lbl_SousTitre);
            this.Controls.Add(this.lbl_Titre);
            this.Name = "ListeLivres";
            this.Text = "Bibliothèque - ListeLivres";
            this.Load += new System.EventHandler(this.ListeLivres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.Label lbl_SousTitre;
        private System.Windows.Forms.Button btn_ajoutLivre;
        private System.Windows.Forms.Button btn_supressionLivre;
        private System.Windows.Forms.Button btn_accueil;
    }
}