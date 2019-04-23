using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liemie
{
    public partial class Menu : Form
    {
        int idUtilisateur;
        List<Panel> listPanel = new List<Panel>();
        
        public Menu(int unIdUtilisateur)
        {
            InitializeComponent();
            this.idUtilisateur = unIdUtilisateur;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            listPanel.Add(pnl_menu);
            listPanel.Add(pnl_mesVisites);
            DimenssionDesPanels(908, 462);
            ToutFermerEtOuvrirCePanel(pnl_menu);
        }

        private void ToutFermerEtOuvrirCePanel(Panel monPanel)
        {
            if(listPanel.Contains(monPanel))
            {
                foreach(Panel pnl in listPanel)
                {                    
                    pnl.Hide();
                }
                monPanel.Show();
            }
        }

        public void DimenssionDesPanels(int h, int l)
        {
            foreach (Panel pnl in listPanel)
            {
                pnl.Size = new Size(h, l);
            }
        }


        private void btn_màjVisites_Click(object sender, EventArgs e)
        {
            if (Model_Kaliemie.RapatrierMesVisites(idUtilisateur) != "")
            { MessageBox.Show(Model_Kaliemie.RapatrierMesVisites(idUtilisateur)); }
            AfficherDGVMesVisites();
        }

        public void AfficherDGVMesVisites()
        {
            bs_mesVisites.DataSource = Model_Kaliemie.listVisites(idUtilisateur);
            dgv_mesVisites.DataSource = bs_mesVisites;
            for (int i = 0; i < dgv_mesVisites.ColumnCount; i++)
            {
                dgv_mesVisites.Columns[i].Visible = false;
            }
            dgv_mesVisites.Columns["patient"].Visible = true;
            dgv_mesVisites.Columns["patient"].HeaderText = "Patient";
            dgv_mesVisites.Columns["date_prevue"].Visible = true;
            dgv_mesVisites.Columns["date_prevue"].HeaderText = "Date prévue";
            dgv_mesVisites.Columns["date_reelle"].Visible = true;
            dgv_mesVisites.Columns["date_reelle"].HeaderText = "Date réelle";
            dgv_mesVisites.Columns["duree"].Visible = true;
            dgv_mesVisites.Columns["duree"].HeaderText = "Durée";
            dgv_mesVisites.Columns["compte_rendu_infirmiere"].Visible = true;
            dgv_mesVisites.Columns["compte_rendu_infirmiere"].HeaderText = "Compte rendu infirmiere";
            dgv_mesVisites.Columns["compte_rendu_patient"].Visible = true;
            dgv_mesVisites.Columns["compte_rendu_patient"].HeaderText = "Compte rendu patient";
        }

        private void tsm_planningVisites_Click(object sender, EventArgs e)
        {
            ToutFermerEtOuvrirCePanel(pnl_mesVisites);
            AfficherDGVMesVisites();
        }

        private void tsm_menuPrincipal_Click(object sender, EventArgs e)
        {
            ToutFermerEtOuvrirCePanel(pnl_menu);
        }

        private void tsm_deconnexion_Click(object sender, EventArgs e)
        {
            Connexion c = new Connexion();
            c.Show();
            this.Hide();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
