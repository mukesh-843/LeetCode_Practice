using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Sample test cases
        string[] testCases = new string[]
        {
            "A man, a plan, a canal: Panama",   // Expected: True
            "race a car",                       // Expected: False
            " ",                                // Expected: True
            "No lemon, no melon",               // Expected: True
            "Was it a car or a cat I saw?",     // Expected: True
            "Not a palindrome",                 // Expected: False
            "12321",                            // Expected: True
            "1231",                             // Expected: False
            "Able was I ere I saw Elba",        // Expected: True
        };

        foreach (var test in testCases)
        {
            bool result = solution.IsPalindrome(test);
            Console.WriteLine($"Input: \"{test}\" → IsPalindrome: {result}");
        }
    }
}

public class Solution
{
    /// <summary>
    /// Checks whether a string is a valid palindrome, considering only alphanumeric characters and ignoring cases.
    /// 
    /// Approach: Two-pointer technique.
    /// - Skip non-alphanumeric characters.
    /// - Compare characters from both ends moving toward the center.
    /// 
    /// Time Complexity: O(n)  → where n = length of the string
    /// Space Complexity: O(1) → no extra space used (in-place comparison)
    /// 
    /// Alternative Approaches:
    /// 1. Clean string and reverse it, then compare (Space: O(n))
    /// 2. Use StringBuilder or Regex to preprocess string
    /// 3. Brute-force: slow string concatenation and reverse (Time: O(n²), Space: O(n))
    /// </summary>
    /// <param name="s">Input string to check for palindrome</param>
    /// <returns>True if the cleaned string is a palindrome, otherwise False</returns>
    public bool IsPalindrome(string s)
    {
        // Edge case: if the string is null or empty, consider it a valid palindrome
        if (string.IsNullOrEmpty(s)) return true;

        int left = 0;
        int right = s.Length - 1;

        // Continue checking until pointers meet
        while (left < right)
        {
            // Move left pointer to the right if current character is not alphanumeric
            while (left < right && !Char.IsLetterOrDigit(s[left])) left++;

            // Move right pointer to the left if current character is not alphanumeric
            while (left < right && !Char.IsLetterOrDigit(s[right])) right--;

            // Compare characters (case-insensitive)
            if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                return false;

            // Move both pointers toward the center
            left++;
            right--;
        }

        // All characters matched
        return true;
    }
}
