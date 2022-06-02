namespace Bibliotheque
{
    partial class ListeFormats
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
            this.btn_modifFormat = new System.Windows.Forms.Button();
            this.dgridview_editeur = new System.Windows.Forms.DataGridView();
            this.txtbox_searchEditeur = new System.Windows.Forms.TextBox();
            this.btn_supprEditeur = new System.Windows.Forms.Button();
            this.btn_ajoutFormat = new System.Windows.Forms.Button();
            this.btn_accueilFormat = new System.Windows.Forms.Button();
            this.lbl_soustitre_format = new System.Windows.Forms.Label();
            this.lbl_titre_format = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_editeur)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modifFormat
            // 
            this.btn_modifFormat.Location = new System.Drawing.Point(332, 166);
            this.btn_modifFormat.Name = "btn_modifFormat";
            this.btn_modifFormat.Size = new System.Drawing.Size(115, 23);
            this.btn_modifFormat.TabIndex = 23;
            this.btn_modifFormat.Text = "Modification format";
            this.btn_modifFormat.UseVisualStyleBackColor = true;
            // 
            // dgridview_editeur
            // 
            this.dgridview_editeur.AllowUserToAddRows = false;
            this.dgridview_editeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridview_editeur.Location = new System.Drawing.Point(37, 213);
            this.dgridview_editeur.Name = "dgridview_editeur";
            this.dgridview_editeur.Size = new System.Drawing.Size(744, 218);
            this.dgridview_editeur.TabIndex = 22;
            // 
            // txtbox_searchEditeur
            // 
            this.txtbox_searchEditeur.Location = new System.Drawing.Point(37, 166);
            this.txtbox_searchEditeur.Name = "txtbox_searchEditeur";
            this.txtbox_searchEditeur.Size = new System.Drawing.Size(100, 20);
            this.txtbox_searchEditeur.TabIndex = 21;
            // 
            // btn_supprEditeur
            // 
            this.btn_supprEditeur.Location = new System.Drawing.Point(497, 166);
            this.btn_supprEditeur.Name = "btn_supprEditeur";
            this.btn_supprEditeur.Size = new System.Drawing.Size(118, 23);
            this.btn_supprEditeur.TabIndex = 20;
            this.btn_supprEditeur.Text = "Suppression editeur";
            this.btn_supprEditeur.UseVisualStyleBackColor = true;
            // 
            // btn_ajoutFormat
            // 
            this.btn_ajoutFormat.Location = new System.Drawing.Point(204, 166);
            this.btn_ajoutFormat.Name = "btn_ajoutFormat";
            this.btn_ajoutFormat.Size = new System.Drawing.Size(75, 23);
            this.btn_ajoutFormat.TabIndex = 19;
            this.btn_ajoutFormat.Text = "Ajout format";
            this.btn_ajoutFormat.UseVisualStyleBackColor = true;
            // 
            // btn_accueilFormat
            // 
            this.btn_accueilFormat.Location = new System.Drawing.Point(20, 22);
            this.btn_accueilFormat.Name = "btn_accueilFormat";
            this.btn_accueilFormat.Size = new System.Drawing.Size(103, 23);
            this.btn_accueilFormat.TabIndex = 18;
            this.btn_accueilFormat.Text = "Retour à l\'accueil";
            this.btn_accueilFormat.UseVisualStyleBackColor = true;
            // 
            // lbl_soustitre_format
            // 
            this.lbl_soustitre_format.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soustitre_format.Location = new System.Drawing.Point(327, 88);
            this.lbl_soustitre_format.Name = "lbl_soustitre_format";
            this.lbl_soustitre_format.Size = new System.Drawing.Size(160, 29);
            this.lbl_soustitre_format.TabIndex = 16;
            this.lbl_soustitre_format.Text = "Liste formats";
            // 
            // lbl_titre_format
            // 
            this.lbl_titre_format.AutoSize = true;
            this.lbl_titre_format.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_format.Location = new System.Drawing.Point(267, 19);
            this.lbl_titre_format.Name = "lbl_titre_format";
            this.lbl_titre_format.Size = new System.Drawing.Size(288, 55);
            this.lbl_titre_format.TabIndex = 17;
            this.lbl_titre_format.Text = "Bibliothèque";
            // 
            // ListeFormats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_modifFormat);
            this.Controls.Add(this.dgridview_editeur);
            this.Controls.Add(this.txtbox_searchEditeur);
            this.Controls.Add(this.btn_supprEditeur);
            this.Controls.Add(this.btn_ajoutFormat);
            this.Controls.Add(this.btn_accueilFormat);
            this.Controls.Add(this.lbl_soustitre_format);
            this.Controls.Add(this.lbl_titre_format);
            this.Name = "ListeFormats";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_editeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modifFormat;
        private System.Windows.Forms.DataGridView dgridview_editeur;
        private System.Windows.Forms.TextBox txtbox_searchEditeur;
        private System.Windows.Forms.Button btn_supprEditeur;
        private System.Windows.Forms.Button btn_ajoutFormat;
        private System.Windows.Forms.Button btn_accueilFormat;
        private System.Windows.Forms.Label lbl_soustitre_format;
        private System.Windows.Forms.Label lbl_titre_format;
    }
}