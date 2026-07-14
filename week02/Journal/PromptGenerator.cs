using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string>_dailyPrompts = new List<string>();
    public List<string>_weeklyPrompts = new List<string>(); 
    private Random _random = new Random();
    public PromptGenerator()
    {
        //Daily prompt
        _dailyPrompts.Add("Who was the most interesting person I interacted with today?");
        _dailyPrompts.Add("How did I see the hand of the Lord in my life today?");
        _dailyPrompts.Add("What was the strongest emotion I felt today?");
        _dailyPrompts.Add("If I had one thing i could do over today, what would it be?");
        _dailyPrompts.Add("What is something small that make me smile today?");
        _dailyPrompts.Add("What is one challenge I did face today?");
        _dailyPrompts.Add("What am I greatful for today?");
        _dailyPrompts.Add("What did i learn today?");

        //Weekly review prompts
        _weeklyPrompts.Add("What was my biggest win this week?");
        _weeklyPrompts.Add("What challenged me the most this week?");
        _weeklyPrompts.Add("What am I proud of this week?");
        _weeklyPrompts.Add("What do i want to improve next week?");
        _weeklyPrompts.Add("What patterns did I notice in my emotions or habits?");
    }
    public string GetRandomPrompt()
    {
        //Random prompt return
        int index = _random.Next(_dailyPrompts.Count);
        return _dailyPrompts[index];
    }

    public string GetWeeklyPrompt()
    {
        int index = _random.Next(_weeklyPrompts.Count);
        return _weeklyPrompts[index];
    }
}
