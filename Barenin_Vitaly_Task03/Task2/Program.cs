using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static private string DoubleLetters(string textString, string keyString)
        {
            char[] characters = new char[keyString.Length];
            string outText = string.Empty;
            int j = 0;
            for (int i = 0; i < keyString.Length; i++)
            {
                if (!(characters.Contains(keyString[i])) && textString.Contains(keyString[i]))
                {
                    characters[j] = keyString[i];
                    j++;
                }
            }
            for (int i = 0; i < textString.Length; i++)
            {
                outText += textString[i];
                if (characters.Contains<Char>(textString[i]) && textString[i] != ' ')
                {
                    outText += textString[i];
                }
            }
            return outText;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input string first: ");
            String text = Console.ReadLine();
            Console.WriteLine("Input string second: ");
            String text2 = Console.ReadLine();
            DoubleLetters(text, text2);
            Console.WriteLine("Result string: {0}", DoubleLetters(text, text2));
            Console.ReadLine();
        }
    }
}
