using System;
namespace Assignment2
{
    public class GCD
    {
        public static int Gcd(int a,int b)
        {
            int rem = a % b;
            if(rem ==0)
            {
                return b;
            }
            return Gcd(b, rem);
        }
        public static void ComputeGCD()
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The GCD of " +num1+ " ans "+num2+" is "+Gcd(num1, num2));


        }
    }
}