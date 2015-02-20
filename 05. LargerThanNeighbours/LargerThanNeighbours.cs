//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter an array: ");
        int[] numbers = Console.ReadLine()
        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();
        Console.Write("Enter a position of number to be compared: ");
        int k = int.Parse(Console.ReadLine());

        if (IntComparer(numbers, k) == true)
        {
            Console.WriteLine("The number of position {0} is larger than its neighbours!");
        }
        else Console.WriteLine("The number of position {0} is not larger than its neighbours!");
    }

    static bool IntComparer(int[] numbers, int k)
    {
        bool checker = false;
        if (k == 0 && numbers[k] > numbers[k + 1] 
            || k == numbers.Length - 1 && numbers[k] > numbers[k - 1]
            || numbers[k] > numbers[k + 1] && numbers[k] > numbers[k - 1])
        {
            checker = true;
        }
        return checker;
    }
}