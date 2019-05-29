using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        private int step = 0;
        public Form1()
        {
            InitializeComponent();

            pirmas1.Show();
            antras1.Hide();
            trecias1.Hide();
            ketvirtas1.Hide();
            step = 1;
            button1.Text = "Pradėti";
            button2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            perejimas();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pirmas1_Load(object sender, EventArgs e)
        {

        }

        private void trecias1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            step=step-2;
            perejimas();
        }

        private void perejimas()
        {
            switch (step)
            {
                case 0:
                    pirmas1.Show();
                    antras1.Enabled = false;
                    trecias1.Enabled = false;
                    ketvirtas1.Enabled = false;
                    step++;
                    button1.Text = "Pradėti";
                    break;
                case 1:

                    if (Globals.TOWN != "" && Globals.LEVEL != 0)
                    {
                        antras1.Enabled = true;
                        pirmas1.Hide();
                        trecias1.Enabled = false;
                        ketvirtas1.Enabled = false;
                        antras1.Show();
                        step++;
                        if (Globals.TOWN != "" && Globals.LEVEL != 0) { }
                        button1.Text = "Tęsti";
                    }
                    else button1.Text = "Pasirinkite miestą ir lygį!";
                    break;
                case 2:
                    trecias1.Enabled = true;
                    ketvirtas1.Enabled = false;
                    pirmas1.Hide();
                    antras1.Hide();
                    trecias1.Show();
                    ketvirtas1.Hide();
                    button2.Show();
                    step++;
                    button1.Text = "Tęsti";
                    break;
                case 3:
                    ketvirtas1.Enabled = true;
                    pirmas1.Hide();
                    antras1.Hide();
                    trecias1.Hide();
                    ketvirtas1.Show();
                    step++;
                    button2.Show();
                    button1.Text = "Baigti";
                    break;
                case 4:
                    Close();
                    break;
            }
        }
    }
}
