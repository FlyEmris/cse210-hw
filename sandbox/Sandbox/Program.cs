using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
    }
}
        // while loop
        var count = 0;
        while (true)
        {
            Console.WriteLine("Still Going");
            if (count <= 5)
            {
                break;
            }
            ++count
        }

        //do while
        do
        {
            Console.WriteLine("hit");
            count++;
            Console.WriteLine($"Count = {count++}")
        }
        while (count < 5);
        //for loop
        for (var i = 0; i<5; ++i)
        {
            Console.writeLine($"i = {i}");
        }

        //foreach loop

        var myInts = new int[]{1,2,3,4,5};
        for(var i=0; i<myInts.Length; ++i)
        {
            Console.WriteLine($"i = {i}");
        }
