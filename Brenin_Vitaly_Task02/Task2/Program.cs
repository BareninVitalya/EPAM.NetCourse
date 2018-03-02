using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static Random random = new Random();
        static int[,,] FillArrayRandom(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int s = 0; s < array.GetLength(2); s++)
                    {
                        array[s,j,i] = random.Next(-100,100);
                    }
                }
            }
            return array; 
        }
        static int[,,] Replace(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int s = 0; s < array.GetLength(2); s++)
                    {
                        if (array[s, j, i] > 0)
                        {
                            array[s, j, i] = 0;
                        }
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input size 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input size 2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input size 3:");
            int c = int.Parse(Console.ReadLine());
            var array = new int[a, b, c];
            FillArrayRandom(array);
            Replace(array);
            Console.ReadKey();
        }
    }
}
