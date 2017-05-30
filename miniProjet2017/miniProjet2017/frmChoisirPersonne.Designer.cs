namespace miniProjet2017
{
    partial class frmChoisirPersonne
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
            this.pnlPersonne = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.picBordure = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPersonne
            // 
            this.pnlPersonne.AutoScroll = true;
            this.pnlPersonne.Location = new System.Drawing.Point(26, 58);
            this.pnlPersonne.Name = "pnlPersonne";
            this.pnlPersonne.Size = new System.Drawing.Size(436, 198);
            this.pnlPersonne.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Italic);
            this.lblTitre.Location = new System.Drawing.Point(88, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(316, 36);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Choisir les participants";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = global::miniProjet2017.Properties.Resources.cancel;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Location = new System.Drawing.Point(413, 262);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(46, 46);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.QuitterFrmChoisirPersonne);
            // 
            // btnValider
            // 
            this.btnValider.BackgroundImage = global::miniProjet2017.Properties.Resources.validate;
            this.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValider.Location = new System.Drawing.Point(352, 262);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(46, 46);
            this.btnValider.TabIndex = 5;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.CliquerSurValider);
            // 
            // picBordure
            // 
            this.picBordure.Image = global::miniProjet2017.Properties.Resources.bordureOption;
            this.picBordure.Location = new System.Drawing.Point(0, 0);
            this.picBordure.Name = "picBordure";
            this.picBordure.Size = new System.Drawing.Size(490, 320);
            this.picBordure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBordure.TabIndex = 7;
            this.picBordure.TabStop = false;
            // 
            // frmChoisirPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 320);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pnlPersonne);
            this.Controls.Add(this.picBordure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChoisirPersonne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choisir les personnes";
            this.Load += new System.EventHandler(this.RemplirLePanelDesPersonnes);
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPersonne;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.PictureBox picBordure;
    }
}