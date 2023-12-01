using System;
using System.Runtime.CompilerServices;

class Order
{
    public Customer Customer;
    public List<Product> Products;

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }


    public decimal CalculateCost()
    {
        decimal totalCost = Products.Sum(product => product.GetPrice());
        int shippingCost = Customer.InUsa() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string PackingLabel()
    {
        var packingLabel = "";
        foreach (var product in Products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address.GetAddress}";
    }
}