using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace gsb
{
    class Medecin : Personne
    {
        Specialite laSpecialite;
        string tel;
        int departement;
        public Medecin(string id, string nom, string prenom, string adresse, string tel, int departement, Specialite laSpecialite)
            : base(id, nom, prenom, adresse)
        {
            this.tel = tel;
            this.departement = departement;
            this.laSpecialite = laSpecialite;
        }

        public Medecin(string id, string nom, string prenom, string adresse, string tel, int departement)
            : base(id, nom, prenom, adresse)
        {
            this.tel = tel;
            this.departement = departement;
        }

        public string getTel()
        {
            return this.tel;
        }

        public int getDepartement()
        {
            return this.departement;
        }

        public Specialite getSpecialite()
        {
            return this.laSpecialite;
        }

        public void setSpecialite(Specialite laSpe)
        {
            this.laSpecialite = laSpe;
        }

        public string toString()
        {
            string a = this.getId() + " - ";
            a = a + this.getNom() + " ";
            a = a + this.getPrenom();

            return a;
        }
    }
}
