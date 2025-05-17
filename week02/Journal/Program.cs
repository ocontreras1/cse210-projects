using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 6;

        //Loop to continue showing the menu until user chooses to end the program
        while (userChoice != 0)
        {
            Console.WriteLine("Welcome to your Journal");
            Console.WriteLine("Please make a selection: ");
            Console.WriteLine("1.  Write a new entry");
            Console.WriteLine("2.  Display the journal");
            Console.WriteLine("3.  Save the journal to a file");
            Console.WriteLine("4.  Load the journal from a file");
            Console.WriteLine("0.  Exit the journal");
            string userChoiceString = Console.ReadLine();
            userChoice = int.Parse(userChoiceString);

            // If statement that causes the program to execute each of of the options
            if (userChoice == 1)
            {
                //Generate a prompt, display it, and save the response from the user
                PromptGenerator generator = new PromptGenerator();
                string prompt = generator.GetRandomPrompt();
                Entry entry1 = new Entry();
                entry1._promptText = prompt;
                Console.WriteLine(prompt);
                entry1._entryText = Console.ReadLine();

                //get the date and store as a string
                DateTime theCurrentTime = DateTime.Now;
                entry1._date = theCurrentTime.ToShortDateString();
            }

            else if (userChoice == 2)
            {
                entry1.Display();
            }

            else if (userChoice == 3)
            {
                Console.WriteLine("Choice 3");
            }

            else if (userChoice == 4)
            {
                Console.WriteLine("Choice 4");
            }

            else if (userChoice == 0)
            {
                Console.WriteLine("Thank you for using the journal program.");
            }

            else
            {
                Console.WriteLine("Please enter a valid choice.");
            }

        }
        //Console.WriteLine("Hello World! This is the Journal Project.");
    }
}