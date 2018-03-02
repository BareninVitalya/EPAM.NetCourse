using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static Random random = new Random();
        static int[] FillArrayRandom(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(-100, 100);
            }
            return array;
        }
        static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                        if (array[i] > 0)
                        {
                            sum+=array[i];
                        }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input size:");
            int a = int.Parse(Console.ReadLine());
            var array = new int[a];
            Console.WriteLine(string.Join(" ", FillArrayRandom(array)));
            Console.WriteLine("Sum = " + Sum(array));
            Console.ReadKey();
        }
    }
}
