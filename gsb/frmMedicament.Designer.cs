namespace gsb
{
    partial class frmMedicament
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
            this.lbMedicament = new System.Windows.Forms.Label();
            this.txtFamille = new System.Windows.Forms.TextBox();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.txtNomCommercial = new System.Windows.Forms.TextBox();
            this.lbFamille = new System.Windows.Forms.Label();
            this.txtContreIndications = new System.Windows.Forms.TextBox();
            this.lbContreIndications = new System.Windows.Forms.Label();
            this.txtEffets = new System.Windows.Forms.TextBox();
            this.lbEffets = new System.Windows.Forms.Label();
            this.lbComposition = new System.Windows.Forms.Label();
            this.lbNomCommercial = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.listMedicaments = new System.Windows.Forms.ListBox();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbMedicament);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtFamille);
            this.splitContainer1.Panel2.Controls.Add(this.txtComposition);
            this.splitContainer1.Panel2.Controls.Add(this.txtNomCommercial);
            this.splitContainer1.Panel2.Controls.Add(this.lbFamille);
            this.splitContainer1.Panel2.Controls.Add(this.txtContreIndications);
            this.splitContainer1.Panel2.Controls.Add(this.lbContreIndications);
            this.splitContainer1.Panel2.Controls.Add(this.txtEffets);
            this.splitContainer1.Panel2.Controls.Add(this.lbEffets);
            this.splitContainer1.Panel2.Controls.Add(this.lbComposition);
            this.splitContainer1.Panel2.Controls.Add(this.lbNomCommercial);
            this.splitContainer1.Panel2.Controls.Add(this.txtId);
            this.splitContainer1.Panel2.Controls.Add(this.lbId);
            this.splitContainer1.Panel2.Controls.Add(this.listMedicaments);
            this.splitContainer1.Size = new System.Drawing.Size(600, 421);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbMedicament
            // 
            this.lbMedicament.AutoSize = true;
            this.lbMedicament.Location = new System.Drawing.Point(265, 24);
            this.lbMedicament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMedicament.Name = "lbMedicament";
            this.lbMedicament.Size = new System.Drawing.Size(114, 13);
            this.lbMedicament.TabIndex = 0;
            this.lbMedicament.Text = "Liste des médicaments";
            // 
            // txtFamille
            // 
            this.txtFamille.Location = new System.Drawing.Point(410, 276);
            this.txtFamille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFamille.Multiline = true;
            this.txtFamille.Name = "txtFamille";
            this.txtFamille.ReadOnly = true;
            this.txtFamille.Size = new System.Drawing.Size(164, 62);
            this.txtFamille.TabIndex = 12;
            // 
            // txtComposition
            // 
            this.txtComposition.Location = new System.Drawing.Point(100, 262);
            this.txtComposition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComposition.Multiline = true;
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.ReadOnly = true;
            this.txtComposition.Size = new System.Drawing.Size(164, 77);
            this.txtComposition.TabIndex = 11;
            // 
            // txtNomCommercial
            // 
            this.txtNomCommercial.Location = new System.Drawing.Point(99, 202);
            this.txtNomCommercial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomCommercial.Name = "txtNomCommercial";
            this.txtNomCommercial.ReadOnly = true;
            this.txtNomCommercial.Size = new System.Drawing.Size(164, 20);
            this.txtNomCommercial.TabIndex = 10;
            // 
            // lbFamille
            // 
            this.lbFamille.AutoSize = true;
            this.lbFamille.Location = new System.Drawing.Point(299, 276);
            this.lbFamille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFamille.Name = "lbFamille";
            this.lbFamille.Size = new System.Drawing.Size(39, 13);
            this.lbFamille.TabIndex = 9;
            this.lbFamille.Text = "Famille";
            // 
            // txtContreIndications
            // 
            this.txtContreIndications.Location = new System.Drawing.Point(410, 202);
            this.txtContreIndications.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContreIndications.Multiline = true;
            this.txtContreIndications.Name = "txtContreIndications";
            this.txtContreIndications.ReadOnly = true;
            this.txtContreIndications.Size = new System.Drawing.Size(164, 58);
            this.txtContreIndications.TabIndex = 8;
            // 
            // lbContreIndications
            // 
            this.lbContreIndications.AutoSize = true;
            this.lbContreIndications.Location = new System.Drawing.Point(299, 202);
            this.lbContreIndications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbContreIndications.Name = "lbContreIndications";
            this.lbContreIndications.Size = new System.Drawing.Size(92, 13);
            this.lbContreIndications.TabIndex = 7;
            this.lbContreIndications.Text = "Contre Indications";
            // 
            // txtEffets
            // 
            this.txtEffets.Location = new System.Drawing.Point(410, 122);
            this.txtEffets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEffets.Multiline = true;
            this.txtEffets.Name = "txtEffets";
            this.txtEffets.ReadOnly = true;
            this.txtEffets.Size = new System.Drawing.Size(164, 62);
            this.txtEffets.TabIndex = 6;
            // 
            // lbEffets
            // 
            this.lbEffets.AutoSize = true;
            this.lbEffets.Location = new System.Drawing.Point(299, 122);
            this.lbEffets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEffets.Name = "lbEffets";
            this.lbEffets.Size = new System.Drawing.Size(34, 13);
            this.lbEffets.TabIndex = 5;
            this.lbEffets.Text = "Effets";
            // 
            // lbComposition
            // 
            this.lbComposition.AutoSize = true;
            this.lbComposition.Location = new System.Drawing.Point(9, 262);
            this.lbComposition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComposition.Name = "lbComposition";
            this.lbComposition.Size = new System.Drawing.Size(64, 13);
            this.lbComposition.TabIndex = 4;
            this.lbComposition.Text = "Composition";
            // 
            // lbNomCommercial
            // 
            this.lbNomCommercial.AutoSize = true;
            this.lbNomCommercial.Location = new System.Drawing.Point(9, 197);
            this.lbNomCommercial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNomCommercial.Name = "lbNomCommercial";
            this.lbNomCommercial.Size = new System.Drawing.Size(86, 13);
            this.lbNomCommercial.TabIndex = 3;
            this.lbNomCommercial.Text = "Nom Commercial";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(100, 127);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(164, 20);
            this.txtId.TabIndex = 2;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(9, 129);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(15, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "id";
            // 
            // listMedicaments
            // 
            this.listMedicaments.FormattingEnabled = true;
            this.listMedicaments.Location = new System.Drawing.Point(11, 6);
            this.listMedicaments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listMedicaments.Name = "listMedicaments";
            this.listMedicaments.Size = new System.Drawing.Size(563, 108);
            this.listMedicaments.TabIndex = 0;
            this.listMedicaments.SelectedIndexChanged += new System.EventHandler(this.listMedicaments_SelectedIndexChanged);
            // 
            // frmMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 421);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMedicament";
            this.Text = "Formulaire Medicament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMedicament_Load);
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
        private System.Windows.Forms.Label lbMedicament;
        private System.Windows.Forms.ListBox listMedicaments;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtFamille;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.TextBox txtNomCommercial;
        private System.Windows.Forms.Label lbFamille;
        private System.Windows.Forms.TextBox txtContreIndications;
        private System.Windows.Forms.Label lbContreIndications;
        private System.Windows.Forms.TextBox txtEffets;
        private System.Windows.Forms.Label lbEffets;
        private System.Windows.Forms.Label lbComposition;
        private System.Windows.Forms.Label lbNomCommercial;
    }
}