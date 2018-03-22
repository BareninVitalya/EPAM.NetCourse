using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Point
    {
        public double X
        {
            get;
            private set;
        }
        public double Y
        {
            get;
            private set;
        }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return "( "+X+"; "+Y+" )";
        }
    }
}
