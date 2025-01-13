/*
One-Dimensional Array 
----------------------------------------------------------------------
English:
Given a binary array nums, return the maximum number of consecutive 1's in the array.

LINK: https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3238/
----------------------------------------------------------------------
*/

using System.Runtime.Versioning;

static int FindMaxConsecutiveOnes(int[] nums)
{
    int capacity = nums.Length;
    int oneCounter = default;
    int maxValue = default;
    int returnToZero = 0;

    for (int i = 0; i < capacity; i++)
    {
        if (nums[i] is 1)
        {
            oneCounter += 1;
            if (oneCounter >= maxValue)
                maxValue = oneCounter;
        }
        else
            oneCounter = returnToZero;
    }
    return maxValue;
}

int[] array = new int[8];
array = [1,1,0,0,0,1,1,1];
int result;

result = FindMaxConsecutiveOnes(array);
System.Console.WriteLine($"Max Consecutive Ones: {result}");

