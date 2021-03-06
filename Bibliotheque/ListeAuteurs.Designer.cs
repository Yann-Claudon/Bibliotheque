namespace Bibliotheque
{
    partial class ListeAuteurs
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_accueilAuteur = new System.Windows.Forms.Button();
            this.btn_ajoutAuteur = new System.Windows.Forms.Button();
            this.btn_supprAuteur = new System.Windows.Forms.Button();
            this.txtbox_searchAuteur = new System.Windows.Forms.TextBox();
            this.dgridview_auteur = new System.Windows.Forms.DataGridView();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliothequeDataSet = new global::Bibliotheque.bibliothequeDataSet();
            this.authorTableAdapter = new global::Bibliotheque.bibliothequeDataSetTableAdapters.authorTableAdapter();
            this.btn_modif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_auteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSet)).BeginInit();
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
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste auteurs";
            // 
            // btn_accueilAuteur
            // 
            this.btn_accueilAuteur.Location = new System.Drawing.Point(12, 12);
            this.btn_accueilAuteur.Name = "btn_accueilAuteur";
            this.btn_accueilAuteur.Size = new System.Drawing.Size(103, 23);
            this.btn_accueilAuteur.TabIndex = 1;
            this.btn_accueilAuteur.Text = "Retour à l\'accueil";
            this.btn_accueilAuteur.UseVisualStyleBackColor = true;
            this.btn_accueilAuteur.Click += new System.EventHandler(this.btn_accueilAuteur_Click);
            // 
            // btn_ajoutAuteur
            // 
            this.btn_ajoutAuteur.Location = new System.Drawing.Point(211, 156);
            this.btn_ajoutAuteur.Name = "btn_ajoutAuteur";
            this.btn_ajoutAuteur.Size = new System.Drawing.Size(75, 23);
            this.btn_ajoutAuteur.TabIndex = 2;
            this.btn_ajoutAuteur.Text = "Ajout auteur";
            this.btn_ajoutAuteur.UseVisualStyleBackColor = true;
            this.btn_ajoutAuteur.Click += new System.EventHandler(this.btn_ajoutAuteur_Click);
            // 
            // btn_supprAuteur
            // 
            this.btn_supprAuteur.Location = new System.Drawing.Point(504, 156);
            this.btn_supprAuteur.Name = "btn_supprAuteur";
            this.btn_supprAuteur.Size = new System.Drawing.Size(118, 23);
            this.btn_supprAuteur.TabIndex = 3;
            this.btn_supprAuteur.Text = "Suppression auteur";
            this.btn_supprAuteur.UseVisualStyleBackColor = true;
            this.btn_supprAuteur.Click += new System.EventHandler(this.btn_supprAuteur_Click);
            // 
            // txtbox_searchAuteur
            // 
            this.txtbox_searchAuteur.Location = new System.Drawing.Point(44, 156);
            this.txtbox_searchAuteur.Name = "txtbox_searchAuteur";
            this.txtbox_searchAuteur.Size = new System.Drawing.Size(100, 20);
            this.txtbox_searchAuteur.TabIndex = 4;
            this.txtbox_searchAuteur.Text = "Recherche auteur";
            this.txtbox_searchAuteur.TextChanged += new System.EventHandler(this.txtbox_searchAuteur_TextChanged);
            // 
            // dgridview_auteur
            // 
            this.dgridview_auteur.AllowUserToAddRows = false;
            this.dgridview_auteur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridview_auteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridview_auteur.Location = new System.Drawing.Point(44, 203);
            this.dgridview_auteur.Name = "dgridview_auteur";
            this.dgridview_auteur.Size = new System.Drawing.Size(744, 218);
            this.dgridview_auteur.TabIndex = 5;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "author";
            this.authorBindingSource.DataSource = this.bibliothequeDataSet;
            // 
            // bibliothequeDataSet
            // 
            this.bibliothequeDataSet.DataSetName = "bibliothequeDataSet";
            this.bibliothequeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(339, 156);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(115, 23);
            this.btn_modif.TabIndex = 7;
            this.btn_modif.Text = "Modification auteur";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // ListeAuteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.dgridview_auteur);
            this.Controls.Add(this.txtbox_searchAuteur);
            this.Controls.Add(this.btn_supprAuteur);
            this.Controls.Add(this.btn_ajoutAuteur);
            this.Controls.Add(this.btn_accueilAuteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Titre);
            this.Name = "ListeAuteurs";
            this.Text = "Bibliothèque - Liste auteurs";
            this.Load += new System.EventHandler(this.Auteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_auteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_accueilAuteur;
        private System.Windows.Forms.Button btn_ajoutAuteur;
        private System.Windows.Forms.Button btn_supprAuteur;
        private System.Windows.Forms.TextBox txtbox_searchAuteur;
        private System.Windows.Forms.DataGridView dgridview_auteur;
        private bibliothequeDataSet bibliothequeDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private bibliothequeDataSetTableAdapters.authorTableAdapter authorTableAdapter;
        private System.Windows.Forms.Button btn_modif;
    }
}