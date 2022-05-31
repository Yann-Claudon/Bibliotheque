namespace Bibliotheque
{
    partial class AjoutAuteur
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
            this.grpBox_AjoutAuteur = new System.Windows.Forms.GroupBox();
            this.btn_annulerAuteur = new System.Windows.Forms.Button();
            this.txtbox_naissance = new System.Windows.Forms.TextBox();
            this.btn_ajouterAuteur = new System.Windows.Forms.Button();
            this.txtbox_nom = new System.Windows.Forms.TextBox();
            this.grpBox_AjoutAuteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_AjoutAuteur
            // 
            this.grpBox_AjoutAuteur.Controls.Add(this.btn_annulerAuteur);
            this.grpBox_AjoutAuteur.Controls.Add(this.txtbox_naissance);
            this.grpBox_AjoutAuteur.Controls.Add(this.btn_ajouterAuteur);
            this.grpBox_AjoutAuteur.Controls.Add(this.txtbox_nom);
            this.grpBox_AjoutAuteur.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_AjoutAuteur.Location = new System.Drawing.Point(12, 12);
            this.grpBox_AjoutAuteur.Name = "grpBox_AjoutAuteur";
            this.grpBox_AjoutAuteur.Size = new System.Drawing.Size(221, 171);
            this.grpBox_AjoutAuteur.TabIndex = 1;
            this.grpBox_AjoutAuteur.TabStop = false;
            this.grpBox_AjoutAuteur.Text = "Ajout Auteur";
            // 
            // btn_annulerAuteur
            // 
            this.btn_annulerAuteur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annulerAuteur.Location = new System.Drawing.Point(140, 125);
            this.btn_annulerAuteur.Name = "btn_annulerAuteur";
            this.btn_annulerAuteur.Size = new System.Drawing.Size(75, 23);
            this.btn_annulerAuteur.TabIndex = 5;
            this.btn_annulerAuteur.Text = "Annuler";
            this.btn_annulerAuteur.UseVisualStyleBackColor = true;
            // 
            // txtbox_naissance
            // 
            this.txtbox_naissance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_naissance.Location = new System.Drawing.Point(60, 73);
            this.txtbox_naissance.Name = "txtbox_naissance";
            this.txtbox_naissance.Size = new System.Drawing.Size(100, 25);
            this.txtbox_naissance.TabIndex = 4;
            this.txtbox_naissance.Text = "jj/mm/aaaa";
            // 
            // btn_ajouterAuteur
            // 
            this.btn_ajouterAuteur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterAuteur.Location = new System.Drawing.Point(6, 125);
            this.btn_ajouterAuteur.Name = "btn_ajouterAuteur";
            this.btn_ajouterAuteur.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouterAuteur.TabIndex = 2;
            this.btn_ajouterAuteur.Text = "Ajouter";
            this.btn_ajouterAuteur.UseVisualStyleBackColor = true;
            this.btn_ajouterAuteur.Click += new System.EventHandler(this.btn_ajouterAuteur_Click);
            // 
            // txtbox_nom
            // 
            this.txtbox_nom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nom.Location = new System.Drawing.Point(60, 30);
            this.txtbox_nom.Name = "txtbox_nom";
            this.txtbox_nom.Size = new System.Drawing.Size(100, 25);
            this.txtbox_nom.TabIndex = 0;
            this.txtbox_nom.Text = "Prénom Nom";
            // 
            // AjoutAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 200);
            this.Controls.Add(this.grpBox_AjoutAuteur);
            this.Name = "AjoutAuteur";
            this.Text = "Bibliothèeque - Ajout auteur";
            this.grpBox_AjoutAuteur.ResumeLayout(false);
            this.grpBox_AjoutAuteur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_AjoutAuteur;
        private System.Windows.Forms.Button btn_annulerAuteur;
        private System.Windows.Forms.TextBox txtbox_naissance;
        private System.Windows.Forms.Button btn_ajouterAuteur;
        private System.Windows.Forms.TextBox txtbox_nom;
    }
}