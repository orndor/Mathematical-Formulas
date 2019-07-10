using System;

namespace progex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            // Implementation for area here
            double area = Math.PI * (Math.Pow(intradius, 2));
            Console.WriteLine($"The area is {area}");



            // Part 2

            // Implementation here
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            double volume = ((4 / 3) * Math.PI * (Math.Pow(intradius, 3))) / 2;
            Console.WriteLine($"The volume is {volume}");


            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

            // Implementation here
            Console.Write("Enter an integer for side 1 of the triangle: ");
            string strside1 = Console.ReadLine();
            int intside1 = int.Parse(strside1);
            Console.Write("Enter an integer for side 2 of the triangle: ");
            string strside2 = Console.ReadLine();
            int intside2 = int.Parse(strside2);
            Console.Write("Enter an integer for side 3 of the triangle: ");
            string strside3 = Console.ReadLine();
            int intside3 = int.Parse(strside3);
            double intperimeter = (intside1 + intside2 + intside3) / 2.0;
            area = Math.Sqrt(intperimeter * (intperimeter - intside1) * (intperimeter - intside2) * (intperimeter - intside3));
            Console.WriteLine($"The area triangle is {area}");


            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");

            // Implementation here

            Console.WriteLine($"The positive solution is {positive_num / denominator}");
            Console.WriteLine($"The negative solution is {negative_num / denominator}");
        }
    }
}
