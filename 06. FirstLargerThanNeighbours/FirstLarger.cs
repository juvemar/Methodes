//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Linq;

class FirstLarger
{
    static void Main()
    {
        Console.Write("Enter an array: ");
        int[] numbers = Console.ReadLine()
        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();

        if (IntComparer(numbers) == -1)
        {
            Console.WriteLine("There is no number greater than its neighbours.");
        }
        else
        {
            Console.WriteLine("The first number greater than its neighbours is at position {0}", IntComparer(numbers));
        }
    }

    static int IntComparer(int[] numbers)
    {
        for (int k = 0; k < numbers.Length; k++)
        {
            if (k == numbers.Length - 1)
            {
                if(numbers[k] > numbers[k - 1])
                {
                return k;
                }
            }
            else if (k == 0)
            {
                if(numbers[k] > numbers[k + 1])
                {
                      return k;
                }
            }
            else
                if (numbers[k] > numbers[k + 1] && numbers[k] > numbers[k - 1])
                {
                    return k;
                }
        }
        return -1;
    }
}