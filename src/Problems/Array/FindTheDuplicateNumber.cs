﻿namespace Problems.Array;

/// <summary>
/// Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.
/// There is only one repeated number in nums, return this repeated number.
/// You must solve the problem without modifying the array nums and uses only constant extra space.
/// </summary>

/// <example>
/// Input: nums = [1,3,4,2,2]
/// Output: 2
/// </example>

public class FindTheDuplicateNumber
{
    public int Solution(int[] nums)
    {
        var slow = nums[0];
        var fast = nums[0];
        while (true)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
            if (slow == fast)
                break;
        }

        slow = nums[0];
        while (slow != fast)
            (slow, fast) = (nums[slow], nums[fast]);

        return slow;
    }
}