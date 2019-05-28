namespace PuzzleGame
{
    partial class Trecias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trecias));
            this.pavadinimasLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pavadinimasLabel
            // 
            this.pavadinimasLabel.AutoSize = true;
            this.pavadinimasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.pavadinimasLabel.Location = new System.Drawing.Point(154, 68);
            this.pavadinimasLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pavadinimasLabel.Name = "pavadinimasLabel";
            this.pavadinimasLabel.Size = new System.Drawing.Size(252, 63);
            this.pavadinimasLabel.TabIndex = 1;
            this.pavadinimasLabel.Text = "Miestas: ";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.infoLabel.Location = new System.Drawing.Point(103, 150);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(289, 46);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "INFORMACIJA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1700, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 501);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Trecias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.pavadinimasLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Trecias";
            this.Size = new System.Drawing.Size(2144, 1317);
            this.Load += new System.EventHandler(this.Trecias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pavadinimasLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
