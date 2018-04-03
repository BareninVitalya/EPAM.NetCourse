using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public delegate void PrintArray(string[] str);
        static public event PrintArray FinishSort;
        static void Main(string[] args)
        {
            var strArray1 = new string[]{ "we", "are", "a", "global", "team", "of", "technologists" };
            var strArray2 = new string[] { "we", "are", "a", "global", "team", "of", "technologists" };
            FinishSort += Print;
            ThreadStart sort = () =>
            {
                strArray1 = SortArray(strArray1);
            };
            Thread newThread = new Thread(sort);
            ThreadStart sort2 = () =>
            {
                strArray1 = SortArray(strArray2);
            };
            Thread newThread2 = new Thread(sort2);
            newThread.Start();
            newThread2.Start();
            Console.ReadKey();
        }
        static public void Print(string[] str)
        {
            Console.WriteLine(String.Join(" ", str));
        }
        static public string[] SortArray(string[] str)
        {
                string temp;
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (CompareElementsOfStringArrayByLength(str[i], str[j]) != 0)
                        {
                            if (CompareElementsOfStringArrayByLength(str[i], str[j]) == -1)
                            {
                                temp = str[i];
                                str[i] = str[j];
                                str[j] = temp;
                            }
                        }
                    Thread.Sleep(100);
                    }
                }
            FinishSort(str);
                return str;
            }
        static public int CompareElementsOfStringArrayByLength(string elementA, string elementB)
        {
            if (elementA.Length > elementB.Length)
            {
                return -1;
            }
            else
            {
                if (elementA.Length < elementB.Length)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
