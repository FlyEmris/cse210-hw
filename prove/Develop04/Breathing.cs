using System;

public class BreathingActivity : Activity
{
    private DateTime _downTime;

    public BreathingActivity(string activityName, string activityDescription, string activityFinalMessage) : base(activityName, activityDescription, activityFinalMessage)
    {
        DateTime startTime = DateTime.Now;
        _downTime = startTime.AddSeconds(0);
    }

    public BreathingActivity(string activityName, string activityDescription, string activityFinalMessage, int downTimeActivity) : base(activityName, activityDescription, activityFinalMessage)
    {
        String cooldownTimeString = downTimeActivity.ToString().PadRight(3, '0');
        DateTime startTime = DateTime.Now;
        _downTime = startTime.AddSeconds(int.Parse(cooldownTimeString));   
    }
    public DateTime GetCooldown()
    {
        return _downTime;
    }

    public void SetTitle(DateTime setCooldown)
    {
        string cooldownTimeString = setCooldown.ToString().PadRight(3, '0');
        DateTime startTime = DateTime.Now;
        _downTime = startTime.AddSeconds(int.Parse(cooldownTimeString));
    }

    public int GetCooldownBreathActivity(int seconds)
    {
        Console.WriteLine("Let's start...");
        ShowSpinnerWithText(" Press enter to initiate the activity");

        const int breatheInDuration = 6;
        const int breatheOutDuration = 3;

        int remainingSeconds = seconds;
        bool isBreathingIn = true;
        while (remainingSeconds > 0)
        {
            Console.Clear();

            int countdown = isBreathingIn ? breatheInDuration : breatheOutDuration;
            string message = isBreathingIn ? "Breathe in..." : "Now breathe out...";

            while (countdown > 0 && remainingSeconds > 0)
            {
                Console.Clear();
                Console.WriteLine($"{message}{countdown}");

                Thread.Sleep(1000);

                countdown--;
                remainingSeconds--;
            }

            isBreathingIn = !isBreathingIn;
        }

        return seconds;
    }
}