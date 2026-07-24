using System;

// Primary constructor
class Person(string name, int age)
{
    // Auto properties initialized from constructor parameters
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    // Display details
    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        // Create object
        Person p = new Person("John", 22);

        // Display details
        p.Display();
    }
}
