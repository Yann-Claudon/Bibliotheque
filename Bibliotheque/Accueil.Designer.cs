﻿namespace Bibliotheque
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
            this.btn_retourLivres = new System.Windows.Forms.Button();
            this.btn_pretLivres = new System.Windows.Forms.Button();
            this.btn_planning = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
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
            this.btn_auteurs.Location = new System.Drawing.Point(340, 151);
            this.btn_auteurs.Name = "btn_auteurs";
            this.btn_auteurs.Size = new System.Drawing.Size(119, 23);
            this.btn_auteurs.TabIndex = 3;
            this.btn_auteurs.Text = "Liste des auteurs";
            this.btn_auteurs.UseVisualStyleBackColor = true;
            this.btn_auteurs.Click += new System.EventHandler(this.btn_auteurs_Click);
            // 
            // btn_livres
            // 
            this.btn_livres.Location = new System.Drawing.Point(340, 195);
            this.btn_livres.Name = "btn_livres";
            this.btn_livres.Size = new System.Drawing.Size(119, 23);
            this.btn_livres.TabIndex = 4;
            this.btn_livres.Text = "Liste des livres";
            this.btn_livres.UseVisualStyleBackColor = true;
            this.btn_livres.Click += new System.EventHandler(this.btn_livres_Click);
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(340, 237);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(119, 23);
            this.btn_clients.TabIndex = 5;
            this.btn_clients.Text = "Liste des clients";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // btn_retourLivres
            // 
            this.btn_retourLivres.Location = new System.Drawing.Point(199, 305);
            this.btn_retourLivres.Name = "btn_retourLivres";
            this.btn_retourLivres.Size = new System.Drawing.Size(119, 23);
            this.btn_retourLivres.TabIndex = 6;
            this.btn_retourLivres.Text = "Retour livre";
            this.btn_retourLivres.UseVisualStyleBackColor = true;
            this.btn_retourLivres.Click += new System.EventHandler(this.btn_retourLivres_Click);
            // 
            // btn_pretLivres
            // 
            this.btn_pretLivres.Location = new System.Drawing.Point(468, 305);
            this.btn_pretLivres.Name = "btn_pretLivres";
            this.btn_pretLivres.Size = new System.Drawing.Size(119, 23);
            this.btn_pretLivres.TabIndex = 7;
            this.btn_pretLivres.Text = "Prêt de livre";
            this.btn_pretLivres.UseVisualStyleBackColor = true;
            // 
            // btn_planning
            // 
            this.btn_planning.Location = new System.Drawing.Point(612, 272);
            this.btn_planning.Name = "btn_planning";
            this.btn_planning.Size = new System.Drawing.Size(119, 23);
            this.btn_planning.TabIndex = 8;
            this.btn_planning.Text = "Planning";
            this.btn_planning.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(555, 98);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_planning);
            this.Controls.Add(this.btn_pretLivres);
            this.Controls.Add(this.btn_retourLivres);
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
        private System.Windows.Forms.Button btn_retourLivres;
        private System.Windows.Forms.Button btn_pretLivres;
        private System.Windows.Forms.Button btn_planning;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

