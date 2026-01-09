using System;
using EventDelegateDemo;

namespace EventDelegateDemo
{
    public delegate bool CreateRecord(Product p);
    public delegate void Caller(string str);
    class Program
    {
        public static void ShowMe(string str)
        {
            Console.WriteLine("Hello from ShowMe " + str);
        }
        public void GenerateBill(string str)
        {
            Console.WriteLine("Hello from GenerateBill " + str);
        }
        static void Main(string[] args)
        {
            //ProductRepo pRepo = new ProductRepo();
            //CreateRecord AddProduct = new CreateRecord(pRepo.Add);

            //AddProduct(new Product(){ ProductID = 101, ProductName = "Laptop"});

            Program p1 = new Program();
            Caller CallMe = new Caller(Program.ShowMe);
            CallMe -= new Caller(p1.GenerateBill);

            CallMe("LPU");
        }
    }
}
