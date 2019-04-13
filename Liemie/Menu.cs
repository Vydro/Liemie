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
        int id, Index;
        List<Panel> listPanel = new List<Panel>();
        private void Menu_Load(object sender, EventArgs e)
        {
            listPanel.Add(flp_mesVisites);
        }

        public Menu(int unId)
        {
            InitializeComponent();
            this.id = unId;
        }

       

        private void FermerEtOuvrirCePanel(FlowLayoutPanel monFLP)
        {
            if(listPanel.Contains(monFLP))
            {
                foreach(FlowLayoutPanel flp in listPanel)
                {
                    flp.Hide();
                }
                monFLP.Show();
            }
        }
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
