namespace Bibliotheque
{
    partial class ListeStatuts
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
            this.btn_modifStatut = new System.Windows.Forms.Button();
            this.dgridview_statut = new System.Windows.Forms.DataGridView();
            this.txtbox_searchStatut = new System.Windows.Forms.TextBox();
            this.btn_supprStatut = new System.Windows.Forms.Button();
            this.btn_ajoutStatut = new System.Windows.Forms.Button();
            this.btn_accueilStatut = new System.Windows.Forms.Button();
            this.lbl_soustitre_statut = new System.Windows.Forms.Label();
            this.lbl_titre_statut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_statut)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modifStatut
            // 
            this.btn_modifStatut.Location = new System.Drawing.Point(332, 166);
            this.btn_modifStatut.Name = "btn_modifStatut";
            this.btn_modifStatut.Size = new System.Drawing.Size(115, 23);
            this.btn_modifStatut.TabIndex = 39;
            this.btn_modifStatut.Text = "Modification statut";
            this.btn_modifStatut.UseVisualStyleBackColor = true;
            this.btn_modifStatut.Click += new System.EventHandler(this.btn_modifStatut_Click);
            // 
            // dgridview_statut
            // 
            this.dgridview_statut.AllowUserToAddRows = false;
            this.dgridview_statut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridview_statut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridview_statut.Location = new System.Drawing.Point(37, 213);
            this.dgridview_statut.Name = "dgridview_statut";
            this.dgridview_statut.Size = new System.Drawing.Size(744, 218);
            this.dgridview_statut.TabIndex = 38;
            // 
            // txtbox_searchStatut
            // 
            this.txtbox_searchStatut.Location = new System.Drawing.Point(37, 166);
            this.txtbox_searchStatut.Name = "txtbox_searchStatut";
            this.txtbox_searchStatut.Size = new System.Drawing.Size(100, 20);
            this.txtbox_searchStatut.TabIndex = 37;
            this.txtbox_searchStatut.Text = "Recherche statut";
            this.txtbox_searchStatut.TextChanged += new System.EventHandler(this.txtbox_searchStatut_TextChanged);
            // 
            // btn_supprStatut
            // 
            this.btn_supprStatut.Location = new System.Drawing.Point(497, 166);
            this.btn_supprStatut.Name = "btn_supprStatut";
            this.btn_supprStatut.Size = new System.Drawing.Size(118, 23);
            this.btn_supprStatut.TabIndex = 36;
            this.btn_supprStatut.Text = "Suppression statut";
            this.btn_supprStatut.UseVisualStyleBackColor = true;
            this.btn_supprStatut.Click += new System.EventHandler(this.btn_supprStatut_Click);
            // 
            // btn_ajoutStatut
            // 
            this.btn_ajoutStatut.Location = new System.Drawing.Point(204, 166);
            this.btn_ajoutStatut.Name = "btn_ajoutStatut";
            this.btn_ajoutStatut.Size = new System.Drawing.Size(75, 23);
            this.btn_ajoutStatut.TabIndex = 35;
            this.btn_ajoutStatut.Text = "Ajout statut";
            this.btn_ajoutStatut.UseVisualStyleBackColor = true;
            this.btn_ajoutStatut.Click += new System.EventHandler(this.btn_ajoutStatut_Click);
            // 
            // btn_accueilStatut
            // 
            this.btn_accueilStatut.Location = new System.Drawing.Point(20, 22);
            this.btn_accueilStatut.Name = "btn_accueilStatut";
            this.btn_accueilStatut.Size = new System.Drawing.Size(103, 23);
            this.btn_accueilStatut.TabIndex = 34;
            this.btn_accueilStatut.Text = "Retour à l\'accueil";
            this.btn_accueilStatut.UseVisualStyleBackColor = true;
            this.btn_accueilStatut.Click += new System.EventHandler(this.btn_accueilStatut_Click);
            // 
            // lbl_soustitre_statut
            // 
            this.lbl_soustitre_statut.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soustitre_statut.Location = new System.Drawing.Point(327, 88);
            this.lbl_soustitre_statut.Name = "lbl_soustitre_statut";
            this.lbl_soustitre_statut.Size = new System.Drawing.Size(160, 29);
            this.lbl_soustitre_statut.TabIndex = 32;
            this.lbl_soustitre_statut.Text = "Liste statuts";
            // 
            // lbl_titre_statut
            // 
            this.lbl_titre_statut.AutoSize = true;
            this.lbl_titre_statut.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_statut.Location = new System.Drawing.Point(267, 19);
            this.lbl_titre_statut.Name = "lbl_titre_statut";
            this.lbl_titre_statut.Size = new System.Drawing.Size(288, 55);
            this.lbl_titre_statut.TabIndex = 33;
            this.lbl_titre_statut.Text = "Bibliothèque";
            // 
            // ListeStatuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_modifStatut);
            this.Controls.Add(this.dgridview_statut);
            this.Controls.Add(this.txtbox_searchStatut);
            this.Controls.Add(this.btn_supprStatut);
            this.Controls.Add(this.btn_ajoutStatut);
            this.Controls.Add(this.btn_accueilStatut);
            this.Controls.Add(this.lbl_soustitre_statut);
            this.Controls.Add(this.lbl_titre_statut);
            this.Name = "ListeStatuts";
            this.Text = "ListeStatut";
            this.Load += new System.EventHandler(this.ListeStatuts_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_statut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modifStatut;
        private System.Windows.Forms.DataGridView dgridview_statut;
        private System.Windows.Forms.TextBox txtbox_searchStatut;
        private System.Windows.Forms.Button btn_supprStatut;
        private System.Windows.Forms.Button btn_ajoutStatut;
        private System.Windows.Forms.Button btn_accueilStatut;
        private System.Windows.Forms.Label lbl_soustitre_statut;
        private System.Windows.Forms.Label lbl_titre_statut;
    }
}