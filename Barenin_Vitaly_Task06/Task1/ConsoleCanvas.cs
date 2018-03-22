using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Task1
{
    class ConsoleCanvas  : ICanvas
    {
        public void DrawRound(Point point, double radius, double innerRadius=0)
        {
            if (innerRadius == 0)
            {
                Console.WriteLine("This is round with parameters: O = {0}; Radius ={1} ", point, radius);
            }
            else
            {
                Console.WriteLine("This is ring with parameters: O = {0}; Radius ={1}; InnerRadius ={2};", point, radius,innerRadius);
            }
        }
        public void DrawLine(Point pointA, Point pointB)
        {
            Console.WriteLine("This is line with parameters: point A ={0}; point B ={1};",pointA, pointB);
        }
        public void DrawRectangle(Point pointA, Point pointB)
        {
            Console.WriteLine("This is rectangle with parameters: point A ={0}; point B = ( {1}; {2} ); point C ={3}; point D = ( {4}; {5} );", pointA, pointA.X,pointB.Y, pointB, pointB.X, pointA.Y);
        }
    }
}
