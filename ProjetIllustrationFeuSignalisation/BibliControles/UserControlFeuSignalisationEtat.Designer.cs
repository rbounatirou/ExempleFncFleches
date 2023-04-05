namespace BibliControles
{
    partial class UserControlFeuSignalisationEtat
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFeu = new System.Windows.Forms.Label();
            this.panelCouleur = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelFeu
            // 
            this.labelFeu.AutoSize = true;
            this.labelFeu.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFeu.Location = new System.Drawing.Point(10, 10);
            this.labelFeu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.labelFeu.Name = "labelFeu";
            this.labelFeu.Size = new System.Drawing.Size(38, 15);
            this.labelFeu.TabIndex = 0;
            this.labelFeu.Text = "labelFeu";
            // 
            // panelCouleur
            // 
            this.panelCouleur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCouleur.Location = new System.Drawing.Point(48, 10);
            this.panelCouleur.Name = "panelCouleur";
            this.panelCouleur.Size = new System.Drawing.Size(360, 20);
            this.panelCouleur.TabIndex = 1;
            // 
            // UserControlFeuSignalisationEtat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCouleur);
            this.Controls.Add(this.labelFeu);
            this.Name = "UserControlFeuSignalisationEtat";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(418, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFeu;
        private Panel panelCouleur;
    }
}