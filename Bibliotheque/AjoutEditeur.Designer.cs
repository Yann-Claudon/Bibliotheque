namespace Bibliotheque
{
    partial class AjoutEditeur
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
            this.gBox_ajoutEditeur = new System.Windows.Forms.GroupBox();
            this.btn_annulerEditeur = new System.Windows.Forms.Button();
            this.btn_ajouterEditeur = new System.Windows.Forms.Button();
            this.txtbox_nom = new System.Windows.Forms.TextBox();
            this.gBox_ajoutEditeur.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_ajoutEditeur
            // 
            this.gBox_ajoutEditeur.Controls.Add(this.btn_annulerEditeur);
            this.gBox_ajoutEditeur.Controls.Add(this.btn_ajouterEditeur);
            this.gBox_ajoutEditeur.Controls.Add(this.txtbox_nom);
            this.gBox_ajoutEditeur.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_ajoutEditeur.Location = new System.Drawing.Point(12, 12);
            this.gBox_ajoutEditeur.Name = "gBox_ajoutEditeur";
            this.gBox_ajoutEditeur.Size = new System.Drawing.Size(221, 171);
            this.gBox_ajoutEditeur.TabIndex = 2;
            this.gBox_ajoutEditeur.TabStop = false;
            this.gBox_ajoutEditeur.Text = "Ajout Editeur";
            // 
            // btn_annulerEditeur
            // 
            this.btn_annulerEditeur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annulerEditeur.Location = new System.Drawing.Point(140, 125);
            this.btn_annulerEditeur.Name = "btn_annulerEditeur";
            this.btn_annulerEditeur.Size = new System.Drawing.Size(75, 23);
            this.btn_annulerEditeur.TabIndex = 5;
            this.btn_annulerEditeur.Text = "Annuler";
            this.btn_annulerEditeur.UseVisualStyleBackColor = true;
            this.btn_annulerEditeur.Click += new System.EventHandler(this.btn_annulerEditeur_Click);
            // 
            // btn_ajouterEditeur
            // 
            this.btn_ajouterEditeur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterEditeur.Location = new System.Drawing.Point(6, 125);
            this.btn_ajouterEditeur.Name = "btn_ajouterEditeur";
            this.btn_ajouterEditeur.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouterEditeur.TabIndex = 2;
            this.btn_ajouterEditeur.Text = "Ajouter";
            this.btn_ajouterEditeur.UseVisualStyleBackColor = true;
            this.btn_ajouterEditeur.Click += new System.EventHandler(this.btn_ajouterEditeur_Click);
            // 
            // txtbox_nom
            // 
            this.txtbox_nom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nom.Location = new System.Drawing.Point(58, 55);
            this.txtbox_nom.Name = "txtbox_nom";
            this.txtbox_nom.Size = new System.Drawing.Size(100, 25);
            this.txtbox_nom.TabIndex = 0;
            this.txtbox_nom.Text = "Editeur";
            // 
            // AjoutEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 191);
            this.Controls.Add(this.gBox_ajoutEditeur);
            this.Name = "AjoutEditeur";
            this.Text = "Bibliothèque - Ajout éditeur";
            this.gBox_ajoutEditeur.ResumeLayout(false);
            this.gBox_ajoutEditeur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_ajoutEditeur;
        private System.Windows.Forms.Button btn_annulerEditeur;
        private System.Windows.Forms.Button btn_ajouterEditeur;
        private System.Windows.Forms.TextBox txtbox_nom;
    }
}