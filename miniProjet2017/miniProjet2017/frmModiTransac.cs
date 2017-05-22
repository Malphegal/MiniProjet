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

        private void CliquerSurAideModif(object sender, EventArgs e)
        {
            new Classes.Aide().AideModiTransac(this);
        }
    }
}
