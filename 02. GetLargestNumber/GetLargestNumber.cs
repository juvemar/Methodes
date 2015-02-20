//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Write first integer: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Write second integer: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Write third integer: ");
        int z = int.Parse(Console.ReadLine());

        Console.WriteLine("The biggest number is " + GetMax(GetMax(x,y),z));
    }

    static int GetMax(int n, int m)
    {
        if (n > m)
        {
            return n;
        }
        else return m;
    }
}