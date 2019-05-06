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

            cb_categSoins.ValueMember = "id"; //valeur réel
            cb_categSoins.DisplayMember = "libel"; //valeur affiché
            bs_categSoins.DataSource = Model_Kaliemie.listCategSoins(); //remplissage du BindingSource avec une requête
            cb_categSoins.DataSource = bs_categSoins; //remplissage de la combo depuis BindingSource
        }

        private void bs_categSoins_CurrentChanged(object sender, EventArgs e)
        {
            tb_descCategSoins.Text = ((categ_soins)bs_categSoins.Current).libel.ToString() + ":\r\n" +
                ((categ_soins)bs_categSoins.Current).description.ToString();
            cb_typeSoins.ValueMember = "id_type_soins";
            cb_typeSoins.DisplayMember = "libel";
            bs_typeSoins.DataSource = ((categ_soins)bs_categSoins.Current).type_soins.ToList().OrderBy(x => x.id_type_soins);
            cb_typeSoins.DataSource = bs_typeSoins;

        }

        private void bs_typeSoins_CurrentChanged(object sender, EventArgs e)
        {
            tb_descTypeSoins.Text = ((type_soins)bs_typeSoins.Current).libel.ToString() + ":\r\n" +
                ((type_soins)bs_typeSoins.Current).description.ToString();
            cb_soins.ValueMember = "id";
            cb_soins.DisplayMember = "libel";
            bs_soins.DataSource = ((type_soins)bs_typeSoins.Current).soins.ToList().OrderBy(x => x.id);
            cb_soins.DataSource = bs_soins;
        }
        private void bs_soins_CurrentChanged(object sender, EventArgs e)
        {
            lbl_coeffSoins.Text = "Coefficient " + ((soins)bs_soins.Current).coefficient.ToString();
            lbl_dateSoins.Text = "Date " + ((soins)bs_soins.Current).date.ToString().Substring(0, 10);
        }

        private void cb_typeSoins_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value.ToString().Length > 30)
            {
                e.Value = e.Value.ToString().Substring(0,30)+"...";
            }
        }

        private void cb_soins_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value.ToString().Length > 30)
            {
                e.Value = e.Value.ToString().Substring(0, 30) + "...";
            }
        }

        
    }
}
