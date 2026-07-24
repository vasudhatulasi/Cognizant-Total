using System;

class Student
{
    // Must be initialized
    public required string Name { get; set; }
    public required int RollNo { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student
        {
            Name = "John",
            RollNo = 101
        };

        Console.WriteLine($"{s.Name} {s.RollNo}");

        // If Name or RollNo is omitted,
        // compiler generates an error
    }
}
