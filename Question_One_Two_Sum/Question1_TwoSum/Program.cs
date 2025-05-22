using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Brute-force approach (Time Complexity: O(n^2))
        // for(int i = 0; i < nums.Length - 1; i++) {
        //     for(int j = i + 1; j < nums.Length; j++) {
        //         if(nums[i] + nums[j] == target) {
        //             return new int[] {i, j};
        //         }
        //     }
        // }

        // Optimized approach using a hash map (Time Complexity: O(n))
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }

        // If no solution is found (though question guarantees one)
        return new int[0];
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        Solution solution = new Solution();
        int[] result = solution.TwoSum(nums, target);

        Console.WriteLine("[" + result[0] + ", " + result[1] + "]");
    }
}
