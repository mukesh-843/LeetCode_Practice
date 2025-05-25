using System;

public class Solution {
    /*
        Problem: Move Zeroes - 

        Move all 0's to the end of the array while maintaining the relative order
        of the non-zero elements.
    */
    public void MoveZeroes(int[] nums) {
        int insert_ps = 0; // Pointer to insert the next non-zero

        // First pass: Move all non-zero elements to the front
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[insert_ps] = nums[i];
                insert_ps++;
            }
        }

        // Second pass: Fill the remaining elements with 0
        
        for (int i = insert_ps; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }

    //Entry point for testing the solution
    
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        //Test case
        
        int[] testArray = { 0, 1, 0, 3, 12 };

        Console.WriteLine("Before:");
        Console.WriteLine(string.Join(", ", testArray));

        sol.MoveZeroes(testArray);

        Console.WriteLine("After:");
        Console.WriteLine(string.Join(", ", testArray));
    }
}
