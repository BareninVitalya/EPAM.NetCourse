using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary 
{
    public class Rectangle : Figure
    {
        protected Point pointA;
        protected Point pointB;
        public Rectangle(Point pointA, Point pointB)
        {
            if (pointA.X == pointB.X || pointA.Y == pointB.Y)
            {
                throw new ArgumentException("Rectangle error: this isn't rectangle!");
            }
            else
            {
                this.pointA = pointA;
                this.pointB = pointB;
            }
        }
        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRectangle(this.pointA, this.pointB);
        }
    }
}
