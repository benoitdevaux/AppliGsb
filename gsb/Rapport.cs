using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb
{
    class Rapport
    {
        private string idVisiteur;
        private int idMedecin;
        private int id;
        private DateTime date;
        private string motif;
        private string bilan;
        private Visiteur leVisiteur;
        private Medecin leMedecin;
        private List<EchantillonOffert> lesEchantillonOfferts;

        public Rapport(int unId, DateTime date, string motif, string bilan, string idVisiteur, int idMedecin)
        {
            this.id = unId;
            this.date = date;
            this.motif = motif;
            this.bilan = bilan;
            this.idVisiteur = idVisiteur;
            this.idMedecin = idMedecin;
        }

        public Rapport(int unId, DateTime date, string motif, string bilan, Visiteur visiteur, Medecin medecin)
        {
            this.id = unId;
            this.date = date;
            this.motif = motif;
            this.bilan = bilan;
            this.leVisiteur = visiteur;
            this.leMedecin = medecin;
        }

        public int GetId()
        {
            return this.id;
        }

        public DateTime GetDate()
        {
            return this.date;
        }

        public string GetMotif()
        {
            return this.motif;
        }

        public string Getbilan()
        {
            return this.bilan;
        }

        public string GetIdVisiteur()
        {
            return this.idVisiteur;
        }

        public int GetIdMedecin()
        {
            return this.idMedecin;
        }

        public Visiteur GetVisiteur()
        {
            return this.leVisiteur;
        }

        public Medecin GetMedecin()
        {
            return this.leMedecin;
        }

        public List<EchantillonOffert> GetEchantillonOffert()
        {
            return this.lesEchantillonOfferts;
        }

        public void SetVisiteur(Visiteur visiteur)
        {
            this.leVisiteur = visiteur;
        }

        public void SetMedecin(Medecin medecin)
        {
            this.leMedecin = medecin;
        }

        public void SetEchantillionsOfferts(List<EchantillonOffert> echantillonOffert)
        {
            this.lesEchantillonOfferts = echantillonOffert;
        }
    }
}
