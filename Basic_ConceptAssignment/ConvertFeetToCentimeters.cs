using System;
namespace Assignment2
{
    public class ConvertFeetToCentimeters
    {
        public static void Convert()
        {
            Console.WriteLine("Enter the length in feet");
            int feet = Int32.Parse(Console.ReadLine());

            double cm = feet * 30.48;
            Console.WriteLine(feet + " feet in cms = " + cm+ " cm");
        }
    }
}