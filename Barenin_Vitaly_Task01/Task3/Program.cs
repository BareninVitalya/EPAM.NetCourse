using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;
            int sum3 = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            for (int i = 0; i < 1000; i+=3)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    sum2 += i;
                }
            }
            for (int i = 0; i < 1000; i+=5)
            {
                    sum3 += i;
            }
            Console.WriteLine("Sum of numders = "+sum);
            Console.WriteLine("Sum of numders2 = " + (sum2+sum3));
            Console.ReadLine();
        }
    }
}
