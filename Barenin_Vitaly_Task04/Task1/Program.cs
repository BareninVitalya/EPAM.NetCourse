using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
        private string secondName;
        private string name;
        private string patronymic;
        private string dateOfBirth;
        private int age;
        Regex regex = new Regex(@"\b[A-ZА-Я][a-zа-я][^0-9\s]\S+\b");
        public string SecondName
        {
            get { return secondName; }
            set { if (regex.IsMatch(value)) { secondName = value; } }
        }
        public string Name
        {
            get { return name; }
            set { if (regex.IsMatch(value)){ name = value; } }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { if (regex.IsMatch(value)) { patronymic = value; } }
        }
        public string  DateOfBirth
        {
            get { return dateOfBirth; }
            set { if (DateTime.TryParse(value,out DateTime dateTime) && (DateTime.Today.Year-Age)==dateTime.Year) { dateOfBirth = value; } }
        }
        public int Age
        {
            get { return age; }
            set { if (value>7 && value<100) { age = value; } }
        }
        public void GetInformation(User user)
        {
            Console.WriteLine(new string('-', 33));
            Console.WriteLine("|{0,-20}|{1,-10}|","Name", user.Name);
            Console.WriteLine(new string('-', 33));
            Console.WriteLine("|{0,-20}|{1,-10}|", "Second Name", user.SecondName);
            Console.WriteLine(new string('-', 33));
            Console.WriteLine("|{0,-20}|{1,-10}|", "Date of birth", user.DateOfBirth);
            Console.WriteLine(new string('-', 33));
            Console.WriteLine("|{0,-20}|{1,-10}|", "Age", user.Age);
            Console.WriteLine(new string('-', 33));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Enter Name: ");
            user.Name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            user.Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date Of Birth: ");
            user.DateOfBirth = Console.ReadLine();
            Console.WriteLine("Name:{0} Age: {1} DateOfBirth: {2}", user.Name,user.Age,user.DateOfBirth);
            user.GetInformation(user);
            Console.ReadLine();
        }
    }
}
