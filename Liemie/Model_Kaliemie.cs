using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace Liemie
{
    class Model_Kaliemie
    {
        private static KaliemieConnect maConnexion;
        

        public static void init()
        {
            maConnexion = new KaliemieConnect();
        }


        public static string encode(string input) //cryptage
        {
            #region ancien code
            /*byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();*/
            #endregion

            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static int ConnexionLocal(string login, string password)
        {
            int vretour = -1; //si n'existe pas en local envoi -1
            password = encode(password); //cryptage

                var LQuery = maConnexion.personne_login.ToList()
                                .Where(x => x.login == login)
                               .Select(x => new { x.login, x.mp, x.id });

            foreach (var v in LQuery)
            {
                if (v.login == login && v.mp == password)
                { vretour = v.id; break; }

                if(v.login == login && v.mp != password)
                {
                    vretour = -2;break;
                }
            }
            return vretour;
        }
        public static int connexionWebService(string login, string password)
        {
            int vretour;
            var url = "http://www.btssio-carcouet.fr/ppe4/public/connect2/" + login + "/" + password + "/infirmiere";
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            JObject JsonLogin = new JObject();
            JsonLogin = JObject.Parse(responseFromServer);

            if (! responseFromServer.Contains("{\"status\":\"false\"}"))
            {
                try
                {
                    personne p = new personne
                    {
                        id = Convert.ToInt32(JsonLogin["id"]),
                        nom = Convert.ToString(JsonLogin["nom"]),
                        prenom = Convert.ToString(JsonLogin["prenom"]),
                        sexe = Convert.ToString(JsonLogin["sexe"]),
                        date_naiss = Convert.ToDateTime(JsonLogin["date_naiss"]),
                        ad1 = Convert.ToString(JsonLogin["ad1"]),
                        ad2 = Convert.ToString(JsonLogin["ad2"]),
                        cp = Convert.ToInt32(JsonLogin["cp"]),
                        ville = Convert.ToString(JsonLogin["ville"]),
                        tel_fixe = Convert.ToString(JsonLogin["tel_fixe"]),
                        tel_port = Convert.ToString(JsonLogin["tel_port"]),
                        mail = Convert.ToString(JsonLogin["mail"]),
                    };
                    if (JsonLogin["date_deces"].HasValues) { p.date_deces = Convert.ToDateTime(JsonLogin["date_deces"]); }
                    else { p.date_deces = null; }
                    
                    personne_login pl = new personne_login
                    {
                        id = Convert.ToInt32(JsonLogin["id"].ToString()),
                        login = login,
                        mp = encode(password),
                        derniere_connexion = DateTime.Now.Date,
                        nb_tentative_erreur = 0,
                    };
                    infirmiere i = new infirmiere
                    {
                        id = Convert.ToInt32(JsonLogin["id"].ToString()),
                        fichier_photo = null,
                    };
                    
                    maConnexion.personne.Add(p);
                    maConnexion.personne_login.Add(pl);
                    maConnexion.infirmiere.Add(i);
                    maConnexion.SaveChanges();
                    vretour = i.id; //renvoi l'id de la personne
                }catch (Exception)
                { vretour = -1; } //ajout problème
            }
            else { vretour = -2; } //id ou mdp incorrect liens incorrect status false
            return vretour;
        }


        public static string RapatrierMesVisites(int identifiant)
        {
            string vretour = "";
            var url = "http://www.btssio-carcouet.fr/ppe4/public/mesvisites/" + identifiant;
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            JArray JsonVisites = new JArray();
            JsonVisites = JArray.Parse(responseFromServer);
            if (! responseFromServer.Contains("[]"))
            {
                try
                {
                    int index = 0, n = -1;
                    visite[] v = new visite[JsonVisites.Count];
                    while (JsonVisites.Count > index)
                    {   
                        if(VisiteExiste(Convert.ToInt32(JsonVisites[index]["id"])) == false)
                        {
                            CultureInfo provider = CultureInfo.InvariantCulture;

                            if(PatientExiste(Convert.ToInt32(JsonVisites[index]["patient"])) == false)
                            { RapatrierPatient(Convert.ToInt32(JsonVisites[index]["patient"])); }

                            v[n + 1] = new visite
                            {
                                id = Convert.ToInt32(JsonVisites[index]["id"]),
                                patient = Convert.ToInt32(JsonVisites[index]["patient"]),
                                infirmiere = identifiant,
                                date_prevue = Convert.ToDateTime(JsonVisites[index]["date_prevue"], provider),
                                date_reelle = null, //Convert.ToDateTime(JsonVisites[index]["date_reel"], provider),
                                duree = Convert.ToInt32(JsonVisites[index]["duree"]),
                                compte_rendu_infirmiere = Convert.ToString(JsonVisites[index]["compte_rendu_infirmiere"]),
                                compte_rendu_patient = Convert.ToString(JsonVisites[index]["compte_rendu_patient"]),
                            };
                            maConnexion.visite.Add(v[n + 1]);
                        }
                        index ++;
                        n++;
                    }
                    maConnexion.SaveChanges();
                    if(v.Count() == 0) { vretour = "Il n'y pas de visite supplémentaire"; } else {  }
                }
                catch (Exception e)
                { vretour = "Le rapatriement des visites a échoué \n" + e; }
            }
            else { vretour = "Il n'y a pas de visite"; }
            return vretour;
        }

        public static string RapatrierPatient(int identifiant)
        {
            string v = "";
            var url = "http://www.btssio-carcouet.fr/ppe4/public/personne/" + identifiant;
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            JArray JsonPatient = new JArray();
            JsonPatient = JArray.Parse(responseFromServer);

            if (! responseFromServer.Contains("[]"))
            {
                try
                {
                    personne per = new personne
                    {
                        id = Convert.ToInt32(JsonPatient[0]["id"]),
                        nom = Convert.ToString(JsonPatient[0]["nom"]),
                        prenom = Convert.ToString(JsonPatient[0]["prenom"]),
                        sexe = Convert.ToString(JsonPatient[0]["sexe"]),
                        date_naiss = Convert.ToDateTime(JsonPatient[0]["date_naiss"]),
                        ad1 = Convert.ToString(JsonPatient[0]["ad1"]),
                        ad2 = Convert.ToString(JsonPatient[0]["ad2"]),
                        cp = Convert.ToInt32(JsonPatient[0]["cp"]),
                        ville = Convert.ToString(JsonPatient[0]["ville"]),
                        tel_fixe = Convert.ToString(JsonPatient[0]["tel_fixe"]),
                        tel_port = Convert.ToString(JsonPatient[0]["tel_port"]),
                        mail = Convert.ToString(JsonPatient[0]["mail"]),
                    };
                    if (JsonPatient[0]["date_deces"].HasValues) { per.date_deces = Convert.ToDateTime(JsonPatient["date_deces"]); }
                    else { per.date_deces = null; }

                    patient pat = new patient
                    {
                        id = Convert.ToInt32(JsonPatient[0]["id"]),
                        informations_medicales = "",
                        personne_de_confiance = null,
                        infirmiere_souhait = null,
                    };

                    maConnexion.personne.Add(per);
                    maConnexion.patient.Add(pat);
                    maConnexion.SaveChanges();
                    v= "ok";
                }
                catch (Exception e)
                { v = e.ToString(); }
                v = "non";
            }return v;
        }

        public static bool VisiteExiste(int idVisite)
        {
            bool vretour = false;

            var LQuery = maConnexion.visite.ToList()
                            .Where(x => x.id == idVisite)
                           .Select(x => new { x.id });

            foreach (var v in LQuery)
            {
                if(v.id == idVisite) { vretour = true; }
            }
            return vretour;
        }

        public static bool PatientExiste(int idPatient)
        {
            bool vretour = false;

            var LQuery = maConnexion.patient.ToList()
                            .Where(x => x.id == idPatient)
                           .Select(x => new { x.id });

            foreach (var v in LQuery)
            {
                if (v.id == idPatient) { vretour = true; }
            }
            return vretour;
        }

        public static List<visite> listVisites(int id)
        {
            var LQuery = maConnexion.visite.ToList()
                          .Where(x => x.infirmiere == id)
                          .OrderBy(x => x.date_prevue);
            return LQuery.ToList();
        }
    }
}
