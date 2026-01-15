using System;
namespace Assignment2
{
    public class ConditionalLogic
    {
        public static void Conditional()
        {
            Console.WriteLine("Enter a number1: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number2: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number3: ");
            int num3 = Int32.Parse(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine(num1 + " is the largest number.");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine(num2 + " is the largest number.");
            }
            else
            {
                Console.WriteLine(num3 + " is the largest number.");
            }
        }
    }
}