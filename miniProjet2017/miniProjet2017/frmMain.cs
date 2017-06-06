using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CON = System.Data.OleDb.OleDbConnection;

namespace miniProjet2017
{
    public partial class frmMain : Form
    {
        public static System.Drawing.Text.PrivateFontCollection fonts = new System.Drawing.Text.PrivateFontCollection();
        public static CON con = new CON();

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
            if (!baseExist)
            {
                MessageBox.Show("La base de donnée est introuvable !\nVérifiez dans le menu option !", "Attention");
                return;
            }
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmAjoutTransac().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        private void NouveauFrmAffichage(object sender, EventArgs e)
        {
            if (!baseExist)
            {
                MessageBox.Show("La base de donnée est introuvable !\nVérifiez dans le menu option !", "Attention");
                return;
            }
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmAffichage().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        private void NouveauFrmModiTransac(object sender, EventArgs e)
        {
            if (!baseExist)
            {
                MessageBox.Show("La base de donnée est introuvable !\nVérifiez dans le menu option !", "Attention");
                return;
            }
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmModiTransac().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        private void NouveauFrmRecap(object sender, EventArgs e)
        {
            if (!baseExist)
            {
                MessageBox.Show("La base de donnée est introuvable !\nVérifiez dans le menu option !", "Attention");
                return;
            }
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmRecap().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        private void NouveauFrmSupprTransac(object sender, EventArgs e)
        {
            if (!baseExist)
            {
                MessageBox.Show("La base de donnée est introuvable !\nVérifiez dans le menu option !", "Attention");
                return;
            }
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmSupprTransac().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        private void NouveauFrmOption(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmOption().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
            resolutionScale = (0.6F + 0.2F * frmOption.valeurResolution);
            RedimensionnerFrmMain();
        }

        private void NouveauFrmAjouterPersonne(object sender, EventArgs e)
        {
            if (!baseExist)
            {
                MessageBox.Show("La base de donnée est introuvable !\nVérifiez dans le menu option !", "Attention");
                return;
            }
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmAjouterPersonne().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        private void NouveauFrmPostFixe(object sender, EventArgs e)
        {
            if (!baseExist)
            {
                MessageBox.Show("La base de donnée est introuvable !\nVérifiez dans le menu option !", "Attention");
                return;
            }
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmPostFixe().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        private void NouveauFrmPostePonctuel(object sender, EventArgs e)
        {
            if (!baseExist)
            {
                MessageBox.Show("La base de donnée est introuvable !\nVérifiez dans le menu option !", "Attention");
                return;
            }
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmPostePonctuel().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        private void NouveauFrm3(object sender, EventArgs e)
        {
            if (!baseExist)
            {
                MessageBox.Show("La base de donnée est introuvable !\nVérifiez dans le menu option !", "Attention");
                return;
            }
            foreach (Control c in Controls)
                c.Enabled = false;
            new frm_3().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        /* Ferme l'application */
        private void QuitterApplication(object sender, EventArgs e)
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

        /* Réduire cette application */
        private void CliquerSurReduire(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /* Cliquer sur le bouton des transactions dans le panel de gauche */
        static bool deroulerTransaction = false;
        private void CliquerSurDeroulerTransaction(object sender, EventArgs e)
        {
            if (deroulerTransaction = !deroulerTransaction)
            {
                foreach (Button b in pnlGauche.Controls.OfType<Button>())
                {
                    b.Top += Convert.ToInt32(b.Tag.ToString().Split(';')[1]) * 59;
                    if (b.Name == "btnAjouterTransaction"
                        || b.Name == "btnModifierTransaction"
                        || b.Name == "btnSupprimerTransaction")
                    {
                        b.Left += 220;
                        b.TabStop = true;
                    }
                }
                btnDeroulerTransaction.Text = btnDeroulerTransaction.Text.Replace('↓', '↑');
            }
            else {
                foreach (Button b in pnlGauche.Controls.OfType<Button>())
                {
                    b.Top -= Convert.ToInt32(b.Tag.ToString().Split(';')[1]) * 59;
                    if (b.Name == "btnAjouterTransaction"
                        || b.Name == "btnModifierTransaction"
                        || b.Name == "btnSupprimerTransaction")
                    {
                        b.Left -= 220;
                        b.TabStop = false;
                    }
                }
                btnDeroulerTransaction.Text = btnDeroulerTransaction.Text.Replace('↑', '↓');
            }
        }

        /* Cliquer sur le bouton des budgets dans le panel de gauche */
        static bool deroulerBudget = false;
        private void CliquerSurDeroulerBudget(object sender, EventArgs e)
        {
            if (deroulerBudget = !deroulerBudget)
            {
                foreach (Button b in pnlGauche.Controls.OfType<Button>())
                {
                    if (b.Name == "btnPostFixe"
                        || b.Name == "btnPostePonctuel"
                        || b.Name == "btnFrm_3")
                    {
                        b.Left += 220;
                        b.TabStop = true;
                    }
                }
                btnDeroulerBudget.Text = btnDeroulerBudget.Text.Replace('↓', '↑');
            }
            else {
                foreach (Button b in pnlGauche.Controls.OfType<Button>())
                {
                    if (b.Name == "btnPostFixe"
                        || b.Name == "btnPostePonctuel"
                        || b.Name == "btnFrm_3")
                    {
                        b.Left -= 220;
                        b.TabStop = false;
                    }
                }
                btnDeroulerBudget.Text = btnDeroulerBudget.Text.Replace('↑', '↓');
            }
        }

        // TODO: Dérouler proprement et joliment
        /* Création des boutons du menu déroulant */
        private void PremierChargementDeApplication(object sender, EventArgs e)
        {
                // Les polices d'écritures

            fonts.AddFontFile("..\\..\\..\\..\\Font\\Café Françoise.otf");

            lblTitre.Font = new System.Drawing.Font(fonts.Families[0], lblTitre.Font.Size);

                // Dérouler transaction

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
                Font = btnDeroulerTransaction.Font,
                Cursor = Cursors.Hand,
                ForeColor = Color.White,
                TabStop = false,
                Tag = "derouler;0",
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
                Font = btnDeroulerTransaction.Font,
                Cursor = Cursors.Hand,
                ForeColor = Color.White,
                TabStop = false,
                Tag = "derouler;0",
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
                Font = btnDeroulerTransaction.Font,
                Cursor = Cursors.Hand,
                ForeColor = Color.White,
                TabStop = false,
                Tag = "derouler;0",
                TabIndex = 3
            };
            b.FlatAppearance.BorderColor = Color.Black;
            b.FlatAppearance.BorderSize = 2;
            b.Click += new EventHandler(NouveauFrmSupprTransac);

            // Dérouler budget

            b =
            new Button()
            {
                Name = "btnPostFixe",
                Text = "frmPostFixe",
                Top = 258,
                Left = -160,
                Size = new Size(160, 60),
                Parent = pnlGauche,
                FlatStyle = FlatStyle.Flat,
                Font = btnDeroulerTransaction.Font,
                Cursor = Cursors.Hand,
                ForeColor = Color.White,
                TabStop = false,
                Tag = "derouler;3",
                TabIndex = 6
            };
            b.FlatAppearance.BorderColor = Color.Black;
            b.FlatAppearance.BorderSize = 2;
            b.Click += new EventHandler(NouveauFrmPostFixe);

            b =
            new Button()
            {
                Name = "btnPostePonctuel",
                Text = "frmPostePonctuel",
                Top = 317,
                Left = -160,
                Size = new Size(160, 60),
                Parent = pnlGauche,
                FlatStyle = FlatStyle.Flat,
                Font = btnDeroulerTransaction.Font,
                Cursor = Cursors.Hand,
                ForeColor = Color.White,
                TabStop = false,
                Tag = "derouler;3",
                TabIndex = 7
            };
            b.FlatAppearance.BorderColor = Color.Black;
            b.FlatAppearance.BorderSize = 2;
            b.Click += new EventHandler(NouveauFrmPostePonctuel);

            b =
            new Button()
            {
                Name = "btnFrm_3",
                Text = "frmFrm_3",
                Top = 376,
                Left = -160,
                Size = new Size(160, 60),
                Parent = pnlGauche,
                FlatStyle = FlatStyle.Flat,
                Font = btnDeroulerTransaction.Font,
                Cursor = Cursors.Hand,
                ForeColor = Color.White,
                TabStop = false,
                Tag = "derouler;3",
                TabIndex = 8
            };
            b.FlatAppearance.BorderColor = Color.Black;
            b.FlatAppearance.BorderSize = 2;
            b.Click += new EventHandler(NouveauFrm3);

            // Pour focus le premier bouton

            ActiveControl = btnDeroulerTransaction;
        }

        /* Initialise les valeurs par défaut du formulaire des options */
        public static bool baseExist = true;
        void InitValeurOption()
        {
            // Recherche du fichier de stockage

            if (!File.Exists(@"..\..\Resources\ValeurParDefaut.txt"))
            {
                MessageBox.Show("Le fichier ValeurParDefaut est manquant ! ");
            }
            else {
                // Fichier de stockage

                string[] fichier = System.IO.File.ReadAllLines(@"..\..\Resources\ValeurParDefaut.txt");

                if (!File.Exists(fichier[1]))
                    baseExist = false;
                else
                    con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fichier[1] + ";Persist Security Info=True";

                try { frmOption.pourcentageSMS = Convert.ToByte(fichier[3]); }
                catch { MessageBox.Show("Le poucentageSMS n'est pas correct !"); };
                try { frmOption.valeurResolution = Convert.ToByte(fichier[5]); }
                catch { MessageBox.Show("La valeur de résolution n'est pas correct !"); };
            }
            // Mise à jour de la résolution

            resolutionScale = (0.6F + 0.2F * frmOption.valeurResolution);
            privateResolutionScale = resolutionScale;
            Scale(new SizeF(resolutionScale, resolutionScale));
            RedimensionnerLesControls(this, resolutionScale);
        }
        public static float resolutionScale;
        static float privateResolutionScale;
        // TODO: changer les valeurs ??
        public static void RedimensionnerLesControls(Control parent, float coeff)
        {
            foreach (Control c in parent.Controls)
                if (c.GetType() == typeof(Button) || c.GetType() == typeof(Label) || c.GetType() == typeof(TextBox))
                    c.Font = new System.Drawing.Font(c.Font.FontFamily, c.Font.Size * coeff);
                else
                    RedimensionnerLesControls(c, coeff);
        }
        void RedimensionnerFrmMain()
        {
            if (resolutionScale == privateResolutionScale)
                return;
            if (privateResolutionScale == 1F)
            {
                RedimensionnerLesControls(this, resolutionScale);
                Scale(new SizeF(resolutionScale, resolutionScale));
            }
            else if (privateResolutionScale == 0.8F)
            {
                RedimensionnerLesControls(this, 1.25F);
                Scale(new SizeF(1.25F, 1.25F));
                if (resolutionScale == 1.2F)
                {
                    RedimensionnerLesControls(this, resolutionScale);
                    Scale(new SizeF(resolutionScale, resolutionScale));
                }
            }
            else
            {
                RedimensionnerLesControls(this, 5 / 6F);
                Scale(new SizeF(5 / 6F, 5 / 6F));
                if (resolutionScale == 0.8F)
                {
                    RedimensionnerLesControls(this, resolutionScale);
                    Scale(new SizeF(resolutionScale, resolutionScale));
                }
            }
            privateResolutionScale = resolutionScale;
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

        // ---------------------------------------------
        // ---------------- Event hover ----------------
        // ---------------------------------------------

        private void HoverQuitter(object sender, EventArgs e)
        {
            toolTip.Show("Quitte l'application.", picQuitter, 20, 5);
        }

        private void _HoverQuitter(object sender, EventArgs e)
        {
            toolTip.Show("", picQuitter);
        }

        private void HoverOption(object sender, EventArgs e)
        {
            toolTip.Show("Affiche les options.", picOption, 20, 5);
        }

        private void _HoverOption(object sender, EventArgs e)
        {
            toolTip.Show("", picOption);
        }
    }
}