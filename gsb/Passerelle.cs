using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;
using System.Reflection;

namespace gsb
{
    class Passerelle
    {
        private static DbConnection connexion = null;
        
        //Fonction de connexion à la base de données
        private static DbConnection GetConnexion()
        {
            if(connexion != null)
            {
                return connexion;
            }
            else
            {
                DbProviderFactory dbpf =
                    DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
                connexion = dbpf.CreateConnection();
                connexion.ConnectionString = "server=localhost;User Id=root;database=gsb";
                connexion.Open();
                return connexion;
            }
        }

        //Récupère les médicaments
        public static List<Medicament> GetMedicament()
        {
            //liste de médicaments
            List<Medicament> liste = new List<Medicament>();

            DbCommand dbc = GetConnexion().CreateCommand();
            //Requête SQL qui récupère tous les médicaments, triés par nom commercial 
            dbc.CommandText = "SELECT * FROM medicament ORDER BY nomCommercial";
            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                //Fait appel à MapperLigneMedicament et ajoute le médicament à la liste
                Medicament unMed = MapperLigneMedicament(reader);
                liste.Add(unMed);
            }
            reader.Close();
            return liste;
        }

        //Récupère les medecins
        public static List<Medecin> GetMedecins()
        {
            //liste des medecins 
            List<Medecin> liste = new List<Medecin>();

            DbCommand dbc = GetConnexion().CreateCommand();
            //Requête SQL qui récupère tous les medecins
            dbc.CommandText = "SELECT * FROM medecin ORDER BY nom";
            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                //Fait appel à MapperLigneMedecin et ajoute le medecin
                Medecin unMedecin = MapperLigneMedecin(reader);
                liste.Add(unMedecin);
            }
            reader.Close();
            return liste;
        }

        //Récupère les visiteurs
        public static List<Visiteur> GetVisiteurs()
        {
            //liste des visiteurs
            List<Visiteur> liste = new List<Visiteur>();

            DbCommand dbc = GetConnexion().CreateCommand();
            //Requête qui récupère les visiteurs
            dbc.CommandText = "SELECT * FROM visiteur ORDER BY nom";
            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                //Fait appel à MapperLigneVisiteur et ajoute le visiteur
                Visiteur unVisiteur = MapperLigneVisiteur(reader);
                liste.Add(unVisiteur);
            }
            reader.Close();
            return liste;
        }

        //Récupère la spécialité du médecin
        public static Specialite getSpecialiteDuMedecin(string idMedecin)
        {
            Specialite spe = null;

            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT Specialite.* FROM specialite "
                + " INNER JOIN medecin ON medecin.idSpecialite = specialite.id "
                + " WHERE medecin.id = '" + idMedecin + "'";

            DbDataReader reader = dbc.ExecuteReader();


            while (reader.Read())
            {
                //fait appel à MapperLigneSpecialite
                spe = MapperLigneSpecialite(reader);
            }
            reader.Close();
            return spe;
        }

        //Récupère le rapport d'un medecin par son id
        public static List<Int32> GetIdsRapportsMedecin(String idMedecin)
        {
            List<Int32> liste = new List<Int32>();
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT id FROM rapport WHERE idMedecin = '" + idMedecin + "' ORDER BY date DESC";
            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                liste.Add(id);
            }
            reader.Close();
            return liste;
        }


        //Récupère un rapport par son id
        public static Rapport GetRapport(int id)
        {
            Rapport rapport = null;

            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM rapport WHERE rapport.id = " + id;
            DbDataReader reader = dbc.ExecuteReader();

            if (reader.Read())
            {
                rapport = MapperLigneRapport(reader);
            }
            reader.Close();
            return rapport;
        }

        //Récupère un visiteur par son id
        public static Visiteur GetVisiteur(string idVisiteur)
        {
            Visiteur visiteur = null;

            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM visiteur WHERE id = '" + idVisiteur + "'";
            DbDataReader reader = dbc.ExecuteReader();

            if (reader.Read())
            {
                visiteur = MapperLigneVisiteur(reader);
            }
            reader.Close();
            return visiteur;
        }

        //Récupère un medecin par son id
        public static Medecin GetMedecin(string idMedecin)
        {
            Medecin medecin = null;


            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM medecin WHERE medecin.id = '" + idMedecin + "'";
            DbDataReader reader = dbc.ExecuteReader();

            if (reader.Read())
            {
                medecin = MapperLigneMedecin(reader);
            }
            reader.Close();
            return medecin;
        }
        
        ///<summary>
        ///Crée un médicament à partir d'une ligne de résultat du jeu d'enregistrements
        ///</summary>
        ///<param name="reader">le jeu d'enregistrements</param>
        ///<returns>le médicament correspondant à la ligne lue</returns>
        //Récupère la famille du médicament dont l'id est passé en paramètre
        public static Famille GetFamilleDuMedicament(String idMedicament)
        {
            Famille famille = null;

            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT famille.* FROM famille, medicament "
                + " WHERE medicament.idFamille = famille.id AND medicament.id = '" + idMedicament + "'";

            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                //fait appel à MapperLigneFamille
                famille = MapperLigneFamille(reader);
            }
            reader.Close();
            return famille;
        }

        /// <summary>
        /// Retourne les ids des rapports d'un visiteur,
        /// classés du plus récent au plus ancien
        /// </summary>
        /// <param name="idVisiteur">l'id du visiteur</param>
        /// <returns>la liste des rapports</returns>
        public static List<Int32> GetIdsRapportsVisiteur(String idVisiteur)
        {
            List<Int32> liste = new List<Int32>();
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT id FROM rapport WHERE idVisiteur = '" + idVisiteur + "' ORDER BY date DESC";
            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                liste.Add(id);
            }
            reader.Close();
            return liste;
        }


        private static Medicament MapperLigneMedicament(DbDataReader reader)
        {
            string id, nomCommercial, composition, effets, contreIndications;

            //Récupération des informations du médicament
            id = (string)reader["id"];
            nomCommercial = (string)reader["nomCommercial"];
            composition = (string)reader["composition"];
            effets = (string)reader["effets"];
            contreIndications = (string)reader["contreIndications"];

            //instanciation des objets
            Medicament medicament = new Medicament(id, nomCommercial, composition, effets, contreIndications);
            return medicament;
        }

        private static Medecin MapperLigneMedecin(DbDataReader reader)
        {
            string id, nom, prenom, adresse, tel;
            int departement;

            //Récupération des infos médecins
            id = ((int)reader["id"]).ToString();
            nom = (string)reader["nom"];
            prenom = (string)reader["prenom"];
            adresse = (string)reader["adresse"];
            tel = (string)reader["tel"];
            departement = (int)reader["departement"];

            //instanciation des objets
            Medecin medecin = new Medecin(id, nom, prenom, adresse, tel, departement);
            return medecin; ;
        }

        private static Visiteur MapperLigneVisiteur(DbDataReader reader)
        {
            string id, nom, prenom, login, mdp, adresse, cp, ville;
            DateTime dateEmbauche;

            //Récupération des infos visiteur
            id = (string)reader["id"];
            nom = (string)reader["nom"];
            prenom = (string)reader["prenom"];
            login = (string)reader["login"];
            mdp = (string)reader["mdp"];
            adresse = (string)reader["adresse"];
            cp = (string)reader["cp"];
            ville = (string)reader["ville"];
            dateEmbauche = (DateTime)reader["dateEmbauche"];

            //instanciation des objets
            Visiteur visiteur = new Visiteur(id, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche);
            return visiteur;
        }

        //crée une famille à partir d'une ligne de résultat du jeu d'enregistrements
        private static Famille MapperLigneFamille(DbDataReader reader)
        {
            String id, libelle;

            id = (String)reader["id"];
            libelle = (String)reader["libelle"];

            Famille laFamille = new Famille(id, libelle);
            return laFamille;
        }

        public static Specialite MapperLigneSpecialite(DbDataReader reader)
        {
            String id, nom;

            id = (String)reader["id"];
            nom = (String)reader["specialite"];

            Specialite laSpe = new Specialite(id, nom);
            return laSpe;
        }
        private static Rapport MapperLigneRapport(DbDataReader reader)
        {
            DateTime date;
            string motif, bilan, idVisiteur;
            int idMedecin;

            date = (DateTime)reader["date"];
            motif = (string)reader["motif"];
            bilan = (string)reader["bilan"];
            idVisiteur = (string)reader["idVisiteur"];
            idMedecin = (int)reader["idMedecin"];

            Rapport rapport = new Rapport(date, motif, bilan, idVisiteur, idMedecin);
            return rapport;
        }

        public static List<Famille> GetFamilles()
        {
            List<Famille> liste = new List<Famille>();

            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT famille.* FROM famille ORDER BY libelle";

            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                //fait appel à MapperLigneFamille
                Famille uneFamille = MapperLigneFamille(reader);
                liste.Add(uneFamille);
            }

            reader.Close();
            return liste;
        }

        public static List<Rapport> GetRapports()
        {
            List<Rapport> liste = new List<Rapport>();

            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT rapport.* FROM rapport ORDER BY date";

            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                //fait appel à MapperLigneRapport
                Rapport unRapport = MapperLigneRapport(reader);
                liste.Add(unRapport);
            }

            reader.Close();
            return liste;
        }
        public static List<Specialite> GetSpecialites()
        {
            List<Specialite> liste = new List<Specialite>();

            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT specialite.* FROM specialite ORDER BY specialite";

            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                //fait appel à MapperLigneSpecialite
                Specialite uneSpecialite = MapperLigneSpecialite(reader);
                liste.Add(uneSpecialite);               
            }
            reader.Close();
            return liste;
        }

        //Récupère les échantillins offert d'un rapport
        public static List<EchantillonOffert> GetEchantillonOfferts(int idRapport)
        {
            //liste des echantillons
            List<EchantillonOffert> liste = new List<EchantillonOffert>();

            //Requête SQL qui récupère les infos
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT medicament.*, offrir.quantite FROM medicament, offrir "
                + " WHERE offrir.idRapport = " + idRapport
                + " AND offrir.idMedicament = medicament.id "
                + " ORDER BY nomCommercial";
            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                EchantillonOffert echantillon;
                //le médicament
                Medicament unMed = MapperLigneMedicament(reader);
                //la quantite de l'échantillon 
                int quantite = (int)reader["quantite"];
                //instanciation de l'échantillon
                echantillon = new EchantillonOffert(unMed, quantite);
                //on l'ajoute à la liste
                liste.Add(echantillon);
            }
            reader.Close();
            return liste;

        }

        public static void InsererMedicament(Medicament medicament)
        {
            DbCommand dbc = GetConnexion().CreateCommand();

            //construction de la requête SQL insert
            dbc.CommandText = "INSERT INTO medicament VALUES ( "
                + "'" + medicament.getId() + "',"
                + "'" + medicament.getNom() + "',"
                + "'" + medicament.getFamille().getId() + "',"
                + "'" + medicament.getComposition() + "',"
                + "'" + medicament.getEffets() + "',"
                + "'" + medicament.getContreIndications() + "'"
                + " )";

            // Exécution de la requête
            dbc.ExecuteNonQuery();
        }

        public static void InsererMedecin(Medecin medecin)
        {
            DbCommand dbc = GetConnexion().CreateCommand();

            //construction de la requête SQL insert
            dbc.CommandText = "INSERT INTO medecin(nom, prenom, adresse, tel, idSpecialite, departement) VALUES ( "
                + "'" + medecin.getNom() + "',"
                + "'" + medecin.getPrenom() + "',"
                + "'" + medecin.getAdresse() + "',"
                + "'" + medecin.getTel() + "',"
                + "'" + medecin.getSpecialite().getId() + "',"
                + "'" + medecin.getDepartement() + "'"
                + " )";

            // Exécution de la requête
            dbc.ExecuteNonQuery();
        }

        //Ajouter un rapport
        public static void InsererRapport(Rapport rapport)
        {
            DbCommand dbc = GetConnexion().CreateCommand();

            //Récupération de la date
            int annee = rapport.GetDate().Year;
            int jour = rapport.GetDate().Day;
            int mois = rapport.GetDate().Month;

            //construction de la requête SQL insert
            dbc.CommandText = "INSERT INTO rapport(date, motif, bilan, idVisiteur, idMedecin) VALUES ( "
                + "'" + annee + "-" + mois + "-" + jour + "',"
                + "'" + rapport.GetMotif() + "',"
                + "'" + rapport.Getbilan() + "',"
                + "'" + rapport.GetIdVisiteur() + "',"
                + "'" + rapport.GetIdMedecin() + "'"
                + ")";

            // Exécution de la requête
            dbc.ExecuteNonQuery();
        }

        //Récupère le nombre de rapport par ans
        public static List<List<String>> GetRapportByYear()
        {
            DbCommand dbc = GetConnexion().CreateCommand();

            List<List<String>> outerList = new List<List<String>>();
            

            //construction de la requête SQL
            dbc.CommandText = "SELECT YEAR(date), COUNT(*) FROM rapport GROUP BY YEAR(date)";

            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                List<String> innerList = new List<String>();
                int year = (int)reader["YEAR(date)"];
                long nbRapport = (long)reader["COUNT(*)"];
                innerList.Add(year.ToString());
                innerList.Add(nbRapport.ToString());

                outerList.Add(innerList);
            }
            reader.Close();
            return outerList;
        }
    }
}
