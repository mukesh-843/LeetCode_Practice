using System;
using System.Collections.Generic;
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        // Return 0 if array is null or has less than 2 prices
        if (prices == null || prices.Length < 2)
        {
            return 0;
        }

        int min_price = prices[0];   // Store the lowest price seen so far
        int max_profit = 0;          // Store the maximum profit found so far

        // Loop through prices starting from second day
        for (int i = 1; i < prices.Length; i++)
        {
            // If current price is lower than min_price, update min_price
            if (prices[i] < min_price)
            {
                min_price = prices[i];
            }
            else
            {
                // Calculate profit if we sell today
                int profit = prices[i] - min_price;

                // Update max_profit if this profit is greater
                if (profit > max_profit)
                {
                    max_profit = profit;
                }
            }
        }

        return max_profit; // Return the best profit found
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        int[] prices = { 7, 1, 5, 3, 6, 4 }; // Example input

        int result = sol.MaxProfit(prices); // Call the method

        Console.WriteLine("Maximum Profit: " + result); // Output result
    }
}
