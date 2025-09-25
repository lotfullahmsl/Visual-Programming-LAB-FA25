using System;

class Exercise3_7
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\t=== Using 2D Array ===\n");

        string[,] arr2D = {
            { "0", "1.3 miles", "-" },
            { "1", "1.5 miles", "-" },
            { "2", "ComputeCircumference()", "Circu" }
        };

        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            Console.Write("\t");
            for (int j = 0; j < arr2D.GetLength(1); j++)
                Console.Write(arr2D[i, j] + "\t");
            Console.WriteLine("\n");
        }

        Console.WriteLine("\n\t=== Using Jagged Array ===\n");

        string[][] arrJagged = new string[3][];
        arrJagged[0] = new string[] { "0", "1.3 miles", "-" };
        arrJagged[1] = new string[] { "1", "1.5 miles", "-" };
        arrJagged[2] = new string[] { "2", "ComputeCircumference()", "Circu" };

        for (int i = 0; i < arrJagged.Length; i++)
        {
            Console.Write("\t");
            for (int j = 0; j < arrJagged[i].Length; j++)
                Console.Write(arrJagged[i][j] + "\t");
            Console.WriteLine("\n");
        }

        Console.WriteLine("\tPress Enter to exit...");
        Console.ReadLine();
    }
}
