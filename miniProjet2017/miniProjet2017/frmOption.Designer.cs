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
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBaseDonnee = new System.Windows.Forms.Label();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.lblSourceBaseDonnee = new System.Windows.Forms.Label();
            this.btnBaseDonnee = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.txtResolution = new System.Windows.Forms.TextBox();
            this.lblResolutionMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreSMSTransaction
            // 
            this.lblNombreSMSTransaction.AutoSize = true;
            this.lblNombreSMSTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSMSTransaction.ForeColor = System.Drawing.Color.Maroon;
            this.lblNombreSMSTransaction.Location = new System.Drawing.Point(26, 148);
            this.lblNombreSMSTransaction.Name = "lblNombreSMSTransaction";
            this.lblNombreSMSTransaction.Size = new System.Drawing.Size(246, 15);
            this.lblNombreSMSTransaction.TabIndex = 0;
            this.lblNombreSMSTransaction.Text = "Valeur du reçu SMS en pourcentage :";
            // 
            // txtPourcentageSMS
            // 
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
            this.lblPourcent.Location = new System.Drawing.Point(326, 150);
            this.lblPourcent.Name = "lblPourcent";
            this.lblPourcent.Size = new System.Drawing.Size(15, 13);
            this.lblPourcent.TabIndex = 2;
            this.lblPourcent.Text = "%";
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(363, 311);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(66, 41);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "OK";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.FermerFrmOption);
            // 
            // picQuitter
            // 
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.croixQuitter;
            this.picQuitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picQuitter.Location = new System.Drawing.Point(400, 12);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(29, 29);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 4;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.FermerFrmOption);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::miniProjet2017.Properties.Resources.bordureOption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblBaseDonnee
            // 
            this.lblBaseDonnee.AutoSize = true;
            this.lblBaseDonnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseDonnee.ForeColor = System.Drawing.Color.Maroon;
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
            this.lblSourceBaseDonnee.Location = new System.Drawing.Point(26, 87);
            this.lblSourceBaseDonnee.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblSourceBaseDonnee.Name = "lblSourceBaseDonnee";
            this.lblSourceBaseDonnee.Size = new System.Drawing.Size(98, 13);
            this.lblSourceBaseDonnee.TabIndex = 7;
            this.lblSourceBaseDonnee.Text = "budget1.mdb - OFF";
            // 
            // btnBaseDonnee
            // 
            this.btnBaseDonnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseDonnee.Location = new System.Drawing.Point(277, 62);
            this.btnBaseDonnee.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaseDonnee.Name = "btnBaseDonnee";
            this.btnBaseDonnee.Size = new System.Drawing.Size(40, 20);
            this.btnBaseDonnee.TabIndex = 0;
            this.btnBaseDonnee.Text = "•••";
            this.btnBaseDonnee.UseVisualStyleBackColor = true;
            this.btnBaseDonnee.Click += new System.EventHandler(this.ChangerBaseDeDonnee);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(163, 16);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(102, 25);
            this.lblTitre.TabIndex = 9;
            this.lblTitre.Text = "OPTIONS";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolution.ForeColor = System.Drawing.Color.Maroon;
            this.lblResolution.Location = new System.Drawing.Point(112, 176);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(160, 15);
            this.lblResolution.TabIndex = 10;
            this.lblResolution.Text = "Valeur de la résolution :";
            // 
            // txtResolution
            // 
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
            this.lblResolutionMax.Location = new System.Drawing.Point(326, 181);
            this.lblResolutionMax.Name = "lblResolutionMax";
            this.lblResolutionMax.Size = new System.Drawing.Size(21, 13);
            this.lblResolutionMax.TabIndex = 12;
            this.lblResolutionMax.Text = "/ 3";
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(441, 364);
            this.MinimumSize = new System.Drawing.Size(441, 364);
            this.Name = "frmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOption";
            this.Load += new System.EventHandler(this.ChargementDeFrmOption);
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreSMSTransaction;
        private System.Windows.Forms.TextBox txtPourcentageSMS;
        private System.Windows.Forms.Label lblPourcent;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.PictureBox picQuitter;
        private System.Windows.Forms.PictureBox pictureBox1;
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