using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2labs
{
    class Program
    {
        static string didPass(int testScore)
        {
            if (testScore >= 70) 
            {
                return "pass";

            }
            else
            {
                return "fail";
            }
        }
        static string name(string firstName, string lastName, int score)
        {

            string result = lastName + firstName + didPass(score);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(name("Jill ", "Henderson ", 90));
            Console.WriteLine(name("Joshua ", "Matia ", 50));
            Console.WriteLine(name("Samantha ", "Henderson ", 90));
        }
    }
}
