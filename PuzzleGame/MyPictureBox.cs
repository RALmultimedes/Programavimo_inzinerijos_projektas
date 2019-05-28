using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    class MyPictureBox : PictureBox
    {
        int index = 0;


        public int Index
        {
            get => index; set => index = value;
        }


        int imageindex = 0;
        public int Imageindex { get => imageindex; set => imageindex = value; }
        public bool isMatch()
        {
            return (index == Imageindex);
        }
    }
}
