using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a:");
            String input = Console.ReadLine();
            int a = int.Parse(input);
            Console.WriteLine("input b:");
            input = Console.ReadLine();
            int b = int.Parse(input);
            if (!(a <= 0 || b <= 0))
            {
                int squre = a * b;
                Console.WriteLine("Squre =" + squre);
            }
            else
            {
                Console.WriteLine("Error: Wrong numder!");
            }
            Console.ReadLine();
        }
    }
}
