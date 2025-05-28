public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

    Dictionary<int, int> dict = new Dictionary<int, int>();

        for(int i = 0; i < numbers.Length; i++){
            int diff_target = target - numbers[i];

            if(dict.ContainsKey(diff_target)){
                return new int[] {dict[diff_target]+1, i+1};
            }

            if(!dict.ContainsKey(numbers[i])){
                dict[numbers[i]] = i;
            }

        }

        return new int[0];
    }
}