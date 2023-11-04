using System;

public class Activity
{
    protected string _activityName;
    protected int _activityDuration;
    protected string _activityDescription;
    protected string _finalActivityMessage;


    public Activity(string activityName, string activityDescription, string activityFinalMessage)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _finalActivityMessage = activityFinalMessage;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void SetActivityDuration(int activityDuration)
    {
        _activityDuration = activityDuration;
    }
    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public string GetFinalActivityMessage()
    {
        return _finalActivityMessage;
    }

    public void SetFinalActivityMessage(string finalActivityMessage)
    {
        _finalActivityMessage = finalActivityMessage;
    }
    public string GetActivityNameDisplay()
    {
        return $"Welcome to the {_activityName}.";
    }
    public string GetActivityDescriptionDisplay()
    {
        return $"{_activityDescription}";
    }
    public string GetActivityDurationDisplay()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = "0";
        string result = Console.ReadLine();
        if (!string.IsNullOrEmpty(result))
        {
            duration = result;
        }
        return duration;
    }


    public string GetFinalActivityMessageDisplay()
    {
        Console.WriteLine("Well done.");
        Console.WriteLine();
        Convert.ToString(_activityDuration);
        return $"You have completed another {_activityDuration} seconds of the {_activityName}.";
    }
    public void ShowSpinnerWithText(string text, string position = "left")
    {
        int x = Console.CursorLeft;
        int y = Console.CursorTop;

        string[] spinnerFrames = new string[] { "| ", "/ ", "— ", "\\ " };
        int spinnerIndex = 0;

        while (true)
        {
            Console.SetCursorPosition(x, y);

            if (position == "left")
            {
                Console.Write(spinnerFrames[spinnerIndex] + text);
            }
            else if (position == "right")
            {
                Console.Write(text + " " + spinnerFrames[spinnerIndex]);
            }

            spinnerIndex = (spinnerIndex + 1) % spinnerFrames.Length;

            Thread.Sleep(400);

            if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.SetCursorPosition(x + text.Length, y);
                Console.Write("   ");
                Console.WriteLine();
                break;
            }
        }
    }

}