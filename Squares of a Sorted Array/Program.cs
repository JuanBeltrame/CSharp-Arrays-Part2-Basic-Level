/*
One-Dimensional Array 
----------------------------------------------------------------------
English:
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

LINK: https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3240/
----------------------------------------------------------------------
*/

static int[] SortedSquares(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = nums[i] * nums[i];
    }
    for (int j = 0; j < (nums.Length - 1); j++)
    {
        for (int k = j + 1; k < nums.Length; k++)
        {
            if (nums[j] > nums[k])
            {
                int aux = nums[j];
                nums[j] = nums[k];
                nums[k] = aux;
            }
        }
    }

    return nums;
}

int[] nums = [-4, -1, 0, 3, 10];
int[] result = SortedSquares(nums);
for (int i = 0; i < result.Length; i++)
    Console.Write($" {result[i]} ");