using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExercise
{
    class Square
    {
        private static double Area;

        public static double GetArea(int side)
        {
            Area = side * side;

            return Area;
        }
    }
}
