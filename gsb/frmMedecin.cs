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
    public partial class frmMedecin : Form
    {
        public frmMedecin()
        {
            InitializeComponent();
        }

        private void frmMedecin_Load(object sender, EventArgs e)
        {
            //Charger les médicaments grâce au manager
            List<Medecin> lesMedecins = Manager.ChargerMedecins();

            //On fait une boucle foreach qui parcourt la liste
            foreach (Medecin med in lesMedecins)
            {
                // on ajoute chaque médicament aux Items de la liste listMedicaments
                this.listMedecin.Items.Add(med.toString());
            }
        }

        private void listMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //récupération de l'indice du médicament sélectionné
            int indexMed = this.listMedecin.SelectedIndex;

            //récupération du médicament  dans la classe manager
            Medecin med = Manager.getMedecin(indexMed);

            //mise à jour des champs de texte
            this.txtIdMed.Text = med.getId();
            this.txtNomMed.Text = med.getNom();
            this.txtPrenomMed.Text = med.getPrenom();
            this.txtAdresseMed.Text = med.getAdresse();
            this.txtTelMed.Text = med.getTel();
            


            //récupération de la famille du médicament grâce au Manager
            Specialite spe = Manager.ChargerSpecialiteDuMedecin(med);

            //mise à jour du champ de texte txtFamille avec le libellé de la famille
            this.txtSpeMed.Text = spe.getSpecialite();
        }

        private void frmMedecin_Load_1(object sender, EventArgs e)
        {
             //Charger les médicaments grâce au manager
            List<Medecin> lesMedecins = Manager.ChargerMedecins();

            //On fait une boucle foreach qui parcourt la liste
            foreach (Medecin med in lesMedecins)
            {
                // on ajoute chaque médicament aux Items de la liste listMedicaments
                this.listMedecin.Items.Add(med.toString());
            }
        }
    }
}
