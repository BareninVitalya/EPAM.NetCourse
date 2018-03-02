using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static Random random = new Random();
        static int[,] FillArrayRandom(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = random.Next(0, 50);
                }
            }
            return array;
        }
        static int Sum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i,j];
                    }
                }
            }
            return sum;
        }
        static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"\t{array[i, j]}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input size 1 :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input size 2 :");
            int b = int.Parse(Console.ReadLine());
            var array = new int[a,b];
            //FillArrayRandom(array);
            Print(FillArrayRandom(array));
            Console.WriteLine("Sum = " + Sum(array));
            Console.ReadKey();
        }
    }
}
