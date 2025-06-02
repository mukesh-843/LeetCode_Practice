// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Solution {
    public int[][] Merge(int[][] intervals) {
        int n = intervals.Length;
        if (n == 0) return new int[0][];

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> ans = new List<int[]>();

        for (int i = 0; i < n; i++) {
            int start = intervals[i][0];
            int end = intervals[i][1];

            while (i + 1 < n && intervals[i + 1][0] <= end) {
                i++;
                end = Math.Max(end, intervals[i][1]);
            }

            ans.Add(new int[] { start, end });
        }

        return ans.ToArray();
    }
}
