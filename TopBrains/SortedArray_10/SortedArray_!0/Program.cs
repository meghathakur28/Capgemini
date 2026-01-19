using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedArray__0
{
    public class Program
    {
        // Fix: Add generic type parameter <T> to the Merge method and constrain T to IComparable<T>
        public static T[] Merge<T>(T[] a, T[] b) where T : IComparable<T>
        {
            int n1 = a.Length;
            int n2 = b.Length;

            T[] result = new T[n1 + n2];
            for(int i=0;i<n1;i++)
            {
                result[i] = a[i];
            }
            for(int i=0;i<n2;i++)
            {
                result[n1 + i] = b[i];
            }

            Array.Sort(result);
            return result;

        }
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9 };

            int[] ans = Merge(a, b);
            Console.WriteLine("Merged Array: ");
            for(int i=0;i<ans.Length;i++)
            {
                Console.Write(ans[i] + " ");
            }
        }
    }
}
