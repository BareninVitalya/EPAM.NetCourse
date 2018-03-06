using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static private void ComapreTime(int numder)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("NumberOfIterations: " + numder);
            stopWatch.Start();
            for (int i = 0; i < numder; i++)
            {
                str += "*";
            }
            stopWatch.Stop();
            Console.WriteLine("String: "+stopWatch.Elapsed);
            stopWatch.Reset();
            stopWatch.Start();
            for (int i = 0; i < numder; i++)
            {
                sb.Append("*");
            }
            stopWatch.Stop();
            Console.WriteLine("StringBuilder: " + stopWatch.Elapsed);
        }
        static void Main(string[] args)
        {
            ComapreTime(10);
            ComapreTime(50);
            ComapreTime(100);
            ComapreTime(500);
            ComapreTime(1000);
            Console.ReadLine();
        }
    }
}
