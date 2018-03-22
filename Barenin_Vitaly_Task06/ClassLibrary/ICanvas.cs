using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface ICanvas
    {
        void DrawRound(Point point, double radius, double innerRadius = 0);
        void DrawLine(Point pointA, Point pointB);
        void DrawRectangle(Point pointA, Point pointB);
    }
}
