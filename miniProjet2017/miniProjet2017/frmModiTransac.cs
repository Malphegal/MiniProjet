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

namespace miniProjet2017
{
    public partial class frmModiTransac : Form
    {
        Tuple<string, string, float, bool, bool, string, List<uint>, Tuple<string>> tuple;
        public frmModiTransac()
        {
            
            InitializeComponent();
            Scale(new SizeF(frmMain.resolutionScale, frmMain.resolutionScale));
            frmMain.RedimensionnerLesControls(this, frmMain.resolutionScale);
        }

        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        // TODO: Si il n'y a pas de transaction dans la table, MessageBox.Show ?
        /* Création de la table Transaction en local */
        private void LancementDuFormulaire(object sender, EventArgs e)
        {
                                    // Remplir la table locale

            frmMain.con.Open();
            da = new OleDbDataAdapter(new CMD("SELECT * FROM [Transaction]", frmMain.con));
            da.Fill(ds, "_Transaction");
            da = new OleDbDataAdapter(new CMD("SELECT * FROM [Personne]", frmMain.con));
            da.Fill(ds, "_Personne");
            frmMain.con.Close();

                // Affichage de la première transaction, si il y en a une

            if (ds.Tables["_Transaction"].Rows.Count > 0)
            {
                    // Remplissage de la CBO
                    
                foreach (DataRow row in ds.Tables["_Transaction"].Rows)
                    cboListeTransaction.Items.Add(row[2] + " " + row[1]);
                cboListeTransaction.SelectedIndex = 0; // modifierLeTuple se lance implicitement
            }
            else {
                MessageBox.Show("Il n'y a pas de transaction dans la base de donnée !");
                Close();
            }
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
                CliquerSurChkRecette(chkRecette, new EventArgs());
            }
            else
                chkPerçu.Checked = Convert.ToBoolean(ds.Tables["_Transaction"].Rows[cboListeTransaction.SelectedIndex][5]);

            da = new OleDbDataAdapter(new CMD("SELECT * FROM TypeTransaction", frmMain.con));
            da.Fill(ds, "_TypeTransaction");

            foreach (var row in ds.Tables["_TypeTransaction"].Rows.Cast<DataRow>().Select((row, i) => new { Row = row, Index = i }))
            {
                cboType.Items.Add(row.Row["libType"]);
                if (Convert.ToInt32(row.Row[0]) == Convert.ToInt32(ds.Tables["_Transaction"].Rows[cboListeTransaction.SelectedIndex][6]))
                    cboType.SelectedIndex = row.Index;
            }

                // Recharger listeParticipant de la transaction courante

            listeParticipant = new List<uint>(ds.Tables["_Personne"].Rows.Count);

            if (ds.Tables.Contains("_Beneficiaires"))
                ds.Tables["_Beneficiaires"].Clear();
            da = new OleDbDataAdapter(new CMD("SELECT * FROM Beneficiaires WHERE codeTransaction = " + (cboListeTransaction.SelectedIndex + 1), frmMain.con));
            da.Fill(ds, "_Beneficiaires");
            
            foreach (DataRow row in ds.Tables["_Beneficiaires"].Rows)
                listeParticipant.Add(Convert.ToUInt32(row[1]));

                // Tuple pour savoir si quelque chose à changé ou non
                
            tuple = new Tuple<string, string, float, bool, bool, string, List<uint>, Tuple<string>>
                (calTransac.SelectionStart.ToString(), txtDescTran.Text, float.Parse(txtMontant.Text),
                chkRecette.Checked, chkPerçu.Checked, cboType.SelectedItem.ToString(), new List<uint>(listeParticipant),
                Tuple.Create(calTransac.SelectionStart.ToString()));

            lblChoixPersonne.Text = "participant" + (listeParticipant.Count > 1 ? "s : " : " : ") + (listeParticipant.Count);
        }

        // TODO: Check comment ajouter l'heure dans la table Transaction, ajout du TRY CATCH, ajout dans d'autre table (Beneficiaire ?)
        // TODO: valeur qui ont changé : METTRE A JOUR -> CHECK
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
                bool memeListeQueAvant = true;
                if (listeParticipant.Count != tuple.Item7.Count)
                    memeListeQueAvant = false;
                else
                    for (int i = 0; i < tuple.Item7.Count; i++)
                        if (listeParticipant[i] != tuple.Item7[i])
                        {
                            memeListeQueAvant = false;
                            break;
                        }
                if (DialogResult.OK == MessageBox.Show("Modification de la transaction :"
                    + "\n" + (calTransac.SelectionStart.ToString() != tuple.Rest.Item1 ? "\n  - A changé : " + tuple.Rest.Item1 : "")
                    + "\n • " + calTransac.SelectionStart.ToString()
                    + "\n" + (txtDescTran.Text != tuple.Item2 ? "\n  - A changé : " + tuple.Item2 : "")
                    + "\n • " + txtDescTran.Text
                    + "\n" + (float.Parse(txtMontant.Text) != tuple.Item3 ? "\n - A changé : " + tuple.Item3 : "")
                    + "\n • " + frmAjoutTransac.FormatDuMontant(txtMontant.Text)
                    + " €\n" + (cboType.SelectedItem.ToString() != tuple.Item6 ? "\n - A changé : " + tuple.Item6 : "")
                    + "\n • Type : " + cboType.SelectedItem
                    + "\n" + (!memeListeQueAvant ? "\n - A changé - " : "")
                    + "\n • Elle concerne " + listeParticipant.Count + " personne" + (listeParticipant.Count > 1 ? "s." : ".")
                    + "\n\n     Voulez-vous valider cette modification ?", "Ajout d'une transaction", MessageBoxButtons.OKCancel))
                {
                    frmMain.con.Open();

                        // Reset la table Beneficiaires

                    if (ds.Tables["_Beneficiaires"].Rows.Count > 0)
                        new CMD(@"DELETE FROM Beneficiaires WHERE codeTransaction = " + ds.Tables["_Beneficiaires"].Rows[0][0], frmMain.con).ExecuteNonQuery();

                        // Update la transaction

                    new CMD(@"UPDATE [Transaction] set codeTransaction = codeTransaction, dateTransaction = "
                                                            + "#" + (calTransac.SelectionStart.Day > 9
                                                            ? calTransac.SelectionStart.Day.ToString()
                                                            : "0" + calTransac.SelectionStart.Day.ToString()) + '/' + (calTransac.SelectionStart.Month > 9
                                                            ? calTransac.SelectionStart.Month.ToString()
                                                            : "0" + calTransac.SelectionStart.Month.ToString()) + '/' + calTransac.SelectionStart.Year + "#, "
                                                            + "description = '" + txtDescTran.Text + "', "
                                                            + "montant = " + txtMontant.Text.Replace(',', '.') + ", "
                                                            + "recetteON = " +(chkRecette.Checked ? "True" : "False") + ", "
                                                            + "percuON = " + (chkPerçu.Checked ? "True" : "False") + ", "
                                                            + "type = " + (cboType.SelectedIndex + 1)
                                                            + " WHERE codeTransaction = " + (cboListeTransaction.SelectedIndex + 1), frmMain.con).ExecuteNonQuery();

                        // Ajout des personnes dans table Beneficiaire

                    foreach (uint i in listeParticipant)
                        new CMD(@"INSERT INTO Beneficiaires VALUES (" + ds.Tables["_Beneficiaires"].Rows[cboListeTransaction.SelectedIndex][0]
                            + ", " + i + ")", frmMain.con).ExecuteNonQuery();

                    MessageBox.Show("Transaction modifiée !");
                    frmMain.con.Close();

                        // Refresh le tuple

                    ModifierLeTuple();
                }
                else
                    MessageBox.Show("Aucune modification n'a été effectuée !");
            }
        }

        /* Saisie de la description, ne doit pas dépasser 30 caractères */
        private void SaisieDescription(object sender, KeyPressEventArgs e)
        {
            if (txtDescTran.Text.Length == 30 && (e.KeyChar != 8 && txtDescTran.SelectedText.Length == 0))
            {
                e.Handled = true;
                errorProvider.SetIconPadding(txtDescTran, 11);
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
                chkPerçu.Checked = false;
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

        /* Modifier une autre transaction */
        private void ChangerIndexCboListeTransaction(object sender, EventArgs e)
        {
            ModifierLeTuple();            
        }

        /* Ouvre le frmChoixPersonne pour ajouter les gens à la transaction que l'on veut ajouter */
        List<uint> listeParticipant;
        private void AjouterPersonneATransaction(object sender, EventArgs e)
        {
            frmChoisirPersonne frm = new frmChoisirPersonne(listeParticipant);
            if (DialogResult.OK == frm.ShowDialog())
                lblChoixPersonne.Text = "Participant" + (frm.listeParticipant.Count > 1 ? "s : " : " : ") + (listeParticipant = frm.listeParticipant).Count.ToString();
        }

        private void picQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        /* Affiche ou retire l'aide du formulaire */
        private void btnAide_Click(object sender, EventArgs e)
        {
            new Classes.Aide().AideTransac(this);
        }
    }
}
