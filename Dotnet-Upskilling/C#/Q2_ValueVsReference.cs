using System;

// Reference type class
class Person
{
    public string Name;
}

class Program
{
    // Value type parameter
    static void ChangeValue(int num)
    {
        // Changes only local copy
        num = 100;
    }

    // Reference type parameter
    static void ChangeReference(Person p)
    {
        // Changes actual object's property
        p.Name = "Alice";
    }

    static void Main()
    {
        // Value type variable
        int number = 10;

        Console.WriteLine("Before: " + number);

        ChangeValue(number);

        Console.WriteLine("After: " + number);

        // Create object
        Person person = new Person();
        person.Name = "John";

        Console.WriteLine("Before: " + person.Name);

        ChangeReference(person);

        Console.WriteLine("After: " + person.Name);
    }
}
