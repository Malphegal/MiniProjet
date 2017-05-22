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
            Hide();
            new frmAffichage().ShowDialog();
            Show();
        }

        private void NouveauFrmModiTransac(object sender, EventArgs e)
        {
            Hide();
            new frmModiTransac().ShowDialog();
            Show();
        }

        private void NouveauFrmRecap(object sender, EventArgs e)
        {
            Hide();
            new frmRecap().ShowDialog();
            Show();
        }

        private void NouveauFrmSupprTransac(object sender, EventArgs e)
        {
            Hide();
            new frmSupprTransac().ShowDialog();
            Show();
        }

        private void NouveauFrmOption(object sender, EventArgs e)
        {
            new frmOption().ShowDialog();
        }

        private void btnAjouterPersonne_Click(object sender, EventArgs e)
        {
            new frmAjouterPersonne().ShowDialog();
        }
    }
}
