using System;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static private void CheckEnteredNumder(string text)
        {
            Regex regexScience = new Regex(@"[0-9]+[e,*,^]+[0-9,-]");
            Regex regexOrdinary = new Regex(@"[0-9]+[.][0-9]");
            if (regexScience.IsMatch(text))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else
            {
                if (regexOrdinary.IsMatch(text)||Int32.TryParse(text,out int number))
                {
                    Console.WriteLine("Это число в обычной нотации");
                }
                else
                {
                    Console.WriteLine("Это не число");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            CheckEnteredNumder(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
