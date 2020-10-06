using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Famille
    {
        //Délcaration des variables
        string id;
        string libelle; 

        //Constructeur
        public Famille(string id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        //Récupère l'identifiant de la famille
        public string getId()
        {
            return this.id;
        }

        //Modifie l'identifiant de la famille
        public void setId(string id)
        {
            this.id = id;
        }

        //Récupère le libelle de la famille
        public string getLibelle()
        {
            return this.libelle;
        }

        //Modifie le libelle de la famille
        public void setLibelle(string libelle)
        {
            this.libelle = libelle;
        }
    }
}
