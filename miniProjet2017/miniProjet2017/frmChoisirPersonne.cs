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
    public partial class frmChoisirPersonne : Form
    {
        public frmChoisirPersonne()
        {
            InitializeComponent();
        }

        private void RemplirLePanelDesPersonnes(object sender, EventArgs e)
        {
                // Remplissage de la table locale _Personne

            CON con = new CON("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget1.mdb");
            con.Open();
            DataSet ds = new DataSet();
            new OleDbDataAdapter("SELECT * FROM Personne", con).Fill(ds, "_Personne");
            con.Close();

                // Affichage de toutes les personnes dans le panel

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
                    Tag = i
                };
        }
    }
}
