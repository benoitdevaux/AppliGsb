using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb
{
    public partial class frmMedicament : Form
    {
        public frmMedicament()
        {
            InitializeComponent();
        }

        private void frmMedicament_Load(object sender, EventArgs e)
        {
            //On utilise la passerelle pour récupérer le médicament "AMOX45"
            List<Medicament>medicaments = Passerelle.GetMedicament();

            //Charger les médicaments grâce au manager
            List<Medicament> lesMedicaments = Manager.ChargerMedicaments();

            //On fait une boucle foreach qui parcourt la liste
            foreach(Medicament med in lesMedicaments)
            {
                // on ajoute chaque médicament aux Items de la liste listMedicaments
                this.listMedicaments.Items.Add(med.toString());
            }
        }

        private void listMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            //récupération de l'indice du médicament sélectionné
            int indexMed = this.listMedicaments.SelectedIndex;

            //récupération du médicament  dans la classe manager
            Medicament med = Manager.getMedicament(indexMed);

            //mise à jour des champs de texte
            this.txtId.Text = med.getId();
            this.txtNomCommercial.Text = med.getNom();
            this.txtEffets.Text = med.getEffets();
            this.txtComposition.Text = med.getComposition();
            this.txtContreIndications.Text = med.getContreIndications();

            //récupération de la famille du médicament grâce au Manager
            Famille famille = Manager.GetFamilleDuMedicament(med);

            //mise à jour du champ de texte txtFamille avec le libellé de la famille
            this.txtFamille.Text = famille.getLibelle();
        }
    }
}
