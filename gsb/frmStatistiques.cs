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
    public partial class frmStatistiques : Form
    {
        public frmStatistiques()
        {
            InitializeComponent();
        }

        private void frmStatistiques_Load(object sender, EventArgs e)
        {
            
        }

        private void btActualiser_Click(object sender, EventArgs e)
        {
            //Réinitialise la listView
            this.lvRapports.Items.Clear();

            //Charge le nombre de rapport par annéee
            List<List<String>> listRapportAnnee = Manager.GetRapportByYear();
            foreach (List<String> liste in listRapportAnnee)
            {
                String[] tab = { liste[0], liste[1] };
                lvRapports.Items.Add(new ListViewItem(tab));
            }

            //Charge le nombre de medecins
            List<Medecin> listMedecin = Manager.ChargerMedecins();
            int medecins = 0;
            foreach (Medecin medecin in listMedecin)
            {
                medecins += 1;
            }
            this.txtMedecin.Text = medecins.ToString();

            //charge le nombre Médicaments
            List<Medicament> listMedicament = Manager.ChargerMedicaments();
            int medicaments = 0;
            foreach (Medicament medicament in listMedicament)
            {
                medicaments += 1;
            }
            this.txtMedicament.Text = medicaments.ToString();

            //Charge le nombre de rapports
            List<Rapport> listRapport = Manager.ChargerRapports();
            int rapports = 0;
            foreach (Rapport rapport in listRapport)
            {
                rapports += 1;
            }
            this.txtRapport.Text = rapports.ToString();

        }

        private void lvRapports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
