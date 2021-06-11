namespace score
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Yeruham = new System.Windows.Forms.Button();
            this.OrtBraudeKarmiel = new System.Windows.Forms.Button();
            this.Husidman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Yeruham
            // 
            this.Yeruham.Location = new System.Drawing.Point(933, 530);
            this.Yeruham.Name = "Yeruham";
            this.Yeruham.Size = new System.Drawing.Size(127, 62);
            this.Yeruham.TabIndex = 0;
            this.Yeruham.Text = "מרכז מדעים ירוחם";
            this.Yeruham.UseVisualStyleBackColor = true;
            this.Yeruham.Click += new System.EventHandler(this.Yeruham_Click);
            // 
            // OrtBraudeKarmiel
            // 
            this.OrtBraudeKarmiel.Location = new System.Drawing.Point(504, 530);
            this.OrtBraudeKarmiel.Name = "OrtBraudeKarmiel";
            this.OrtBraudeKarmiel.Size = new System.Drawing.Size(127, 62);
            this.OrtBraudeKarmiel.TabIndex = 1;
            this.OrtBraudeKarmiel.Text = "אורט בראודה כרמיאל";
            this.OrtBraudeKarmiel.UseVisualStyleBackColor = true;
            this.OrtBraudeKarmiel.Click += new System.EventHandler(this.OrtBraudeKarmiel_Click);
            // 
            // Husidman
            // 
            this.Husidman.Location = new System.Drawing.Point(1362, 530);
            this.Husidman.Name = "Husidman";
            this.Husidman.Size = new System.Drawing.Size(127, 62);
            this.Husidman.TabIndex = 2;
            this.Husidman.Text = "חוסידמן";
            this.Husidman.UseVisualStyleBackColor = true;
            this.Husidman.Click += new System.EventHandler(this.Husidman_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Husidman);
            this.Controls.Add(this.OrtBraudeKarmiel);
            this.Controls.Add(this.Yeruham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Yeruham;
        private System.Windows.Forms.Button OrtBraudeKarmiel;
        private System.Windows.Forms.Button Husidman;
    }
}

