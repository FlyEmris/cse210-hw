using System;

class Product
{
    public string Name;
    public int ProductId;
    public decimal Price;
    public int Quantity;

    public decimal GetPrice()
    {
        return Price * Quantity;
    }
}