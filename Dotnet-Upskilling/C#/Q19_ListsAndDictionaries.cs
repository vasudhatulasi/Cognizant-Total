using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List
        List<string> students = new()
        {
            "John",
            "Alice",
            "Bob"
        };

        students.Add("David");
        students.Remove("Bob");

        Console.WriteLine("List:");

        foreach (string s in students)
        {
            Console.WriteLine(s);
        }

        // Dictionary
        Dictionary<int, string> dict = new()
        {
            { 1, "One" },
            { 2, "Two" },
            { 3, "Three" }
        };

        Console.WriteLine("Dictionary:");

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}
