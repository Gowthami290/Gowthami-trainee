using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}

class Pricess
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        // Accept 10 products
        for (int i = 0; i < 10; i++)
        {
            Product p = new Product();
            Console.Write($"Enter Product {i + 1} Id: ");
            p.ProductId = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter Product {i + 1} Name: ");
            p.ProductName = Console.ReadLine();
            Console.Write($"Enter Product {i + 1} Price: ");
            p.Price = Convert.ToDecimal(Console.ReadLine());
            products.Add(p);
        }

        // Sort products by price
        var sortedProducts = products.OrderBy(p => p.Price);

        // Display sorted products
        Console.WriteLine("Sorted Products:");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"Id: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}");
            Console.Read();
        }
    }
}
