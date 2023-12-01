using System;

class Customer
{
    public string Name;
    public Address Address;

    public bool InUsa()
    {
        return Address.InUSA();
    }
}