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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEditer = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterPersonne = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlGauche = new System.Windows.Forms.Panel();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnDeroulerTransaction = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlHaut = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlGauche.SuspendLayout();
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
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFichier,
            this.menuStripEditer});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menuStripFichier
            // 
            resources.ApplyResources(this.menuStripFichier, "menuStripFichier");
            this.menuStripFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.menuStripFichier.Name = "menuStripFichier";
            // 
            // quitterToolStripMenuItem
            // 
            resources.ApplyResources(this.quitterToolStripMenuItem, "quitterToolStripMenuItem");
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.CliquerApplication);
            // 
            // menuStripEditer
            // 
            resources.ApplyResources(this.menuStripEditer, "menuStripEditer");
            this.menuStripEditer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStripEditer.Name = "menuStripEditer";
            // 
            // optionsToolStripMenuItem
            // 
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.NouveauFrmOption);
            // 
            // btnAjouterPersonne
            // 
            resources.ApplyResources(this.btnAjouterPersonne, "btnAjouterPersonne");
            this.btnAjouterPersonne.Name = "btnAjouterPersonne";
            this.btnAjouterPersonne.UseVisualStyleBackColor = true;
            this.btnAjouterPersonne.Click += new System.EventHandler(this.NouveauFrmAjouterPersonne);
            // 
            // lblTitre
            // 
            resources.ApplyResources(this.lblTitre, "lblTitre");
            this.lblTitre.Name = "lblTitre";
            // 
            // pnlGauche
            // 
            resources.ApplyResources(this.pnlGauche, "pnlGauche");
            this.pnlGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlGauche.Controls.Add(this.btn2);
            this.pnlGauche.Controls.Add(this.btnDeroulerTransaction);
            this.pnlGauche.Controls.Add(this.pnlLogo);
            this.pnlGauche.Name = "pnlGauche";
            // 
            // btn2
            // 
            resources.ApplyResources(this.btn2, "btn2");
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Name = "btn2";
            this.btn2.Tag = "";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btnDeroulerTransaction
            // 
            resources.ApplyResources(this.btnDeroulerTransaction, "btnDeroulerTransaction");
            this.btnDeroulerTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnDeroulerTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeroulerTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeroulerTransaction.ForeColor = System.Drawing.Color.White;
            this.btnDeroulerTransaction.Name = "btnDeroulerTransaction";
            this.btnDeroulerTransaction.Tag = "";
            this.btnDeroulerTransaction.UseVisualStyleBackColor = false;
            this.btnDeroulerTransaction.Click += new System.EventHandler(this.CliquerSurDeroulerTransaction);
            // 
            // pnlLogo
            // 
            resources.ApplyResources(this.pnlLogo, "pnlLogo");
            this.pnlLogo.BackgroundImage = global::miniProjet2017.Properties.Resources.logo;
            this.pnlLogo.Name = "pnlLogo";
            // 
            // pnlHaut
            // 
            resources.ApplyResources(this.pnlHaut, "pnlHaut");
            this.pnlHaut.Name = "pnlHaut";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHaut);
            this.Controls.Add(this.pnlGauche);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAjouterPersonne);
            this.Controls.Add(this.btnRecap);
            this.Controls.Add(this.btnAffichage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.PremierChargementDeApplication);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlGauche.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAffichage;
        private System.Windows.Forms.Button btnRecap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripFichier;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripEditer;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button btnAjouterPersonne;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlGauche;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlHaut;
        private System.Windows.Forms.Button btnDeroulerTransaction;
        private System.Windows.Forms.Button btn2;
    }
}

