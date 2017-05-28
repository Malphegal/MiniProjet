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
    public partial class frmRecap : Form
    {
        BindingSource bs = new BindingSource();

        public frmRecap()
        {
            InitializeComponent();
        }

        // TODO: on ne doit pas pouvoir cliquer plusieurs fois
        /* Lance la liaison de donnée vers les transactions */
        private void CliquerSurLiaisonTransaction(object sender, EventArgs e)
        {
            CON con = new CON("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget1.mdb");
            DataSet ds = new DataSet();
            new OleDbDataAdapter(new CMD(@"SELECT * FROM [Transaction]", con)).Fill(ds, "_Transaction");
            bs.DataSource = ds.Tables["_Transaction"];

                // Liaison de donnée

            lblId.DataBindings.Add("Text", bs, "codeTransaction");
            lblDate.DataBindings.Add("Text", bs, "dateTransaction");
            lblDescription.DataBindings.Add("Text", bs, "description");
            lblMontant.DataBindings.Add("Text", bs, "montant");
            chkRecette.DataBindings.Add("Checked", bs, "recetteON");
            chkPercu.DataBindings.Add("Checked", bs, "percuON");
            lblType.DataBindings.Add("Text", bs, "type");

            //lbl.text = "Enregistrement " + (bs.Position + 1) + " sur " + bs.Count.ToString();

                // Activation des boutons de navigation

            btnLL.Enabled = true;
            btnL.Enabled = true;
            btnR.Enabled = true;
            btnRR.Enabled = true;
        }

        // ----------------------------------
        // ---Déplacement du BindingSource---
        // ----------------------------------

        private void CliquerSurPremier(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void CliquerSurPrecedent(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void CliquerSurSuivant(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void CliquerSurDernier(object sender, EventArgs e)
        {
            bs.MoveLast();
        }
    }
}
