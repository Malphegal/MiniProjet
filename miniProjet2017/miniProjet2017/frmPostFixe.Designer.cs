namespace miniProjet2017
{
    partial class frmPostFixe
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
            this.lblPoste = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAutre = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPeriodicité = new System.Windows.Forms.Label();
            this.lblJour = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblMois = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.Location = new System.Drawing.Point(13, 16);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(40, 13);
            this.lblPoste.TabIndex = 0;
            this.lblPoste.Text = "Poste :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnAutre
            // 
            this.btnAutre.Location = new System.Drawing.Point(245, 11);
            this.btnAutre.Name = "btnAutre";
            this.btnAutre.Size = new System.Drawing.Size(75, 23);
            this.btnAutre.TabIndex = 2;
            this.btnAutre.Text = "Autre";
            this.btnAutre.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblPeriodicité
            // 
            this.lblPeriodicité.AutoSize = true;
            this.lblPeriodicité.Location = new System.Drawing.Point(13, 58);
            this.lblPeriodicité.Name = "lblPeriodicité";
            this.lblPeriodicité.Size = new System.Drawing.Size(59, 13);
            this.lblPeriodicité.TabIndex = 4;
            this.lblPeriodicité.Text = "Périodicité.";
            // 
            // lblJour
            // 
            this.lblJour.AutoSize = true;
            this.lblJour.Location = new System.Drawing.Point(12, 96);
            this.lblJour.Name = "lblJour";
            this.lblJour.Size = new System.Drawing.Size(111, 13);
            this.lblJour.TabIndex = 5;
            this.lblJour.Text = "Jour du mois ?      Le :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(379, 413);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(13, 170);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(52, 13);
            this.lblMontant.TabIndex = 9;
            this.lblMontant.Text = "Montant :";
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Location = new System.Drawing.Point(159, 96);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(70, 13);
            this.lblMois.TabIndex = 10;
            this.lblMois.Text = "chaque mois.";
            // 
            // frmPostFixe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 448);
            this.Controls.Add(this.lblMois);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblJour);
            this.Controls.Add(this.lblPeriodicité);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAutre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPoste);
            this.Name = "frmPostFixe";
            this.Text = "Poste fixe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoste;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAutre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPeriodicité;
        private System.Windows.Forms.Label lblJour;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblMois;
    }
}