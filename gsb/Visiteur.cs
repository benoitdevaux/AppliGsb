using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb
{
    class Visiteur : Personne
    {
        private String login;
        private String mdp;
        private String cp;
        private String ville;
        private DateTime dateEmbauche;

        public Visiteur(String id, String nom, String prenom, String login, String mdp, String adresse, String cp, String ville, DateTime dateEmbauche)
            : base(id, nom, prenom, adresse)
        {
            this.login = login;
            this.mdp = mdp;
            this.cp = cp;
            this.ville = ville;
            this.dateEmbauche = dateEmbauche;
        }

        public String GetCp()
        {
            return this.cp;
        }

        public String GetVille()
        {
            return this.ville;
        }

        public DateTime GetDateEmbauche()
        {
            return this.dateEmbauche;
        }

        public void SetCp(String cp)
        {
            this.cp = cp;
        }

        public void SetVille(String ville)
        {
            this.ville = ville;
        }

        public void SetDateEmbauche(DateTime dateEmbauche)
        {
            this.dateEmbauche = dateEmbauche;
        }

        public string ToString()
        {
            string a = this.getId() + " - ";
            a = a + this.getNom() + " ";
            a = a + this.getPrenom();

            return a;
        }
    }
}
