using System;
namespace Assignment2
{
    public class SummaryArray
    {
        public static void Summary()
        {
            Console.WriteLine("Enter the number of the number of the element:");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int min  = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + " element:");
                arr[i] = Int32.Parse(Console.ReadLine());
                min = Math.Min(min, arr[i]);
                max = Math.Max(max, arr[i]);
                sum += arr[i];
            }
            avg = sum / n;
            Console.WriteLine("Min: "+min);
            Console.WriteLine("Max: "+max);
            Console.WriteLine("Sum: "+sum);
            Console.WriteLine("Average: "+avg);
        }
    }
}