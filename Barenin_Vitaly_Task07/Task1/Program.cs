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
            DynamicArray<int> dynamicArray = new DynamicArray<int>(5);
            DynamicArray<char> dynamicArrayChar = new DynamicArray<char>(5);
            //dynamicArray.Add(1);
            //dynamicArray.Add(4);
            //dynamicArray[2] = 55;
            //dynamicArray[3] = 333;
            //dynamicArray.Add(7);
            //dynamicArray.AddRange(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //for (int i = 0; i < dynamicArray.Length; i++)
            //{
            //    Console.WriteLine(dynamicArray[i]);
            //}
            //Console.WriteLine("{0},{1}", dynamicArray.Capacity, dynamicArray.Length);
            //dynamicArray.Remove(5);
            //for (int i = 0; i < dynamicArray.Length; i++)
            //{
            //    Console.WriteLine(dynamicArray[i]);
            //}
            //Console.WriteLine("{0},{1}", dynamicArray.Capacity, dynamicArray.Length);
            //dynamicArray.Insert(4, 55555);
            //for (int i = 0; i < dynamicArray.Length; i++)
            //{
            //    Console.WriteLine(dynamicArray[i]);
            //}
            //Console.WriteLine("{0},{1}", dynamicArray.Capacity, dynamicArray.Length);

            dynamicArrayChar.Add('п');
            dynamicArrayChar.Add('р');
            dynamicArrayChar[2] = 'и';
            dynamicArrayChar[3] = 'в';
            dynamicArrayChar.Add('е');
            dynamicArrayChar.AddRange(new[] {'т',' ','д','р','у','г','!'});
            for (int i = 0; i < dynamicArrayChar.Length; i++)
            {
                Console.Write(dynamicArrayChar[i]);
            }
            Console.WriteLine("{0},{1}", dynamicArrayChar.Capacity, dynamicArrayChar.Length);
            dynamicArrayChar.Remove(4);
            for (int i = 0; i < dynamicArrayChar.Length; i++)
            {
                Console.Write(dynamicArrayChar[i]);
            }
            Console.WriteLine("{0},{1}", dynamicArrayChar.Capacity, dynamicArrayChar.Length);
            dynamicArrayChar.Insert(4, '!');
            for (int i = 0; i < dynamicArrayChar.Length; i++)
            {
                Console.Write(dynamicArrayChar[i]);
            }
            Console.WriteLine("{0},{1}", dynamicArrayChar.Capacity, dynamicArrayChar.Length);
            Console.ReadLine();

        }
    }
}
