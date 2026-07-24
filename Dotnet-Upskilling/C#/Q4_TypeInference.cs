using System;

class Student
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        // Compiler infers int type
        var number = 10;

        // Compiler infers string type
        var text = "Hello";

        // Compiler infers Student type
        Student s = new();

        s.Name = "John";

        Console.WriteLine(number);
        Console.WriteLine(text);
        Console.WriteLine(s.Name);

        // Print types
        Console.WriteLine(number.GetType());
        Console.WriteLine(text.GetType());
        Console.WriteLine(s.GetType());
    }
}
