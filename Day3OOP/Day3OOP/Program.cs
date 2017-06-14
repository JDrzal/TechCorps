using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Day3OOP.Car();
            car1.make = "Ford";
            car1.model = "Focus";
            car1.color = "Red";

            Car car2 = new Day3OOP.Car();
            car2.make = "Kia";
            car2.model = "Spectra";
            car2.color = "Black";
            
        }
    }
    
}
