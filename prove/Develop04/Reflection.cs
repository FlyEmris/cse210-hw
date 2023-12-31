using System;
using System.Diagnostics;

public class ReflectionActivity : Activity
{

    private List<string> _listOfPhrases = new List<string>();
    private Random _random = new Random();


    public ReflectionActivity(string activityName, string activityDescription, string activityFinalMessage) : base(activityName, activityDescription, activityFinalMessage) //base() are the propieties from Activity (base/father class)
    {
        _listOfPhrases = new List<string>();
        _random = new Random();
    }


    public List<string> GetAllReflectionPhases()
    {
        return _listOfPhrases;
    }

    public void SetAllReflectionPhasesList(List<string> phase)
    {
        _listOfPhrases = phase;
    }


    public void AddPhaseToList(string phase)
    {
        _listOfPhrases.Add(phase);
    }

    public string GetRandomChoosenPhrase()
    {

        int indexOfList = _random.Next(_listOfPhrases.Count);
        return _listOfPhrases[indexOfList];
    }



    public int GetCooldownReflectionActivity(int seconds, List<string> listToUsePhrases, List<string> listaToUseQuestions)
    {
        _listOfPhrases = listToUsePhrases;
        int original = seconds;
        int copy = original;
        DateTime newTime = DateTime.Now.AddSeconds(copy);

        int remaining = seconds;
        string message = "You may begin in: ";

        Console.WriteLine("Let's start...");
        ShowSpinnerWithText(" Press enter to initiate the activity");
        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();


        Random rand = new Random();
        int index = rand.Next(0, listToUsePhrases.Count);
        Console.WriteLine($"---- {listToUsePhrases[index]} ----");


        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press 'Enter' to continue.");
        Console.Write("");
        string enterKey = Console.ReadLine();


        if (enterKey == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            
            while (DateTime.Now <= newTime){


            for (int i = 3; i > 0; i--)
            {
                
                Console.SetCursorPosition(x, y);

                Console.Write($"\r{message}" + i);
                Thread.Sleep(1000);
            }

            Console.Clear();
        

            for (int i = 0; i < listaToUseQuestions.Count; i++)
            {
                ShowSpinnerWithText(listaToUseQuestions[i], "right");
                Console.WriteLine();
                
 
                if (DateTime.Now >= newTime){
                    break;
                }
            }
            }
            

        }

        return original;
    }

}