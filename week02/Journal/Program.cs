using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Main program logic
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu: ");
            Console.WriteLine("1. Write a daily entry");
            Console.WriteLine("2. Write a weekly review");
            Console.WriteLine("3. Display journal");
            Console.WriteLine("4. Save journal (JSON)");
            Console.WriteLine("5. Load journal (JSON)");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    WriteEntry(journal, prompts.GetRandomPrompt());
                    break;

                case "2":
                    WriteEntry(journal, prompts.GetWeeklyPrompt());
                    break;
                
                case "3":
                    journal.DisplayAll();
                    break;
                
                case "4":
                    Console.Write("Filename: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                
                case "5":
                    Console.Write("Filename: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;

                case "6":
                    running = false;
                    break;

                default: 
                    Console.WriteLine("Invalid option.");
                    break;
            }
            Console.WriteLine();
        }        
    }
    static void WriteEntry(Journal journal, string prompt)
    {
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Console.Write("Mood: ");
        string mood = Console.ReadLine();

        Console.Write("Location: ");
        string location = Console.ReadLine();

        Console.Write("Tags (comma separated): ");
        string tagInput = Console.ReadLine();
        var tags = new List<string>(tagInput.Split(',',StringSplitOptions.RemoveEmptyEntries));

        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();
        entry._prompt = prompt;
        entry._response = response;
        entry._mood = mood;
        entry._location = location; 
        entry._tags = tags;

        journal.AddEntry(entry);

        Console.WriteLine("Entry added.");
    }
}