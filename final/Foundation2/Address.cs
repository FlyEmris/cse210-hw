using System;
using System.Security.Cryptography.X509Certificates;

class Address
{
    public string Street;
    public string City;

    public string StateProvince;
    public string Country;

    public bool InUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetAddress()
    {
        return $"{Street}\n{City}, {StateProvince} {Country}";
    }
}