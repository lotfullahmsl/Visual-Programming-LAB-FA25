using System;

class Exercise3_1
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];
        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nODD\tEVEN");

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
                Console.WriteLine("\t{0}", numbers[i]);
            else
                Console.WriteLine("{0}", numbers[i]);
        }

        Console.ReadLine();
    }
}
