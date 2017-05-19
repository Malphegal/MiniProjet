using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProjet2017.Classes
{
    public static class Aide
    {
        public static void AideModiTransac(Form form)
        {
            Label lblAide = new System.Windows.Forms.Label();
            lblAide.Text = "Voici l'aide pour le formulaire de modification de transaction.";
            form.Controls.Add(lblAide);
        }
        public static void AideAjoutTransac()
        {

        }
    }
}
