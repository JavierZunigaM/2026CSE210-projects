using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness

{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>()
        {
            "List as many things as you can that you are grateful for.",
            "List as many personal strengths as you can.",
            "List as many people who have positively influenced your life.",
            "List as many accomplishments you are proud of.",
            "List as many things that bring you joy."
        };
        private List<string> _responses = new List<string>()
        {
            
        };

        public ListingActivity (string name, string description) 
            : base (name, description)
        {
        }
        public void Run ()
        {
            DisplayStartMessage();
            
            Console.WriteLine("Prompt: ");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.WriteLine("Start listing items. Press Enter after each one.");
            Console.WriteLine("You have limited time!");

            int duration = GetDuration();
            DateTime endTime = DateTime.Now.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                _responses.Add(response);
            }

            Console.WriteLine($"You listed {_responses.Count} items.");
            DisplayEndMessage();
            
        }
        private string GetRandomPrompt ()
        {
            Random rand = new Random();
            return _prompts[rand.Next(_prompts.Count)];
        }
       
        
    }
    
}