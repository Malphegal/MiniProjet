namespace miniProjet2017
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAffichage = new System.Windows.Forms.Button();
            this.btnAjoutTransac = new System.Windows.Forms.Button();
            this.btnModiTransac = new System.Windows.Forms.Button();
            this.btnRecap = new System.Windows.Forms.Button();
            this.btnSupprTransac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAffichage
            // 
            this.btnAffichage.Location = new System.Drawing.Point(12, 64);
            this.btnAffichage.Name = "btnAffichage";
            this.btnAffichage.Size = new System.Drawing.Size(130, 41);
            this.btnAffichage.TabIndex = 0;
            this.btnAffichage.Text = "frmAffichage";
            this.btnAffichage.UseVisualStyleBackColor = true;
            this.btnAffichage.Click += new System.EventHandler(this.nouveauFrmAffichage);
            // 
            // btnAjoutTransac
            // 
            this.btnAjoutTransac.Location = new System.Drawing.Point(12, 17);
            this.btnAjoutTransac.Name = "btnAjoutTransac";
            this.btnAjoutTransac.Size = new System.Drawing.Size(130, 41);
            this.btnAjoutTransac.TabIndex = 1;
            this.btnAjoutTransac.Text = "frmAjoutTransac";
            this.btnAjoutTransac.UseVisualStyleBackColor = true;
            this.btnAjoutTransac.Click += new System.EventHandler(this.nouveauFrmAjoutTransac);
            // 
            // btnModiTransac
            // 
            this.btnModiTransac.Location = new System.Drawing.Point(12, 111);
            this.btnModiTransac.Name = "btnModiTransac";
            this.btnModiTransac.Size = new System.Drawing.Size(130, 41);
            this.btnModiTransac.TabIndex = 2;
            this.btnModiTransac.Text = "frmModiTransac";
            this.btnModiTransac.UseVisualStyleBackColor = true;
            this.btnModiTransac.Click += new System.EventHandler(this.nouveauFrmModiTransac);
            // 
            // btnRecap
            // 
            this.btnRecap.Location = new System.Drawing.Point(12, 160);
            this.btnRecap.Name = "btnRecap";
            this.btnRecap.Size = new System.Drawing.Size(130, 41);
            this.btnRecap.TabIndex = 3;
            this.btnRecap.Text = "frmRecap";
            this.btnRecap.UseVisualStyleBackColor = true;
            this.btnRecap.Click += new System.EventHandler(this.nouveauFrmRecap);
            // 
            // btnSupprTransac
            // 
            this.btnSupprTransac.Location = new System.Drawing.Point(12, 207);
            this.btnSupprTransac.Name = "btnSupprTransac";
            this.btnSupprTransac.Size = new System.Drawing.Size(130, 41);
            this.btnSupprTransac.TabIndex = 4;
            this.btnSupprTransac.Text = "frmSupprTransac";
            this.btnSupprTransac.UseVisualStyleBackColor = true;
            this.btnSupprTransac.Click += new System.EventHandler(this.nouveauFrmSupprTransac);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 584);
            this.Controls.Add(this.btnSupprTransac);
            this.Controls.Add(this.btnRecap);
            this.Controls.Add(this.btnModiTransac);
            this.Controls.Add(this.btnAjoutTransac);
            this.Controls.Add(this.btnAffichage);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAffichage;
        private System.Windows.Forms.Button btnAjoutTransac;
        private System.Windows.Forms.Button btnModiTransac;
        private System.Windows.Forms.Button btnRecap;
        private System.Windows.Forms.Button btnSupprTransac;
    }
}

