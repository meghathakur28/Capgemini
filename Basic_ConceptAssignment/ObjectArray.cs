using System;
namespace Assignment2
{
       public class ObjectArray
    {
        public static void MixedArray()
        {
            Console.WriteLine("Enter the length of the array:");
            int n = Int32.Parse(Console.ReadLine());
            object[] arr = new object[n];
            int sum = 0;
            Console.WriteLine("Enter the elements inside the array (can be int or string):");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + " element: ");
                string input = Console.ReadLine();
                arr[i] = input;
                int intValue;
                if (int.TryParse(input, out intValue))
                {
                    sum+= intValue;
                }
            }
            Console.WriteLine("The sum of integer elements is: " + sum);
        }
    }

}