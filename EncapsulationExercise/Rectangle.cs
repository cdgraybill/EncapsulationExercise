using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExercise
{
    class Rectangle
    {
        public double Area;

        public double GetArea(int length, int width)
        {
            Area = length * width;

            return Area;
        }
    }
}
