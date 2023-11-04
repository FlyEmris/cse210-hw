using System;
using System.Diagnostics;

public class ListingActivity : Activity
{

    private List<string> _goodThingsList = new List<string>();
    private Random _random = new Random();

    public ListingActivity(string activityName, string activityDescription, string activityFinalMessage) : base(activityName, activityDescription, activityFinalMessage) //base() are the propieties from Activity (base/father class)
    {
        _goodThingsList = new List<string>();
        _random = new Random();
    }

    public List<string> GetAllListingPrompts()
    {
        return _goodThingsList;
    }

    public void SetAllReflectionPhasesList(List<string> goodThingsPrompts)
    {
        _goodThingsList = goodThingsPrompts;
    }


    public void AddPhaseToGoodThingsList(string goodThingsPrompts)
    {
        _goodThingsList.Add(goodThingsPrompts);
    }


    public string GetRandomChoosenGoodThingsPrompts()
    {

        int indexOfList = _random.Next(_goodThingsList.Count);
        return _goodThingsList[indexOfList];
    }


    public int GetCooldownListingActivity(int seconds, List<string> listToUsePhrases)
    {
        _goodThingsList = listToUsePhrases;
        int original = seconds;
        DateTime newTime = DateTime.Now.AddSeconds(original);

        Console.WriteLine("Let's start...");
        ShowSpinnerWithText(" Press enter to initiate the activity");

        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine();

        Random rand = new Random();
        Console.WriteLine($"---- {listToUsePhrases[rand.Next(listToUsePhrases.Count)]} ----");
        Console.WriteLine();


        Console.Write("You may begin in: ");
        for (int i = 3; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine();
        List<string> responses = new List<string>();
        while (DateTime.Now <= newTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (string.IsNullOrEmpty(response))
            {
                break;
            }
            responses.Add(response);
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {responses.Count} items!");

        return original;
    }

}