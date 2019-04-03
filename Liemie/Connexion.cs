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
            Menu fm = new Menu();
            if (tb_identifiant.Text != "" && tb_motDePasse.Text != "")
            {
                switch (Model_Kaliemie.ConnexionLocal(tb_identifiant.Text, tb_motDePasse.Text))
                {
                    case "Error_local_request" :
                        if (Model_Kaliemie.connexionWebService(tb_identifiant.Text, tb_motDePasse.Text) != "AjoutLocalOK")
                        {
                            lbl_alert.Text = Model_Kaliemie.connexionWebService(tb_identifiant.Text, tb_motDePasse.Text);
                        }
                        else {fm.Show(); this.Hide(); }
                        break;
                    case "Identifiant ou mot de passe incorrect":
                        lbl_alert.Text = Model_Kaliemie.ConnexionLocal(tb_identifiant.Text, tb_motDePasse.Text);
                        break;
                    default :
                        fm.Show(); this.Hide();
                        break;
                }
            }
            else { lbl_alert.Text = "Tous les champs doivent être remplient"; }
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
