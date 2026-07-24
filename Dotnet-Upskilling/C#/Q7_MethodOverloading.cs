using System;

class Calculator
{
    // Method with two integers
    public int CalculateTotal(int a, int b)
    {
        return a + b;
    }

    // Method with three doubles
    public double CalculateTotal(double a, double b, double c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();

        Console.WriteLine(c.CalculateTotal(10, 20));

        Console.WriteLine(c.CalculateTotal(10.5, 20.5, 30.5));
    }
}
