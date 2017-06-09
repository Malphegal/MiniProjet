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

namespace miniProjet2017
{
    public partial class frmBudgetRecap : Form
    {
        public frmBudgetRecap()
        {
            InitializeComponent();
        }

        /* Ferme le frmBudgetRecap */
        private void QuitterFrmBudgetRecap(object sender, EventArgs e)
        {
            Close();
        }
  
        public int dc;
        public DataGridView dgv;

        /* Remplir les premières DataGridView */
        private void ChargementDeFrmBudgetRecap(object sender, EventArgs e)
        {
                // Initialisation

            picQuitter.Parent = picBordure;
            flecheRetour = picQuitter.Image;
            // Création des tables locales

            OleDbCommand cmd = new OleDbCommand();

            cmd = new OleDbCommand();
            cmd.Connection = frmMain.con;

            frmMain.con.Open();
            string requ = @"select pp.codePoste as Code, po.libPoste as Description, pp.montant as Montant, per.libPer as Periodicite
                from  Periodicite per, Poste po, PostePeriodique pp
                where per.codePer=pp.typePer and pp.codePoste=po.codePoste";
            string requ2 = @"select po.codePoste as Code, po.libPoste as Description, count(e.codePoste) as Echeances, sum(e.montantEcheance) as Montant
                from Echeances e, Poste po, PostePonctuel pop
                where po.codePoste=pop.codePoste and e.codePoste=pop.codePoste
                group by po.codePoste, po.libPoste
                having count(e.codePoste)>1";
            string requ3 = @"select po.codePoste as Code, po.libPoste as Description, p.pnPersonne + ' ' + p.nomPersonne as Beneficiaire, pr.montant as Montant
                from PosteRevenu pr, Poste po, Personne p
                where po.codePoste=pr.codePoste and pr.codePersonne=p.codePersonne";
            rempliDTGB(requ, dataGridView1);
            rempliDTGB(requ2, dataGridView2);
            rempliDTGB(requ3, dataGridView3);
            frmMain.con.Close();

                // Ajout des events pour les modifications des DataGridView

            dataGridView1.CellBeginEdit += new DataGridViewCellCancelEventHandler(DebutFocusCellule);
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(FinFocusCellule);

        }

        string str = ""; //valeur de la cellule selectionnée
        /* Indique la cellule séléctionné */
        private void DebutFocusCellule(object sender, EventArgs e)
        {
            str = dgv.Rows[dc].Cells[1].Value.ToString(); //initialise un string avec le contenu de la cellule choisit 
        }
        private void FinFocusCellule(object sender, EventArgs e)
        {
            if (dgv.Rows[dc].Cells[1].Value.ToString().Length > 30 || dgv.Rows[dc].Cells[1].Value.ToString() == null || dgv.Rows[dc].Cells[1].Value.ToString().Length == 0)
            {
                dgv.Rows[dc].Cells[1].Value = str;
                str = "";
                MessageBox.Show("Attention, la valeur de la cellule a modifié possede une longueur supérieur à 30 ou est vide ou est null");
            }
            else
            {
                frmMain.con.Open();
                OleDbCommand command = new OleDbCommand("update Poste set libPoste='" + dgv.Rows[dc].Cells[1].Value.ToString() + "' where codePoste =" + dgv.Rows[dc].Cells[0].Value.ToString(), frmMain.con);
                command.ExecuteNonQuery();
                frmMain.con.Close();
            }

        }

        /* Remplir une DataGridView */
        private void rempliDTGB(string requete, DataGridView dg)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(requete, frmMain.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
        }

        private void ToolStripModifier(object sender, EventArgs e)
        {
            dgv.MultiSelect = false;
            dgv.Rows[dc].Cells[1].Selected = true;
            dgv.BeginEdit(true);
        }

        private void ToolStripSupprimer(object sender, EventArgs e)
        {
            frmMain.con.Open();
            OleDbCommand command = new OleDbCommand("delete from PostePeriodique where codePoste =" + dataGridView1.Rows[dc].Cells[0].Value.ToString(), frmMain.con);
            new OleDbCommand("delete from Poste where codePoste =" + dataGridView1.Rows[dc].Cells[0].Value.ToString(), frmMain.con).ExecuteNonQuery();
            command.ExecuteNonQuery();
            frmMain.con.Close();
            dgv.Rows.RemoveAt(dc);
        }

        private void CliqueDroitSurDataGridView1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int position_xy_mouse_row = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (e.Button == MouseButtons.Right)
                {
                    dc = e.RowIndex;
                    dgv = sender as DataGridView;

                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "fonction mouseclick datagridview1");
            }
        }

        private void CliqueDroitSurDataGridView2(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int position_xy_mouse_row = dataGridView2.HitTest(e.X, e.Y).RowIndex;
                if (e.Button == MouseButtons.Left)
                {
                    dc = e.RowIndex;
                    frmMain.con.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter("select pop.codePoste, p.libPoste, e.datePrelevt, e.montantEcheance from PostePonctuel pop, Poste p, Echeances e where pop.codePoste=p.codePoste and pop.codePoste=e.codePoste group by pop.codePoste, p.libPoste, e.datePrelevt, e.montantEcheance having pop.codePoste=" + dataGridView2.Rows[dc].Cells[0].Value.ToString(), frmMain.con);
                    DataTable dat = new DataTable();
                    da.Fill(dat);
                    frmMain.con.Close();

                    dc = e.RowIndex;
                    string res = "";
                    int i = 0;
                    while (i < dat.Rows.Count)
                    {
                        res += "Date prévue: " + dat.Rows[i][2].ToString() + "Montant: " + dat.Rows[i][3].ToString() + "\n";
                        i++;
                    }
                    MessageBox.Show("Poste à échéance n°:" + dat.Columns[0].ToString() + "\n" + "Achat: " + dat.Columns[1].ToString().ToString() + "\n" + res);
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void CliqueDroitSurDataGridView3(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int position_xy_mouse_row = dataGridView3.HitTest(e.X, e.Y).RowIndex;
                if (e.Button == MouseButtons.Right)
                {
                    dgv = sender as DataGridView;
                    dc = e.RowIndex;
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "fonction mouseclick datagridview3");
            }
        }

        /* PAS DE REF */
        private void buttoncal_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            // creer les colonnes de la datatable
            table.Columns.Add("Poste", typeof(string));
            table.Columns.Add("JANVIER", typeof(int));
            table.Columns.Add("FEVRIER", typeof(int));
            table.Columns.Add("MARS", typeof(int));
            table.Columns.Add("AVRIL", typeof(int));
            table.Columns.Add("MAI", typeof(int));
            table.Columns.Add("JUIN", typeof(int));
            table.Columns.Add("JUILLET", typeof(int));
            table.Columns.Add("AOUT", typeof(int));
            table.Columns.Add("SEPTEMBRE", typeof(int));
            table.Columns.Add("OCTOBRE", typeof(int));
            table.Columns.Add("NOVEMBRE", typeof(int));
            table.Columns.Add("DECEMBRE", typeof(int));

            // rajout des postes


            //this.dataGridView.Columns("AddToCartButton").Frozen = true;
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

        private void btnGrosDataGridView_Click(object sender, EventArgs e)
        {
            new frmGeant().ShowDialog();
        }
    }
}
