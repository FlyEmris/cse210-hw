using System;

class Program
{
    static void Main()
    {
        var addressUSA = new Address {Street = "Over the Rainbow", City= "Somewhere in Kansas", StateProvince= "KS", Country = "USA"};
        var customerUSA = new Customer {Name = "Dorothy Gale", Address = addressUSA};

        var addressInternational = new Address {Street = "23 Baggins Lane", City = "Bag End", StateProvince = "Shire", Country = "Middle Earth"};
        var customerInternational = new Customer {Name = "Frodo Baggins", Address = addressInternational};

        var product1 = new Product { Name = "Ruby Slippers", ProductId = 1, Price = 10, Quantity = 2 };
        var product2 = new Product { Name = "Dog Toto", ProductId = 2, Price = 15, Quantity = 1 };
        var product3 = new Product { Name = "The one Ring", ProductId = 3, Price = 10, Quantity = 2 };
        var product4 = new Product { Name = "Sting", ProductId = 4, Price = 15, Quantity = 1 };


        var order1 = new Order { Customer = customerUSA };
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order { Customer = customerInternational };
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine($"Order 1 Total Cost: ${order1.CalculateCost()}");
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());

        Console.WriteLine($"\nOrder 2 Total Cost: ${order2.CalculateCost()}");
        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());

    }
}
