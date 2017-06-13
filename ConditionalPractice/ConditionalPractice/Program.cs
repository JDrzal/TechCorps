using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void InfoCollection()
        {
            Console.WriteLine("what is the water temp?");
            int Watertemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is the air temp?");
            int airtemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is the %chance of rain?");
            int por = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is the time of day (0-24)?");
            int time = Convert.ToInt32(Console.ReadLine());

            if ((time >= 12) && (time <= 16) && (Watertemp > 70) && (airtemp > 80))
                Console.WriteLine("Go swimming");
            if ((airtemp > 60) && (por < 50) && (time > 10) && (time < 18))
                Console.WriteLine("Play Soccer");
            if ((por > 60) || (time > 18) && (time < 20))
                Console.WriteLine("play boardgames");
            if (time > 20) Console.WriteLine("Watch movies");
            else
            {
                Console.WriteLine("I cannot provide any suggestions");
            }
        }
        static void Main(string[] args)
        {
            InfoCollection();
        }
    }
}
