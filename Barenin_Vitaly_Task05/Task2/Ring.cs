using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ring : Round
    {
        private double innerRadius;
        public double InnerRadius
        {
            get { return innerRadius; }
            set
            {
                if (value < Radius && value > 0)
                {
                    innerRadius = value;
                }
                else
                {
                    throw new ArgumentException("InnerRadius error");
                }
            }
        }
        public double Square(Ring ring)
        {
            Round round = ring;
            return Square(round) - Math.PI * Math.Pow(ring.InnerRadius, 2);
        }
        public double Length(Ring ring)
        {
            Round round = ring;
            return Length(round) + (Math.PI * ring.InnerRadius * 2);
        }
        public Ring(int x, int y, double radius, double innerRadius)
            : base(x,y,radius)
        {
            InnerRadius = innerRadius;
        }
    }
}
