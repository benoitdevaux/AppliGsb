namespace gsb
{
    partial class frmAjoutRapport
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbAjoutRapport = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lbQuantite = new System.Windows.Forms.Label();
            this.lbMedicament = new System.Windows.Forms.Label();
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.btCreer = new System.Windows.Forms.Button();
            this.lvMedicament = new System.Windows.Forms.ListView();
            this.colMedicament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbBilan = new System.Windows.Forms.Label();
            this.lbMotif = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.cbMedecins = new System.Windows.Forms.ComboBox();
            this.lbMedecin = new System.Windows.Forms.Label();
            this.cbVisiteurs = new System.Windows.Forms.ComboBox();
            this.lbVisiteur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbAjoutRapport);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSupprimer);
            this.splitContainer1.Panel2.Controls.Add(this.btnAjouter);
            this.splitContainer1.Panel2.Controls.Add(this.txtQuantite);
            this.splitContainer1.Panel2.Controls.Add(this.lbQuantite);
            this.splitContainer1.Panel2.Controls.Add(this.lbMedicament);
            this.splitContainer1.Panel2.Controls.Add(this.cbMedicament);
            this.splitContainer1.Panel2.Controls.Add(this.btCreer);
            this.splitContainer1.Panel2.Controls.Add(this.lvMedicament);
            this.splitContainer1.Panel2.Controls.Add(this.txtBilan);
            this.splitContainer1.Panel2.Controls.Add(this.txtMotif);
            this.splitContainer1.Panel2.Controls.Add(this.txtDate);
            this.splitContainer1.Panel2.Controls.Add(this.lbBilan);
            this.splitContainer1.Panel2.Controls.Add(this.lbMotif);
            this.splitContainer1.Panel2.Controls.Add(this.lbDate);
            this.splitContainer1.Panel2.Controls.Add(this.cbMedecins);
            this.splitContainer1.Panel2.Controls.Add(this.lbMedecin);
            this.splitContainer1.Panel2.Controls.Add(this.cbVisiteurs);
            this.splitContainer1.Panel2.Controls.Add(this.lbVisiteur);
            this.splitContainer1.Size = new System.Drawing.Size(878, 588);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbAjoutRapport
            // 
            this.lbAjoutRapport.AutoSize = true;
            this.lbAjoutRapport.Location = new System.Drawing.Point(396, 49);
            this.lbAjoutRapport.Name = "lbAjoutRapport";
            this.lbAjoutRapport.Size = new System.Drawing.Size(123, 17);
            this.lbAjoutRapport.TabIndex = 0;
            this.lbAjoutRapport.Text = "Ajouter un rapport";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(777, 366);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(89, 39);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(656, 176);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(88, 39);
            this.btnAjouter.TabIndex = 16;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(656, 135);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(100, 22);
            this.txtQuantite.TabIndex = 15;
            // 
            // lbQuantite
            // 
            this.lbQuantite.AutoSize = true;
            this.lbQuantite.Location = new System.Drawing.Point(531, 135);
            this.lbQuantite.Name = "lbQuantite";
            this.lbQuantite.Size = new System.Drawing.Size(62, 17);
            this.lbQuantite.TabIndex = 14;
            this.lbQuantite.Text = "Quantite";
            // 
            // lbMedicament
            // 
            this.lbMedicament.AutoSize = true;
            this.lbMedicament.Location = new System.Drawing.Point(531, 91);
            this.lbMedicament.Name = "lbMedicament";
            this.lbMedicament.Size = new System.Drawing.Size(84, 17);
            this.lbMedicament.TabIndex = 13;
            this.lbMedicament.Text = "Medicament";
            // 
            // cbMedicament
            // 
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(656, 91);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(157, 24);
            this.cbMedicament.TabIndex = 12;
            // 
            // btCreer
            // 
            this.btCreer.Location = new System.Drawing.Point(29, 429);
            this.btCreer.Name = "btCreer";
            this.btCreer.Size = new System.Drawing.Size(103, 27);
            this.btCreer.TabIndex = 11;
            this.btCreer.Text = "Créer";
            this.btCreer.UseVisualStyleBackColor = true;
            this.btCreer.Click += new System.EventHandler(this.btCreer_Click);
            // 
            // lvMedicament
            // 
            this.lvMedicament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMedicament,
            this.colQuantite});
            this.lvMedicament.HideSelection = false;
            this.lvMedicament.Location = new System.Drawing.Point(29, 244);
            this.lvMedicament.Name = "lvMedicament";
            this.lvMedicament.Scrollable = false;
            this.lvMedicament.Size = new System.Drawing.Size(837, 116);
            this.lvMedicament.TabIndex = 10;
            this.lvMedicament.UseCompatibleStateImageBehavior = false;
            this.lvMedicament.View = System.Windows.Forms.View.Details;
            // 
            // colMedicament
            // 
            this.colMedicament.Text = "Médicaments offerts";
            this.colMedicament.Width = 368;
            // 
            // colQuantite
            // 
            this.colQuantite.Text = "Quantite";
            this.colQuantite.Width = 214;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(656, 30);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(156, 46);
            this.txtBilan.TabIndex = 9;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(117, 176);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(156, 54);
            this.txtMotif.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(117, 125);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(156, 22);
            this.txtDate.TabIndex = 7;
            // 
            // lbBilan
            // 
            this.lbBilan.AutoSize = true;
            this.lbBilan.Location = new System.Drawing.Point(529, 30);
            this.lbBilan.Name = "lbBilan";
            this.lbBilan.Size = new System.Drawing.Size(39, 17);
            this.lbBilan.TabIndex = 6;
            this.lbBilan.Text = "Bilan";
            // 
            // lbMotif
            // 
            this.lbMotif.AutoSize = true;
            this.lbMotif.Location = new System.Drawing.Point(26, 176);
            this.lbMotif.Name = "lbMotif";
            this.lbMotif.Size = new System.Drawing.Size(38, 17);
            this.lbMotif.TabIndex = 5;
            this.lbMotif.Text = "Motif";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(26, 125);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(38, 17);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "Date";
            // 
            // cbMedecins
            // 
            this.cbMedecins.FormattingEnabled = true;
            this.cbMedecins.Location = new System.Drawing.Point(117, 75);
            this.cbMedecins.Name = "cbMedecins";
            this.cbMedecins.Size = new System.Drawing.Size(156, 24);
            this.cbMedecins.TabIndex = 3;
            // 
            // lbMedecin
            // 
            this.lbMedecin.AutoSize = true;
            this.lbMedecin.Location = new System.Drawing.Point(26, 75);
            this.lbMedecin.Name = "lbMedecin";
            this.lbMedecin.Size = new System.Drawing.Size(68, 17);
            this.lbMedecin.TabIndex = 2;
            this.lbMedecin.Text = "Medecins";
            // 
            // cbVisiteurs
            // 
            this.cbVisiteurs.FormattingEnabled = true;
            this.cbVisiteurs.Location = new System.Drawing.Point(117, 34);
            this.cbVisiteurs.Name = "cbVisiteurs";
            this.cbVisiteurs.Size = new System.Drawing.Size(156, 24);
            this.cbVisiteurs.TabIndex = 1;
            // 
            // lbVisiteur
            // 
            this.lbVisiteur.AutoSize = true;
            this.lbVisiteur.Location = new System.Drawing.Point(26, 34);
            this.lbVisiteur.Name = "lbVisiteur";
            this.lbVisiteur.Size = new System.Drawing.Size(62, 17);
            this.lbVisiteur.TabIndex = 0;
            this.lbVisiteur.Text = "Visiteurs";
            // 
            // frmAjoutRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 588);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmAjoutRapport";
            this.Text = "frmAjoutRapport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAjoutRapport_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbAjoutRapport;
        private System.Windows.Forms.Button btCreer;
        private System.Windows.Forms.ListView lvMedicament;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lbBilan;
        private System.Windows.Forms.Label lbMotif;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox cbMedecins;
        private System.Windows.Forms.Label lbMedecin;
        private System.Windows.Forms.ComboBox cbVisiteurs;
        private System.Windows.Forms.Label lbVisiteur;
        private System.Windows.Forms.ColumnHeader colMedicament;
        private System.Windows.Forms.ColumnHeader colQuantite;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label lbQuantite;
        private System.Windows.Forms.Label lbMedicament;
        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
    }
}