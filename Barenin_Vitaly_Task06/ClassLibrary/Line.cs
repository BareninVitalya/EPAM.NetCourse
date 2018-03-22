using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibrary
{
   public class Line : Figure
    {
        protected Point pointA;
        protected Point pointB;
        public Line(Point pointA, Point pointB)
        {
            if (pointA.X == pointB.X && pointA.Y == pointB.Y)
            {
                throw new ArgumentException("Line error: this is point!");
            }
            else
            {
                this.pointA = pointA;
                this.pointB = pointB;
            }
        }
        public override void Draw(ICanvas canvas)
        {
            canvas.DrawLine(this.pointA,this.pointB);
        }
    }
}
