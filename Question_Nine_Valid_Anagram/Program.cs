public class Solution {
    public bool IsAnagram(string s, string t) {
        
        // //base case if length of both strings are same then we will go forward, if not then no need to cgo further
        // if(s.Length != t.Length){
        //     return false;
        // }

        // char[] s_arr = s.ToCharArray();
        // char[] t_arr = t.ToCharArray();

        // Array.Sort(s_arr);
        // Array.Sort(t_arr);

        // //Comparison

        // if(s_arr.SequenceEqual(t_arr)){
        //     return true;
        // }

        // else {
        //     return false;
        // }



        // //Time complexity:  nlogn and space complexity: O(n)




        //we can do with better apporach which is counting frequency, so  O(n);

        if(s.Length != t.Length){
            return false;
        }

        int[] counts = new int[26];

        for(int i = 0; i < s.Length; i++){
                counts[s[i] - 'a']++;
        }

        for(int i = 0; i < t.Length; i++){
            counts[t[i] - 'a']--;
        }

        foreach(int count in counts){
            if(count != 0){
                return false;
            }
            
        }

        return true;

    }
}