﻿namespace miniProjet2017
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
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnChoixPersonne = new System.Windows.Forms.Button();
            this.lblChoixPersonne = new System.Windows.Forms.Label();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.picBordure = new System.Windows.Forms.PictureBox();
            this.txtDescTran = new System.Windows.Forms.TextBox();
            this.btnAide = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.picBarreVerte1 = new System.Windows.Forms.PictureBox();
            this.picBarreVerte2 = new System.Windows.Forms.PictureBox();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarreVerte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarreVerte2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransac
            // 
            this.lblTransac.AutoSize = true;
            this.lblTransac.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTransac.Location = new System.Drawing.Point(492, 109);
            this.lblTransac.Name = "lblTransac";
            this.lblTransac.Size = new System.Drawing.Size(111, 13);
            this.lblTransac.TabIndex = 0;
            this.lblTransac.Text = "Date de la transaction";
            // 
            // lblDescTransac
            // 
            this.lblDescTransac.AutoSize = true;
            this.lblDescTransac.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescTransac.Location = new System.Drawing.Point(44, 199);
            this.lblDescTransac.Name = "lblDescTransac";
            this.lblDescTransac.Size = new System.Drawing.Size(141, 13);
            this.lblDescTransac.TabIndex = 1;
            this.lblDescTransac.Text = "Description de la transaction";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMontant.Location = new System.Drawing.Point(139, 292);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 2;
            this.lblMontant.Text = "Montant";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblType.Location = new System.Drawing.Point(154, 109);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // calTransac
            // 
            this.calTransac.Location = new System.Drawing.Point(495, 133);
            this.calTransac.MaxSelectionCount = 1;
            this.calTransac.Name = "calTransac";
            this.calTransac.TabIndex = 0;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(204, 106);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 6;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(204, 289);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(107, 20);
            this.txtMontant.TabIndex = 2;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisirUnMontant);
            // 
            // chkRecette
            // 
            this.chkRecette.AutoSize = true;
            this.chkRecette.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRecette.Location = new System.Drawing.Point(101, 16);
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
            this.chkPerçu.ForeColor = System.Drawing.SystemColors.Control;
            this.chkPerçu.Location = new System.Drawing.Point(203, 16);
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
            this.grb1.Location = new System.Drawing.Point(66, 341);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(281, 43);
            this.grb1.TabIndex = 3;
            this.grb1.TabStop = false;
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.ForeColor = System.Drawing.Color.Gray;
            this.lblRecette.Location = new System.Drawing.Point(36, 17);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(50, 13);
            this.lblRecette.TabIndex = 6;
            this.lblRecette.Text = "Dépense";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAjouter.Location = new System.Drawing.Point(301, 441);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAjouter.Size = new System.Drawing.Size(168, 53);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter la transaction";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.AjouterUneTransaction);
            this.btnAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            this.btnAjouter.MouseHover += new System.EventHandler(this.btnAjouterHover);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEuro.Location = new System.Drawing.Point(317, 292);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(13, 13);
            this.lblEuro.TabIndex = 16;
            this.lblEuro.Text = "€";
            // 
            // lblAideType
            // 
            this.lblAideType.AutoSize = true;
            this.lblAideType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAideType.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAideType.Location = new System.Drawing.Point(150, 139);
            this.lblAideType.Name = "lblAideType";
            this.lblAideType.Size = new System.Drawing.Size(41, 13);
            this.lblAideType.TabIndex = 51;
            this.lblAideType.Tag = "Aidelbl5";
            this.lblAideType.Text = "label1";
            this.lblAideType.Visible = false;
            // 
            // lblAideRecette
            // 
            this.lblAideRecette.AutoSize = true;
            this.lblAideRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAideRecette.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAideRecette.Location = new System.Drawing.Point(150, 392);
            this.lblAideRecette.Name = "lblAideRecette";
            this.lblAideRecette.Size = new System.Drawing.Size(41, 13);
            this.lblAideRecette.TabIndex = 50;
            this.lblAideRecette.Tag = "Aidelbl4";
            this.lblAideRecette.Text = "label1";
            this.lblAideRecette.Visible = false;
            // 
            // lblAideMontant
            // 
            this.lblAideMontant.AutoSize = true;
            this.lblAideMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAideMontant.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAideMontant.Location = new System.Drawing.Point(150, 325);
            this.lblAideMontant.Name = "lblAideMontant";
            this.lblAideMontant.Size = new System.Drawing.Size(41, 13);
            this.lblAideMontant.TabIndex = 49;
            this.lblAideMontant.Tag = "Aidelbl3";
            this.lblAideMontant.Text = "label1";
            this.lblAideMontant.Visible = false;
            // 
            // lblAideDescri
            // 
            this.lblAideDescri.AutoSize = true;
            this.lblAideDescri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAideDescri.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAideDescri.Location = new System.Drawing.Point(150, 232);
            this.lblAideDescri.Name = "lblAideDescri";
            this.lblAideDescri.Size = new System.Drawing.Size(41, 13);
            this.lblAideDescri.TabIndex = 48;
            this.lblAideDescri.Tag = "Aidelbl2";
            this.lblAideDescri.Text = "label1";
            this.lblAideDescri.Visible = false;
            // 
            // lblAideDate
            // 
            this.lblAideDate.AutoSize = true;
            this.lblAideDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAideDate.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAideDate.Location = new System.Drawing.Point(492, 304);
            this.lblAideDate.Name = "lblAideDate";
            this.lblAideDate.Size = new System.Drawing.Size(41, 13);
            this.lblAideDate.TabIndex = 47;
            this.lblAideDate.Tag = "Aidelbl1";
            this.lblAideDate.Text = "label1";
            this.lblAideDate.Visible = false;
            // 
            // pic5
            // 
            this.pic5.Location = new System.Drawing.Point(47, 483);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(100, 21);
            this.pic5.TabIndex = 46;
            this.pic5.TabStop = false;
            this.pic5.Tag = "Aide2";
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(47, 473);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(100, 21);
            this.pic4.TabIndex = 45;
            this.pic4.TabStop = false;
            this.pic4.Tag = "Aide2";
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(47, 457);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(100, 20);
            this.pic3.TabIndex = 44;
            this.pic3.TabStop = false;
            this.pic3.Tag = "Aide2";
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(47, 441);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(100, 20);
            this.pic2.TabIndex = 43;
            this.pic2.TabStop = false;
            this.pic2.Tag = "Aide2";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(153, 448);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(100, 50);
            this.pic1.TabIndex = 42;
            this.pic1.TabStop = false;
            this.pic1.Tag = "Aide";
            // 
            // btnChoixPersonne
            // 
            this.btnChoixPersonne.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnChoixPersonne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChoixPersonne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChoixPersonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoixPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnChoixPersonne.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChoixPersonne.Location = new System.Drawing.Point(522, 441);
            this.btnChoixPersonne.Name = "btnChoixPersonne";
            this.btnChoixPersonne.Size = new System.Drawing.Size(168, 53);
            this.btnChoixPersonne.TabIndex = 7;
            this.btnChoixPersonne.Text = "Choisir les participants...";
            this.btnChoixPersonne.UseVisualStyleBackColor = true;
            this.btnChoixPersonne.Click += new System.EventHandler(this.AjouterPersonneATransaction);
            // 
            // lblChoixPersonne
            // 
            this.lblChoixPersonne.AutoSize = true;
            this.lblChoixPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixPersonne.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChoixPersonne.Location = new System.Drawing.Point(556, 423);
            this.lblChoixPersonne.Name = "lblChoixPersonne";
            this.lblChoixPersonne.Size = new System.Drawing.Size(95, 15);
            this.lblChoixPersonne.TabIndex = 53;
            this.lblChoixPersonne.Text = "participant : 0";
            // 
            // picQuitter
            // 
            this.picQuitter.BackColor = System.Drawing.Color.Transparent;
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.flecheRetour;
            this.picQuitter.Location = new System.Drawing.Point(658, 30);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(79, 71);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 54;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.QuitterAjoutTransac);
            // 
            // picBordure
            // 
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
            this.txtDescTran.Location = new System.Drawing.Point(203, 196);
            this.txtDescTran.Name = "txtDescTran";
            this.txtDescTran.Size = new System.Drawing.Size(144, 20);
            this.txtDescTran.TabIndex = 1;
            this.txtDescTran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisieDescription);
            // 
            // btnAide
            // 
            this.btnAide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAide.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAide.Location = new System.Drawing.Point(47, 38);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(75, 23);
            this.btnAide.TabIndex = 9;
            this.btnAide.Text = "Aide";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.CliquerAideAjout);
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
            this.picBarreVerte1.Location = new System.Drawing.Point(141, 155);
            this.picBarreVerte1.Name = "picBarreVerte1";
            this.picBarreVerte1.Size = new System.Drawing.Size(206, 35);
            this.picBarreVerte1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarreVerte1.TabIndex = 57;
            this.picBarreVerte1.TabStop = false;
            // 
            // picBarreVerte2
            // 
            this.picBarreVerte2.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.picBarreVerte2.Location = new System.Drawing.Point(141, 248);
            this.picBarreVerte2.Name = "picBarreVerte2";
            this.picBarreVerte2.Size = new System.Drawing.Size(206, 35);
            this.picBarreVerte2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarreVerte2.TabIndex = 58;
            this.picBarreVerte2.TabStop = false;
            // 
            // frmAjoutTransac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(768, 547);
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
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarreVerte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarreVerte2)).EndInit();
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
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
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
    }
}