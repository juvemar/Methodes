//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit;
//the last digit is kept in arr[0]).Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Linq;
using System.Numerics;

class NumberAsArray
{
    static void Main()
    {
        BigInteger[] first = new BigInteger[5];
        BigInteger[] second = new BigInteger[5];

        first[0] = 1;
        first[1] = 2;
        first[2] = 3;
        first[3] = 4;
        second[0] = 5;
        second[1] = 6;
        second[2] = 7;
        second[3] = 8;

        Console.WriteLine(string.Join("", Sum(first, second)));
    }

    static BigInteger[] Sum(BigInteger[] first, BigInteger[] second)
    {
        BigInteger[] result = new BigInteger[first.Length + 1];

        int i = first.Length - 1;
        int j = 0;
        while (i >= 0)
        {
            result[j] += (first[i] + second[i]) % 10;
            if ((first[i] + second[i]) > 9)
            {
                result[j + 1] = 1;
            }
            else result[j + 1] = 0;
            i--;
            j++;

        }
        if (result[result.Length - 1] == 0)
        {
            result = result.Where(r => r != result[result.Length - 1]).ToArray();
        }
        return result;
    }
}
