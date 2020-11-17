using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Medicament
    {
        string id;
        string nomCommercial;
        string composition;
        string effets;
        string contreindications;
        Famille famille;

        public Medicament(string id, string nomCommercial, string composition, string effets, string contreindications)
        {
            this.id = id;
            this.nomCommercial = nomCommercial;
            this.composition = composition;
            this.effets = effets;
            this.contreindications = contreindications;
        }

        public Medicament(string id, string nomCommercial, string composition, string effets, string contreindications, Famille famille)
        {
            this.id = id;
            this.nomCommercial = nomCommercial;
            this.composition = composition;
            this.effets = effets;
            this.contreindications = contreindications;
            this.famille = famille;
        }

        public string getId()
        {
            return this.id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getNom()
        {
            return this.nomCommercial;
        }

        public void setNomCommercial(string nomCommercial)
        {
            this.nomCommercial = nomCommercial;
        }

        public string getComposition()
        {
            return this.composition;
        }

        public void setComposition(string composition)
        {
            this.composition = composition;
        }

        public string getEffets()
        {
            return this.effets;
        }

        public void setEffets(string effets)
        {
            this.effets = effets;
        }

        public string getContreIndications()
        {
            return this.contreindications;
        }

        public void setContreIndications(string contreIndications)
        {
            this.contreindications = contreIndications;
        }

        public Famille getFamille()
        {
            return this.famille;
        }

        public void setFamille(Famille famille)
        {
            this.famille = famille;
        }

        public string toString()
        {
            string a = this.getId() + " - ";
            a = a + this.getNom();

            return a;
        }

       
    }
}
