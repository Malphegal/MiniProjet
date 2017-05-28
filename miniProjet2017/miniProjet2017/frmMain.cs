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
            InitValeurOption();
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
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmOption().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        private void NouveauFrmAjouterPersonne(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmAjouterPersonne().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        /* Ferme l'application */
        private void CliquerApplication(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Quitter ?", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.OK)
                Application.Exit();
            else
            {
                // TODO: Amélioration ?
                WindowState = FormWindowState.Minimized;
                WindowState = FormWindowState.Maximized;
                WindowState = FormWindowState.Normal;
            }
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
                        || pnlGauche.Controls[i].Name == "btnSupprimerTransaction") {
                        pnlGauche.Controls[i].Left += 220;
                        pnlGauche.Controls[i].TabStop = true;
                    }
                btnAjouterPersonne.Top += 177;
            }
            else
            {
                for (int i = 0; i < pnlGauche.Controls.Count; i++)
                    if (pnlGauche.Controls[i].Name == "btnAjouterTransaction"
                        || pnlGauche.Controls[i].Name == "btnModifierTransaction"
                        || pnlGauche.Controls[i].Name == "btnSupprimerTransaction") {
                        pnlGauche.Controls[i].Left -= 220;
                        pnlGauche.Controls[i].TabStop = false;
                    }
                btnAjouterPersonne.Top -= 177;
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
                ForeColor = Color.White,
                TabStop = false,
                TabIndex = 1
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
                ForeColor = Color.White,
                TabStop = false,
                TabIndex = 2
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
                ForeColor = Color.White,
                TabStop = false,
                TabIndex = 3
            };
            b.FlatAppearance.BorderColor = Color.Black;
            b.FlatAppearance.BorderSize = 2;
            b.Click += new EventHandler(NouveauFrmSupprTransac);

                // Pour focus le premier bouton

            // TODO: pouquoi focus() ne fonctionne pas ?
            ProcessTabKey(false);
            ProcessTabKey(false);
        }

        /* Initialise les valeurs par défaut du formulaire des options */
        void InitValeurOption()
        {
            string[] fichier = System.IO.File.ReadAllLines(@"..\..\Resources\ValeurParDefaut.txt");
            
            frmOption.pourcentageSMS = Convert.ToByte(fichier[1]);
        }

        #region Drag&Drop
        public bool EnClique = false;
        public int SourisX,
            SourisY;

        private void DeplacementSouris(object sender, MouseEventArgs e)
        {
            if (EnClique)
                Location = new Point(Location.X + (e.X - SourisX), Location.Y + (e.Y - SourisY));
        }

        private void LacherCliqueSouris(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                EnClique = false;
        }

        private void CliqueSouris(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EnClique = true;
                SourisX = e.X;
                SourisY = e.Y;
            }
        }
        #endregion
    }
}
