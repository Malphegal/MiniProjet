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
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblAideType = new System.Windows.Forms.Label();
            this.lblAideRecette = new System.Windows.Forms.Label();
            this.lblAideMontant = new System.Windows.Forms.Label();
            this.lblAideDescri = new System.Windows.Forms.Label();
            this.lblAideDate = new System.Windows.Forms.Label();
            this.btnChoixPersonne = new System.Windows.Forms.Button();
            this.lblChoixPersonne = new System.Windows.Forms.Label();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.picBordure = new System.Windows.Forms.PictureBox();
            this.txtDescTran = new System.Windows.Forms.TextBox();
            this.btnAide = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.picBarreVerte1 = new System.Windows.Forms.PictureBox();
            this.picBarreVerte2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarreVerte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarreVerte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransac
            // 
            this.lblTransac.AutoSize = true;
            this.lblTransac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransac.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTransac.Location = new System.Drawing.Point(492, 109);
            this.lblTransac.Name = "lblTransac";
            this.lblTransac.Size = new System.Drawing.Size(133, 13);
            this.lblTransac.TabIndex = 0;
            this.lblTransac.Text = "Date de la transaction";
            // 
            // lblDescTransac
            // 
            this.lblDescTransac.AutoSize = true;
            this.lblDescTransac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescTransac.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescTransac.Location = new System.Drawing.Point(44, 199);
            this.lblDescTransac.Name = "lblDescTransac";
            this.lblDescTransac.Size = new System.Drawing.Size(170, 13);
            this.lblDescTransac.TabIndex = 1;
            this.lblDescTransac.Text = "Description de la transaction";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMontant.Location = new System.Drawing.Point(161, 292);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(53, 13);
            this.lblMontant.TabIndex = 2;
            this.lblMontant.Text = "Montant";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblType.Location = new System.Drawing.Point(179, 109);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // calTransac
            // 
            this.calTransac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calTransac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calTransac.Location = new System.Drawing.Point(495, 133);
            this.calTransac.MaxSelectionCount = 1;
            this.calTransac.Name = "calTransac";
            this.calTransac.TabIndex = 0;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(220, 106);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 6;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(220, 289);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.ShortcutsEnabled = false;
            this.txtMontant.Size = new System.Drawing.Size(107, 20);
            this.txtMontant.TabIndex = 2;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisirUnMontant);
            // 
            // chkRecette
            // 
            this.chkRecette.AutoSize = true;
            this.chkRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecette.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRecette.Location = new System.Drawing.Point(101, 16);
            this.chkRecette.Name = "chkRecette";
            this.chkRecette.Size = new System.Drawing.Size(82, 17);
            this.chkRecette.TabIndex = 4;
            this.chkRecette.Text = "• Recette";
            this.chkRecette.UseVisualStyleBackColor = true;
            this.chkRecette.CheckedChanged += new System.EventHandler(this.CliquerSurChkRecette);
            // 
            // chkPerçu
            // 
            this.chkPerçu.AutoSize = true;
            this.chkPerçu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPerçu.ForeColor = System.Drawing.SystemColors.Control;
            this.chkPerçu.Location = new System.Drawing.Point(203, 16);
            this.chkPerçu.Name = "chkPerçu";
            this.chkPerçu.Size = new System.Drawing.Size(59, 17);
            this.chkPerçu.TabIndex = 5;
            this.chkPerçu.Text = "Perçu";
            this.chkPerçu.UseVisualStyleBackColor = true;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.lblRecette);
            this.grb1.Controls.Add(this.chkPerçu);
            this.grb1.Controls.Add(this.chkRecette);
            this.grb1.Location = new System.Drawing.Point(66, 341);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(281, 43);
            this.grb1.TabIndex = 3;
            this.grb1.TabStop = false;
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecette.ForeColor = System.Drawing.Color.Gray;
            this.lblRecette.Location = new System.Drawing.Point(36, 17);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(57, 13);
            this.lblRecette.TabIndex = 6;
            this.lblRecette.Text = "Dépense";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAjouter.Location = new System.Drawing.Point(157, 441);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAjouter.Size = new System.Drawing.Size(168, 53);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter la transaction";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.AjouterUneTransaction);
            this.btnAjouter.MouseHover += new System.EventHandler(this.BoutonHover);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEuro.Location = new System.Drawing.Point(334, 292);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(14, 13);
            this.lblEuro.TabIndex = 16;
            this.lblEuro.Text = "€";
            // 
            // lblAideType
            // 
            this.lblAideType.AutoSize = true;
            this.lblAideType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAideType.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAideType.Location = new System.Drawing.Point(443, 323);
            this.lblAideType.Name = "lblAideType";
            this.lblAideType.Size = new System.Drawing.Size(41, 13);
            this.lblAideType.TabIndex = 51;
            this.lblAideType.Tag = "Aidelbl5";
            this.lblAideType.Text = "label1";
            this.lblAideType.Visible = false;
            // 
            // lblAideRecette
            // 
            this.lblAideRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAideRecette.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAideRecette.Location = new System.Drawing.Point(102, 230);
            this.lblAideRecette.Name = "lblAideRecette";
            this.lblAideRecette.Size = new System.Drawing.Size(300, 13);
            this.lblAideRecette.TabIndex = 50;
            this.lblAideRecette.Tag = "Aidelbl4";
            this.lblAideRecette.Text = "label1";
            this.lblAideRecette.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAideRecette.Visible = false;
            // 
            // lblAideMontant
            // 
            this.lblAideMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAideMontant.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAideMontant.Location = new System.Drawing.Point(102, 322);
            this.lblAideMontant.Name = "lblAideMontant";
            this.lblAideMontant.Size = new System.Drawing.Size(300, 13);
            this.lblAideMontant.TabIndex = 49;
            this.lblAideMontant.Tag = "Aidelbl3";
            this.lblAideMontant.Text = "label1";
            this.lblAideMontant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAideMontant.Visible = false;
            // 
            // lblAideDescri
            // 
            this.lblAideDescri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAideDescri.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAideDescri.Location = new System.Drawing.Point(102, 388);
            this.lblAideDescri.Name = "lblAideDescri";
            this.lblAideDescri.Size = new System.Drawing.Size(300, 13);
            this.lblAideDescri.TabIndex = 48;
            this.lblAideDescri.Tag = "Aidelbl2";
            this.lblAideDescri.Text = "label1";
            this.lblAideDescri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAideDescri.Visible = false;
            // 
            // lblAideDate
            // 
            this.lblAideDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAideDate.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAideDate.Location = new System.Drawing.Point(102, 140);
            this.lblAideDate.Name = "lblAideDate";
            this.lblAideDate.Size = new System.Drawing.Size(300, 13);
            this.lblAideDate.TabIndex = 47;
            this.lblAideDate.Tag = "Aidelbl1";
            this.lblAideDate.Text = "label1";
            this.lblAideDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAideDate.Visible = false;
            // 
            // btnChoixPersonne
            // 
            this.btnChoixPersonne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoixPersonne.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnChoixPersonne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChoixPersonne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChoixPersonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoixPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnChoixPersonne.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChoixPersonne.Location = new System.Drawing.Point(435, 441);
            this.btnChoixPersonne.Name = "btnChoixPersonne";
            this.btnChoixPersonne.Size = new System.Drawing.Size(168, 53);
            this.btnChoixPersonne.TabIndex = 7;
            this.btnChoixPersonne.Text = "Choisir les participants...";
            this.btnChoixPersonne.UseVisualStyleBackColor = true;
            this.btnChoixPersonne.Click += new System.EventHandler(this.AjouterPersonneATransaction);
            this.btnChoixPersonne.MouseHover += new System.EventHandler(this.BoutonHover);
            // 
            // lblChoixPersonne
            // 
            this.lblChoixPersonne.AutoSize = true;
            this.lblChoixPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixPersonne.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChoixPersonne.Location = new System.Drawing.Point(626, 459);
            this.lblChoixPersonne.Name = "lblChoixPersonne";
            this.lblChoixPersonne.Size = new System.Drawing.Size(96, 15);
            this.lblChoixPersonne.TabIndex = 53;
            this.lblChoixPersonne.Text = "Participant : 0";
            // 
            // picQuitter
            // 
            this.picQuitter.BackColor = System.Drawing.Color.Transparent;
            this.picQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.flecheRetour;
            this.picQuitter.Location = new System.Drawing.Point(658, 30);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(79, 71);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 54;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.QuitterAjoutTransac);
            this.picQuitter.MouseEnter += new System.EventHandler(this.SourisSurPicQuitter);
            this.picQuitter.MouseLeave += new System.EventHandler(this.SourisSortDePicQuitter);
            // 
            // picBordure
            // 
            this.picBordure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBordure.Image = ((System.Drawing.Image)(resources.GetObject("picBordure.Image")));
            this.picBordure.Location = new System.Drawing.Point(0, 0);
            this.picBordure.Name = "picBordure";
            this.picBordure.Size = new System.Drawing.Size(768, 547);
            this.picBordure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBordure.TabIndex = 55;
            this.picBordure.TabStop = false;
            // 
            // txtDescTran
            // 
            this.txtDescTran.Location = new System.Drawing.Point(220, 196);
            this.txtDescTran.Name = "txtDescTran";
            this.txtDescTran.ShortcutsEnabled = false;
            this.txtDescTran.Size = new System.Drawing.Size(196, 20);
            this.txtDescTran.TabIndex = 1;
            this.txtDescTran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisieDescription);
            // 
            // btnAide
            // 
            this.btnAide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAide.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAide.Location = new System.Drawing.Point(47, 38);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(75, 23);
            this.btnAide.TabIndex = 9;
            this.btnAide.Text = "Aide";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.CliquerAideAjout);
            this.btnAide.MouseHover += new System.EventHandler(this.BoutonHover);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitre.Location = new System.Drawing.Point(254, 30);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(293, 31);
            this.lblTitre.TabIndex = 56;
            this.lblTitre.Text = "Ajouter une transaction";
            // 
            // picBarreVerte1
            // 
            this.picBarreVerte1.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.picBarreVerte1.Location = new System.Drawing.Point(105, 154);
            this.picBarreVerte1.Name = "picBarreVerte1";
            this.picBarreVerte1.Size = new System.Drawing.Size(311, 32);
            this.picBarreVerte1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarreVerte1.TabIndex = 57;
            this.picBarreVerte1.TabStop = false;
            // 
            // picBarreVerte2
            // 
            this.picBarreVerte2.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.picBarreVerte2.Location = new System.Drawing.Point(105, 247);
            this.picBarreVerte2.Name = "picBarreVerte2";
            this.picBarreVerte2.Size = new System.Drawing.Size(311, 30);
            this.picBarreVerte2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarreVerte2.TabIndex = 58;
            this.picBarreVerte2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.pictureBox1.Location = new System.Drawing.Point(105, 405);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // frmAjoutTransac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(768, 547);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBarreVerte2);
            this.Controls.Add(this.picBarreVerte1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.txtDescTran);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.lblChoixPersonne);
            this.Controls.Add(this.btnChoixPersonne);
            this.Controls.Add(this.lblAideType);
            this.Controls.Add(this.lblAideRecette);
            this.Controls.Add(this.lblAideMontant);
            this.Controls.Add(this.lblAideDescri);
            this.Controls.Add(this.lblAideDate);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.calTransac);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblDescTransac);
            this.Controls.Add(this.lblTransac);
            this.Controls.Add(this.picBordure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(768, 547);
            this.MinimumSize = new System.Drawing.Size(768, 547);
            this.Name = "frmAjoutTransac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "0";
            this.Text = "frmAjoutTransac";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarreVerte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarreVerte2)).EndInit();
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
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblAideType;
        private System.Windows.Forms.Label lblAideRecette;
        private System.Windows.Forms.Label lblAideMontant;
        private System.Windows.Forms.Label lblAideDescri;
        private System.Windows.Forms.Label lblAideDate;
        private System.Windows.Forms.Label lblRecette;
        private System.Windows.Forms.Button btnChoixPersonne;
        private System.Windows.Forms.Label lblChoixPersonne;
        private System.Windows.Forms.PictureBox picQuitter;
        private System.Windows.Forms.PictureBox picBordure;
        private System.Windows.Forms.TextBox txtDescTran;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox picBarreVerte2;
        private System.Windows.Forms.PictureBox picBarreVerte1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}