using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input number of lines:");
            String input = Console.ReadLine();
            int lines = int.Parse(input);
            int numderOfStars=0;
            for (int i = 0; i < lines; i++)
            {
                numderOfStars++;
                for (int j=0; j<numderOfStars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
