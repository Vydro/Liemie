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
            JObject JsonLogin = new JObject();
            JsonLogin = JObject.Parse(responseFromServer);
            if (JsonLogin["nom"].ToString() != "" && JsonLogin["prenom"].ToString() != "")
            {
                try
                {
                    personne p = new personne
                    {
                        id = Convert.ToInt32(JsonLogin["id"].ToString()),
                        nom = Convert.ToString(JsonLogin["nom"]),
                        prenom = Convert.ToString(JsonLogin["prenom"]),
                        sexe = Convert.ToString(JsonLogin["sexe"]),
                        date_naiss = Convert.ToDateTime(JsonLogin["date_naiss"]),
                        date_deces = Convert.ToDateTime(JsonLogin["date_deces"]),
                        ad1 = Convert.ToString(JsonLogin["ad1"]),
                        ad2 = Convert.ToString(JsonLogin["ad2"]),
                        cp = Convert.ToInt32(JsonLogin["cp"]),
                        ville = Convert.ToString(JsonLogin["ville"]),
                        tel_fixe = Convert.ToString(JsonLogin["tel_fixe"]),
                        tel_port = Convert.ToString(JsonLogin["tel_port"]),
                        mail = Convert.ToString(JsonLogin["mail"]),
                    };/*
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
                        infirmiere_badge = 
                        fichier_photo = 
                    };*/
                }
                catch (Exception e) { vretour = e.InnerException.ToString(); }
            }return vretour;
        }

        /*public bool ModifDerniereConnexion(personne_login pl, string dateDerniereConnexion)
        {
        }*/

    }
}
