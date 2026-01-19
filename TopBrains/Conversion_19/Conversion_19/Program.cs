using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the height in feet ");
            int foot = Int32.Parse(Console.ReadLine());

            double cm = (double) foot * 30.48;

            Console.WriteLine(Math.Round(cm, 2));


        }
    }
}
