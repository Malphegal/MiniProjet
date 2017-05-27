using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        /* Met sur les TextBox et autres composents les valeurs par défaut */
        void InitToutesLesValeurs()
        {
            txtPourcentageSMS.Text = pourcentageSMS.ToString();
        }

        /* Valeur pour le pourcentage */
        public static byte pourcentageSMS = 10;
        private void EntrerUneValeurPourcentageSMS(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) && txtPourcentageSMS.Text.Length < 2 || e.KeyChar == 8 || e.KeyChar == 13)
                e.Handled = false;
        }
        private void MiseAJourDeLaValeurPourcentSMS(object sender, EventArgs e)
        {
            if (txtPourcentageSMS.Text.Length != 0)
                pourcentageSMS = Convert.ToByte(txtPourcentageSMS.Text); 
        }

        private void FermerFrmOption(object sender, EventArgs e)
        {
            MettreValeurAJour();
            Close();
        }

        private void MettreValeurAJour()
        {
            string[] fichier = File.ReadAllLines(@"..\..\Resources\ValeurParDefaut.txt");

            fichier[1] = pourcentageSMS.ToString();

            File.WriteAllLines(@"..\..\Resources\ValeurParDefaut.txt", fichier);
        }
    }
}
