namespace miniProjet2017
{
    partial class frmGeant
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
            this.BO = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BO)).BeginInit();
            this.SuspendLayout();
            // 
            // BO
            // 
            this.BO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BO.Location = new System.Drawing.Point(29, 90);
            this.BO.Name = "BO";
            this.BO.Size = new System.Drawing.Size(628, 308);
            this.BO.TabIndex = 0;
            // 
            // frmGeant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 495);
            this.Controls.Add(this.BO);
            this.Name = "frmGeant";
            this.Text = "frmGeant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BO;
    }
}