namespace miniProjet2017
{
    partial class frmPosteRevenu
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
            this.picBordure = new System.Windows.Forms.PictureBox();
            this.lblIntitule = new System.Windows.Forms.Label();
            this.lblBenef = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtJourMois = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cboPersonne = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // picBordure
            // 
            this.picBordure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.picBordure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBordure.Image = global::miniProjet2017.Properties.Resources.bordureOption;
            this.picBordure.Location = new System.Drawing.Point(0, 0);
            this.picBordure.Name = "picBordure";
            this.picBordure.Size = new System.Drawing.Size(466, 448);
            this.picBordure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBordure.TabIndex = 58;
            this.picBordure.TabStop = false;
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIntitule.Location = new System.Drawing.Point(79, 140);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(110, 13);
            this.lblIntitule.TabIndex = 60;
            this.lblIntitule.Text = "Description du poste :";
            // 
            // lblBenef
            // 
            this.lblBenef.AutoSize = true;
            this.lblBenef.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBenef.Location = new System.Drawing.Point(79, 198);
            this.lblBenef.Name = "lblBenef";
            this.lblBenef.Size = new System.Drawing.Size(112, 13);
            this.lblBenef.TabIndex = 61;
            this.lblBenef.Text = "Personne concernée :";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMontant.Location = new System.Drawing.Point(137, 270);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(52, 13);
            this.lblMontant.TabIndex = 62;
            this.lblMontant.Text = "Montant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(94, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Jour du mois,    le :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(238, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "du mois";
            // 
            // txtDescri
            // 
            this.txtDescri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txtDescri.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDescri.Location = new System.Drawing.Point(196, 140);
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(147, 20);
            this.txtDescri.TabIndex = 65;
            // 
            // txtMontant
            // 
            this.txtMontant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txtMontant.ForeColor = System.Drawing.SystemColors.Control;
            this.txtMontant.Location = new System.Drawing.Point(196, 270);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(147, 20);
            this.txtMontant.TabIndex = 67;
            // 
            // txtJourMois
            // 
            this.txtJourMois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txtJourMois.ForeColor = System.Drawing.SystemColors.Control;
            this.txtJourMois.Location = new System.Drawing.Point(196, 327);
            this.txtJourMois.Name = "txtJourMois";
            this.txtJourMois.Size = new System.Drawing.Size(36, 20);
            this.txtJourMois.TabIndex = 68;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitre.Location = new System.Drawing.Point(135, 25);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(214, 37);
            this.lblTitre.TabIndex = 69;
            this.lblTitre.Text = "Poste Revenu";
            // 
            // cboPersonne
            // 
            this.cboPersonne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.cboPersonne.ForeColor = System.Drawing.SystemColors.Control;
            this.cboPersonne.FormattingEnabled = true;
            this.cboPersonne.Location = new System.Drawing.Point(196, 198);
            this.cboPersonne.Name = "cboPersonne";
            this.cboPersonne.Size = new System.Drawing.Size(147, 21);
            this.cboPersonne.TabIndex = 71;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(80)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAjouter.Location = new System.Drawing.Point(289, 377);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAjouter.Size = new System.Drawing.Size(145, 28);
            this.btnAjouter.TabIndex = 72;
            this.btnAjouter.Text = "Ajouter le revenu";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.AjouterLePosteRevenu);
            // 
            // picQuitter
            // 
            this.picQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.picQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.flecheRetour;
            this.picQuitter.Location = new System.Drawing.Point(365, 34);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(69, 68);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 73;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.QuitterFrmAffichage);
            this.picQuitter.MouseEnter += new System.EventHandler(this.SourisSurPicQuitter);
            this.picQuitter.MouseLeave += new System.EventHandler(this.SourisSortDePicQuitter);
            // 
            // frmPosteRevenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(466, 448);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cboPersonne);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtJourMois);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtDescri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblBenef);
            this.Controls.Add(this.lblIntitule);
            this.Controls.Add(this.picBordure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(466, 448);
            this.MinimumSize = new System.Drawing.Size(466, 448);
            this.Name = "frmPosteRevenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Poste Revenu";
            this.Load += new System.EventHandler(this.ChargementDeFrmPosteRevenu);
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBordure;
        private System.Windows.Forms.Label lblIntitule;
        private System.Windows.Forms.Label lblBenef;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtJourMois;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cboPersonne;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.PictureBox picQuitter;
    }
}