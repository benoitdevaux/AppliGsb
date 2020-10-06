using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class EchantillonOffert
    {
        //Déclaration des variables
        private Medicament leMedicament;
        private int quantite;

        //Constructeur
        public EchantillonOffert(Medicament medicament, int quantite)
        {
            this.leMedicament = medicament;
            this.quantite = quantite;
        }

        //Récupère le médicament
        public Medicament GetMedicament()
        {
            return this.leMedicament;
        }

        //Récupère la quantite
        public int GetQuantite()
        {
            return this.quantite;
        }
    }
}
