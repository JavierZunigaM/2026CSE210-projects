using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        String name = PromptUserName();
        int number = PromptUserNumber();

        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }

    //Function 1
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Function 2
    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();
        return name;
    }

    //Function 3
    static int PromptUserNumber()
    {
        Console.Write("Please enter a number: ");
        String input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    //Function 4
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    //Function 5
    static void DisplayResult(String name, int square)
    {
        Console.WriteLine($"{name}, the square of that number is {square}");
    }

}