using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingRocks
{
  public  class Dwarf:GameObject
    {
        
        public Dwarf(Position position)
          : base(position, '0', ConsoleColor.Green)
        {
            
        }
        public override void Update()
        {
           
        }
        public  void MoveLeft()
        {
            this.Position.Row -= 1;
        }

        public void MoveRight()
        {
            this.Position.Row += 1;
        }
    }
}
