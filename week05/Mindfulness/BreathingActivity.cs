using System;
using System.Threading;

namespace Mindfulness
{
    public class BreathingActivity : Activity

    {
        public BreathingActivity (string name, string description) : base (name, description)
        {
        }
        public void Run ()
        {
            DisplayStartBreathingMessage();

            int breaths = GetDuration();
            int inhaleSeconds = 5;
            int exhaleSeconds = 5;

            int cycleTime = inhaleSeconds + exhaleSeconds;

            Console.WriteLine($"Great! We will do {breaths} cycles of breathing. Each cycle will take {cycleTime} seconds.");
            Console.WriteLine("Each inhale and exhale last 5 seconds. Let's begin!");
            Console.WriteLine("Get ready...");
            ShowSpinner(10);
            Console.Clear();

            for (int i = 0; i < breaths; i++)
            {
                Console.WriteLine($"Breath #{i + 1} of {breaths}:");
                Console.WriteLine("Breath in...");
                ShowCountdown(inhaleSeconds);
                Console.WriteLine("Breath out...");
                ShowCountdown(exhaleSeconds);
                Console.WriteLine();
            }

            DisplayEndBreathingMessage();

            
        }
    }
}
