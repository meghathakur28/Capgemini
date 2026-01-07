using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInventoryManagement
{
    public interface IProduct
    {
        string Name { get; set; }
        string Category { get; set; }
        int StockQuantity { get; set; }

        decimal Price { get; set; }
    }
}
