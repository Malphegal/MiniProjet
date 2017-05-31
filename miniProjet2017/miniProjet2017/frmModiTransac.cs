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
using CMD = System.Data.OleDb.OleDbCommand;
using CON = System.Data.OleDb.OleDbConnection;

namespace miniProjet2017
{
    public partial class frmModiTransac : Form
    {
        public frmModiTransac()
        {
            InitializeComponent();
            Scale(new SizeF(frmMain.resolutionScale, frmMain.resolutionScale));
            frmMain.RedimensionnerLesControls(this, frmMain.resolutionScale);
        }

        CON con = new CON("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget1.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        /* Affiche ou retire l'aide du formulaire */
        private void CliquerSurAideModif(object sender, EventArgs e)
        {
            new Classes.Aide().AideTransac(this);
        }

        // TODO: Si il n'y a pas de transaction dans la table, MessageBox.Show ?
        /* Création de la table Transaction en local */
        private void LancementDuFormulaire(object sender, EventArgs e)
        {
                // Remplir la table locale

            con.Open();
            da = new OleDbDataAdapter(new CMD("SELECT * FROM [Transaction]", con));
            da.Fill(ds, "_Transaction");
            da = new OleDbDataAdapter(new CMD("SELECT * FROM [Personne]", con));
            da.Fill(ds, "_Personne");

                // Affichage de la première transaction, si il y en a une

            if (ds.Tables["_Transaction"].Rows.Count > 0)
            {
                    // Activation des composants

                foreach (Control c in Controls)
                    if (c.Controls.Count > 0)
                        foreach (Control _c in c.Controls)
                            _c.Enabled = true;
                    else
                        c.Enabled = true;

                    // Remplissage de la CBO

                foreach (DataRow row in ds.Tables["_Transaction"].Rows)
                    cboListeTransaction.Items.Add(row[2] + " " + row[1]);
                cboListeTransaction.SelectedIndex = 0;

                ModifierLeTuple();
            }
            else
                MessageBox.Show("Il n'y a pas de transaction dans la base de donnée !");
        }

        /* Relance toutes les modification pour remplir les composants */
        private void ModifierLeTuple()
        {
                // Remplissage des composants

            string[] date = ds.Tables["_Transaction"].Rows[cboListeTransaction.SelectedIndex][1].ToString().Split('/');
            calTransac.SelectionStart = new DateTime(int.Parse(date[2].Substring(0, 4)), int.Parse(date[1]), int.Parse(date[0]));

            txtDescTran.Text = ds.Tables["_Transaction"].Rows[cboListeTransaction.SelectedIndex][2].ToString();
            txtMontant.Text = ds.Tables["_Transaction"].Rows[cboListeTransaction.SelectedIndex][3].ToString();

            if (Convert.ToBoolean(ds.Tables["_Transaction"].Rows[cboListeTransaction.SelectedIndex][4]))
            {
                chkRecette.Checked = true;
//CliquerSurChkRecette(chkRecette, e);
            }
            else
                chkPerçu.Checked = Convert.ToBoolean(ds.Tables["_Transaction"].Rows[cboListeTransaction.SelectedIndex][5]);

            da = new OleDbDataAdapter(new CMD("SELECT * FROM TypeTransaction", con));
            da.Fill(ds, "_TypeTransaction");

            foreach (var row in ds.Tables["_TypeTransaction"].Rows.Cast<DataRow>().Select((row, i) => new { Row = row, Index = i }))
            {
                cboType.Items.Add(row.Row["libType"]);
                if (Convert.ToInt32(row.Row[0]) == Convert.ToInt32(ds.Tables["_Transaction"].Rows[cboListeTransaction.SelectedIndex][6]))
                    cboType.SelectedIndex = row.Index;
            }

                // Recharger listeParticipant de la transaction courante

            listeParticipant = new List<uint>(ds.Tables["_Personne"].Rows.Count);

            da = new OleDbDataAdapter(new CMD("SELECT * FROM Beneficiaires WHERE codeTransaction = 0", con));
            da.Fill(ds, "_Beneficiaires");

            foreach (DataRow row in ds.Tables["_Beneficiaires"].Rows)
                listeParticipant.Add(Convert.ToUInt32(row[1]));
            // TODO: il manque qqch ??

            // Tuple pour savoir si quelque chose à changé ou non
            MessageBox.Show(txtMontant.Text.ToString());
            Tuple<string, string, float, bool, bool, string> tuple = new Tuple<string, string, float, bool, bool, string>
                (calTransac.SelectionStart.ToString(), txtDescTran.Text, float.Parse(txtMontant.Text.Replace(',', '.')),
                chkRecette.Checked, chkPerçu.Checked, cboType.SelectedText);
        }

        // TODO: Check comment ajouter l'heure dans la table Transaction, ajout du TRY CATCH, ajout dans d'autre table (Beneficiaire ?)
        // TODO: valeur qui ont changé, changé de couleur ?
        /* Bouton valider, vérification des valeurs avant la modification */
        private void ModifierLaTransaction(object sender, EventArgs e)
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

            if (txtMontant.Text == "" || double.Parse(txtMontant.Text) < 0.01D)
            {
                errorProvider.SetError(txtMontant, "Il faut indiquer un montant non nul (ou inférieur à 1 centime) pour cette transaction !");
                toutEstOk = false;
            }
            else errorProvider.SetError(txtMontant, "");

            if (txtDescTran.Text == "")
            {
                errorProvider.SetError(txtDescTran, "Il faut décrire cette transaction !");
                toutEstOk = false;
            }
            else errorProvider.SetError(txtDescTran, "");

            // Si aucune erreur est présente, on peut modifier la transaction

            if (toutEstOk)
            {
                    // Récapitulatif avant de valider la modification
                if (txtMontant.Text[txtMontant.Text.Length - 1] == ',')
                    txtMontant.Text.Substring(0, txtMontant.Text.Length - 1);
                short nbPersonne = 0;
                foreach (CheckBox chk in Controls.OfType<CheckBox>())
                    if (chk.Checked)
                        nbPersonne++;
                if (DialogResult.OK == MessageBox.Show("Modification de la transaction :\n\n • " + txtDescTran.Text
                    + "\n\n • " + frmAjoutTransac.FormatDuMontant(txtMontant.Text)
                    + " €\n\n • Type : " + cboType.SelectedItem
                    + "\n\n • Elle conserne " + nbPersonne + " personne" + (nbPersonne > 1 ? "s." : ".")
                    + "\n\n     Voulez-vous valider cette modification ?", "Ajout d'une transaction", MessageBoxButtons.OKCancel))
                {
                    CON con = new CON("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget1.mdb");
                    con.Open();
                    new CMD(@"UPDATE [Transaction] set dateTransaction = "
                                                            + "#" + (calTransac.SelectionStart.Day > 9
                                                            ? calTransac.SelectionStart.Day.ToString()
                                                            : "0" + calTransac.SelectionStart.Day.ToString()) + '/' + (calTransac.SelectionStart.Month > 9
                                                            ? calTransac.SelectionStart.Month.ToString()
                                                            : "0" + calTransac.SelectionStart.Month.ToString()) + '/' + calTransac.SelectionStart.Year + "#, "
                                                            + "description = '" + txtDescTran.Text + "', "
                                                            + "montant = " + frmAjoutTransac.FormatDuMontant(txtMontant.Text).Replace(',', '.') + ", "
                                                            + "recetteON = " +(chkRecette.Checked ? "True" : "False") + ", "
                                                            + "percuON = " + (chkPerçu.Checked ? "True" : "False") + ", "
                                                            + "type = " + (cboType.SelectedIndex + 1)
                                                            + " WHERE codeTransaction = ", con).ExecuteNonQuery();
                    MessageBox.Show("Transaction modifiée !");
                    con.Close();
                }
                else
                    MessageBox.Show("Aucune modification n'a été effectuée !");
            }
        }

        /* Saisie de la description, ne doit pas dépasser 30 caractères */
        private void SaisieDescription(object sender, KeyPressEventArgs e)
        {
            if (txtDescTran.Text.Length == 30)
            {
                e.Handled = true;
                errorProvider.SetError(txtDescTran, "La description ne doit pas dépasser 30 caractères !");
            }
            else
                errorProvider.SetError(txtDescTran, "");
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

        /* Change le texte de chkRecette en fonction de son état checked ou non */
        private void CliquerSurChkRecette(object sender, EventArgs e)
        {
            CheckBox _sender = (CheckBox)sender;
            if (_sender.Checked)
            {
                _sender.ForeColor = Color.Gray;
                lblRecette.ForeColor = Color.Black;
                chkPerçu.Checked = true;
                chkPerçu.Enabled = false;
            }
            else {
                _sender.ForeColor = Color.Black;
                lblRecette.ForeColor = Color.Gray;
                chkPerçu.Checked = false;
                chkPerçu.Enabled = true;
            }
        }

        /* Ferme ce formulaire */
        private void QuitterCeFormulaire(object sender, EventArgs e)
        {
            Close();
        }

        // TODO: a faire
        /* Modifier une autre transaction */
        private void ChangerIndexCboListeTransaction(object sender, EventArgs e)
        {

        }

        /* Ouvre le frmChoixPersonne pour ajouter les gens à la transaction que l'on veut ajouter */
        List<uint> listeParticipant;
        private void btnChoixPersonne_Click(object sender, EventArgs e)
        {
            frmChoisirPersonne frm = new frmChoisirPersonne(listeParticipant);
            if (DialogResult.OK == frm.ShowDialog())
                lblChoixPersonne.Text = "participant" + (frm.listeParticipant.Count > 1 ? "s :" : " :") + (listeParticipant = frm.listeParticipant).Count.ToString();
        }
    }
}
