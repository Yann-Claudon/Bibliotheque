namespace Bibliotheque
{
    partial class RetourLivre
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
            this.gBox_RetourLivre = new System.Windows.Forms.GroupBox();
            this.cmbbox_livre = new System.Windows.Forms.ComboBox();
            this.date_retour = new System.Windows.Forms.DateTimePicker();
            this.date_pret = new System.Windows.Forms.DateTimePicker();
            this.cmbbox_nomClient = new System.Windows.Forms.ComboBox();
            this.btn_annulerAuteur = new System.Windows.Forms.Button();
            this.btn_ajouterAuteur = new System.Windows.Forms.Button();
            this.cmbboxetat = new System.Windows.Forms.ComboBox();
            this.gBox_RetourLivre.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_RetourLivre
            // 
            this.gBox_RetourLivre.Controls.Add(this.cmbboxetat);
            this.gBox_RetourLivre.Controls.Add(this.cmbbox_livre);
            this.gBox_RetourLivre.Controls.Add(this.date_retour);
            this.gBox_RetourLivre.Controls.Add(this.date_pret);
            this.gBox_RetourLivre.Controls.Add(this.cmbbox_nomClient);
            this.gBox_RetourLivre.Controls.Add(this.btn_annulerAuteur);
            this.gBox_RetourLivre.Controls.Add(this.btn_ajouterAuteur);
            this.gBox_RetourLivre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_RetourLivre.Location = new System.Drawing.Point(12, 12);
            this.gBox_RetourLivre.Name = "gBox_RetourLivre";
            this.gBox_RetourLivre.Size = new System.Drawing.Size(381, 330);
            this.gBox_RetourLivre.TabIndex = 3;
            this.gBox_RetourLivre.TabStop = false;
            this.gBox_RetourLivre.Text = "Retour Livre";
            // 
            // cmbbox_livre
            // 
            this.cmbbox_livre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbox_livre.FormattingEnabled = true;
            this.cmbbox_livre.Location = new System.Drawing.Point(6, 48);
            this.cmbbox_livre.Name = "cmbbox_livre";
            this.cmbbox_livre.Size = new System.Drawing.Size(136, 25);
            this.cmbbox_livre.TabIndex = 9;
            // 
            // date_retour
            // 
            this.date_retour.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_retour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_retour.Location = new System.Drawing.Point(6, 228);
            this.date_retour.Name = "date_retour";
            this.date_retour.Size = new System.Drawing.Size(135, 25);
            this.date_retour.TabIndex = 8;
            // 
            // date_pret
            // 
            this.date_pret.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_pret.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_pret.Location = new System.Drawing.Point(6, 185);
            this.date_pret.Name = "date_pret";
            this.date_pret.Size = new System.Drawing.Size(136, 25);
            this.date_pret.TabIndex = 7;
            // 
            // cmbbox_nomClient
            // 
            this.cmbbox_nomClient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbox_nomClient.FormattingEnabled = true;
            this.cmbbox_nomClient.Location = new System.Drawing.Point(6, 91);
            this.cmbbox_nomClient.Name = "cmbbox_nomClient";
            this.cmbbox_nomClient.Size = new System.Drawing.Size(136, 25);
            this.cmbbox_nomClient.TabIndex = 6;
            // 
            // btn_annulerAuteur
            // 
            this.btn_annulerAuteur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annulerAuteur.Location = new System.Drawing.Point(117, 289);
            this.btn_annulerAuteur.Name = "btn_annulerAuteur";
            this.btn_annulerAuteur.Size = new System.Drawing.Size(75, 23);
            this.btn_annulerAuteur.TabIndex = 5;
            this.btn_annulerAuteur.Text = "Annuler";
            this.btn_annulerAuteur.UseVisualStyleBackColor = true;
            this.btn_annulerAuteur.Click += new System.EventHandler(this.btn_annulerAuteur_Click);
            // 
            // btn_ajouterAuteur
            // 
            this.btn_ajouterAuteur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterAuteur.Location = new System.Drawing.Point(6, 289);
            this.btn_ajouterAuteur.Name = "btn_ajouterAuteur";
            this.btn_ajouterAuteur.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouterAuteur.TabIndex = 2;
            this.btn_ajouterAuteur.Text = "Ajouter";
            this.btn_ajouterAuteur.UseVisualStyleBackColor = true;
            this.btn_ajouterAuteur.Click += new System.EventHandler(this.btn_ajouterAuteur_Click);
            // 
            // cmbboxetat
            // 
            this.cmbboxetat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxetat.FormattingEnabled = true;
            this.cmbboxetat.Location = new System.Drawing.Point(6, 138);
            this.cmbboxetat.Name = "cmbboxetat";
            this.cmbboxetat.Size = new System.Drawing.Size(135, 25);
            this.cmbboxetat.TabIndex = 10;
            // 
            // RetourLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 373);
            this.Controls.Add(this.gBox_RetourLivre);
            this.Name = "RetourLivre";
            this.Text = "Bibliotheque - RetourLivre";
            this.gBox_RetourLivre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_RetourLivre;
        private System.Windows.Forms.ComboBox cmbbox_livre;
        private System.Windows.Forms.DateTimePicker date_retour;
        private System.Windows.Forms.DateTimePicker date_pret;
        private System.Windows.Forms.ComboBox cmbbox_nomClient;
        private System.Windows.Forms.Button btn_annulerAuteur;
        private System.Windows.Forms.Button btn_ajouterAuteur;
        private System.Windows.Forms.ComboBox cmbboxetat;
    }
}