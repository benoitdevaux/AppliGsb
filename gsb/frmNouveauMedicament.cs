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
    public partial class frmNouveauMedicament : Form
    {
        public frmNouveauMedicament()
        {
            InitializeComponent();
        }

        private void frmNouveauMedicament_Load(object sender, EventArgs e)
        {
            //charger les familles de médicaments du manager 
            List<Famille> lesFamilles = Manager.ChargerFamilles();
            //Parcourir la liste des familles 
            foreach(Famille famille in lesFamilles)
            {
                //ajouter chaque famille aux Items de la liste cbFamilles : 
                this.cbFamilles.Items.Add(famille.getLibelle());
            }
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            //récupération des valeurs des champs de texte et instanciation d'un medicament
            Medicament nouveauMed = new Medicament(txtId.Text, txtNom.Text, txtComposition.Text, txtEffets.Text, txtContreIndications.Text);

            //Récupération de l'index sélectionné dans la lliste des familles
            int indexFamille = cbFamilles.SelectedIndex;
            //Récupération de la famille grâce au manager
            Famille laFamille = Manager.GetFamille(indexFamille);

            //il faut attribuer cette famille au médicament avec SetFamille
            nouveauMed.setFamille(laFamille);
            //on fait appel au manager pour enregistrer le médicament
            Manager.CreerMedicament(nouveauMed);

            //Message de confirmation 
            MessageBox.Show("Le médicament " + nouveauMed.getNom() + " a été créé");

        }
    }
}
