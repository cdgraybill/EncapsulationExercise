using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExercise
{
    abstract class Shape
    {
        public abstract double Area();
    }

    class Circle : Shape
    {
        private readonly double radius;
        public Circle (double r)
        {
            radius = r;
        }
        public override double Area()
        {
            return Math.PI * (radius * 2);
        }
    }

    class Rectangle : Shape
    {
        private readonly double _length;
        private readonly double _width;
        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }
        public override double Area()
        {
            return _length * _width;
        }
    }

    class Square : Shape
    {
        private readonly double _side;
        public Square(double side)
        {
            _side = side;
        }
        public override double Area()
        {
            return Math.Pow(_side, 2);
        }
    }
}
