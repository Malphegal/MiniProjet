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
        }

        /* Affiche ou retire l'aide du formulaire */
        private void CliquerSurAideModif(object sender, EventArgs e)
        {
            new Classes.Aide().AideTransac(this);
        }

        /* Création de la table Transaction en local */
        private void LancementDuFormulaire(object sender, EventArgs e)
        {
                // Remplir la table locale

            CON con = new CON("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget1.mdb");
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(new CMD("SELECT * FROM [Transaction]", con));
            DataSet ds = new DataSet();
            da.Fill(ds, "_Transaction");

                // Affichage de la première transaction, si il y en a une
            
            if (ds.Tables["_Transaction"].Rows.Count > 0)
            {
                string[] date = ds.Tables["_Transaction"].Rows[0][1].ToString().Split('/');
                calTransac.SelectionStart = new DateTime(int.Parse(date[2].Substring(0, 4)), int.Parse(date[1]), int.Parse(date[0]));

                txtDescTran.Text = ds.Tables["_Transaction"].Rows[0][2].ToString();
                txtMontant.Text = ds.Tables["_Transaction"].Rows[0][3].ToString();
                chkRecette.Checked = Convert.ToBoolean(ds.Tables["_Transaction"].Rows[0][4]);
                chkPerçu.Checked = Convert.ToBoolean(ds.Tables["_Transaction"].Rows[0][5]);

                da = new OleDbDataAdapter(new CMD("SELECT * FROM TypeTransaction", con));
                da.Fill(ds, "_TypeTransaction");

                foreach (var row in ds.Tables["_TypeTransaction"].Rows.Cast<DataRow>().Select((row, i) => new { Row = row, Index = i }))
                {
                    cboType.Items.Add(row.Row["libType"]);
                    if (Convert.ToInt32(row.Row[0]) == Convert.ToInt32(ds.Tables["_Transaction"].Rows[0][6]))
                        cboType.SelectedIndex = row.Index;
                }
            }

            // TODO: Si il n'y a pas de transaction dans la table, MessageBox.Show ?
        }
    }
}
