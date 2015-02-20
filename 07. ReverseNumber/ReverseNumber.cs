//Write a method that reverses the digits of given decimal number.
//Example:

//input 	output
//256	    652
//123.45	54.321

using System;
using System.Linq;
class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine(Reverse(number));
    }

    static char[] Reverse(decimal number)
    {
        char[] array = number.ToString().ToCharArray();
        char[] newArr = array.Reverse().ToArray();
        return newArr;
    }
}
