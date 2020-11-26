namespace gsb
{
    partial class frmRapport
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
            this.lbVisiteur = new System.Windows.Forms.Label();
            this.lbMedecin = new System.Windows.Forms.Label();
            this.lbRapports = new System.Windows.Forms.Label();
            this.lbVisiteurTitle = new System.Windows.Forms.Label();
            this.lbVisiteurNom = new System.Windows.Forms.Label();
            this.lbVisiteurPrenom = new System.Windows.Forms.Label();
            this.lbVisiteurMotifs = new System.Windows.Forms.Label();
            this.lbVisiteurDate = new System.Windows.Forms.Label();
            this.lbVisiteurBilan = new System.Windows.Forms.Label();
            this.cbVisiteur = new System.Windows.Forms.ComboBox();
            this.cbMedecins = new System.Windows.Forms.ComboBox();
            this.listRapports = new System.Windows.Forms.ListBox();
            this.txtNomVisiteur = new System.Windows.Forms.TextBox();
            this.txtPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbMedecinsTitre = new System.Windows.Forms.Label();
            this.lbMedecinNom = new System.Windows.Forms.Label();
            this.lbMedecinPrenom = new System.Windows.Forms.Label();
            this.lbMedecinAdresse = new System.Windows.Forms.Label();
            this.txtNomMedecin = new System.Windows.Forms.TextBox();
            this.txtPrenomMedecin = new System.Windows.Forms.TextBox();
            this.txtAdresseMedecin = new System.Windows.Forms.TextBox();
            this.lvMedicaments = new System.Windows.Forms.ListView();
            this.colMedicament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRechercher1 = new System.Windows.Forms.Button();
            this.btRechercher2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVisiteur
            // 
            this.lbVisiteur.AutoSize = true;
            this.lbVisiteur.Location = new System.Drawing.Point(22, 22);
            this.lbVisiteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVisiteur.Name = "lbVisiteur";
            this.lbVisiteur.Size = new System.Drawing.Size(41, 13);
            this.lbVisiteur.TabIndex = 0;
            this.lbVisiteur.Text = "Visiteur";
            // 
            // lbMedecin
            // 
            this.lbMedecin.AutoSize = true;
            this.lbMedecin.Location = new System.Drawing.Point(22, 50);
            this.lbMedecin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMedecin.Name = "lbMedecin";
            this.lbMedecin.Size = new System.Drawing.Size(53, 13);
            this.lbMedecin.TabIndex = 1;
            this.lbMedecin.Text = "Medecins";
            // 
            // lbRapports
            // 
            this.lbRapports.AutoSize = true;
            this.lbRapports.Location = new System.Drawing.Point(22, 80);
            this.lbRapports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRapports.Name = "lbRapports";
            this.lbRapports.Size = new System.Drawing.Size(97, 13);
            this.lbRapports.TabIndex = 2;
            this.lbRapports.Text = "Rapports de visites";
            // 
            // lbVisiteurTitle
            // 
            this.lbVisiteurTitle.AutoSize = true;
            this.lbVisiteurTitle.Location = new System.Drawing.Point(22, 170);
            this.lbVisiteurTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVisiteurTitle.Name = "lbVisiteurTitle";
            this.lbVisiteurTitle.Size = new System.Drawing.Size(46, 13);
            this.lbVisiteurTitle.TabIndex = 3;
            this.lbVisiteurTitle.Text = "Visiteurs";
            // 
            // lbVisiteurNom
            // 
            this.lbVisiteurNom.AutoSize = true;
            this.lbVisiteurNom.Location = new System.Drawing.Point(43, 210);
            this.lbVisiteurNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVisiteurNom.Name = "lbVisiteurNom";
            this.lbVisiteurNom.Size = new System.Drawing.Size(29, 13);
            this.lbVisiteurNom.TabIndex = 4;
            this.lbVisiteurNom.Text = "Nom";
            // 
            // lbVisiteurPrenom
            // 
            this.lbVisiteurPrenom.AutoSize = true;
            this.lbVisiteurPrenom.Location = new System.Drawing.Point(43, 245);
            this.lbVisiteurPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVisiteurPrenom.Name = "lbVisiteurPrenom";
            this.lbVisiteurPrenom.Size = new System.Drawing.Size(43, 13);
            this.lbVisiteurPrenom.TabIndex = 5;
            this.lbVisiteurPrenom.Text = "Prénom";
            // 
            // lbVisiteurMotifs
            // 
            this.lbVisiteurMotifs.AutoSize = true;
            this.lbVisiteurMotifs.Location = new System.Drawing.Point(43, 279);
            this.lbVisiteurMotifs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVisiteurMotifs.Name = "lbVisiteurMotifs";
            this.lbVisiteurMotifs.Size = new System.Drawing.Size(83, 13);
            this.lbVisiteurMotifs.TabIndex = 6;
            this.lbVisiteurMotifs.Text = "Motif de la visite";
            // 
            // lbVisiteurDate
            // 
            this.lbVisiteurDate.AutoSize = true;
            this.lbVisiteurDate.Location = new System.Drawing.Point(43, 312);
            this.lbVisiteurDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVisiteurDate.Name = "lbVisiteurDate";
            this.lbVisiteurDate.Size = new System.Drawing.Size(83, 13);
            this.lbVisiteurDate.TabIndex = 7;
            this.lbVisiteurDate.Text = "Date de la visite";
            // 
            // lbVisiteurBilan
            // 
            this.lbVisiteurBilan.AutoSize = true;
            this.lbVisiteurBilan.Location = new System.Drawing.Point(43, 339);
            this.lbVisiteurBilan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVisiteurBilan.Name = "lbVisiteurBilan";
            this.lbVisiteurBilan.Size = new System.Drawing.Size(30, 13);
            this.lbVisiteurBilan.TabIndex = 8;
            this.lbVisiteurBilan.Text = "Bilan";
            // 
            // cbVisiteur
            // 
            this.cbVisiteur.FormattingEnabled = true;
            this.cbVisiteur.Location = new System.Drawing.Point(148, 22);
            this.cbVisiteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVisiteur.Name = "cbVisiteur";
            this.cbVisiteur.Size = new System.Drawing.Size(178, 21);
            this.cbVisiteur.TabIndex = 9;
            // 
            // cbMedecins
            // 
            this.cbMedecins.FormattingEnabled = true;
            this.cbMedecins.Location = new System.Drawing.Point(148, 50);
            this.cbMedecins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMedecins.Name = "cbMedecins";
            this.cbMedecins.Size = new System.Drawing.Size(178, 21);
            this.cbMedecins.TabIndex = 10;
            // 
            // listRapports
            // 
            this.listRapports.FormattingEnabled = true;
            this.listRapports.Location = new System.Drawing.Point(148, 80);
            this.listRapports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listRapports.Name = "listRapports";
            this.listRapports.Size = new System.Drawing.Size(178, 69);
            this.listRapports.TabIndex = 11;
            this.listRapports.SelectedIndexChanged += new System.EventHandler(this.listRapports_SelectedIndexChanged);
            // 
            // txtNomVisiteur
            // 
            this.txtNomVisiteur.Location = new System.Drawing.Point(165, 210);
            this.txtNomVisiteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomVisiteur.Name = "txtNomVisiteur";
            this.txtNomVisiteur.ReadOnly = true;
            this.txtNomVisiteur.Size = new System.Drawing.Size(102, 20);
            this.txtNomVisiteur.TabIndex = 12;
            // 
            // txtPrenomVisiteur
            // 
            this.txtPrenomVisiteur.Location = new System.Drawing.Point(165, 245);
            this.txtPrenomVisiteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrenomVisiteur.Name = "txtPrenomVisiteur";
            this.txtPrenomVisiteur.ReadOnly = true;
            this.txtPrenomVisiteur.Size = new System.Drawing.Size(102, 20);
            this.txtPrenomVisiteur.TabIndex = 13;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(165, 279);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.ReadOnly = true;
            this.txtMotif.Size = new System.Drawing.Size(102, 20);
            this.txtMotif.TabIndex = 14;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(165, 339);
            this.txtBilan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.ReadOnly = true;
            this.txtBilan.Size = new System.Drawing.Size(381, 56);
            this.txtBilan.TabIndex = 15;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(165, 310);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(102, 20);
            this.txtDate.TabIndex = 16;
            // 
            // lbMedecinsTitre
            // 
            this.lbMedecinsTitre.AutoSize = true;
            this.lbMedecinsTitre.Location = new System.Drawing.Point(345, 170);
            this.lbMedecinsTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMedecinsTitre.Name = "lbMedecinsTitre";
            this.lbMedecinsTitre.Size = new System.Drawing.Size(48, 13);
            this.lbMedecinsTitre.TabIndex = 17;
            this.lbMedecinsTitre.Text = "Médecin";
            // 
            // lbMedecinNom
            // 
            this.lbMedecinNom.AutoSize = true;
            this.lbMedecinNom.Location = new System.Drawing.Point(370, 209);
            this.lbMedecinNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMedecinNom.Name = "lbMedecinNom";
            this.lbMedecinNom.Size = new System.Drawing.Size(29, 13);
            this.lbMedecinNom.TabIndex = 18;
            this.lbMedecinNom.Text = "Nom";
            // 
            // lbMedecinPrenom
            // 
            this.lbMedecinPrenom.AutoSize = true;
            this.lbMedecinPrenom.Location = new System.Drawing.Point(370, 245);
            this.lbMedecinPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMedecinPrenom.Name = "lbMedecinPrenom";
            this.lbMedecinPrenom.Size = new System.Drawing.Size(43, 13);
            this.lbMedecinPrenom.TabIndex = 19;
            this.lbMedecinPrenom.Text = "Prénom";
            // 
            // lbMedecinAdresse
            // 
            this.lbMedecinAdresse.AutoSize = true;
            this.lbMedecinAdresse.Location = new System.Drawing.Point(370, 279);
            this.lbMedecinAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMedecinAdresse.Name = "lbMedecinAdresse";
            this.lbMedecinAdresse.Size = new System.Drawing.Size(45, 13);
            this.lbMedecinAdresse.TabIndex = 20;
            this.lbMedecinAdresse.Text = "Adresse";
            // 
            // txtNomMedecin
            // 
            this.txtNomMedecin.Location = new System.Drawing.Point(446, 210);
            this.txtNomMedecin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomMedecin.Name = "txtNomMedecin";
            this.txtNomMedecin.ReadOnly = true;
            this.txtNomMedecin.Size = new System.Drawing.Size(100, 20);
            this.txtNomMedecin.TabIndex = 21;
            // 
            // txtPrenomMedecin
            // 
            this.txtPrenomMedecin.Location = new System.Drawing.Point(446, 243);
            this.txtPrenomMedecin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrenomMedecin.Name = "txtPrenomMedecin";
            this.txtPrenomMedecin.ReadOnly = true;
            this.txtPrenomMedecin.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomMedecin.TabIndex = 22;
            // 
            // txtAdresseMedecin
            // 
            this.txtAdresseMedecin.Location = new System.Drawing.Point(446, 279);
            this.txtAdresseMedecin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdresseMedecin.Name = "txtAdresseMedecin";
            this.txtAdresseMedecin.ReadOnly = true;
            this.txtAdresseMedecin.Size = new System.Drawing.Size(100, 20);
            this.txtAdresseMedecin.TabIndex = 23;
            // 
            // lvMedicaments
            // 
            this.lvMedicaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMedicament,
            this.colQuantite});
            this.lvMedicaments.HideSelection = false;
            this.lvMedicaments.Location = new System.Drawing.Point(25, 399);
            this.lvMedicaments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvMedicaments.Name = "lvMedicaments";
            this.lvMedicaments.Scrollable = false;
            this.lvMedicaments.Size = new System.Drawing.Size(529, 125);
            this.lvMedicaments.TabIndex = 24;
            this.lvMedicaments.UseCompatibleStateImageBehavior = false;
            this.lvMedicaments.View = System.Windows.Forms.View.Details;
            // 
            // colMedicament
            // 
            this.colMedicament.Text = "Médicaments offerts";
            this.colMedicament.Width = 435;
            // 
            // colQuantite
            // 
            this.colQuantite.Text = "Quantite";
            this.colQuantite.Width = 273;
            // 
            // btRechercher1
            // 
            this.btRechercher1.Location = new System.Drawing.Point(372, 20);
            this.btRechercher1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRechercher1.Name = "btRechercher1";
            this.btRechercher1.Size = new System.Drawing.Size(112, 24);
            this.btRechercher1.TabIndex = 25;
            this.btRechercher1.Text = "Rechercher";
            this.btRechercher1.UseVisualStyleBackColor = true;
            this.btRechercher1.Click += new System.EventHandler(this.btRechercher1_Click);
            // 
            // btRechercher2
            // 
            this.btRechercher2.Location = new System.Drawing.Point(372, 48);
            this.btRechercher2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRechercher2.Name = "btRechercher2";
            this.btRechercher2.Size = new System.Drawing.Size(112, 22);
            this.btRechercher2.TabIndex = 26;
            this.btRechercher2.Text = "Rechercher";
            this.btRechercher2.UseVisualStyleBackColor = true;
            this.btRechercher2.Click += new System.EventHandler(this.btRechercher2_Click);
            // 
            // frmRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 533);
            this.ControlBox = false;
            this.Controls.Add(this.btRechercher2);
            this.Controls.Add(this.btRechercher1);
            this.Controls.Add(this.lvMedicaments);
            this.Controls.Add(this.txtAdresseMedecin);
            this.Controls.Add(this.txtPrenomMedecin);
            this.Controls.Add(this.txtNomMedecin);
            this.Controls.Add(this.lbMedecinAdresse);
            this.Controls.Add(this.lbMedecinPrenom);
            this.Controls.Add(this.lbMedecinNom);
            this.Controls.Add(this.lbMedecinsTitre);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.txtPrenomVisiteur);
            this.Controls.Add(this.txtNomVisiteur);
            this.Controls.Add(this.listRapports);
            this.Controls.Add(this.cbMedecins);
            this.Controls.Add(this.cbVisiteur);
            this.Controls.Add(this.lbVisiteurBilan);
            this.Controls.Add(this.lbVisiteurDate);
            this.Controls.Add(this.lbVisiteurMotifs);
            this.Controls.Add(this.lbVisiteurPrenom);
            this.Controls.Add(this.lbVisiteurNom);
            this.Controls.Add(this.lbVisiteurTitle);
            this.Controls.Add(this.lbRapports);
            this.Controls.Add(this.lbMedecin);
            this.Controls.Add(this.lbVisiteur);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRapport";
            this.Text = "frmRapport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRapport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVisiteur;
        private System.Windows.Forms.Label lbMedecin;
        private System.Windows.Forms.Label lbRapports;
        private System.Windows.Forms.Label lbVisiteurTitle;
        private System.Windows.Forms.Label lbVisiteurNom;
        private System.Windows.Forms.Label lbVisiteurPrenom;
        private System.Windows.Forms.Label lbVisiteurMotifs;
        private System.Windows.Forms.Label lbVisiteurDate;
        private System.Windows.Forms.Label lbVisiteurBilan;
        private System.Windows.Forms.ComboBox cbVisiteur;
        private System.Windows.Forms.ComboBox cbMedecins;
        private System.Windows.Forms.ListBox listRapports;
        private System.Windows.Forms.TextBox txtNomVisiteur;
        private System.Windows.Forms.TextBox txtPrenomVisiteur;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lbMedecinsTitre;
        private System.Windows.Forms.Label lbMedecinNom;
        private System.Windows.Forms.Label lbMedecinPrenom;
        private System.Windows.Forms.Label lbMedecinAdresse;
        private System.Windows.Forms.TextBox txtNomMedecin;
        private System.Windows.Forms.TextBox txtPrenomMedecin;
        private System.Windows.Forms.TextBox txtAdresseMedecin;
        private System.Windows.Forms.ListView lvMedicaments;
        private System.Windows.Forms.Button btRechercher1;
        private System.Windows.Forms.Button btRechercher2;
        private System.Windows.Forms.ColumnHeader colMedicament;
        private System.Windows.Forms.ColumnHeader colQuantite;
    }
}