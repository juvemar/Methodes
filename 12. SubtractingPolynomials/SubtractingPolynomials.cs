//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Linq;
class AddingPolynomials
{
    static void Main()
    {
        int[] arr1 = { 5, 0, 1 };
        int[] arr2 = { 2, 5, 0 };

        PrintPolynomials(arr1);
        PrintPolynomials(arr2);
        Console.WriteLine("The result of the adding is: ");
        AddPolynomials(arr1, arr2);
        Subtracting(arr1, arr2);
        Multiplying(arr1, arr2);
    }

    static void AddPolynomials(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] + arr2[i];
        }
        PrintPolynomials(result);
    }
    static void Subtracting(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] - arr2[i];
        }
        PrintPolynomials(result);
    }
    static void Multiplying(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] * arr2[i];
        }
        PrintPolynomials(result);
    }
    static void PrintPolynomials(int[] array)
    {
        int power = array.Length - 1;
        if (array[array.Length - 1] == 0)
        {
            array = array.Where(r => r != array[array.Length - 1]).ToArray();
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                Console.Write("{1}x{0}", power, array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(" + ");
                }
                power--;
            }
            else power--;
        }
        Console.WriteLine();
    }
}