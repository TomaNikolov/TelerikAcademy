using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingRocks
{
    class MovingObject:GameObject
    {
        public Position Speed { get; set; }

        public MovingObject(Position position, Position speed, char sign, ConsoleColor color)
         :base(position, sign, color)
        {
            this.Speed = speed;
        }

        protected virtual void UpdatePosition()
        {  
             
            this.Position += this.Speed;
        }

        public override void Update()
        {
            this.UpdatePosition();
        }
    }
}
