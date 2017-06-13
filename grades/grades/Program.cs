using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class Program
    {
        static void giveStudentGrade(string firstName, string lastName, int Score)
        {
            string grade = "A";
            if (Score > 79 && Score < 90)
            {
                grade = "B";
            }
            else if (Score > 69 && Score < 80)
            {
                grade = "c";
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
