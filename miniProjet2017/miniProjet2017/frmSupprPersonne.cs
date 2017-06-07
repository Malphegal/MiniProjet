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
    public partial class frmSupprPersonne : Form
    {
        public frmSupprPersonne()
        {
            InitializeComponent();
        }

        /* Ferme le formulaire frmSupprPersonne */
        private void QuitterLeFrmSupprPersonne(object sender, EventArgs e)
        {
            Close();
        }

        /* Charge toutes les personnes de la base de donnée dans le panel central */
        private void ChangementDuFormulaire(object sender, EventArgs e)
        {
                // Création de la table en locale

            DataSet ds = new DataSet();
            new OleDbDataAdapter(new CMD(@"SELECT * FROM Personne", frmMain.con)).Fill(ds, "_Personne");

                // Vérification du nombre de personne dans la table, savoir si on quitte ou non

            if (ds.Tables["_Personne"].Rows.Count != 0)
            {
                for (int i = 0; i < ds.Tables["_Personne"].Rows.Count; i++)
                    new CheckBox()
                    {
                        Parent = pnlPersonne,
                        Left = 40,
                        Top = i * 25 + 20,
                        Text = " • " + ds.Tables["_Personne"].Rows[i][1].ToString()
                            + " " + ds.Tables["_Personne"].Rows[i][2].ToString(),
                        Font = new Font(FontFamily.GenericSansSerif, 14F),
                        AutoSize = true,
                        Tag = ds.Tables["_Personne"].Rows[i][0]
                    };
            }
            else
            {
                MessageBox.Show("Il n'y a pas de personne dans la base de donnée !\nFermeture du formulaire.");
                Close();
            }
        }

        private void SupprimerLesPersonnes(object sender, EventArgs e)
        {
                // Obtenir la liste des personnes qui sont cochées

            List<int> idDesPersonnesASuppr = new List<int>();
            foreach (CheckBox chk in pnlPersonne.Controls.OfType<CheckBox>())
                if (chk.Checked)
                    idDesPersonnesASuppr.Add(Convert.ToInt32(chk.Tag));

                // Si au moins une personne est cochée, on peut demander si l'utilisateur souhaite vraiment supprimer

            if (idDesPersonnesASuppr.Count != 0 && DialogResult.OK == MessageBox.Show("Souhaitez vous vraiment supprimez ", "Suppression d", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                    // On supprime toutes les références de cette personne dans les autres tables

                // id des transaction qui possède une personne
                List<int> idDesTransaction = new List<int>();

                frmMain.con.Open();
                foreach (int i in idDesPersonnesASuppr)
                {
                    idDesTransaction.Add(Convert.ToInt32(new CMD(@"SELECT codeTransaction FROM Beneficiaires
                                                                   WHERE codePersonne = " + i, frmMain.con).ExecuteScalar()));

                    new CMD(@"DELETE FROM Beneficiaires
                              WHERE codePersonne = " + i, frmMain.con).ExecuteNonQuery();

                        // On supprime la personne

                    new CMD(@"DELETE FROM Personne
                              WHERE codePersonne = " + i, frmMain.con).ExecuteNonQuery();
                }
                    // On vérifie si la transaction possède encore des personnes ou non !

                foreach (int i in idDesTransaction)
                    if (Convert.ToInt32(new CMD("SELECT count(*) FROM Beneficiaire WHERE codeTransaction = " + i, frmMain.con).ExecuteScalar()) == 0)
                        new CMD(@"DE", frmMain.con).ExecuteNonQuery();

                    // On ferme con et le formulaire

                foreach (int i in idDesTransaction)
                    MessageBox.Show(i.ToString());
                frmMain.con.Close();
                MessageBox.Show("Personne supprimée !");
                Close();
            }
            else
                MessageBox.Show("Aucune modification n'a été effectuée !");
        }
    }
}
