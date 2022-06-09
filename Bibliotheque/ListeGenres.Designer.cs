namespace Bibliotheque
{
    partial class ListeGenres
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
            this.btn_modifGenre = new System.Windows.Forms.Button();
            this.dgridview_genre = new System.Windows.Forms.DataGridView();
            this.txtbox_searchGenre = new System.Windows.Forms.TextBox();
            this.btn_supprGenre = new System.Windows.Forms.Button();
            this.btn_ajoutGenre = new System.Windows.Forms.Button();
            this.btn_accueilGenre = new System.Windows.Forms.Button();
            this.lbl_soustitre_genre = new System.Windows.Forms.Label();
            this.lbl_titre_genre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_genre)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modifGenre
            // 
            this.btn_modifGenre.Location = new System.Drawing.Point(332, 166);
            this.btn_modifGenre.Name = "btn_modifGenre";
            this.btn_modifGenre.Size = new System.Drawing.Size(115, 23);
            this.btn_modifGenre.TabIndex = 39;
            this.btn_modifGenre.Text = "Modification genre";
            this.btn_modifGenre.UseVisualStyleBackColor = true;
            this.btn_modifGenre.Click += new System.EventHandler(this.btn_modifGenre_Click);
            // 
            // dgridview_genre
            // 
            this.dgridview_genre.AllowUserToAddRows = false;
            this.dgridview_genre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridview_genre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridview_genre.Location = new System.Drawing.Point(37, 213);
            this.dgridview_genre.Name = "dgridview_genre";
            this.dgridview_genre.Size = new System.Drawing.Size(744, 218);
            this.dgridview_genre.TabIndex = 38;
            // 
            // txtbox_searchGenre
            // 
            this.txtbox_searchGenre.Location = new System.Drawing.Point(37, 166);
            this.txtbox_searchGenre.Name = "txtbox_searchGenre";
            this.txtbox_searchGenre.Size = new System.Drawing.Size(100, 20);
            this.txtbox_searchGenre.TabIndex = 37;
            this.txtbox_searchGenre.Text = "Recherche genre";
            this.txtbox_searchGenre.TextChanged += new System.EventHandler(this.txtbox_searchGenre_TextChanged);
            // 
            // btn_supprGenre
            // 
            this.btn_supprGenre.Location = new System.Drawing.Point(497, 166);
            this.btn_supprGenre.Name = "btn_supprGenre";
            this.btn_supprGenre.Size = new System.Drawing.Size(118, 23);
            this.btn_supprGenre.TabIndex = 36;
            this.btn_supprGenre.Text = "Suppression genre";
            this.btn_supprGenre.UseVisualStyleBackColor = true;
            this.btn_supprGenre.Click += new System.EventHandler(this.btn_supprGenre_Click);
            // 
            // btn_ajoutGenre
            // 
            this.btn_ajoutGenre.Location = new System.Drawing.Point(204, 166);
            this.btn_ajoutGenre.Name = "btn_ajoutGenre";
            this.btn_ajoutGenre.Size = new System.Drawing.Size(75, 23);
            this.btn_ajoutGenre.TabIndex = 35;
            this.btn_ajoutGenre.Text = "Ajout genre";
            this.btn_ajoutGenre.UseVisualStyleBackColor = true;
            this.btn_ajoutGenre.Click += new System.EventHandler(this.btn_ajoutGenre_Click);
            // 
            // btn_accueilGenre
            // 
            this.btn_accueilGenre.Location = new System.Drawing.Point(20, 22);
            this.btn_accueilGenre.Name = "btn_accueilGenre";
            this.btn_accueilGenre.Size = new System.Drawing.Size(103, 23);
            this.btn_accueilGenre.TabIndex = 34;
            this.btn_accueilGenre.Text = "Retour à l\'accueil";
            this.btn_accueilGenre.UseVisualStyleBackColor = true;
            this.btn_accueilGenre.Click += new System.EventHandler(this.btn_accueilGenre_Click);
            // 
            // lbl_soustitre_genre
            // 
            this.lbl_soustitre_genre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soustitre_genre.Location = new System.Drawing.Point(327, 88);
            this.lbl_soustitre_genre.Name = "lbl_soustitre_genre";
            this.lbl_soustitre_genre.Size = new System.Drawing.Size(160, 29);
            this.lbl_soustitre_genre.TabIndex = 32;
            this.lbl_soustitre_genre.Text = "Liste genres";
            // 
            // lbl_titre_genre
            // 
            this.lbl_titre_genre.AutoSize = true;
            this.lbl_titre_genre.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_genre.Location = new System.Drawing.Point(267, 19);
            this.lbl_titre_genre.Name = "lbl_titre_genre";
            this.lbl_titre_genre.Size = new System.Drawing.Size(288, 55);
            this.lbl_titre_genre.TabIndex = 33;
            this.lbl_titre_genre.Text = "Bibliothèque";
            // 
            // ListeGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_modifGenre);
            this.Controls.Add(this.dgridview_genre);
            this.Controls.Add(this.txtbox_searchGenre);
            this.Controls.Add(this.btn_supprGenre);
            this.Controls.Add(this.btn_ajoutGenre);
            this.Controls.Add(this.btn_accueilGenre);
            this.Controls.Add(this.lbl_soustitre_genre);
            this.Controls.Add(this.lbl_titre_genre);
            this.Name = "ListeGenres";
            this.Text = "ListeGenres";
            this.Load += new System.EventHandler(this.ListeGenres_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_genre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modifGenre;
        private System.Windows.Forms.DataGridView dgridview_genre;
        private System.Windows.Forms.TextBox txtbox_searchGenre;
        private System.Windows.Forms.Button btn_supprGenre;
        private System.Windows.Forms.Button btn_ajoutGenre;
        private System.Windows.Forms.Button btn_accueilGenre;
        private System.Windows.Forms.Label lbl_soustitre_genre;
        private System.Windows.Forms.Label lbl_titre_genre;
    }
}