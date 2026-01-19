using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion_21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the seconds: ");
            int totalSeconds = Int32.Parse(Console.ReadLine());

            int min = totalSeconds / 60;
            int sec = totalSeconds % 60;
            if (sec < 10)
            {
                Console.WriteLine($"The time is: {min}:0{sec}");
                return;
            }
            Console.WriteLine($"The time is: {min}:{sec}");
        }
    }
}
