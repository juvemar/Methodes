//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.Write("Enter array's length: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter {0} number(s) to array:", n);
        int[] nums = new int[n];
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("nums[{0}]->", i);
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nEnter start index: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("The maximal element in a portion of the array is {0}",FindMaxElementInPortion(start,end,nums));
        Console.WriteLine("The array in ascending order: " + string.Join(", ", AscendingOrder(nums)));
        Console.WriteLine("The array in descending order: " + string.Join(", ", DescendingOrder(nums)));
    }

    static int FindMaxElementInPortion(int start, int end, int[] nums)
    {
        int maxEl = 0;
        for (int i = start; i <= end; i++)
        {
            if (maxEl < nums[i])
            {
                maxEl = nums[i];
            }
        }
        return maxEl;
    }

    static int[] AscendingOrder(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        return nums;
    }

    static int[] DescendingOrder(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        return nums;
    }


}