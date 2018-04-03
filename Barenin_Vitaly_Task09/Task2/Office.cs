using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Office
    {
        public delegate string Hello(string name, DateTime time);
        public delegate string Goodbye(string name);
        static public event Hello Came;
        static public event Goodbye Left;
        public string CameInOffice(Person person, DateTime time)
        {
            string temp = string.Empty;
            if (Came != null)
            {
                temp = Came(person.Name, time);
            }
            Came += person.Greet;
            Left += person.SayingGoodbye;
            return temp;
        }
        public string LeftFromOffice(Person person)
        {

            string temp = string.Empty;
            Left -= person.SayingGoodbye;
            if (Left != null)
            {
                temp = Left(person.Name);
                Came -= person.Greet;
            }
            return temp;
        }
    }
}
