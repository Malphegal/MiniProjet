namespace miniProjet2017
{
    partial class frmRecap
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
            this.btnPersonne = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnRR = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.chkRecette = new System.Windows.Forms.CheckBox();
            this.chkPercu = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this._lblId = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDefaut = new System.Windows.Forms.TabPage();
            this.tabTransaction = new System.Windows.Forms.TabPage();
            this.lblEnregistrement = new System.Windows.Forms.Label();
            this._lblType = new System.Windows.Forms.Label();
            this._lblDescription = new System.Windows.Forms.Label();
            this._lblMontant = new System.Windows.Forms.Label();
            this.tabPersonne = new System.Windows.Forms.TabPage();
            this.lblIdPersonne = new System.Windows.Forms.Label();
            this._lblIdPersonne = new System.Windows.Forms.Label();
            this._lblEnregistrement = new System.Windows.Forms.Label();
            this._btnL = new System.Windows.Forms.Button();
            this._btnLL = new System.Windows.Forms.Button();
            this._btnR = new System.Windows.Forms.Button();
            this._btnRR = new System.Windows.Forms.Button();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this._lblTelephone = new System.Windows.Forms.Label();
            this._lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this._lblPrenom = new System.Windows.Forms.Label();
            this.lblRecapitulatif = new System.Windows.Forms.Label();
            this.picBordure = new System.Windows.Forms.PictureBox();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabTransaction.SuspendLayout();
            this.tabPersonne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonne
            // 
            this.btnPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnPersonne.Location = new System.Drawing.Point(42, 53);
            this.btnPersonne.Name = "btnPersonne";
            this.btnPersonne.Size = new System.Drawing.Size(132, 48);
            this.btnPersonne.TabIndex = 0;
            this.btnPersonne.Text = "Lister personne";
            this.btnPersonne.UseVisualStyleBackColor = true;
            this.btnPersonne.Click += new System.EventHandler(this.CliquerSurLiaisonPersonne);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.Location = new System.Drawing.Point(207, 53);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(132, 48);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.Text = "Lister transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.CliquerSurLiaisonTransaction);
            // 
            // btnLL
            // 
            this.btnLL.Enabled = false;
            this.btnLL.Location = new System.Drawing.Point(6, 299);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(60, 47);
            this.btnLL.TabIndex = 2;
            this.btnLL.Text = "Shift left";
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Click += new System.EventHandler(this.CliquerSurPremierTransaction);
            // 
            // btnL
            // 
            this.btnL.Enabled = false;
            this.btnL.Location = new System.Drawing.Point(72, 299);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(60, 47);
            this.btnL.TabIndex = 3;
            this.btnL.Text = "LT";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.CliquerSurPrecedentTransaction);
            // 
            // btnR
            // 
            this.btnR.Enabled = false;
            this.btnR.Location = new System.Drawing.Point(138, 299);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(60, 47);
            this.btnR.TabIndex = 4;
            this.btnR.Text = "GT";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.CliquerSurSuivantTransaction);
            // 
            // btnRR
            // 
            this.btnRR.Enabled = false;
            this.btnRR.Location = new System.Drawing.Point(204, 299);
            this.btnRR.Name = "btnRR";
            this.btnRR.Size = new System.Drawing.Size(60, 47);
            this.btnRR.TabIndex = 5;
            this.btnRR.Text = "Shift right";
            this.btnRR.UseVisualStyleBackColor = true;
            this.btnRR.Click += new System.EventHandler(this.CliquerSurDernierTransaction);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(138, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(138, 81);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(138, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(138, 111);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 9;
            this.lblMontant.Text = "Montant";
            // 
            // chkRecette
            // 
            this.chkRecette.AutoSize = true;
            this.chkRecette.Enabled = false;
            this.chkRecette.Location = new System.Drawing.Point(473, 138);
            this.chkRecette.Name = "chkRecette";
            this.chkRecette.Size = new System.Drawing.Size(64, 17);
            this.chkRecette.TabIndex = 10;
            this.chkRecette.Text = "Recette";
            this.chkRecette.UseVisualStyleBackColor = true;
            // 
            // chkPercu
            // 
            this.chkPercu.AutoSize = true;
            this.chkPercu.Enabled = false;
            this.chkPercu.Location = new System.Drawing.Point(473, 161);
            this.chkPercu.Name = "chkPercu";
            this.chkPercu.Size = new System.Drawing.Size(54, 17);
            this.chkPercu.TabIndex = 11;
            this.chkPercu.Text = "Perçu";
            this.chkPercu.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(531, 108);
            this.listBox1.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(402, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
            // 
            // _lblId
            // 
            this._lblId.AutoSize = true;
            this._lblId.Location = new System.Drawing.Point(6, 20);
            this._lblId.Name = "_lblId";
            this._lblId.Size = new System.Drawing.Size(119, 13);
            this._lblId.TabIndex = 15;
            this._lblId.Text = "Code de la transcation :";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabDefaut);
            this.tabControl1.Controls.Add(this.tabTransaction);
            this.tabControl1.Controls.Add(this.tabPersonne);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(19, 102);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 378);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 16;
            this.tabControl1.TabStop = false;
            // 
            // tabDefaut
            // 
            this.tabDefaut.BackColor = System.Drawing.Color.Transparent;
            this.tabDefaut.Location = new System.Drawing.Point(4, 5);
            this.tabDefaut.Name = "tabDefaut";
            this.tabDefaut.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefaut.Size = new System.Drawing.Size(543, 369);
            this.tabDefaut.TabIndex = 2;
            this.tabDefaut.Text = "Defaut";
            // 
            // tabTransaction
            // 
            this.tabTransaction.BackColor = System.Drawing.Color.Transparent;
            this.tabTransaction.Controls.Add(this.lblEnregistrement);
            this.tabTransaction.Controls.Add(this._lblType);
            this.tabTransaction.Controls.Add(this._lblDescription);
            this.tabTransaction.Controls.Add(this._lblId);
            this.tabTransaction.Controls.Add(this.btnL);
            this.tabTransaction.Controls.Add(this._lblMontant);
            this.tabTransaction.Controls.Add(this.lblMontant);
            this.tabTransaction.Controls.Add(this.lblDate);
            this.tabTransaction.Controls.Add(this.lblDescription);
            this.tabTransaction.Controls.Add(this.lblType);
            this.tabTransaction.Controls.Add(this.btnLL);
            this.tabTransaction.Controls.Add(this.lblId);
            this.tabTransaction.Controls.Add(this.chkPercu);
            this.tabTransaction.Controls.Add(this.listBox1);
            this.tabTransaction.Controls.Add(this.chkRecette);
            this.tabTransaction.Controls.Add(this.btnR);
            this.tabTransaction.Controls.Add(this.btnRR);
            this.tabTransaction.Location = new System.Drawing.Point(4, 5);
            this.tabTransaction.Name = "tabTransaction";
            this.tabTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransaction.Size = new System.Drawing.Size(543, 369);
            this.tabTransaction.TabIndex = 0;
            this.tabTransaction.Text = "Transaction";
            // 
            // lblEnregistrement
            // 
            this.lblEnregistrement.AutoSize = true;
            this.lblEnregistrement.Location = new System.Drawing.Point(340, 317);
            this.lblEnregistrement.Name = "lblEnregistrement";
            this.lblEnregistrement.Size = new System.Drawing.Size(83, 13);
            this.lblEnregistrement.TabIndex = 18;
            this.lblEnregistrement.Text = "Enregistrement :";
            // 
            // _lblType
            // 
            this._lblType.AutoSize = true;
            this._lblType.Location = new System.Drawing.Point(88, 81);
            this._lblType.Name = "_lblType";
            this._lblType.Size = new System.Drawing.Size(37, 13);
            this._lblType.TabIndex = 17;
            this._lblType.Text = "Type :";
            // 
            // _lblDescription
            // 
            this._lblDescription.AutoSize = true;
            this._lblDescription.Location = new System.Drawing.Point(59, 48);
            this._lblDescription.Name = "_lblDescription";
            this._lblDescription.Size = new System.Drawing.Size(66, 13);
            this._lblDescription.TabIndex = 16;
            this._lblDescription.Text = "Description :";
            // 
            // _lblMontant
            // 
            this._lblMontant.AutoSize = true;
            this._lblMontant.Location = new System.Drawing.Point(73, 111);
            this._lblMontant.Name = "_lblMontant";
            this._lblMontant.Size = new System.Drawing.Size(52, 13);
            this._lblMontant.TabIndex = 9;
            this._lblMontant.Text = "Montant :";
            // 
            // tabPersonne
            // 
            this.tabPersonne.BackColor = System.Drawing.Color.Transparent;
            this.tabPersonne.Controls.Add(this.lblIdPersonne);
            this.tabPersonne.Controls.Add(this._lblIdPersonne);
            this.tabPersonne.Controls.Add(this._lblEnregistrement);
            this.tabPersonne.Controls.Add(this._btnL);
            this.tabPersonne.Controls.Add(this._btnLL);
            this.tabPersonne.Controls.Add(this._btnR);
            this.tabPersonne.Controls.Add(this._btnRR);
            this.tabPersonne.Controls.Add(this.lblTelephone);
            this.tabPersonne.Controls.Add(this.lblNom);
            this.tabPersonne.Controls.Add(this._lblTelephone);
            this.tabPersonne.Controls.Add(this._lblNom);
            this.tabPersonne.Controls.Add(this.lblPrenom);
            this.tabPersonne.Controls.Add(this._lblPrenom);
            this.tabPersonne.Location = new System.Drawing.Point(4, 5);
            this.tabPersonne.Name = "tabPersonne";
            this.tabPersonne.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonne.Size = new System.Drawing.Size(543, 369);
            this.tabPersonne.TabIndex = 1;
            this.tabPersonne.Text = "Personne";
            // 
            // lblIdPersonne
            // 
            this.lblIdPersonne.AutoSize = true;
            this.lblIdPersonne.Location = new System.Drawing.Point(131, 32);
            this.lblIdPersonne.Name = "lblIdPersonne";
            this.lblIdPersonne.Size = new System.Drawing.Size(16, 13);
            this.lblIdPersonne.TabIndex = 25;
            this.lblIdPersonne.Text = "Id";
            // 
            // _lblIdPersonne
            // 
            this._lblIdPersonne.AutoSize = true;
            this._lblIdPersonne.Location = new System.Drawing.Point(6, 32);
            this._lblIdPersonne.Name = "_lblIdPersonne";
            this._lblIdPersonne.Size = new System.Drawing.Size(111, 13);
            this._lblIdPersonne.TabIndex = 24;
            this._lblIdPersonne.Text = "Code de la personne :";
            // 
            // _lblEnregistrement
            // 
            this._lblEnregistrement.AutoSize = true;
            this._lblEnregistrement.Location = new System.Drawing.Point(343, 334);
            this._lblEnregistrement.Name = "_lblEnregistrement";
            this._lblEnregistrement.Size = new System.Drawing.Size(83, 13);
            this._lblEnregistrement.TabIndex = 23;
            this._lblEnregistrement.Text = "Enregistrement :";
            // 
            // _btnL
            // 
            this._btnL.Enabled = false;
            this._btnL.Location = new System.Drawing.Point(75, 316);
            this._btnL.Name = "_btnL";
            this._btnL.Size = new System.Drawing.Size(60, 47);
            this._btnL.TabIndex = 20;
            this._btnL.Text = "LT";
            this._btnL.UseVisualStyleBackColor = true;
            this._btnL.Click += new System.EventHandler(this.CliquerSurPrecedentPersonne);
            // 
            // _btnLL
            // 
            this._btnLL.Enabled = false;
            this._btnLL.Location = new System.Drawing.Point(9, 316);
            this._btnLL.Name = "_btnLL";
            this._btnLL.Size = new System.Drawing.Size(60, 47);
            this._btnLL.TabIndex = 19;
            this._btnLL.Text = "Shift left";
            this._btnLL.UseVisualStyleBackColor = true;
            this._btnLL.Click += new System.EventHandler(this.CliquerSurPremierPersonne);
            // 
            // _btnR
            // 
            this._btnR.Enabled = false;
            this._btnR.Location = new System.Drawing.Point(141, 316);
            this._btnR.Name = "_btnR";
            this._btnR.Size = new System.Drawing.Size(60, 47);
            this._btnR.TabIndex = 21;
            this._btnR.Text = "GT";
            this._btnR.UseVisualStyleBackColor = true;
            this._btnR.Click += new System.EventHandler(this.CliquerSurSuivantPersonne);
            // 
            // _btnRR
            // 
            this._btnRR.Enabled = false;
            this._btnRR.Location = new System.Drawing.Point(207, 316);
            this._btnRR.Name = "_btnRR";
            this._btnRR.Size = new System.Drawing.Size(60, 47);
            this._btnRR.TabIndex = 22;
            this._btnRR.Text = "Shift right";
            this._btnRR.UseVisualStyleBackColor = true;
            this._btnRR.Click += new System.EventHandler(this.CliquerSurDernierPersonne);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(131, 149);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "Téléphone";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(131, 107);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom";
            // 
            // _lblTelephone
            // 
            this._lblTelephone.AutoSize = true;
            this._lblTelephone.Location = new System.Drawing.Point(51, 149);
            this._lblTelephone.Name = "_lblTelephone";
            this._lblTelephone.Size = new System.Drawing.Size(64, 13);
            this._lblTelephone.TabIndex = 3;
            this._lblTelephone.Text = "Téléphone :";
            // 
            // _lblNom
            // 
            this._lblNom.AutoSize = true;
            this._lblNom.Location = new System.Drawing.Point(80, 107);
            this._lblNom.Name = "_lblNom";
            this._lblNom.Size = new System.Drawing.Size(35, 13);
            this._lblNom.TabIndex = 2;
            this._lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(131, 69);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            // 
            // _lblPrenom
            // 
            this._lblPrenom.AutoSize = true;
            this._lblPrenom.Location = new System.Drawing.Point(66, 69);
            this._lblPrenom.Name = "_lblPrenom";
            this._lblPrenom.Size = new System.Drawing.Size(49, 13);
            this._lblPrenom.TabIndex = 0;
            this._lblPrenom.Text = "Prénom :";
            // 
            // lblRecapitulatif
            // 
            this.lblRecapitulatif.AutoSize = true;
            this.lblRecapitulatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecapitulatif.Location = new System.Drawing.Point(241, 25);
            this.lblRecapitulatif.Name = "lblRecapitulatif";
            this.lblRecapitulatif.Size = new System.Drawing.Size(98, 20);
            this.lblRecapitulatif.TabIndex = 17;
            this.lblRecapitulatif.Text = "Récapitulatif";
            // 
            // picBordure
            // 
            this.picBordure.Image = global::miniProjet2017.Properties.Resources.bordureOption;
            this.picBordure.Location = new System.Drawing.Point(-5, 0);
            this.picBordure.Name = "picBordure";
            this.picBordure.Size = new System.Drawing.Size(610, 506);
            this.picBordure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBordure.TabIndex = 18;
            this.picBordure.TabStop = false;
            // 
            // picQuitter
            // 
            this.picQuitter.BackColor = System.Drawing.Color.Transparent;
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.flecheRetour;
            this.picQuitter.Location = new System.Drawing.Point(499, 25);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(71, 64);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 19;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.picQuitter_Click);
            // 
            // frmRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.lblRecapitulatif);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnPersonne);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.picBordure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "frmRecap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Récapitulatif";
            this.Load += new System.EventHandler(this.ChargementDeFrmRecap);
            this.tabControl1.ResumeLayout(false);
            this.tabTransaction.ResumeLayout(false);
            this.tabTransaction.PerformLayout();
            this.tabPersonne.ResumeLayout(false);
            this.tabPersonne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonne;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnLL;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnRR;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.CheckBox chkRecette;
        private System.Windows.Forms.CheckBox chkPercu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label _lblId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDefaut;
        private System.Windows.Forms.TabPage tabTransaction;
        private System.Windows.Forms.TabPage tabPersonne;
        private System.Windows.Forms.Label _lblType;
        private System.Windows.Forms.Label _lblDescription;
        private System.Windows.Forms.Label _lblMontant;
        private System.Windows.Forms.Label lblEnregistrement;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label _lblTelephone;
        private System.Windows.Forms.Label _lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label _lblPrenom;
        private System.Windows.Forms.Label _lblEnregistrement;
        private System.Windows.Forms.Button _btnL;
        private System.Windows.Forms.Button _btnLL;
        private System.Windows.Forms.Button _btnR;
        private System.Windows.Forms.Button _btnRR;
        private System.Windows.Forms.Label lblIdPersonne;
        private System.Windows.Forms.Label _lblIdPersonne;
        private System.Windows.Forms.Label lblRecapitulatif;
        private System.Windows.Forms.PictureBox picBordure;
        private System.Windows.Forms.PictureBox picQuitter;
    }
}