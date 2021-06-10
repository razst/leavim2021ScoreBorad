
namespace score
{
    partial class Scoreboard
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
            this.pictureBoxOrt = new System.Windows.Forms.PictureBox();
            this.pictureBoxYeruham = new System.Windows.Forms.PictureBox();
            this.pictureBoxHusidman = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYeruham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHusidman)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOrt
            // 
            this.pictureBoxOrt.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOrt.Location = new System.Drawing.Point(327, 621);
            this.pictureBoxOrt.Name = "pictureBoxOrt";
            this.pictureBoxOrt.Size = new System.Drawing.Size(274, 258);
            this.pictureBoxOrt.TabIndex = 0;
            this.pictureBoxOrt.TabStop = false;
            // 
            // pictureBoxYeruham
            // 
            this.pictureBoxYeruham.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxYeruham.Location = new System.Drawing.Point(832, 621);
            this.pictureBoxYeruham.Name = "pictureBoxYeruham";
            this.pictureBoxYeruham.Size = new System.Drawing.Size(274, 258);
            this.pictureBoxYeruham.TabIndex = 1;
            this.pictureBoxYeruham.TabStop = false;
            // 
            // pictureBoxHusidman
            // 
            this.pictureBoxHusidman.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHusidman.Location = new System.Drawing.Point(1358, 621);
            this.pictureBoxHusidman.Name = "pictureBoxHusidman";
            this.pictureBoxHusidman.Size = new System.Drawing.Size(274, 258);
            this.pictureBoxHusidman.TabIndex = 2;
            this.pictureBoxHusidman.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 13);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(127, 51);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::score.Properties.Resources.ניקוד_ביניים;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.pictureBoxHusidman);
            this.Controls.Add(this.pictureBoxYeruham);
            this.Controls.Add(this.pictureBoxOrt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYeruham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHusidman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOrt;
        private System.Windows.Forms.PictureBox pictureBoxYeruham;
        private System.Windows.Forms.PictureBox pictureBoxHusidman;
        private System.Windows.Forms.Button BackButton;
    }
}