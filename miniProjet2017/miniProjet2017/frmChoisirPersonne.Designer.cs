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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.pnlPersonne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(95)))));
            this.pnlPersonne.Location = new System.Drawing.Point(26, 58);
            this.pnlPersonne.Name = "pnlPersonne";
            this.pnlPersonne.Size = new System.Drawing.Size(439, 198);
            this.pnlPersonne.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(162, 268);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "• Tout cocher";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitre.Location = new System.Drawing.Point(70, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(350, 35);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Choisir les participants";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnQuitter.BackgroundImage = global::miniProjet2017.Properties.Resources.cancel;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Location = new System.Drawing.Point(396, 256);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(46, 46);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.QuitterFrmChoisirPersonne);
            // 
            // btnValider
            // 
            this.btnValider.AutoSize = true;
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnValider.BackgroundImage = global::miniProjet2017.Properties.Resources.validate;
            this.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Location = new System.Drawing.Point(330, 256);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(48, 46);
            this.btnValider.TabIndex = 5;
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.CliquerSurValider);
            // 
            // picBordure
            // 
            this.picBordure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
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
            this.Controls.Add(this.checkBox1);
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
        private System.Windows.Forms.CheckBox checkBox1;
    }
}