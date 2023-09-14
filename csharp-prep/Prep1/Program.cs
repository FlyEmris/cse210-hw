using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        int myInt = 5;
        Console.WriteLine($"my int = {myInt}");

        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine($"name = {name}");

        if (name == "Jonathan Leonardson")
        {
            Console.WriteLine("Hey that's who I am!");
        }
        else
        {
            Console.WriteLine($"Hi there, {name}");
        }
        Console.Write("What is your First name? ");
        string first = Console.Readline();
        Console.Write("What is your Last name?");
        string last = Console.Readline();
        Console.WriteLine($"Your name is {last}, {first} {last}. ")   
    }
}