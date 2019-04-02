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
            lbl_alert.Text = "";
        }

        private void btn_seConnecter_Click(object sender, EventArgs e)
        {
            lbl_alert.Text = "";
            if (tb_identifiant.Text != "" || tb_motDePasse.Text != "")
            {
                string lib;
                if(Model_Kaliemie.ConnexionLocal(tb_identifiant.Text, tb_motDePasse.Text) == "Error_local_request")
                {
                    try
                    {
                        if (Model_Kaliemie.connexionWebService(tb_identifiant.Text, tb_motDePasse.Text) == "Error_local_request") ;
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.ToString());
                    }
                    
                }
                //lib = Model_Keliemie.ConnexionLocal(tb_identifiant.Text,Model_Keliemie.encode(tb_motDePasse.Text));
                lib = Model_Kaliemie.connexionWebService(tb_identifiant.Text, tb_motDePasse.Text);
                MessageBox.Show(lib);
            }
            else { lbl_alert.Text = "*Tous les champs doivent être remplient"; }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            tb_identifiant.Text = "";
            tb_motDePasse.Text = "";
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
