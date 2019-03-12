using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;


namespace Liemie
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void btn_seConnecter_Click(object sender, EventArgs e)
        {
            connexion(tb_identifiant.Text, tb_motDePasse.Text);
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            tb_identifiant.Text = "";
            tb_motDePasse.Text = "";
        }

        public static string connexion(string login, string passwd)
        {
            string vretour = "Error";
            var url = "http://www.btssio-carcouet.fr/ppe4/public/connect2/" + login + "/" + passwd + "/infirmiere";
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            JObject JsonLogin = JObject.Parse(responseFromServer);
            if(JsonLogin["nom"].ToString() != "" && JsonLogin["prenom"].ToString() != "")
            {
                string identifiant = JsonLogin["nom"].ToString() + " " + JsonLogin["prenom"].ToString();
                vretour = identifiant;
            }
            return vretour;
        }
    }
}
