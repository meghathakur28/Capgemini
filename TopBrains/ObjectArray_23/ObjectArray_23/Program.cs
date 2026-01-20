using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArray_23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value n (no of elements in the array: ");
            int n = Int32.Parse(Console.ReadLine());
            Object[] arr = new Object[n];

            for(int i=0;i<n;i++)
            {
                arr[i] = Console.ReadLine();
            }
            int sum = 0;
            foreach (var i in arr)
            {
                string s = i.ToString();
                if(Int32.TryParse(s,out var value))
                {
                    sum += value;
                }
            }

            Console.WriteLine($"The sum is {sum}");


        }
    }
}
