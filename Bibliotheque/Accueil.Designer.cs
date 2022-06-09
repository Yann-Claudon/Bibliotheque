namespace Bibliotheque
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_SousTitre = new System.Windows.Forms.Label();
            this.btn_auteurs = new System.Windows.Forms.Button();
            this.btn_livres = new System.Windows.Forms.Button();
            this.btn_clients = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_statut = new System.Windows.Forms.Button();
            this.btn_formats = new System.Windows.Forms.Button();
            this.btn_editeurs = new System.Windows.Forms.Button();
            this.btn_genres = new System.Windows.Forms.Button();
            this.btn_emprunts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre.Location = new System.Drawing.Point(259, 9);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(288, 55);
            this.lbl_Titre.TabIndex = 0;
            this.lbl_Titre.Text = "Bibliothèque";
            this.lbl_Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lbl_SousTitre
            // 
            this.lbl_SousTitre.AutoSize = true;
            this.lbl_SousTitre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SousTitre.Location = new System.Drawing.Point(358, 64);
            this.lbl_SousTitre.Name = "lbl_SousTitre";
            this.lbl_SousTitre.Size = new System.Drawing.Size(89, 27);
            this.lbl_SousTitre.TabIndex = 2;
            this.lbl_SousTitre.Text = "Accueil";
            // 
            // btn_auteurs
            // 
            this.btn_auteurs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_auteurs.Location = new System.Drawing.Point(197, 288);
            this.btn_auteurs.Name = "btn_auteurs";
            this.btn_auteurs.Size = new System.Drawing.Size(119, 23);
            this.btn_auteurs.TabIndex = 3;
            this.btn_auteurs.Text = "Liste des auteurs";
            this.btn_auteurs.UseVisualStyleBackColor = true;
            this.btn_auteurs.Click += new System.EventHandler(this.btn_auteurs_Click);
            // 
            // btn_livres
            // 
            this.btn_livres.Location = new System.Drawing.Point(197, 169);
            this.btn_livres.Name = "btn_livres";
            this.btn_livres.Size = new System.Drawing.Size(119, 23);
            this.btn_livres.TabIndex = 4;
            this.btn_livres.Text = "Liste des livres";
            this.btn_livres.UseVisualStyleBackColor = true;
            this.btn_livres.Click += new System.EventHandler(this.btn_livres_Click);
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(197, 211);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(119, 23);
            this.btn_clients.TabIndex = 5;
            this.btn_clients.Text = "Liste des clients";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(555, 98);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // btn_statut
            // 
            this.btn_statut.Location = new System.Drawing.Point(341, 209);
            this.btn_statut.Name = "btn_statut";
            this.btn_statut.Size = new System.Drawing.Size(119, 23);
            this.btn_statut.TabIndex = 12;
            this.btn_statut.Text = "Liste des statuts";
            this.btn_statut.UseVisualStyleBackColor = true;
            this.btn_statut.Click += new System.EventHandler(this.btn_status_Click);
            // 
            // btn_formats
            // 
            this.btn_formats.Location = new System.Drawing.Point(341, 167);
            this.btn_formats.Name = "btn_formats";
            this.btn_formats.Size = new System.Drawing.Size(119, 23);
            this.btn_formats.TabIndex = 11;
            this.btn_formats.Text = "Liste des formats";
            this.btn_formats.UseVisualStyleBackColor = true;
            this.btn_formats.Click += new System.EventHandler(this.btn_formats_Click);
            // 
            // btn_editeurs
            // 
            this.btn_editeurs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_editeurs.Location = new System.Drawing.Point(197, 250);
            this.btn_editeurs.Name = "btn_editeurs";
            this.btn_editeurs.Size = new System.Drawing.Size(119, 23);
            this.btn_editeurs.TabIndex = 10;
            this.btn_editeurs.Text = "Liste des éditeurs";
            this.btn_editeurs.UseVisualStyleBackColor = true;
            this.btn_editeurs.Click += new System.EventHandler(this.btn_editeurs_Click);
            // 
            // btn_genres
            // 
            this.btn_genres.Location = new System.Drawing.Point(341, 250);
            this.btn_genres.Name = "btn_genres";
            this.btn_genres.Size = new System.Drawing.Size(119, 23);
            this.btn_genres.TabIndex = 13;
            this.btn_genres.Text = "Liste des genres";
            this.btn_genres.UseVisualStyleBackColor = true;
            this.btn_genres.Click += new System.EventHandler(this.btn_genres_Click);
            // 
            // btn_emprunts
            // 
            this.btn_emprunts.Location = new System.Drawing.Point(341, 288);
            this.btn_emprunts.Name = "btn_emprunts";
            this.btn_emprunts.Size = new System.Drawing.Size(119, 23);
            this.btn_emprunts.TabIndex = 14;
            this.btn_emprunts.Text = "Liste des emprunts";
            this.btn_emprunts.UseVisualStyleBackColor = true;
            this.btn_emprunts.Click += new System.EventHandler(this.btn_emprunts_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_emprunts);
            this.Controls.Add(this.btn_genres);
            this.Controls.Add(this.btn_statut);
            this.Controls.Add(this.btn_formats);
            this.Controls.Add(this.btn_editeurs);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_clients);
            this.Controls.Add(this.btn_livres);
            this.Controls.Add(this.btn_auteurs);
            this.Controls.Add(this.lbl_SousTitre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Titre);
            this.Name = "Accueil";
            this.Text = "Bibliothèque - Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_SousTitre;
        private System.Windows.Forms.Button btn_auteurs;
        private System.Windows.Forms.Button btn_livres;
        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_statut;
        private System.Windows.Forms.Button btn_formats;
        private System.Windows.Forms.Button btn_editeurs;
        private System.Windows.Forms.Button btn_genres;
        private System.Windows.Forms.Button btn_emprunts;
    }
}

