namespace gsb
{
    partial class frmNouveauMedecin
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
            this.lbNouveauMedecin = new System.Windows.Forms.Label();
            this.lbDepartement = new System.Windows.Forms.Label();
            this.cbSpecialite = new System.Windows.Forms.ComboBox();
            this.lbSpe = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.lbNouveauMedecin);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCreer);
            this.splitContainer1.Panel2.Controls.Add(this.txtDepartement);
            this.splitContainer1.Panel2.Controls.Add(this.lbDepartement);
            this.splitContainer1.Panel2.Controls.Add(this.cbSpecialite);
            this.splitContainer1.Panel2.Controls.Add(this.lbSpe);
            this.splitContainer1.Panel2.Controls.Add(this.txtTel);
            this.splitContainer1.Panel2.Controls.Add(this.lbTel);
            this.splitContainer1.Panel2.Controls.Add(this.txtAdresse);
            this.splitContainer1.Panel2.Controls.Add(this.lbAdresse);
            this.splitContainer1.Panel2.Controls.Add(this.txtPrenom);
            this.splitContainer1.Panel2.Controls.Add(this.txtNom);
            this.splitContainer1.Panel2.Controls.Add(this.lbPrenom);
            this.splitContainer1.Panel2.Controls.Add(this.lbNom);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbNouveauMedecin
            // 
            this.lbNouveauMedecin.AutoSize = true;
            this.lbNouveauMedecin.Location = new System.Drawing.Point(400, 29);
            this.lbNouveauMedecin.Name = "lbNouveauMedecin";
            this.lbNouveauMedecin.Size = new System.Drawing.Size(122, 17);
            this.lbNouveauMedecin.TabIndex = 0;
            this.lbNouveauMedecin.Text = "Nouveau Medecin";
            // 
            // lbDepartement
            // 
            this.lbDepartement.AutoSize = true;
            this.lbDepartement.Location = new System.Drawing.Point(12, 200);
            this.lbDepartement.Name = "lbDepartement";
            this.lbDepartement.Size = new System.Drawing.Size(90, 17);
            this.lbDepartement.TabIndex = 12;
            this.lbDepartement.Text = "Departement";
            // 
            // cbSpecialite
            // 
            this.cbSpecialite.FormattingEnabled = true;
            this.cbSpecialite.Location = new System.Drawing.Point(576, 193);
            this.cbSpecialite.Name = "cbSpecialite";
            this.cbSpecialite.Size = new System.Drawing.Size(175, 24);
            this.cbSpecialite.TabIndex = 11;
            // 
            // lbSpe
            // 
            this.lbSpe.AutoSize = true;
            this.lbSpe.Location = new System.Drawing.Point(466, 200);
            this.lbSpe.Name = "lbSpe";
            this.lbSpe.Size = new System.Drawing.Size(69, 17);
            this.lbSpe.TabIndex = 10;
            this.lbSpe.Text = "Specialite";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(576, 142);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(175, 22);
            this.txtTel.TabIndex = 9;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(507, 142);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(28, 17);
            this.lbTel.TabIndex = 8;
            this.lbTel.Text = "Tel";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(576, 33);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(175, 67);
            this.txtAdresse.TabIndex = 7;
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Location = new System.Drawing.Point(475, 33);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(60, 17);
            this.lbAdresse.TabIndex = 6;
            this.lbAdresse.Text = "Adresse";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(141, 139);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(148, 22);
            this.txtPrenom.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(141, 33);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(148, 22);
            this.txtNom.TabIndex = 4;
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(40, 139);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(57, 17);
            this.lbPrenom.TabIndex = 2;
            this.lbPrenom.Text = "Prenom";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(58, 33);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(37, 17);
            this.lbNom.TabIndex = 1;
            this.lbNom.Text = "Nom";
            // 
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(141, 200);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(148, 22);
            this.txtDepartement.TabIndex = 13;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(27, 334);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 14;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // frmNouveauMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNouveauMedecin";
            this.Text = "frmNouveauMedecin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNouveauMedecin_Load);
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
        private System.Windows.Forms.Label lbNouveauMedecin;
        private System.Windows.Forms.Label lbSpe;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbDepartement;
        private System.Windows.Forms.ComboBox cbSpecialite;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.TextBox txtDepartement;
    }
}