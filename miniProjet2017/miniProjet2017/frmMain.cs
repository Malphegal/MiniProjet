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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // ---------------------------------------------
        // Les boutons pour afficher les autres fenêtres
        // ---------------------------------------------

        private void NouveauFrmAjoutTransac(object sender, EventArgs e)
        {
            Hide();
            new frmAjoutTransac().ShowDialog();
            Show();
        }

        private void NouveauFrmAffichage(object sender, EventArgs e)
        {
            new frmAffichage().ShowDialog();
        }

        private void NouveauFrmModiTransac(object sender, EventArgs e)
        {
            new frmModiTransac().ShowDialog();
        }

        private void NouveauFrmRecap(object sender, EventArgs e)
        {
            new frmRecap().ShowDialog();
        }

        private void NouveauFrmSupprTransac(object sender, EventArgs e)
        {
            new frmSupprTransac().ShowDialog();
        }
    }
}
