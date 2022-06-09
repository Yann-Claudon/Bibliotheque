namespace Bibliotheque
{
    partial class AjoutFormat
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
            this.txtbox_nom = new System.Windows.Forms.TextBox();
            this.btn_ajouterFormat = new System.Windows.Forms.Button();
            this.btn_annulerFormat = new System.Windows.Forms.Button();
            this.gBox_ajoutFormat = new System.Windows.Forms.GroupBox();
            this.gBox_ajoutFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_nom
            // 
            this.txtbox_nom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nom.Location = new System.Drawing.Point(58, 55);
            this.txtbox_nom.Name = "txtbox_nom";
            this.txtbox_nom.Size = new System.Drawing.Size(100, 25);
            this.txtbox_nom.TabIndex = 0;
            this.txtbox_nom.Text = "Format";
            // 
            // btn_ajouterFormat
            // 
            this.btn_ajouterFormat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterFormat.Location = new System.Drawing.Point(6, 125);
            this.btn_ajouterFormat.Name = "btn_ajouterFormat";
            this.btn_ajouterFormat.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouterFormat.TabIndex = 2;
            this.btn_ajouterFormat.Text = "Ajouter";
            this.btn_ajouterFormat.UseVisualStyleBackColor = true;
            this.btn_ajouterFormat.Click += new System.EventHandler(this.btn_ajouterFormat_Click);
            // 
            // btn_annulerFormat
            // 
            this.btn_annulerFormat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annulerFormat.Location = new System.Drawing.Point(140, 125);
            this.btn_annulerFormat.Name = "btn_annulerFormat";
            this.btn_annulerFormat.Size = new System.Drawing.Size(75, 23);
            this.btn_annulerFormat.TabIndex = 5;
            this.btn_annulerFormat.Text = "Annuler";
            this.btn_annulerFormat.UseVisualStyleBackColor = true;
            this.btn_annulerFormat.Click += new System.EventHandler(this.btn_annulerFormat_Click);
            // 
            // gBox_ajoutFormat
            // 
            this.gBox_ajoutFormat.Controls.Add(this.btn_annulerFormat);
            this.gBox_ajoutFormat.Controls.Add(this.btn_ajouterFormat);
            this.gBox_ajoutFormat.Controls.Add(this.txtbox_nom);
            this.gBox_ajoutFormat.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_ajoutFormat.Location = new System.Drawing.Point(12, 12);
            this.gBox_ajoutFormat.Name = "gBox_ajoutFormat";
            this.gBox_ajoutFormat.Size = new System.Drawing.Size(221, 171);
            this.gBox_ajoutFormat.TabIndex = 3;
            this.gBox_ajoutFormat.TabStop = false;
            this.gBox_ajoutFormat.Text = "Bibliothèque - Ajout format";
            // 
            // AjoutFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 192);
            this.Controls.Add(this.gBox_ajoutFormat);
            this.Name = "AjoutFormat";
            this.Text = "Form1";
            this.gBox_ajoutFormat.ResumeLayout(false);
            this.gBox_ajoutFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_nom;
        private System.Windows.Forms.Button btn_ajouterFormat;
        private System.Windows.Forms.Button btn_annulerFormat;
        private System.Windows.Forms.GroupBox gBox_ajoutFormat;
    }
}