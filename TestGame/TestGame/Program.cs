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
            int bulleth = hori;
            int bulletv = vert;
            int score = 0;

            ConsoleKeyInfo Keyinfo;

            bool pellet = true;
            bool pellet2 = true;
            bool pellet3 = true;
            bool pellet4 = true;
            bool bulletAlive = false;
            bool keyPressed = true;
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

                //outer walls
                Console.SetCursorPosition(0, 1);
                Console.Write("██");

                Console.SetCursorPosition(0, 2);
                Console.Write("██");

                Console.SetCursorPosition(0, 3);
                Console.Write("██");

                Console.SetCursorPosition(0, 4);
                Console.Write("██");

                Console.SetCursorPosition(0, 5);
                Console.Write("██");

                Console.SetCursorPosition(0, 6);
                Console.Write("██");

                Console.SetCursorPosition(0, 7);
                Console.Write("██");

                Console.SetCursorPosition(0, 8);
                Console.Write("██");

                Console.SetCursorPosition(0, 9);
                Console.Write("██");

                Console.SetCursorPosition(0, 10);
                Console.Write("██");

                Console.SetCursorPosition(0, 11);
                Console.Write("██");

                Console.SetCursorPosition(0, 12);
                Console.Write("██");

                Console.SetCursorPosition(0, 13);
                Console.Write("██");

                Console.SetCursorPosition(0, 14);
                Console.Write("██");

                Console.SetCursorPosition(0, 15);
                Console.Write("██");

                Console.SetCursorPosition(0, 16);
                Console.Write("██");

                Console.SetCursorPosition(0, 17);
                Console.Write("██");

                Console.SetCursorPosition(0, 18);
                Console.Write("██");

                Console.SetCursorPosition(0, 19);
                Console.Write("██");

                Console.SetCursorPosition(0, 20);
                Console.Write("██");

                Console.SetCursorPosition(0, 21);
                Console.Write("██");

                Console.SetCursorPosition(0, 22);
                Console.Write("██");

                Console.SetCursorPosition(0, 23);
                Console.Write("██");

                Console.SetCursorPosition(0, 24);
                Console.Write("██");

                Console.SetCursorPosition(1, 1);
                Console.Write("██");

                Console.SetCursorPosition(2, 1);
                Console.Write("██");

                Console.SetCursorPosition(3, 1);
                Console.Write("██");

                Console.SetCursorPosition(4, 1);
                Console.Write("██");

                Console.SetCursorPosition(5, 1);
                Console.Write("██");

                Console.SetCursorPosition(6, 1);
                Console.Write("██");

                Console.SetCursorPosition(7, 1);
                Console.Write("██");

                Console.SetCursorPosition(8, 1);
                Console.Write("██");

                Console.SetCursorPosition(9, 1);
                Console.Write("██");

                Console.SetCursorPosition(10, 1);
                Console.Write("██");

                Console.SetCursorPosition(11, 1);
                Console.Write("██");

                Console.SetCursorPosition(12, 1);
                Console.Write("██");

                Console.SetCursorPosition(13, 1);
                Console.Write("██");

                Console.SetCursorPosition(14, 1);
                Console.Write("██");

                Console.SetCursorPosition(15, 1);
                Console.Write("██");

                Console.SetCursorPosition(16, 1);
                Console.Write("██");

                Console.SetCursorPosition(17, 1);
                Console.Write("██");

                Console.SetCursorPosition(18, 1);
                Console.Write("██");

                Console.SetCursorPosition(19, 1);
                Console.Write("██");

                Console.SetCursorPosition(20, 1);
                Console.Write("██");

                Console.SetCursorPosition(21, 1);
                Console.Write("██");

                Console.SetCursorPosition(22, 1);
                Console.Write("██");

                Console.SetCursorPosition(23, 1);
                Console.Write("██");

                Console.SetCursorPosition(24, 1);
                Console.Write("██");

                Console.SetCursorPosition(25, 1);
                Console.Write("██");

                Console.SetCursorPosition(26, 1);
                Console.Write("██");

                Console.SetCursorPosition(27, 1);
                Console.Write("██");

                Console.SetCursorPosition(28, 1);
                Console.Write("██");

                Console.SetCursorPosition(29, 1);
                Console.Write("██");

                Console.SetCursorPosition(30, 1);
                Console.Write("██");

                Console.SetCursorPosition(31, 1);
                Console.Write("██");

                Console.SetCursorPosition(32, 1);
                Console.Write("██");      
                                          
                Console.SetCursorPosition(33, 1);
                Console.Write("██");      
                                          
                Console.SetCursorPosition(34, 1);
                Console.Write("██");      
                                          
                Console.SetCursorPosition(35, 1);
                Console.Write("██");      
                                          
                Console.SetCursorPosition(36, 1);
                Console.Write("██");      
                                          
                Console.SetCursorPosition(37, 1);
                Console.Write("██");      
                                          
                Console.SetCursorPosition(38, 1);
                Console.Write("██");      
                                          
                Console.SetCursorPosition(39, 1);
                Console.Write("██");

                Console.SetCursorPosition(40, 1);
                Console.Write("██");

                Console.SetCursorPosition(41, 1);
                Console.Write("██");

                Console.SetCursorPosition(42, 1);
                Console.Write("██");

                Console.SetCursorPosition(43, 1);
                Console.Write("██");

                Console.SetCursorPosition(44, 1);
                Console.Write("██");

                Console.SetCursorPosition(45, 1);
                Console.Write("██");

                Console.SetCursorPosition(46, 1);
                Console.Write("██");

                Console.SetCursorPosition(47, 1);
                Console.Write("██");

                Console.SetCursorPosition(48, 1);
                Console.Write("██");

                Console.SetCursorPosition(49, 1);
                Console.Write("██");

                Console.SetCursorPosition(50, 1);
                Console.Write("██");

                Console.SetCursorPosition(51, 1);
                Console.Write("██");

                Console.SetCursorPosition(52, 1);
                Console.Write("██");

                Console.SetCursorPosition(53, 1);
                Console.Write("██");

                Console.SetCursorPosition(54, 1);
                Console.Write("██");

                Console.SetCursorPosition(55, 1);
                Console.Write("██");

                Console.SetCursorPosition(56, 1);
                Console.Write("██");

                Console.SetCursorPosition(57, 1);
                Console.Write("██");

                Console.SetCursorPosition(58, 1);
                Console.Write("██");

                Console.SetCursorPosition(59, 1);
                Console.Write("██");

                Console.SetCursorPosition(60, 1);
                Console.Write("██");

                Console.SetCursorPosition(61, 1);
                Console.Write("██");

                Console.SetCursorPosition(62, 1);
                Console.Write("██");

                Console.SetCursorPosition(63, 1);
                Console.Write("██");

                Console.SetCursorPosition(64, 1);
                Console.Write("██");

                Console.SetCursorPosition(65, 1);
                Console.Write("██");

                Console.SetCursorPosition(66, 1);
                Console.Write("██");

                Console.SetCursorPosition(67, 1);
                Console.Write("██");

                Console.SetCursorPosition(68, 1);
                Console.Write("██");

                Console.SetCursorPosition(69, 1);
                Console.Write("██");

                Console.SetCursorPosition(70, 1);
                Console.Write("██");

                Console.SetCursorPosition(71, 1);
                Console.Write("██");

                Console.SetCursorPosition(72, 1);
                Console.Write("██");

                Console.SetCursorPosition(73, 1);
                Console.Write("██");

                Console.SetCursorPosition(74, 1);
                Console.Write("██");

                Console.SetCursorPosition(75, 1);
                Console.Write("██");

                Console.SetCursorPosition(76, 1);
                Console.Write("██");

                Console.SetCursorPosition(77, 1);
                Console.Write("██");

                Console.SetCursorPosition(78, 1);
                Console.Write("██");

                Console.SetCursorPosition(78, 2);
                Console.Write("██");

                Console.SetCursorPosition(78, 3);
                Console.Write("██");

                Console.SetCursorPosition(78, 4);
                Console.Write("██");

                Console.SetCursorPosition(78, 5);
                Console.Write("██");

                Console.SetCursorPosition(78, 6);
                Console.Write("██");

                Console.SetCursorPosition(78, 7);
                Console.Write("██");

                Console.SetCursorPosition(78, 8);
                Console.Write("██");

                Console.SetCursorPosition(78, 9);
                Console.Write("██");

                Console.SetCursorPosition(78, 10);
                Console.Write("██");

                Console.SetCursorPosition(78, 11);
                Console.Write("██");

                Console.SetCursorPosition(78, 12);
                Console.Write("██");

                Console.SetCursorPosition(78, 13);
                Console.Write("██");

                Console.SetCursorPosition(78, 14);
                Console.Write("██");

                Console.SetCursorPosition(78, 15);
                Console.Write("██");

                Console.SetCursorPosition(78, 16);
                Console.Write("██");

                Console.SetCursorPosition(78, 17);
                Console.Write("██");

                Console.SetCursorPosition(78, 18);
                Console.Write("██");

                Console.SetCursorPosition(78, 19);
                Console.Write("██");

                Console.SetCursorPosition(78, 20);
                Console.Write("██");

                Console.SetCursorPosition(78, 21);
                Console.Write("██");

                Console.SetCursorPosition(78, 22);
                Console.Write("██");

                Console.SetCursorPosition(78, 23);
                Console.Write("██");

                Console.SetCursorPosition(78, 24);
                Console.Write("██");



                //collecting pellets
                if (hori == pellethori && vert == pelletvert && pellet == true) { pellet = false; score++; }
                if (hori == pellet2hori && vert == pellet2vert && pellet2 == true) { pellet2 = false; score++; }
                if (hori == pellet3hori && vert == pellet3vert && pellet3 == true) { pellet3 = false; score++; }
                if (hori == pellet4hori && vert == pellet4vert && pellet4 == true) { pellet4 = false; score++; }

                
                
                if (bulletAlive == true)
                    {
                    Console.SetCursorPosition(bulleth, bulletv);
                    Console.Write("o");
                    bulletv--;
                }


                //key press

                
                

                
                {
                    switch (Keyinfo.Key)
                    {
                        case ConsoleKey.Spacebar:
                            Console.SetCursorPosition(bulleth, bulletv);
                            bulleth = (hori + 2);
                            Console.Write("o");
                            bulletAlive = true;
                            keyPressed = true;
                            break;

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

                }
                


            } while (redo == 0);
            Console.ReadLine();
            
        }
        
    }

}
