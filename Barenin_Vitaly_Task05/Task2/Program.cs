using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring ring = new Ring(5,5,2.0,1.0);
            Console.WriteLine("Square :"+ ring.Square(ring));
            Console.WriteLine("Length :"+ ring.Length(ring));
            Console.ReadKey();
        }
    }
}
