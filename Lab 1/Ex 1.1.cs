
using System;

class Program
{
    static void Main()
    {
        Console.Write("\t\t\t *****Excercise 1.1***** \n");
        Console.Write("\tEnter a non-negative integer: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int n) || n < 0)
        {
            Console.WriteLine("\tInvalid input — please enter a non-negative integer.");
            Console.WriteLine("\tPress Enter to exit...");
            Console.ReadLine();
            return;
        }

        long factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"\tFactorial of {n} is {factorial}");
        Console.WriteLine("\tPress Enter to exit...");
        Console.ReadLine();
    }
}
