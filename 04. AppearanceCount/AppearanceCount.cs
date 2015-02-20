//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        Console.Write("Enter an array: ");
        int[] numbers = Console.ReadLine()
        .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();
        Console.Write("Enter a number to be counted: ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} appears {1} times in the array.",k,AppCount(numbers,k));
    }
    static int AppCount(int[] numbers, int k)
    {
        int counter = 0;
        foreach (var item in numbers)
        {
            if(item == k)
            {
                counter++;
            }
        }
        return counter;
    }
}