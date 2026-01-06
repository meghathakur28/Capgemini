using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeObjectReference
{
    public  class Customer
    {
        List<Orders> orderList= null;
        public Customer()
        {
            orderList = new List<Orders>();
        }
            public int CustID { get; set; }
            public string Name { get; set; }
            public Address BillingAddress { get; set; }
            public Address ShippingAddress { get; set; }
             
            public List<Orders> MyOrders
        {
            get
            {
                return orderList;
            }
            protected set
            {
                orderList = value;
            }
        }

    }
}
