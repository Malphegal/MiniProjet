namespace miniProjet2017
{
    partial class frmAjoutTransac
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
            this.lblTransac = new System.Windows.Forms.Label();
            this.lblDescTransac = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.calTransac = new System.Windows.Forms.MonthCalendar();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtDescTran = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.chkRecette = new System.Windows.Forms.CheckBox();
            this.chkPerçu = new System.Windows.Forms.CheckBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btnAjouterPersonne = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTransac
            // 
            this.lblTransac.AutoSize = true;
            this.lblTransac.Location = new System.Drawing.Point(12, 9);
            this.lblTransac.Name = "lblTransac";
            this.lblTransac.Size = new System.Drawing.Size(111, 13);
            this.lblTransac.TabIndex = 0;
            this.lblTransac.Text = "Date de la transaction";
            // 
            // lblDescTransac
            // 
            this.lblDescTransac.AutoSize = true;
            this.lblDescTransac.Location = new System.Drawing.Point(12, 187);
            this.lblDescTransac.Name = "lblDescTransac";
            this.lblDescTransac.Size = new System.Drawing.Size(141, 13);
            this.lblDescTransac.TabIndex = 1;
            this.lblDescTransac.Text = "Description de la transaction";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(12, 236);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 2;
            this.lblMontant.Text = "Montant";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 328);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // calTransac
            // 
            this.calTransac.Location = new System.Drawing.Point(130, 13);
            this.calTransac.Name = "calTransac";
            this.calTransac.TabIndex = 4;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(159, 328);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 5;
            // 
            // txtDescTran
            // 
            this.txtDescTran.Location = new System.Drawing.Point(159, 184);
            this.txtDescTran.Name = "txtDescTran";
            this.txtDescTran.Size = new System.Drawing.Size(100, 20);
            this.txtDescTran.TabIndex = 6;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(159, 229);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 20);
            this.txtMontant.TabIndex = 7;
            // 
            // chkRecette
            // 
            this.chkRecette.AutoSize = true;
            this.chkRecette.Location = new System.Drawing.Point(6, 12);
            this.chkRecette.Name = "chkRecette";
            this.chkRecette.Size = new System.Drawing.Size(64, 17);
            this.chkRecette.TabIndex = 8;
            this.chkRecette.Text = "Recette";
            this.chkRecette.UseVisualStyleBackColor = true;
            // 
            // chkPerçu
            // 
            this.chkPerçu.AutoSize = true;
            this.chkPerçu.Location = new System.Drawing.Point(150, 12);
            this.chkPerçu.Name = "chkPerçu";
            this.chkPerçu.Size = new System.Drawing.Size(54, 17);
            this.chkPerçu.TabIndex = 9;
            this.chkPerçu.Text = "Perçu";
            this.chkPerçu.UseVisualStyleBackColor = true;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.chkPerçu);
            this.grb1.Controls.Add(this.chkRecette);
            this.grb1.Location = new System.Drawing.Point(9, 272);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(281, 43);
            this.grb1.TabIndex = 10;
            this.grb1.TabStop = false;
            // 
            // btnAjouterPersonne
            // 
            this.btnAjouterPersonne.Location = new System.Drawing.Point(635, 13);
            this.btnAjouterPersonne.Name = "btnAjouterPersonne";
            this.btnAjouterPersonne.Size = new System.Drawing.Size(76, 69);
            this.btnAjouterPersonne.TabIndex = 11;
            this.btnAjouterPersonne.Text = "Ajouter une personne";
            this.btnAjouterPersonne.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAjouter.Location = new System.Drawing.Point(130, 403);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(103, 66);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // frmAjoutTransac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 508);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAjouterPersonne);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtDescTran);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.calTransac);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblDescTransac);
            this.Controls.Add(this.lblTransac);
            this.Name = "frmAjoutTransac";
            this.Text = "frmAjoutTransac";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransac;
        private System.Windows.Forms.Label lblDescTransac;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.MonthCalendar calTransac;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtDescTran;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.CheckBox chkRecette;
        private System.Windows.Forms.CheckBox chkPerçu;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btnAjouterPersonne;
        private System.Windows.Forms.Button btnAjouter;
    }
}