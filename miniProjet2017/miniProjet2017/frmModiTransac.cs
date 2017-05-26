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
                txtMontant.Text = ds.Tables["_Transaction"].Rows[0][3].ToString();
                txtDescTran.Text = ds.Tables["_Transaction"].Rows[0][2].ToString();
                chkRecette.Checked = Convert.ToBoolean(ds.Tables["_Transaction"].Rows[0][4]);
                chkPerçu.Checked = Convert.ToBoolean(ds.Tables["_Transaction"].Rows[0][5]);
            }

                // TODO: Si il n'y a pas de transaction dans la table, MBS ?
        }
    }
}
