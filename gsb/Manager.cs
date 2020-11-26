using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Manager
    {
        // liste des médicaments
        private static List<Medicament> medicaments;
        private static List<Medecin> medecins;
        private static List<Famille> familles;
        private static List<Specialite> specialites;
        private static List<Visiteur> visiteurs;
        private static List<Rapport> rapports;
        private static List<EchantillonOffert> echantillons;
        

        // constructeur du manager
        public Manager()
        { }

        // charge la liste des médicaments à partir de la base de données en utilisant la classe Passerelle
        public static List<Medicament>ChargerMedicaments()
        {
            medicaments = Passerelle.GetMedicament();
            return medicaments;
        }

        //Charge la liste des medecins à partir de la base de données en utilisant la classe Passerelle
        public static List<Medecin>ChargerMedecins()
        {
            medecins = Passerelle.GetMedecins();
            return medecins;
        }

        //Charge la liste des familles à partir de la base de données en utilisant la classe Passerelle 
        public static List<Famille>ChargerFamilles()
        {
            familles = Passerelle.GetFamilles();
            return familles;
        }

        //Charge la liste des specialites à partir de la base de données en utilisant la classe Passerelle
        public static List<Specialite> ChargerSpecialites()
        {
            specialites = Passerelle.GetSpecialites();
            return specialites;
        }

        //Charge la liste des visiteurs à partir de la base de données en utilisant la classe Passerelle
        public static List<Visiteur> ChargerVisiteurs()
        {
            visiteurs = Passerelle.GetVisiteurs();
            return visiteurs;
        }

        //Charge la liste des rapports à partir de la base de données en utilisant la classe Passerelle
        public static List<Rapport> ChargerRapports()
        {
            rapports = Passerelle.GetRapports();
            return rapports;
        }

        //Permet d'obtenir un rapport à partir de son id
        public static Rapport ChargerRapport(int idRapport)
        {
           //utilise la passerelle pour obtenir le rapport
           Rapport rapport = Passerelle.GetRapport(idRapport);

            //utilise la passerelle pour obtenir son visiteur:
            Visiteur visiteur = Passerelle.GetVisiteur(rapport.GetIdVisiteur());
            rapport.SetVisiteur(visiteur);

            //utilise la passerelle pour obtenir son medecin
            Medecin medecin = Passerelle.GetMedecin(rapport.GetIdMedecin().ToString());
            rapport.SetMedecin(medecin);

            //utilise la passerelle pour obtenir son echantillon offert
            var echantillon = Passerelle.GetEchantillonOfferts(idRapport);
            rapport.SetEchantillionsOfferts(echantillon);

            //Renvoie le rapport
            return rapport;
        }

        //Permet de charger un rapport en fonction du visiteur
        public static List<Int32> ChercherIdsRapportsVisiteur(int indexVisiteur)
        {
            //récupère le visiteur dans la liste visiteurs (qui a été chargée au préalable) 
            Visiteur visiteur = visiteurs[indexVisiteur];

            //obtient les ids des rapports des visiteurs grâce à la Passerelle
            return Passerelle.GetIdsRapportsVisiteur(visiteur.getId());
        }

        //Permet de charger un rapport en fonction du medecin
        public static List<Int32> ChercherIdsRapportsMedecin(int indexMedecin)
        {
            //récupère le visiteur dans la liste des medecins
            Medecin medecin = medecins[indexMedecin];

            //obtiens les ids des rapports des medecin grâce à la passerelle 
            return Passerelle.GetIdsRapportsMedecin(medecin.getId());
        }

        //Récupère un médicament à partir de son index
        public static Medicament GetMedicamentByName(String nom)
        {
            return Passerelle.getMedicament(nom);
        }

        public static Medicament getMedicament(int index)
        {
            return medicaments[index];
        }

        //Récupère un medecin à partir de son index
        public static Medecin getMedecin(int index)
        {
            return medecins[index];
        }

        //Récupère un visiteur à partir de son index
        public static Visiteur GetVisiteur(int index)
        {
            return visiteurs[index];
        }

        //Récupère la famille d'un médicament
        public static Famille GetFamilleDuMedicament(Medicament medicament)
        {
            //récupère la famille du médicament grâce à son id 
            Famille laFamille = Passerelle.GetFamilleDuMedicament(medicament.getId());

            //attribue cette famille au médicament
            medicament.setFamille(laFamille);

            //retourne la famille
            return laFamille;
        }

        //Récupère la spécialité d'un medecin
        public static Specialite ChargerSpecialiteDuMedecin(Medecin medecin)
        {
            Specialite laSpe = Passerelle.getSpecialiteDuMedecin(medecin.getId());

            medecin.setSpecialite(laSpe);

            return laSpe;
        }

        //obtient une famille de la liste des familles à partir de son index
        public static Famille GetFamille(int index)
        {
            return familles[index];
        }

        //obtient une sepcialtie de la liste des specialite à partir de son index
        public static Specialite GetSpecialite(int index )
        {
            return specialites[index];
        }

        //permet de créer un médicament en faisant appel à la Passerelle
        public static void CreerMedicament(Medicament medicament)
        {
            Passerelle.InsererMedicament(medicament);
        }

        //Permet de créer un medecin en faisant appel à la Passerelle
        public static void CreerMedecin(Medecin medecin)
        {
            Passerelle.InsererMedecin(medecin);
        }

        //Permet de créer un rapport en faisant appel à la Passerelle
        public static void CreerRapport(Rapport rapport)
        {
            Passerelle.InsererRapport(rapport);
        }

        //Récupère une liste de rapport par année
        public static List<List<String>> GetRapportByYear()
        {
            return Passerelle.GetRapportByYear();
        }

        public static int getRapportId(Rapport unRapport)
        {
            return Passerelle.getIdRapport(unRapport);
        }

        public static EchantillonOffert GetEchantillonOffert(int index)
        {
            return echantillons[index];
        }
        public static void CreerEchantillonOffert(int idRapport, EchantillonOffert unEchantillon)
        {
            Passerelle.InsererEchantillonOffert(idRapport, unEchantillon);
        }


    }   

   
}
