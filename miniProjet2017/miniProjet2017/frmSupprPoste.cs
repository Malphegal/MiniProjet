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
    public partial class frmSupprPoste : Form
    {
        public frmSupprPoste()
        {
            InitializeComponent();
        }

        /* Ferme le frmBudgetRecap */

        private void QuitterFrmBudgetRecap(object sender, EventArgs e)
        {            
            Close();
        }
    }
}
