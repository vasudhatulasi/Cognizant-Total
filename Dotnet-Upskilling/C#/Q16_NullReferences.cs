using System;

class Person
{
    public string? Name { get; set; }
}

class Program
{
    static void Main()
    {
        Person? p = null;

        // Null conditional operator
        Console.WriteLine(p?.Name);

        // Null coalescing operator
        string result = p?.Name ?? "No Name";

        Console.WriteLine(result);
    }
}
