namespace miniProjet2017
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAffichage = new System.Windows.Forms.Button();
            this.btnRecap = new System.Windows.Forms.Button();
            this.pnlGauche = new System.Windows.Forms.Panel();
            this.btnAjouterPersonne = new System.Windows.Forms.Button();
            this.btnDeroulerTransaction = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlHaut = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.picOption = new System.Windows.Forms.PictureBox();
            this.pnlGauche.SuspendLayout();
            this.pnlHaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAffichage
            // 
            resources.ApplyResources(this.btnAffichage, "btnAffichage");
            this.btnAffichage.Name = "btnAffichage";
            this.btnAffichage.UseVisualStyleBackColor = true;
            this.btnAffichage.Click += new System.EventHandler(this.NouveauFrmAffichage);
            // 
            // btnRecap
            // 
            resources.ApplyResources(this.btnRecap, "btnRecap");
            this.btnRecap.Name = "btnRecap";
            this.btnRecap.UseVisualStyleBackColor = true;
            this.btnRecap.Click += new System.EventHandler(this.NouveauFrmRecap);
            // 
            // pnlGauche
            // 
            this.pnlGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlGauche.Controls.Add(this.btnAjouterPersonne);
            this.pnlGauche.Controls.Add(this.btnDeroulerTransaction);
            this.pnlGauche.Controls.Add(this.pnlLogo);
            resources.ApplyResources(this.pnlGauche, "pnlGauche");
            this.pnlGauche.Name = "pnlGauche";
            this.pnlGauche.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CliqueSouris);
            this.pnlGauche.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeplacementSouris);
            this.pnlGauche.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LacherCliqueSouris);
            // 
            // btnAjouterPersonne
            // 
            this.btnAjouterPersonne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnAjouterPersonne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterPersonne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnAjouterPersonne, "btnAjouterPersonne");
            this.btnAjouterPersonne.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPersonne.Name = "btnAjouterPersonne";
            this.btnAjouterPersonne.Tag = "";
            this.btnAjouterPersonne.UseVisualStyleBackColor = false;
            this.btnAjouterPersonne.Click += new System.EventHandler(this.NouveauFrmAjouterPersonne);
            // 
            // btnDeroulerTransaction
            // 
            this.btnDeroulerTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnDeroulerTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeroulerTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnDeroulerTransaction, "btnDeroulerTransaction");
            this.btnDeroulerTransaction.ForeColor = System.Drawing.Color.White;
            this.btnDeroulerTransaction.Name = "btnDeroulerTransaction";
            this.btnDeroulerTransaction.Tag = "";
            this.btnDeroulerTransaction.UseVisualStyleBackColor = false;
            this.btnDeroulerTransaction.Click += new System.EventHandler(this.CliquerSurDeroulerTransaction);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::miniProjet2017.Properties.Resources.logo;
            resources.ApplyResources(this.pnlLogo, "pnlLogo");
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CliqueSouris);
            this.pnlLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeplacementSouris);
            this.pnlLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LacherCliqueSouris);
            // 
            // pnlHaut
            // 
            this.pnlHaut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlHaut.Controls.Add(this.lblTitre);
            this.pnlHaut.Controls.Add(this.picQuitter);
            this.pnlHaut.Controls.Add(this.picOption);
            resources.ApplyResources(this.pnlHaut, "pnlHaut");
            this.pnlHaut.Name = "pnlHaut";
            this.pnlHaut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CliqueSouris);
            this.pnlHaut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeplacementSouris);
            this.pnlHaut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LacherCliqueSouris);
            // 
            // lblTitre
            // 
            resources.ApplyResources(this.lblTitre, "lblTitre");
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CliqueSouris);
            this.lblTitre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeplacementSouris);
            this.lblTitre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LacherCliqueSouris);
            // 
            // picQuitter
            // 
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.croixQuitter;
            resources.ApplyResources(this.picQuitter, "picQuitter");
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.CliquerApplication);
            // 
            // picOption
            // 
            this.picOption.Image = global::miniProjet2017.Properties.Resources.engrenage;
            resources.ApplyResources(this.picOption, "picOption");
            this.picOption.Name = "picOption";
            this.picOption.TabStop = false;
            this.picOption.Click += new System.EventHandler(this.NouveauFrmOption);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.pnlHaut);
            this.Controls.Add(this.pnlGauche);
            this.Controls.Add(this.btnRecap);
            this.Controls.Add(this.btnAffichage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.PremierChargementDeApplication);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CliqueSouris);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeplacementSouris);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LacherCliqueSouris);
            this.pnlGauche.ResumeLayout(false);
            this.pnlHaut.ResumeLayout(false);
            this.pnlHaut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAffichage;
        private System.Windows.Forms.Button btnRecap;
        private System.Windows.Forms.Panel pnlGauche;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlHaut;
        private System.Windows.Forms.Button btnDeroulerTransaction;
        private System.Windows.Forms.Button btnAjouterPersonne;
        private System.Windows.Forms.PictureBox picOption;
        private System.Windows.Forms.PictureBox picQuitter;
        private System.Windows.Forms.Label lblTitre;
    }
}

