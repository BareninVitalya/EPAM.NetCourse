using System;

namespace Task1
{
    class Program
    {
        static private int AvgWord(string text)
        {
            char[] separator = new char[text.Length];
            int avgWord = 0;
            int numberOfWord = 0;
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (!(Char.IsLetter(text[i])))
                {
                    separator[j] = text[i];
                    j++;
                }
            }
            string[] subString = text.Split(separator);
            for (int i = 0; i < subString.Length; i++)
            {
                if (subString[i].Length != 0)
                {
                    avgWord += subString[i].Length;
                    numberOfWord++;
                }
            }
            return avgWord /= numberOfWord;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            String text = Console.ReadLine();
            Console.WriteLine(AvgWord(text));
            Console.ReadLine();
        }
    }
}
