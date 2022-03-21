using System;

namespace Operator_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"17/4 is {quotient} remainder {remainder}");

            }
            Console.WriteLine("What is the radius of a circle?");
            var radius = double.Parse(Console.ReadLine());
            double areaOfCircle = Math.PI * radius * radius;

            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}"); 
        }
    }
}


