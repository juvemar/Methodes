//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Linq;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("1. Reverse the digits of a number.");
        Console.WriteLine("2. Calculate the average of a sequence of integers.");
        Console.WriteLine("3. Solve a linear equation a * x + b = 0");
        Console.WriteLine(@"Enter the number equivalent to the action you want to be done:");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1: Console.WriteLine(string.Join(" ", ReverseDigits())); break;
            case 2: Console.WriteLine(CalculateAvarage()); break;
            case 3: Console.WriteLine(SolveEquation()); break;
            default: Console.WriteLine("Invalid input"); break;
        }
    }

    static int ReverseDigits()
    {
        int num = 0;
        do
        {
            Console.Write("Enter a non-negative decimal number: ");
            num = int.Parse(Console.ReadLine());
        } while (num < 0);

        int left = num;
        int rev = 0;
        int r = 0;
        while (left > 0)
        {
            r = left % 10;
            rev = rev * 10 + r;
            left = left / 10;  //left = Math.floor(left / 10); 
        } 
        Console.Write("Reversed, the number is ");
        return rev;
    }

    static double CalculateAvarage()
    {
        Console.Write("Enter length of the sequence(at least 1): ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        do
        {
            Console.Write("Enter a sequence of integers: ");
            numbers = Console.ReadLine()
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();
        } while (numbers[0] == 0);
        double avarage = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            avarage += (double)numbers[i];
        }
        avarage /= numbers.Length;
        Console.Write("The avarage number of the sequence is ");
        return avarage;
    }

    static double SolveEquation()
    {
        double a = 0;
        double b = 0;
        do
        {
            Console.Write(@"Enter ""a"": ");
            a = double.Parse(Console.ReadLine());
            Console.Write(@"Enter ""b"": ");
            b = double.Parse(Console.ReadLine());
        } while (a == 0);
        double x = 0;
        x = -(b / a);
        Console.Write("The result of the equation is ");
        return x;
    }
}