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
        public void AideModiTransac(Form form)
        {         
            foreach(PictureBox pic in form.Controls.OfType<PictureBox>())
            {
                if((string)pic.Tag == "Aide" )
                {
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Image = imgFlecheCourbee;  
                }
                if((string)pic.Tag == "Aide2")
                {
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Image = imgFlecheHori;
                }
            }
            
        }
        public static void AideAjoutTransac()
        {

        }
    }
}
