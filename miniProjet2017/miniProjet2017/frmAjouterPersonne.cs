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

namespace miniProjet2017
{
    public partial class frmAjouterPersonne : Form
    {
        public frmAjouterPersonne()
        {
            InitializeComponent();
        }

        /* Ferme ce formulaire */
        private void QuitterAjouterPersonne(object sender, EventArgs e)
        {
            Close();
        }

        private void CliquerSurValider(object sender, EventArgs e)
        {
                // Sera 'false' si au moins une erreur se produit

            bool toutEstOK = true;

                // Position des erreurs

            errorProvider1.SetIconPadding(txtPrenom, 10);
            errorProvider1.SetIconPadding(txtNom, 10);
            errorProvider1.SetIconPadding(txtNumero, 10);

                // Les vérifications au cas par cas

            if (txtPrenom.Text.Length == 0)
            {
                errorProvider1.SetError(txtPrenom, "Il faut indiquer un prénom !");
                toutEstOK = false;
            }else
                errorProvider1.SetError(txtPrenom, "");

            if (txtNom.Text.Length == 0)
            {
                errorProvider1.SetError(txtNom, "Il faut indiquer un nom !");
                toutEstOK = false;
            }else
                errorProvider1.SetError(txtNom, "");

            if (txtNumero.Text.Length != 0)
                if (txtNumero.Text.Length != 10)
                {
                    errorProvider1.SetError(txtNumero, "Le numéro est optionnel, ou doit contenir 10 chiffre !");
                    toutEstOK = false;
                }
            else
                errorProvider1.SetError(txtNumero, "");

                // Si aucune erreur est présente, on peut ajouter la transaction

            if (toutEstOK)
            {

            }
        }
    }
}
