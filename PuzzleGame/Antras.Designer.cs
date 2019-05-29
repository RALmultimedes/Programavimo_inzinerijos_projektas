namespace PuzzleGame
{
    partial class Antras
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Antras));
            this.groupBoxPuzzle = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.movesLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.processLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPuzzle
            // 
            this.groupBoxPuzzle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxPuzzle.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxPuzzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPuzzle.Location = new System.Drawing.Point(20, 61);
            this.groupBoxPuzzle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPuzzle.Name = "groupBoxPuzzle";
            this.groupBoxPuzzle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPuzzle.Size = new System.Drawing.Size(419, 419);
            this.groupBoxPuzzle.TabIndex = 1;
            this.groupBoxPuzzle.TabStop = false;
            this.groupBoxPuzzle.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(602, 366);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pradėti";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // movesLabel
            // 
            this.movesLabel.AutoSize = true;
            this.movesLabel.Font = new System.Drawing.Font("Century Gothic", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.movesLabel.Location = new System.Drawing.Point(483, 124);
            this.movesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movesLabel.Name = "movesLabel";
            this.movesLabel.Size = new System.Drawing.Size(206, 26);
            this.movesLabel.TabIndex = 5;
            this.movesLabel.Text = "Padaryta ėjimų : 0";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.timeLabel.Location = new System.Drawing.Point(543, 88);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(119, 33);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.processLabel.Location = new System.Drawing.Point(420, 197);
            this.processLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(55, 29);
            this.processLabel.TabIndex = 6;
            this.processLabel.Text = "       ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(509, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Praėjo laiko:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(452, 307);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Antras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.movesLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxPuzzle);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Antras";
            this.Size = new System.Drawing.Size(814, 518);
            this.Load += new System.EventHandler(this.Antras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxPuzzle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label movesLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
