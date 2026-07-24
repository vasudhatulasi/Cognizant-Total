using System;

class Program
{
    static int CalculateFactorial(int n)
    {
        // Local function
        int Factorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;

            return num * Factorial(num - 1);
        }

        return Factorial(n);
    }

    static void Main()
    {
        int result = CalculateFactorial(5);

        Console.WriteLine("Factorial = " + result);
    }
}
