namespace miniProjet2017
{
    partial class frmSupprPoste
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
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.txtDescTran = new System.Windows.Forms.TextBox();
            this.cboListeBudget = new System.Windows.Forms.ComboBox();
            this.cboListeType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.picBordure.Size = new System.Drawing.Size(365, 334);
            this.picBordure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBordure.TabIndex = 12;
            this.picBordure.TabStop = false;
            // 
            // picQuitter
            // 
            this.picQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.picQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.flecheRetour;
            this.picQuitter.Location = new System.Drawing.Point(275, 21);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(69, 68);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 13;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.QuitterFrmBudgetRecap);
            // 
            // txtDescTran
            // 
            this.txtDescTran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txtDescTran.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDescTran.Location = new System.Drawing.Point(58, 124);
            this.txtDescTran.Name = "txtDescTran";
            this.txtDescTran.ShortcutsEnabled = false;
            this.txtDescTran.Size = new System.Drawing.Size(196, 20);
            this.txtDescTran.TabIndex = 14;
            // 
            // cboListeBudget
            // 
            this.cboListeBudget.FormattingEnabled = true;
            this.cboListeBudget.Location = new System.Drawing.Point(95, 85);
            this.cboListeBudget.Name = "cboListeBudget";
            this.cboListeBudget.Size = new System.Drawing.Size(121, 21);
            this.cboListeBudget.TabIndex = 15;
            // 
            // cboListeType
            // 
            this.cboListeType.FormattingEnabled = true;
            this.cboListeType.Items.AddRange(new object[] {
            "Les postes fixes",
            "Les postes ponctuels",
            "Les postes revenus"});
            this.cboListeType.Location = new System.Drawing.Point(95, 44);
            this.cboListeType.Name = "cboListeType";
            this.cboListeType.Size = new System.Drawing.Size(121, 21);
            this.cboListeType.TabIndex = 16;
            this.cboListeType.SelectedIndexChanged += new System.EventHandler(this.cboListeType_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSupprPoste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboListeType);
            this.Controls.Add(this.cboListeBudget);
            this.Controls.Add(this.txtDescTran);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.picBordure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSupprPoste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suppression de poste";
            this.Load += new System.EventHandler(this.frmSupprPoste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBordure;
        private System.Windows.Forms.PictureBox picQuitter;
        private System.Windows.Forms.TextBox txtDescTran;
        private System.Windows.Forms.ComboBox cboListeBudget;
        private System.Windows.Forms.ComboBox cboListeType;
        private System.Windows.Forms.Button button1;
    }
}