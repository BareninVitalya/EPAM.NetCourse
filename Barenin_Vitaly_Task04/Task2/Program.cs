using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        private int x;
        private int y;
        private double radius;
        private double pi = 3.14;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Radius
        {
            get { return radius; }
            set { if (value > 0) { radius = value; } }
        }
        public double Square(Round round)
        {
            return round.pi * Math.Pow(round.radius,2);
        }
        public Round(int x,int y,double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public double Length(Round round)
        {
            return round.pi * round.radius*2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Round round = new Round(5,5,25);
            Console.WriteLine("Square of round: {0}",round.Square(round));
            Console.WriteLine("Length of round: {0}",round.Length(round));
            Console.ReadLine();
        }
    }
}
