using System;

class Program
{
    static void Main()
    {
        Console.Write("\t\t\t ***** Exercise 1.2 *****\n");
        Console.Write("\tEnter a string: ");
        string input = Console.ReadLine() ?? "";

        int vowelCount = 0;
        foreach (char ch in input.ToLower())
        {
            if ("aeiou".IndexOf(ch) >= 0) vowelCount++;
        }

        Console.WriteLine($"\tTotal vowels: {vowelCount}");
        Console.WriteLine("\tPress Enter to exit...");
        Console.ReadLine();
    }
}
