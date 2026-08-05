using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity(
                        "Breathing",
                        "This activity will help you relax by guiding you through slow breathing."
                    );
                    breathing.Run();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity(
                        "Reflecting",
                        "This activity will help you reflect on meaningful moments."
                    );
                    reflecting.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity(
                        "Listing",
                        "This activity will help you focus by listing positive things."
                    );
                    listing.Run();
                    break;

                case "4":
                    
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    Console.WriteLine("Remember to take a moment for yourself today.");
                    Console.WriteLine("Have a great day!");
    
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}