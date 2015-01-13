using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingRocks
{
    class CollisionDetection
    {
        //List<Rock> rocks;
        //List<Bullet> bullets;
        //Dwarf dwarf;

        public static int BulletDetection(List<Bullet> bullets,List<Rock> rocks)
        {   
            int poin = 0;
            for (int i = 0; i < bullets.Count; i++)
			{
                for (int j = 0; j < rocks.Count; j++)
                {
                    if (!bullets[i].IsDestroy && !rocks[j].IsDestroy)
                    {
                        if (bullets[i].Position == rocks[j].Position)
                        {
                            bullets[i].IsDestroy = true;
                            rocks[j].IsDestroy = true;
                            poin++;
                        }
                    }
                }
			}
            return poin;
        }

        public static bool RockSmash(Dwarf dwarf, List<Rock> rocks)
        {
            for (int i = 0; i < rocks.Count; i++)
            {
                if (dwarf.Position == rocks[i].Position)
                    return true;
            }
            return false;
        }
    }
}
