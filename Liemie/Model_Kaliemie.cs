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

        public static string ConnexionLocal(string login, string password)
        {
            string vretour = "Error_local_request";
            password = encode(password); //cryptage

            var LQuery = maConnexion.personne_login.ToList()
                            .Where(x => x.login == login)
                           .Select(x => new { x.login, x.mp });

            foreach (var v in LQuery)
            {
                if (v.mp == password && v.login == login)
                { vretour = login; }
            }
            return vretour;
        }
        public static string connexionWebService(string login, string password)
        {
            string vretour = "Error_web_service_request";
            var url = "http://www.btssio-carcouet.fr/ppe4/public/connect2/" + login + "/" + password + "/infirmiere";
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            JObject JsonLogin = JObject.Parse(responseFromServer);
            if (JsonLogin["nom"].ToString() != "" && JsonLogin["prenom"].ToString() != "")
            {
                string identifiant = JsonLogin["nom"].ToString() + " " + JsonLogin["prenom"].ToString();
                vretour = identifiant;
            }
            return vretour;
        }

        public static bool AjoutPersonne(int id, string nom, string prenom, string sexe,
            DateTime dateNaiss, DateTime dateDeces, string ad1, string ad2, int cp, string ville,
                int telFixe, int telPort, string email)
        {
            bool vretour = true;
            try
            {
                personne p = new personne();
                p.id = id;
                p.nom = nom;
                p.prenom = prenom;
                p.sexe = sexe;
                p.date_naiss = dateNaiss;
                p.date_deces = dateDeces;
                p.ad1 = ad1;
                p.ad2 = ad2;
                maConnexion.personne.Add(p);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool AjoutPersonneLogin(int id, string login, string mp,
           DateTime derniereConnexion, int nbTentativeErreur)
        {
            bool vretour = true;
            try
            {
                personne_login pl = new personne_login();
                pl.id = id;
                pl.login = login;
                pl.mp = mp;
                pl.derniere_connexion = derniereConnexion;
                pl.nb_tentative_erreur = nbTentativeErreur;
                maConnexion.personne_login.Add(pl);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool ModifDerniereConnexion(DateTime dateDerniereConnexion)
        {
            dateDerniereConnexion = DateTime.Now.Date;
            bool vretour = true;
            try
            {
                personne_login pl = new personne_login();

                maConnexion.personne_login.Add(pl);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

    }
}
