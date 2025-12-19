using System;
namespace ConsoleApp1.Tasks;

class Task3
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

        Console.Write("Enter a number to search for: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int searchNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        bool found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchNumber)
            {
                Console.WriteLine($"Number found at position {i}!");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Number not found in the list.");
        }
    }
}
