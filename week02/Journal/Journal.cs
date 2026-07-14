using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry>_entries = new List<Entry>();
    
    public void AddEntry(Entry entry)
    {
        //Add Entry
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
     //Show All Entries
     if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the Journal yet.");
            return;
        }   
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        //Save the file
        string json = JsonSerializer.Serialize(_entries);
        string basePath = @"C:\Users\jzm20\OneDrive\Documents\BYU\26-CSE210 - Programming with clases\2026CSE210-projects\week02\Journal\Journal Entries";
        
        // Ensure the folder exists
        Directory.CreateDirectory(basePath);

        // Combine folder + filename
        string fullPath = Path.Combine(basePath, filename);

        // Save JSON
        File.WriteAllText(fullPath, json);

        Console.WriteLine($"Journal saved to: {fullPath}");
        Console.WriteLine("Journal saved a JSON :)");
    }
    public void LoadFromFile(string filename)
    {
        string basePath = @"C:\Users\jzm20\OneDrive\Documents\BYU\26-CSE210 - Programming with clases\2026CSE210-projects\week02\Journal\Journal Entries";

        string fullPath = Path.Combine(basePath, filename);
        
        //Load from File
        
        if (!File.Exists(fullPath))
        {
            Console.WriteLine("File not found :( ");
            return;
        }

        string json = File.ReadAllText(fullPath);
        _entries = JsonSerializer.Deserialize<List<Entry>>(json);

        Console.WriteLine($"Journal loaded from: {fullPath}");
       
        Console.WriteLine($"Journal loaded from: {fullPath}");    
        Console.WriteLine("Journal Loaded from JSON :)!");
    }
}
