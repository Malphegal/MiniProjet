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
            DémarrageDeAjoutTransac();
        }

        /* Affiche toutes les personne de la table Personne et rempli la combobox pour les type de transaction */
        private void DémarrageDeAjoutTransac()
        {
                // Initialisation des variables de connection

            CON con = new CON("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget1.mdb");
            CMD cmd;
            OleDbDataAdapter da;
            DataSet ds = new DataSet();
            con.Open();

                // Ajout des tables locales

            cmd = new CMD("SELECT * FROM Personne", con);
            da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "_Personne");

            cmd = new CMD("SELECT * FROM TypeTransaction", con);
            da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "_TypeTransaction");

                // Ajout des CheckBox pour chaque personne se trouvant dans la base de donnée

            short top = 0;
            foreach (DataRow row in ds.Tables["_Personne"].Rows)
            {
                new CheckBox()
                {
                    Parent = this,
                    Text = "[" + row[0] + "] " + row[1] + " " + row[2],
                    Location = new Point(480, top += 40),
                    AutoSize = true
                };
            }

                // Remplissage de la combobox pour les types de transaction

            foreach (DataRow row in ds.Tables["_TypeTransaction"].Rows)
                cboType.Items.Add(row["libType"]);
        }

        /* Bouton valider, vérification des valeurs avant l'ajout*/
        private void AjouterUneTransaction(object sender, EventArgs e)
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

            if (toutEstOk) {
                if (txtMontant.Text[txtMontant.Text.Length - 1] == ',')
                    txtMontant.Text.Substring(0, txtMontant.Text.Length - 1);
                short nbPersonne = 0;
                foreach (CheckBox chk in Controls.OfType<CheckBox>())
                    if (chk.Checked)
                        nbPersonne++;
                MessageBox.Show("Ajout de la transaction :\n • " + txtDescTran + "\n • " + txtMontant
                    + " €\nElle conserne " + nbPersonne + " personne" + (nbPersonne > 1 ? "s." : "."));
                if (DialogResult.OK == MessageBox.Show("Voulez-vous ajouter cette transaction ?", "Ajout", MessageBoxButtons.OKCancel))
                    MessageBox.Show("Transaction ajoutée !");
                else
                    MessageBox.Show("Aucune modification n'a été effectuée !");
            }
        }

        /* Ferme ce formulaire */
        private void QuitterAjoutTransac(object sender, EventArgs e)
        {
            Close();
        }

        /* Change le texte de chkRecette en fonction de son état checked ou non */
        private void CliquerSurChkRecette(object sender, EventArgs e)
        {
            CheckBox _sender = (CheckBox)sender;
            if (_sender.Checked) {
                _sender.Text = "Dépense";
                chkPerçu.Checked = true;
                chkPerçu.Enabled = false;
            }
            else {
                _sender.Text = "Recette";
                chkPerçu.Checked = false;
                chkPerçu.Enabled = true;
            }

        }

        /* Contrôle de saisie pour le montant */
        private void SaisirUnMontant(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else if (e.KeyChar == ',' && !txtMontant.Text.Contains(","))
                    e.Handled = false;
            else if (e.KeyChar == '.' && !txtMontant.Text.Contains(","))
            {
                e.KeyChar = ',';
                e.Handled = false;
            }
        }
    }
}
