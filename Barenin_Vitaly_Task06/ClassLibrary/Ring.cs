using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Ring : Round
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
        public Ring(Point point, double radius, double innerRadius)
            : base(point,radius)
        {
            InnerRadius = innerRadius;
        }
        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(point, Radius, InnerRadius);
        }
    }
}
