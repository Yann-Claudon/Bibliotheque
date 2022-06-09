namespace Bibliotheque
{
    partial class AjoutStatut
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
            this.gBox_ajoutStatut = new System.Windows.Forms.GroupBox();
            this.btn_annulerStatut = new System.Windows.Forms.Button();
            this.btn_ajouterStatut = new System.Windows.Forms.Button();
            this.txtbox_nom = new System.Windows.Forms.TextBox();
            this.gBox_ajoutStatut.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_ajoutStatut
            // 
            this.gBox_ajoutStatut.Controls.Add(this.btn_annulerStatut);
            this.gBox_ajoutStatut.Controls.Add(this.btn_ajouterStatut);
            this.gBox_ajoutStatut.Controls.Add(this.txtbox_nom);
            this.gBox_ajoutStatut.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_ajoutStatut.Location = new System.Drawing.Point(12, 12);
            this.gBox_ajoutStatut.Name = "gBox_ajoutStatut";
            this.gBox_ajoutStatut.Size = new System.Drawing.Size(221, 171);
            this.gBox_ajoutStatut.TabIndex = 5;
            this.gBox_ajoutStatut.TabStop = false;
            this.gBox_ajoutStatut.Text = "Ajout Statut";
            // 
            // btn_annulerStatut
            // 
            this.btn_annulerStatut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annulerStatut.Location = new System.Drawing.Point(140, 125);
            this.btn_annulerStatut.Name = "btn_annulerStatut";
            this.btn_annulerStatut.Size = new System.Drawing.Size(75, 23);
            this.btn_annulerStatut.TabIndex = 5;
            this.btn_annulerStatut.Text = "Annuler";
            this.btn_annulerStatut.UseVisualStyleBackColor = true;
            // 
            // btn_ajouterStatut
            // 
            this.btn_ajouterStatut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterStatut.Location = new System.Drawing.Point(6, 125);
            this.btn_ajouterStatut.Name = "btn_ajouterStatut";
            this.btn_ajouterStatut.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouterStatut.TabIndex = 2;
            this.btn_ajouterStatut.Text = "Ajouter";
            this.btn_ajouterStatut.UseVisualStyleBackColor = true;
            // 
            // txtbox_nom
            // 
            this.txtbox_nom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nom.Location = new System.Drawing.Point(58, 55);
            this.txtbox_nom.Name = "txtbox_nom";
            this.txtbox_nom.Size = new System.Drawing.Size(100, 25);
            this.txtbox_nom.TabIndex = 0;
            this.txtbox_nom.Text = "Statut";
            this.txtbox_nom.TextChanged += new System.EventHandler(this.txtbox_nom_TextChanged);
            // 
            // AjoutStatut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 188);
            this.Controls.Add(this.gBox_ajoutStatut);
            this.Name = "AjoutStatut";
            this.Text = "AjoutStatut";
            this.gBox_ajoutStatut.ResumeLayout(false);
            this.gBox_ajoutStatut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_ajoutStatut;
        private System.Windows.Forms.Button btn_annulerStatut;
        private System.Windows.Forms.Button btn_ajouterStatut;
        private System.Windows.Forms.TextBox txtbox_nom;
    }
}