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
            Scale(new SizeF(frmMain.resolutionScale, frmMain.resolutionScale));
            frmMain.RedimensionnerLesControls(this, frmMain.resolutionScale);
        }

        /* Met sur les TextBox et autres composents les valeurs par défaut */
        void InitToutesLesValeurs()
        {
            txtPourcentageSMS.Text = pourcentageSMS.ToString();
            txtResolution.Text = valeurResolution.ToString();
        }

        /* Valeur pour le pourcentage */
        public static byte pourcentageSMS; // 10
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

        /* Valeur résolution */
        public static byte valeurResolution; // 2
        private void EntrerUneValeurResolution(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == 8)
                || !(txtResolution.Text.Length == 0 || (txtResolution.Text.Length == 1 && (e.KeyChar == 8 || txtResolution.SelectionLength == 1))))
                e.Handled = true;
        }
        private void MiseAJourDeLaResolution(object sender, EventArgs e)
        {
            if (txtResolution.Text.Length != 0)
                valeurResolution = Convert.ToByte(txtResolution.Text);
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

            fichier[3] = pourcentageSMS.ToString();

            fichier[5] = valeurResolution.ToString();

            File.WriteAllLines(@"..\..\Resources\ValeurParDefaut.txt", fichier);
        }

        /* Modification du fichier de la base de donnéee */
        public static string baseDeDonnee;
        private void ChangerBaseDeDonnee(object sender, EventArgs e)
        {
            openFD.Title = "Sélectionnez votre base de donnée";
            openFD.Filter = "Votre_base_de_donnée | *.mdb";
            openFD.InitialDirectory = ".";
            if (DialogResult.OK == openFD.ShowDialog())
            {
                baseDeDonnee = openFD.FileName;
                frmMain.con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + baseDeDonnee + ";Persist Security Info=True";
                if (File.Exists(@"..\..\Resources\ValeurParDefaut.txt"))
                {
                    string[] fichier = File.ReadAllLines(@"..\..\Resources\ValeurParDefaut.txt");
                    try { fichier[1] = baseDeDonnee; File.WriteAllLines(@"..\..\Resources\ValeurParDefaut.txt", fichier);
                        lblSourceBaseDonnee.Text = baseDeDonnee; frmMain.baseExist = true; }
                    catch { MessageBox.Show("Erreur dans le fichier ValeurParDefaut"); }
                }
            }
        }

        /* Initialise le label du chemin de la base de donnée */
        private void ChargementDeFrmOption(object sender, EventArgs e)
        {
                // Parent pour transparent

            picQuitter.Parent = picBordure;

                // Si le fichier existe

            if (File.Exists(@"..\..\Resources\ValeurParDefaut.txt"))
                try {
                    if (File.Exists(File.ReadAllLines(@"..\..\Resources\ValeurParDefaut.txt")[1]))
                        lblSourceBaseDonnee.Text = baseDeDonnee = File.ReadAllLines(@"..\..\Resources\ValeurParDefaut.txt")[1];
                    else
                        lblSourceBaseDonnee.Text = "Manquante !"; 
                }
                catch { MessageBox.Show("Erreur de base de donnée !"); }
        }
    }
}