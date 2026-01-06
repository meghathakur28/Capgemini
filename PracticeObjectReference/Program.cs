using System;
using System.Xml.Linq;
namespace PracticeObjectReference
{
    //structs are lightweight objects bcoz its a value type in c sharp
    // dont make a class as a sealed make struct instead of class 
    // struct doesnot support inheritance 
    // u can make a struct as readonly also 
    // public readonly struct Customer1
    struct Customer1 // Value type in C sharp
    {
        int id;
        string name;
        //public int ID { get; set; }
        //public string Name { get; set; }
        public Customer1(int id, string nm)
        {
            this.id = id;
            name = nm;

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //init customer object first
            Customer custObj = null ;
            custObj = new Customer();

            custObj.CustID = 101;
            custObj.Name = "Megha";


            //Init the ShippingAddr
            custObj.ShippingAddress = new Address();
            custObj.ShippingAddress.FlatNo = 1802;
            custObj.ShippingAddress.BuildingName = "Sky Tower";
            custObj.ShippingAddress.Street = "Lane 1";
            custObj.ShippingAddress.Locality = "Wakad";
            custObj.ShippingAddress.City = "Pune";

            //1 Customer - Have - ManyOrders

            PrimeCustomer cust = new PrimeCustomer();
            cust.MyPrimeOrders = new List<Orders>()
            {
                new Orders{ OrderID = 1124, OrderDate  = new DateTime(2001,12,22), Amount = 14000},
                new Orders{OrderID = 1134, OrderDate  = new DateTime(2001,3,28), Amount = 1400},
                new Orders{ OrderID = 2124, OrderDate  = new DateTime(2001,2,11), Amount = 13400},
                new Orders{ OrderID = 1214, OrderDate  = new DateTime(2001,11,2), Amount = 800},
                new Orders{ OrderID = 324, OrderDate  = new DateTime(2001,10,23), Amount = 1500},
                new Orders{ OrderID = 1445, OrderDate  = new DateTime(2001,1,22), Amount = 7654},

            };

            System.Console.WriteLine(custObj.MyOrders[0]);
            


        }
    }
}
