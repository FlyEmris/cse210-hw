using System;

public class BreathingActivity : Activity
{
    private string _message1 = "Breath in...";
    private string _message2 = "Breath out...";
    private string _description = "This activity will focus on your breathing and allow you to relax.";

    public BreathingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetDescription()
    {
        Console.WriteLine(_description);
    }
}