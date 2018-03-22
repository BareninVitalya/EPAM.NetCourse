using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApplication;

namespace Task3
{
    class Program
    {
        static public void PrintIndexInStep(IIndexable indexable, int step, int count)
        {
            for (int i=0; i<count; i++)
            {
                Console.WriteLine(indexable[i*step]);
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] vs = new double[] { 0,1,2,3,4,5,6,7,8,9,10};
            List list = new List(vs);
            PrintIndexInStep(list,3,4);
            Console.ReadKey();
        }
    }
}
