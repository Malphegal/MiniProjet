using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProjet2017
{
    public partial class frmAide : Form
    {
        public frmAide(string val)
        {
            InitializeComponent();
            switch (val)
            {
                case "modif":
                    Classes.Aide.AideModiTransac(this);
                    break;
                case "ajout":
                    Classes.Aide.AideAjoutTransac();
                    break;
            }
        }

        private void frmAide_Load(object sender, EventArgs e)
        {

        }
    }

}
