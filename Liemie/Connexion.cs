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

        private void Connexion_Load(object sender, EventArgs e)
        {
            lbl_alert.Text = "";
        }

        private void btn_seConnecter_Click(object sender, EventArgs e)
        {
            lbl_alert.Text = "";
            
            if (tb_identifiant.Text != "" && tb_motDePasse.Text != "")
            {
                switch (Model_Kaliemie.ConnexionLocal(tb_identifiant.Text, tb_motDePasse.Text))
                {
                    case -1 :
                        switch (Model_Kaliemie.connexionWebService(tb_identifiant.Text, tb_motDePasse.Text))
                        { 
                            case -1:
                                lbl_alert.Text = "Votre compte n'a pas pû être ajouté au serveur local";
                            break;
                            case -2:
                                lbl_alert.Text = "Le compte n'a pas été trouvez sur le serveur distant \n Identifiant ou mot de passe incorrect";
                            break;
                            default:
                                new Menu(Model_Kaliemie.ConnexionLocal(tb_identifiant.Text, tb_motDePasse.Text)).Show();
                                this.Hide();
                            break;
                        }
                        break;
                    case -2:
                        lbl_alert.Text = "Identifiant ou mot de passe incorrect";
                        break;
                    default :
                        new Menu(Model_Kaliemie.ConnexionLocal(tb_identifiant.Text, tb_motDePasse.Text)).Show();
                        this.Hide();
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

        private void Connexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
