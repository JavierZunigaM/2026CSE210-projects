namespace Mindfulness
{
    public class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        public Activity (string name, string description)
        {
            _name = name;
            _description = description;
            
        
        }

        public void DisplayStartBreathingMessage()
        {
            Console.WriteLine($"Welcome to the {_name} activity.");
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.WriteLine("Enter the amount of times you want to breath in and breath out: ");
            _duration = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        public void DisplayEndBreathingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            ShowSpinner(3);
            Console.WriteLine($"You have completed another {_duration} cycles of the {_name} activity.");
            ShowSpinner(3);
        }

        public void DisplayStartMessage()
        {
            Console.WriteLine($"Welcome to the {_name} activity.");
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.WriteLine("Enter the duration in seconds: ");
            _duration = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        public void DisplayEndMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            ShowSpinner(3);
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
            ShowSpinner(3);
        }
        public void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            
        }
        public void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();    
        }
        public int GetDuration() 
        { 
            return _duration; 
        }

    }
}