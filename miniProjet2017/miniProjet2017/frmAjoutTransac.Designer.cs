namespace miniProjet2017
{
    partial class frmAjoutTransac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutTransac));
            this.lblTransac = new System.Windows.Forms.Label();
            this.lblDescTransac = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.calTransac = new System.Windows.Forms.MonthCalendar();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.chkRecette = new System.Windows.Forms.CheckBox();
            this.chkPerçu = new System.Windows.Forms.CheckBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.lblRecette = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDescTran = new System.Windows.Forms.RichTextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblAideType = new System.Windows.Forms.Label();
            this.lblAideRecette = new System.Windows.Forms.Label();
            this.lblAideMontant = new System.Windows.Forms.Label();
            this.lblAideDescri = new System.Windows.Forms.Label();
            this.lblAideDate = new System.Windows.Forms.Label();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnChoixPersonne = new System.Windows.Forms.Button();
            this.lblChoixPersonne = new System.Windows.Forms.Label();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransac
            // 
            this.lblTransac.AutoSize = true;
            this.lblTransac.Location = new System.Drawing.Point(12, 50);
            this.lblTransac.Name = "lblTransac";
            this.lblTransac.Size = new System.Drawing.Size(111, 13);
            this.lblTransac.TabIndex = 0;
            this.lblTransac.Text = "Date de la transaction";
            // 
            // lblDescTransac
            // 
            this.lblDescTransac.AutoSize = true;
            this.lblDescTransac.Location = new System.Drawing.Point(12, 246);
            this.lblDescTransac.Name = "lblDescTransac";
            this.lblDescTransac.Size = new System.Drawing.Size(141, 13);
            this.lblDescTransac.TabIndex = 1;
            this.lblDescTransac.Text = "Description de la transaction";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(12, 315);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 2;
            this.lblMontant.Text = "Montant";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(15, 387);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // calTransac
            // 
            this.calTransac.Location = new System.Drawing.Point(130, 39);
            this.calTransac.MaxSelectionCount = 1;
            this.calTransac.Name = "calTransac";
            this.calTransac.TabIndex = 0;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(162, 387);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 6;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(162, 308);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(107, 20);
            this.txtMontant.TabIndex = 2;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisirUnMontant);
            // 
            // chkRecette
            // 
            this.chkRecette.AutoSize = true;
            this.chkRecette.Location = new System.Drawing.Point(77, 12);
            this.chkRecette.Name = "chkRecette";
            this.chkRecette.Size = new System.Drawing.Size(73, 17);
            this.chkRecette.TabIndex = 4;
            this.chkRecette.Text = "• Recette";
            this.chkRecette.UseVisualStyleBackColor = true;
            this.chkRecette.CheckedChanged += new System.EventHandler(this.CliquerSurChkRecette);
            // 
            // chkPerçu
            // 
            this.chkPerçu.AutoSize = true;
            this.chkPerçu.Location = new System.Drawing.Point(150, 12);
            this.chkPerçu.Name = "chkPerçu";
            this.chkPerçu.Size = new System.Drawing.Size(54, 17);
            this.chkPerçu.TabIndex = 5;
            this.chkPerçu.Text = "Perçu";
            this.chkPerçu.UseVisualStyleBackColor = true;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.lblRecette);
            this.grb1.Controls.Add(this.chkPerçu);
            this.grb1.Controls.Add(this.chkRecette);
            this.grb1.Location = new System.Drawing.Point(12, 331);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(281, 43);
            this.grb1.TabIndex = 3;
            this.grb1.TabStop = false;
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.ForeColor = System.Drawing.Color.Gray;
            this.lblRecette.Location = new System.Drawing.Point(12, 13);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(50, 13);
            this.lblRecette.TabIndex = 6;
            this.lblRecette.Text = "Dépense";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAjouter.Location = new System.Drawing.Point(66, 438);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 41);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter la transaction";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.AjouterUneTransaction);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
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
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.CliquerAideAjout);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.quitterToolStripMenuItem.Text = "Quitter...";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterAjoutTransac);
            // 
            // txtDescTran
            // 
            this.txtDescTran.Location = new System.Drawing.Point(162, 210);
            this.txtDescTran.Name = "txtDescTran";
            this.txtDescTran.Size = new System.Drawing.Size(195, 92);
            this.txtDescTran.TabIndex = 1;
            this.txtDescTran.Text = "";
            this.txtDescTran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisieDescription);
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(270, 311);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(13, 13);
            this.lblEuro.TabIndex = 16;
            this.lblEuro.Text = "€";
            // 
            // lblAideType
            // 
            this.lblAideType.AutoSize = true;
            this.lblAideType.Location = new System.Drawing.Point(395, 395);
            this.lblAideType.Name = "lblAideType";
            this.lblAideType.Size = new System.Drawing.Size(35, 13);
            this.lblAideType.TabIndex = 51;
            this.lblAideType.Tag = "Aidelbl5";
            this.lblAideType.Text = "label1";
            this.lblAideType.Visible = false;
            // 
            // lblAideRecette
            // 
            this.lblAideRecette.AutoSize = true;
            this.lblAideRecette.Location = new System.Drawing.Point(395, 347);
            this.lblAideRecette.Name = "lblAideRecette";
            this.lblAideRecette.Size = new System.Drawing.Size(35, 13);
            this.lblAideRecette.TabIndex = 50;
            this.lblAideRecette.Tag = "Aidelbl4";
            this.lblAideRecette.Text = "label1";
            this.lblAideRecette.Visible = false;
            // 
            // lblAideMontant
            // 
            this.lblAideMontant.AutoSize = true;
            this.lblAideMontant.Location = new System.Drawing.Point(395, 311);
            this.lblAideMontant.Name = "lblAideMontant";
            this.lblAideMontant.Size = new System.Drawing.Size(35, 13);
            this.lblAideMontant.TabIndex = 49;
            this.lblAideMontant.Tag = "Aidelbl3";
            this.lblAideMontant.Text = "label1";
            this.lblAideMontant.Visible = false;
            // 
            // lblAideDescri
            // 
            this.lblAideDescri.AutoSize = true;
            this.lblAideDescri.Location = new System.Drawing.Point(469, 249);
            this.lblAideDescri.Name = "lblAideDescri";
            this.lblAideDescri.Size = new System.Drawing.Size(35, 13);
            this.lblAideDescri.TabIndex = 48;
            this.lblAideDescri.Tag = "Aidelbl2";
            this.lblAideDescri.Text = "label1";
            this.lblAideDescri.Visible = false;
            // 
            // lblAideDate
            // 
            this.lblAideDate.AutoSize = true;
            this.lblAideDate.Location = new System.Drawing.Point(396, 92);
            this.lblAideDate.Name = "lblAideDate";
            this.lblAideDate.Size = new System.Drawing.Size(35, 13);
            this.lblAideDate.TabIndex = 47;
            this.lblAideDate.Tag = "Aidelbl1";
            this.lblAideDate.Text = "label1";
            this.lblAideDate.Visible = false;
            // 
            // pic5
            // 
            this.pic5.Location = new System.Drawing.Point(289, 387);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(100, 21);
            this.pic5.TabIndex = 46;
            this.pic5.TabStop = false;
            this.pic5.Tag = "Aide2";
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(289, 343);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(100, 21);
            this.pic4.TabIndex = 45;
            this.pic4.TabStop = false;
            this.pic4.Tag = "Aide2";
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(289, 308);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(100, 20);
            this.pic3.TabIndex = 44;
            this.pic3.TabStop = false;
            this.pic3.Tag = "Aide2";
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(363, 246);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(100, 20);
            this.pic2.TabIndex = 43;
            this.pic2.TabStop = false;
            this.pic2.Tag = "Aide2";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(363, 39);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(100, 50);
            this.pic1.TabIndex = 42;
            this.pic1.TabStop = false;
            this.pic1.Tag = "Aide";
            // 
            // btnChoixPersonne
            // 
            this.btnChoixPersonne.Location = new System.Drawing.Point(572, 131);
            this.btnChoixPersonne.Name = "btnChoixPersonne";
            this.btnChoixPersonne.Size = new System.Drawing.Size(88, 39);
            this.btnChoixPersonne.TabIndex = 52;
            this.btnChoixPersonne.Text = "Choisir les participants...";
            this.btnChoixPersonne.UseVisualStyleBackColor = true;
            this.btnChoixPersonne.Click += new System.EventHandler(this.AjouterPersonneATransaction);
            // 
            // lblChoixPersonne
            // 
            this.lblChoixPersonne.AutoSize = true;
            this.lblChoixPersonne.Location = new System.Drawing.Point(589, 186);
            this.lblChoixPersonne.Name = "lblChoixPersonne";
            this.lblChoixPersonne.Size = new System.Drawing.Size(71, 13);
            this.lblChoixPersonne.TabIndex = 53;
            this.lblChoixPersonne.Text = "participant : 0";
            // 
            // picQuitter
            // 
            this.picQuitter.Image = ((System.Drawing.Image)(resources.GetObject("picQuitter.Image")));
            this.picQuitter.Location = new System.Drawing.Point(706, 39);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(50, 50);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 54;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.QuitterAjoutTransac);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // frmAjoutTransac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 547);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.lblChoixPersonne);
            this.Controls.Add(this.btnChoixPersonne);
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
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.txtDescTran);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.calTransac);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblDescTransac);
            this.Controls.Add(this.lblTransac);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(768, 547);
            this.MinimumSize = new System.Drawing.Size(768, 547);
            this.Name = "frmAjoutTransac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "0";
            this.Text = "frmAjoutTransac";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransac;
        private System.Windows.Forms.Label lblDescTransac;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.MonthCalendar calTransac;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.CheckBox chkRecette;
        private System.Windows.Forms.CheckBox chkPerçu;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtDescTran;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblAideType;
        private System.Windows.Forms.Label lblAideRecette;
        private System.Windows.Forms.Label lblAideMontant;
        private System.Windows.Forms.Label lblAideDescri;
        private System.Windows.Forms.Label lblAideDate;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label lblRecette;
        private System.Windows.Forms.Button btnChoixPersonne;
        private System.Windows.Forms.Label lblChoixPersonne;
        private System.Windows.Forms.PictureBox picQuitter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}