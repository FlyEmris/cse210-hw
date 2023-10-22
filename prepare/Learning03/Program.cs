using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        Fraction w = new Fraction(5);
        Console.WriteLine(w.GetFractionString());
        Console.WriteLine(w.GetDecimalValue());

        Fraction s1 = new Fraction(3, 4);
        Console.WriteLine(s1.GetFractionString());
        Console.WriteLine(s1.GetDecimalValue());

        Fraction s2 = new Fraction(1, 3);
        Console.WriteLine(s2.GetFractionString());
        Console.WriteLine(s2.GetDecimalValue());

        Fraction s3 = new Fraction(37, 23);
        Console.WriteLine(s3.GetFractionString());
        Console.WriteLine(s3.GetDecimalValue());

        Fraction s4 = new Fraction(2543, 231);
        Console.WriteLine(s4.GetFractionString());
        Console.WriteLine(s4.GetDecimalValue());
    }
}
    