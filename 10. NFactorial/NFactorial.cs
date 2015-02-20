//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int[] arr = new int[100];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }
        int n = 10;

        Console.WriteLine(Factorial(arr, n));
    }

    static BigInteger Factorial(int[] arr, int n)
    {
        BigInteger result = 1;
        for (int i = 0; i < n; i++)
        {
            result *= arr[i];
        }
        return result;
    }
}