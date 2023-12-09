using System;

class Program
{
    static void Main()
    {
        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        Cycling cyclingActivity = new Cycling("03 Nov 2022", 30, 18.6);
        Swimming swimmingActivity = new Swimming("03 Nov 2022", 30, 20);

        List<Activity> activitiesList = new List<Activity>
        {
            runningActivity,
            cyclingActivity,
            swimmingActivity
        };

        foreach (var activity in activitiesList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}