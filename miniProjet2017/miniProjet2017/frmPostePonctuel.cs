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

        /* Création ou suppression des lignes des échéances */
        private void GenererElementsPrelevements(int i)
        {

            if(ancienNbEcheance < i)
            {
                int m = DateTime.Today.Month;
                int y = DateTime.Today.Year;
                for (int j = ancienNbEcheance+1; j <= i; j++)
                {
                        //Création des différents items
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
                    txt2.KeyPress += new KeyPressEventHandler(EntrerMontant);
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
                for(int j = 0; j < (ancienNbEcheance - i) * 3; j+= 3)
                {
                        // Suppression des éléments
                    pnl.Controls.RemoveAt(pnl.Controls.Count - 1);
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

            if (txtIntitule.Text.Length > 30 || txtIntitule.Text == "")
            {
                errorProvider1.SetError(txtIntitule, "La decription doit être non vide, et ne doit pas dépasser 30 caractères !");
                toutEstOK = false;
            }
            else
                errorProvider1.SetError(txtIntitule, "");

            if (txtNbPreleve.Text.Length == 0)
            {
                errorProvider1.SetError(txtNbPreleve, "Il doit y avoir au moins 2 échéances !");
                toutEstOK = false;
            }
            else
                errorProvider1.SetError(txtNbPreleve, "");

            foreach(TextBox txt in pnl.Controls.OfType<TextBox>())
            {
                if(txt.Text == "")
                {
                    errorProvider1.SetError(txt, "Il doit y avoir une valeur entrée");
                    toutEstOK = false;
                }
                else
                    errorProvider1.SetError(txt, "");
            }

                // S'il n'y a pas d'erreur, ajout dans la base de donnée

            if (toutEstOK)
            {
                if (DialogResult.OK == MessageBox.Show("AJOUTER ? • [TODO]", "Ajout d'un poste ponctuel", MessageBoxButtons.OKCancel))
                {
                    frmMain.con.Open();

                    int idMax = -1;
                    idMax = Convert.ToInt32(new CMD(@"SELECT IIF(max(codePoste) IS NULL, 1, max(codePoste) + 1)
                                                          FROM Poste", frmMain.con).ExecuteScalar());

                    new CMD(@"INSERT INTO Poste VALUES ("
                    + idMax + ", '"
                    + txtDescri.Text + "')", frmMain.con).ExecuteNonQuery();

                    new CMD(@"INSERT INTO PostePonctuel VALUES ("
                    //+ (cboTypePoste.SelectedIndex + 1) + ", '"
                    + idMax + ", '"
                    + txtDescri.Text + "')", frmMain.con).ExecuteNonQuery();

                    float montantActuel;

                    foreach (DateTimePicker dtp in pnl.Controls.OfType<DateTimePicker>())
                    {
                        montantActuel = -1;
                        foreach (TextBox txt in pnl.Controls.OfType<TextBox>())
                            if (txt.Tag.ToString() == dtp.Tag.ToString())
                            {
                                montantActuel = float.Parse(txt.Text.Replace('.', ','));
                                break;
                            }
                        
                        new CMD(@"INSERT INTO Echeances VALUES ("
                        + idMax + ", "
                        + "#" + (dtp.Value.Day > 9
                        ? dtp.Value.Day.ToString()
                        : "0" + dtp.Value.Day.ToString()) + '/' + (dtp.Value.Month > 9
                        ? dtp.Value.Month.ToString()
                        : "0" + dtp.Value.Month.ToString()) + '/' + dtp.Value.Year + "#, "
                        + montantActuel.ToString().Replace(',', '.') + ")", frmMain.con).ExecuteNonQuery();
                    }

                    MessageBox.Show("Ce poste a été ajouté dans la base de donnée !");

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

        private void EntrerMontant(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((sender as TextBox).Text == "" || double.Parse((sender as TextBox).Text) < 0.01D)
            {
                errorProvider1.SetError((sender as TextBox), "Il faut indiquer un montant non nul (ou inférieur à 1 centime) pour cette transaction !");
            }
            else errorProvider1.SetError((sender as TextBox), "");
            
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else if (e.KeyChar == ',' && !(sender as TextBox).Text.Contains(","))
                e.Handled = false;
            else if (e.KeyChar == '.' && !(sender as TextBox).Text.Contains(","))
            {
                e.KeyChar = ',';
                e.Handled = false;
            }
        }
    }
}
