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
    public partial class frmRapport : Form
    {
        public frmRapport()
        {
            InitializeComponent();
        }

        private void frmRapport_Load(object sender, EventArgs e)
        {
            //charger les visiteurs du manager 
            List<Visiteur> lesVisiteurs = Manager.ChargerVisiteurs();
            //Parcourir la liste des familles 
            foreach (Visiteur visiteurs in lesVisiteurs)
            {
                //ajouter chaque visiteur aux Items de la liste cbVisiteur : 
                this.cbVisiteur.Items.Add(visiteurs.ToString());
            }

            //charger les medecins
            List<Medecin> lesMedecins = Manager.ChargerMedecins();
            //Parcourir la liste des medecins
            foreach (Medecin medecin in lesMedecins)
            {
                //ajouter chaque medecin aux items de la liste cbMedecin :
                this.cbMedecins.Items.Add(medecin.toString());
            }

        }

        private void btRechercher1_Click(object sender, EventArgs e)
        {
            //récupération du visiteur sélectionné
            int indexVisiteur = this.cbVisiteur.SelectedIndex;

            //on va rechercher les rapports grâce au manager
            List<Int32> idDesRapports = Manager.ChercherIdsRapportsVisiteur(indexVisiteur);

            //on efface les élémenets de la liste listRapports
            this.listRapports.Items.Clear();

            //on affiche ces ids de rapports dans la liste listRapports
            foreach (int idRapport in idDesRapports)
            {
                listRapports.Items.Add(idRapport);
            }
        }

        private void btRechercher2_Click(object sender, EventArgs e)
        {
            //récupération du medecin sélectionné
            int indexMedecin = this.cbMedecins.SelectedIndex;

            //on va rechercher les rapports grâce au manager
            List<Int32> idDesRapports = Manager.ChercherIdsRapportsMedecin(indexMedecin);

            //on effce les élémenets de la liste listRapports
            this.listRapports.Items.Clear();

            //on affiche ces ids de rapports dans la liste listRapports
            foreach (int idRapport in idDesRapports)
            {
                listRapports.Items.Add(idRapport);
            }
        }

        private void listRapports_SelectedIndexChanged(object sender, EventArgs e)
        {
            //récupération du rapport sélectionné
            String idStr = this.listRapports.Text;

            //récupération de l'id du rapport
            int idRapport = int.Parse(this.listRapports.Text);

            //on utilise le manager pour récupérer le rapport
            Rapport rapport = Manager.ChargerRapport(idRapport);

            //affichage des infos
            //nom visiteur 
            this.txtNomVisiteur.Text = rapport.GetVisiteur().getNom();

            //prenom visiteur
            this.txtPrenomVisiteur.Text = rapport.GetVisiteur().getPrenom();

            //nom medecin
            this.txtNomMedecin.Text = rapport.GetMedecin().getNom();

            //prenom medecin
            this.txtPrenomMedecin.Text = rapport.GetMedecin().getPrenom();

            //adresse medecin
            this.txtAdresseMedecin.Text = rapport.GetMedecin().getAdresse();
            //motif
            this.txtMotif.Text = rapport.GetMotif();

            //date
            this.txtDate.Text = rapport.GetDate().ToString();

            //bilan
            this.txtBilan.Text = rapport.Getbilan();

            lvMedicaments.Items.Clear();

            //echantillons offerts
            foreach (EchantillonOffert echantillon in Passerelle.GetEchantillonOfferts(idRapport))
            {
                String[] tab = { echantillon.GetMedicament().getNom(), echantillon.GetQuantite().ToString() };
                lvMedicaments.Items.Add(new ListViewItem(tab));
            }
        }
    }
}
