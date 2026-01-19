using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayHeight_7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the height in cms");
            int height = Int32.Parse(Console.ReadLine());

            if(height < 150)
            {
                Console.WriteLine("Short");
            }
            else if(height >= 150&& height<180)
            {
                Console.WriteLine("Average");
            }
            else if(height >=180)
            {
                Console.WriteLine("Tall");
            }
        }
    }
}
