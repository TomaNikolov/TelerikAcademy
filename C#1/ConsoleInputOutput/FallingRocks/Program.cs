using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallingRocks
{

    class Program
    {
        static int point = 0;
        static void Main(string[] args)
        {

            Console.WindowHeight = 40;
            Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.BufferWidth;
            List<GameObject> allObject = new List<GameObject>();
            List<Rock> rocks = new List<Rock>();
            List<Bullet> bullets = new List<Bullet>();
            Random random = new Random();
            Dwarf dwarf = new Dwarf(new Position(20, 39));
            allObject.Add(dwarf);
            Draw(allObject);




            while (true)
            {
                Thread.Sleep(150);
                Console.Clear();

                Console.WriteLine("point = " + point);
                Rock rock = new Rock(new Position(random.Next(39), 1), new Position(0, 1));

                allObject.Add(rock);
                rocks.Add(rock);
                point += CollisionDetection.BulletDetection(bullets, rocks);

                if (CollisionDetection.RockSmash(dwarf, rocks))
                {
                    EndGame();
                }



                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.Position.Row > 0)
                        {
                            dwarf.MoveLeft();
                        }
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.Position.Row < Console.WindowWidth - 2)
                        {
                            dwarf.MoveRight();
                        }
                    }
                    if (userInput.Key == ConsoleKey.Spacebar)
                    {
                        Bullet bullet = new Bullet(new Position(dwarf.Position.Row, dwarf.Position.Col - 1), new Position(0, -1));
                        bullets.Add(bullet);
                        allObject.Add(bullet);

                    }

                }
                Draw(allObject);

            }

        }
        private static void ShootRoks(Position position, List<Bullet> bullets)
        {
            Bullet bullet = new Bullet(position, new Position(0, -1));
            bullets.Add(bullet);
        }
        private static void EndGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over!");
            Console.WriteLine("Point = " + point);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            Environment.Exit(0);
            
        }
        private static void Draw(List<GameObject> allObject)
        {
            foreach (var obj in allObject)
            {
                if (obj.Position.Col == Console.WindowHeight ||
                    obj.Position.Col == 0)
                {
                    obj.IsDestroy = true;
                }
                if (!obj.IsDestroy)
                {
                    Console.SetCursorPosition(obj.Position.Row, obj.Position.Col);
                    Console.ForegroundColor = obj.color;
                    obj.Update();
                    Console.Write(obj.Sign);
                }
            }

        }

    }
}
