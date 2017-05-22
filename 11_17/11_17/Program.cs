using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11_17
{
    class Program 
    {
        static void Main(string[] args)
        {
            string line = "";
            string searchedFile = "";
            string searchedWord = "";
            Console.WriteLine("Please enter a .txt file you would like to search, the included file name is abigcar. Please leave out the file extension.");
            searchedFile = Console.ReadLine() + ".txt";
            Console.WriteLine("What string would you like to look for? e.g car");
            searchedWord = Console.ReadLine();
            //file contains the text "a big car"
            StreamReader file = new StreamReader(searchedFile);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(searchedWord))
                {
                    Console.WriteLine("This file contains " + searchedWord);
                }
                else
                {
                    Console.WriteLine("This file does not contain " + searchedWord);
                }
            }

            
        }
    }
}
