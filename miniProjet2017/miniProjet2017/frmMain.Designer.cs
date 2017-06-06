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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAffichage = new System.Windows.Forms.Button();
            this.btnRecap = new System.Windows.Forms.Button();
            this.pnlGauche = new System.Windows.Forms.Panel();
            this.btnDeroulerBudget = new System.Windows.Forms.Button();
            this.btnAjouterPersonne = new System.Windows.Forms.Button();
            this.btnSupprimerTransaction = new System.Windows.Forms.Button();
            this.btnModifierTransaction = new System.Windows.Forms.Button();
            this.btnAjouterTransaction = new System.Windows.Forms.Button();
            this._btnDeroulerTransaction = new System.Windows.Forms.Button();
            this.pnlHaut = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.picReduire = new System.Windows.Forms.PictureBox();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.picOption = new System.Windows.Forms.PictureBox();
            this.picVertePnlGauche1 = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picVertePnlGauche2 = new System.Windows.Forms.PictureBox();
            this.pnlGauche.SuspendLayout();
            this.pnlHaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReduire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVertePnlGauche1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVertePnlGauche2)).BeginInit();
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
            this.pnlGauche.Controls.Add(this.btnDeroulerBudget);
            this.pnlGauche.Controls.Add(this.picVertePnlGauche2);
            this.pnlGauche.Controls.Add(this.btnAjouterPersonne);
            this.pnlGauche.Controls.Add(this.picVertePnlGauche1);
            this.pnlGauche.Controls.Add(this.btnSupprimerTransaction);
            this.pnlGauche.Controls.Add(this.btnModifierTransaction);
            this.pnlGauche.Controls.Add(this.btnAjouterTransaction);
            this.pnlGauche.Controls.Add(this._btnDeroulerTransaction);
            this.pnlGauche.Controls.Add(this.pnlLogo);
            resources.ApplyResources(this.pnlGauche, "pnlGauche");
            this.pnlGauche.Name = "pnlGauche";
            this.pnlGauche.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CliqueSouris);
            this.pnlGauche.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeplacementSouris);
            this.pnlGauche.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LacherCliqueSouris);
            // 
            // btnDeroulerBudget
            // 
            this.btnDeroulerBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnDeroulerBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDeroulerBudget, "btnDeroulerBudget");
            this.btnDeroulerBudget.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeroulerBudget.ForeColor = System.Drawing.Color.White;
            this.btnDeroulerBudget.Name = "btnDeroulerBudget";
            this.btnDeroulerBudget.Tag = "derouler;3";
            this.btnDeroulerBudget.UseVisualStyleBackColor = false;
            this.btnDeroulerBudget.Click += new System.EventHandler(this.CliquerSurDeroulerBudget);
            // 
            // btnAjouterPersonne
            // 
            this.btnAjouterPersonne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnAjouterPersonne.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAjouterPersonne, "btnAjouterPersonne");
            this.btnAjouterPersonne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjouterPersonne.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPersonne.Name = "btnAjouterPersonne";
            this.btnAjouterPersonne.Tag = "derouler;3";
            this.btnAjouterPersonne.UseVisualStyleBackColor = false;
            this.btnAjouterPersonne.Click += new System.EventHandler(this.NouveauFrmAjouterPersonne);
            // 
            // btnSupprimerTransaction
            // 
            this.btnSupprimerTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnSupprimerTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSupprimerTransaction, "btnSupprimerTransaction");
            this.btnSupprimerTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSupprimerTransaction.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerTransaction.Name = "btnSupprimerTransaction";
            this.btnSupprimerTransaction.TabStop = false;
            this.btnSupprimerTransaction.Tag = "derouler;0";
            this.btnSupprimerTransaction.UseVisualStyleBackColor = false;
            this.btnSupprimerTransaction.Click += new System.EventHandler(this.NouveauFrmSupprTransac);
            // 
            // btnModifierTransaction
            // 
            this.btnModifierTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnModifierTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnModifierTransaction, "btnModifierTransaction");
            this.btnModifierTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModifierTransaction.ForeColor = System.Drawing.Color.White;
            this.btnModifierTransaction.Name = "btnModifierTransaction";
            this.btnModifierTransaction.TabStop = false;
            this.btnModifierTransaction.Tag = "derouler;0";
            this.btnModifierTransaction.UseVisualStyleBackColor = false;
            this.btnModifierTransaction.Click += new System.EventHandler(this.NouveauFrmModiTransac);
            // 
            // btnAjouterTransaction
            // 
            this.btnAjouterTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnAjouterTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAjouterTransaction, "btnAjouterTransaction");
            this.btnAjouterTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjouterTransaction.ForeColor = System.Drawing.Color.White;
            this.btnAjouterTransaction.Name = "btnAjouterTransaction";
            this.btnAjouterTransaction.TabStop = false;
            this.btnAjouterTransaction.Tag = "derouler;0";
            this.btnAjouterTransaction.UseVisualStyleBackColor = false;
            this.btnAjouterTransaction.Click += new System.EventHandler(this.NouveauFrmAjoutTransac);
            // 
            // _btnDeroulerTransaction
            // 
            this._btnDeroulerTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this._btnDeroulerTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this._btnDeroulerTransaction, "_btnDeroulerTransaction");
            this._btnDeroulerTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._btnDeroulerTransaction.ForeColor = System.Drawing.Color.White;
            this._btnDeroulerTransaction.Name = "_btnDeroulerTransaction";
            this._btnDeroulerTransaction.Tag = "derouler;0";
            this._btnDeroulerTransaction.UseVisualStyleBackColor = false;
            this._btnDeroulerTransaction.Click += new System.EventHandler(this.CliquerSurDeroulerTransaction);
            // 
            // pnlHaut
            // 
            this.pnlHaut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlHaut.Controls.Add(this.picReduire);
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
            // picReduire
            // 
            resources.ApplyResources(this.picReduire, "picReduire");
            this.picReduire.Name = "picReduire";
            this.picReduire.TabStop = false;
            this.picReduire.Click += new System.EventHandler(this.CliquerSurReduire);
            // 
            // picQuitter
            // 
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.croixFermer;
            resources.ApplyResources(this.picQuitter, "picQuitter");
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.QuitterApplication);
            this.picQuitter.MouseLeave += new System.EventHandler(this._HoverQuitter);
            this.picQuitter.MouseHover += new System.EventHandler(this.HoverQuitter);
            // 
            // picOption
            // 
            this.picOption.Image = global::miniProjet2017.Properties.Resources.engrenage;
            resources.ApplyResources(this.picOption, "picOption");
            this.picOption.Name = "picOption";
            this.picOption.TabStop = false;
            this.picOption.Click += new System.EventHandler(this.NouveauFrmOption);
            this.picOption.MouseLeave += new System.EventHandler(this._HoverOption);
            this.picOption.MouseHover += new System.EventHandler(this.HoverOption);
            // 
            // picVertePnlGauche1
            // 
            resources.ApplyResources(this.picVertePnlGauche1, "picVertePnlGauche1");
            this.picVertePnlGauche1.Image = global::miniProjet2017.Properties.Resources.verteSeparateurPanel;
            this.picVertePnlGauche1.Name = "picVertePnlGauche1";
            this.picVertePnlGauche1.TabStop = false;
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
            // picVertePnlGauche2
            // 
            resources.ApplyResources(this.picVertePnlGauche2, "picVertePnlGauche2");
            this.picVertePnlGauche2.Image = global::miniProjet2017.Properties.Resources.verteSeparateurPanel;
            this.picVertePnlGauche2.Name = "picVertePnlGauche2";
            this.picVertePnlGauche2.TabStop = false;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(95)))));
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
            ((System.ComponentModel.ISupportInitialize)(this.picReduire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVertePnlGauche1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVertePnlGauche2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAffichage;
        private System.Windows.Forms.Button btnRecap;
        private System.Windows.Forms.Panel pnlGauche;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlHaut;
        private System.Windows.Forms.Button _btnDeroulerTransaction;
        private System.Windows.Forms.PictureBox picOption;
        private System.Windows.Forms.PictureBox picQuitter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnDeroulerBudget;
        private System.Windows.Forms.PictureBox picReduire;
        private System.Windows.Forms.Button btnAjouterPersonne;
        private System.Windows.Forms.Button btnAjouterTransaction;
        private System.Windows.Forms.Button btnModifierTransaction;
        private System.Windows.Forms.Button btnSupprimerTransaction;
        private System.Windows.Forms.PictureBox picVertePnlGauche1;
        private System.Windows.Forms.PictureBox picVertePnlGauche2;
    }
}

