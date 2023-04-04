namespace ProjetIllustrationFeuSignalisation
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterFeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rougeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.passerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterFeuToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterFeuToolStripMenuItem
            // 
            this.ajouterFeuToolStripMenuItem.Name = "ajouterFeuToolStripMenuItem";
            this.ajouterFeuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterFeuToolStripMenuItem.Text = "Ajouter feu";
            this.ajouterFeuToolStripMenuItem.Click += new System.EventHandler(this.ajouterFeuToolStripMenuItem_Click);
            // 
            // passerToolStripMenuItem
            // 
            this.passerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rougeToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.vertToolStripMenuItem});
            this.passerToolStripMenuItem.Name = "passerToolStripMenuItem";
            this.passerToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.passerToolStripMenuItem.Text = "Passer";
            // 
            // rougeToolStripMenuItem
            // 
            this.rougeToolStripMenuItem.Name = "rougeToolStripMenuItem";
            this.rougeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rougeToolStripMenuItem.Text = "Rouge";
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orangeToolStripMenuItem.Text = "Orange";
            // 
            // vertToolStripMenuItem
            // 
            this.vertToolStripMenuItem.Name = "vertToolStripMenuItem";
            this.vertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vertToolStripMenuItem.Text = "Vert";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem ajouterFeuToolStripMenuItem;
        private ToolStripMenuItem passerToolStripMenuItem;
        private ToolStripMenuItem rougeToolStripMenuItem;
        private ToolStripMenuItem orangeToolStripMenuItem;
        private ToolStripMenuItem vertToolStripMenuItem;
    }
}