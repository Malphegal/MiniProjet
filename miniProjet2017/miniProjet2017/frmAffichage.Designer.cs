namespace miniProjet2017
{
    partial class frmAffichage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAffichage));
            this.gridViewPDF = new System.Windows.Forms.DataGridView();
            this.picBordure = new System.Windows.Forms.PictureBox();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPDF = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gridViewClone = new System.Windows.Forms.DataGridView();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClone)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewPDF
            // 
            this.gridViewPDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPDF.Location = new System.Drawing.Point(26, 102);
            this.gridViewPDF.Name = "gridViewPDF";
            this.gridViewPDF.Size = new System.Drawing.Size(728, 293);
            this.gridViewPDF.TabIndex = 0;
            this.gridViewPDF.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CliqueDroitSurUneCaseDuDataGridView);
            // 
            // picBordure
            // 
            this.picBordure.Image = ((System.Drawing.Image)(resources.GetObject("picBordure.Image")));
            this.picBordure.Location = new System.Drawing.Point(0, 0);
            this.picBordure.Name = "picBordure";
            this.picBordure.Size = new System.Drawing.Size(780, 420);
            this.picBordure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBordure.TabIndex = 1;
            this.picBordure.TabStop = false;
            // 
            // picQuitter
            // 
            this.picQuitter.BackColor = System.Drawing.Color.Transparent;
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.flecheRetour;
            this.picQuitter.Location = new System.Drawing.Point(685, 12);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(69, 68);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 2;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.QuitterFrmAffichage);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 48);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.modifierToolStripMenuItem.Text = "Modifier...";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.ContextStripModifier);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer...";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.ContextStripSupprimer);
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(42, 27);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(123, 35);
            this.btnPDF.TabIndex = 3;
            this.btnPDF.Text = "Génération du PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.GenerationDuPDF);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(319, 27);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(175, 29);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Affichage[OFF]";
            // 
            // gridViewClone
            // 
            this.gridViewClone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewClone.Location = new System.Drawing.Point(0, 0);
            this.gridViewClone.Name = "gridViewClone";
            this.gridViewClone.Size = new System.Drawing.Size(0, 0);
            this.gridViewClone.TabIndex = 5;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(281, 76);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(100, 20);
            this.txtRecherche.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.gridViewClone);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.gridViewPDF);
            this.Controls.Add(this.picBordure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(780, 420);
            this.MinimumSize = new System.Drawing.Size(780, 420);
            this.Name = "frmAffichage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAffichage";
            this.Load += new System.EventHandler(this.DebutDuFormulaire);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBordure;
        private System.Windows.Forms.PictureBox picQuitter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView gridViewPDF;
        private System.Windows.Forms.DataGridView gridViewClone;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button button1;
    }
}