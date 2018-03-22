using System;
using DemoApplication;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GeometricProgression : ISeries
    {
        private double firstElement;
        private double denominator;
        private double currentNumber;
        public GeometricProgression(double firstElement, double denominator)
        {
            if (firstElement != 0 && denominator != 0)
            {
                this.firstElement = firstElement;
                this.denominator = denominator;
                currentNumber = firstElement;
            }
            else
            {
                throw new ArgumentException("The tirst element or the denominator are zero!");
            }
        }
        public double GetCurrent()
        {
            return currentNumber;
        }

        public bool MoveNext()
        {
            currentNumber *= denominator;
            return true;
        }

        public void Reset()
        {
            currentNumber = firstElement;
        }
    }
}
