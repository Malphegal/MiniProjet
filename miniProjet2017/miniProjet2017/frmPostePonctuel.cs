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
        int topPnl = 200;
        int topElem = 30;
        int leftElem = 20;
        Panel pnl;

        private void txtNbPreleve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtNbPreleve.Text.Length == 0)
                return;
            if (txtNbPreleve.Text.Length > 0 && e.KeyChar == 13 && int.Parse(txtNbPreleve.Text) > 1)
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
                errorProvider1.SetError(txtNbPreleve, "Veuillez entrer un valeur supérieure à 1 !");
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
                pnl.Width = 430;
                pnl.Height = 220;
                pnl.AutoScroll = true;
                picBordure.Controls.Add(pnl);
                Label lblTitre = new Label();
                lblTitre.Top = 10;
                lblTitre.Text = "Liste des prélévements";
                lblTitre.AutoSize = true;
                lblTitre.ForeColor = Color.White;
                pnl.Controls.Add(lblTitre);
            }
            if(ancienNbEcheance < i)
            {
                int m = DateTime.Today.Month;
                int y = DateTime.Today.Year;
                for (int j = ancienNbEcheance+1; j <= i; j++)
                {
                    Label lbl = new Label();
                    lbl.ForeColor = Color.White;
                    DateTimePicker dtPick = new DateTimePicker();
                    TextBox txt2 = new TextBox();

                    dtPick.Top = topElem;
                    dtPick.Left =lbl.Width;
                    if (m > 12) // Mois plus grand que 12 ?
                    {
                        m = 1; y++; //On réinitialise le nombre de mois à 1, et on augmente l'année de 1.
                        dtPick.Value = new DateTime(y, m, DateTime.Today.Day);
                    }
                    else if (m <= 12)
                    {
                        dtPick.Value = new DateTime(y, m, DateTime.Today.Day); // Situation normale 
                    }
                                        
                    lbl.Top = topElem;
                    lbl.Text = "Prélévement n°" + j;
                    txt2.Top = topElem;
                    txt2.Left = lbl.Width + dtPick.Width;
                    pnl.Controls.Add(lbl);
                    pnl.Controls.Add(dtPick);
                    pnl.Controls.Add(txt2);
                    MessageBox.Show(lbl.Top.ToString());
                    //On incrémente les valeurs
                    topElem += 30;
                    m++;
                }
            }
            else if(ancienNbEcheance > i){
                for(int j = 0; j < (ancienNbEcheance - i) * 2; j+= 2)
                {
                    pnl.Controls.RemoveAt(pnl.Controls.Count - 1);
                    pnl.Controls.RemoveAt(pnl.Controls.Count - 1);
                    topElem -= 30;
                }
            }
            ancienNbEcheance = i;
        }

        private void picQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Ici traitement de la transaction SQL
        }
    }
}
