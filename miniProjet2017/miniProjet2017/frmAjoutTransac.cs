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
    public partial class frmAjoutTransac : Form
    {
        // TODO: s'il n'y a pas de typeTransaction, on ne peut pas ajouter !
        public frmAjoutTransac()
        {
            InitializeComponent();
            DemarrageDeAjoutTransac();
            Scale(new SizeF(frmMain.resolutionScale, frmMain.resolutionScale));
            frmMain.RedimensionnerLesControls(this, frmMain.resolutionScale);
            picQuitter.Parent = picBordure;
        }

        /* Affiche toutes les personne de la table Personne et rempli la combobox pour les type de transaction */
        private void DemarrageDeAjoutTransac()
        {
                // Initialisation des valeurs static

            flecheRetour = picQuitter.Image;
            c = Color.FromArgb(56, 69, 80);

                // Initialisation des variables de connection

            CMD cmd;
            OleDbDataAdapter da;
            DataSet ds = new DataSet();
            frmMain.con.Open();

                // Ajout des tables locales

            cmd = new CMD("SELECT * FROM Personne", frmMain.con);
            da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "_Personne");

            cmd = new CMD("SELECT * FROM TypeTransaction", frmMain.con);
            da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "_TypeTransaction");

                // Initialisaton de la liste des participants

            listeParticipant = new List<uint>(ds.Tables["_Personne"].Rows.Count);

                // Remplissage de la combobox pour les types de transaction

            foreach (DataRow row in ds.Tables["_TypeTransaction"].Rows)
                cboType.Items.Add(row["libType"]);

            frmMain.con.Close();
        }

        // TODO: Check comment ajouter l'heure dans la table Transaction, ajout du TRY CATCH, ajout dans d'autre table (Beneficiaire ?)
        /* Bouton valider, vérification des valeurs avant l'ajout */
        private void AjouterUneTransaction(object sender, EventArgs e)
        {
                // Sera 'false' si au moins une erreur se produit

            bool toutEstOk = true;

                // Position des erreurs

            errorProvider.SetIconPadding(cboType, 11);
            errorProvider.SetIconPadding(txtDescTran, 11);
            errorProvider.SetIconPadding(txtMontant, 19);
            errorProvider.SetIconPadding(btnChoixPersonne, 11);

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

            if (listeParticipant.Count == 0)
            {
                errorProvider.SetError(btnChoixPersonne, "Il faut au moins une personne en relation avec cette transaction !");
                toutEstOk = false;
            }
            else errorProvider.SetError(btnChoixPersonne, "");

                // Si aucune erreur est présente, on peut ajouter la transaction

            if (toutEstOk)
            {
                if (txtMontant.Text[txtMontant.Text.Length - 1] == ',')
                    txtMontant.Text.Substring(0, txtMontant.Text.Length - 1);
                if (DialogResult.OK == MessageBox.Show("Ajout de la transaction :\n\n • " + txtDescTran.Text
                    + "\n\n • " + FormatDuMontant(txtMontant.Text)
                    + " €\n\n • Type : " + cboType.SelectedItem
                    + "\n\n • Elle concerne " + listeParticipant.Count + " personne" + (listeParticipant.Count > 1 ? "s." : ".")
                    + "\n\n     Voulez-vous ajouter cette transaction ?", "Ajout d'une transaction", MessageBoxButtons.OKCancel))
                {
                        // Remplir la table locale

                    frmMain.con.Open();

                        // Table Transaction

                    object idCetteTransaction = new CMD(@"SELECT IIF(max(codeTransaction) IS NULL, 1, max(codeTransaction) + 1) FROM [Transaction]", frmMain.con).ExecuteScalar();
                    new CMD(@"INSERT INTO [Transaction] VALUES (" + idCetteTransaction + ", "
                                                            + "#" + (calTransac.SelectionStart.Day > 9
                                                            ? calTransac.SelectionStart.Day.ToString()
                                                            : "0" + calTransac.SelectionStart.Day.ToString()) + '/' + (calTransac.SelectionStart.Month > 9
                                                            ? calTransac.SelectionStart.Month.ToString()
                                                            : "0" + calTransac.SelectionStart.Month.ToString()) + '/' + calTransac.SelectionStart.Year + "#, '"
                                                            + txtDescTran.Text + "', "
                                                            + txtMontant.Text.Replace(',', '.') + ", "
                                                            //+ (chkRecette.Checked ? "True" : "False") + ", "
                                                            + (chkRecette.Checked ? "False" : "True") + ", "
                                                            + (chkPerçu.Checked ? "True" : "False") + ", "
                                                            + (cboType.SelectedIndex + 1) + ")", frmMain.con).ExecuteNonQuery();

                        // Ajout des personnes dans table Beneficiaire

                    foreach (uint i in listeParticipant)
                        new CMD(@"INSERT INTO Beneficiaires VALUES (" + idCetteTransaction + ", " + i + ")", frmMain.con).ExecuteNonQuery();

                    MessageBox.Show("Transaction ajoutée !");
                    frmMain.con.Close();
                }
                else
                    MessageBox.Show("Aucune modification n'a été effectuée !");
            }
        }

        /* Affichage du prix formatté */
        public static string FormatDuMontant(string montant)
        {
            double d = Math.Round(Convert.ToDouble(montant), 2);
            return d.ToString().Contains(',') /* IndexOf(",") != 1*/ ?
                string.Format("{0:0,0}", Math.Floor(d)) + "," + d.ToString().Remove(0, d.ToString().IndexOf(",") + 1) :
                string.Format("{0:0,0}", d);
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
                _sender.ForeColor = Color.Gray;
                lblRecette.ForeColor = Color.White;
                chkPerçu.ForeColor = Color.Gray;
                lblRecette.Text = "Dépense •";
                _sender.Text = "  Recette";
                chkPerçu.Checked = false;
                chkPerçu.AutoCheck = false;
            }
            else {
                _sender.ForeColor = Color.White;
                lblRecette.ForeColor = Color.Gray;
                chkPerçu.ForeColor = Color.White;
                lblRecette.Text = "Dépense";
                _sender.Text = "• Recette";
                chkPerçu.Checked = false;
                chkPerçu.AutoCheck = true;
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

        /* Ajout ou retire l'aide de ce formulaire */
        private void CliquerAideAjout(object sender, EventArgs e)
        {
            new Classes.Aide().AideTransac(this);
        }

        /* Ouvre le frmChoixPersonne pour ajouter les gens à la transaction que l'on veut ajouter */
        List<uint> listeParticipant;
        private void AjouterPersonneATransaction(object sender, EventArgs e)
        {
            frmChoisirPersonne frm = new frmChoisirPersonne(listeParticipant);
            if (DialogResult.OK == frm.ShowDialog())
                lblChoixPersonne.Text = "Participant" + (frm.listeParticipant.Count > 1 ? "s : " : " : ") + (listeParticipant = frm.listeParticipant).Count.ToString();
        }

        static Color c;
        /* Change la couleur des boutons quand la souris est sur l'un d'entre eux */
        private void BoutonHover(object sender, EventArgs e)
        {
            (sender as Button).FlatAppearance.MouseOverBackColor = c;
        }

        static Image flecheRetour_clair = new Bitmap("..\\..\\Resources\\flecheRetour_clair.png");
        static Image flecheRetour;
        /* Souris sur picQuitter */
        private void SourisSurPicQuitter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = flecheRetour_clair;
        }

        /* Souris sors de picQuitter */
        private void SourisSortDePicQuitter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = flecheRetour;
        }
    }
}