using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMD = System.Data.OleDb.OleDbCommand;
using System.IO;

namespace miniProjet2017
{
    public partial class frmAffichage : Form
    {
        //DataGridView dataGridViewClone = new DataGridView();

        public frmAffichage()
        {
            InitializeComponent();
            Scale(new SizeF(frmMain.resolutionScale, frmMain.resolutionScale));
            frmMain.RedimensionnerLesControls(this, frmMain.resolutionScale);
        }

        /* Remplir le contenu de la DataGridView */
        private void DebutDuFormulaire(object sender, EventArgs e)
        {
            picQuitter.Parent = picBordure;
            flecheRetour = picQuitter.Image;
            // Création de la table en local

            DataSet ds = new DataSet();
            new OleDbDataAdapter(new CMD(@"SELECT t.*, t2.libType
                                            FROM [Transaction] t, TypeTransaction t2
                                            WHERE t2.codeType = t.type", frmMain.con)).Fill(ds, "_Transaction");

            if (ds.Tables["_Transaction"].Rows.Count != 0)
            {
                    // Ajout du contenu du DataGridView

                gridViewPDF.DataSource = ds.Tables["_Transaction"];
                gridViewPDF.Columns[1].Width += 60;
                gridViewPDF.Columns[2].Width += 20;
                gridViewPDF.Columns[3].Width -= 45;
                gridViewPDF.Columns[4].Width -= 40;
                gridViewPDF.Columns[5].Width -= 45;
                gridViewPDF.Columns[6].Width -= 65;

                gridViewClone.DataSource = ds.Tables["_Transaction"];
                gridViewClone.Columns.RemoveAt(6);
                gridViewClone.Columns.RemoveAt(0);
            }
            else {
                MessageBox.Show("Il n'y a pas de transaction dans la base de donnée !\nFermeture du formulaire");
                Close();
            }
        }

        /* Ferme ce formulaire */
        private void QuitterFrmAffichage(object sender, EventArgs e)
        {
            Close();
        }

        static System.Drawing.Image flecheRetour_clair = new Bitmap("..\\..\\Resources\\flecheRetour_clair.png");
        static System.Drawing.Image flecheRetour;
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

        /* Effectuer un clique droit sur une des cellules du dataGridView */
        private void CliqueDroitSurUneCaseDuDataGridView(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(Cursor.Position);
        }

        /* Ouvre le formulaire pour modifier une transaction */
        // TODO: Afficher la bonne transaction
        private void ContextStripModifier(object sender, EventArgs e)
        {
            Close();
            new frmModiTransac().ShowDialog();
        }

        /* Ouvre le formulaire pour supprimer une transaction */
        // TODO: Afficher la bonne transaction
        private void ContextStripSupprimer(object sender, EventArgs e)
        {
            Close();
            new frmSupprTransac().ShowDialog();
        }

        private void GenerationDuPDF(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Filter = "Emplacement du fichier PDF | *.pdf";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
                CliquerSurBoutonPDF(saveFileDialog1.FileName);
        }

        /* Création du PDF */
        // TODO: Changer la date, pour choisir un mois d'une année
        // TODO: dataGridView -> Pouvoir faire une recherche sur la date, description, ...
        private void CliquerSurBoutonPDF(string cheminDuPDF)
        {
            string mois = "Avril"; // TODO: A VOIR

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            doc.SetPageSize(iTextSharp.text.PageSize.A4); //met le PDF en format A4 
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(cheminDuPDF, FileMode.Create));
            doc.Open(); //ouvre le document

            PdfPTable dtgw = new PdfPTable(gridViewClone.Columns.Count);

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

            for (int i = 0; i < gridViewClone.Rows.Count; i++)
            {
                for (int j = 0; j < gridViewClone.Columns.Count; j++)
                {
                    if (gridViewClone[j, i].Value != null)
                    {
                        table.AddCell(new Phrase(gridViewClone[j, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table); //rajoute la table avec les informations de la dataGridView

            double nbDepen = 0;
            double nbRecet = 0;
            for (int k = 0; k < gridViewClone.Rows.Count; k++)
            {
                //if (gridViewPDF[3, k].Value.ToString() == "False")
                if (!Convert.ToBoolean(gridViewClone[3, k].Value))
                {
                    nbDepen += Convert.ToDouble((gridViewClone[2, k].Value));
                }
                else
                {
                    nbRecet += Convert.ToDouble((gridViewClone[2, k].Value));
                }
            }

            double restPerc = 0;
            for (int l = 0; l < gridViewClone.Rows.Count; l++)
            {
                //if (gridViewPDF[4, l].Value.ToString() == "True")
                if (Convert.ToBoolean(gridViewClone[4, l].Value))
                {
                    restPerc += Convert.ToDouble((gridViewClone[2, l].Value));
                }
            }

            double sommDepen = nbRecet - nbDepen + restPerc;
            int nbTransac = gridViewClone.Rows.Count - 1; // -1 -> car ligne vide à la fin en trop

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
            iTextSharp.text.Image JPG = iTextSharp.text.Image.GetInstance("..\\..\\Resources\\logo.jpg");
            JPG.ScalePercent(10f);
            JPG.SetAbsolutePosition(doc.PageSize.Width - 36f - 36f, doc.PageSize.Height - 36f - 216.6f);
            doc.Add(JPG);

            MessageBox.Show("Le document PDF à été créé !\n\n");

            doc.Close(); //ferme le document
        }

        private void RechercheSurDescription(object sender, EventArgs e)
        {
            if (txtRecherche.Text.Length > 0)
                (gridViewPDF.DataSource as DataTable).DefaultView.RowFilter = string.Format("[description] like '%{0}%'",
                    txtRecherche.Text.Trim().Replace("'", "''"));
            else
                (gridViewPDF.DataSource as DataTable).DefaultView.RowFilter = null;
        }
    }
}