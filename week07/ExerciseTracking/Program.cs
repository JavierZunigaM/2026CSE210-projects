using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List <Activity> activities = new List<Activity>();
        activities.Add(new Running("03 Nov 2022", 30, 4.8)); // km
        activities.Add(new Cycling("03 Nov 2022", 45, 20.0)); // kph
        activities.Add(new Swimming("03 Nov 2022", 25, 30)); // Laps

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}