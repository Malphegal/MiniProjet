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

namespace miniProjet2017
{
    public partial class frmMain : Form
    {
        static System.Drawing.Text.PrivateFontCollection fonts = new System.Drawing.Text.PrivateFontCollection();

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
            new frmAjoutTransac().ShowDialog();
        }

        private void NouveauFrmAffichage(object sender, EventArgs e)
        {
            new frmAffichage().ShowDialog();
        }

        private void NouveauFrmModiTransac(object sender, EventArgs e)
        {
            new frmModiTransac().ShowDialog();
        }

        private void NouveauFrmRecap(object sender, EventArgs e)
        {
            new frmRecap().ShowDialog();
        }

        private void NouveauFrmSupprTransac(object sender, EventArgs e)
        {
            new frmSupprTransac().ShowDialog();
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
            foreach (Control c in Controls)
                c.Enabled = false;
            new frmAjouterPersonne().ShowDialog();
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        private void NouveauFrmPostFixe(object sender, EventArgs e)
        {
            new frmPostFixe().ShowDialog();
        }

        private void NouveauFrmPostePonctuel(object sender, EventArgs e)
        {
            new frmPostePonctuel().ShowDialog();
        }

        private void NouveauFrm3(object sender, EventArgs e)
        {
            new frm_3().ShowDialog();
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
                        b.Left += 220;
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
                        b.Left -= 220;
                }
                btnDeroulerTransaction.Text = btnDeroulerTransaction.Text.Replace('↑', '↓');
            }
        }

        /* Cliquer sur le bouton des budgets dans le panel de gauche */
        static bool deroulerBudget = false;
        private void CliquerSurDeroulerBudget(object sender, EventArgs e)
        {
            if (deroulerBudget = !deroulerBudget) {
                foreach (Button b in pnlGauche.Controls.OfType<Button>())
                {
                    if (b.Name == "btnPostFixe"
                        || b.Name == "btnPostePonctuel"
                        || b.Name == "btnFrm_3")
                        b.Left += 220;
                }
                btnDeroulerBudget.Text = btnDeroulerBudget.Text.Replace('↓', '↑');
            }
            else {
                foreach (Button b in pnlGauche.Controls.OfType<Button>())
                {
                    if (b.Name == "btnPostFixe"
                        || b.Name == "btnPostePonctuel"
                        || b.Name == "btnFrm_3")
                        b.Left -= 220;
                }
                btnDeroulerBudget.Text = btnDeroulerBudget.Text.Replace('↑', '↓');
            }
        }

        // TODO: Dérouler proprement et joliment
        /* Création des boutons du menu déroulant */
        private void PremierChargementDeApplication(object sender, EventArgs e)
        {
                // Font

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
                TabIndex = 2
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
                TabIndex = 2
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
                TabIndex = 2
            };
            b.FlatAppearance.BorderColor = Color.Black;
            b.FlatAppearance.BorderSize = 2;
            b.Click += new EventHandler(NouveauFrm3);

            // Pour focus le premier bouton

            ActiveControl = btnDeroulerTransaction;
        }

        /* Initialise les valeurs par défaut du formulaire des options */
        void InitValeurOption()
        {
            // Fichier de stockage

            string[] fichier = System.IO.File.ReadAllLines(@"..\..\Resources\ValeurParDefaut.txt");

            // [1] == BDD

            frmOption.pourcentageSMS = Convert.ToByte(fichier[3]);

            frmOption.valeurResolution = Convert.ToByte(fichier[5]);

            // Mise à jour de la résolution

            resolutionScale = (0.6F + 0.2F * frmOption.valeurResolution);
            privateResolutionScale = resolutionScale;
            Scale(new SizeF(resolutionScale, resolutionScale));
            RedimensionnerLesControls(this, resolutionScale);
        }
        public static float resolutionScale;
        static float privateResolutionScale;
        // TODO: changer les valeurs
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


    /*class PDF_TEST
    {
        private void button1_Click(object sender, EventArgs e)
        {
            string mois = "Avril";

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            doc.SetPageSize(iTextSharp.text.PageSize.A4); //met le PDF en format A4 
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test omega.pdf", FileMode.Create));
            doc.Open(); //ouvre le document


            PdfPTable dtgw = new PdfPTable(dataGridView1.Columns.Count);

            Paragraph ligne = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLUE, Element.ALIGN_LEFT, 1))); //construction d'une ligne

            Paragraph titre = new Paragraph(); //créé un texte souligné
            Chunk text = new Chunk("Récapitulatif du mois : " + mois);
            text.SetUnderline(0.5f, -2f);
            titre.Add(text);
            doc.Add(titre);

            doc.Add(Chunk.NEWLINE); // saute une ligne

            doc.Add(ligne); //rajoute une ligne bleue

            Paragraph Dep = new Paragraph("Dépenses");
            doc.Add(Dep);

            doc.Add(Chunk.NEWLINE);

            PdfPTable table = new PdfPTable(6);
            table.AddCell("Date de la transaction");
            table.AddCell("Description");
            table.AddCell("Montant");
            table.AddCell("Recette ?");
            table.AddCell("Perçu ?");
            table.AddCell("Type de dépense");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView1[j, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table); //rajoute la table avec les informations de la dataGridView

            double nbDepen = 0;
            double nbRecet = 0;
            for (int k = 0; k < dataGridView1.Rows.Count; k++)
            {
                if (dataGridView1[3, k].Value.ToString() == "False")
                {
                    nbDepen += (double)(dataGridView1[2, k].Value);
                }
                else
                {
                    nbRecet += (double)(dataGridView1[2, k].Value);
                }
            }

            double restPerc = 0;
            for (int l = 0; l < dataGridView1.Rows.Count; l++)
            {
                if (dataGridView1[4, l].Value.ToString() == "True")
                {
                    restPerc += (double)(dataGridView1[2, l].Value);
                }
            }



            double sommDepen = nbRecet - nbDepen + restPerc;



            int nbTransac = dataGridView1.Rows.Count;

            doc.Add(Chunk.NEWLINE);

            Paragraph p = new Paragraph();

            p.Add(ligne); //rajoute une ligne bleue

            Chunk recet = new Chunk("Recette : " + nbRecet);
            p.Add(recet);

            p.Add(Chunk.NEWLINE);
            p.Add(Chunk.NEWLINE);

            p.Add(ligne); //rajoute une ligne bleue

            Chunk depen = new Chunk("Dépenses : " + nbDepen);
            p.Add(depen);
            p.Add(Chunk.NEWLINE);
            p.Add(Chunk.NEWLINE);

            p.Add(ligne); //rajoute une ligne bleue

            Chunk perc = new Chunk("Reste à percevoir : " + restPerc);
            p.Add(perc);
            p.Add(Chunk.NEWLINE);
            p.Add(Chunk.NEWLINE);

            p.Add(ligne); //rajoute une ligne bleue

            Chunk somm = new Chunk("Somme totale dépensée : " + sommDepen);
            p.Add(somm);
            p.Add(Chunk.NEWLINE);
            p.Add(Chunk.NEWLINE);

            p.Add(ligne); //rajoute une ligne bleue

            Chunk trans = new Chunk("Nombre de transaction : " + nbTransac);
            p.Add(trans);
            p.Add(Chunk.NEWLINE);
            p.Add(Chunk.NEWLINE);

            p.Add(ligne); //rajoute une ligne bleue

            doc.Add(p);


            //rajoute, redimensionne et positionne une image
            iTextSharp.text.Image JPG = iTextSharp.text.Image.GetInstance("phoenix.jpg");
            JPG.ScalePercent(10f);
            JPG.SetAbsolutePosition(doc.PageSize.Width - 36f - 36f, doc.PageSize.Height - 36f - 216.6f);
            doc.Add(JPG);

            doc.Close(); //ferme le document
        }
    }*/
}