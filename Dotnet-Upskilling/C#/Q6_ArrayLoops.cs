using System;

class Program
{
    static void Main()
    {
        // Integer array
        int[] numbers = { 10, 20, 30, 40, 50 };

        // FOR LOOP
        Console.WriteLine("For Loop");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine();

        // FOREACH LOOP
        Console.WriteLine("Foreach Loop");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        // WHILE LOOP
        Console.WriteLine("While Loop");
        int index = 0;
        while (index < numbers.Length)
        {
            Console.WriteLine(numbers[index]);
            index++;
        }

        Console.WriteLine();

        // DO-WHILE LOOP
        Console.WriteLine("Do-While Loop");
        index = 0;
        do
        {
            Console.WriteLine(numbers[index]);
            index++;
        } while (index < numbers.Length);
    }
}
