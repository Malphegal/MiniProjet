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
    public partial class frmPostFixe : Form
    {
        public frmPostFixe()
        {
            InitializeComponent();
        }

        /* Remplir les comboBox */
        private void DemarrageDeFrmPostFixe(object sender, EventArgs e)
        {
                // Position de errorProvider

            errorProvider1.SetIconPadding(txtJour, 25);

                // On retire le text du label "/ 3"

            lblMois.Text = "";

                // Création de la base de donnée

            DataSet ds = new DataSet();
            new OleDbDataAdapter(@"SELECT * FROM Poste", frmMain.con).Fill(ds, "_Poste");
            new OleDbDataAdapter(@"SELECT * FROM Periodicite", frmMain.con).Fill(ds, "_Periodicite");

                // Remplissage de la cboPoste

            foreach (DataRow row in ds.Tables["_Poste"].Rows)
                cboPoste.Items.Add(row[1]);

            foreach (DataRow row in ds.Tables["_Periodicite"].Rows)
                cboPeriodicite.Items.Add(row[1]);

            if (ds.Tables["_Periodicite"].Rows.Count > 0)
                cboPeriodicite.SelectedIndex = 0;
            else
            {
                MessageBox.Show("Il n'y a pas de periodicité dans la base de donnée !\nFermuture du formulaire.");
                Close();
            }
            if (ds.Tables["_Poste"].Rows.Count > 0)
                cboPoste.SelectedIndex = 0;
            else
            {
                MessageBox.Show("Il n'y a pas de type de poste dans la base de donnée !\nFermuture du formulaire.");
                Close();
            }
        }

        /* Contrôle de la saisie du jour du mois */
        private void SaisirUnJourDuMois(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || (e.KeyChar == '0' && txtJour.Text.Length == 0))
                e.Handled = true;
            else
            {
                if (txtJour.Text.Length == 1)
                {
                    if (!new int[] { 1, 2, 3 }.Contains(int.Parse(txtJour.Text)))
                        e.Handled = true;
                    if (int.Parse(txtJour.Text) == 3 && !new char[] { '0', '1' }.Contains(e.KeyChar))
                        e.Handled = true;
                }
                if (txtJour.Text.Length == 2)
                    e.Handled = true;
            }
            if (e.KeyChar == 8)
                e.Handled = false;
        }
        private void SaisirUnJourDeLaSemaine(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' ||
                e.KeyChar == '6' || e.KeyChar == '7') || (txtJour.Text.Length == 1 && txtJour.SelectionLength != 1))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        /* Ajoute le poste fixe si tout est ok pour le faire */
        private void AjouterLePoste(object sender, EventArgs e)
        {
                // Sera false si quelque chose n'est pas correct

            bool toutEstOK = true;

                // Vérification au cas par cas

            if (cboPoste.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboPoste, "Il faut choisir un type de poste !");
                toutEstOK = false;
            }
            else errorProvider1.SetError(cboPoste, "");

            if (cboPeriodicite.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboPeriodicite, "Il faut choisir un type de periodicité !");
                toutEstOK = false;
            }
            else errorProvider1.SetError(cboPeriodicite, "");

            if (txtMontant.Text == "" || double.Parse(txtMontant.Text) < 0.01D)
            {
                errorProvider1.SetError(txtMontant, "Il faut indiquer un montant non nul (ou inférieur à 1 centime) pour ce poste !");
                toutEstOK = false;
            }
            else errorProvider1.SetError(txtMontant, "");

            if (txtJour.Text == "")
            {
                errorProvider1.SetError(txtJour, "Il faut indiquer un jour du mois/de la semaine pour ce poste !");
                toutEstOK = false;
            }
            else errorProvider1.SetError(txtMontant, "");

                // Si oui, alors ajouter le poste

            if (toutEstOK)
            {
                if (txtMontant.Text[txtMontant.Text.Length - 1] == ',')
                    txtMontant.Text.Substring(0, txtMontant.Text.Length - 1);
                if (DialogResult.OK == MessageBox.Show("Ajout du poste :\n\n • " + cboPoste.SelectedItem
                    + "\n\n • " + cboPeriodicite.SelectedItem
                    + " le " + txtJour.Text + "\n\n • Montant : " + txtMontant.Text
                    + "€\n\n     Voulez-vous ajouter ce poste ?", "Ajout d'un poste", MessageBoxButtons.OKCancel))
                {
                    frmMain.con.Open();

                        // Ajout dans la base de donnée

                    new CMD(@"INSERT INTO PostePeriodique VALUES ("
                        + (cboPoste.SelectedIndex + 1) + ", "
                        + txtMontant.Text.Replace(',', '.') + ", "
                        + (cboPeriodicite.SelectedIndex + 1) + ", '"
                        + txtJour.Text + "')", frmMain.con).ExecuteNonQuery();

                    frmMain.con.Close();

                    MessageBox.Show("Ce poste périodique à été ajouté !");
                }
                else
                    MessageBox.Show("Aucune modification n'a été effectuée !");
            }
        }

        /* Vérifier si on selectionne hebdomadaire ou non */
        static int ancienneValeurIndex = 0;
        private void ChangerIndexCboPeriodicite(object sender, EventArgs e)
        {
            if (cboPeriodicite.SelectedIndex == 0)
            {
                lblJour.Text = "Jour de la semaine :";
                lblMois.Text = "/ 7";
                txtJour.Text = "";
                txtJour.KeyPress -= new KeyPressEventHandler(SaisirUnJourDuMois);
                txtJour.KeyPress += new KeyPressEventHandler(SaisirUnJourDeLaSemaine);
            }
            else
            {
                lblJour.Text = "Jour du mois :";
                lblMois.Text = "";
                if (ancienneValeurIndex == 0)
                    txtJour.Text = "";
                ancienneValeurIndex = cboPeriodicite.SelectedIndex;
                txtJour.KeyPress += new KeyPressEventHandler(SaisirUnJourDuMois);
                txtJour.KeyPress -= new KeyPressEventHandler(SaisirUnJourDeLaSemaine);
            }
        }

        /* Ferme le frmPostFixe */
        private void QuitterFrmPostFixe(object sender, EventArgs e)
        {
            Close();
        }

        /* Saisir un montant */
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
