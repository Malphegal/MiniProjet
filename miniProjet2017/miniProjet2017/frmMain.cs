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

        private void NouveauBudgetRecap(object sender, EventArgs e)
        {
            if (!baseExist)
            {
                MessageBox.Show("La base de donnée est introuvable !\nVérifiez dans le menu option !", "Attention");
                return;
            }
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmBudgetRecap().ShowDialog();
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
        static Timer timerDeroulantTransaction = new Timer();
        private void CliquerSurDeroulerTransaction(object sender, EventArgs e)
        {
            if (deroulerTransaction = !deroulerTransaction)
            {
                timerDeroulantTransaction.Stop();
                timerDeroulantTransaction.Start();
                _btnDeroulerTransaction.Text = _btnDeroulerTransaction.Text.Replace('↓', '↑');
            }
            else {
                timerDeroulantTransaction.Stop();
                timerDeroulantTransaction.Start();
                _btnDeroulerTransaction.Text = _btnDeroulerTransaction.Text.Replace('↑', '↓');
            }
        }

        void DeroulementDeTransaction(object sender, EventArgs e)
        {
            btnAjouterTransaction.Height += 3;
            btnModifierTransaction.Height += 3;
            btnSupprimerTransaction.Height += 3;
            if (btnAjouterTransaction.Height >= 50)
            {
                timerDeroulantTransaction.Stop();
                btnAjouterTransaction.Height = 50;
                btnModifierTransaction.Height = 50;
                btnSupprimerTransaction.Height = 50;
                btnAjouterTransaction.TabStop = true;
                btnModifierTransaction.TabStop = true;
                btnSupprimerTransaction.TabStop = true;
                timerDeroulantTransaction.Tick -= new EventHandler(DeroulementDeTransaction);
                timerDeroulantTransaction.Tick += new EventHandler(EnroulementDeTransaction);
            }
        }

        void EnroulementDeTransaction(object sender, EventArgs e)
        {
            btnAjouterTransaction.Height -= 3;
            btnModifierTransaction.Height -= 3;
            btnSupprimerTransaction.Height -= 3;
            if (btnAjouterTransaction.Height <= 0)
            {
                timerDeroulantTransaction.Stop();
                btnAjouterTransaction.Height = 0;
                btnModifierTransaction.Height = 0;
                btnSupprimerTransaction.Height = 0;
                btnAjouterTransaction.TabStop = false;
                btnModifierTransaction.TabStop = false;
                btnSupprimerTransaction.TabStop = false;
                timerDeroulantTransaction.Tick -= new EventHandler(EnroulementDeTransaction);
                timerDeroulantTransaction.Tick += new EventHandler(DeroulementDeTransaction);
            }
        }

        /* Cliquer sur le bouton des budgets dans le panel de gauche */
        static bool deroulerBudget = false;
        static Timer timerDeroulantBudget = new Timer();
        private void CliquerSurDeroulerBudget(object sender, EventArgs e)
        {
            if (deroulerBudget = !deroulerBudget)
            {
                timerDeroulantBudget.Stop();
                timerDeroulantBudget.Start();
                btnDeroulerBudget.Text = btnDeroulerBudget.Text.Replace('↓', '↑');
            }
            else {
                timerDeroulantBudget.Stop();
                timerDeroulantBudget.Start();
                btnDeroulerBudget.Text = btnDeroulerBudget.Text.Replace('↑', '↓');
            }
        }

        void DeroulementDeBudget(object sender, EventArgs e)
        {
            btnPostFixe.Height += 3;
            btnPostePonctuel.Height += 3;
            btnFrm_3.Height += 3;
            btnBudgetRecap.Height += 3;
            if (btnPostFixe.Height >= 50)
            {
                timerDeroulantBudget.Stop();
                btnPostFixe.Height = 50;
                btnPostePonctuel.Height = 50;
                btnFrm_3.Height = 50;
                btnBudgetRecap.Height = 50;
                btnPostFixe.TabStop = true;
                btnPostePonctuel.TabStop = true;
                btnFrm_3.TabStop = true;
                btnBudgetRecap.TabStop = true;
                timerDeroulantBudget.Tick -= new EventHandler(DeroulementDeBudget);
                timerDeroulantBudget.Tick += new EventHandler(EnroulementDeBudget);
            }
        }

        void EnroulementDeBudget(object sender, EventArgs e)
        {
            btnPostFixe.Height -= 3;
            btnPostePonctuel.Height -= 3;
            btnFrm_3.Height -= 3;
            btnBudgetRecap.Height -= 3;
            if (btnPostFixe.Height <= 0)
            {
                timerDeroulantBudget.Stop();
                btnPostFixe.Height = 0;
                btnPostePonctuel.Height = 0;
                btnFrm_3.Height = 0;
                btnBudgetRecap.Height = 0;
                btnPostFixe.TabStop = false;
                btnPostePonctuel.TabStop = false;
                btnFrm_3.TabStop = false;
                btnBudgetRecap.TabStop = false;
                timerDeroulantBudget.Tick -= new EventHandler(EnroulementDeBudget);
                timerDeroulantBudget.Tick += new EventHandler(DeroulementDeBudget);
            }
        }

        // TODO: Dérouler proprement et joliment
        /* Création des boutons du menu déroulant */
        private void PremierChargementDeApplication(object sender, EventArgs e)
        {
                // Les timer

            timerDeroulantTransaction.Tick += new EventHandler(DeroulementDeTransaction);
            timerDeroulantTransaction.Interval = 1;
            timerDeroulantBudget.Tick += new EventHandler(DeroulementDeBudget);
            timerDeroulantBudget.Interval = 1;

            // Les polices d'écritures

            fonts.AddFontFile("..\\..\\..\\..\\Font\\Café Françoise.otf");
            lblTitre.Font = new System.Drawing.Font(fonts.Families[0], lblTitre.Font.Size);

                // Pour focus le premier bouton

            ActiveControl = _btnDeroulerTransaction;
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

        #region HOVER
        private void HoverQuitter(object sender, EventArgs e)
        {
            toolTip.Show("Quitte l'application.", picQuitter, 25, 0);
        }

        private void _HoverQuitter(object sender, EventArgs e)
        {
            toolTip.Show("", picQuitter);
        }

        private void HoverOption(object sender, EventArgs e)
        {
            toolTip.Show("Affiche les options.", picOption, 25, 0);
        }

        private void _HoverOption(object sender, EventArgs e)
        {
            toolTip.Show("", picOption);
        }
        #endregion
    }
}