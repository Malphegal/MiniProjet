namespace miniProjet2017
{
    partial class frmOption
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
            this.lblNombreSMSTransaction = new System.Windows.Forms.Label();
            this.txtPourcentageSMS = new System.Windows.Forms.TextBox();
            this.lblPourcent = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblBaseDonnee = new System.Windows.Forms.Label();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.lblSourceBaseDonnee = new System.Windows.Forms.Label();
            this.btnBaseDonnee = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.txtResolution = new System.Windows.Forms.TextBox();
            this.lblResolutionMax = new System.Windows.Forms.Label();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.picBordure = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreSMSTransaction
            // 
            this.lblNombreSMSTransaction.AutoSize = true;
            this.lblNombreSMSTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSMSTransaction.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreSMSTransaction.Location = new System.Drawing.Point(26, 148);
            this.lblNombreSMSTransaction.Name = "lblNombreSMSTransaction";
            this.lblNombreSMSTransaction.Size = new System.Drawing.Size(246, 15);
            this.lblNombreSMSTransaction.TabIndex = 0;
            this.lblNombreSMSTransaction.Text = "Valeur du reçu SMS en pourcentage :";
            // 
            // txtPourcentageSMS
            // 
            this.txtPourcentageSMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txtPourcentageSMS.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPourcentageSMS.Location = new System.Drawing.Point(277, 147);
            this.txtPourcentageSMS.Name = "txtPourcentageSMS";
            this.txtPourcentageSMS.Size = new System.Drawing.Size(43, 20);
            this.txtPourcentageSMS.TabIndex = 1;
            this.txtPourcentageSMS.TextChanged += new System.EventHandler(this.MiseAJourDeLaValeurPourcentSMS);
            this.txtPourcentageSMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntrerUneValeurPourcentageSMS);
            // 
            // lblPourcent
            // 
            this.lblPourcent.AutoSize = true;
            this.lblPourcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPourcent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPourcent.Location = new System.Drawing.Point(326, 150);
            this.lblPourcent.Name = "lblPourcent";
            this.lblPourcent.Size = new System.Drawing.Size(16, 13);
            this.lblPourcent.TabIndex = 2;
            this.lblPourcent.Text = "%";
            // 
            // btnRetour
            // 
            this.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRetour.Location = new System.Drawing.Point(347, 296);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(66, 41);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "OK";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.FermerFrmOption);
            // 
            // lblBaseDonnee
            // 
            this.lblBaseDonnee.AutoSize = true;
            this.lblBaseDonnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseDonnee.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBaseDonnee.Location = new System.Drawing.Point(153, 64);
            this.lblBaseDonnee.Name = "lblBaseDonnee";
            this.lblBaseDonnee.Size = new System.Drawing.Size(119, 15);
            this.lblBaseDonnee.TabIndex = 6;
            this.lblBaseDonnee.Text = "Base de donnée :";
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // lblSourceBaseDonnee
            // 
            this.lblSourceBaseDonnee.AutoSize = true;
            this.lblSourceBaseDonnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceBaseDonnee.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSourceBaseDonnee.Location = new System.Drawing.Point(26, 87);
            this.lblSourceBaseDonnee.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblSourceBaseDonnee.Name = "lblSourceBaseDonnee";
            this.lblSourceBaseDonnee.Size = new System.Drawing.Size(115, 13);
            this.lblSourceBaseDonnee.TabIndex = 7;
            this.lblSourceBaseDonnee.Text = "budget1.mdb - OFF";
            // 
            // btnBaseDonnee
            // 
            this.btnBaseDonnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.btnBaseDonnee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaseDonnee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaseDonnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseDonnee.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBaseDonnee.Location = new System.Drawing.Point(277, 62);
            this.btnBaseDonnee.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaseDonnee.Name = "btnBaseDonnee";
            this.btnBaseDonnee.Size = new System.Drawing.Size(40, 20);
            this.btnBaseDonnee.TabIndex = 0;
            this.btnBaseDonnee.Text = "•••";
            this.btnBaseDonnee.UseVisualStyleBackColor = false;
            this.btnBaseDonnee.Click += new System.EventHandler(this.ChangerBaseDeDonnee);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitre.Location = new System.Drawing.Point(160, 21);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(112, 25);
            this.lblTitre.TabIndex = 9;
            this.lblTitre.Text = "OPTIONS";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolution.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResolution.Location = new System.Drawing.Point(112, 176);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(160, 15);
            this.lblResolution.TabIndex = 10;
            this.lblResolution.Text = "Valeur de la résolution :";
            // 
            // txtResolution
            // 
            this.txtResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txtResolution.ForeColor = System.Drawing.SystemColors.Control;
            this.txtResolution.Location = new System.Drawing.Point(277, 175);
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(43, 20);
            this.txtResolution.TabIndex = 2;
            this.txtResolution.TextChanged += new System.EventHandler(this.MiseAJourDeLaResolution);
            this.txtResolution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntrerUneValeurResolution);
            // 
            // lblResolutionMax
            // 
            this.lblResolutionMax.AutoSize = true;
            this.lblResolutionMax.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResolutionMax.Location = new System.Drawing.Point(326, 181);
            this.lblResolutionMax.Name = "lblResolutionMax";
            this.lblResolutionMax.Size = new System.Drawing.Size(21, 13);
            this.lblResolutionMax.TabIndex = 12;
            this.lblResolutionMax.Text = "/ 3";
            // 
            // picQuitter
            // 
            this.picQuitter.BackColor = System.Drawing.Color.Transparent;
            this.picQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.flecheRetour;
            this.picQuitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picQuitter.Location = new System.Drawing.Point(363, 21);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(50, 50);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 4;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.FermerFrmOption);
            // 
            // picBordure
            // 
            this.picBordure.Image = global::miniProjet2017.Properties.Resources.bordureOption;
            this.picBordure.Location = new System.Drawing.Point(0, 0);
            this.picBordure.Name = "picBordure";
            this.picBordure.Size = new System.Drawing.Size(443, 365);
            this.picBordure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBordure.TabIndex = 5;
            this.picBordure.TabStop = false;
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(441, 364);
            this.Controls.Add(this.lblResolutionMax);
            this.Controls.Add(this.txtResolution);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnBaseDonnee);
            this.Controls.Add(this.lblSourceBaseDonnee);
            this.Controls.Add(this.lblBaseDonnee);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblPourcent);
            this.Controls.Add(this.txtPourcentageSMS);
            this.Controls.Add(this.lblNombreSMSTransaction);
            this.Controls.Add(this.picBordure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(441, 364);
            this.MinimumSize = new System.Drawing.Size(441, 364);
            this.Name = "frmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOption";
            this.Load += new System.EventHandler(this.ChargementDeFrmOption);
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreSMSTransaction;
        private System.Windows.Forms.TextBox txtPourcentageSMS;
        private System.Windows.Forms.Label lblPourcent;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.PictureBox picQuitter;
        private System.Windows.Forms.PictureBox picBordure;
        private System.Windows.Forms.Label lblBaseDonnee;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Label lblSourceBaseDonnee;
        private System.Windows.Forms.Button btnBaseDonnee;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.TextBox txtResolution;
        private System.Windows.Forms.Label lblResolutionMax;
    }
}