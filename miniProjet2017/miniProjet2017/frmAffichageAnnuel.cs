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
    public partial class frmAffichageAnnuel : Form
    {
        public frmAffichageAnnuel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CMD cmd = new CMD();

            DataTable Tablerevenu = new DataTable();
            DataTable Tableperiodique = new DataTable();

            string reqRevenu = "select pr.codePoste, po.libPoste, pr.montant from Poste po, PosteRevenu pr where po.codePoste=pr.codeposte";
            string reqPeriodique = "select pp.codePoste, po.libPoste, pp.montant, pp.typePer from Poste po, PostePeriodique pp where po.codePoste=pp.codeposte";

            rempliDataTable(reqRevenu, Tablerevenu);
            rempliDataTable(reqPeriodique, Tableperiodique);

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

            int res;

            // rajout des postes revenus
            for (int i = 0; i < Tablerevenu.Rows.Count; i++)
            {
                res = int.Parse(Tablerevenu.Rows[i][2].ToString());
                table.Rows.Add(Tablerevenu.Rows[i][1].ToString(), res, res, res, res, res, res, res, res, res, res, res, res);
            }

            //rajout des postes periodiques
            for (int j = 0; j < Tableperiodique.Rows.Count; j++)
            {
                if ((int)Tableperiodique.Rows[j][3] == 1)
                {
                    res = -int.Parse(Tableperiodique.Rows[j][2].ToString()) * 4;
                    table.Rows.Add(Tableperiodique.Rows[j][1].ToString(), res, res, res, res, res, res, res, res, res, res, res, res);
                }

                if ((int)Tableperiodique.Rows[j][3] == 2)
                {
                    res = -int.Parse(Tableperiodique.Rows[j][2].ToString());
                    table.Rows.Add(Tableperiodique.Rows[j][1].ToString(), res, res, res, res, res, res, res, res, res, res, res, res);
                }

                if ((int)Tableperiodique.Rows[j][3] == 3)
                {
                    res = -int.Parse(Tableperiodique.Rows[j][2].ToString());
                    table.Rows.Add(Tableperiodique.Rows[j][1].ToString(), res, 0, res, 0, res, 0, res, 0, res, 0, res, 0);
                }

                if ((int)Tableperiodique.Rows[j][3] == 4)
                {
                    res = -int.Parse(Tableperiodique.Rows[j][2].ToString());
                    table.Rows.Add(Tableperiodique.Rows[j][1].ToString(), res, 0, 0, res, 0, 0, res, 0, 0, res, 0, 0);
                }

                if ((int)Tableperiodique.Rows[j][3] == 5)
                {
                    res = -int.Parse(Tableperiodique.Rows[j][2].ToString());
                    table.Rows.Add(Tableperiodique.Rows[j][1].ToString(), res, 0, 0, 0, 0, res, 0, 0, 0, 0, res, 0);
                }

                if ((int)Tableperiodique.Rows[j][3] == 6)
                {
                    res = -int.Parse(Tableperiodique.Rows[j][2].ToString());
                    table.Rows.Add(Tableperiodique.Rows[j][1].ToString(), res, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                }
            }

            //total mois
            table.Rows.Add("Total mois", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            for (int l = 1; l < table.Columns.Count; l++)
            {
                int nbTotaleMois = 0;
                for (int k = 0; k < table.Rows.Count; k++)
                {
                    nbTotaleMois += int.Parse(table.Rows[k][l].ToString());
                }
                table.Rows[table.Rows.Count - 1][l] = nbTotaleMois;
            }

            //total année
            table.Rows.Add("Total", 0);
            int nbTotal = 0;
            for (int m = 1; m < table.Columns.Count; m++)
            {
                nbTotal += int.Parse(table.Rows[table.Rows.Count - 2][m].ToString());
            }
            table.Rows[table.Rows.Count - 1][1] = nbTotal;

            //transformation de la dataTable en dataGridView
            BO.DataSource = table;

            //gele la première colonne de la dataGridView
            this.BO.Columns[0].Frozen = true;
        }

        private void rempliDataTable(string requete, DataTable dt)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(requete, frmMain.con);
            da.Fill(dt);
        }
    }
}
