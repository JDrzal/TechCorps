using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStartScreen
{
    class Program
    {
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void Menu()
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            ConsoleKeyInfo Keyinfo;
            Keyinfo = Console.ReadKey(true);
            Console.Clear();
            int menu = 10;
            int redo = 0;

            //Menu Text

            Console.WriteLine("                    ");
            Console.WriteLine("                    ▄▄▄█████▓ ▄▄▄       ███▄    █  ██ ▄█▀");
            Console.WriteLine("                    ▓  ██▒ ▓▒▒████▄     ██ ▀█   █  ██▄█▒ ");
            Console.WriteLine("                    ▒ ▓██░ ▒░▒██  ▀█▄  ▓██  ▀█ ██▒▓███▄░ ");
            Console.WriteLine("                    ░ ▓██▓ ░ ░██▄▄▄▄██ ▓██▒  ▐▌██▒▓██ █▄ ");
            Console.WriteLine("                      ▒██▒ ░  ▓█   ▓██▒▒██░   ▓██░▒██▒ █▄");
            Console.WriteLine("                      ▒ ░░    ▒▒   ▓▒█░░ ▒░   ▒ ▒ ▒ ▒▒ ▓▒");
            Console.WriteLine("                        ░      ▒   ▒▒ ░░ ░░   ░ ▒░░ ░▒ ▒░");
            Console.WriteLine("                      ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                 SINGLE PLAYER");
            Console.WriteLine("                      ");
            Console.WriteLine("                      ");
            Console.WriteLine("                      ");
            Console.WriteLine("                      ");
            Console.WriteLine("                                 TWO PLAYER");
            Console.WriteLine("                      ");
            Console.WriteLine("                      ");
            Console.WriteLine("                      ");
            Console.WriteLine("                      ");
            Console.WriteLine("                                 EXIT");


            //Menu Cursor movement
            do
            {
                Keyinfo = Console.ReadKey(true);

                switch (Keyinfo.Key)
                {


                    case ConsoleKey.UpArrow:
                        if (menu != 10)
                        { menu -= 5; }
                        ClearCurrentConsoleLine();
                        Console.SetCursorPosition(28, menu);

                        Console.Write(">>>");
                        break;

                    case ConsoleKey.DownArrow:
                        if (menu != 20)
                            menu += 5;
                        ClearCurrentConsoleLine();
                        Console.SetCursorPosition(28, menu);
                        Console.Write(">>>");
                        break;

                    case ConsoleKey.Spacebar:

                        if (menu == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            redo = 1;
                        }
                        else if (menu == 15)
                        { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (menu == 20)
                        { Console.ForegroundColor = ConsoleColor.Green; }
                        break;


                }

            } while (redo == 0);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
