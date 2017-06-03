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
    public partial class frmAffichage : Form
    {
        public frmAffichage()
        {
            InitializeComponent();
            Scale(new SizeF(frmMain.resolutionScale, frmMain.resolutionScale));
            frmMain.RedimensionnerLesControls(this, frmMain.resolutionScale);
        }

        /* Remplir le contenu de la DataGridView */
        private void DebutDuFormulaire(object sender, EventArgs e)
        {
                // Création de la table en local

            CON con = new CON("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\..\\BaseDeDonnee\\budget1.mdb");
            DataSet ds = new DataSet();
            new OleDbDataAdapter(new CMD(@"SELECT t.*, t2.libType
                                            FROM [Transaction] t, TypeTransaction t2
                                            WHERE t2.codeType = t.type", con)).Fill(ds, "_Transaction");

                // Ajout du contenu du DataGridView

            dataGridView1.DataSource = ds.Tables["_Transaction"];
            dataGridView1.Columns[1].Width += 60;
            dataGridView1.Columns[2].Width += 20;
            dataGridView1.Columns[3].Width -= 45;
            dataGridView1.Columns[4].Width -= 40;
            dataGridView1.Columns[5].Width -= 45;
            dataGridView1.Columns[6].Width -= 65;
        }

        /* Ferme ce formulaire */
        private void QuitterFrmAffichage(object sender, EventArgs e)
        {
            Close();
        }

        /* Effectuer un clique droit sur une des cellules du dataGridView */
        private void CliqueDroitSurUneCaseDuDataGridView(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(Cursor.Position);
        }

        /* Ouvre le formulaire pour modifier une transaction */
        private void ContextStripModifier(object sender, EventArgs e)
        {
            new frmModiTransac().ShowDialog();
        }

        /* Ouvre le formulaire pour supprimer une transaction */
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSupprTransac().ShowDialog();
        }
    }
}
