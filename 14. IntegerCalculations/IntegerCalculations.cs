//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        Console.Write("Enter integers: ");
        int[] numbers = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

        Console.WriteLine("Minimum is {0}.", Minimum(numbers));
        Console.WriteLine("Maximum is {0}.", Maximum(numbers));
        Console.WriteLine("Avarage is {0}.", Avarage(numbers));
        Console.WriteLine("Sum is {0}.", Sum(numbers));
        Console.WriteLine("Product is {0}.", Product(numbers));
    }

    static int Minimum(int[] numbers)
    {
        int min = numbers[0];
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static int Maximum(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static double Avarage(int[] numbers)
    {
        double avarage = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
                avarage += (double)numbers[i];
        }
        avarage /= numbers.Length;
        return avarage;
    }
    static int Sum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static int Product(int[] numbers)
    {
        int product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}
