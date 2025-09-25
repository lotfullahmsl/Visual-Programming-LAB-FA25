using System;

class Exercise3_5
{
    static void AddArray(int[] arr1, int[] arr2)
    {
        int[] sum = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            sum[i] = arr1[i] + arr2[i];
        }

        Console.WriteLine("\n\tResulting Array:");
        Console.Write("\t");
        foreach (int x in sum)
            Console.Write(x + "\t");
        Console.WriteLine("\n");
    }

    static void Main(string[] args)
    {
        Console.Write("\n\tEnter size of arrays: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        Console.WriteLine("\n\tEnter elements of Array 1:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("\tElement " + (i + 1) + ": ");
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n\tEnter elements of Array 2:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("\tElement " + (i + 1) + ": ");
            arr2[i] = int.Parse(Console.ReadLine());
        }

        AddArray(arr1, arr2);

        Console.WriteLine("\tPress Enter to exit...");
        Console.ReadLine();
    }
}
