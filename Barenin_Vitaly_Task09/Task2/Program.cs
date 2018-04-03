using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public delegate void Messege(string name);
        static void Main(string[] args)
        {
            Messege messege = new Messege(ConsoleMessege);
            Person person = new Person("Jone");
            person.CameInOffice(new DateTime(2018, 4, 2, 11, 30, 0));
            Person person2 = new Person("Nina");
            person2.CameInOffice(new DateTime(2018, 4, 2, 11, 58, 0));
            Person person3 = new Person("Ivan");
            person3.CameInOffice(DateTime.Now);
            person.LeftFromOffice();
            Person person4 = new Person("Alex");
            person4.CameInOffice(DateTime.Now);
            person2.LeftFromOffice();
            person3.LeftFromOffice();
            person.CameInOffice(DateTime.Now);
            Console.ReadKey();
        }
        static public void ConsoleMessege(string messege)
        {
            Console.WriteLine(messege);
        }
    }
}
