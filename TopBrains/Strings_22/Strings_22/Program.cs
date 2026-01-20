using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Strings_22
{
    public interface IArea
    {
        double Circle(double radius);
        double Rectangle(double width, double height);

        double Triangle(double bases, double height);
    }

    public class Area : IArea
    {
        public double Circle(double radius) => 3.14 * radius * radius;

        public double Rectangle(double width, double height) => width * height;

        public double Triangle(double bases, double height) => 0.5 * bases* height;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            string[] arr = s.Split(' ');

            string type = arr[0];

            Area aObj = new Area();

            if (type.Equals("C"))
            {
                double radius = double.Parse(arr[1]);
                Console.WriteLine("The Area is: " + aObj.Circle(radius));
            }
            else if (type.Equals("R"))
            {
                double width = double.Parse(arr[1]);
                double height = double.Parse(arr[2]);
                Console.WriteLine("The Area is: " + aObj.Rectangle(width, height));
            }
            else if (type.Equals("T"))
            {
                double bases = double.Parse(arr[1]);
                double height = double.Parse(arr[2]);
                Console.WriteLine("Teh Area is: "+ aObj.Triangle(bases, height));
            }
            else
            {
                Console.WriteLine("Invalid string");
            }

        }
    }
}
