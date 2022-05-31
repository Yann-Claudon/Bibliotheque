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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bibliothequeBDD = new Bibliotheque.bibliothequeBDD();
            this.bibliothequeBDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new Bibliotheque.bibliothequeBDDTableAdapters.authorTableAdapter();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Bibliotheque.bibliothequeBDDTableAdapters.bookTableAdapter();
            this.namebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishdatebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkgenrebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkeditorbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkauthorbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkformatbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkstatusbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namebookDataGridViewTextBoxColumn,
            this.publishdatebookDataGridViewTextBoxColumn,
            this.fkgenrebookDataGridViewTextBoxColumn,
            this.fkeditorbookDataGridViewTextBoxColumn,
            this.fkauthorbookDataGridViewTextBoxColumn,
            this.fkformatbookDataGridViewTextBoxColumn,
            this.fkstatusbookDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 228);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bibliothequeBDD
            // 
            this.bibliothequeBDD.DataSetName = "bibliothequeBDD";
            this.bibliothequeBDD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliothequeBDDBindingSource
            // 
            this.bibliothequeBDDBindingSource.DataSource = this.bibliothequeBDD;
            this.bibliothequeBDDBindingSource.Position = 0;
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
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.bibliothequeBDDBindingSource;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // namebookDataGridViewTextBoxColumn
            // 
            this.namebookDataGridViewTextBoxColumn.DataPropertyName = "name_book";
            this.namebookDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.namebookDataGridViewTextBoxColumn.Name = "namebookDataGridViewTextBoxColumn";
            this.namebookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishdatebookDataGridViewTextBoxColumn
            // 
            this.publishdatebookDataGridViewTextBoxColumn.DataPropertyName = "publish_date_book";
            this.publishdatebookDataGridViewTextBoxColumn.HeaderText = "Date de publication";
            this.publishdatebookDataGridViewTextBoxColumn.Name = "publishdatebookDataGridViewTextBoxColumn";
            this.publishdatebookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkgenrebookDataGridViewTextBoxColumn
            // 
            this.fkgenrebookDataGridViewTextBoxColumn.DataPropertyName = "fk_genre_book";
            this.fkgenrebookDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.fkgenrebookDataGridViewTextBoxColumn.Name = "fkgenrebookDataGridViewTextBoxColumn";
            this.fkgenrebookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkeditorbookDataGridViewTextBoxColumn
            // 
            this.fkeditorbookDataGridViewTextBoxColumn.DataPropertyName = "fk_editor_book";
            this.fkeditorbookDataGridViewTextBoxColumn.HeaderText = "Editeur";
            this.fkeditorbookDataGridViewTextBoxColumn.Name = "fkeditorbookDataGridViewTextBoxColumn";
            this.fkeditorbookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkauthorbookDataGridViewTextBoxColumn
            // 
            this.fkauthorbookDataGridViewTextBoxColumn.DataPropertyName = "fk_author_book";
            this.fkauthorbookDataGridViewTextBoxColumn.HeaderText = "Auteur";
            this.fkauthorbookDataGridViewTextBoxColumn.Name = "fkauthorbookDataGridViewTextBoxColumn";
            this.fkauthorbookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkformatbookDataGridViewTextBoxColumn
            // 
            this.fkformatbookDataGridViewTextBoxColumn.DataPropertyName = "fk_format_book";
            this.fkformatbookDataGridViewTextBoxColumn.HeaderText = "Format";
            this.fkformatbookDataGridViewTextBoxColumn.Name = "fkformatbookDataGridViewTextBoxColumn";
            this.fkformatbookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkstatusbookDataGridViewTextBoxColumn
            // 
            this.fkstatusbookDataGridViewTextBoxColumn.DataPropertyName = "fk_status_book";
            this.fkstatusbookDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.fkstatusbookDataGridViewTextBoxColumn.Name = "fkstatusbookDataGridViewTextBoxColumn";
            this.fkstatusbookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListeLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_accueil);
            this.Controls.Add(this.btn_supressionLivre);
            this.Controls.Add(this.btn_ajoutLivre);
            this.Controls.Add(this.lbl_SousTitre);
            this.Controls.Add(this.lbl_Titre);
            this.Name = "ListeLivres";
            this.Text = "Bibliothèque - ListeLivres";
            this.Load += new System.EventHandler(this.ListeLivres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.Label lbl_SousTitre;
        private System.Windows.Forms.Button btn_ajoutLivre;
        private System.Windows.Forms.Button btn_supressionLivre;
        private System.Windows.Forms.Button btn_accueil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bibliothequeBDDBindingSource;
        private bibliothequeBDD bibliothequeBDD;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private bibliothequeBDDTableAdapters.authorTableAdapter authorTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private bibliothequeBDDTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishdatebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkgenrebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkeditorbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkauthorbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkformatbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkstatusbookDataGridViewTextBoxColumn;
    }
}