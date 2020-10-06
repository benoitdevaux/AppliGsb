namespace gsb
{
    partial class frmNouveauMedicament
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
            this.lbNouveauMedicament = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNomComm = new System.Windows.Forms.Label();
            this.lbComposition = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.lbEffet = new System.Windows.Forms.Label();
            this.txtEffets = new System.Windows.Forms.TextBox();
            this.txtContreIndications = new System.Windows.Forms.TextBox();
            this.lbContreIndication = new System.Windows.Forms.Label();
            this.lbFamille = new System.Windows.Forms.Label();
            this.cbFamilles = new System.Windows.Forms.ComboBox();
            this.btCreer = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.lbNouveauMedicament);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btCreer);
            this.splitContainer1.Panel2.Controls.Add(this.cbFamilles);
            this.splitContainer1.Panel2.Controls.Add(this.lbFamille);
            this.splitContainer1.Panel2.Controls.Add(this.lbContreIndication);
            this.splitContainer1.Panel2.Controls.Add(this.txtContreIndications);
            this.splitContainer1.Panel2.Controls.Add(this.txtEffets);
            this.splitContainer1.Panel2.Controls.Add(this.lbEffet);
            this.splitContainer1.Panel2.Controls.Add(this.txtComposition);
            this.splitContainer1.Panel2.Controls.Add(this.txtNom);
            this.splitContainer1.Panel2.Controls.Add(this.txtId);
            this.splitContainer1.Panel2.Controls.Add(this.lbComposition);
            this.splitContainer1.Panel2.Controls.Add(this.lbNomComm);
            this.splitContainer1.Panel2.Controls.Add(this.lbId);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbNouveauMedicament
            // 
            this.lbNouveauMedicament.AutoSize = true;
            this.lbNouveauMedicament.Location = new System.Drawing.Point(328, 22);
            this.lbNouveauMedicament.Name = "lbNouveauMedicament";
            this.lbNouveauMedicament.Size = new System.Drawing.Size(145, 17);
            this.lbNouveauMedicament.TabIndex = 1;
            this.lbNouveauMedicament.Text = "Nouveau médicament";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(42, 42);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(19, 17);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "id";
            // 
            // lbNomComm
            // 
            this.lbNomComm.AutoSize = true;
            this.lbNomComm.Location = new System.Drawing.Point(42, 134);
            this.lbNomComm.Name = "lbNomComm";
            this.lbNomComm.Size = new System.Drawing.Size(110, 17);
            this.lbNomComm.TabIndex = 1;
            this.lbNomComm.Text = "nom commercial";
            // 
            // lbComposition
            // 
            this.lbComposition.AutoSize = true;
            this.lbComposition.Location = new System.Drawing.Point(42, 217);
            this.lbComposition.Name = "lbComposition";
            this.lbComposition.Size = new System.Drawing.Size(83, 17);
            this.lbComposition.TabIndex = 2;
            this.lbComposition.Text = "composition";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(186, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(152, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(186, 134);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(152, 22);
            this.txtNom.TabIndex = 4;
            // 
            // txtComposition
            // 
            this.txtComposition.Location = new System.Drawing.Point(186, 217);
            this.txtComposition.Multiline = true;
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(152, 66);
            this.txtComposition.TabIndex = 5;
            // 
            // lbEffet
            // 
            this.lbEffet.AutoSize = true;
            this.lbEffet.Location = new System.Drawing.Point(496, 42);
            this.lbEffet.Name = "lbEffet";
            this.lbEffet.Size = new System.Drawing.Size(43, 17);
            this.lbEffet.TabIndex = 6;
            this.lbEffet.Text = "effets";
            // 
            // txtEffets
            // 
            this.txtEffets.Location = new System.Drawing.Point(562, 39);
            this.txtEffets.Multiline = true;
            this.txtEffets.Name = "txtEffets";
            this.txtEffets.Size = new System.Drawing.Size(205, 62);
            this.txtEffets.TabIndex = 7;
            // 
            // txtContreIndications
            // 
            this.txtContreIndications.Location = new System.Drawing.Point(562, 134);
            this.txtContreIndications.Multiline = true;
            this.txtContreIndications.Name = "txtContreIndications";
            this.txtContreIndications.Size = new System.Drawing.Size(205, 64);
            this.txtContreIndications.TabIndex = 8;
            // 
            // lbContreIndication
            // 
            this.lbContreIndication.AutoSize = true;
            this.lbContreIndication.Location = new System.Drawing.Point(420, 134);
            this.lbContreIndication.Name = "lbContreIndication";
            this.lbContreIndication.Size = new System.Drawing.Size(119, 17);
            this.lbContreIndication.TabIndex = 9;
            this.lbContreIndication.Text = "contre indications";
            // 
            // lbFamille
            // 
            this.lbFamille.AutoSize = true;
            this.lbFamille.Location = new System.Drawing.Point(493, 217);
            this.lbFamille.Name = "lbFamille";
            this.lbFamille.Size = new System.Drawing.Size(48, 17);
            this.lbFamille.TabIndex = 10;
            this.lbFamille.Text = "famille";
            // 
            // cbFamilles
            // 
            this.cbFamilles.FormattingEnabled = true;
            this.cbFamilles.Location = new System.Drawing.Point(562, 217);
            this.cbFamilles.Name = "cbFamilles";
            this.cbFamilles.Size = new System.Drawing.Size(205, 24);
            this.cbFamilles.TabIndex = 11;
            // 
            // btCreer
            // 
            this.btCreer.Location = new System.Drawing.Point(45, 332);
            this.btCreer.Name = "btCreer";
            this.btCreer.Size = new System.Drawing.Size(75, 23);
            this.btCreer.TabIndex = 12;
            this.btCreer.Text = "Creer";
            this.btCreer.UseVisualStyleBackColor = true;
            this.btCreer.Click += new System.EventHandler(this.btCreer_Click);
            // 
            // frmNouveauMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNouveauMedicament";
            this.Text = "frmNouveauMedicament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNouveauMedicament_Load);
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
        private System.Windows.Forms.Label lbNouveauMedicament;
        private System.Windows.Forms.Button btCreer;
        private System.Windows.Forms.ComboBox cbFamilles;
        private System.Windows.Forms.Label lbFamille;
        private System.Windows.Forms.Label lbContreIndication;
        private System.Windows.Forms.TextBox txtContreIndications;
        private System.Windows.Forms.TextBox txtEffets;
        private System.Windows.Forms.Label lbEffet;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbComposition;
        private System.Windows.Forms.Label lbNomComm;
        private System.Windows.Forms.Label lbId;
    }
}