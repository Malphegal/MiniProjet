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
    public partial class frmPosteRevenu : Form
    {
        public frmPosteRevenu()
        {
            InitializeComponent();
        }

        /* Ferme le formulaire frmPosteRevenu */
        private void QuitterFrmPosteRevenu(object sender, EventArgs e)
        {
            Close();
        }

        /* Ajouter le poste de revenu dans la base de donnée */
        private void AjouterLePosteRevenu(object sender, EventArgs e)
        {
                // Sera faux s'il y a une erreur

            bool toutEstOK = true;

                // Tester au cas par cas



                // Si tout est ok, alors ajouter dans la base de donnée

            if (toutEstOK)
            {
                if (DialogResult.OK == MessageBox.Show("Test", "TESTT", MessageBoxButtons.OKCancel))
                {
                        // Insertion dans les bases de données

                    frmMain.con.Open();

                    int idMax = Convert.ToInt32(new CMD(@"SELECT IIF(max(codePoste) IS NULL, 1, max(codePoste) + 1)
                                                          FROM Poste", frmMain.con).ExecuteScalar());

                    new CMD(@"INSERT INTO Poste VALUES ("
                              + idMax + ", '"
                              + txtDescri.Text + "')", frmMain.con).ExecuteNonQuery();

                    new CMD(@"INSERT INTO PosteRevenu VALUES ("
                              + idMax + ", "
                              + txtMontant.Text + ", "
                              + cboPersonne.ValueMember + ", "
                              + txtJourMois.Text + ")", frmMain.con).ExecuteNonQuery();

                    MessageBox.Show("Ce poste de revenu a été ajouté !");

                    frmMain.con.Close();
                }
                else
                    MessageBox.Show("Aucune modification n'a été effectuée !");
            }
            else
                MessageBox.Show("Aucune modification n'a été effectuée !");
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

        /* Remplir la combobox des personnes */
        private void ChargementDeFrmPosteRevenu(object sender, EventArgs e)
        {
                // Création des tables en locale

            DataSet ds = new DataSet();
            new OleDbDataAdapter(new CMD(@"SELECT codePersonne, (nomPersonne + ' ' + pnPersonne) as NomPrenom FROM Personne", frmMain.con)).Fill(ds, "_Personne");

                // Remplir la comboBox

            cboPersonne.DataSource = ds.Tables["_Personne"];
            cboPersonne.ValueMember = "codePersonne";
            cboPersonne.DisplayMember = "NomPrenom";
        }
    }
}
