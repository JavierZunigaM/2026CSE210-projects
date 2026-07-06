using System;

class Program
{
    static void Main(string[] args)
    {
        
        //percentage
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        //Letter grade
        string letterGrade = "";
        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        // Determine + or -
        string sign = "";

        int lastDigit = percentage % 10;

        if ( lastDigit >= 7)
        { 
            sign = "+";
        }
        else if ( lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        
        // Exceptions: A+, F+, F-
        if ( letterGrade == "A" && sign == "+")
        {
            sign = "";
        }
        if ( letterGrade == "F")
        {
            sign = "";
        }
            
        //Print grade
        Console.WriteLine($"Your grade is: {letterGrade}");

        //Pass/fail message
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Keep trying, you can do it next time!");
        }
    }
}