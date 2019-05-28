using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PuzzleGame
{
    public partial class Pirmas : UserControl
    {
        public Pirmas()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new object[]
             { "Niujorkas",
               "Tokijas",
               "Vilnius",
               "Kaunas",
               "Seulas",
               "Paryžius" });

            comboBox2.Items.AddRange(new object[]
                {"Pirmas",
                "Antras",
                "Trečias" });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                switch (comboBox1.Text)
                {
                    case "Niujorkas":
                        Globals.TOWN = "NIUJORKAS";
                        break;
                    case "Tokijas":
                        Globals.TOWN = "TOKIJAS";
                        break;
                    case "Kaunas":
                        Globals.TOWN = "KAUNAS";
                        break;
                    case "Seulas":
                        Globals.TOWN = "SEULAS";
                        break;
                    case "Paryžius":
                        Globals.TOWN = "PARYZIUS";
                        break;
                    case "Vilnius":
                        Globals.TOWN = "VILNIUS";
                        break;
                }
                switch(comboBox2.Text)
                {
                    case "Pirmas":
                        Globals.LEVEL = 1;
                        break;
                    case "Antras":
                        Globals.LEVEL = 2;
                        break;
                    case "Trečias":
                        Globals.LEVEL = 3;
                        break;
                }
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
            else label3.Text = "Pasirinkite miestą ir lygį";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
        //public string getPath()
        //{   string[] images = Directory.GetFiles(@"C:\Users\Roberta\Desktop\PuzzleGame\PuzzleGame\PuzzleGame\PuzzleGame\Images\");

        //}

        
    
}
