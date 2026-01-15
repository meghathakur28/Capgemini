using System;
namespace Assignment2
{
    public class ArrayString
    {
        public static void SumString()
        {
            Console.WriteLine("Enter the length of the array:");
            int n = Int32.Parse(Console.ReadLine());
            string[] arr = new string[n];
            Console.WriteLine("Enter the String inside the array");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + " string ");
                arr[i] = Console.ReadLine();
            }
            int sum = 0;
            for (int i = 0; i < n; i++) {
                int m;
                if (int.TryParse(arr[i], out m))
                    sum += m;
            }
             Console.WriteLine("The sum is: "+sum);
        }
    }
}