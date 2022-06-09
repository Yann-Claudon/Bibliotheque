namespace Bibliotheque
{
    partial class AjoutGenre
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
            this.gBox_ajoutGenre = new System.Windows.Forms.GroupBox();
            this.btn_annulerGenre = new System.Windows.Forms.Button();
            this.btn_ajouterGenre = new System.Windows.Forms.Button();
            this.txtbox_nom = new System.Windows.Forms.TextBox();
            this.gBox_ajoutGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_ajoutGenre
            // 
            this.gBox_ajoutGenre.Controls.Add(this.btn_annulerGenre);
            this.gBox_ajoutGenre.Controls.Add(this.btn_ajouterGenre);
            this.gBox_ajoutGenre.Controls.Add(this.txtbox_nom);
            this.gBox_ajoutGenre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_ajoutGenre.Location = new System.Drawing.Point(12, 12);
            this.gBox_ajoutGenre.Name = "gBox_ajoutGenre";
            this.gBox_ajoutGenre.Size = new System.Drawing.Size(221, 171);
            this.gBox_ajoutGenre.TabIndex = 5;
            this.gBox_ajoutGenre.TabStop = false;
            this.gBox_ajoutGenre.Text = "Ajout Genre";
            // 
            // btn_annulerGenre
            // 
            this.btn_annulerGenre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annulerGenre.Location = new System.Drawing.Point(140, 125);
            this.btn_annulerGenre.Name = "btn_annulerGenre";
            this.btn_annulerGenre.Size = new System.Drawing.Size(75, 23);
            this.btn_annulerGenre.TabIndex = 5;
            this.btn_annulerGenre.Text = "Annuler";
            this.btn_annulerGenre.UseVisualStyleBackColor = true;
            this.btn_annulerGenre.Click += new System.EventHandler(this.btn_annulerGenre_Click);
            // 
            // btn_ajouterGenre
            // 
            this.btn_ajouterGenre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterGenre.Location = new System.Drawing.Point(6, 125);
            this.btn_ajouterGenre.Name = "btn_ajouterGenre";
            this.btn_ajouterGenre.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouterGenre.TabIndex = 2;
            this.btn_ajouterGenre.Text = "Ajouter";
            this.btn_ajouterGenre.UseVisualStyleBackColor = true;
            this.btn_ajouterGenre.Click += new System.EventHandler(this.btn_ajouterGenre_Click);
            // 
            // txtbox_nom
            // 
            this.txtbox_nom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nom.Location = new System.Drawing.Point(58, 55);
            this.txtbox_nom.Name = "txtbox_nom";
            this.txtbox_nom.Size = new System.Drawing.Size(100, 25);
            this.txtbox_nom.TabIndex = 0;
            this.txtbox_nom.Text = "Genre";
            // 
            // AjoutGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 189);
            this.Controls.Add(this.gBox_ajoutGenre);
            this.Name = "AjoutGenre";
            this.Text = "Bibliothèque - Ajout genre";
            this.gBox_ajoutGenre.ResumeLayout(false);
            this.gBox_ajoutGenre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_ajoutGenre;
        private System.Windows.Forms.Button btn_annulerGenre;
        private System.Windows.Forms.Button btn_ajouterGenre;
        private System.Windows.Forms.TextBox txtbox_nom;
    }
}