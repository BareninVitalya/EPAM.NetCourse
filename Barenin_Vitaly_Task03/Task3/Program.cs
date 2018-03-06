using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static private void CompareCultures(string nameFirstCulture, string nameSecondCulture)
        {
            try
            {
                CultureInfo cultureInfoFirst = new CultureInfo(nameFirstCulture);
                CultureInfo cultureInfoSecond = new CultureInfo(nameSecondCulture);
                Console.WriteLine("|{0,-10}|{1,-2}|", cultureInfoFirst.EnglishName, cultureInfoSecond.EnglishName);
                Console.WriteLine(new string('-',50));
                Console.WriteLine("|{0,-25}|{1,-10}|{2,-12}|", "NumberDecimalSeparator", cultureInfoFirst.NumberFormat.NumberDecimalSeparator, cultureInfoSecond.NumberFormat.NumberDecimalSeparator);
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("|{0,-25}|{1,-10}|{2,-12}|", "ShortDatePattern", cultureInfoFirst.DateTimeFormat.ShortDatePattern, cultureInfoSecond.DateTimeFormat.ShortDatePattern);
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("|{0,-25}|{1,-10}|{2,-12}|", "CurrencySymbol", cultureInfoFirst.NumberFormat.CurrencySymbol, cultureInfoSecond.NumberFormat.CurrencySymbol);
                Console.WriteLine(new string('-', 50));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input string first: ");
            String text = Console.ReadLine();
            Console.WriteLine("Input string second: ");
            String text2 = Console.ReadLine();
            CompareCultures(text,text2);
            Console.ReadLine();
        }
    }
}
