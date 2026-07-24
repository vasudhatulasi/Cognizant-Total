using System;

class Program
{
    // Method accepts any type of object
    static void CheckObject(object obj)
    {
        // Pattern matching using is
        if (obj is int number)
        {
            Console.WriteLine("Integer: " + number);
        }
        else if (obj is string text)
        {
            Console.WriteLine("String: " + text);
        }

        // Switch pattern matching
        switch (obj)
        {
            case int n:
                Console.WriteLine($"Square = {n * n}");
                break;

            case string s:
                Console.WriteLine($"Length = {s.Length}");
                break;

            default:
                Console.WriteLine("Unknown Type");
                break;
        }
    }

    static void Main()
    {
        CheckObject(10);

        CheckObject("Hello");
    }
}
