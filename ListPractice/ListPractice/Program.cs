using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            students.Add("John");
            students.Add("Logan");
            students.Add("Dylan");
            students.Add("Evan");
            students.Add("Josh");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
