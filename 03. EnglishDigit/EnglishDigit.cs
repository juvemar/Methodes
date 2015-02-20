//Write a method that returns the last digit of given integer as an English word.

using System;
class EnglishDigit
{
    static void Main()
    {
        Console.Write("Write an integer: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit is {0}.", EnglishWord(number));
    }

    static string EnglishWord(int number)
    {
        string last;
        string numStr = number.ToString();
        switch (numStr[numStr.Length - 1])
        {
            case '0': last = "zero"; break;
            case '1': last = "one"; break;
            case '2': last = "two"; break;
            case '3': last = "three"; break;
            case '4': last = "four"; break;
            case '5': last = "five"; break;
            case '6': last = "six"; break;
            case '7': last = "seven"; break;
            case '8': last = "eight"; break;
            case '9': last = "nine"; break;
            default: last = "There are no digits"; break;
        }
        return last;
    }
}