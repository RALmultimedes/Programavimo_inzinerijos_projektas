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
    public partial class Antras : UserControl
    {
        Image image;
        PictureBox picBoxWhole = null;
        PictureBox[] picBoxes = null;
        Image[] images = null;
        MyPictureBox firstBox = null;
        MyPictureBox secondBox = null;
        int currentLevel = Globals.getLvl();
        Timer timer = new Timer();
        int moves = 0;

        public bool a = false;
        public Antras()
        {
            InitializeComponent();
           
        }

        private void ImageBrowse()
        {
            string imgPath = String.Format("{0}\\Images\\{1}.jpg", System.IO.Directory.GetCurrentDirectory(), Globals.TOWN);
            imgPath = imgPath.Replace('/', '\\');
            

            image = CreateBitmapImage(Image.FromFile(imgPath));
            if (picBoxWhole == null)
            {
                picBoxWhole = new PictureBox();
                picBoxWhole.Height = groupBoxPuzzle.Height;
                picBoxWhole.Width = groupBoxPuzzle.Width;
                groupBoxPuzzle.Controls.Add(picBoxWhole);
            }
            picBoxWhole.Image = image;
        }

        private Bitmap CreateBitmapImage(Image image)
        {
            Bitmap obj = new Bitmap(groupBoxPuzzle.Width, groupBoxPuzzle.Height);
            Graphics objGraphics = Graphics.FromImage(obj);
            objGraphics.Clear(Color.White);
            objGraphics.DrawImage(image, new Rectangle(0, 0, groupBoxPuzzle.Width, groupBoxPuzzle.Height));
            objGraphics.Flush();
            return obj;
        }
        private void CreateBitmapImage(Image image, Image[] images, int index, int numRow, int numColum, int unitX, int unitY)
        {

            images[index] = new Bitmap(unitX, unitY);

            Graphics objGraphics = Graphics.FromImage(images[index]);
            objGraphics.Clear(Color.White);
            objGraphics.DrawImage(image, new Rectangle(0, 0, unitX, unitY),
                                  new Rectangle(unitX * (index % numColum), unitY * (index / numColum), unitX, unitY), GraphicsUnit.Pixel);
            objGraphics.Flush();

        }
        private void shuffle(ref int[] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n);
                n--;
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
        public void OnPuzzleClick(object sender, EventArgs e)
        {
            if (firstBox == null)
            {
                firstBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (secondBox == null)
            {
                secondBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.Fixed3D;
                secondBox.BorderStyle = BorderStyle.FixedSingle;
                SwitchImages(firstBox, secondBox);
                firstBox = null;
                secondBox = null;
            }
            //else
            //{
            //    firstBox = secondBox;
            //    firstBox.BorderStyle = BorderStyle.Fixed3D;
            //    secondBox = (MyPictureBox)sender;
            //    secondBox.BorderStyle = BorderStyle.FixedSingle;
            //    
            //}



        }
        private void SwitchImages(MyPictureBox box1, MyPictureBox box2)
        {
            moves++;
           // timer.Start();
            //string laikas = timer.ToString();
            //timeLabel.Text = laikas;
            movesLabel.Text = "Padaryta ėjimų : " + moves.ToString();
            int tmp = box2.Imageindex;
            box2.Image = images[box1.Imageindex];
            box2.Imageindex = box1.Imageindex;
            box1.Image = images[tmp];
            box1.Imageindex = tmp;
            if (isSuccessful())
            {
                timer1.Enabled = false;
                processLabel.Text = "Dėlionė sudėliota teisingai!";
            }
        }


        private bool isSuccessful()
        {
            for (int i = 0; i < currentLevel; i++)
            {
                if (((MyPictureBox)picBoxes[i]).Imageindex != ((MyPictureBox)picBoxes[i]).Index)
                    return false;
            }
            return true;
        }

        private void PlayLevel()
        {
          
            int currentLevel = Globals.getLvl();
            //int currentLevel = Globals.LEVEL;

            groupBoxPuzzle.Controls.Clear();
            if (picBoxWhole != null)
            {
                groupBoxPuzzle.Controls.Remove(picBoxWhole);
                picBoxWhole.Dispose();
                picBoxWhole = null;
            }
            if (picBoxes == null)
            {
                images = new Image[currentLevel];
                picBoxes = new PictureBox[currentLevel];
            }
            int numRow = (int)Math.Sqrt(currentLevel);
            int numColom = numRow;
            int unitX = groupBoxPuzzle.Width / numRow;
            int unitY = groupBoxPuzzle.Height / numColom;
            int[] indice = new int[currentLevel];

            for (int i = 0; i < currentLevel; i++)
            {
                indice[i] = i;
                if (picBoxes[i] == null)
                {
                    picBoxes[i] = new MyPictureBox();
                    picBoxes[i].Click += new EventHandler(OnPuzzleClick);
                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                picBoxes[i].Width = unitX;
                picBoxes[i].Height = unitY;

                ((MyPictureBox)picBoxes[i]).Index = i;
                CreateBitmapImage(image, images, i, numRow, numColom, unitX, unitY);
                picBoxes[i].Location = new Point(unitX * (i % numColom), unitY * (i / numColom));
                if (!groupBoxPuzzle.Controls.Contains(picBoxes[i]));
                groupBoxPuzzle.Controls.Add(picBoxes[i]);
            }
            shuffle(ref indice);
            for (int i = 0; i < currentLevel; i++)
            {
                picBoxes[i].Image = images[indice[i]];
                ((MyPictureBox)picBoxes[i]).Imageindex = indice[i];
            }

        }
        int quick = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            PlayLevel();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            processLabel.Text = "Žaidimas vyksta...";
        }

        private void Antras_Load(object sender, EventArgs e)
        {
            ImageBrowse();
            //timeLabel.Text = "00:00:00";
           
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            quick++;
            timeLabel.Text =  quick / 3600 + ":" + ((quick %3600/60) >= 10 ? (quick%3600/60 ).ToString() : "0" + (quick % 3600/60)); 
        }

    }
}
