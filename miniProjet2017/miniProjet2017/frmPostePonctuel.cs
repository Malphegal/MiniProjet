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

        int ancienNbEcheance = 0;
        int topPnl = 170;
        int topElem = 30;
        int leftElem = 20;
        Panel pnl;

        private void txtNbPreleve_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13 && int.Parse(txtNbPreleve.Text) > 1 )
            {
                int i = int.Parse(txtNbPreleve.Text);
                genererElementsPrelevements(i);
                errorProvider1.SetError(txtNbPreleve, "");
            }
            else if(char.IsDigit(e.KeyChar)|| e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13 && int.Parse(txtNbPreleve.Text) <= 1)
            {
                errorProvider1.SetIconPadding(txtNbPreleve, 10);
                errorProvider1.SetError(txtNbPreleve, "Veuillez entrer un valeur supérieure à 1");
            }
            else
            {
                e.Handled = true;
            }
        }

        private void genererElementsPrelevements(int i)
        {
            if (pnl == null)
            {
                //Version Panel
                pnl = new Panel();
                pnl.Text = "Liste des prélévements";
                pnl.Top = topPnl;
                pnl.Left = 30;
                pnl.Width = 480;
                pnl.Height = 300;
                pnl.AutoScroll = true;
                Controls.Add(pnl);
                Label lblTitre = new Label();
                lblTitre.Text = "Liste des prélévements";
                lblTitre.AutoSize = true;
                pnl.Controls.Add(lblTitre);
            }
            if(ancienNbEcheance < i)
            {
                for (int j = ancienNbEcheance+1; j <= i; j++)
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

                    //On incrémente les valeurs
                    topElem += 30;

                }
            }
            else if(ancienNbEcheance > i){
                for(int j = pnl.Controls.Count-1; j < i*2+1; )
                {
                    MessageBox.Show(pnl.Controls.Count.ToString());
                    pnl.Controls.RemoveAt(j--);
                    pnl.Controls.RemoveAt(j--);
                    MessageBox.Show(pnl.Controls.Count.ToString());
                }
            }
            MessageBox.Show(pnl.Controls.Count.ToString());
            ancienNbEcheance = i;
        }

        private void txtNbPreleve_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNbPreleve.Text) && Convert.ToInt32(txtNbPreleve.Text) > ancienNbEcheance)
            {
                for(int i = 0; i < Controls.Count; i++)
                {
                    if(Controls[i].Name == "pnl")
                    {
                        for(int j = 0; j < Convert.ToInt32(txtNbPreleve.Text) - ancienNbEcheance; j++)
                        {
                            Label lbl = new Label();
                            DateTimePicker dtPick = new DateTimePicker();
                            TextBox txt2 = new TextBox();
                            dtPick.Top = topElem;
                            dtPick.Left = leftElem + lbl.Width;
                            lbl.Top = topElem;
                            lbl.Left = leftElem;
                            lbl.Text = "Prélévement n°" + j;
                            Controls[i].Controls.Add(lbl);
                            Controls[i].Controls.Add(dtPick);
                            topElem += 30;
                        }
                    }
                }
            }
        }
    }
}
