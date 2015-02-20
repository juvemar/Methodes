//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;
class SayHello
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Hello(name);
    }

    static void Hello(string name)
    {
        Console.WriteLine("Hello, " + name);
    }
}
