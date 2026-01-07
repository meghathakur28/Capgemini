using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInventoryManagement
{
    public class Inventory: IInventory
    {
        List<Product> _products;
        public Inventory()
        {
            _products = new List<Product>();
        }

        public void addProduct(Product product)
        {
            if (product != null)
            {
                _products.Add(product);
            }
        }
        public void removeProduct(string name)
        {
            Product product = _products.Find(p => p.Name == name);
            if (product != null)
            {
                _products.Remove(product);
            }

        }

        public decimal CalculateTotalInventoryValue()
        {
            decimal sum = 0;
            foreach(var i in _products)
            {
                sum+= i.Price * i.StockQuantity;
            }
            return sum;
        }

        public List<Product> retrieveProductByCategory(string category)
        {
            List<Product> products = new List<Product>();
            foreach(var i in _products)
            {
                if(i.Category == category)
                {
                    products.Add(i);
                }
            }
            return products;
        }

        public List<Product> retrieveProductByCategoryWithCount(string category, int count)
        {
            List<Product> products = new List<Product>();
            foreach(var i in _products)
            {
                if(category != null)
                {
                    if (i.Category == category && i.StockQuantity == count)
                    {
                        products.Add(i);
                    }
                }
            }
            return products;
        }

        public Product SearchProduct(string name)
        {
            Product product = _products.Find(p => p.Name == name);
            return product;     

        }

        public List<Product> productsByPrice(decimal minPrice, decimal maxPrice)
        {
            List<Product> products = new List<Product>();
            foreach(var i in _products)
            {
                if(i.Price >= minPrice && i.Price <= maxPrice)
                {
                    products.Add(i);
                }
            }
            return products;

        }
    }
}
