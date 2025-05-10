using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numbers = -1;
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //While loop to keep asking the user for a number
        while (numbers != 0)
        {
            Console.Write("Enter number: ");
            string userList = Console.ReadLine();
            numbers = int.Parse(userList);
            if (numbers != 0)
            {
                numberList.Add(numbers); //  Only add if it's not 0
            }
        }
        // loop to go through each item in the list 
        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }
     // Calculate and display sum, average, largest and smallest numbers
        int sum = numberList.Sum();
        double average = numberList.Average();
        int max = numberList.Max();
        int min = numberList.Min();

        Console.WriteLine();
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The Largest number is: {max}");
        Console.WriteLine($"The Smallest number is: {min}");   
    }

}