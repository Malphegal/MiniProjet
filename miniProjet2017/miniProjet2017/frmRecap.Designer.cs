namespace miniProjet2017
{
    partial class frmRecap
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
            this.btnPersonne = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnRR = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.chkRecette = new System.Windows.Forms.CheckBox();
            this.chkPercu = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersonne
            // 
            this.btnPersonne.Location = new System.Drawing.Point(12, 12);
            this.btnPersonne.Name = "btnPersonne";
            this.btnPersonne.Size = new System.Drawing.Size(119, 48);
            this.btnPersonne.TabIndex = 0;
            this.btnPersonne.Text = "Lister personne (OFF)";
            this.btnPersonne.UseVisualStyleBackColor = true;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(137, 12);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(119, 48);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.Text = "Lister transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.CliquerSurLiaisonTransaction);
            // 
            // btnLL
            // 
            this.btnLL.Enabled = false;
            this.btnLL.Location = new System.Drawing.Point(12, 408);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(60, 47);
            this.btnLL.TabIndex = 2;
            this.btnLL.Text = "Shift left";
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Click += new System.EventHandler(this.CliquerSurPremier);
            // 
            // btnL
            // 
            this.btnL.Enabled = false;
            this.btnL.Location = new System.Drawing.Point(78, 408);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(60, 47);
            this.btnL.TabIndex = 3;
            this.btnL.Text = "LT";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.CliquerSurPrecedent);
            // 
            // btnR
            // 
            this.btnR.Enabled = false;
            this.btnR.Location = new System.Drawing.Point(144, 408);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(60, 47);
            this.btnR.TabIndex = 4;
            this.btnR.Text = "GT";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.CliquerSurSuivant);
            // 
            // btnRR
            // 
            this.btnRR.Enabled = false;
            this.btnRR.Location = new System.Drawing.Point(210, 408);
            this.btnRR.Name = "btnRR";
            this.btnRR.Size = new System.Drawing.Size(60, 47);
            this.btnRR.TabIndex = 5;
            this.btnRR.Text = "Shift right";
            this.btnRR.UseVisualStyleBackColor = true;
            this.btnRR.Click += new System.EventHandler(this.CliquerSurDernier);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 119);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 180);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 147);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(12, 210);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 9;
            this.lblMontant.Text = "Montant";
            // 
            // chkRecette
            // 
            this.chkRecette.AutoSize = true;
            this.chkRecette.Enabled = false;
            this.chkRecette.Location = new System.Drawing.Point(499, 197);
            this.chkRecette.Name = "chkRecette";
            this.chkRecette.Size = new System.Drawing.Size(64, 17);
            this.chkRecette.TabIndex = 10;
            this.chkRecette.Text = "Recette";
            this.chkRecette.UseVisualStyleBackColor = true;
            // 
            // chkPercu
            // 
            this.chkPercu.AutoSize = true;
            this.chkPercu.Enabled = false;
            this.chkPercu.Location = new System.Drawing.Point(499, 220);
            this.chkPercu.Name = "chkPercu";
            this.chkPercu.Size = new System.Drawing.Size(54, 17);
            this.chkPercu.TabIndex = 11;
            this.chkPercu.Text = "Perçu";
            this.chkPercu.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 251);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(551, 147);
            this.listBox1.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(371, 119);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
            // 
            // frmRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 467);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chkPercu);
            this.Controls.Add(this.chkRecette);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnRR);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnLL);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnPersonne);
            this.Name = "frmRecap";
            this.Text = "frmRecap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonne;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnLL;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnRR;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.CheckBox chkRecette;
        private System.Windows.Forms.CheckBox chkPercu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblDate;
    }
}