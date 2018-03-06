using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();
            Regex regex = new Regex(@"([0-1][0-9]:[0-5][0-9])|([2][0-3]:[0-5][0-9])|(\D[0-9]:[0-5][0-9])");
            Console.WriteLine("Number of time:"+regex.Matches(text).Count);
            Console.ReadLine();
        }
    }
}
