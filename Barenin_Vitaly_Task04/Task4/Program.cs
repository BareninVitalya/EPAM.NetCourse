using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        private char []characters;
        public char[] Characters
        {
            get { return characters; }
            set { characters = value; }
        }
        public MyString(string str)
        {
            Characters = str.ToCharArray(0,str.Length);
        }
        public override string ToString()
        {
            string temp="";
            for (int i = 0; i < Characters.Length; i++)
            {
                temp+=Characters[i].ToString();
            }
            return (System.String.Format(temp));
        }
        public static MyString operator +(MyString myString, string str)
        {
            string temp=string.Empty;
            int length = str.Length + myString.Characters.Length;
            temp=myString.ToString();
            temp += str;
            myString.Characters = temp.ToCharArray(0, length);
            return myString;
        }
        public static MyString operator -(MyString myString, string str)
        {
            string temp = string.Empty;
            temp = myString.ToString();
            temp=temp.Replace(str,string.Empty);
            myString.Characters = temp.ToCharArray(0, temp.Length);
            return myString;
        }
        public static  bool operator ==(MyString myStringA, MyString myStringB)
        {
            string tempA = string.Empty;
            string tempB = string.Empty;
            tempA = myStringA.ToString();
            tempB = myStringB.ToString();
            if (String.Compare(tempA, tempB) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(MyString myStringA, MyString myStringB)
        {
            string tempA = string.Empty;
            string tempB = string.Empty;
            tempA = myStringA.ToString();
            tempB = myStringB.ToString();
            if (String.Compare(tempA, tempB) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyString myStringA = new MyString("ПРивет");
            MyString myStringB = new MyString("ПРивет");
            if (myStringA==myStringB)
            {
                Console.WriteLine("Строки равны.");
            }
            if (myStringA != myStringB)
            {
                Console.WriteLine("Строки не равны.");
            }
            myStringA += "123";
            Console.WriteLine(myStringA.ToString());
            myStringA -= "12";
            Console.WriteLine(myStringA.ToString());
            Console.ReadKey();
        }
    }
}
