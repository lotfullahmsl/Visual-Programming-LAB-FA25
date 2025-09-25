using System;

class Exercise3_2
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string st = Console.ReadLine();
        string temp = "";

        for (int i = st.Length - 1; i >= 0; i--)
        {
            temp += st[i];
        }

        if (st.ToLower() == temp.ToLower())
            Console.WriteLine("The string is a Palindrome.");
        else
            Console.WriteLine("The string is NOT a Palindrome.");

        Console.ReadLine();
    }
}
