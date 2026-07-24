using System;

class Program
{
    // Method returning multiple values
    static (int, string) GetStudent()
    {
        return (101, "John");
    }

    static void Main()
    {
        // Deconstruct tuple
        (int id, string name) = GetStudent();

        Console.WriteLine("ID: " + id);

        Console.WriteLine("Name: " + name);
    }
}
