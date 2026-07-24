using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        // Create object
        User user = new User()
        {
            Name = "John",
            Age = 22,
            Email = "john@gmail.com"
        };

        // Convert object to JSON
        string json = JsonSerializer.Serialize(user);

        // Save JSON to file
        File.WriteAllText("user.json", json);

        Console.WriteLine("JSON Saved");

        // Read JSON file
        string readJson = File.ReadAllText("user.json");

        // Convert JSON back to object
        User data = JsonSerializer.Deserialize<User>(readJson);

        Console.WriteLine(data.Name);
        Console.WriteLine(data.Age);
        Console.WriteLine(data.Email);
    }
}
