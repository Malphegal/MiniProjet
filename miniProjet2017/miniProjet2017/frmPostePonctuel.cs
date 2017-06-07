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
    public partial class frmPostePonctuel : Form
    {
        public frmPostePonctuel()
        {
            InitializeComponent();
        }

        private void frmPostePonctuel_Load(object sender, EventArgs e)
        {

        }

        private void txtNbPreleve_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                int i = int.Parse(txtNbPreleve.Text);
                genererElementsPrelevements(i);
            }
            else if(char.IsDigit(e.KeyChar)|| e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void genererElementsPrelevements(int i)
        {
            int topPnl = 170;
            int LeftPnl = 50;
            int topElem = 30;
            int leftElem = 50;

          //Version Panel
            Panel pnl = new Panel();
            TextBox txt = new TextBox();
            DateTimePicker dtp = new DateTimePicker();

            pnl.Text = "Liste des prélévements";
            pnl.Top = topPnl;
            pnl.Left = 30;
            pnl.Width = 480;
            pnl.Height = 300;
            pnl.AutoScroll = true;
            Controls.Add(pnl);
            Label lblTitre = new Label();
            lblTitre.Text = "Liste des prélévements";
            lblTitre.AutoSize= true;
            pnl.Controls.Add(lblTitre);

            //Version group box
            /*GroupBox grb = new GroupBox();
            grb.Text = "Liste des prélévements";
            grb.Top = topPnl;
            grb.Left = LeftPnl;
            grb.Controls.Add(new VScrollBar());
            Controls.Add(grb); */
            for (int j = 1; j <= i; j++)
            {
                Label lbl = new Label();
                DateTimePicker dtPick = new DateTimePicker();
                TextBox txt2 = new TextBox();
                dtPick.Top = topElem;
                dtPick.Left = leftElem + lbl.Width;
                lbl.Top = topElem;
                lbl.Left = leftElem;
                lbl.Text = "Prélévement n°" + j;
                pnl.Controls.Add(lbl);
                pnl.Controls.Add(dtPick);
              //grb.Controls.Add(lbl);

              //On incrémente les valeurs
                topElem += 30;
            }
        }
    }
}
