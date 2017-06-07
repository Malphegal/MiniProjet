namespace miniProjet2017
{
    partial class frmPostFixe
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
            this.lblPoste = new System.Windows.Forms.Label();
            this.cboPoste = new System.Windows.Forms.ComboBox();
            this.btnAutre = new System.Windows.Forms.Button();
            this.txtJour = new System.Windows.Forms.TextBox();
            this.lblPeriodicite = new System.Windows.Forms.Label();
            this.lblJour = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.cboPeriodicite = new System.Windows.Forms.ComboBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblMois = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picQuitter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPoste.Location = new System.Drawing.Point(47, 51);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(40, 13);
            this.lblPoste.TabIndex = 0;
            this.lblPoste.Text = "Poste :";
            // 
            // cboPoste
            // 
            this.cboPoste.FormattingEnabled = true;
            this.cboPoste.Location = new System.Drawing.Point(129, 49);
            this.cboPoste.Name = "cboPoste";
            this.cboPoste.Size = new System.Drawing.Size(195, 21);
            this.cboPoste.TabIndex = 0;
            // 
            // btnAutre
            // 
            this.btnAutre.Location = new System.Drawing.Point(304, 335);
            this.btnAutre.Name = "btnAutre";
            this.btnAutre.Size = new System.Drawing.Size(127, 23);
            this.btnAutre.TabIndex = 4;
            this.btnAutre.Text = "Autre[SERT A QUOI]";
            this.btnAutre.UseVisualStyleBackColor = true;
            // 
            // txtJour
            // 
            this.txtJour.Location = new System.Drawing.Point(159, 128);
            this.txtJour.Name = "txtJour";
            this.txtJour.Size = new System.Drawing.Size(28, 20);
            this.txtJour.TabIndex = 2;
            this.txtJour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisirUnJourDuMois);
            // 
            // lblPeriodicite
            // 
            this.lblPeriodicite.AutoSize = true;
            this.lblPeriodicite.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPeriodicite.Location = new System.Drawing.Point(47, 93);
            this.lblPeriodicite.Name = "lblPeriodicite";
            this.lblPeriodicite.Size = new System.Drawing.Size(62, 13);
            this.lblPeriodicite.TabIndex = 4;
            this.lblPeriodicite.Text = "Périodicité :";
            // 
            // lblJour
            // 
            this.lblJour.AutoSize = true;
            this.lblJour.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJour.Location = new System.Drawing.Point(46, 131);
            this.lblJour.Name = "lblJour";
            this.lblJour.Size = new System.Drawing.Size(72, 13);
            this.lblJour.TabIndex = 5;
            this.lblJour.Text = "Jour du mois :";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(129, 202);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(195, 20);
            this.txtMontant.TabIndex = 3;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisirUnJourDuMois);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(356, 386);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.AjouterLePoste);
            // 
            // cboPeriodicite
            // 
            this.cboPeriodicite.FormattingEnabled = true;
            this.cboPeriodicite.Location = new System.Drawing.Point(129, 90);
            this.cboPeriodicite.Name = "cboPeriodicite";
            this.cboPeriodicite.Size = new System.Drawing.Size(195, 21);
            this.cboPeriodicite.TabIndex = 1;
            this.cboPeriodicite.SelectedIndexChanged += new System.EventHandler(this.ChangerIndexCboPeriodicite);
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMontant.Location = new System.Drawing.Point(47, 205);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(52, 13);
            this.lblMontant.TabIndex = 9;
            this.lblMontant.Text = "Montant :";
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMois.Location = new System.Drawing.Point(193, 131);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(43, 13);
            this.lblMois.TabIndex = 10;
            this.lblMois.Text = "du mois";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEuro.Location = new System.Drawing.Point(330, 205);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(13, 13);
            this.lblEuro.TabIndex = 11;
            this.lblEuro.Text = "€";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picQuitter
            // 
            this.picQuitter.BackColor = System.Drawing.Color.Transparent;
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.flecheRetour;
            this.picQuitter.Location = new System.Drawing.Point(356, 35);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(79, 71);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 55;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.QuitterFrmPostFixe);
            // 
            // frmPostFixe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(466, 448);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblMois);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.cboPeriodicite);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblJour);
            this.Controls.Add(this.lblPeriodicite);
            this.Controls.Add(this.txtJour);
            this.Controls.Add(this.btnAutre);
            this.Controls.Add(this.cboPoste);
            this.Controls.Add(this.lblPoste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPostFixe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Poste fixe";
            this.Load += new System.EventHandler(this.DemarrageDeFrmPostFixe);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoste;
        private System.Windows.Forms.ComboBox cboPoste;
        private System.Windows.Forms.Button btnAutre;
        private System.Windows.Forms.TextBox txtJour;
        private System.Windows.Forms.Label lblPeriodicite;
        private System.Windows.Forms.Label lblJour;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cboPeriodicite;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox picQuitter;
    }
}