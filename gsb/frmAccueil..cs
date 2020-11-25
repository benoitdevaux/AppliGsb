using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb
{
    public partial class frmAccueil : Form
    {
        //Initialise le formulaire
        public frmAccueil()
        {
            InitializeComponent();
        }

        //Code du bouton quitter
        private void btQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Affichage du formulaire Médicament
        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmMedicament f = new frmMedicament();
            f.MdiParent = this;
            f.Show();
        }

        //Récupère le formulaire actif s'il existe on le ferme
        private void FermerMDI()
        {
            Form c;
            c = this.ActiveMdiChild;
            if (c != null)
            {
                c.Close();
            }
        }

        private void RendVisible(bool val)  //val vaut true ou false
        {
            pictureBox1.Visible = val;  //la propriété Visible passe à vrai ou Faux 
            btQuitter.Visible = val;
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmNouveauMedicament f = new frmNouveauMedicament();
            f.MdiParent = this;
            f.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmMedecin f = new frmMedecin();
            f.MdiParent = this;

            f.Show();
        }

        private void gérerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmNouveauMedecin f = new frmNouveauMedecin();
            f.MdiParent = this;
            f.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmRapport f = new frmRapport();
            f.MdiParent = this;
            f.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmAjoutRapport f = new frmAjoutRapport();
            f.MdiParent = this;
            f.Show();
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmStatistiques f = new frmStatistiques();
            f.MdiParent = this;
            f.Show();
        }

        private void listeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmVisiteur f = new frmVisiteur();
            f.MdiParent = this;
            f.Show();
        }
    }
}
