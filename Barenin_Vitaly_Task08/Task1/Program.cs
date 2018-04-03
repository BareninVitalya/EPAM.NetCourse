using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            LinkedList<string> linkedList = new LinkedList<string>();
            Fill(8, list);
            Fill(8, linkedList);
            RemoveEachSecondItem(list);
            Console.WriteLine("-");
            RemoveEachSecondItem(linkedList);
            Console.ReadKey();
        }
        static public void Fill(int n, ICollection<int> collection)
        {
            for (int i = 1; i < n; i++)
            {
                collection.Add(i);
            }
        }
        static public void Fill(int n, ICollection<string> collection)
        {
            for (int i = 1; i < n; i++)
            {
                collection.Add(i.ToString());
            }
        }
        static public void RemoveEachSecondItem<T>(ICollection<T> collection)
        {
            int count = 1;
            T temp = default(T);
            while (collection.Count != 1)
            {
                List<T> list = new List<T>();
                foreach (var i in collection)
                {
                    if (count % 2 == 0)
                    {
                        list.Add(i);
                    }
                    count++;
                    temp = i;
                }
                foreach (var i in list)
                {
                    collection.Remove(i);
                }
                if (collection.Contains(temp))
                {
                    count = 2;
                }
                else
                {
                    count = 1;
                }
                foreach (var i in collection)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}
