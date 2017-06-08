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
    public partial class frmPosteRevenu : Form
    {
        public frmPosteRevenu()
        {
            InitializeComponent();
        }

        /* Ferme le formulaire frmPosteRevenu */
        private void QuitterFrmPosteRevenu(object sender, EventArgs e)
        {
            Close();
        }

        /* Ajouter le poste de revenu dans la base de donnée */
        private void AjouterLePosteRevenu(object sender, EventArgs e)
        {
                // Sera faux s'il y a une erreur

            bool toutEstOK = true;

                // Tester au cas par cas

            

                // Si tout est ok, alors ajouter dans la base de donnée

            if (toutEstOK)
            {

            }
            else
                MessageBox.Show("Aucune modification n'a été effectuée !");
        }

        static Image flecheRetour_clair = new Bitmap("..\\..\\Resources\\flecheRetour_clair.png");
        static Image flecheRetour;
        /* Souris sur picQuitter */
        private void SourisSurPicQuitter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = flecheRetour_clair;
        }

        /* Souris sors de picQuitter */
        private void SourisSortDePicQuitter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = flecheRetour;
        }
    }
}
