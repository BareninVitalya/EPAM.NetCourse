using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static Random random = new Random();
        static int[] FillArrayRandom(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,20);
            }
            return array;
        }
        static int [] Sotr(int[] array )
        {
            int temp = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max<array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input size:");
            int a = int.Parse(Console.ReadLine());
            var array = new int[a];
            Console.WriteLine(string.Join(" ", FillArrayRandom(array)));
            Console.WriteLine(string.Join(" ", Sotr(array)));
            Console.WriteLine("Max ="+Max(array)+"  Min ="+Min(array));
            Console.ReadLine();
        }
    }
}
