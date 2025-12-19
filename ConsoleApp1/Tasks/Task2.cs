using System;
namespace ConsoleApp1.Tasks;

class Task2
{
    static void Main(string[] args)
    {
        // Declare and initialize the jagged 2D array
        // Row 0: Even numbers
        // Row 1: Odd numbers
        int[][] numberMatrix = new int[][]
        {
            new int[] { 2, 4, 6, 8, 10 },
            new int[] { 1, 3, 5, 7, 9 }
        };

        Console.WriteLine("The number matrix has been initialized.");

        // Extract digits based on the puzzle clues
        int digit1 = numberMatrix[1][3]; // Row 1, Index 3
        int digit2 = numberMatrix[0][0]; // Row 0, Index 0
        int digit3 = numberMatrix[1][4]; // Row 1, Index 4

        // Combine the digits into a single string (the key/password)
        string finalKey = digit1.ToString() + digit2.ToString() + digit3.ToString();

        // Display the final key
        Console.WriteLine("The password is: " + finalKey);
    }
}
