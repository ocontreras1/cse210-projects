using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 20);
        int guessNumber = 0;
        do 
        {   
            Console.Write("What is the magic number: ");
            string guess = Console.ReadLine();

            guessNumber = int.Parse(guess);
        
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {   
                Console.WriteLine("You guessed it!");
            }
        } while (guessNumber != magicNumber);
    }   
}