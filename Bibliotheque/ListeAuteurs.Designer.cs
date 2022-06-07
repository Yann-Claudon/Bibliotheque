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
            this.btn_accueil = new System.Windows.Forms.Button();
            this.btn_ajoutAuteur = new System.Windows.Forms.Button();
            this.btn_supprAuteur = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgridview_auteur = new System.Windows.Forms.DataGridView();
            this.idauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliothequeDataSet = new Bibliotheque.bibliothequeDataSet();
            this.authorTableAdapter = new Bibliotheque.bibliothequeDataSetTableAdapters.authorTableAdapter();
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
            // btn_accueil
            // 
            this.btn_accueil.Location = new System.Drawing.Point(12, 12);
            this.btn_accueil.Name = "btn_accueil";
            this.btn_accueil.Size = new System.Drawing.Size(103, 23);
            this.btn_accueil.TabIndex = 1;
            this.btn_accueil.Text = "Retour à l\'accueil";
            this.btn_accueil.UseVisualStyleBackColor = true;
            this.btn_accueil.Click += new System.EventHandler(this.btn_accueil_Click);
            // 
            // btn_ajoutAuteur
            // 
            this.btn_ajoutAuteur.Location = new System.Drawing.Point(196, 156);
            this.btn_ajoutAuteur.Name = "btn_ajoutAuteur";
            this.btn_ajoutAuteur.Size = new System.Drawing.Size(75, 23);
            this.btn_ajoutAuteur.TabIndex = 2;
            this.btn_ajoutAuteur.Text = "Ajout auteur";
            this.btn_ajoutAuteur.UseVisualStyleBackColor = true;
            this.btn_ajoutAuteur.Click += new System.EventHandler(this.btn_ajoutAuteur_Click);
            // 
            // btn_supprAuteur
            // 
            this.btn_supprAuteur.Location = new System.Drawing.Point(489, 156);
            this.btn_supprAuteur.Name = "btn_supprAuteur";
            this.btn_supprAuteur.Size = new System.Drawing.Size(118, 23);
            this.btn_supprAuteur.TabIndex = 3;
            this.btn_supprAuteur.Text = "Suppression auteur";
            this.btn_supprAuteur.UseVisualStyleBackColor = true;
            this.btn_supprAuteur.Click += new System.EventHandler(this.btn_supprAuteur_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dgridview_auteur
            // 
            this.dgridview_auteur.AllowUserToAddRows = false;
            this.dgridview_auteur.AutoGenerateColumns = false;
            this.dgridview_auteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridview_auteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idauthorDataGridViewTextBoxColumn,
            this.nameauthorDataGridViewTextBoxColumn,
            this.birthdayauthorDataGridViewTextBoxColumn});
            this.dgridview_auteur.DataSource = this.authorBindingSource;
            this.dgridview_auteur.Location = new System.Drawing.Point(44, 203);
            this.dgridview_auteur.Name = "dgridview_auteur";
            this.dgridview_auteur.Size = new System.Drawing.Size(744, 218);
            this.dgridview_auteur.TabIndex = 5;
            // 
            // idauthorDataGridViewTextBoxColumn
            // 
            this.idauthorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idauthorDataGridViewTextBoxColumn.DataPropertyName = "id_author";
            this.idauthorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idauthorDataGridViewTextBoxColumn.Name = "idauthorDataGridViewTextBoxColumn";
            // 
            // nameauthorDataGridViewTextBoxColumn
            // 
            this.nameauthorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameauthorDataGridViewTextBoxColumn.DataPropertyName = "name_author";
            this.nameauthorDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nameauthorDataGridViewTextBoxColumn.Name = "nameauthorDataGridViewTextBoxColumn";
            // 
            // birthdayauthorDataGridViewTextBoxColumn
            // 
            this.birthdayauthorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthdayauthorDataGridViewTextBoxColumn.DataPropertyName = "birthday_author";
            this.birthdayauthorDataGridViewTextBoxColumn.HeaderText = "Naissance";
            this.birthdayauthorDataGridViewTextBoxColumn.Name = "birthdayauthorDataGridViewTextBoxColumn";
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
            this.btn_modif.Location = new System.Drawing.Point(324, 156);
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_supprAuteur);
            this.Controls.Add(this.btn_ajoutAuteur);
            this.Controls.Add(this.btn_accueil);
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
        private System.Windows.Forms.Button btn_accueil;
        private System.Windows.Forms.Button btn_ajoutAuteur;
        private System.Windows.Forms.Button btn_supprAuteur;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgridview_auteur;
        private bibliothequeDataSet bibliothequeDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private bibliothequeDataSetTableAdapters.authorTableAdapter authorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_modif;
    }
}