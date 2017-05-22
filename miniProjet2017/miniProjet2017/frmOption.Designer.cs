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
            this.SuspendLayout();
            // 
            // lblNombreSMSTransaction
            // 
            this.lblNombreSMSTransaction.AutoSize = true;
            this.lblNombreSMSTransaction.Location = new System.Drawing.Point(26, 23);
            this.lblNombreSMSTransaction.Name = "lblNombreSMSTransaction";
            this.lblNombreSMSTransaction.Size = new System.Drawing.Size(186, 13);
            this.lblNombreSMSTransaction.TabIndex = 0;
            this.lblNombreSMSTransaction.Text = "Valeur du reçu SMS en pourcentage :";
            // 
            // txtPourcentageSMS
            // 
            this.txtPourcentageSMS.Location = new System.Drawing.Point(218, 20);
            this.txtPourcentageSMS.Name = "txtPourcentageSMS";
            this.txtPourcentageSMS.Size = new System.Drawing.Size(43, 20);
            this.txtPourcentageSMS.TabIndex = 1;
            this.txtPourcentageSMS.TextChanged += new System.EventHandler(this.MiseAJourDeLaValeurPourcentSMS);
            this.txtPourcentageSMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntrerUneValeurPourcentageSMS);
            // 
            // lblPourcent
            // 
            this.lblPourcent.AutoSize = true;
            this.lblPourcent.Location = new System.Drawing.Point(267, 23);
            this.lblPourcent.Name = "lblPourcent";
            this.lblPourcent.Size = new System.Drawing.Size(15, 13);
            this.lblPourcent.TabIndex = 2;
            this.lblPourcent.Text = "%";
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblPourcent);
            this.Controls.Add(this.txtPourcentageSMS);
            this.Controls.Add(this.lblNombreSMSTransaction);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreSMSTransaction;
        private System.Windows.Forms.TextBox txtPourcentageSMS;
        private System.Windows.Forms.Label lblPourcent;
    }
}