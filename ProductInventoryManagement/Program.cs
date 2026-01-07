using System;
using ProductInventoryManagement;

public class Program
{
    public static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        Product product1 = new Product
        {
            Name = "Laptop",
            Category = "Electronics",
            StockQuantity = 10,
            Price = 999.99m
        };
        Product product2 = new Product
        {
            Name = "Smartphone",
            Category = "Electronics",
            StockQuantity = 20,
            Price = 499.99m
        };
        inventory.addProduct(product1);
        inventory.addProduct(product2);
        decimal totalValue = inventory.CalculateTotalInventoryValue();
        Console.WriteLine($"Total Inventory Value: {totalValue}");
        var electronicsProducts = inventory.retrieveProductByCategory("Electronics");
        Console.WriteLine($"Products in Electronics Category: {electronicsProducts.Count}");
    }
}