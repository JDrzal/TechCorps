using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int redo = 0;
            int hori = 20;
            int vert = 20;
            int score = 0;
            ConsoleKeyInfo Keyinfo;

            bool pellet = true;
            bool pellet2 = true;
            bool pellet3 = true;
            bool pellet4 = true;
            do

            {
                //score
                Console.SetCursorPosition(0, 0);
                Console.Write("Score: " + score);

                Keyinfo = Console.ReadKey(true);
                Console.Clear();

                //pellet
                int pellethori = 10;
                int pelletvert = 10;
                if (pellet == true)
                {
                    Console.SetCursorPosition(pellethori, pelletvert);
                    Console.Write("O");
                }

                //pellet2
                int pellet2hori = 20;
                int pellet2vert = 10;
                if (pellet2 == true)
                {
                    Console.SetCursorPosition(pellet2hori, pellet2vert);
                    Console.Write("O");
                }

                //pellet3
                int pellet3hori = 30;
                int pellet3vert = 10;
                if (pellet3 == true)
                {
                    Console.SetCursorPosition(pellet3hori, pellet3vert);
                    Console.Write("O");
                }

                //pellet4
                int pellet4hori = 40;
                int pellet4vert = 10;
                if (pellet4 == true)
                {
                    Console.SetCursorPosition(pellet4hori, pellet4vert);
                    Console.Write("O");
                }
                //collecting pellets
                if (hori == pellethori && vert == pelletvert && pellet == true) { pellet = false; score++; }
                if (hori == pellet2hori && vert == pellet2vert && pellet2 == true) { pellet2 = false; score++; }
                if (hori == pellet3hori && vert == pellet3vert && pellet3 == true) { pellet3 = false; score++; }
                if (hori == pellet4hori && vert == pellet4vert && pellet4 == true) { pellet4 = false; score++; }

                switch (Keyinfo.Key)
                {

                    case ConsoleKey.RightArrow:
                        hori++;
                        Console.SetCursorPosition(hori, vert);
                        Console.Write("██");
                        break;
                    case ConsoleKey.LeftArrow:
                        hori--;
                        Console.SetCursorPosition(hori, vert);
                        Console.Write("██");
                        break;
                    case ConsoleKey.DownArrow:
                        vert++;
                        Console.SetCursorPosition(hori, vert);
                        Console.Write("██");
                        break;
                    case ConsoleKey.UpArrow:
                        vert--;
                        Console.SetCursorPosition(hori, vert);
                        Console.Write("██");
                        break;

                }


            } while (redo == 0);
            Console.ReadLine();
        }
    }

}
