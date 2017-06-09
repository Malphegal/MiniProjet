namespace miniProjet2017
{
    partial class frmSupprTransac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupprTransac));
            this.lblTitre = new System.Windows.Forms.Label();
            this.cboTransactions = new System.Windows.Forms.ComboBox();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRecette = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this._lblId = new System.Windows.Forms.Label();
            this._lblDate = new System.Windows.Forms.Label();
            this._lblType = new System.Windows.Forms.Label();
            this._lblDescription = new System.Windows.Forms.Label();
            this._lblRecette = new System.Windows.Forms.Label();
            this._lblMontant = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.picLigneVerte3 = new System.Windows.Forms.PictureBox();
            this.picLigneVerte6 = new System.Windows.Forms.PictureBox();
            this.picLigneVerte5 = new System.Windows.Forms.PictureBox();
            this.picLigneVerte4 = new System.Windows.Forms.PictureBox();
            this.picLigneVerte1 = new System.Windows.Forms.PictureBox();
            this.picLigneVerte2 = new System.Windows.Forms.PictureBox();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.picBordure = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitre.Location = new System.Drawing.Point(187, 44);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(331, 31);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Supprimer une transaction";
            // 
            // cboTransactions
            // 
            this.cboTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.cboTransactions.ForeColor = System.Drawing.SystemColors.Control;
            this.cboTransactions.FormattingEnabled = true;
            this.cboTransactions.Location = new System.Drawing.Point(202, 143);
            this.cboTransactions.Name = "cboTransactions";
            this.cboTransactions.Size = new System.Drawing.Size(298, 21);
            this.cboTransactions.TabIndex = 2;
            this.cboTransactions.SelectedIndexChanged += new System.EventHandler(this.cboTransactions_SelectedIndexChanged);
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactions.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTransactions.Location = new System.Drawing.Point(262, 120);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(171, 20);
            this.lblTransactions.TabIndex = 3;
            this.lblTransactions.Text = "Choisir une transaction";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Location = new System.Drawing.Point(97, 292);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 18);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecette.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRecette.Location = new System.Drawing.Point(294, 292);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(130, 18);
            this.lblRecette.TabIndex = 6;
            this.lblRecette.Text = "Recette / Dépense";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMontant.Location = new System.Drawing.Point(551, 292);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(62, 18);
            this.lblMontant.TabIndex = 7;
            this.lblMontant.Text = "Montant";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblType.Location = new System.Drawing.Point(561, 188);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 18);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblId.Location = new System.Drawing.Point(131, 188);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 18);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Id";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(342, 188);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date";
            // 
            // _lblId
            // 
            this._lblId.AutoSize = true;
            this._lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblId.ForeColor = System.Drawing.SystemColors.Control;
            this._lblId.Location = new System.Drawing.Point(81, 243);
            this._lblId.Name = "_lblId";
            this._lblId.Size = new System.Drawing.Size(28, 13);
            this._lblId.TabIndex = 18;
            this._lblId.Text = "[ID]";
            // 
            // _lblDate
            // 
            this._lblDate.AutoSize = true;
            this._lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this._lblDate.Location = new System.Drawing.Point(304, 243);
            this._lblDate.Name = "_lblDate";
            this._lblDate.Size = new System.Drawing.Size(48, 13);
            this._lblDate.TabIndex = 19;
            this._lblDate.Text = "[DATE]";
            // 
            // _lblType
            // 
            this._lblType.AutoSize = true;
            this._lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblType.ForeColor = System.Drawing.SystemColors.Control;
            this._lblType.Location = new System.Drawing.Point(529, 243);
            this._lblType.Name = "_lblType";
            this._lblType.Size = new System.Drawing.Size(47, 13);
            this._lblType.TabIndex = 20;
            this._lblType.Text = "[TYPE]";
            // 
            // _lblDescription
            // 
            this._lblDescription.AutoSize = true;
            this._lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDescription.ForeColor = System.Drawing.SystemColors.Control;
            this._lblDescription.Location = new System.Drawing.Point(81, 349);
            this._lblDescription.Name = "_lblDescription";
            this._lblDescription.Size = new System.Drawing.Size(99, 13);
            this._lblDescription.TabIndex = 21;
            this._lblDescription.Text = "[DESCRIPTION]";
            // 
            // _lblRecette
            // 
            this._lblRecette.AutoSize = true;
            this._lblRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRecette.ForeColor = System.Drawing.SystemColors.Control;
            this._lblRecette.Location = new System.Drawing.Point(304, 349);
            this._lblRecette.Name = "_lblRecette";
            this._lblRecette.Size = new System.Drawing.Size(72, 13);
            this._lblRecette.TabIndex = 22;
            this._lblRecette.Text = "[RECETTE]";
            // 
            // _lblMontant
            // 
            this._lblMontant.AutoSize = true;
            this._lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMontant.ForeColor = System.Drawing.SystemColors.Control;
            this._lblMontant.Location = new System.Drawing.Point(529, 349);
            this._lblMontant.Name = "_lblMontant";
            this._lblMontant.Size = new System.Drawing.Size(76, 13);
            this._lblMontant.TabIndex = 23;
            this._lblMontant.Text = "[MONTANT]";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.BackgroundImage = global::miniProjet2017.Properties.Resources.boutonFondBleu;
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Location = new System.Drawing.Point(283, 402);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(150, 53);
            this.btnSupprimer.TabIndex = 24;
            this.btnSupprimer.Text = "Supprimer cette transaction";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // picLigneVerte3
            // 
            this.picLigneVerte3.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.picLigneVerte3.Location = new System.Drawing.Point(499, 193);
            this.picLigneVerte3.Name = "picLigneVerte3";
            this.picLigneVerte3.Size = new System.Drawing.Size(150, 30);
            this.picLigneVerte3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLigneVerte3.TabIndex = 17;
            this.picLigneVerte3.TabStop = false;
            // 
            // picLigneVerte6
            // 
            this.picLigneVerte6.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.picLigneVerte6.Location = new System.Drawing.Point(499, 299);
            this.picLigneVerte6.Name = "picLigneVerte6";
            this.picLigneVerte6.Size = new System.Drawing.Size(150, 30);
            this.picLigneVerte6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLigneVerte6.TabIndex = 16;
            this.picLigneVerte6.TabStop = false;
            // 
            // picLigneVerte5
            // 
            this.picLigneVerte5.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.picLigneVerte5.Location = new System.Drawing.Point(283, 299);
            this.picLigneVerte5.Name = "picLigneVerte5";
            this.picLigneVerte5.Size = new System.Drawing.Size(150, 30);
            this.picLigneVerte5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLigneVerte5.TabIndex = 15;
            this.picLigneVerte5.TabStop = false;
            // 
            // picLigneVerte4
            // 
            this.picLigneVerte4.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.picLigneVerte4.Location = new System.Drawing.Point(59, 299);
            this.picLigneVerte4.Name = "picLigneVerte4";
            this.picLigneVerte4.Size = new System.Drawing.Size(150, 30);
            this.picLigneVerte4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLigneVerte4.TabIndex = 14;
            this.picLigneVerte4.TabStop = false;
            // 
            // picLigneVerte1
            // 
            this.picLigneVerte1.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.picLigneVerte1.Location = new System.Drawing.Point(58, 195);
            this.picLigneVerte1.Name = "picLigneVerte1";
            this.picLigneVerte1.Size = new System.Drawing.Size(150, 30);
            this.picLigneVerte1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLigneVerte1.TabIndex = 13;
            this.picLigneVerte1.TabStop = false;
            // 
            // picLigneVerte2
            // 
            this.picLigneVerte2.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.picLigneVerte2.Location = new System.Drawing.Point(283, 193);
            this.picLigneVerte2.Name = "picLigneVerte2";
            this.picLigneVerte2.Size = new System.Drawing.Size(150, 30);
            this.picLigneVerte2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLigneVerte2.TabIndex = 12;
            this.picLigneVerte2.TabStop = false;
            // 
            // picQuitter
            // 
            this.picQuitter.BackColor = System.Drawing.Color.Transparent;
            this.picQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picQuitter.Image = ((System.Drawing.Image)(resources.GetObject("picQuitter.Image")));
            this.picQuitter.Location = new System.Drawing.Point(621, 25);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(50, 50);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 4;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.QuitterFrmSupprTransac);
            this.picQuitter.MouseEnter += new System.EventHandler(this.SourisSurPicQuitter);
            this.picQuitter.MouseLeave += new System.EventHandler(this.SourisSortDePicQuitter);
            // 
            // picBordure
            // 
            this.picBordure.Image = global::miniProjet2017.Properties.Resources.bordureOption;
            this.picBordure.Location = new System.Drawing.Point(0, 0);
            this.picBordure.Name = "picBordure";
            this.picBordure.Size = new System.Drawing.Size(700, 500);
            this.picBordure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBordure.TabIndex = 0;
            this.picBordure.TabStop = false;
            // 
            // frmSupprTransac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this._lblMontant);
            this.Controls.Add(this._lblRecette);
            this.Controls.Add(this._lblDescription);
            this.Controls.Add(this._lblType);
            this.Controls.Add(this._lblDate);
            this.Controls.Add(this._lblId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.picLigneVerte3);
            this.Controls.Add(this.picLigneVerte6);
            this.Controls.Add(this.lblRecette);
            this.Controls.Add(this.picLigneVerte5);
            this.Controls.Add(this.picLigneVerte4);
            this.Controls.Add(this.picLigneVerte1);
            this.Controls.Add(this.picLigneVerte2);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.lblTransactions);
            this.Controls.Add(this.cboTransactions);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.picBordure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "frmSupprTransac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSupprTransac";
            this.Load += new System.EventHandler(this.ChargementDeFrmSupprimerTransaction);
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigneVerte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBordure;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cboTransactions;
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.PictureBox picQuitter;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRecette;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox picLigneVerte2;
        private System.Windows.Forms.PictureBox picLigneVerte1;
        private System.Windows.Forms.PictureBox picLigneVerte4;
        private System.Windows.Forms.PictureBox picLigneVerte5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox picLigneVerte6;
        private System.Windows.Forms.PictureBox picLigneVerte3;
        private System.Windows.Forms.Label _lblId;
        private System.Windows.Forms.Label _lblDate;
        private System.Windows.Forms.Label _lblType;
        private System.Windows.Forms.Label _lblDescription;
        private System.Windows.Forms.Label _lblRecette;
        private System.Windows.Forms.Label _lblMontant;
        private System.Windows.Forms.Button btnSupprimer;
    }
}