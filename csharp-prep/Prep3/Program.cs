using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
    }
}

    //Get random number
    Console.WriteLine("Give me a random number: ");
    string randomNumberString = Console.ReadLine();
    int randomNumber = int.Parse(randomNumberString);

    //Ask for user guess
    Console.Write("Guess the number: ");
    string guessNumberString = Console.ReadLine();


    //Check if guess is higher
    if (guessNumber > randomNumber)
    {
        Console.WriteLine("You guessed too high");
    }
    //Check if its to low
    if (guessNumber < randomNumber)
    {
        Console.WriteLine("You guessed too low");
    }
    //check if guess is a match
    if (guessNumber = randomNumber)
    {
        Console.WriteLine("You guessed right!");
    }