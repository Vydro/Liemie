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
        private static Kaliemie maConnexion;

        public static void init()
        {
            maConnexion = new Kaliemie();
        }


        public static string encode(string input) //cryptage
        {
            /*byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();*/

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
                if (v.mp == password)
                { vretour = login; }
            }
            return vretour;
        }
        public static string connexionWebService(string login, string password)
        {
            string vretour = "Error_web_service_request";
            //var url = "http://172.16.4.224/service-web/app/public/connect?login=" + login + "&mdp=" + password;
            var url = "http://www.btssio-carcouet.fr/ppe4/public/connect2/" + login + "/" + password + "/infirmiere";
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            vretour = responseFromServer;
            //JObject JsonLogin = JObject.Parse(responseFromServer);
            /*if (JsonLogin["nom"].ToString() != "" && JsonLogin["prenom"].ToString() != "")
            {
                string identifiant = JsonLogin["nom"].ToString() + " " + JsonLogin["prenom"].ToString();
                vretour = identifiant;


            }*/
            return vretour;
        }

    }
}
