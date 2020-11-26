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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
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
            this.splitContainer1.Size = new System.Drawing.Size(471, 436);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbStatistique
            // 
            this.lbStatistique.AutoSize = true;
            this.lbStatistique.Location = new System.Drawing.Point(209, 30);
            this.lbStatistique.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatistique.Name = "lbStatistique";
            this.lbStatistique.Size = new System.Drawing.Size(56, 13);
            this.lbStatistique.TabIndex = 0;
            this.lbStatistique.Text = "Statistique";
            // 
            // lvRapports
            // 
            this.lvRapports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAnnee,
            this.colRapports});
            this.lvRapports.HideSelection = false;
            this.lvRapports.Location = new System.Drawing.Point(16, 41);
            this.lvRapports.Margin = new System.Windows.Forms.Padding(2);
            this.lvRapports.Name = "lvRapports";
            this.lvRapports.Scrollable = false;
            this.lvRapports.Size = new System.Drawing.Size(212, 236);
            this.lvRapports.TabIndex = 11;
            this.lvRapports.UseCompatibleStateImageBehavior = false;
            this.lvRapports.View = System.Windows.Forms.View.Details;
            // 
            // colAnnee
            // 
            this.colAnnee.Text = "Année";
            this.colAnnee.Width = 111;
            // 
            // colRapports
            // 
            this.colRapports.Text = "Rapports";
            this.colRapports.Width = 214;
            // 
            // btActualiser
            // 
            this.btActualiser.Location = new System.Drawing.Point(382, 318);
            this.btActualiser.Margin = new System.Windows.Forms.Padding(2);
            this.btActualiser.Name = "btActualiser";
            this.btActualiser.Size = new System.Drawing.Size(66, 24);
            this.btActualiser.TabIndex = 8;
            this.btActualiser.Text = "Actualiser";
            this.btActualiser.UseVisualStyleBackColor = true;
            this.btActualiser.Click += new System.EventHandler(this.btActualiser_Click);
            // 
            // txtMedicament
            // 
            this.txtMedicament.Location = new System.Drawing.Point(294, 132);
            this.txtMedicament.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedicament.Name = "txtMedicament";
            this.txtMedicament.ReadOnly = true;
            this.txtMedicament.Size = new System.Drawing.Size(76, 20);
            this.txtMedicament.TabIndex = 7;
            // 
            // txtMedecin
            // 
            this.txtMedecin.Location = new System.Drawing.Point(294, 66);
            this.txtMedecin.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedecin.Name = "txtMedecin";
            this.txtMedecin.ReadOnly = true;
            this.txtMedecin.Size = new System.Drawing.Size(76, 20);
            this.txtMedecin.TabIndex = 6;
            // 
            // txtRapport
            // 
            this.txtRapport.Location = new System.Drawing.Point(11, 324);
            this.txtRapport.Margin = new System.Windows.Forms.Padding(2);
            this.txtRapport.Name = "txtRapport";
            this.txtRapport.ReadOnly = true;
            this.txtRapport.Size = new System.Drawing.Size(76, 20);
            this.txtRapport.TabIndex = 5;
            // 
            // lbRapport
            // 
            this.lbRapport.AutoSize = true;
            this.lbRapport.Location = new System.Drawing.Point(9, 300);
            this.lbRapport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRapport.Name = "lbRapport";
            this.lbRapport.Size = new System.Drawing.Size(100, 13);
            this.lbRapport.TabIndex = 4;
            this.lbRapport.Text = "Nombre de rapports";
            // 
            // lbMedicaments
            // 
            this.lbMedicaments.AutoSize = true;
            this.lbMedicaments.Location = new System.Drawing.Point(292, 105);
            this.lbMedicaments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMedicaments.Name = "lbMedicaments";
            this.lbMedicaments.Size = new System.Drawing.Size(124, 13);
            this.lbMedicaments.TabIndex = 3;
            this.lbMedicaments.Text = "Nombre de médicaments";
            // 
            // lbMedecin
            // 
            this.lbMedecin.AutoSize = true;
            this.lbMedecin.Location = new System.Drawing.Point(292, 41);
            this.lbMedecin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMedecin.Name = "lbMedecin";
            this.lbMedecin.Size = new System.Drawing.Size(107, 13);
            this.lbMedecin.TabIndex = 2;
            this.lbMedecin.Text = "Nombre de médecins";
            // 
            // lbRapportAnnee
            // 
            this.lbRapportAnnee.AutoSize = true;
            this.lbRapportAnnee.Location = new System.Drawing.Point(9, 17);
            this.lbRapportAnnee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRapportAnnee.Name = "lbRapportAnnee";
            this.lbRapportAnnee.Size = new System.Drawing.Size(156, 13);
            this.lbRapportAnnee.TabIndex = 1;
            this.lbRapportAnnee.Text = "Nombre de rapports par années";
            // 
            // frmStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 436);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStatistiques";
            this.Text = "Statistiques";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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