using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Setting
    {
        public static int gameWidth { get; set; }
        public static int gameHeight { get; set; }
        public static int gameTime { set; get; }
        public static bool gameOver { get; set; }
        public static int cageWidth { get; set; }
        public static int cageHeight { get; set; }

        public Setting()
        {
            gameWidth = 1000;
            gameHeight = 1000;
            gameTime = 0;
            gameOver = false;
            cageWidth = 90;
            cageHeight = 90;
        }
    }
}
