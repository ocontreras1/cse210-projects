using System;

class Program
{
    static void Main(string[] args)
    {
        //Get user input about their grade
        Console.Write("Please enter your grade percentage: ");
        string userGrade = Console.ReadLine();
        float percent = float.Parse(userGrade);

        //Find if letter is + or -
        //float plus_minus = float.Parse(userGrade) % 10
        //if plus_minus >= 7:
        // sign = '+'
        //else if plus_minus <= 3:
        //sign = '-'
        //else:
        //print()
        string letter = "";
        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }
    
        else if (percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        // Display grade
        //if (letter == 'F') || (letter == 'A')
        //{
          //  Console.WriteLine($"Your letter grade is {letter}");
        //}
        //else
        //{
        //    Console.WriteLine($"Your letter grade is {letter} {sign}");
        //}
        Console.WriteLine($"Your grade letter is {letter} ");
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("I'm sorry, you have not passed the class. Better luck next time.");
        }
    
    }
}