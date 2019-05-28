using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleGame
{
    public static class Globals
    {
        public const Int32 BUFFER_SIZE = 512; // Unmodifiable
        public static String TOWN = ""; // Modifiable
        public static int LEVEL = 1; // modifiable

        public static int getLvl()
        {
            switch (LEVEL)
            {
                case 1:
                    return 9;
                case 2:
                    return 16;
                case 3:
                    return 25;
                case 4:
                    return 36;
                default:
                    return 9;
            }
        }
        public static int getTOWN()
        {
            switch (TOWN)
            {
                case "NIUJORKAS":
                    return 1;
                case "TOKIJAS":
                    return 2;
                case "VILNIUS":
                    return 3;
                case "KAUNAS":
                    return 4;
                case "SEULAS":
                    return 5;
                case "PARYZIUS":
                    return 6;
                default:
                    return 0;
            }
        }
    }
}
