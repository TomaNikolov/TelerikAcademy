using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingRocks
{
    class Rock:MovingObject
    {
      public static Random randomNumber = new Random();

        public Rock(Position position, Position speed)
            :base(position, speed, RandomSign(), RandomColor())
        {
            
        }

        private static ConsoleColor RandomColor()
        {
            ConsoleColor[] color = new ConsoleColor[] 
            {ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue,
                ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Magenta, ConsoleColor.White,
                ConsoleColor.Yellow
            };
            ConsoleColor resultColor = color[randomNumber.Next(12)];
            return resultColor;
        }

private static char RandomSign()
{
 	char [] ch = new char []{'!', '@', '#',  '$', '%', '^', '&', '*', '+', '-', '=' };
    char sign = ch[randomNumber.Next(11)];
    return sign;

}

       

    }
}
