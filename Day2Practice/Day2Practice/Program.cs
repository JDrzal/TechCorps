using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbercheck
{
    class Program
    {
        public static void Clear()
        {
            letters();  
        }
        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        static void letters()
        {
            
            bool hori = true;
            
            for (int spacehori = 0; spacehori < 40; spacehori++)

            if (hori == true)
            {
                if (spacehori == 1) { Console.WriteLine(" " + "c"); }
                if (spacehori == 2) { Console.Clear(); Console.WriteLine("  " + "c"); }
                if (spacehori == 3) { Console.Clear(); Console.WriteLine("   " + "c"); }
                if (spacehori == 4) { Console.Clear(); Console.WriteLine("    " + "c"); }
                if (spacehori == 5) { Console.Clear(); Console.WriteLine("     " + "c"); }
                if (spacehori == 6) { Console.Clear(); Console.WriteLine("      " + "c"); }
                if (spacehori == 7) { Console.Clear(); Console.WriteLine("       " + "c"); }
                if (spacehori == 8) { Console.Clear(); Console.WriteLine("        " + "c"); }
                if (spacehori == 9) { Console.Clear(); Console.WriteLine("         " + "c"); }
                if (spacehori == 10) { Console.Clear(); Console.WriteLine("          " + "c"); }
                if (spacehori == 11) { Console.Clear(); Console.WriteLine("           " + "c"); }
                if (spacehori == 12) { Console.Clear(); Console.WriteLine("            " + "c"); }
                if (spacehori == 13) { Console.Clear(); Console.WriteLine("             " + "c"); }
                if (spacehori == 14) { Console.Clear(); Console.WriteLine("              " + "c"); }
                if (spacehori == 15) { Console.Clear(); Console.WriteLine("               " + "c"); }
                if (spacehori == 16) { Console.Clear(); Console.WriteLine("                " + "c"); }
                if (spacehori == 17) { Console.Clear(); Console.WriteLine("                 " + "c"); }
                if (spacehori == 18) { Console.Clear(); Console.WriteLine("                  " + "c"); }
                if (spacehori == 19) { Console.Clear(); Console.WriteLine("                   " + "c"); }
                if (spacehori == 20) { Console.Clear(); Console.WriteLine("                    " + "c"); }
                if (spacehori == 21) { Console.Clear(); Console.WriteLine("                     " + "c"); }
                if (spacehori == 22) { Console.Clear(); Console.WriteLine("                      " + "c"); }
                if (spacehori == 23) { Console.Clear(); Console.WriteLine("                       " + "c"); }
                if (spacehori == 24) { Console.Clear(); Console.WriteLine("                        " + "c"); }
                if (spacehori == 25) { Console.Clear(); Console.WriteLine("                         " + "c"); }
                if (spacehori == 26) { Console.Clear(); Console.WriteLine("                          " + "c"); }
                if (spacehori == 27) { Console.Clear(); Console.WriteLine("                           " + "c"); }
                if (spacehori == 28) { Console.Clear(); Console.WriteLine("                            " + "c"); }
                if (spacehori == 29) { Console.Clear(); Console.WriteLine("                             " + "c"); }
                if (spacehori == 30) { Console.Clear(); Console.WriteLine("                              " + "c"); }
                if (spacehori == 31) { Console.Clear(); Console.WriteLine("                               " + "c"); }
                if (spacehori == 32) { Console.Clear(); Console.WriteLine("                                " + "c"); }
                if (spacehori == 33) { Console.Clear(); Console.WriteLine("                                 " + "c"); }
                if (spacehori == 34) { Console.Clear(); Console.WriteLine("                                  " + "c"); }
                if (spacehori == 35) { Console.Clear(); Console.WriteLine("                                   " + "c"); }
                if (spacehori == 36) { Console.Clear(); Console.WriteLine("                                    " + "c"); }
                if (spacehori == 37) { Console.Clear(); Console.WriteLine("                                     " + "c"); }
                if (spacehori == 38) { Console.Clear(); Console.WriteLine("                                      " + "c"); }
                if (spacehori == 39) { Console.Clear(); Console.WriteLine("                                       " + "c"); }
                    System.Threading.Thread.Sleep(25);
                
            }
        }
        static void background()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            System.Threading.Thread.Sleep(100);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            System.Threading.Thread.Sleep(100);
            background();
        }
        static void runTracker()
        {
            while (true)
            {
                Console.Write("enter the distance in miles ");
                double distanceRan = double.Parse(System.Console.ReadLine());
                Console.Write("enter the time it took in minutes ");
                double timeran = double.Parse(System.Console.ReadLine());

                double averageamp = (timeran / distanceRan);
                Console.WriteLine("it took about" + " " + averageamp + " " + "minutes to run a mile");
            }
        }
        static void numcheck()
        {
            Console.Write("Enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            string size = "nothing";
            if (number >= 100) size = "big";
            if (number <= 100) size = "small";
            else
            { Console.Write(" "); }

            Console.Write("that is a" + " " + size + " " + "number");
        }
        static void Main(string[] args)
        {
            letters();
        }
    }
}
