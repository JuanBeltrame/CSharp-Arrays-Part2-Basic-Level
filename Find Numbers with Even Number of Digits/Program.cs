/*
One-Dimensional Array 
----------------------------------------------------------------------
English:
Given an array nums of integers, return how many of them contain an even number of digits.

LINK: https://leetcode.com/problems/find-numbers-with-even-number-of-digits/description/
----------------------------------------------------------------------
*/

using System.Runtime.InteropServices;

static int FindNumbers(int[] nums)
{
    int capacity = nums.Length;
    int counter = default;
    for (int i = 0; i < capacity; i++)
    {
        if (nums[i].ToString().Length % 2 == 0)
            counter += 1;
    }

    return counter;
}

Random rn = new();
int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rn.Next(1,10000);
    System.Console.Write($" {array[i]} ");
}
System.Console.WriteLine();
System.Console.WriteLine($"La cantidad de numeros pares fueron: {FindNumbers(array)}");




