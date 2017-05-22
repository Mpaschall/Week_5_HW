using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11_18
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string line = "";
            string file = "";
            Console.WriteLine("Please enter a text file name without the extension. The file for this is ExtraSpaces.");
            file = Console.ReadLine() + ".txt";
            StreamReader reader = new StreamReader(file);
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("Original: " + line);
                line = string.Join(" ", line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                Console.WriteLine("Fixed: " + line);
            }
        }
    }
    
}
