using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Task1
{
    class Program
    {
        static Random random = new Random();
        public static Point RandomPoint()
        {
            return new Point(random.Next(-10, 10), random.Next(-10, 10));
        }
        public static double RandomRadius()
        {
            return random.Next(7,15);
        }
        public static double RandomInnerRadius()
        {
            return random.Next(1, 7);
        }
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[5];
            for (int i=0; i< figures.Length; i++)
            {
                switch (random.Next(4))
                {
                    case 0:
                        figures[i] = new Round(RandomPoint(), RandomRadius());
                        break;
                    case 1:
                        figures[i] = new Ring(RandomPoint(), RandomRadius(), RandomInnerRadius());
                        break;
                    case 2:
                        figures[i] = new Rectangle(RandomPoint(), RandomPoint());
                        break;
                    case 3:
                        figures[i] = new Line(RandomPoint(),RandomPoint());
                        break;
                }
            }
            ConsoleCanvas consoleCanvas = new ConsoleCanvas();
            for (int i=0; i<figures.Length; i++)
            {
                figures[i].Draw(consoleCanvas);
            }
            Console.ReadKey();
        }
    }
}
