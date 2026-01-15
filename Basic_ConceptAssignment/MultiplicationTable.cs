using System;
namespace Assignment2
{
       public class MultiplicationTable
    {
        public static void Table()
        {
            Console.WriteLine("Enter a number which you want the multiplication table for: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number upto u want a table");
            int upto = Int32.Parse(Console.ReadLine());

            for(int i=1;i<=upto;i++)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
            }
        }
    }

}