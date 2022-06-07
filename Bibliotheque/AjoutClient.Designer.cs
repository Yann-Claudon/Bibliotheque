namespace Bibliotheque
{
    partial class AjoutClient
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
            this.gBox_AjoutAuteur = new System.Windows.Forms.GroupBox();
            this.txtbox_ville_client = new System.Windows.Forms.TextBox();
            this.txtbox_prenom_client = new System.Windows.Forms.TextBox();
            this.btn_annulerClient = new System.Windows.Forms.Button();
            this.txtbox_telephone_client = new System.Windows.Forms.TextBox();
            this.btn_ajouterClient = new System.Windows.Forms.Button();
            this.txtbox_nom_client = new System.Windows.Forms.TextBox();
            this.gBox_AjoutAuteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_AjoutAuteur
            // 
            this.gBox_AjoutAuteur.Controls.Add(this.txtbox_ville_client);
            this.gBox_AjoutAuteur.Controls.Add(this.txtbox_prenom_client);
            this.gBox_AjoutAuteur.Controls.Add(this.btn_annulerClient);
            this.gBox_AjoutAuteur.Controls.Add(this.txtbox_telephone_client);
            this.gBox_AjoutAuteur.Controls.Add(this.btn_ajouterClient);
            this.gBox_AjoutAuteur.Controls.Add(this.txtbox_nom_client);
            this.gBox_AjoutAuteur.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_AjoutAuteur.Location = new System.Drawing.Point(12, 12);
            this.gBox_AjoutAuteur.Name = "gBox_AjoutAuteur";
            this.gBox_AjoutAuteur.Size = new System.Drawing.Size(221, 171);
            this.gBox_AjoutAuteur.TabIndex = 2;
            this.gBox_AjoutAuteur.TabStop = false;
            this.gBox_AjoutAuteur.Text = "Ajout Client";
            // 
            // txtbox_ville_client
            // 
            this.txtbox_ville_client.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_ville_client.Location = new System.Drawing.Point(121, 65);
            this.txtbox_ville_client.MaxLength = 5;
            this.txtbox_ville_client.Name = "txtbox_ville_client";
            this.txtbox_ville_client.Size = new System.Drawing.Size(100, 25);
            this.txtbox_ville_client.TabIndex = 7;
            this.txtbox_ville_client.Text = "Code Postal";
            this.txtbox_ville_client.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_ville_client_KeyPress);
            // 
            // txtbox_prenom_client
            // 
            this.txtbox_prenom_client.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_prenom_client.Location = new System.Drawing.Point(121, 34);
            this.txtbox_prenom_client.Name = "txtbox_prenom_client";
            this.txtbox_prenom_client.Size = new System.Drawing.Size(100, 25);
            this.txtbox_prenom_client.TabIndex = 6;
            this.txtbox_prenom_client.Text = "Prénom";
            // 
            // btn_annulerClient
            // 
            this.btn_annulerClient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annulerClient.Location = new System.Drawing.Point(140, 125);
            this.btn_annulerClient.Name = "btn_annulerClient";
            this.btn_annulerClient.Size = new System.Drawing.Size(75, 23);
            this.btn_annulerClient.TabIndex = 5;
            this.btn_annulerClient.Text = "Annuler";
            this.btn_annulerClient.UseVisualStyleBackColor = true;
            this.btn_annulerClient.Click += new System.EventHandler(this.btn_annulerClient_Click);
            // 
            // txtbox_telephone_client
            // 
            this.txtbox_telephone_client.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_telephone_client.Location = new System.Drawing.Point(6, 65);
            this.txtbox_telephone_client.MaxLength = 10;
            this.txtbox_telephone_client.Name = "txtbox_telephone_client";
            this.txtbox_telephone_client.Size = new System.Drawing.Size(100, 25);
            this.txtbox_telephone_client.TabIndex = 4;
            this.txtbox_telephone_client.Text = "Téléphone";
            this.txtbox_telephone_client.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_telephone_client_KeyPress);
            // 
            // btn_ajouterClient
            // 
            this.btn_ajouterClient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterClient.Location = new System.Drawing.Point(6, 125);
            this.btn_ajouterClient.Name = "btn_ajouterClient";
            this.btn_ajouterClient.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouterClient.TabIndex = 2;
            this.btn_ajouterClient.Text = "Ajouter";
            this.btn_ajouterClient.UseVisualStyleBackColor = true;
            this.btn_ajouterClient.Click += new System.EventHandler(this.btn_ajouterClient_Click);
            // 
            // txtbox_nom_client
            // 
            this.txtbox_nom_client.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nom_client.Location = new System.Drawing.Point(6, 34);
            this.txtbox_nom_client.Name = "txtbox_nom_client";
            this.txtbox_nom_client.Size = new System.Drawing.Size(100, 25);
            this.txtbox_nom_client.TabIndex = 0;
            this.txtbox_nom_client.Text = "Nom";
            this.txtbox_nom_client.UseWaitCursor = true;
            // 
            // AjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 188);
            this.Controls.Add(this.gBox_AjoutAuteur);
            this.Name = "AjoutClient";
            this.Text = "Form1";
            this.gBox_AjoutAuteur.ResumeLayout(false);
            this.gBox_AjoutAuteur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_AjoutAuteur;
        private System.Windows.Forms.Button btn_annulerClient;
        private System.Windows.Forms.TextBox txtbox_telephone_client;
        private System.Windows.Forms.Button btn_ajouterClient;
        private System.Windows.Forms.TextBox txtbox_nom_client;
        private System.Windows.Forms.TextBox txtbox_prenom_client;
        private System.Windows.Forms.TextBox txtbox_ville_client;
    }
}