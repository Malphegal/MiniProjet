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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOption));
            this.lblNombreSMSTransaction = new System.Windows.Forms.Label();
            this.txtPourcentageSMS = new System.Windows.Forms.TextBox();
            this.lblPourcent = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreSMSTransaction
            // 
            this.lblNombreSMSTransaction.AutoSize = true;
            this.lblNombreSMSTransaction.Location = new System.Drawing.Point(24, 49);
            this.lblNombreSMSTransaction.Name = "lblNombreSMSTransaction";
            this.lblNombreSMSTransaction.Size = new System.Drawing.Size(186, 13);
            this.lblNombreSMSTransaction.TabIndex = 0;
            this.lblNombreSMSTransaction.Text = "Valeur du reçu SMS en pourcentage :";
            // 
            // txtPourcentageSMS
            // 
            this.txtPourcentageSMS.Location = new System.Drawing.Point(216, 46);
            this.txtPourcentageSMS.Name = "txtPourcentageSMS";
            this.txtPourcentageSMS.Size = new System.Drawing.Size(43, 20);
            this.txtPourcentageSMS.TabIndex = 1;
            this.txtPourcentageSMS.TextChanged += new System.EventHandler(this.MiseAJourDeLaValeurPourcentSMS);
            this.txtPourcentageSMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntrerUneValeurPourcentageSMS);
            // 
            // lblPourcent
            // 
            this.lblPourcent.AutoSize = true;
            this.lblPourcent.Location = new System.Drawing.Point(265, 49);
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 364);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblPourcent);
            this.Controls.Add(this.txtPourcentageSMS);
            this.Controls.Add(this.lblNombreSMSTransaction);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOption";
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
    }
}