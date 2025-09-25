using System;

class Exercise3_4
{
    static void BubbleSort(int[] arr)
    {
        int temp;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter size of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("\nEnter {0} elements:\n", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0}:\t", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nUnsorted Array:");
        foreach (int x in numbers)
            Console.Write(x + " ");

        BubbleSort(numbers);

        Console.WriteLine("\n\nSorted Array:");
        foreach (int x in numbers)
            Console.Write(x + " ");

        Console.ReadLine();
    }
}
