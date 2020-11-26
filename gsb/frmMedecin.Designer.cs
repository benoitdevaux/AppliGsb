namespace gsb
{
    partial class frmMedecin
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
            this.lbListMed = new System.Windows.Forms.Label();
            this.txtDepMed = new System.Windows.Forms.TextBox();
            this.lbDepMed = new System.Windows.Forms.Label();
            this.txtSpeMed = new System.Windows.Forms.TextBox();
            this.lbSpeMed = new System.Windows.Forms.Label();
            this.txtTelMed = new System.Windows.Forms.TextBox();
            this.lbTelMed = new System.Windows.Forms.Label();
            this.txtAdresseMed = new System.Windows.Forms.TextBox();
            this.lbAdresseMed = new System.Windows.Forms.Label();
            this.txtPrenomMed = new System.Windows.Forms.TextBox();
            this.lbPrenomMed = new System.Windows.Forms.Label();
            this.txtNomMed = new System.Windows.Forms.TextBox();
            this.lbNomMed = new System.Windows.Forms.Label();
            this.txtIdMed = new System.Windows.Forms.TextBox();
            this.lbIdMed = new System.Windows.Forms.Label();
            this.listMedecin = new System.Windows.Forms.ListBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.lbListMed);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtDepMed);
            this.splitContainer1.Panel2.Controls.Add(this.lbDepMed);
            this.splitContainer1.Panel2.Controls.Add(this.txtSpeMed);
            this.splitContainer1.Panel2.Controls.Add(this.lbSpeMed);
            this.splitContainer1.Panel2.Controls.Add(this.txtTelMed);
            this.splitContainer1.Panel2.Controls.Add(this.lbTelMed);
            this.splitContainer1.Panel2.Controls.Add(this.txtAdresseMed);
            this.splitContainer1.Panel2.Controls.Add(this.lbAdresseMed);
            this.splitContainer1.Panel2.Controls.Add(this.txtPrenomMed);
            this.splitContainer1.Panel2.Controls.Add(this.lbPrenomMed);
            this.splitContainer1.Panel2.Controls.Add(this.txtNomMed);
            this.splitContainer1.Panel2.Controls.Add(this.lbNomMed);
            this.splitContainer1.Panel2.Controls.Add(this.txtIdMed);
            this.splitContainer1.Panel2.Controls.Add(this.lbIdMed);
            this.splitContainer1.Panel2.Controls.Add(this.listMedecin);
            this.splitContainer1.Size = new System.Drawing.Size(600, 459);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbListMed
            // 
            this.lbListMed.AutoSize = true;
            this.lbListMed.Location = new System.Drawing.Point(256, 20);
            this.lbListMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbListMed.Name = "lbListMed";
            this.lbListMed.Size = new System.Drawing.Size(97, 13);
            this.lbListMed.TabIndex = 0;
            this.lbListMed.Text = "Liste des médecins";
            // 
            // txtDepMed
            // 
            this.txtDepMed.Location = new System.Drawing.Point(433, 214);
            this.txtDepMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepMed.Name = "txtDepMed";
            this.txtDepMed.ReadOnly = true;
            this.txtDepMed.Size = new System.Drawing.Size(128, 20);
            this.txtDepMed.TabIndex = 14;
            // 
            // lbDepMed
            // 
            this.lbDepMed.AutoSize = true;
            this.lbDepMed.Location = new System.Drawing.Point(342, 219);
            this.lbDepMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDepMed.Name = "lbDepMed";
            this.lbDepMed.Size = new System.Drawing.Size(68, 13);
            this.lbDepMed.TabIndex = 13;
            this.lbDepMed.Text = "Département";
            // 
            // txtSpeMed
            // 
            this.txtSpeMed.Location = new System.Drawing.Point(433, 185);
            this.txtSpeMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpeMed.Name = "txtSpeMed";
            this.txtSpeMed.ReadOnly = true;
            this.txtSpeMed.Size = new System.Drawing.Size(128, 20);
            this.txtSpeMed.TabIndex = 12;
            // 
            // lbSpeMed
            // 
            this.lbSpeMed.AutoSize = true;
            this.lbSpeMed.Location = new System.Drawing.Point(340, 189);
            this.lbSpeMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSpeMed.Name = "lbSpeMed";
            this.lbSpeMed.Size = new System.Drawing.Size(53, 13);
            this.lbSpeMed.TabIndex = 11;
            this.lbSpeMed.Text = "Spécialité";
            // 
            // txtTelMed
            // 
            this.txtTelMed.Location = new System.Drawing.Point(86, 314);
            this.txtTelMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelMed.Name = "txtTelMed";
            this.txtTelMed.ReadOnly = true;
            this.txtTelMed.Size = new System.Drawing.Size(136, 20);
            this.txtTelMed.TabIndex = 10;
            // 
            // lbTelMed
            // 
            this.lbTelMed.AutoSize = true;
            this.lbTelMed.Location = new System.Drawing.Point(30, 314);
            this.lbTelMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTelMed.Name = "lbTelMed";
            this.lbTelMed.Size = new System.Drawing.Size(22, 13);
            this.lbTelMed.TabIndex = 9;
            this.lbTelMed.Text = "Tel";
            // 
            // txtAdresseMed
            // 
            this.txtAdresseMed.Location = new System.Drawing.Point(86, 281);
            this.txtAdresseMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresseMed.Name = "txtAdresseMed";
            this.txtAdresseMed.ReadOnly = true;
            this.txtAdresseMed.Size = new System.Drawing.Size(136, 20);
            this.txtAdresseMed.TabIndex = 8;
            // 
            // lbAdresseMed
            // 
            this.lbAdresseMed.AutoSize = true;
            this.lbAdresseMed.Location = new System.Drawing.Point(30, 285);
            this.lbAdresseMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdresseMed.Name = "lbAdresseMed";
            this.lbAdresseMed.Size = new System.Drawing.Size(45, 13);
            this.lbAdresseMed.TabIndex = 7;
            this.lbAdresseMed.Text = "Adresse";
            // 
            // txtPrenomMed
            // 
            this.txtPrenomMed.Location = new System.Drawing.Point(86, 250);
            this.txtPrenomMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenomMed.Name = "txtPrenomMed";
            this.txtPrenomMed.ReadOnly = true;
            this.txtPrenomMed.Size = new System.Drawing.Size(136, 20);
            this.txtPrenomMed.TabIndex = 6;
            // 
            // lbPrenomMed
            // 
            this.lbPrenomMed.AutoSize = true;
            this.lbPrenomMed.Location = new System.Drawing.Point(30, 254);
            this.lbPrenomMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrenomMed.Name = "lbPrenomMed";
            this.lbPrenomMed.Size = new System.Drawing.Size(43, 13);
            this.lbPrenomMed.TabIndex = 5;
            this.lbPrenomMed.Text = "Prénom";
            // 
            // txtNomMed
            // 
            this.txtNomMed.Location = new System.Drawing.Point(86, 214);
            this.txtNomMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomMed.Name = "txtNomMed";
            this.txtNomMed.ReadOnly = true;
            this.txtNomMed.Size = new System.Drawing.Size(136, 20);
            this.txtNomMed.TabIndex = 4;
            // 
            // lbNomMed
            // 
            this.lbNomMed.AutoSize = true;
            this.lbNomMed.Location = new System.Drawing.Point(30, 219);
            this.lbNomMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNomMed.Name = "lbNomMed";
            this.lbNomMed.Size = new System.Drawing.Size(29, 13);
            this.lbNomMed.TabIndex = 3;
            this.lbNomMed.Text = "Nom";
            // 
            // txtIdMed
            // 
            this.txtIdMed.Location = new System.Drawing.Point(86, 184);
            this.txtIdMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdMed.Name = "txtIdMed";
            this.txtIdMed.ReadOnly = true;
            this.txtIdMed.Size = new System.Drawing.Size(136, 20);
            this.txtIdMed.TabIndex = 2;
            // 
            // lbIdMed
            // 
            this.lbIdMed.AutoSize = true;
            this.lbIdMed.Location = new System.Drawing.Point(30, 188);
            this.lbIdMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdMed.Name = "lbIdMed";
            this.lbIdMed.Size = new System.Drawing.Size(18, 13);
            this.lbIdMed.TabIndex = 1;
            this.lbIdMed.Text = "ID";
            // 
            // listMedecin
            // 
            this.listMedecin.FormattingEnabled = true;
            this.listMedecin.Location = new System.Drawing.Point(32, 17);
            this.listMedecin.Margin = new System.Windows.Forms.Padding(2);
            this.listMedecin.Name = "listMedecin";
            this.listMedecin.Size = new System.Drawing.Size(529, 147);
            this.listMedecin.TabIndex = 0;
            this.listMedecin.SelectedIndexChanged += new System.EventHandler(this.listMedecin_SelectedIndexChanged);
            // 
            // frmMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 459);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMedecin";
            this.Text = "frmMedecin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMedecin_Load_1);
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
        private System.Windows.Forms.Label lbListMed;
        private System.Windows.Forms.TextBox txtDepMed;
        private System.Windows.Forms.Label lbDepMed;
        private System.Windows.Forms.TextBox txtSpeMed;
        private System.Windows.Forms.Label lbSpeMed;
        private System.Windows.Forms.TextBox txtTelMed;
        private System.Windows.Forms.Label lbTelMed;
        private System.Windows.Forms.TextBox txtAdresseMed;
        private System.Windows.Forms.Label lbAdresseMed;
        private System.Windows.Forms.TextBox txtPrenomMed;
        private System.Windows.Forms.Label lbPrenomMed;
        private System.Windows.Forms.TextBox txtNomMed;
        private System.Windows.Forms.Label lbNomMed;
        private System.Windows.Forms.TextBox txtIdMed;
        private System.Windows.Forms.Label lbIdMed;
        private System.Windows.Forms.ListBox listMedecin;
    }
}