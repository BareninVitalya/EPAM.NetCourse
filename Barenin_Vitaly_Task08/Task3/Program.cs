using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "THIS this ThiS is IS iS text with multile words, that we are Are ArE ARE gonna count!";
            string[] stringArr = DeleteSpacesAndPunctuation(str);
            var numberOfWords = stringArr.Length;
            var uniqueStr = stringArr.Distinct(StringComparer.CurrentCultureIgnoreCase).ToArray();
            int[] numberOfIntromission = new int[uniqueStr.Length];
            Dictionary<string, double> wordAndNumber = new Dictionary<string, double>();
            FindingWords(uniqueStr, numberOfIntromission, str, wordAndNumber, numberOfWords);
            Console.WriteLine(str);
            Console.WriteLine("Word | Rate");
            wordAndNumber = Sort(wordAndNumber);
            Writeline(wordAndNumber, wordAndNumber.Count);
            Console.ReadKey();
        }
        static string[] DeleteSpacesAndPunctuation(string s)
        {
            Regex rgx = new Regex("\\W");
            string[] wordsOnly = rgx.Split(s).Where(str => str != String.Empty).ToArray();
            return wordsOnly;
        }
        static Dictionary<string, double> Sort(Dictionary<string, double> dictionary)
        {
            dictionary = dictionary.OrderByDescending(di => di.Value).ToDictionary(di => di.Key, di => di.Value);
            return dictionary;
        }
        private static void FindingWords(string[] words, int[] count, string source, Dictionary<string, double> dictionary, int numberOfWords)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string pattern = "\\b(?i)" + words[i] + "(?-i)\\b";
                count[i] = new Regex(pattern).Matches(source).Count;
                double rate = count[i] / (numberOfWords * 0.01);
                dictionary.Add(words[i], rate);
            }
        }
        private static void Writeline(Dictionary<string, double> dictionary, int NumOfIteration)
        {
            foreach (var i in dictionary)
            {
                Console.WriteLine("{0} : {1:0.##}%", i.Key, i.Value);
            }
        }
    }
}