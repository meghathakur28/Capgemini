using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInventoryManagement
{
    public class Product:IProduct
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int StockQuantity { get; set; }

        public decimal Price { get; set; }
    }
}
