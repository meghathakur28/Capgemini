using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInventoryManagement
{
    public interface IInventory
    {
        public void addProduct(Product product);
        public void removeProduct(string name);

        public decimal CalculateTotalInventoryValue();

        public List<Product> retrieveProductByCategory(string category);

        public List<Product> retrieveProductByCategoryWithCount(string category, int count);

        public Product SearchProduct(string name);

        public List<Product> productsByPrice(decimal minPrice, decimal maxPrice);
    }
}
