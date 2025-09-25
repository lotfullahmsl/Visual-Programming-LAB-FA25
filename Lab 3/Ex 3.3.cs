using System;

class Exercise3_3
{
    static string Highest(string[] names, int[] marks)
    {
        int maxIndex = 0;
        for (int i = 1; i < marks.Length; i++)
        {
            if (marks[i] > marks[maxIndex])
                maxIndex = i;
        }
        return names[maxIndex];
    }

    static string Lowest(string[] names, int[] marks)
    {
        int minIndex = 0;
        for (int i = 1; i < marks.Length; i++)
        {
            if (marks[i] < marks[minIndex])
                minIndex = i;
        }
        return names[minIndex];
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        string[] names = new string[n];
        string[] enroll = new string[n];
        int[] marks = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("\nEnter Name: ");
            names[i] = Console.ReadLine();
            Console.Write("Enter Enrollment No: ");
            enroll[i] = Console.ReadLine();
            Console.Write("Enter Marks: ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nHighest marks: " + Highest(names, marks));
        Console.WriteLine("Lowest marks: " + Lowest(names, marks));

        Console.ReadLine();
    }
}
