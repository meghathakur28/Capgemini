using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegateDemo
{
    //MutiCast Delegate
    public delegate void GreetMsg(string msg); 

    //Unicast Delegate -> should have return type -> parameters also
    public delegate int Calculation(int num1, int num2);
    class Hindi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Suprabhat "+userName);
        }
    }
    class Tamil
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Vanakkam " + userName);
        }
    }
    class Telugu
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Suprabhat " + userName);
        }
    }
    class Marathi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namaskar " + userName);
        }
    }
    public class DelegateDemo
    {
        public static void DelegateDemoMain()
        {
            Tamil tObj = new Tamil();
            GreetMsg GreetInTamil = new GreetMsg(tObj.WelcomeMsg);
            GreetInTamil("Alok");
        }
    }
}
