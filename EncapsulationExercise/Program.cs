using System;

namespace EncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            
            Console.WriteLine($"The current area is {r.Area}");

            r.GetArea(4, 7);

            Console.WriteLine($"The current area is {r.Area}");

            Console.WriteLine(r.Area = 0);

            Console.WriteLine($"The current area is {r.Area}");

            Console.ReadLine();
        }
    }
}
