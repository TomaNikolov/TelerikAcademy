using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingRocks
{
    class Bullet:MovingObject
    {
         public Bullet(Position position, Position speed)
            : base(position, speed, '|', ConsoleColor.Red)
        {
            
        }
    }
}
