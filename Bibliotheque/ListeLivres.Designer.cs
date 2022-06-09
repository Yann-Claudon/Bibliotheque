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
            this.components = new System.ComponentModel.Container();
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.lbl_SousTitre = new System.Windows.Forms.Label();
            this.btn_ajoutLivre = new System.Windows.Forms.Button();
            this.btn_supressionLivre = new System.Windows.Forms.Button();
            this.btn_accueil = new System.Windows.Forms.Button();
            this.dgridview_livre = new System.Windows.Forms.DataGridView();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliothequeBDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliothequeBDD = new Bibliotheque.bibliothequeBDD();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new Bibliotheque.bibliothequeBDDTableAdapters.authorTableAdapter();
            this.bookTableAdapter = new Bibliotheque.bibliothequeBDDTableAdapters.bookTableAdapter();
            this.txtbox_recherche = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_livre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
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
            this.btn_ajoutLivre.Click += new System.EventHandler(this.btn_ajoutLivre_Click);
            // 
            // btn_supressionLivre
            // 
            this.btn_supressionLivre.Location = new System.Drawing.Point(468, 119);
            this.btn_supressionLivre.Name = "btn_supressionLivre";
            this.btn_supressionLivre.Size = new System.Drawing.Size(119, 23);
            this.btn_supressionLivre.TabIndex = 5;
            this.btn_supressionLivre.Text = "Suppression Livre";
            this.btn_supressionLivre.UseVisualStyleBackColor = true;
            this.btn_supressionLivre.Click += new System.EventHandler(this.btn_supressionLivre_Click);
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
            // dgridview_livre
            // 
            this.dgridview_livre.AllowUserToAddRows = false;
            this.dgridview_livre.AllowUserToDeleteRows = false;
            this.dgridview_livre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridview_livre.Location = new System.Drawing.Point(26, 175);
            this.dgridview_livre.Name = "dgridview_livre";
            this.dgridview_livre.ReadOnly = true;
            this.dgridview_livre.Size = new System.Drawing.Size(745, 228);
            this.dgridview_livre.TabIndex = 7;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.bibliothequeBDDBindingSource;
            // 
            // bibliothequeBDDBindingSource
            // 
            this.bibliothequeBDDBindingSource.DataSource = this.bibliothequeBDD;
            this.bibliothequeBDDBindingSource.Position = 0;
            // 
            // bibliothequeBDD
            // 
            this.bibliothequeBDD.DataSetName = "bibliothequeBDD";
            this.bibliothequeBDD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "author";
            this.authorBindingSource.DataSource = this.bibliothequeBDDBindingSource;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // txtbox_recherche
            // 
            this.txtbox_recherche.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_recherche.Location = new System.Drawing.Point(51, 119);
            this.txtbox_recherche.Name = "txtbox_recherche";
            this.txtbox_recherche.Size = new System.Drawing.Size(120, 25);
            this.txtbox_recherche.TabIndex = 9;
            this.txtbox_recherche.Text = "Recherche livre";
            this.txtbox_recherche.TextChanged += new System.EventHandler(this.txtbox_recherche_TextChanged);
            // 
            // ListeLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox_recherche);
            this.Controls.Add(this.dgridview_livre);
            this.Controls.Add(this.btn_accueil);
            this.Controls.Add(this.btn_supressionLivre);
            this.Controls.Add(this.btn_ajoutLivre);
            this.Controls.Add(this.lbl_SousTitre);
            this.Controls.Add(this.lbl_Titre);
            this.Name = "ListeLivres";
            this.Text = "Bibliothèque - ListeLivres";
            this.Load += new System.EventHandler(this.ListeLivres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_livre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.Label lbl_SousTitre;
        private System.Windows.Forms.Button btn_ajoutLivre;
        private System.Windows.Forms.Button btn_supressionLivre;
        private System.Windows.Forms.Button btn_accueil;
        private System.Windows.Forms.DataGridView dgridview_livre;
        private System.Windows.Forms.BindingSource bibliothequeBDDBindingSource;
        private bibliothequeBDD bibliothequeBDD;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private bibliothequeBDDTableAdapters.authorTableAdapter authorTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private bibliothequeBDDTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.TextBox txtbox_recherche;
    }
}