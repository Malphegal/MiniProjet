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
    public partial class frmPostFixe : Form
    {
        public frmPostFixe()
        {
            InitializeComponent();
        }

        private void DemarrageDeFrmPostFixe(object sender, EventArgs e)
        {
                // Création de la base de donnée

            DataSet ds = new DataSet();
            new OleDbDataAdapter(@"SELECT * FROM Poste", frmMain.con).Fill(ds, "_Poste");

                // Remplissage de la cboPoste


        }
    }
}
