using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProjet2017
{
    public partial class frmOption : Form
    {
        public frmOption()
        {
            InitializeComponent();
            InitToutesLesValeurs();
        }

        void InitToutesLesValeurs()
        {
            txtPourcentageSMS.Text = pourcentageSMS.ToString();
        }

        /* Valeur pour le pourcentage */
        static byte pourcentageSMS = 10;
        private void EntrerUneValeurPourcentageSMS(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) && txtPourcentageSMS.Text.Length < 3 || e.KeyChar == 8)
                e.Handled = false;
        }
        private void MiseAJourDeLaValeurPourcentSMS(object sender, EventArgs e)
        {
            // TODO : Check if NULL
            pourcentageSMS = Convert.ToByte(txtPourcentageSMS.Text); 
        }
    }
}
