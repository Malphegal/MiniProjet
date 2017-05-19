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
    public partial class frmAjoutTransac : Form
    {
        public frmAjoutTransac()
        {
            InitializeComponent();
        }

        private void frmAjoutTransac_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            {
                bool toutEstOk = true;

                errorProvider.SetIconPadding(cboType, 15);
                errorProvider.SetIconPadding(txtDescTran, 15);
                errorProvider.SetIconPadding(txtMontant, 15);

                if (cboType.SelectedIndex == -1)
                {
                    errorProvider.SetError(cboType, "Il faut séléctionner un type pour cette transaction !");
                    toutEstOk = false;
                }
                else errorProvider.SetError(cboType, "");

                if (txtMontant.Text == "")
                {
                    errorProvider.SetError(cboType, "Il faut indiquer un montant pour cette transaction !");
                    toutEstOk = false;
                }
                else errorProvider.SetError(cboType, "");

                if (txtDescTran.Text == "")
                {
                    errorProvider.SetError(cboType, "Il faut décrire cette transaction !");
                    toutEstOk = false;
                }
                else errorProvider.SetError(cboType, "");
            }
    }
}
