public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        //brute force

        // for(int i = 0; i < nums.Length-1; i++){
            
        //     for(int j = i + 1; j < nums.Length; j++){
        //         if(nums[i] == nums[j]){
        //         return true;
        //         }
        //     }

        // }
        // return false;

        //     Array.Sort(nums);

        //     for(int i = 1; i < nums.Length; i++){

        //         if(nums[i] == nums[i-1]){
        //             return true;
        //         }

        //     }

        // return false;


        HashSet<int> seen = new HashSet <int>();

        foreach(int num in nums){
            if(seen.Contains(num))  return true;
            seen.Add(num);

            }

            return false;
        }
    }