using System;

public class Activity
{
    private string _activityName;
    private int _activityTime;

    public Activity(string activityName, int activityTime)
    {
        _activityName = activityName;
        _activityTime = activityTime;
    }
    public void GetName()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
    }
    public void SetName(string activityName)
    {
        _activityName = activityName;
    }
    public int GetTime()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _activityTime = userSeconds;
        return userSeconds;
    }
    public void SetTime(int activityTime)
    {
        _activityTime = activityTime;
    }

}