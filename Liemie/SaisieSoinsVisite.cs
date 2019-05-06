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
    public partial class SaisieSoinsVisite : Form
    {
        int idVisite;
        public SaisieSoinsVisite(int unIdVisite)
        {
            InitializeComponent();
            this.idVisite = unIdVisite;
        }

        private void SaisieSoinsVisite_Load(object sender, EventArgs e)
        {
            lbl_titre.Text = lbl_titre.Text + idVisite.ToString();

            cmb_categSoins.ValueMember = "id"; //valeur réel
            cmb_categSoins.DisplayMember = "libel"; //valeur affiché
            bs_categSoins.DataSource = Model_Kaliemie.listCategSoins(); //remplissage du BindingSource avec une requête
            cmb_categSoins.DataSource = bs_categSoins; //remplissage de la combo depuis BindingSource
        }

        private void bs_categSoins_CurrentChanged(object sender, EventArgs e)
        {
            txt_descCategSoins.Text = ((categ_soins)bs_categSoins.Current).libel.ToString() + ":\r\n" +
                ((categ_soins)bs_categSoins.Current).description.ToString();
            cmb_typeSoins.ValueMember = "id_type_soins";
            cmb_typeSoins.DisplayMember = "libel";
            bs_typeSoins.DataSource = ((categ_soins)bs_categSoins.Current).type_soins.ToList().OrderBy(x => x.id_type_soins);
            cmb_typeSoins.DataSource = bs_typeSoins;

        }

        private void bs_typeSoins_CurrentChanged(object sender, EventArgs e)
        {
            txt_descTypeSoins.Text = ((type_soins)bs_typeSoins.Current).libel.ToString() + ":\r\n" +
                ((type_soins)bs_typeSoins.Current).description.ToString();
            cmb_soins.ValueMember = "id";
            cmb_soins.DisplayMember = "libel";
            bs_soins.DataSource = ((type_soins)bs_typeSoins.Current).soins.ToList().OrderBy(x => x.id);
            cmb_soins.DataSource = bs_soins;
        }
        private void bs_soins_CurrentChanged(object sender, EventArgs e)
        {
            lbl_coeffSoins.Text = "Coefficient " + ((soins)bs_soins.Current).coefficient.ToString();
            txt_descSoins.Text = ((soins)bs_soins.Current).libel.ToString();
        }

        private void cmb_typeSoins_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value.ToString().Length > 30)
            {
                e.Value = e.Value.ToString().Substring(0,30)+"...";
            }
        }

        private void cmb_soins_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value.ToString().Length > 30)
            {
                e.Value = e.Value.ToString().Substring(0, 30) + "...";
            }
        }

        private void btn_finaliser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Attention", "Ête vous sûre de vouloir valider ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                short p = 0, r = 0;
                if(chk_prevue.Checked == true) { p = 1; }
                if (chk_realise.Checked == true) { r = 1; }
                MessageBox.Show(Model_Kaliemie.AjouterSoinsVisite(idVisite, Convert.ToInt32(cmb_categSoins.SelectedValue),
                    Convert.ToInt32(cmb_typeSoins.SelectedValue), Convert.ToInt32(cmb_soins.SelectedValue), p, r));
            }
        }
    }
}
