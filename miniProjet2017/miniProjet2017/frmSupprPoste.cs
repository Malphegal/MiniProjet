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
    public partial class frmSupprPoste : Form
    {
        DataSet ds = new DataSet();

        public frmSupprPoste()
        {
            InitializeComponent();
        }

        /* Ferme le frmBudgetRecap */

        private void QuitterFrmBudgetRecap(object sender, EventArgs e)
        {            
            Close();           
               
        }

        /* Ferme le frmBudgetRecap */
        private void frmSupprPoste_Load(object sender, EventArgs e)
        {
            flecheRetour = picQuitter.Image;
            new OleDbDataAdapter(new CMD(@"SELECT pp.*, p.libPoste FROM PostePeriodique pp, Poste p
                    WHERE pp.codePoste = p.codePoste", frmMain.con)).Fill(ds, "_PostePeriodique");
            new OleDbDataAdapter(new CMD(@"SELECT pp.*, p.libPoste FROM PostePonctuel pp, Poste p
                    WHERE pp.codePoste = p.codePoste", frmMain.con)).Fill(ds, "_PostePonctuel");
            new OleDbDataAdapter(new CMD(@"SELECT pr.*, p.libPoste FROM PosteRevenu pr, Poste p
                    WHERE pr.codePoste = p.codePoste", frmMain.con)).Fill(ds, "_PosteRevenu");
        }

        private void cboListeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboListeType.SelectedIndex == 0)
            {
                cboListeBudget.Items.Clear();
                cboListeBudget.ResetText();
                foreach (DataRow row in ds.Tables["_PostePeriodique"].Rows)
                    cboListeBudget.Items.Add(row[4]);
            }
            else if (cboListeType.SelectedIndex == 1)
            {
                cboListeBudget.Items.Clear();
                cboListeBudget.ResetText();
                foreach (DataRow row in ds.Tables["_PostePonctuel"].Rows)
                    cboListeBudget.Items.Add(row[2]);
            }
            else if (cboListeType.SelectedIndex == 2)
            {
                cboListeBudget.Items.Clear();
                cboListeBudget.ResetText();
                foreach (DataRow row in ds.Tables["_PosteRevenu"].Rows)
                    cboListeBudget.Items.Add(row[4]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Sera faux s'il y a une erreur

            bool toutEstOk = true;

                // Test au cas par cas
             if (cboListeType.SelectedIndex == -1)
            {
                errorProvider.SetError(cboListeType, "Il faut séléctionner un type pour cette transaction !");
                toutEstOk = false;
            }
            else errorProvider.SetError(cboListeType, "");

            if (cboListeBudget.SelectedIndex == -1)
            {
                errorProvider.SetError(cboListeBudget, "Il faut séléctionner un budget !");
                toutEstOk = false;
            }
            else errorProvider.SetError(cboListeBudget, "");
            

            if (toutEstOk)
            {
                // Suppr des poste

                if (DialogResult.OK == MessageBox.Show("Test", "Test", MessageBoxButtons.OKCancel))
                {
                        // Suppression des postes au cas par cas

                    frmMain.con.Open();

                    int id = -1;

                    if (cboListeType.SelectedIndex == 0)
                    {
                        id = Convert.ToInt32(ds.Tables["_PostePeriodique"].Rows[cboListeBudget.SelectedIndex][0]);
                        new CMD(@"DELETE FROM PostePeriodique WHERE codePoste = "
                            + ds.Tables["_PostePeriodique"].Rows[cboListeBudget.SelectedIndex][0], frmMain.con).ExecuteScalar();
                    }
                    else if (cboListeType.SelectedIndex == 1)
                    {
                        id = Convert.ToInt32(ds.Tables["_PostePonctuel"].Rows[cboListeBudget.SelectedIndex][0]);
                        new CMD(@"DELETE FROM Echeances WHERE codePoste = "
                            + ds.Tables["_PostePonctuel"].Rows[cboListeBudget.SelectedIndex][0], frmMain.con).ExecuteScalar();
                        new CMD(@"DELETE FROM PostePonctuel WHERE codePoste = "
                            + ds.Tables["_PostePonctuel"].Rows[cboListeBudget.SelectedIndex][0], frmMain.con).ExecuteScalar();
                    }
                    else if (cboListeType.SelectedIndex == 2)
                    {
                        id = Convert.ToInt32(ds.Tables["_PosteRevenu"].Rows[cboListeBudget.SelectedIndex][0]);
                        new CMD(@"DELETE FROM PosteRevenu WHERE codePoste = "
                            + ds.Tables["_PosteRevenu"].Rows[cboListeBudget.SelectedIndex][0], frmMain.con).ExecuteScalar();
                    }
                        // Puis supprimer dans le Poste

                    new CMD(@"DELETE FROM Poste WHERE codePoste = " + id, frmMain.con).ExecuteNonQuery();

                    frmMain.con.Close();

                    MessageBox.Show("Le poste a été supprimé !");

                    frmSupprPoste_Load(sender, e);
                }
            }
            else
                MessageBox.Show("Aucune modification n'a été effectuée !");
        }

        private void picBordure_Click(object sender, EventArgs e)
        {
            Close();
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
