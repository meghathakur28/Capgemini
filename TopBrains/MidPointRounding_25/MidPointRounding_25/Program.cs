using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidPointRounding_25
{
    public class Program
    {
        public static double Area(double radius) => Math.Round(3.14* radius * radius,2);
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            System.Console.WriteLine("The radius is: " + Area(radius));

        }
    }
}
