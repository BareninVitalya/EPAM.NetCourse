using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibrary
{
    public class Round : Figure
    {
        private double radius;
        protected Point point;
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
                    throw new ArgumentException("Radius error");
                }
            }
        }
        public Round(Point point, double radius)
        {
            this.point = point;
            Radius = radius;
        }
        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(point,Radius);
        }
    }
}
