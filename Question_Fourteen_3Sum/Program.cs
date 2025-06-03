public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums); // Step 1: Sort the array
        List<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++) {
            // Skip duplicate elements for the first element of the triplet
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum < 0) {
                    left++;
                } else if (sum > 0) {
                    right--;
                } else {
                    // Found a valid triplet
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Skip duplicate values for left and right
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                }
            }
        }

        return result;
    }
}
