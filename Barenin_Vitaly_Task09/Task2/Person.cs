using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Person
    {
        public delegate string Hello(string name, DateTime time);
        public delegate string Goodbye(string name);
        static public event Hello Came;
        static public event Goodbye Left;
        public string Name { get; set; }
        public string Greet(string name, DateTime time)
        {
            string temp = string.Empty;
            if (time.TimeOfDay.Hours < 12)
            {
                temp = "Good morning";
            }
            if (time.TimeOfDay.Hours >= 12 && time.TimeOfDay.Hours < 17)
            {
                temp = "Good afternoon";
            }
            if (time.TimeOfDay.Hours >= 17)
            {
                temp = "Good evening";
            }
            Console.WriteLine($"{temp}, {name}!, {Name} said.");
            return $"{temp}, {name}!, {Name} said.";
        }
        public string SayingGoodbye(string name)
        {
            Console.WriteLine($"'Goodbye, {name}!' - {Name} said.");
            return $"'Goodbye, {name}!' - {Name} said.";
        }
        public Person(string name)
        {
            Name = name;
        }
         public void LeftFromOffice()
        {
            Office office = new Office();
            office.LeftFromOffice(this);
        }
        public void CameInOffice(DateTime time)
        {
            Office office = new Office();
            office.CameInOffice(this, time);
        }
    }
}
