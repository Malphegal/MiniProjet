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
    public partial class frmSupprTransac : Form
    {
        DataSet ds;

        public frmSupprTransac()
        {
            InitializeComponent();
            Scale(new SizeF(frmMain.resolutionScale, frmMain.resolutionScale));
            frmMain.RedimensionnerLesControls(this, frmMain.resolutionScale);
        }

        /* Initialise les valeurs de départ */
        private void ChargementDeFrmSupprimerTransaction(object sender, EventArgs e)
        {
            lblTitre.Font = new Font(frmMain.fonts.Families[0], lblTitre.Font.Size);
            picQuitter.Parent = picBordure;

                // Création de la table locale

            ds = new DataSet();
            new OleDbDataAdapter(new CMD(@"SELECT t.codeTransaction, t.dateTransaction, t.description, t.montant,
                    t.recetteON, t.percuON, tt.libType FROM [Transaction] t, TypeTransaction tt
                                            WHERE t.type = tt.codeType", frmMain.con)).Fill(ds, "_Transaction");

            if (ds.Tables["_Transaction"].Rows.Count != 0)
            {
                    // Ajout des transaction dans une comboBox

                foreach (DataRow row in ds.Tables["_Transaction"].Rows)
                    cboTransactions.Items.Add(row[1].ToString().Substring(0, 10) + " • " + row[2]);
                cboTransactions.SelectedIndex = 0;
            }
            else {
                MessageBox.Show("Il n'y a pas de transaction dans la base de donnée !");
                Close();
            }
        }

        /* Change de transaction */
        private void cboTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["_Transaction"].Rows[cboTransactions.SelectedIndex];
            _lblId.Text = row[0].ToString();
            _lblDate.Text = row[1].ToString();
            _lblDescription.Text = row[2].ToString();
            _lblMontant.Text = row[3].ToString() + " €";
            _lblRecette.Text = Convert.ToBoolean(row[4])
                ? "Dépense" : Convert.ToBoolean(row[5]) ? "Recette : Déjà perçue"
                : "Recette";
            _lblType.Text = row[6].ToString();
        }

        /* Ferme ce formulaire */
        private void QuitterFrmSupprTransac(object sender, EventArgs e)
        {
            Close();
        }

        /* MessageBox pour la confirmation de la suppression de la transaction */
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Êtes vous certain de vouloir supprimer cette transaction ?\nCette action sera définitive !",
                "Confirmation de suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                    // Supprimer de la base de donnée

                frmMain.con.Open();
                new CMD(@"DELETE FROM Beneficiaires WHERE codeTransaction = " + _lblId.Text, frmMain.con).ExecuteScalar();
                new CMD(@"DELETE FROM [Transaction] WHERE codeTransaction = " + _lblId.Text, frmMain.con).ExecuteScalar();
                frmMain.con.Close();

                    // Vider la comboBox

                ds.Tables["_Transaction"].Rows.RemoveAt(cboTransactions.SelectedIndex);
                cboTransactions.Items.RemoveAt(cboTransactions.SelectedIndex);

                MessageBox.Show("Transaction supprimée !", "suppression réussi  !");

                if (cboTransactions.Items.Count != 0)
                    cboTransactions.SelectedIndex = 0;
                else
                {
                    MessageBox.Show("Il n'y a plus de transaction dans la base de donnée !", "Retour au menu principal");
                    Close();
                }
            }
        }
    }
}
