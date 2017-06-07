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
            this.lblIntitule = new System.Windows.Forms.Label();
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.lblDescri = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.txtNbPreleve = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.Location = new System.Drawing.Point(28, 15);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(44, 13);
            this.lblIntitule.TabIndex = 0;
            this.lblIntitule.Text = "Intitulé :";
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(221, 12);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(100, 20);
            this.txtIntitule.TabIndex = 1;
            // 
            // lblDescri
            // 
            this.lblDescri.AutoSize = true;
            this.lblDescri.Location = new System.Drawing.Point(28, 79);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(66, 13);
            this.lblDescri.TabIndex = 5;
            this.lblDescri.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre de prélévements :";
            // 
            // txtDescri
            // 
            this.txtDescri.Location = new System.Drawing.Point(221, 76);
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(100, 20);
            this.txtDescri.TabIndex = 2;
            // 
            // txtNbPreleve
            // 
            this.txtNbPreleve.Location = new System.Drawing.Point(221, 137);
            this.txtNbPreleve.Name = "txtNbPreleve";
            this.txtNbPreleve.Size = new System.Drawing.Size(43, 20);
            this.txtNbPreleve.TabIndex = 3;
            this.txtNbPreleve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNbPreleve_KeyPress);
            // 
            // frmPostePonctuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 448);
            this.Controls.Add(this.txtNbPreleve);
            this.Controls.Add(this.txtDescri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDescri);
            this.Controls.Add(this.txtIntitule);
            this.Controls.Add(this.lblIntitule);
            this.Name = "frmPostePonctuel";
            this.Text = "Postes ponctuels";
            this.Load += new System.EventHandler(this.frmPostePonctuel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntitule;
        private System.Windows.Forms.TextBox txtIntitule;
        private System.Windows.Forms.Label lblDescri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.TextBox txtNbPreleve;
    }
}