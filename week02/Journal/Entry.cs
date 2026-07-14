using System;
using System.Collections.Generic;
using System.Text.Json;
public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _mood;
    public string _location;
    public List<string> _tags = new List<string>();

    public void Display()
    {
        //Show entry details
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Location: {_location}");
        Console.WriteLine($"Tags: {string.Join(", ",_tags)}");
        Console.WriteLine();
    }
    
    //Convert entry to JSON
    public string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }

    //Convert JSON back to Entry
    public static Entry FromJson(string json)
    {
        return JsonSerializer.Deserialize<Entry>(json);
    }
}