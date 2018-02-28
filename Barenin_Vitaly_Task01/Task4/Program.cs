using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("input number of lines:");
            String input = Console.ReadLine();
            int lines = int.Parse(input);
            int numderOfStars = 1;
            int space = lines - 1;
            for (int i = 0; i < lines; i++)
            {
                string b = new string(' ', space);
                string c = new string('*', numderOfStars);
                space--;
                numderOfStars += 2;
                Console.WriteLine(b += c);
            }
            Console.ReadLine();
        }
    }
}
