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
    public partial class frmPostePonctuel : Form
    {
        Panel pnl;

        public frmPostePonctuel()
        {
            InitializeComponent();       
        }

        /* Création du panel et de son label, zone pour mettre les lignes échéances */
        private void ChargementDuFormulaire(object sender, EventArgs e)
        {
            flecheRetour = picQuitter.Image;

                // Remplissage cbo type

            DataSet ds = new DataSet();
            new OleDbDataAdapter(new CMD(@"SELECT * FROM Poste", frmMain.con)).Fill(ds, "_Poste");

            foreach (DataRow row in ds.Tables["_Poste"].Rows)
                cboTypePoste.Items.Add(row[1]);

                // Création du panel
                
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

        /* Contrôle de la saisie du nombre d'échéances qui l'on souhaite avoir */
        private void SaisirUnNombreDePrelevement(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtNbPreleve.Text.Length == 0)
                return;
            if (txtNbPreleve.Text.Length > 0 && e.KeyChar == 13 && int.Parse(txtNbPreleve.Text) > 1)
            {
                int i = int.Parse(txtNbPreleve.Text);
                GenererElementsPrelevements(i);
                errorProvider1.SetError(txtNbPreleve, "");
            }
            else if(char.IsDigit(e.KeyChar)|| e.KeyChar == 8)
                e.Handled = false;
            else if (e.KeyChar == 13 && int.Parse(txtNbPreleve.Text) <= 1)
            {
                errorProvider1.SetIconPadding(txtNbPreleve, 10);
                errorProvider1.SetError(txtNbPreleve, "Veuillez entrer un valeur supérieure à 1 !");
            }
            else
                e.Handled = true;
        }

        int ancienNbEcheance = 0;
        int topPnl = 200;
        int topElem = 30;
        int leftElem = 20;

        /* Création ou suppression des lignes des échéances */
        private void GenererElementsPrelevements(int i)
        {

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

                    lbl.Tag = "tag" + j;
                    dtPick.Tag = "tag" + j;
                    txt2.Tag = "tag" + j;

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

        /* Ferme le formulaire frmPostePonctuel */
        private void QuitterFrmPostePonctuel(object sender, EventArgs e)
        {
            Close();
        }

        /* Ajouter dans la base de donnée le poste ponctuel que l'on souhaite faire */
        private void AjouterLePostePonctuel(object sender, EventArgs e)
        {
                // Sera false s'il y a une erreur

            bool toutEstOK = true;

                // Vérification au cas par cas

            if(txtDescri.Text.Length > 30 || txtDescri.Text == "") {
                errorProvider1.SetError(txtDescri, "La decription doit être non vide, et ne doit pas dépasser 30 caractères !");
                toutEstOK = false;
            }
            else
                errorProvider1.SetError(txtDescri, "");

            if (txtNbPreleve.Text.Length == 0)
            {
                errorProvider1.SetError(txtNbPreleve, "Il doit y avoir au moins 2 échéances !");
                toutEstOK = false;
            }
            else
                errorProvider1.SetError(txtNbPreleve, "");

                // S'il n'y a pas d'erreur, ajout dans la base de donnée

            if (toutEstOK)
            {
                if (DialogResult.OK == MessageBox.Show("AJOUTER ? • [TODO]", "Ajout d'un poste ponctuel", MessageBoxButtons.OKCancel))
                {
                    frmMain.con.Open();

                    new CMD(@"INSERT INTO PostePonctuel VALUES ("
                    + (cboTypePoste.SelectedIndex + 1) + ", '"
                    + txtDescri.Text + "')", frmMain.con).ExecuteNonQuery();

                    float montantActuel;

                    foreach (DateTimePicker dtp in pnl.Controls.OfType<DateTimePicker>())
                    {
                        montantActuel = -1;
                        foreach (TextBox txt in pnl.Controls.OfType<TextBox>())
                        {
                            MessageBox.Show(txt.Tag + "\n" + dtp.Tag);
                            if (txt.Tag.ToString() == dtp.Tag.ToString())
                            {
                                montantActuel = float.Parse(txt.Text.Replace('.', ','));
                                MessageBox.Show(montantActuel.ToString());
                                break;
                            }
                        }

                        new CMD(@"INSERT INTO Echeances VALUES ("
                        + (cboTypePoste.SelectedIndex + 1) + ", "
                        + "#" + (dtp.Value.Day > 9
                        ? dtp.Value.Day.ToString()
                        : "0" + dtp.Value.Day.ToString()) + '/' + (dtp.Value.Month > 9
                        ? dtp.Value.Month.ToString()
                        : "0" + dtp.Value.Month.ToString()) + '/' + dtp.Value.Year + "#, "
                        + montantActuel.ToString().Replace(',', '.') + ")", frmMain.con).ExecuteNonQuery();
                    }

                    frmMain.con.Close();
                }
                else
                    MessageBox.Show("Aucune modification n'a été effectuée !");
            }
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
    }
}
