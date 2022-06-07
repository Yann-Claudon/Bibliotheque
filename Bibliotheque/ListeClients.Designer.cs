namespace Bibliotheque
{
    partial class ListeClients
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
            this.dgridview_client = new System.Windows.Forms.DataGridView();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliothequeDataSet = new global::Bibliotheque.bibliothequeDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_supprClient = new System.Windows.Forms.Button();
            this.btn_ajoutClient = new System.Windows.Forms.Button();
            this.btn_accueil_clients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.authorTableAdapter = new global::Bibliotheque.bibliothequeDataSetTableAdapters.authorTableAdapter();
            this.btn_modif_client = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bibliothequeDataSet1 = new global::Bibliotheque.bibliothequeDataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new global::Bibliotheque.bibliothequeDataSet1TableAdapters.clientTableAdapter();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridview_client
            // 
            this.dgridview_client.AllowUserToAddRows = false;
            this.dgridview_client.AutoGenerateColumns = false;
            this.dgridview_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridview_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientDataGridViewTextBoxColumn,
            this.Nom,
            this.fnameclientDataGridViewTextBoxColumn,
            this.phoneclientDataGridViewTextBoxColumn,
            this.townclientDataGridViewTextBoxColumn});
            this.dgridview_client.DataSource = this.clientBindingSource;
            this.dgridview_client.Location = new System.Drawing.Point(37, 213);
            this.dgridview_client.Name = "dgridview_client";
            this.dgridview_client.Size = new System.Drawing.Size(744, 218);
            this.dgridview_client.TabIndex = 14;
            this.dgridview_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridview_client_CellContentClick);
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "author";
            this.authorBindingSource.DataSource = this.bibliothequeDataSet;
            // 
            // bibliothequeDataSet
            // 
            this.bibliothequeDataSet.DataSetName = "bibliothequeDataSet";
            this.bibliothequeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // btn_supprClient
            // 
            this.btn_supprClient.Location = new System.Drawing.Point(497, 166);
            this.btn_supprClient.Name = "btn_supprClient";
            this.btn_supprClient.Size = new System.Drawing.Size(118, 23);
            this.btn_supprClient.TabIndex = 12;
            this.btn_supprClient.Text = "Suppression client";
            this.btn_supprClient.UseVisualStyleBackColor = true;
            this.btn_supprClient.Click += new System.EventHandler(this.btn_supprClient_Click);
            // 
            // btn_ajoutClient
            // 
            this.btn_ajoutClient.Location = new System.Drawing.Point(204, 166);
            this.btn_ajoutClient.Name = "btn_ajoutClient";
            this.btn_ajoutClient.Size = new System.Drawing.Size(75, 23);
            this.btn_ajoutClient.TabIndex = 11;
            this.btn_ajoutClient.Text = "Ajout client";
            this.btn_ajoutClient.UseVisualStyleBackColor = true;
            this.btn_ajoutClient.Click += new System.EventHandler(this.btn_ajoutClient_Click);
            // 
            // btn_accueil_clients
            // 
            this.btn_accueil_clients.Location = new System.Drawing.Point(20, 22);
            this.btn_accueil_clients.Name = "btn_accueil_clients";
            this.btn_accueil_clients.Size = new System.Drawing.Size(103, 23);
            this.btn_accueil_clients.TabIndex = 10;
            this.btn_accueil_clients.Text = "Retour à l\'accueil";
            this.btn_accueil_clients.UseVisualStyleBackColor = true;
            this.btn_accueil_clients.Click += new System.EventHandler(this.btn_accueil_clients_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Liste clients";
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre.Location = new System.Drawing.Point(267, 19);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(288, 55);
            this.lbl_Titre.TabIndex = 9;
            this.lbl_Titre.Text = "Bibliothèque";
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // btn_modif_client
            // 
            this.btn_modif_client.Location = new System.Drawing.Point(332, 166);
            this.btn_modif_client.Name = "btn_modif_client";
            this.btn_modif_client.Size = new System.Drawing.Size(115, 23);
            this.btn_modif_client.TabIndex = 16;
            this.btn_modif_client.Text = "Modification client";
            this.btn_modif_client.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(623, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // bibliothequeDataSet1
            // 
            this.bibliothequeDataSet1.DataSetName = "bibliothequeDataSet1";
            this.bibliothequeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.bibliothequeDataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "ID Client";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclientDataGridViewTextBoxColumn.Width = 347;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.DataPropertyName = "name_client";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // fnameclientDataGridViewTextBoxColumn
            // 
            this.fnameclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameclientDataGridViewTextBoxColumn.DataPropertyName = "fname_client";
            this.fnameclientDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.fnameclientDataGridViewTextBoxColumn.Name = "fnameclientDataGridViewTextBoxColumn";
            // 
            // phoneclientDataGridViewTextBoxColumn
            // 
            this.phoneclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneclientDataGridViewTextBoxColumn.DataPropertyName = "phone_client";
            this.phoneclientDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.phoneclientDataGridViewTextBoxColumn.Name = "phoneclientDataGridViewTextBoxColumn";
            // 
            // townclientDataGridViewTextBoxColumn
            // 
            this.townclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.townclientDataGridViewTextBoxColumn.DataPropertyName = "town_client";
            this.townclientDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.townclientDataGridViewTextBoxColumn.Name = "townclientDataGridViewTextBoxColumn";
            // 
            // ListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgridview_client);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_supprClient);
            this.Controls.Add(this.btn_ajoutClient);
            this.Controls.Add(this.btn_accueil_clients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Titre);
            this.Controls.Add(this.btn_modif_client);
            this.Controls.Add(this.comboBox1);
            this.Name = "ListeClients";
            this.Text = "Bibliothèque - Liste clients";
            this.Load += new System.EventHandler(this.ListeClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridview_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridview_client;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private bibliothequeDataSet bibliothequeDataSet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_supprClient;
        private System.Windows.Forms.Button btn_ajoutClient;
        private System.Windows.Forms.Button btn_accueil_clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Titre;
        private bibliothequeDataSetTableAdapters.authorTableAdapter authorTableAdapter;
        private System.Windows.Forms.Button btn_modif_client;
        private System.Windows.Forms.ComboBox comboBox1;
        private bibliothequeDataSet1 bibliothequeDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private bibliothequeDataSet1TableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townclientDataGridViewTextBoxColumn;
    }
}