namespace gsb
{
    partial class frmStatistiques
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
            this.lbStatistique = new System.Windows.Forms.Label();
            this.lvRapports = new System.Windows.Forms.ListView();
            this.colAnnee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRapports = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btActualiser = new System.Windows.Forms.Button();
            this.txtMedicament = new System.Windows.Forms.TextBox();
            this.txtMedecin = new System.Windows.Forms.TextBox();
            this.txtRapport = new System.Windows.Forms.TextBox();
            this.lbRapport = new System.Windows.Forms.Label();
            this.lbMedicaments = new System.Windows.Forms.Label();
            this.lbMedecin = new System.Windows.Forms.Label();
            this.lbRapportAnnee = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.lbStatistique);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvRapports);
            this.splitContainer1.Panel2.Controls.Add(this.btActualiser);
            this.splitContainer1.Panel2.Controls.Add(this.txtMedicament);
            this.splitContainer1.Panel2.Controls.Add(this.txtMedecin);
            this.splitContainer1.Panel2.Controls.Add(this.txtRapport);
            this.splitContainer1.Panel2.Controls.Add(this.lbRapport);
            this.splitContainer1.Panel2.Controls.Add(this.lbMedicaments);
            this.splitContainer1.Panel2.Controls.Add(this.lbMedecin);
            this.splitContainer1.Panel2.Controls.Add(this.lbRapportAnnee);
            this.splitContainer1.Size = new System.Drawing.Size(628, 536);
            this.splitContainer1.SplitterDistance = 84;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbStatistique
            // 
            this.lbStatistique.AutoSize = true;
            this.lbStatistique.Location = new System.Drawing.Point(279, 37);
            this.lbStatistique.Name = "lbStatistique";
            this.lbStatistique.Size = new System.Drawing.Size(74, 17);
            this.lbStatistique.TabIndex = 0;
            this.lbStatistique.Text = "Statistique";
            // 
            // lvRapports
            // 
            this.lvRapports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAnnee,
            this.colRapports});
            this.lvRapports.HideSelection = false;
            this.lvRapports.Location = new System.Drawing.Point(21, 51);
            this.lvRapports.Name = "lvRapports";
            this.lvRapports.Scrollable = false;
            this.lvRapports.Size = new System.Drawing.Size(282, 290);
            this.lvRapports.TabIndex = 11;
            this.lvRapports.UseCompatibleStateImageBehavior = false;
            this.lvRapports.View = System.Windows.Forms.View.Details;
            this.lvRapports.SelectedIndexChanged += new System.EventHandler(this.lvRapports_SelectedIndexChanged);
            // 
            // colAnnee
            // 
            this.colAnnee.Text = "Année";
            this.colAnnee.Width = 205;
            // 
            // colRapports
            // 
            this.colRapports.Text = "Rapports";
            this.colRapports.Width = 214;
            // 
            // btActualiser
            // 
            this.btActualiser.Location = new System.Drawing.Point(510, 392);
            this.btActualiser.Name = "btActualiser";
            this.btActualiser.Size = new System.Drawing.Size(88, 29);
            this.btActualiser.TabIndex = 8;
            this.btActualiser.Text = "Actualiser";
            this.btActualiser.UseVisualStyleBackColor = true;
            this.btActualiser.Click += new System.EventHandler(this.btActualiser_Click);
            // 
            // txtMedicament
            // 
            this.txtMedicament.Enabled = false;
            this.txtMedicament.Location = new System.Drawing.Point(392, 163);
            this.txtMedicament.Name = "txtMedicament";
            this.txtMedicament.Size = new System.Drawing.Size(100, 22);
            this.txtMedicament.TabIndex = 7;
            // 
            // txtMedecin
            // 
            this.txtMedecin.Enabled = false;
            this.txtMedecin.Location = new System.Drawing.Point(392, 81);
            this.txtMedecin.Name = "txtMedecin";
            this.txtMedecin.Size = new System.Drawing.Size(100, 22);
            this.txtMedecin.TabIndex = 6;
            // 
            // txtRapport
            // 
            this.txtRapport.Enabled = false;
            this.txtRapport.Location = new System.Drawing.Point(15, 399);
            this.txtRapport.Name = "txtRapport";
            this.txtRapport.Size = new System.Drawing.Size(100, 22);
            this.txtRapport.TabIndex = 5;
            // 
            // lbRapport
            // 
            this.lbRapport.AutoSize = true;
            this.lbRapport.Location = new System.Drawing.Point(12, 369);
            this.lbRapport.Name = "lbRapport";
            this.lbRapport.Size = new System.Drawing.Size(135, 17);
            this.lbRapport.TabIndex = 4;
            this.lbRapport.Text = "Nombre de rapports";
            // 
            // lbMedicaments
            // 
            this.lbMedicaments.AutoSize = true;
            this.lbMedicaments.Location = new System.Drawing.Point(389, 129);
            this.lbMedicaments.Name = "lbMedicaments";
            this.lbMedicaments.Size = new System.Drawing.Size(165, 17);
            this.lbMedicaments.TabIndex = 3;
            this.lbMedicaments.Text = "Nombre de médicaments";
            // 
            // lbMedecin
            // 
            this.lbMedecin.AutoSize = true;
            this.lbMedecin.Location = new System.Drawing.Point(389, 51);
            this.lbMedecin.Name = "lbMedecin";
            this.lbMedecin.Size = new System.Drawing.Size(142, 17);
            this.lbMedecin.TabIndex = 2;
            this.lbMedecin.Text = "Nombre de médecins";
            // 
            // lbRapportAnnee
            // 
            this.lbRapportAnnee.AutoSize = true;
            this.lbRapportAnnee.Location = new System.Drawing.Point(12, 21);
            this.lbRapportAnnee.Name = "lbRapportAnnee";
            this.lbRapportAnnee.Size = new System.Drawing.Size(211, 17);
            this.lbRapportAnnee.TabIndex = 1;
            this.lbRapportAnnee.Text = "Nombre de rapports par années";
            // 
            // frmStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 536);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmStatistiques";
            this.Text = "Statistiques";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStatistiques_Load);
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
        private System.Windows.Forms.Label lbStatistique;
        private System.Windows.Forms.TextBox txtMedicament;
        private System.Windows.Forms.TextBox txtMedecin;
        private System.Windows.Forms.TextBox txtRapport;
        private System.Windows.Forms.Label lbRapport;
        private System.Windows.Forms.Label lbMedicaments;
        private System.Windows.Forms.Label lbMedecin;
        private System.Windows.Forms.Label lbRapportAnnee;
        private System.Windows.Forms.Button btActualiser;
        private System.Windows.Forms.ListView lvRapports;
        private System.Windows.Forms.ColumnHeader colAnnee;
        private System.Windows.Forms.ColumnHeader colRapports;
    }
}