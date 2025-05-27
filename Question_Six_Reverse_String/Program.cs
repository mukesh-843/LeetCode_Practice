using System;

public class Solution {
    public void ReverseString(char[] s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            // Swap the characters
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
        }
    }
}

class Program {
    static void Main(string[] args) {
        char[] input = { 'h', 'e', 'l', 'l', 'o' };

        Console.WriteLine("Original: " + new string(input));

        Solution solution = new Solution();
        solution.ReverseString(input);

        Console.WriteLine("Reversed: " + new string(input));
    }
}
