using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        private double radius;
        private double pi = Math.PI;
        public int X
        {
            get;
            private set;
        }
        public int Y
        {
            get;
            private set;
        }
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new AggregateException("Radius error");
                }
            }
        }
        public double Square(Round round)
        {
            return round.pi * Math.Pow(round.radius, 2);
        }
        public Round(int x, int y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public double Length(Round round)
        {
            return round.pi * round.radius * 2;
        }
    }
}
