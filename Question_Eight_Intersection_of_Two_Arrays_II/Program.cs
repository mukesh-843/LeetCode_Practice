public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var counts = new Dictionary<int, int>();
        var result = new List<int>();

        
        foreach (int num in nums1) {
            if (counts.ContainsKey(num))
                counts[num]++;
            else
                counts[num] = 1;
        }

       
        foreach (int num in nums2) {
            if (counts.ContainsKey(num) && counts[num] > 0) {
                result.Add(num);
                counts[num]--;
            }
        }

        return result.ToArray();
    }
}