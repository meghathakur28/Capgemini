using System;
namespace Assignment2
{
    public class PostiveNumberSum
    {
        public static void SumPositiveNumbers()
        {
            Console.WriteLine("Enter the length of the array:");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number " + (i + 1) + ": ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("The sum of positive numbers is: " + sum);
        }
    }
}