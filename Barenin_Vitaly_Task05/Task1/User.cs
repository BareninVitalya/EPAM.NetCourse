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
        private int age;
        private DateTime dateOfBirth;
        Regex regex = new Regex(@"\b[A-ZА-Я][a-zа-я][^0-9\s]\S+\b");
        public string SecondName
        {
            get { return secondName; }
            set {
                if (regex.IsMatch(value))
                {
                    secondName = value;
                }
                else
                {
                    throw new ArgumentException("SecondName error");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (regex.IsMatch(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name error");
                }
            }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (DateTime.Today.Date > value)
                {
                    dateOfBirth = value;
                    age = DateTime.Now.Year - dateOfBirth.Year;
                }
                else
                {
                    throw new ArgumentException("DateOfBirth error");
                }
            }
        }
        public int Age
        {
            get { return age; }
            set { age = DateTime.Now.Year - dateOfBirth.Year; }
        }
        public virtual void GetInformation(User user)
        {
            Console.WriteLine(new string('-', 33));
            Console.WriteLine("|{0,-20}|{1,-10}|", "Name", user.Name);
            Console.WriteLine(new string('-', 33));
            Console.WriteLine("|{0,-20}|{1,-10}|", "Second Name", user.SecondName);
            Console.WriteLine(new string('-', 33));
            Console.WriteLine("|{0,-20}|{1,-10}|", "Date of birth", user.dateOfBirth.Date);
            Console.WriteLine(new string('-', 33));
            Console.WriteLine("|{0,-20}|{1,-10}|", "Age", user.Age);
            Console.WriteLine(new string('-', 33));
        }
        public User(string name, DateTime dateTime, string secondName = null)
        {
            Name = name;
            SecondName = secondName;
            DateOfBirth = dateTime;
        }
    }
}
