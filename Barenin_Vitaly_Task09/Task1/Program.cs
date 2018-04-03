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
            string[] stringArray = {"we","are","a","global","team","of","technologists" ,"anc","abc"};
     //       CompareString compareString = new CompareString(CompareElementsOfStringArrayByLength);
            stringArray = SortArray(stringArray, CompareElementsOfStringArrayByLength);
            Console.WriteLine(String.Join(" ", stringArray));
            Console.ReadKey();
        }
     //   public delegate int CompareString(string elementA, string elementB);
        static public string[] SortArray(string[] str, Func<string,string,int> compareString)
        {
            if (compareString != null)
            {
                string temp;
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (compareString(str[i], str[j]) != 0)
                        {
                            if (compareString(str[i], str[j]) == 1)
                            {
                                temp = str[i];
                                str[i] = str[j];
                                str[j] = temp;
                            }
                        }
                    }
                }
                return str;
            }
            else
            {
                throw new ArgumentException("Delegate is null!");
            }
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
                    return String.Compare(elementA, elementB);
                }
            }
        }
    }
}
