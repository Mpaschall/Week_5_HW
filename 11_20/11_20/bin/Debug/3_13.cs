using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double kiloCon = .45359237;
            double kilo = 0;
            double pound = 0;
            double ounce = 0;

            Console.WriteLine("Please enter the number of kilograms.");
            kilo = Convert.ToDouble(Console.ReadLine());

            pound = (kilo / kiloCon);
            ounce = ((kilo / kiloCon) * 16);
            if ((pound) > 1)
            {
                Console.WriteLine("That is " + pound + " pounds");
            }
            else
            {
                Console.WriteLine("That is " + ounce + " ounces");
            }
        }
    }
}
