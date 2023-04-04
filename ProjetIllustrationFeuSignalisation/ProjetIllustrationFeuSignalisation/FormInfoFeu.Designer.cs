namespace ProjetIllustrationFeuSignalisation
{
    partial class FormInfoFeu
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
            this.btValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRouge = new System.Windows.Forms.TextBox();
            this.textBoxOrange = new System.Windows.Forms.TextBox();
            this.textBoxVert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEtat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(12, 221);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(262, 90);
            this.btValider.TabIndex = 0;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "temps rouge ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "temps orange ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "temps vert ms";
            // 
            // textBoxRouge
            // 
            this.textBoxRouge.Location = new System.Drawing.Point(144, 21);
            this.textBoxRouge.Name = "textBoxRouge";
            this.textBoxRouge.Size = new System.Drawing.Size(130, 23);
            this.textBoxRouge.TabIndex = 4;
            this.textBoxRouge.Text = "20000";
            // 
            // textBoxOrange
            // 
            this.textBoxOrange.Location = new System.Drawing.Point(144, 77);
            this.textBoxOrange.Name = "textBoxOrange";
            this.textBoxOrange.Size = new System.Drawing.Size(130, 23);
            this.textBoxOrange.TabIndex = 5;
            this.textBoxOrange.Text = "5000";
            // 
            // textBoxVert
            // 
            this.textBoxVert.Location = new System.Drawing.Point(144, 128);
            this.textBoxVert.Name = "textBoxVert";
            this.textBoxVert.Size = new System.Drawing.Size(130, 23);
            this.textBoxVert.TabIndex = 6;
            this.textBoxVert.Text = "20000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "etat initial";
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Location = new System.Drawing.Point(144, 177);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(130, 23);
            this.comboBoxEtat.TabIndex = 8;
            // 
            // FormInfoFeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 320);
            this.Controls.Add(this.comboBoxEtat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVert);
            this.Controls.Add(this.textBoxOrange);
            this.Controls.Add(this.textBoxRouge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btValider);
            this.Name = "FormInfoFeu";
            this.Text = "FormInfoFeu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btValider;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxRouge;
        private TextBox textBoxOrange;
        private TextBox textBoxVert;
        private Label label4;
        private ComboBox comboBoxEtat;
    }
}