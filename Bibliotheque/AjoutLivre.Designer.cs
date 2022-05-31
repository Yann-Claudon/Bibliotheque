namespace Bibliotheque
{
    partial class AjoutLivre
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
            this.gbox_livre = new System.Windows.Forms.GroupBox();
            this.cmbbox_auteur = new System.Windows.Forms.ComboBox();
            this.bibliothequeBDD = new Bibliotheque.bibliothequeBDD();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.cmbbox_format = new System.Windows.Forms.ComboBox();
            this.cmbbox_etat = new System.Windows.Forms.ComboBox();
            this.cmbbox_edition = new System.Windows.Forms.ComboBox();
            this.txtbox_datePublication = new System.Windows.Forms.TextBox();
            this.txtbox_nom = new System.Windows.Forms.TextBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Bibliotheque.bibliothequeBDDTableAdapters.bookTableAdapter();
            this.bibliothequeBDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliothequeBDDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbox_livre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDDBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_livre
            // 
            this.gbox_livre.Controls.Add(this.listBox1);
            this.gbox_livre.Controls.Add(this.cmbbox_auteur);
            this.gbox_livre.Controls.Add(this.btn_annuler);
            this.gbox_livre.Controls.Add(this.btn_ajout);
            this.gbox_livre.Controls.Add(this.cmbbox_format);
            this.gbox_livre.Controls.Add(this.cmbbox_etat);
            this.gbox_livre.Controls.Add(this.cmbbox_edition);
            this.gbox_livre.Controls.Add(this.txtbox_datePublication);
            this.gbox_livre.Controls.Add(this.txtbox_nom);
            this.gbox_livre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_livre.Location = new System.Drawing.Point(12, 24);
            this.gbox_livre.Name = "gbox_livre";
            this.gbox_livre.Size = new System.Drawing.Size(223, 431);
            this.gbox_livre.TabIndex = 0;
            this.gbox_livre.TabStop = false;
            this.gbox_livre.Text = "Ajouter un livre";
            this.gbox_livre.Enter += new System.EventHandler(this.gbox_livre_Enter);
            // 
            // cmbbox_auteur
            // 
            this.cmbbox_auteur.DataSource = this.bibliothequeBDD;
            this.cmbbox_auteur.DisplayMember = "author.name_author";
            this.cmbbox_auteur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbox_auteur.FormattingEnabled = true;
            this.cmbbox_auteur.Location = new System.Drawing.Point(20, 330);
            this.cmbbox_auteur.Name = "cmbbox_auteur";
            this.cmbbox_auteur.Size = new System.Drawing.Size(149, 25);
            this.cmbbox_auteur.TabIndex = 8;
            this.cmbbox_auteur.ValueMember = "author.name_author";
            // 
            // bibliothequeBDD
            // 
            this.bibliothequeBDD.DataSetName = "bibliothequeBDD";
            this.bibliothequeBDD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(117, 388);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 7;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_ajout
            // 
            this.btn_ajout.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout.Location = new System.Drawing.Point(20, 388);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(75, 23);
            this.btn_ajout.TabIndex = 6;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            // 
            // cmbbox_format
            // 
            this.cmbbox_format.DataSource = this.bibliothequeBDD;
            this.cmbbox_format.DisplayMember = "format.name_format";
            this.cmbbox_format.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbox_format.FormattingEnabled = true;
            this.cmbbox_format.Location = new System.Drawing.Point(20, 286);
            this.cmbbox_format.Name = "cmbbox_format";
            this.cmbbox_format.Size = new System.Drawing.Size(149, 25);
            this.cmbbox_format.TabIndex = 5;
            // 
            // cmbbox_etat
            // 
            this.cmbbox_etat.DataSource = this.bibliothequeBDD;
            this.cmbbox_etat.DisplayMember = "status.name_status";
            this.cmbbox_etat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbox_etat.FormattingEnabled = true;
            this.cmbbox_etat.Location = new System.Drawing.Point(20, 235);
            this.cmbbox_etat.Name = "cmbbox_etat";
            this.cmbbox_etat.Size = new System.Drawing.Size(149, 25);
            this.cmbbox_etat.TabIndex = 4;
            // 
            // cmbbox_edition
            // 
            this.cmbbox_edition.DataSource = this.bibliothequeBDD;
            this.cmbbox_edition.DisplayMember = "editor.name_editor";
            this.cmbbox_edition.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbox_edition.FormattingEnabled = true;
            this.cmbbox_edition.Location = new System.Drawing.Point(20, 189);
            this.cmbbox_edition.Name = "cmbbox_edition";
            this.cmbbox_edition.Size = new System.Drawing.Size(149, 25);
            this.cmbbox_edition.TabIndex = 3;
            // 
            // txtbox_datePublication
            // 
            this.txtbox_datePublication.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_datePublication.Location = new System.Drawing.Point(20, 93);
            this.txtbox_datePublication.Name = "txtbox_datePublication";
            this.txtbox_datePublication.Size = new System.Drawing.Size(149, 25);
            this.txtbox_datePublication.TabIndex = 1;
            this.txtbox_datePublication.Text = "Année de publication";
            // 
            // txtbox_nom
            // 
            this.txtbox_nom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nom.Location = new System.Drawing.Point(20, 52);
            this.txtbox_nom.Name = "txtbox_nom";
            this.txtbox_nom.Size = new System.Drawing.Size(149, 25);
            this.txtbox_nom.TabIndex = 0;
            this.txtbox_nom.Text = "Nom du livre";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.bibliothequeBDD;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // bibliothequeBDDBindingSource
            // 
            this.bibliothequeBDDBindingSource.DataSource = this.bibliothequeBDD;
            this.bibliothequeBDDBindingSource.Position = 0;
            // 
            // bibliothequeBDDBindingSource1
            // 
            this.bibliothequeBDDBindingSource1.DataSource = this.bibliothequeBDD;
            this.bibliothequeBDDBindingSource1.Position = 0;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.bibliothequeBDD;
            this.listBox1.DisplayMember = "genre.name_genre";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(20, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 31);
            this.listBox1.TabIndex = 9;
            this.listBox1.ValueMember = "genre.name_genre";
            // 
            // AjoutLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 494);
            this.Controls.Add(this.gbox_livre);
            this.Name = "AjoutLivre";
            this.Text = "Bibliotheque - AjoutLivre";
            this.Load += new System.EventHandler(this.AjoutLivre_Load);
            this.gbox_livre.ResumeLayout(false);
            this.gbox_livre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeBDDBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_livre;
        private System.Windows.Forms.TextBox txtbox_nom;
        private System.Windows.Forms.TextBox txtbox_datePublication;
        private bibliothequeBDD bibliothequeBDD;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private bibliothequeBDDTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.ComboBox cmbbox_edition;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.ComboBox cmbbox_format;
        private System.Windows.Forms.ComboBox cmbbox_etat;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.BindingSource bibliothequeBDDBindingSource;
        private System.Windows.Forms.BindingSource bibliothequeBDDBindingSource1;
        private System.Windows.Forms.ComboBox cmbbox_auteur;
        private System.Windows.Forms.ListBox listBox1;
    }
}