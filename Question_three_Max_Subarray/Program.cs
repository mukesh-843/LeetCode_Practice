using System;

public class Solution {
    public int MaxSubArray(int[] nums) {

        // Kadane's Algorithm is used here
        // Key Points:
        // 1. At each index, decide whether to extend the current subarray or start a new one
        // 2. Track the maximum subarray sum seen so far
        // 3. Time Complexity: O(n), Space Complexity: O(1)

        // Edge case: if input is null or empty, return 0
        if (nums == null || nums.Length == 0) {
            return 0;
        }

        // Initialize both max_sum and current_sum with the first element
        int max_sum = nums[0];
        int current_sum = nums[0];

        // Iterate through the array starting from the second element
        for (int i = 1; i < nums.Length; i++) {
            // Choose maximum between current element or current_sum + element
            current_sum = Math.Max(nums[i], current_sum + nums[i]);

            // Update max_sum if a new maximum is found
            max_sum = Math.Max(max_sum, current_sum);
        }

        // Return the maximum subarray sum found
        return max_sum;
    }
}

class Program {
    static void Main(string[] args) {
        Solution solution = new Solution();

        //test cases
        int[] nums1 = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        Console.WriteLine("Max Sum: " + solution.MaxSubArray(nums1)); // Output: 6

        int[] nums2 = {1};
        Console.WriteLine("Max Sum: " + solution.MaxSubArray(nums2)); // Output: 1

        int[] nums3 = {5, 4, -1, 7, 8};
        Console.WriteLine("Max Sum: " + solution.MaxSubArray(nums3)); // Output: 23
    }
}
