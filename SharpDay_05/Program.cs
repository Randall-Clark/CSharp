using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Clean Code", "Robert C. Martin", 45.00);
        Book book2 = new Book("The Pragmatic Programmer", "Andrew Hunt", 39.99);
        
        Electronic electronic1 = new Electronic("Headphones", "Sony", 89.99);
        Electronic electronic2 = new Electronic("Smartphone", "Samsung", 699.99);

        Order order = new Order();
        
        order.AddProduct(book1);
        order.AddProduct(book2);
        order.AddProduct(electronic1);
        order.AddProduct(electronic2);
        
        Console.WriteLine("🧾 Facture :");
        Console.WriteLine(order.ToString());
        
        
        double TotalPrice = 0;
        foreach (IProduct product in order.GetProducts())
        {
            TotalPrice += product.GetPrice();
        }
        
        Console.WriteLine($"This is the price you should pay : {TotalPrice}");

    }
}

interface IProduct
{
    String Name { get; set; }

    double GetPrice();
}

class Book : IProduct
{
    public string Name { get; set; }
    public string Author;
    public double Price;
    public Book(String title, String author, double price)
    {
        this.Name = title;
        this.Author = author;
        this.Price = price;
    }

    public override string ToString()
    {
        return String.Format("Book :{0} by {1} - ${2}", this.Name, this.Author, this.Price);
    }

    public double GetPrice()
    {
        return this.Price;
    }
}

class Electronic : IProduct
{
    public string Name { get; set; }
    public string Brand;
    public double Price;

    public Electronic(string name, string brand, double price)
    {
        this.Name = name;
        this.Brand = brand;
        this.Price = price;
    }

    public override string ToString()
    {
        return String.Format("Electronics :{0} - {1} - ${2} ", this.Name, this.Brand, this.Price);
    }

    public double GetPrice()
    {
        return this.Price;
    }
}


class Order
{
    public List<IProduct> Products = new List<IProduct>();

    public void AddProduct(IProduct product)
    {
        this.Products.Add(product);
    }

    public override string ToString()
    {
        return String.Join("\n", this.Products);
    }

    public void PrintInvoice()
    {
        Console.WriteLine(this.Products.ToString());
        Console.WriteLine();
    }

    public List<IProduct> GetProducts()
    {
        return this.Products;
    }
}