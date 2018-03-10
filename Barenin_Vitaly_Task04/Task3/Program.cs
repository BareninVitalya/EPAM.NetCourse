using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        public double A
        {
            get { return a; }
            set { if(value>0)a = value; }
        }
        public double B
        {
            get { return b; }
            set { if (value > 0) b = value; }
        }
        public double C
        {
            get { return c; }
            set { if (value > 0) { c = value; } }
        }
        public double Square(Triangle triangle)
        {
            double p = triangle.Perimetr(triangle)/2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public Triangle(double a, double b, double c)
        {
            if ((b + c > a) && (a + c > b) && (a + b > c))
            {
                A = a;
                B = b;
                C = c;
            }
        }
        public double Perimetr(Triangle triangle)
        {
            return triangle.a+triangle.b+triangle.c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(2, 2, 2);
            Console.WriteLine("Perimetr: {0}", triangle.Perimetr(triangle));
            Console.WriteLine("Square: {0}", triangle.Square(triangle));
            Console.ReadLine();
        }
    }
}
