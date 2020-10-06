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
    public partial class frmNouveauMedecin : Form
    {
        public frmNouveauMedecin()
        {
            InitializeComponent();
        }

        private void frmNouveauMedecin_Load(object sender, EventArgs e)
        {
            //Charger les spécialité du manager
            List<Specialite> lesSpe = Manager.ChargerSpecialites();

            //Parcourir la liste des spe
            foreach(Specialite specialite in lesSpe)
            {
                //ajouter chaque spe aux items de la liste cbSpecialite
                this.cbSpecialite.Items.Add(specialite.getSpecialite());
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            //récupération des valeurs des champs de texte et instanciation d'un medecin
            Medecin nouveauMedecin = new Medecin("", txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtTel.Text, Int32.Parse(txtDepartement.Text));

            //récupération de l'index sélectionné dans la liste des spe
            int indexSpe = cbSpecialite.SelectedIndex;
            //récupération de la spe grâce au manager
            Specialite laSpe = Manager.GetSpecialite(indexSpe);

            //il faut attribuer cette spe au medecin avec setSpecialite
            nouveauMedecin.setSpecialite(laSpe);
            //on fait appel au manager
            Manager.CreerMedecin(nouveauMedecin);

            //Message de confirmation 
            MessageBox.Show("Le medecin " + nouveauMedecin.getNom() + " a été ajouté");
        }   

    }
}
