namespace miniProjet2017
{
    partial class frmModiTransac
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.lblRecette = new System.Windows.Forms.Label();
            this.chkPerçu = new System.Windows.Forms.CheckBox();
            this.chkRecette = new System.Windows.Forms.CheckBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.lblDescTransac = new System.Windows.Forms.Label();
            this.lblTransac = new System.Windows.Forms.Label();
            this.calTransac = new System.Windows.Forms.MonthCalendar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAideDate = new System.Windows.Forms.Label();
            this.lblAideDescri = new System.Windows.Forms.Label();
            this.lblAideMontant = new System.Windows.Forms.Label();
            this.lblAideRecette = new System.Windows.Forms.Label();
            this.lblAideType = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboListeTransaction = new System.Windows.Forms.ComboBox();
            this.lblListeTransaction = new System.Windows.Forms.Label();
            this.lblChoixPersonne = new System.Windows.Forms.Label();
            this.btnChoixPersonne = new System.Windows.Forms.Button();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.txtDescTran = new System.Windows.Forms.TextBox();
            this.grb1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(623, 476);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(110, 53);
            this.btnQuitter.TabIndex = 30;
            this.btnQuitter.Text = "Retour à la page principal";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.QuitterCeFormulaire);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.Enabled = false;
            this.btnModifier.Location = new System.Drawing.Point(24, 469);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(103, 66);
            this.btnModifier.TabIndex = 28;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.ModifierLaTransaction);
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.lblRecette);
            this.grb1.Controls.Add(this.chkPerçu);
            this.grb1.Controls.Add(this.chkRecette);
            this.grb1.Location = new System.Drawing.Point(24, 333);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(281, 43);
            this.grb1.TabIndex = 27;
            this.grb1.TabStop = false;
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.Enabled = false;
            this.lblRecette.ForeColor = System.Drawing.Color.Gray;
            this.lblRecette.Location = new System.Drawing.Point(24, 13);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(50, 13);
            this.lblRecette.TabIndex = 10;
            this.lblRecette.Text = "Dépense";
            // 
            // chkPerçu
            // 
            this.chkPerçu.AutoSize = true;
            this.chkPerçu.Enabled = false;
            this.chkPerçu.Location = new System.Drawing.Point(150, 12);
            this.chkPerçu.Name = "chkPerçu";
            this.chkPerçu.Size = new System.Drawing.Size(54, 17);
            this.chkPerçu.TabIndex = 9;
            this.chkPerçu.Text = "Perçu";
            this.chkPerçu.UseVisualStyleBackColor = true;
            // 
            // chkRecette
            // 
            this.chkRecette.AutoSize = true;
            this.chkRecette.Enabled = false;
            this.chkRecette.Location = new System.Drawing.Point(80, 12);
            this.chkRecette.Name = "chkRecette";
            this.chkRecette.Size = new System.Drawing.Size(64, 17);
            this.chkRecette.TabIndex = 8;
            this.chkRecette.Text = "Recette";
            this.chkRecette.UseVisualStyleBackColor = true;
            this.chkRecette.Click += new System.EventHandler(this.CliquerSurChkRecette);
            // 
            // cboType
            // 
            this.cboType.Enabled = false;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(174, 389);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 26;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Enabled = false;
            this.lblType.Location = new System.Drawing.Point(27, 389);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 25;
            this.lblType.Text = "Type";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Enabled = false;
            this.lblMontant.Location = new System.Drawing.Point(29, 304);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 24;
            this.lblMontant.Text = "Montant";
            // 
            // txtMontant
            // 
            this.txtMontant.Enabled = false;
            this.txtMontant.Location = new System.Drawing.Point(197, 297);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 20);
            this.txtMontant.TabIndex = 23;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisirUnMontant);
            // 
            // lblDescTransac
            // 
            this.lblDescTransac.AutoSize = true;
            this.lblDescTransac.Enabled = false;
            this.lblDescTransac.Location = new System.Drawing.Point(29, 245);
            this.lblDescTransac.Name = "lblDescTransac";
            this.lblDescTransac.Size = new System.Drawing.Size(141, 13);
            this.lblDescTransac.TabIndex = 22;
            this.lblDescTransac.Text = "Description de la transaction";
            // 
            // lblTransac
            // 
            this.lblTransac.AutoSize = true;
            this.lblTransac.Enabled = false;
            this.lblTransac.Location = new System.Drawing.Point(29, 52);
            this.lblTransac.Name = "lblTransac";
            this.lblTransac.Size = new System.Drawing.Size(111, 13);
            this.lblTransac.TabIndex = 20;
            this.lblTransac.Text = "Date de la transaction";
            // 
            // calTransac
            // 
            this.calTransac.Enabled = false;
            this.calTransac.Location = new System.Drawing.Point(197, 52);
            this.calTransac.MaxSelectionCount = 1;
            this.calTransac.Name = "calTransac";
            this.calTransac.TabIndex = 19;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(770, 24);
            this.menuStrip.TabIndex = 31;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aideToolStripMenuItem.Text = "Aide...";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.CliquerSurAideModif);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.quitterToolStripMenuItem.Text = "Quitter...";
            // 
            // lblAideDate
            // 
            this.lblAideDate.AutoSize = true;
            this.lblAideDate.Location = new System.Drawing.Point(469, 118);
            this.lblAideDate.Name = "lblAideDate";
            this.lblAideDate.Size = new System.Drawing.Size(35, 13);
            this.lblAideDate.TabIndex = 37;
            this.lblAideDate.Tag = "Aidelbl1";
            this.lblAideDate.Text = "label1";
            this.lblAideDate.Visible = false;
            // 
            // lblAideDescri
            // 
            this.lblAideDescri.AutoSize = true;
            this.lblAideDescri.Location = new System.Drawing.Point(410, 245);
            this.lblAideDescri.Name = "lblAideDescri";
            this.lblAideDescri.Size = new System.Drawing.Size(35, 13);
            this.lblAideDescri.TabIndex = 38;
            this.lblAideDescri.Tag = "Aidelbl2";
            this.lblAideDescri.Text = "label1";
            this.lblAideDescri.Visible = false;
            // 
            // lblAideMontant
            // 
            this.lblAideMontant.AutoSize = true;
            this.lblAideMontant.Location = new System.Drawing.Point(410, 300);
            this.lblAideMontant.Name = "lblAideMontant";
            this.lblAideMontant.Size = new System.Drawing.Size(35, 13);
            this.lblAideMontant.TabIndex = 39;
            this.lblAideMontant.Tag = "Aidelbl3";
            this.lblAideMontant.Text = "label1";
            this.lblAideMontant.Visible = false;
            // 
            // lblAideRecette
            // 
            this.lblAideRecette.AutoSize = true;
            this.lblAideRecette.Location = new System.Drawing.Point(410, 345);
            this.lblAideRecette.Name = "lblAideRecette";
            this.lblAideRecette.Size = new System.Drawing.Size(35, 13);
            this.lblAideRecette.TabIndex = 40;
            this.lblAideRecette.Tag = "Aidelbl4";
            this.lblAideRecette.Text = "label1";
            this.lblAideRecette.Visible = false;
            // 
            // lblAideType
            // 
            this.lblAideType.AutoSize = true;
            this.lblAideType.Location = new System.Drawing.Point(410, 397);
            this.lblAideType.Name = "lblAideType";
            this.lblAideType.Size = new System.Drawing.Size(35, 13);
            this.lblAideType.TabIndex = 41;
            this.lblAideType.Tag = "Aidelbl5";
            this.lblAideType.Text = "label1";
            this.lblAideType.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cboListeTransaction
            // 
            this.cboListeTransaction.FormattingEnabled = true;
            this.cboListeTransaction.Location = new System.Drawing.Point(281, 476);
            this.cboListeTransaction.Name = "cboListeTransaction";
            this.cboListeTransaction.Size = new System.Drawing.Size(269, 21);
            this.cboListeTransaction.TabIndex = 42;
            this.cboListeTransaction.SelectedIndexChanged += new System.EventHandler(this.ChangerIndexCboListeTransaction);
            // 
            // lblListeTransaction
            // 
            this.lblListeTransaction.AutoSize = true;
            this.lblListeTransaction.Location = new System.Drawing.Point(160, 479);
            this.lblListeTransaction.Name = "lblListeTransaction";
            this.lblListeTransaction.Size = new System.Drawing.Size(115, 13);
            this.lblListeTransaction.TabIndex = 43;
            this.lblListeTransaction.Text = "Liste des transactions :";
            // 
            // lblChoixPersonne
            // 
            this.lblChoixPersonne.AutoSize = true;
            this.lblChoixPersonne.Location = new System.Drawing.Point(628, 230);
            this.lblChoixPersonne.Name = "lblChoixPersonne";
            this.lblChoixPersonne.Size = new System.Drawing.Size(71, 13);
            this.lblChoixPersonne.TabIndex = 55;
            this.lblChoixPersonne.Text = "participant : 0";
            // 
            // btnChoixPersonne
            // 
            this.btnChoixPersonne.Location = new System.Drawing.Point(611, 175);
            this.btnChoixPersonne.Name = "btnChoixPersonne";
            this.btnChoixPersonne.Size = new System.Drawing.Size(88, 39);
            this.btnChoixPersonne.TabIndex = 54;
            this.btnChoixPersonne.Text = "Choisir les participants...";
            this.btnChoixPersonne.UseVisualStyleBackColor = true;
            this.btnChoixPersonne.Click += new System.EventHandler(this.AjouterPersonneATransaction);
            // 
            // pic5
            // 
            this.pic5.Location = new System.Drawing.Point(304, 389);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(100, 21);
            this.pic5.TabIndex = 36;
            this.pic5.TabStop = false;
            this.pic5.Tag = "Aide2";
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(304, 341);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(100, 21);
            this.pic4.TabIndex = 35;
            this.pic4.TabStop = false;
            this.pic4.Tag = "Aide2";
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(304, 297);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(100, 20);
            this.pic3.TabIndex = 34;
            this.pic3.TabStop = false;
            this.pic3.Tag = "Aide2";
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(304, 242);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(100, 20);
            this.pic2.TabIndex = 33;
            this.pic2.TabStop = false;
            this.pic2.Tag = "Aide2";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(436, 65);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(100, 50);
            this.pic1.TabIndex = 32;
            this.pic1.TabStop = false;
            this.pic1.Tag = "Aide";
            // 
            // txtDescTran
            // 
            this.txtDescTran.Enabled = false;
            this.txtDescTran.Location = new System.Drawing.Point(197, 230);
            this.txtDescTran.Multiline = true;
            this.txtDescTran.Name = "txtDescTran";
            this.txtDescTran.Size = new System.Drawing.Size(100, 61);
            this.txtDescTran.TabIndex = 21;
            this.txtDescTran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisieDescription);
            // 
            // frmModiTransac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 536);
            this.Controls.Add(this.lblChoixPersonne);
            this.Controls.Add(this.btnChoixPersonne);
            this.Controls.Add(this.lblListeTransaction);
            this.Controls.Add(this.cboListeTransaction);
            this.Controls.Add(this.lblAideType);
            this.Controls.Add(this.lblAideRecette);
            this.Controls.Add(this.lblAideMontant);
            this.Controls.Add(this.lblAideDescri);
            this.Controls.Add(this.lblAideDate);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblDescTransac);
            this.Controls.Add(this.txtDescTran);
            this.Controls.Add(this.lblTransac);
            this.Controls.Add(this.calTransac);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(786, 575);
            this.MinimumSize = new System.Drawing.Size(786, 575);
            this.Name = "frmModiTransac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "1";
            this.Text = "Modification d\'une transaction";
            this.Load += new System.EventHandler(this.LancementDuFormulaire);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.CheckBox chkPerçu;
        private System.Windows.Forms.CheckBox chkRecette;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label lblDescTransac;
        private System.Windows.Forms.Label lblTransac;
        private System.Windows.Forms.MonthCalendar calTransac;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.Label lblAideDate;
        private System.Windows.Forms.Label lblAideDescri;
        private System.Windows.Forms.Label lblAideMontant;
        private System.Windows.Forms.Label lblAideRecette;
        private System.Windows.Forms.Label lblAideType;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblRecette;
        private System.Windows.Forms.Label lblListeTransaction;
        private System.Windows.Forms.ComboBox cboListeTransaction;
        private System.Windows.Forms.Label lblChoixPersonne;
        private System.Windows.Forms.Button btnChoixPersonne;
        private System.Windows.Forms.TextBox txtDescTran;
    }
}