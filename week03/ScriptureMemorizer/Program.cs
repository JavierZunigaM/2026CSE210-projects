using System;

// -----------------------------------------------------------------------------
// CREATIVE FEATURES
// -----------------------------------------------------------------------------
// 1. Added a "library" of scriptures and the program chooses one at random.
// 2. Added a feature to hide only words that are NOT already hidden.
// 3. Added a counter showing how many words remain visible.
// -----------------------------------------------------------------------------

class Program
{
    static void Main(string[] arg)
    {
        Console.Clear();
        Console.WriteLine("Scripture Memorizer\n");

        //Scripture library (CREATIVE FEATURES)
        var scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("John:", 3,16),
                "For God so loved the world that he gave his only begotten Son"
            ),
            new Scripture(
                new Reference("Proverbs:", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"
            )
        };

        Random rnd = new Random();
        Scripture scripture = scriptures[rnd.Next(scriptures.Count)];

       while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }
        }       
    }
    
}