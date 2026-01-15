using System;
namespace Assignment2
{
    public class SecToMin
    {
        public static void ConvertSecToMin()
        {
            Console.WriteLine("Enter the number of seconds:");
            int seconds = Int32.Parse(Console.ReadLine());
            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;
            Console.WriteLine(seconds + " seconds is equal to " + minutes + " : " + remainingSeconds);
        }
    }
}