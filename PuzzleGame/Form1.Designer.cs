namespace PuzzleGame
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.antras1 = new PuzzleGame.Antras();
            this.pirmas2 = new PuzzleGame.Pirmas();
            this.pirmas1 = new PuzzleGame.Pirmas();
            this.trecias1 = new PuzzleGame.Trecias();
            this.ketvirtas1 = new PuzzleGame.Ketvirtas();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(711, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "testi1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // antras1
            // 
            this.antras1.Location = new System.Drawing.Point(13, 14);
            this.antras1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.antras1.Name = "antras1";
            this.antras1.Size = new System.Drawing.Size(814, 518);
            this.antras1.TabIndex = 3;
            // 
            // pirmas2
            // 
            this.pirmas2.Location = new System.Drawing.Point(451, 127);
            this.pirmas2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pirmas2.Name = "pirmas2";
            this.pirmas2.Size = new System.Drawing.Size(6, 7);
            this.pirmas2.TabIndex = 2;
            // 
            // pirmas1
            // 
            this.pirmas1.Location = new System.Drawing.Point(13, 14);
            this.pirmas1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pirmas1.Name = "pirmas1";
            this.pirmas1.Size = new System.Drawing.Size(814, 529);
            this.pirmas1.TabIndex = 0;
            this.pirmas1.Load += new System.EventHandler(this.pirmas1_Load);
            // 
            // trecias1
            // 
            this.trecias1.Location = new System.Drawing.Point(13, 14);
            this.trecias1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trecias1.Name = "trecias1";
            this.trecias1.Size = new System.Drawing.Size(814, 572);
            this.trecias1.TabIndex = 4;
            this.trecias1.Load += new System.EventHandler(this.trecias1_Load);
            // 
            // ketvirtas1
            // 
            this.ketvirtas1.Location = new System.Drawing.Point(13, 14);
            this.ketvirtas1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ketvirtas1.Name = "ketvirtas1";
            this.ketvirtas1.Size = new System.Drawing.Size(814, 518);
            this.ketvirtas1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(570, 540);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Grįžti";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.antras1);
            this.Controls.Add(this.pirmas2);
            this.Controls.Add(this.pirmas1);
            this.Controls.Add(this.ketvirtas1);
            this.Controls.Add(this.trecias1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "RAL puzlė";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Pirmas pirmas1;
        private System.Windows.Forms.Button button1;
        private Pirmas pirmas2;
        private Antras antras1;
        private Trecias trecias1;
        private Ketvirtas ketvirtas1;
        private System.Windows.Forms.Button button2;
    }
}

