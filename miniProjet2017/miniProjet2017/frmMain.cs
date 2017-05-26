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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // ---------------------------------------------
        // Les boutons pour afficher les autres fenêtres
        // ---------------------------------------------

        private void NouveauFrmAjoutTransac(object sender, EventArgs e)
        {
            Hide();
            new frmAjoutTransac().ShowDialog();
            Show();
        }

        private void NouveauFrmAffichage(object sender, EventArgs e)
        {
            Hide();
            new frmAffichage().ShowDialog();
            Show();
        }

        private void NouveauFrmModiTransac(object sender, EventArgs e)
        {
            Hide();
            new frmModiTransac().ShowDialog();
            Show();
        }

        private void NouveauFrmRecap(object sender, EventArgs e)
        {
            Hide();
            new frmRecap().ShowDialog();
            Show();
        }

        private void NouveauFrmSupprTransac(object sender, EventArgs e)
        {
            Hide();
            new frmSupprTransac().ShowDialog();
            Show();
        }

        private void NouveauFrmOption(object sender, EventArgs e)
        {
            new frmOption().ShowDialog();
        }

        private void NouveauFrmAjouterPersonne(object sender, EventArgs e)
        {
            new frmAjouterPersonne().ShowDialog();
        }

        /* Ferme l'application */
        private void CliquerApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Cliquer sur le bouton des transaction dans le panel de gauche */
        static bool derouler = false;
        private void CliquerSurDeroulerTransaction(object sender, EventArgs e)
        {
            if (derouler = !derouler)
            {
                for (int i = 0; i < pnlGauche.Controls.Count; i++)
                    if (pnlGauche.Controls[i].Name == "btnAjouterTransaction"
                        || pnlGauche.Controls[i].Name == "btnModifierTransaction"
                        || pnlGauche.Controls[i].Name == "btnSupprimerTransaction")
                        pnlGauche.Controls[i].Left += 220;
                btn2.Top += 177;
            }
            else
            {
                for (int i = 0; i < pnlGauche.Controls.Count; i++)
                    if (pnlGauche.Controls[i].Name == "btnAjouterTransaction"
                        || pnlGauche.Controls[i].Name == "btnModifierTransaction"
                        || pnlGauche.Controls[i].Name == "btnSupprimerTransaction")
                        pnlGauche.Controls[i].Left -= 220;
                btn2.Top -= 177;
            }            
        }

        /* Création des boutons du menu déroulant */
        private void PremierChargementDeApplication(object sender, EventArgs e)
        {
            Button b = 
            new Button()
            {
                Name = "btnAjouterTransaction",
                Text = "Ajouter une transaction",
                Top = 140,
                Left = -160,
                Size = new Size(160, 60),
                Parent = pnlGauche,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                ForeColor = Color.White
            };
            b.FlatAppearance.BorderColor = Color.Black;
            b.FlatAppearance.BorderSize = 2;
            b.Click += new EventHandler(NouveauFrmAjoutTransac);

            b = 
            new Button()
            {
                Name = "btnModifierTransaction",
                Text = "Modifier une transaction",
                Top = 199,
                Left = -160,
                Size = new Size(160, 60),
                Parent = pnlGauche,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                ForeColor = Color.White
            };
            b.FlatAppearance.BorderColor = Color.Black;
            b.FlatAppearance.BorderSize = 2;
            b.Click += new EventHandler(NouveauFrmModiTransac);

            b =
            new Button()
            {
                Name = "btnSupprimerTransaction",
                Text = "Supprimer une transaction",
                Top = 258,
                Left = -160,
                Size = new Size(160, 60),
                Parent = pnlGauche,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                ForeColor = Color.White
            };
            b.FlatAppearance.BorderColor = Color.Black;
            b.FlatAppearance.BorderSize = 2;
            b.Click += new EventHandler(NouveauFrmSupprTransac);
        }

        /* MOVABLE
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        */
    }
}
