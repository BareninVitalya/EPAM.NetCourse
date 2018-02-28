using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Tree(int lines, int tree)
        {
            int numderOfStars = 1;
            int space = tree-1;
            for (int i = 0; i < lines; i++)
            {
                string b = new string(' ', space);
                string c = new string('*',numderOfStars);
                numderOfStars += 2;
                space--;
                Console.WriteLine(b+=c);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("input number of tree:");
            String input = Console.ReadLine();
            int tree = int.Parse(input);
            int lines = 0;
            for (int i=0; i<tree; i++)
            {
                lines++;
                Tree(lines, tree);
            }
            Console.ReadLine();
            
            
        }
    }
}
