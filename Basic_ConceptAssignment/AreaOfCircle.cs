using System;
namespace Assignment2
{
    public class AreaOfCircle
    {
        public static void Area()
        {
            Console.WriteLine("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine());

            double area = 3.14 * radius*radius;

            Console.WriteLine("Area of Circle: " + Math.Round(area,2));

        }
    }
}