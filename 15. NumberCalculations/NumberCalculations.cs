//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Numbers: 23, 3.4, 6.5");

        Console.WriteLine("Minimum is {0}.", Minimum(23, 3.4, 6.5));
        Console.WriteLine("Maximum is {0}.", Maximum(23, 3.4, 6.5));
        Console.WriteLine("Avarage is {0}.", Avarage(23, 3.4, 6.5));
        Console.WriteLine("Sum is {0}.", Sum(23, 3.4, 6.5));
        Console.WriteLine("Product is {0}.", Product(23, 3.4, 6.5));
    }

    static T Minimum<T>(params T[] numbers)
    {
        dynamic min = numbers[0];
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static T Maximum<T>(params T[] numbers)
    {
        dynamic max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static T Avarage<T>(params T[] numbers)
    {
        dynamic avarage = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            avarage += numbers[i];
        }
        avarage /= numbers.Length;
        return avarage;
    }
    static T Sum<T>(params T[] numbers)
    {
        dynamic sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static T Product<T>(params T[] numbers)
    {
        dynamic product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}
