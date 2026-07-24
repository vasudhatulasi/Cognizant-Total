using System;
using System.Threading;

class Program
{
    // Shared variable accessed by multiple threads
    static int counter = 0;

    // Lock object used for synchronization
    static object lockObj = new object();

    static void IncrementWithoutLock()
    {
        for (int i = 0; i < 100000; i++)
        {
            counter++;
        }
    }

    static void IncrementWithLock()
    {
        for (int i = 0; i < 100000; i++)
        {
            lock (lockObj)
            {
                counter++;
            }
        }
    }

    static void Main()
    {
        // Race condition example
        counter = 0;
        Thread t1 = new Thread(IncrementWithoutLock);
        Thread t2 = new Thread(IncrementWithoutLock);
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();

        Console.WriteLine("Without lock: " + counter);

        // Synchronized example
        counter = 0;
        Thread t3 = new Thread(IncrementWithLock);
        Thread t4 = new Thread(IncrementWithLock);
        t3.Start();
        t4.Start();
        t3.Join();
        t4.Join();

        Console.WriteLine("With lock: " + counter);
    }
}
