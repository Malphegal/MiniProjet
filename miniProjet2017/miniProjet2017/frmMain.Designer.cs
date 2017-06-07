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
            this.btnBudgetRecap = new System.Windows.Forms.Button();
            this.btnFrm_3 = new System.Windows.Forms.Button();
            this.btnPostePonctuel = new System.Windows.Forms.Button();
            this.btnPostFixe = new System.Windows.Forms.Button();
            this.btnDeroulerBudget = new System.Windows.Forms.Button();
            this.btnSupprimerPersonne = new System.Windows.Forms.Button();
            this.btnAjouterPersonne = new System.Windows.Forms.Button();
            this.btnDeroulerPersonne = new System.Windows.Forms.Button();
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
            this.picVertePnlGauche2 = new System.Windows.Forms.PictureBox();
            this.picVertePnlGauche1 = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlGauche.SuspendLayout();
            this.pnlHaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReduire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVertePnlGauche2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVertePnlGauche1)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            resources.ApplyResources(this.pnlGauche, "pnlGauche");
            this.pnlGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlGauche.Controls.Add(this.btnBudgetRecap);
            this.pnlGauche.Controls.Add(this.btnFrm_3);
            this.pnlGauche.Controls.Add(this.btnPostePonctuel);
            this.pnlGauche.Controls.Add(this.btnPostFixe);
            this.pnlGauche.Controls.Add(this.btnDeroulerBudget);
            this.pnlGauche.Controls.Add(this.picVertePnlGauche2);
            this.pnlGauche.Controls.Add(this.btnSupprimerPersonne);
            this.pnlGauche.Controls.Add(this.btnAjouterPersonne);
            this.pnlGauche.Controls.Add(this.btnDeroulerPersonne);
            this.pnlGauche.Controls.Add(this.picVertePnlGauche1);
            this.pnlGauche.Controls.Add(this.btnSupprimerTransaction);
            this.pnlGauche.Controls.Add(this.btnModifierTransaction);
            this.pnlGauche.Controls.Add(this.btnAjouterTransaction);
            this.pnlGauche.Controls.Add(this._btnDeroulerTransaction);
            this.pnlGauche.Controls.Add(this.pnlLogo);
            this.pnlGauche.Name = "pnlGauche";
            this.pnlGauche.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CliqueSouris);
            this.pnlGauche.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeplacementSouris);
            this.pnlGauche.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LacherCliqueSouris);
            // 
            // btnBudgetRecap
            // 
            this.btnBudgetRecap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnBudgetRecap.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBudgetRecap, "btnBudgetRecap");
            this.btnBudgetRecap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBudgetRecap.ForeColor = System.Drawing.Color.Salmon;
            this.btnBudgetRecap.Name = "btnBudgetRecap";
            this.btnBudgetRecap.TabStop = false;
            this.btnBudgetRecap.Tag = "";
            this.btnBudgetRecap.UseVisualStyleBackColor = false;
            this.btnBudgetRecap.Click += new System.EventHandler(this.NouveauBudgetRecap);
            // 
            // btnFrm_3
            // 
            this.btnFrm_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnFrm_3.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnFrm_3, "btnFrm_3");
            this.btnFrm_3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFrm_3.ForeColor = System.Drawing.Color.Salmon;
            this.btnFrm_3.Name = "btnFrm_3";
            this.btnFrm_3.TabStop = false;
            this.btnFrm_3.Tag = "";
            this.btnFrm_3.UseVisualStyleBackColor = false;
            this.btnFrm_3.Click += new System.EventHandler(this.NouveauFrm3);
            // 
            // btnPostePonctuel
            // 
            this.btnPostePonctuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnPostePonctuel.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPostePonctuel, "btnPostePonctuel");
            this.btnPostePonctuel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPostePonctuel.ForeColor = System.Drawing.Color.Salmon;
            this.btnPostePonctuel.Name = "btnPostePonctuel";
            this.btnPostePonctuel.TabStop = false;
            this.btnPostePonctuel.Tag = "";
            this.btnPostePonctuel.UseVisualStyleBackColor = false;
            this.btnPostePonctuel.Click += new System.EventHandler(this.NouveauFrmPostePonctuel);
            // 
            // btnPostFixe
            // 
            this.btnPostFixe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnPostFixe.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPostFixe, "btnPostFixe");
            this.btnPostFixe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPostFixe.ForeColor = System.Drawing.Color.Salmon;
            this.btnPostFixe.Name = "btnPostFixe";
            this.btnPostFixe.TabStop = false;
            this.btnPostFixe.Tag = "";
            this.btnPostFixe.UseVisualStyleBackColor = false;
            this.btnPostFixe.Click += new System.EventHandler(this.NouveauFrmPostFixe);
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
            // btnSupprimerPersonne
            // 
            this.btnSupprimerPersonne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnSupprimerPersonne.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSupprimerPersonne, "btnSupprimerPersonne");
            this.btnSupprimerPersonne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSupprimerPersonne.ForeColor = System.Drawing.Color.Salmon;
            this.btnSupprimerPersonne.Name = "btnSupprimerPersonne";
            this.btnSupprimerPersonne.TabStop = false;
            this.btnSupprimerPersonne.Tag = "";
            this.btnSupprimerPersonne.UseVisualStyleBackColor = false;
            this.btnSupprimerPersonne.Click += new System.EventHandler(this.NouveauFrmSupprPersonne);
            // 
            // btnAjouterPersonne
            // 
            this.btnAjouterPersonne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnAjouterPersonne.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAjouterPersonne, "btnAjouterPersonne");
            this.btnAjouterPersonne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjouterPersonne.ForeColor = System.Drawing.Color.Salmon;
            this.btnAjouterPersonne.Name = "btnAjouterPersonne";
            this.btnAjouterPersonne.TabStop = false;
            this.btnAjouterPersonne.Tag = "";
            this.btnAjouterPersonne.UseVisualStyleBackColor = false;
            this.btnAjouterPersonne.Click += new System.EventHandler(this.NouveauFrmAjouterPersonne);
            // 
            // btnDeroulerPersonne
            // 
            this.btnDeroulerPersonne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnDeroulerPersonne.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDeroulerPersonne, "btnDeroulerPersonne");
            this.btnDeroulerPersonne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeroulerPersonne.ForeColor = System.Drawing.Color.White;
            this.btnDeroulerPersonne.Name = "btnDeroulerPersonne";
            this.btnDeroulerPersonne.Tag = "derouler;0";
            this.btnDeroulerPersonne.UseVisualStyleBackColor = false;
            this.btnDeroulerPersonne.Click += new System.EventHandler(this.CliquerSurDeroulerPersonne);
            // 
            // btnSupprimerTransaction
            // 
            this.btnSupprimerTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnSupprimerTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSupprimerTransaction, "btnSupprimerTransaction");
            this.btnSupprimerTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSupprimerTransaction.ForeColor = System.Drawing.Color.Salmon;
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
            this.btnModifierTransaction.ForeColor = System.Drawing.Color.Salmon;
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
            this.btnAjouterTransaction.ForeColor = System.Drawing.Color.Salmon;
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
            // picVertePnlGauche2
            // 
            resources.ApplyResources(this.picVertePnlGauche2, "picVertePnlGauche2");
            this.picVertePnlGauche2.Image = global::miniProjet2017.Properties.Resources.verteSeparateurPanel;
            this.picVertePnlGauche2.Name = "picVertePnlGauche2";
            this.picVertePnlGauche2.TabStop = false;
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
            this.pnlLogo.BackgroundImage = global::miniProjet2017.Properties.Resources.bill_rain;
            resources.ApplyResources(this.pnlLogo, "pnlLogo");
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CliqueSouris);
            this.pnlLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeplacementSouris);
            this.pnlLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LacherCliqueSouris);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::miniProjet2017.Properties.Resources.Minion;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.InitialImage = global::miniProjet2017.Properties.Resources.Minion;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.picVertePnlGauche2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVertePnlGauche1)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAffichage;
        private System.Windows.Forms.Button btnRecap;
        private System.Windows.Forms.Panel pnlGauche;
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
        private System.Windows.Forms.Button btnPostFixe;
        private System.Windows.Forms.Button btnFrm_3;
        private System.Windows.Forms.Button btnPostePonctuel;
        private System.Windows.Forms.Button btnBudgetRecap;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeroulerPersonne;
        private System.Windows.Forms.Button btnSupprimerPersonne;
    }
}

