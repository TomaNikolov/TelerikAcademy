using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingRocks
{
   public abstract class GameObject
    {
       public Position Position { get; set; }
       public char Sign { get; set; }
      public  bool IsDestroy { get; set; }

      public ConsoleColor color { get; set; }
        


        public GameObject(Position position, char sigh, ConsoleColor color)
        {
            this.Position = position;
            this.Sign = sigh;
            this.IsDestroy = false;
            this.color = color;
           
        }

        public abstract void Update();
    }
}
