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
    public partial class frmAjoutRapport : Form
    {
        public frmAjoutRapport()
        {
            InitializeComponent();
        }

        private void frmAjoutRapport_Load(object sender, EventArgs e)
        {
            //charger les visiteurs du manager 
            List<Visiteur> lesVisiteurs = Manager.ChargerVisiteurs();
            //Parcourir la liste des familles 
            foreach (Visiteur visiteurs in lesVisiteurs)
            {
                //ajouter chaque visiteur aux Items de la liste cbVisiteur : 
                this.cbVisiteurs.Items.Add(visiteurs.ToString());
            }

            //charger les medecins
            List<Medecin> lesMedecins = Manager.ChargerMedecins();
            //Parcourir la liste des medecins
            foreach (Medecin medecin in lesMedecins)
            {
                //ajouter chaque medecin aux items de la liste cbMedecin :
                this.cbMedecins.Items.Add(medecin.toString());
            }

            //charger les médicaments
            List<Medicament> lesMedicaments = Manager.ChargerMedicaments();
            //Parcourir la liste des médicaments
            foreach (Medicament medicament in lesMedicaments)
            {
                //ajouter chaque médicaments aux items de la liste cbMedicament
                this.cbMedicament.Items.Add(medicament.toString());
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string[] tab = { cbMedicament.Text, txtQuantite.Text };
            lvMedicament.Items.Add(new ListViewItem(tab));
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection lesIndex = this.lvMedicament.SelectedIndices;

            foreach (int index in lesIndex )
            {
                this.lvMedicament.Items.RemoveAt(index);
            }
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            //Récupération du visiteur, medecin
            Visiteur visiteur = Manager.GetVisiteur(this.cbVisiteurs.SelectedIndex);
            Medecin medecin = Manager.getMedecin(this.cbMedecins.SelectedIndex);


            //Récupération des valeurs des champs et instanciation d'un rapport
            Rapport nouveauRapport = new Rapport(DateTime.Parse(txtDate.Text), txtMotif.Text, txtBilan.Text, visiteur.getId(), Int32.Parse(medecin.getId()));

            //Création de l'élément grâce au manager
            Manager.CreerRapport(nouveauRapport);

            MessageBox.Show("Le rapport du " + txtDate.Text + " a bien été créé");
        }
    }
}
