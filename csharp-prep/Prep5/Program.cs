using System;

class Program
{
    static void Main(string[] args)
    {
    

    WelcomeMessage();

    string userName = PromptName();
    int userNumber = PromptNumber();
    int squaredNumber = SquareNumber(userNumber);

    Result(userName, squaredNumber);

    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string userName()
    {
        Console.Write("Please enter your name: ")
        string name = Console.ReadLine();

        return name;
    }

    static int userNumber()
    {
        Console.Write("Please enter your number: ")
        int number = Console.ReadLine();

        return  number;
    }

    static int squaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine(${name}, the square of your number is {square});
    }
}

