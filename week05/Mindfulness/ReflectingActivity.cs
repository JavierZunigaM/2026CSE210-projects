using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>()
        {
            "Think of a time when you helped someone.",
            "Think of a moment you felt truly happy.",
            "Think of a time you overcame a challenge.",
            "What made this moment stand out?"
        };
        private List<string> _questions = new List<string>()
        {
            "Why was this experience meaningful?",
            "What did you learn from it?",
            "How can you apply this lesson today?",
            "What made this moment stand out?"
        };
        public ReflectingActivity(string name, string description) 
            : base(name, description)
        {
        }
        public void Run ()
        {
            DisplayStartMessage();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();

            int duration = GetDuration();
            Console.Clear();

            int questionInterval = 10; // seconds between questions
            int elapsed = 0;
        

            while (elapsed < duration)
            {
                Console.WriteLine (GetRandomQuestion());
                ShowSpinner(questionInterval); 
                elapsed += questionInterval;
            }
            DisplayEndMessage();
        }
        private string GetRandomPrompt ()
        {
            Random rand = new Random();
            return _prompts[rand.Next(_prompts.Count)];
            
        }
        
        private string GetRandomQuestion ()
        {
            Random rand = new Random();
            return _questions[rand.Next(_questions.Count)];
        }
    }
}