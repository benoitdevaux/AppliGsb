using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    public class Personne
    {
        string id;
        string nom;
        string prenom;
        string adresse;

        public Personne(string id, string nom, string prenom, string adresse)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
        }

        public string getId()
        {
            return this.id;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public string getAdresse()
        {
            return this.adresse;
        }

        public void setId(string unId)
        {
            this.id = unId;
        }

        public void setNom(string unNom)
        {
            this.nom = unNom;
        }

        public void setPrenom(string unPrenom)
        {
            this.prenom = unPrenom;
        }

        public void setAdresse(string uneAdresse)
        {
            this.adresse = uneAdresse;
        }

        public string ToString()
        {
            string a = this.id + "\n";
            a = a + this.nom + "\n"; ;
            a = a + this.prenom + "\n";
            a = a + this.adresse + "\n";

            return a;
        }
    }
}
