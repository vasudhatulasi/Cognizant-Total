using System;

class Program
{
    // ref parameter
    static void Increase(ref int x)
    {
        x += 10;
    }

    // out parameter
    static void GetValue(out int x)
    {
        x = 50;
    }

    // in parameter
    static void Show(in int x)
    {
        Console.WriteLine(x);
    }

    static void Main()
    {
        int a = 10;

        Console.WriteLine("Before ref: " + a);

        Increase(ref a);

        Console.WriteLine("After ref: " + a);

        int b;

        GetValue(out b);

        Console.WriteLine("Out Value: " + b);

        Show(in a);
    }
}
