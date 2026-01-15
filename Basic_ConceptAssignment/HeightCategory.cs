using System;
namespace Assignment2
{
    public class HeightCategory
    {
        public static void CheckHeight()
        {
            Console.WriteLine("Enter the value in feet: ");
            int heightCm = Int32.Parse(Console.ReadLine());
            if (heightCm < 150)
            {
                Console.WriteLine("You are in Short height category");
            }
            else if (heightCm >= 150 && heightCm < 180)
            {
                Console.WriteLine("You are in Average height category");
            }
            else
            {
                Console.WriteLine("You are in Tall height category");
            }
        }
    }
}