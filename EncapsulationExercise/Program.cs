using System;
using System.Globalization;

namespace EncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius to find the area of a circle.");

            double userInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Circle c = new Circle(userInput);
            Console.WriteLine($"Area: {c.Area()}");
            Console.ReadLine();

            Console.WriteLine("Enter the length of a side to find the area of a square.");

            userInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Square s = new Square(userInput);
            Console.WriteLine($"Area: {s.Area()}");
            Console.ReadLine();
        }
    }
}
