namespace miniProjet2017
{
    partial class frmPostePonctuel
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
            this.lblIntitule = new System.Windows.Forms.Label();
            this.lblDescri = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.txtNbPreleve = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnValider = new System.Windows.Forms.Button();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.picBordure = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cboTypePoste = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIntitule.Location = new System.Drawing.Point(113, 86);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(44, 13);
            this.lblIntitule.TabIndex = 0;
            this.lblIntitule.Text = "Intitulé :";
            // 
            // lblDescri
            // 
            this.lblDescri.AutoSize = true;
            this.lblDescri.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescri.Location = new System.Drawing.Point(91, 137);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(66, 13);
            this.lblDescri.TabIndex = 5;
            this.lblDescri.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(26, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre de prélévements :";
            // 
            // txtDescri
            // 
            this.txtDescri.Location = new System.Drawing.Point(218, 134);
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(100, 20);
            this.txtDescri.TabIndex = 2;
            // 
            // txtNbPreleve
            // 
            this.txtNbPreleve.Location = new System.Drawing.Point(218, 188);
            this.txtNbPreleve.Name = "txtNbPreleve";
            this.txtNbPreleve.Size = new System.Drawing.Size(43, 20);
            this.txtNbPreleve.TabIndex = 3;
            this.txtNbPreleve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisirUnNombreDePrelevement);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnValider
            // 
            this.btnValider.BackgroundImage = global::miniProjet2017.Properties.Resources.validate;
            this.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Location = new System.Drawing.Point(400, 146);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(50, 50);
            this.btnValider.TabIndex = 7;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.AjouterLePostePonctuel);
            // 
            // picQuitter
            // 
            this.picQuitter.BackColor = System.Drawing.Color.Transparent;
            this.picQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.flecheRetour;
            this.picQuitter.Location = new System.Drawing.Point(387, 36);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(63, 67);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 56;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.QuitterFrmPostePonctuel);
            this.picQuitter.MouseEnter += new System.EventHandler(this.SourisSurPicQuitter);
            this.picQuitter.MouseLeave += new System.EventHandler(this.SourisSortDePicQuitter);
            // 
            // picBordure
            // 
            this.picBordure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.picBordure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBordure.Image = global::miniProjet2017.Properties.Resources.bordureOption;
            this.picBordure.Location = new System.Drawing.Point(0, 0);
            this.picBordure.Name = "picBordure";
            this.picBordure.Size = new System.Drawing.Size(490, 460);
            this.picBordure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBordure.TabIndex = 57;
            this.picBordure.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitre.Location = new System.Drawing.Point(131, 24);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(231, 37);
            this.lblTitre.TabIndex = 70;
            this.lblTitre.Text = "Poste Ponctuel";
            // 
            // cboTypePoste
            // 
            this.cboTypePoste.FormattingEnabled = true;
            this.cboTypePoste.Location = new System.Drawing.Point(218, 83);
            this.cboTypePoste.Name = "cboTypePoste";
            this.cboTypePoste.Size = new System.Drawing.Size(121, 21);
            this.cboTypePoste.TabIndex = 71;
            // 
            // frmPostePonctuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(490, 460);
            this.Controls.Add(this.cboTypePoste);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtNbPreleve);
            this.Controls.Add(this.txtDescri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDescri);
            this.Controls.Add(this.lblIntitule);
            this.Controls.Add(this.picBordure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(490, 460);
            this.MinimumSize = new System.Drawing.Size(490, 460);
            this.Name = "frmPostePonctuel";
            this.Text = "Postes ponctuels";
            this.Load += new System.EventHandler(this.ChargementDuFormulaire);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntitule;
        private System.Windows.Forms.Label lblDescri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.TextBox txtNbPreleve;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.PictureBox picQuitter;
        private System.Windows.Forms.PictureBox picBordure;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cboTypePoste;
    }
}