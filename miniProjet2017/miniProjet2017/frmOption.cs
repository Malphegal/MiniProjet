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
            if (char.IsNumber(e.KeyChar) && (txtPourcentageSMS.Text.Length < 2 || txtPourcentageSMS.SelectionLength > 0) || e.KeyChar == 8 || e.KeyChar == 13)
                e.Handled = false;
        }
        private void MiseAJourDeLaValeurPourcentSMS(object sender, EventArgs e)
        {
            if (txtPourcentageSMS.Text.Length != 0)
                pourcentageSMS = Convert.ToByte(txtPourcentageSMS.Text); 
        }

        /* Ferme les options et met à jour toutes les valeurs */
        private void FermerFrmOption(object sender, EventArgs e)
        {
            MettreValeurAJour();
            Close();
        }

        /* Changer toutes les valeurs par défaut dans le fichier adéquat */
        private void MettreValeurAJour()
        {
            string[] fichier = File.ReadAllLines(@"..\..\Resources\ValeurParDefaut.txt");

            fichier[1] = pourcentageSMS.ToString();

            File.WriteAllLines(@"..\..\Resources\ValeurParDefaut.txt", fichier);
        }

        // TODO: A compléter !
        /* Modification du fichier de la base de donnéee */
        private void ChangerBaseDeDonnee(object sender, EventArgs e)
        {
            openFD.Title = "Sélectionnez votre base de donnée";
            openFD.Filter = "Votre_base_de_donnée | *.mdb";
            openFD.InitialDirectory = ".";
            openFD.ShowDialog();
        }
    }
}
