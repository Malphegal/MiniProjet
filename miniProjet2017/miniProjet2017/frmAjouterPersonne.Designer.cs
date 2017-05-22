namespace miniProjet2017
{
    partial class frmAjouterPersonne
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
            this.components = new System.ComponentModel.Container();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(57, 10);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(122, 13);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prenom de la personne :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(71, 54);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(108, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom de la personne :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numéro de téléphone (optionnel) :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(186, 7);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(166, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // textBox2
            // 
            this.txtNom.Location = new System.Drawing.Point(185, 51);
            this.txtNom.Name = "textBox2";
            this.txtNom.Size = new System.Drawing.Size(167, 20);
            this.txtNom.TabIndex = 4;
            // 
            // textBox3
            // 
            this.txtNumero.Location = new System.Drawing.Point(185, 94);
            this.txtNumero.Name = "textBox3";
            this.txtNumero.Size = new System.Drawing.Size(167, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(22, 136);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(157, 48);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.CliquerSurValider);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(195, 136);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(157, 48);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.QuitterAjouterPersonne);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAjouterPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 196);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Name = "frmAjouterPersonne";
            this.Text = "frmAjouterPersonne";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}