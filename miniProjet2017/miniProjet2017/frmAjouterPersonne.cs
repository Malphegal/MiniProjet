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
    public partial class frmAjouterPersonne : Form
    {
        public frmAjouterPersonne()
        {
            InitializeComponent();
            Scale(new SizeF(frmMain.resolutionScale, frmMain.resolutionScale));
            frmMain.RedimensionnerLesControls(this, frmMain.resolutionScale);
        }

        /* Ferme ce formulaire */
        private void QuitterAjouterPersonne(object sender, EventArgs e)
        {
            Close();
        }

        /* Vérification avant d'ajouter une personne */
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
                    errorProvider1.SetError(txtNumero, "Le numéro est optionnel, ou doit contenir 10 chiffres !");
                    toutEstOK = false;
                }
            else
                errorProvider1.SetError(txtNumero, "");

                // Si aucune erreur est présente, on peut ajouter la transaction

            if (toutEstOK)
                if (DialogResult.OK == MessageBox.Show("Voulez-vous ajouter cette personne ?", "Ajouter une personne", MessageBoxButtons.OKCancel)) {
                    try {
                        CON con = new CON(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget1.mdb");
                        con.Open();
                        new CMD(@"INSERT INTO Personne VALUES (" + new CMD(@"SELECT IIF(max(codePersonne) IS NULL, 0, max(codePersonne) + 1) FROM Personne", con).ExecuteScalar() + ", '"
                                                                + txtNom.Text + "', '"
                                                                + txtPrenom.Text + "', "
                                                                + (txtNumero.Text.Length == 0 ? "NULL" : txtNumero.Text)
                                                                + ")", con).ExecuteNonQuery();
                        MessageBox.Show("Personne ajoutée !");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur s'est produite :\n" + ex);
                    }
                }
                else
                    MessageBox.Show("Aucune modification n'a été effectée !");
        }

        /* Controle de saisie du numéro */
        private void SaisieDuNumeroTelephone(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) && txtNumero.Text.Length < 10 || e.KeyChar == 8)
                e.Handled = false;
        }

        /* Controle de saisie du prénom/nom */
        private void SaisiePrenomNom(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '-' || e.KeyChar == ' ')
                e.Handled = false;
        }
    }
}
