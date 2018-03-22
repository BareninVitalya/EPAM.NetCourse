using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApplication;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricProgression geometricProgression = new GeometricProgression(1,2);
            InterfacesDemo.PrintSeries(geometricProgression);
            Console.ReadLine();
        }
    }
}
