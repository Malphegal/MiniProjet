using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CON = System.Data.OleDb.OleDbConnection;
using CMD = System.Data.OleDb.OleDbCommand;

namespace miniProjet2017
{
    public partial class frmAjoutTransac : Form
    {
        public frmAjoutTransac()
        {
            InitializeComponent();
        }

        private void DémarrageDeAjoutTransac(object sender, EventArgs e)
        {
                // Ajout des CheckBox pour chaque personne se trouvant dans la base de donnée
                //
        }

        private void AjouterUneTransaction(object sender, EventArgs e)
        {
            {
                    // Sera 'false' si au moins une erreur se produit

                bool toutEstOk = true;

                    // Position des erreurs

                errorProvider.SetIconPadding(cboType, 11);
                errorProvider.SetIconPadding(txtDescTran, 11);
                errorProvider.SetIconPadding(txtMontant, 11);

                    // Les vérifications au cas par cas

                if (cboType.SelectedIndex == -1)
                {
                    errorProvider.SetError(cboType, "Il faut séléctionner un type pour cette transaction !");
                    toutEstOk = false;
                }
                else errorProvider.SetError(cboType, "");

                if (txtMontant.Text == "")
                {
                    errorProvider.SetError(txtMontant, "Il faut indiquer un montant pour cette transaction !");
                    toutEstOk = false;
                }
                else errorProvider.SetError(txtMontant, "");

                if (txtDescTran.Text == "")
                {
                    errorProvider.SetError(txtDescTran, "Il faut décrire cette transaction !");
                    toutEstOk = false;
                }
                else errorProvider.SetError(txtDescTran, "");

                    // Si aucune erreur est présente, on peut ajouter la transaction

                if (toutEstOk)
                    MessageBox.Show("Ajout de la transaction terminée !");
            }
        }

        private void QuitterAjoutTransac(object sender, EventArgs e)
        {
            Close();
        }
    }
}
