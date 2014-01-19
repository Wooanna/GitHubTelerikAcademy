using System;
//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method

class HelloNames
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        Console.WriteLine("Hello, {0}!", Name()); 
    }

    static string Name()
    {
        string name = Console.ReadLine();
        return name;
    }
}

