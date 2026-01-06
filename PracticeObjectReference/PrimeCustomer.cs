using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeObjectReference
{
    public  class PrimeCustomer:Customer
    {
        public List<Orders> MyPrimeOrders //WriteOnly
        {
            set
            {
                MyOrders = value;
            }

        }
    }
}
