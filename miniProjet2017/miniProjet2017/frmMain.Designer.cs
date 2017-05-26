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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterPersonne = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAffichage
            // 
            this.btnAffichage.Location = new System.Drawing.Point(791, 211);
            this.btnAffichage.Name = "btnAffichage";
            this.btnAffichage.Size = new System.Drawing.Size(140, 41);
            this.btnAffichage.TabIndex = 1;
            this.btnAffichage.Text = "frmAffichage";
            this.btnAffichage.UseVisualStyleBackColor = true;
            this.btnAffichage.Click += new System.EventHandler(this.NouveauFrmAffichage);
            // 
            // btnAjoutTransac
            // 
            this.btnAjoutTransac.Location = new System.Drawing.Point(298, 134);
            this.btnAjoutTransac.Name = "btnAjoutTransac";
            this.btnAjoutTransac.Size = new System.Drawing.Size(140, 41);
            this.btnAjoutTransac.TabIndex = 0;
            this.btnAjoutTransac.Text = "Ajouter une transaction";
            this.btnAjoutTransac.UseVisualStyleBackColor = true;
            this.btnAjoutTransac.Click += new System.EventHandler(this.NouveauFrmAjoutTransac);
            // 
            // btnModiTransac
            // 
            this.btnModiTransac.Location = new System.Drawing.Point(298, 192);
            this.btnModiTransac.Name = "btnModiTransac";
            this.btnModiTransac.Size = new System.Drawing.Size(140, 41);
            this.btnModiTransac.TabIndex = 2;
            this.btnModiTransac.Text = "Modifier une transaction";
            this.btnModiTransac.UseVisualStyleBackColor = true;
            this.btnModiTransac.Click += new System.EventHandler(this.NouveauFrmModiTransac);
            // 
            // btnRecap
            // 
            this.btnRecap.Location = new System.Drawing.Point(791, 258);
            this.btnRecap.Name = "btnRecap";
            this.btnRecap.Size = new System.Drawing.Size(140, 41);
            this.btnRecap.TabIndex = 3;
            this.btnRecap.Text = "frmRecap";
            this.btnRecap.UseVisualStyleBackColor = true;
            this.btnRecap.Click += new System.EventHandler(this.NouveauFrmRecap);
            // 
            // btnSupprTransac
            // 
            this.btnSupprTransac.Location = new System.Drawing.Point(298, 253);
            this.btnSupprTransac.Name = "btnSupprTransac";
            this.btnSupprTransac.Size = new System.Drawing.Size(140, 41);
            this.btnSupprTransac.TabIndex = 4;
            this.btnSupprTransac.Text = "Supprimer une transaction";
            this.btnSupprTransac.UseVisualStyleBackColor = true;
            this.btnSupprTransac.Click += new System.EventHandler(this.NouveauFrmSupprTransac);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.quitterToolStripMenuItem.Text = "Quitter...";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editerToolStripMenuItem.Text = "Editer";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.NouveauFrmOption);
            // 
            // btnAjouterPersonne
            // 
            this.btnAjouterPersonne.Location = new System.Drawing.Point(791, 112);
            this.btnAjouterPersonne.Name = "btnAjouterPersonne";
            this.btnAjouterPersonne.Size = new System.Drawing.Size(140, 41);
            this.btnAjouterPersonne.TabIndex = 6;
            this.btnAjouterPersonne.Text = "Ajouter une personne";
            this.btnAjouterPersonne.UseVisualStyleBackColor = true;
            this.btnAjouterPersonne.Click += new System.EventHandler(this.NouveauFrmAjouterPersonne);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(435, 49);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(35, 13);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 560);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::miniProjet2017.Properties.Resources.logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 81);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 82);
            this.panel3.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 584);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSupprTransac);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModiTransac);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAjoutTransac);
            this.Controls.Add(this.btnAjouterPersonne);
            this.Controls.Add(this.btnRecap);
            this.Controls.Add(this.btnAffichage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAffichage;
        private System.Windows.Forms.Button btnAjoutTransac;
        private System.Windows.Forms.Button btnModiTransac;
        private System.Windows.Forms.Button btnRecap;
        private System.Windows.Forms.Button btnSupprTransac;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button btnAjouterPersonne;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

