namespace Bibliotheque
{
    partial class ListeEditeurs
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
            this.btn_modifEditeur = new System.Windows.Forms.Button();
            this.dgridview_editeur = new System.Windows.Forms.DataGridView();
            this.editorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliothequeBDD = new Bibliotheque.bibliothequeBDD();
            this.txtbox_searchEditeur = new System.Windows.Forms.TextBox();
            this.btn_supprEditeur = new System.Windows.Forms.Button();
            this.btn_ajoutEditeur = new System.Windows.Forms.Button();
            this.btn_accueilEditeur = new System.Windows.Forms.Button();
            this.lbl_soustitre_editeur = new System.Windows.Forms.Label();
            this.lbl_titre_editeur = new System.Windows.Forms.Label();
            this.editorTableAdapter = new Bibliotheque.bibliothequeBDDTableAdapters.editorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_editeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDD)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modifEditeur
            // 
            this.btn_modifEditeur.Location = new System.Drawing.Point(332, 166);
            this.btn_modifEditeur.Name = "btn_modifEditeur";
            this.btn_modifEditeur.Size = new System.Drawing.Size(115, 23);
            this.btn_modifEditeur.TabIndex = 15;
            this.btn_modifEditeur.Text = "Modification éditeur";
            this.btn_modifEditeur.UseVisualStyleBackColor = true;
            this.btn_modifEditeur.Click += new System.EventHandler(this.btn_modifEditeur_Click);
            // 
            // dgridview_editeur
            // 
            this.dgridview_editeur.AllowUserToAddRows = false;
            this.dgridview_editeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridview_editeur.Location = new System.Drawing.Point(37, 213);
            this.dgridview_editeur.Name = "dgridview_editeur";
            this.dgridview_editeur.Size = new System.Drawing.Size(744, 218);
            this.dgridview_editeur.TabIndex = 14;
            // 
            // editorBindingSource
            // 
            this.editorBindingSource.DataMember = "editor";
            this.editorBindingSource.DataSource = this.bibliothequeBDD;
            // 
            // bibliothequeBDD
            // 
            this.bibliothequeBDD.DataSetName = "bibliothequeBDD";
            this.bibliothequeBDD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbox_searchEditeur
            // 
            this.txtbox_searchEditeur.Location = new System.Drawing.Point(37, 166);
            this.txtbox_searchEditeur.Name = "txtbox_searchEditeur";
            this.txtbox_searchEditeur.Size = new System.Drawing.Size(100, 20);
            this.txtbox_searchEditeur.TabIndex = 13;
            this.txtbox_searchEditeur.TextChanged += new System.EventHandler(this.txtbox_searchEditeur_TextChanged);
            // 
            // btn_supprEditeur
            // 
            this.btn_supprEditeur.Location = new System.Drawing.Point(497, 166);
            this.btn_supprEditeur.Name = "btn_supprEditeur";
            this.btn_supprEditeur.Size = new System.Drawing.Size(118, 23);
            this.btn_supprEditeur.TabIndex = 12;
            this.btn_supprEditeur.Text = "Suppression éditeur";
            this.btn_supprEditeur.UseVisualStyleBackColor = true;
            this.btn_supprEditeur.Click += new System.EventHandler(this.btn_supprEditeur_Click);
            // 
            // btn_ajoutEditeur
            // 
            this.btn_ajoutEditeur.Location = new System.Drawing.Point(204, 166);
            this.btn_ajoutEditeur.Name = "btn_ajoutEditeur";
            this.btn_ajoutEditeur.Size = new System.Drawing.Size(75, 23);
            this.btn_ajoutEditeur.TabIndex = 11;
            this.btn_ajoutEditeur.Text = "Ajout éditeur";
            this.btn_ajoutEditeur.UseVisualStyleBackColor = true;
            this.btn_ajoutEditeur.Click += new System.EventHandler(this.btn_ajoutEditeur_Click);
            // 
            // btn_accueilEditeur
            // 
            this.btn_accueilEditeur.Location = new System.Drawing.Point(20, 22);
            this.btn_accueilEditeur.Name = "btn_accueilEditeur";
            this.btn_accueilEditeur.Size = new System.Drawing.Size(103, 23);
            this.btn_accueilEditeur.TabIndex = 10;
            this.btn_accueilEditeur.Text = "Retour à l\'accueil";
            this.btn_accueilEditeur.UseVisualStyleBackColor = true;
            this.btn_accueilEditeur.Click += new System.EventHandler(this.btn_accueilEditeur_Click);
            // 
            // lbl_soustitre_editeur
            // 
            this.lbl_soustitre_editeur.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soustitre_editeur.Location = new System.Drawing.Point(327, 88);
            this.lbl_soustitre_editeur.Name = "lbl_soustitre_editeur";
            this.lbl_soustitre_editeur.Size = new System.Drawing.Size(160, 29);
            this.lbl_soustitre_editeur.TabIndex = 8;
            this.lbl_soustitre_editeur.Text = "Liste éditeurs";
            // 
            // lbl_titre_editeur
            // 
            this.lbl_titre_editeur.AutoSize = true;
            this.lbl_titre_editeur.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_editeur.Location = new System.Drawing.Point(267, 19);
            this.lbl_titre_editeur.Name = "lbl_titre_editeur";
            this.lbl_titre_editeur.Size = new System.Drawing.Size(288, 55);
            this.lbl_titre_editeur.TabIndex = 9;
            this.lbl_titre_editeur.Text = "Bibliothèque";
            // 
            // editorTableAdapter
            // 
            this.editorTableAdapter.ClearBeforeFill = true;
            // 
            // ListeEditeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_modifEditeur);
            this.Controls.Add(this.dgridview_editeur);
            this.Controls.Add(this.txtbox_searchEditeur);
            this.Controls.Add(this.btn_supprEditeur);
            this.Controls.Add(this.btn_ajoutEditeur);
            this.Controls.Add(this.btn_accueilEditeur);
            this.Controls.Add(this.lbl_soustitre_editeur);
            this.Controls.Add(this.lbl_titre_editeur);
            this.Name = "ListeEditeurs";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListeEditeurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_editeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modifEditeur;
        private System.Windows.Forms.DataGridView dgridview_editeur;
        private System.Windows.Forms.TextBox txtbox_searchEditeur;
        private System.Windows.Forms.Button btn_supprEditeur;
        private System.Windows.Forms.Button btn_ajoutEditeur;
        private System.Windows.Forms.Button btn_accueilEditeur;
        private System.Windows.Forms.Label lbl_soustitre_editeur;
        private System.Windows.Forms.Label lbl_titre_editeur;
        private bibliothequeBDD bibliothequeBDD;
        private System.Windows.Forms.BindingSource editorBindingSource;
        private bibliothequeBDDTableAdapters.editorTableAdapter editorTableAdapter;
    }
}