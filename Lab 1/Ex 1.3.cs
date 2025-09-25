using System;

class Program
{
    static void Main()
    {
        Console.Write("\t\t\t*****Exercise_1.3***** \n");
        Console.Write("\tEnter marks (0-100): ");
        if (!int.TryParse(Console.ReadLine(), out int marks) || marks < 0 || marks > 100)
        {
            Console.WriteLine("\tInvalid marks. Enter an integer between 0 and 100.");
            Console.WriteLine("\tPress Enter to exit...");
            Console.ReadLine();
            return;
        }

        string grade;
        if (marks >= 87) grade = "A";
        else if (marks >= 80) grade = "\tB+";
        else if (marks >= 72) grade = "\tB";
        else if (marks >= 66) grade = "\tC+";
        else if (marks >= 61) grade = "\tC";
        else grade = "F";

        Console.WriteLine($"\tMarks: {marks} -> Grade: {grade}");
        Console.WriteLine("\tPress Enter to exit...");
        Console.ReadLine();
    }
}
