using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment701
{
    public abstract class Transaction
    {
        public abstract int ID { get; set; }
        public abstract DateTime Date { get; set; }
        public abstract decimal Amount { get; set; }
        public abstract string Description { get; set; }

    }
}
