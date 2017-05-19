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

        /* Les boutons pour afficher les autres fenêtres */

        private void nouveauFrmAjoutTransac(object sender, EventArgs e)
        {
            new frmAjoutTransac().ShowDialog();
        }

        private void nouveauFrmAffichage(object sender, EventArgs e)
        {
            new frmAffichage().ShowDialog();
        }

        private void nouveauFrmModiTransac(object sender, EventArgs e)
        {
            new frmModiTransac().ShowDialog();
        }

        private void nouveauFrmRecap(object sender, EventArgs e)
        {
            new frmRecap().ShowDialog();
        }

        private void nouveauFrmSupprTransac(object sender, EventArgs e)
        {
            new frmSupprTransac().ShowDialog();
        }
    }
}
