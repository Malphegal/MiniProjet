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
    public partial class frmChoisirPersonne : Form
    {
        public frmChoisirPersonne(List<uint> ceuxDejaSelectionne)
        {
            InitializeComponent();
            _listeParticipant = ceuxDejaSelectionne;
        }

        List<uint> _listeParticipant;
        public List<uint> listeParticipant { get { return _listeParticipant; } }

        /* Affichage de toutes les personnes */
        private void RemplirLePanelDesPersonnes(object sender, EventArgs e)
        {
                // Remplissage de la table locale _Personne

            frmMain.con.Open();
            DataSet ds = new DataSet();
            new OleDbDataAdapter("SELECT * FROM Personne", frmMain.con).Fill(ds, "_Personne");
            frmMain.con.Close();

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
                    Tag = ds.Tables["_Personne"].Rows[i][0]
                }.Checked = listeParticipant.Contains((uint)i + 1);

                // Message s'il n'y a personne dans la base de donnée

            if (pnlPersonne.Controls.OfType<CheckBox>().Count() == 0)
                new Label()
                {
                    Parent = pnlPersonne,
                    Left = 40,
                    Top = 45,
                    Text = " • Il n'y a personne dans la base de donnée •",
                    Font = new Font(FontFamily.GenericSansSerif, 14F),
                    ForeColor = Color.Red,
                    AutoSize = true
                };
        }

        /* Ajoute les ID des personnes dans la liste et ferme le formulaire */
        private void CliquerSurValider(object sender, EventArgs e)
        {
            _listeParticipant.Clear();
            foreach (var chk in pnlPersonne.Controls.OfType<CheckBox>())
                if (chk.Checked)
                    _listeParticipant.Add(Convert.ToUInt32(chk.Tag));
            DialogResult = DialogResult.OK;
        }

        /* Ferme ce formulaire sans choisir de personne */
        private void QuitterFrmChoisirPersonne(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox chk in pnlPersonne.Controls.OfType<CheckBox>())
            {
                chk.Checked = (sender as CheckBox).Checked;
            }
        }
    }
}
