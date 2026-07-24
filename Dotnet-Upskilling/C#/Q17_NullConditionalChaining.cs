using System;

class Contact
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
}

class Program
{
    static void Main()
    {
        Contact? contact = null;

        // Safe access
        string name = contact?.Name ?? "Contact Not Found";

        Console.WriteLine(name);
    }
}
