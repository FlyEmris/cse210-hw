using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
    }
}

        //primitive types
        int i;
        string s;
        char c;
        float f;
        double d;
        byte b;

        // Lists - new keyword
        List<int> myInts = new List<int>();
        myInts.Add(2);
        myInts.Add(25);
        MyInts.Remove(1);
        myInts.Insert(1, 35);


        List<string>myStrings = new List<string>();
        myString.Add("hello");


        foreach (var i in myInts)
        {
            Console.WriteLine($"My int = {i}");
        }

