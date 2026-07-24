using System;

class Car
{
    public string Make;
    public string Model;
    public int Year;

    // Default constructor
    public Car()
    {
        Make = "Unknown";
        Model = "Unknown";
        Year = 0;
    }

    // Parameterized constructor
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Display details
    public void Display()
    {
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
    }
}

class Program
{
    static void Main()
    {
        // Using default constructor
        Car car1 = new Car();

        // Using parameterized constructor
        Car car2 = new Car("Toyota", "Camry", 2024);

        car1.Display();

        Console.WriteLine();

        car2.Display();
    }
}
