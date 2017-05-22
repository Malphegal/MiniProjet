using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProjet2017.Classes
{
    public class Aide
    {
        Image imgFlecheCourbee = new Bitmap(@"..\..\..\..\Images\flecheCourbee.jpg");
        Image imgFlecheHori = new Bitmap(@"..\..\..\..\Images\flecheHorizontale.png");
        static bool test = false;
        static string[][] texte = new string[][]
        {
            new string[] {},
            new string[] {"Veuillez-choisir la date à laquelle la transaction a été faite.",
            "Veuillez-choisir une description pour la transaction.","Veuillez-choisir un montant en chiffre.",
            "Pour selectionner une dépense, selectionner perçu puis recette.","Veuillez-choisir un type parmis le menu déroulant."},
            new string[] {},
            new string[] {},
            new string[] {},
        };
        public void AideTransac(Form form)
        {
            if (test = !test)
            {
                foreach (PictureBox pic in form.Controls.OfType<PictureBox>())
                {
                    if ((string)pic.Tag == "Aide")
                    {
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Image = imgFlecheCourbee;
                        pic.Visible = true;
                    }
                    if ((string)pic.Tag == "Aide2")
                    {
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Image = imgFlecheHori;
                        pic.Visible = true;
                    }
                }
                byte k = 0;
                foreach (Label lbl in form.Controls.OfType<Label>())
                {
                    if ((string)lbl.Tag == "Aidelbl1")
                    {
                        lbl.Text = texte[Convert.ToByte(form.Tag)][k++];
                        lbl.AutoSize = true;
                        lbl.Visible = true;
                    }
                    else if ((string)lbl.Tag == "Aidelbl2")
                    {
                        lbl.Text = texte[Convert.ToByte(form.Tag)][k++];
                        lbl.AutoSize = true;
                        lbl.Visible = true;
                    }
                    else if ((string)lbl.Tag == "Aidelbl3")
                    {
                        lbl.Text = texte[Convert.ToByte(form.Tag)][k++];
                        lbl.AutoSize = true;
                        lbl.Visible = true;
                    }
                    else if ((string)lbl.Tag == "Aidelbl4")
                    {
                        lbl.Text = texte[Convert.ToByte(form.Tag)][k++];
                        lbl.AutoSize = true;
                        lbl.Visible = true;
                    }
                    else if ((string)lbl.Tag == "Aidelbl5")
                    {
                        lbl.Text = texte[Convert.ToByte(form.Tag)][k++];
                        lbl.AutoSize = true;
                        lbl.Visible = true;
                    }
                }
            }
            else
            {
                foreach (PictureBox pic in form.Controls.OfType<PictureBox>())
                {
                    if ((string)pic.Tag == "Aide")
                    {
                        pic.Visible = false;
                    }
                    if ((string)pic.Tag == "Aide2")
                    {
                        pic.Visible = false;
                    }
                }
                byte k = 0;
                foreach (Label lbl in form.Controls.OfType<Label>())
                {
                    if ((string)lbl.Tag == "Aidelbl1")
                    {
                        lbl.Text = texte[Convert.ToByte(form.Tag)][k++];
                        lbl.Visible = false;
                    }
                    else if ((string)lbl.Tag == "Aidelbl2")
                    {
                        lbl.Text = texte[Convert.ToByte(form.Tag)][k++];
                        lbl.Visible = false;
                    }
                    else if ((string)lbl.Tag == "Aidelbl3")
                    {
                        lbl.Text = texte[Convert.ToByte(form.Tag)][k++];
                        lbl.Visible = false;
                    }
                    else if ((string)lbl.Tag == "Aidelbl4")
                    {
                        lbl.Text = texte[Convert.ToByte(form.Tag)][k++];
                        lbl.Visible = false;
                    }
                    else if ((string)lbl.Tag == "Aidelbl5")
                    {
                        lbl.Text = texte[Convert.ToByte(form.Tag)][k++];
                        lbl.Visible = false;
                    }
                }
            }
          
        }
        public static void AideAjoutTransac()
        {

        }

    }
}
